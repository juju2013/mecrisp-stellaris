// ----------------------------------------------------------------------------
// Second stage boot code
// Copyright (c) 2019 Raspberry Pi (Trading) Ltd.
// Licensed under original LICENSE-PICO.TXT
//
// Device:      Winbond W25Q080
//              Also supports W25Q16JV (which has some different SR instructions)
//              Also supports AT25SF081
//              Also supports S25FL132K0
//
// Description: Configures W25Q080 to run in Quad I/O continuous read XIP mode
//
// Details:     * Check status register 2 to determine if QSPI mode is enabled,
//                and perform an SR2 programming cycle if necessary.
//              * Use SSI to perform a dummy 0xEB read command, with the mode
//                continuation bits set, so that the flash will not require
//                0xEB instruction prefix on subsequent reads.
//              * Configure SSI to write address, mode bits, but no instruction.
//                SSI + flash are now jointly in a state where continuous reads
//                can take place.
//              * Jump to exit pointer passed in via lr. Bootrom passes null,
//                in which case this code uses a default 256 byte flash offset
//
// Building:    * This code must be position-independent, and use stack only
//              * The code will be padded to a size of 256 bytes, including a
//                4-byte checksum. Therefore code size cannot exceed 252 bytes.
// ----------------------------------------------------------------------------

// ----------------------------------------------------------------------------
// Config section
// ----------------------------------------------------------------------------
// It should be possible to support most flash devices by modifying this section

// The serial flash interface will run at clk_sys/PICO_FLASH_SPI_CLKDIV.
// This must be a positive, even integer.
// The bootrom is very conservative with SPI frequency, but here we should be
// as aggressive as possible.
.equ PICO_FLASH_SPI_CLKDIV, 4

// Define interface width: single/dual/quad IO
.equ FRAME_FORMAT, 0x2

// For W25Q080 this is the "Read data fast quad IO" instruction:
.equ CMD_READ, 0xeb

// "Mode bits" are 8 special bits sent immediately after
// the address bits in a "Read Data Fast Quad I/O" command sequence. 
// On W25Q080, the four LSBs are don't care, and if MSBs == 0xa, the
// next read does not require the 0xeb instruction prefix.
.equ MODE_CONTINUOUS_READ, 0xa0

// The number of address + mode bits, divided by 4 (always 4, not function of
// interface width).
.equ ADDR_L, 8

// How many clocks of Hi-Z following the mode bits. For W25Q080, 4 dummy cycles
// are required.
.equ WAIT_CYCLES, 4

// If defined, we will read status reg, compare to SREG_DATA, and overwrite
// with our value if the SR doesn't match.
// We do a two-byte write to SR1 (01h cmd) rather than a one-byte write to
// SR2 (31h cmd) as the latter command isn't supported by WX25Q080.
// This isn't great because it will remove block protections.
// A better solution is to use a volatile SR write if your device supports it.
#define PROGRAM_STATUS_REG

.equ CMD_WRITE_ENABLE   ,0x06
.equ CMD_READ_STATUS    ,0x05
.equ CMD_READ_STATUS2   ,0x35
.equ CMD_WRITE_STATUS   ,0x01
.equ SREG_DATA          ,0x02  // Enable quad-SPI mode

@------------------------------------------------------------------------------
@ Constants from compiled SDK rp2_common/boot_stage2/bs2_default.dis
@------------------------------------------------------------------------------
  .equ PADS_QSPI_BASE                         , 0x40020000
  .equ PADS_QSPI_GPIO_QSPI_SCLK_OFFSET        , 0x4
  .equ PADS_QSPI_GPIO_QSPI_SD0_OFFSET         , 0x8
  .equ PADS_QSPI_GPIO_QSPI_SD0_SCHMITT_BITS   , 0x2
  .equ PADS_QSPI_GPIO_QSPI_SD0_OFFSET         , 8
  .equ PADS_QSPI_GPIO_QSPI_SD1_OFFSET         , 12
  .equ PADS_QSPI_GPIO_QSPI_SD2_OFFSET         , 16
  .equ PADS_QSPI_GPIO_QSPI_SD3_OFFSET         , 20
  .equ XIP_SSI_BASE                           , 0x18000000
  .equ SSI_SSIENR_OFFSET                      , 8
  .equ PICO_FLASH_SPI_CLKDIV                  , 2
  .equ SSI_BAUDR_OFFSET                       , 20
  .equ SSI_RX_SAMPLE_DLY_OFFSET               , 0xf0
  .equ CTRL0_SPI_TXRX                         , 0x00070000
  .equ SSI_CTRLR0_OFFSET                      , 0
  .equ SSI_DR0_OFFSET                         , 0x60
  .equ SSI_CTRLR1_OFFSET                      , 4
  .equ SSI_SR_OFFSET                          , 0x28
  .equ SSI_SR_TFE_BITS                        , 4
  .equ SSI_SR_BUSY_BITS                       , 1
  .equ CTRLR0_ENTER_XIP                       , 0x005f0300
  .equ SPI_CTRLR0_ENTER_XIP                   , 0x00002221
  .equ SPI_CTRL0                              , 0x180000f4
  .equ SPI_CTRLR0_XIP                         , 0xa0002022

  .equ XIP_BASE                               , . @ This is the start of flash

// ----------------------------------------------------------------------------
// Start of 2nd Stage Boot Code
// ----------------------------------------------------------------------------

.syntax unified
.cpu cortex-m0plus
.thumb

.section .text

// The exit point is passed in lr. If entered from bootrom, this will be the
// flash address immediately following this second stage (0x10000100).
// Otherwise it will be a return address -- second stage being called as a
// function by user code, after copying out of XIP region. r3 holds SSI base,
// r0...2 used as temporaries. Other GPRs not used.
.global _stage2_boot
_stage2_boot:
    push {lr}

    // Set pad configuration:
    // - SCLK 8mA drive, no slew limiting
    // - SDx disable input Schmitt to reduce delay

    ldr r3, =PADS_QSPI_BASE
    movs r0, #0x21
    str r0, [r3, #PADS_QSPI_GPIO_QSPI_SCLK_OFFSET]
    ldr r0, [r3, #PADS_QSPI_GPIO_QSPI_SD0_OFFSET]
    movs r1, #PADS_QSPI_GPIO_QSPI_SD0_SCHMITT_BITS
    bics r0, r1
    str r0, [r3, #PADS_QSPI_GPIO_QSPI_SD0_OFFSET]
    str r0, [r3, #PADS_QSPI_GPIO_QSPI_SD1_OFFSET]
    str r0, [r3, #PADS_QSPI_GPIO_QSPI_SD2_OFFSET]
    str r0, [r3, #PADS_QSPI_GPIO_QSPI_SD3_OFFSET]

    ldr r3, =XIP_SSI_BASE

    // Disable SSI to allow further config
    movs r1, #0
    str r1, [r3, #SSI_SSIENR_OFFSET]

    // Set baud rate
    movs r1, #PICO_FLASH_SPI_CLKDIV
    str r1, [r3, #SSI_BAUDR_OFFSET]

    // Set 1-cycle sample delay. If PICO_FLASH_SPI_CLKDIV == 2 then this means,
    // if the flash launches data on SCLK posedge, we capture it at the time that
    // the next SCLK posedge is launched. This is shortly before that posedge
    // arrives at the flash, so data hold time should be ok. For
    // PICO_FLASH_SPI_CLKDIV > 2 this pretty much has no effect.

    movs r1, #1
    movs r2, #SSI_RX_SAMPLE_DLY_OFFSET  // == 0xf0 so need 8 bits of offset significance
    str r1, [r3, r2]


// On QSPI parts we usually need a 01h SR-write command to enable QSPI mode
// (i.e. turn WPn and HOLDn into IO2/IO3)
#ifdef PROGRAM_STATUS_REG
program_sregs:

    ldr r1, =(CTRL0_SPI_TXRX)
    str r1, [r3, #SSI_CTRLR0_OFFSET]

     // Enable SSI and select slave 0
    movs r1, #1
    str r1, [r3, #SSI_SSIENR_OFFSET]

    // Check whether SR needs updating
    movs r0, #CMD_READ_STATUS2
    bl read_flash_sreg
    movs r2, #SREG_DATA
    cmp r0, r2
    beq skip_sreg_programming

    // Send write enable command
    movs r1, #CMD_WRITE_ENABLE
    str r1, [r3, #SSI_DR0_OFFSET]

    // Poll for completion and discard RX
    bl wait_ssi_ready
    ldr r1, [r3, #SSI_DR0_OFFSET]

    // Send status write command followed by data bytes
    movs r1, #CMD_WRITE_STATUS
    str r1, [r3, #SSI_DR0_OFFSET]
    movs r0, #0
    str r0, [r3, #SSI_DR0_OFFSET]
    str r2, [r3, #SSI_DR0_OFFSET]

    bl wait_ssi_ready
    ldr r1, [r3, #SSI_DR0_OFFSET]
    ldr r1, [r3, #SSI_DR0_OFFSET]
    ldr r1, [r3, #SSI_DR0_OFFSET]

    // Poll status register for write completion
1:
    movs r0, #CMD_READ_STATUS
    bl read_flash_sreg
    movs r1, #1
    tst r0, r1
    bne 1b

skip_sreg_programming:

    // Disable SSI again so that it can be reconfigured
    movs r1, #0
    str r1, [r3, #SSI_SSIENR_OFFSET]
#endif

// Currently the flash expects an 8 bit serial command prefix on every
// transfer, which is a waste of cycles. Perform a dummy Fast Read Quad I/O
// command, with mode bits set such that the flash will not expect a serial
// command prefix on *subsequent* transfers. We don't care about the results
// of the read, the important part is the mode bits.

dummy_read:

    ldr r1, =(CTRLR0_ENTER_XIP)
    str r1, [r3, #SSI_CTRLR0_OFFSET]

    movs r1, #0x0                    // NDF=0 (single 32b read)
    str r1, [r3, #SSI_CTRLR1_OFFSET]

    ldr r1, =(SPI_CTRLR0_ENTER_XIP)
    ldr r0, =SPI_CTRL0  // SPI_CTRL0 Register
    str r1, [r0]

    movs r1, #1                      // Re-enable SSI
    str r1, [r3, #SSI_SSIENR_OFFSET]

    movs r1, #CMD_READ
    str r1, [r3, #SSI_DR0_OFFSET]   // Push SPI command into TX FIFO
    movs r1, #MODE_CONTINUOUS_READ   // 32-bit: 24 address bits (we don't care, so 0) and M[7:4]=1010
    str r1, [r3, #SSI_DR0_OFFSET]   // Push Address into TX FIFO - this will trigger the transaction

    // Poll for completion
    bl wait_ssi_ready

// The flash is in a state where we can blast addresses in parallel, and get
// parallel data back. Now configure the SSI to translate XIP bus accesses
// into QSPI transfers of this form.

    movs r1, #0
    str r1, [r3, #SSI_SSIENR_OFFSET]   // Disable SSI (and clear FIFO) to allow further config

// Note that the INST_L field is used to select what XIP data gets pushed into
// the TX FIFO:
//      INST_L_0_BITS   {ADDR[23:0],XIP_CMD[7:0]}       Load "mode bits" into XIP_CMD
//      Anything else   {XIP_CMD[7:0],ADDR[23:0]}       Load SPI command into XIP_CMD
configure_ssi:

    ldr r1, =(SPI_CTRLR0_XIP)
    ldr r0, =SPI_CTRL0
    str r1, [r0]

    movs r1, #1
    str r1, [r3, #SSI_SSIENR_OFFSET]   // Re-enable SSI

// Bus accesses to the XIP window will now be transparently serviced by the
// external flash on cache miss. We are ready to run code from flash.

soft_reset:
    // Jump to exit point provided in lr. Bootrom will pass null, in which
    // case we use default exit target at a 256 byte offset into XIP region
    // (immediately after this second stage's flash location)
    pop {r0}
    cmp r0, #0
    bne 1f
    ldr r0, =(XIP_BASE + 0x101)
1:
    bx r0

// Common functions

wait_ssi_ready:
    push {r0, r1, lr}

    // Command is complete when there is nothing left to send
    // (TX FIFO empty) and SSI is no longer busy (CSn deasserted)
1:
    ldr r1, [r3, #SSI_SR_OFFSET]
    movs r0, #SSI_SR_TFE_BITS
    tst r1, r0
    beq 1b
    movs r0, #SSI_SR_BUSY_BITS
    tst r1, r0
    bne 1b

    pop {r0, r1, pc}

#ifdef PROGRAM_STATUS_REG
// Pass status read cmd into r0.
// Returns status value in r0.
.global read_flash_sreg
.type read_flash_sreg,%function
.thumb_func
read_flash_sreg:
    push {r1, lr}
    str r0, [r3, #SSI_DR0_OFFSET]
    // Dummy byte:
    str r0, [r3, #SSI_DR0_OFFSET]
    
    bl wait_ssi_ready
    // Discard first byte and combine the next two
    ldr r0, [r3, #SSI_DR0_OFFSET]
    ldr r0, [r3, #SSI_DR0_OFFSET]

    pop {r1, pc}
#endif

// ----------------------------------------------------------------------------
// Literal Table
// ----------------------------------------------------------------------------

literals:
.ltorg

@ -----------------------------------------------------------------------------
@ flash checksum
@ -----------------------------------------------------------------------------
.org 0x100-4
.global _flash_crc32
_flash_crc32: .word FLASHCRC32 @ crc32 
@ as we respect PICO's C SDK convention with next hop at +0x100, the CRC32 will
@ remain the same "0x602a273e". Anyway, there's a crc32 helper in cas of...
