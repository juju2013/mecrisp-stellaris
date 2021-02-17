@
@    Mecrisp-Stellaris - A native code Forth implementation for ARM-Cortex M microcontrollers
@    Copyright (C) 2013  Matthias Koch
@@    Copyright (C) 2017,2018  juju2013@github

@    This program is free software: you can redistribute it and/or modify
@    it under the terms of the GNU General Public License as published by
@    the Free Software Foundation, either version 3 of the License, or
@    (at your option) any later version.
@
@    This program is distributed in the hope that it will be useful,
@    but WITHOUT ANY WARRANTY; without even the implied warranty of
@    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
@    GNU General Public License for more details.
@
@    You should have received a copy of the GNU General Public License
@    along with this program.  If not, see <http://www.gnu.org/licenses/>.
@

.syntax unified
.cpu cortex-m0
.thumb
 
@ -----------------------------------------------------------------------------
@ Swiches for capabilities of this chip
@ -----------------------------------------------------------------------------
.equ m0core, 2
@ Not available: .equ charkommaavailable, 1

@ -----------------------------------------------------------------------------
@ Start with some essential macro definitions
@ -----------------------------------------------------------------------------
.include "../common/datastackandmacros.s"

@ -----------------------------------------------------------------------------
@ Speicherkarte für Flash und RAM
@ Memory map for Flash and RAM
@ -----------------------------------------------------------------------------

@ Constants for the size of the RAM memory

.equ RamAnfang, 0x20000000 @ Start of RAM           Porting: Change this !
@.equ RamEnde,  0x20008000 @ End   of RAM.  256 kb. Porting: Change this !
.equ RamEnde,   0x20008000 @ End   of RAM.  Only allocate first 32 kb, think SMP ...

@ Constants for the size and layout of the flash memory

.equ Kernschutzadresse,     0x10004000 @ Darunter wird niemals etwas geschrieben ! Mecrisp core never writes flash below this address.
.equ FlashDictionaryAnfang, 0x10004000 @  16 kb für den Kern reserviert...            16 kb Flash reserved for core.
.equ FlashDictionaryEnde,   0x10020000 @  128kb Platz für das Flash-Dictionary   use only 128Kb flash
.equ Backlinkgrenze,        RamAnfang  @ Ab dem Ram-Start.

.text    @ Hier beginnt das Vergnügen mit der Stackadresse und der Einsprungadresse
@ -----------------------------------------------------------------------------
@ Anfang im Flash
@ Flash start
@
@ RP2040 don't have internal flash, but an on silicone bootrom @ 0x0. It will try
@ to boot, among other things, from an unspecific external flash.
@ On the flash, the first 252 bytes + 4 bytes CRC32 is the stage2 boot
@ it's chip dependant and it's job is to setup a faster flash access with XIP cache.
@ At the end of stage2, as per convention like PICO's C SDK, we'll branch to 0x10000100
@ which in turn wil setup the "real" interrupt vetor table at 0x10000200 following 
@ by the Reset code  which we'll branch to
@ -----------------------------------------------------------------------------
.include "boot2_w25q080.S"  @ Flash chip vendor dependant, this is for the PICO board

@ -----------------------------------------------------------------------------
@ RP2040 Power & clock
@ -----------------------------------------------------------------------------
    .equ SIO_BASE       , 0xd0000000
    .equ CPUID          , 0                   @ Processor core identifier
    
    .equ vtor_register  , 0xe000ed08          @ VTOR Register

    .equ CLOCKS_BASE    , 0x40008000          @ clocls base
    .equ CLR_PERI_CTRL  , CLOCKS_BASE+0x48    @ Clock control, can be changed on-the-fly (except for auxsrc)
    .equ CLOCK_UART     , BIT11               @ clock for UART
    
    .equ RESET_BASE     , 0x4000c000          @ reset control
    .equ RESET_DONE     , RESET_BASE+0x8      @ bit set after reset
    .equ RESET_UART0    , BIT22               @ UART0 Reset bit

    .equ GPIO_FUNC_XIP  , 0    @ GPIO bank defaults to USER bank, as QSPI is used by external flash
    .equ IO_BASE    , 0x40014000  @
    .equ GPIO_FUNC_SPI  , 1
    .equ GPIO_FUNC_UART , 2
    .equ GPIO_FUNC_I2C  , 3
    .equ GPIO_FUNC_PWM  , 4
    .equ GPIO_FUNC_SIO  , 5
    .equ GPIO_FUNC_PIO0 , 6
    .equ GPIO_FUNC_PIO1 , 7
    .equ GPIO_FUNC_GPCK , 8
    .equ GPIO_FUNC_USB  , 9
    .equ GPIO_FUNC_NULL , 0xf

    .equ  PADS_BASE     , 0x4001c000          @ for pads
    
    .equ CLK_BA     ,0x50000200
    .equ PWRCON     ,CLK_BA+0x00    @ R/W System Power-down Control Register 0x0000_001X 
    .equ AHBCLK     ,CLK_BA+0x04    @  R/W AHB Devices Clock Enable Control Register 0x0000_0004 
    .equ APBCLK     ,CLK_BA+0x08    @  R/W APB Devices Clock Enable Control Register 0x0000_000X 
    .equ CLKSTATUS  ,CLK_BA+0x0C    @  R/W Clock Status Monitor Register 0x0000_00XX 
    .equ CLKSEL0    ,CLK_BA+0x10    @  R/W Clock Source Select Control Register 0 0x0000_003X 
    .equ CLKSEL1    ,CLK_BA+0x14    @  R/W Clock Source Select Control Register 1 0xFFFF_FFFF 
    .equ CLKSEL2    ,CLK_BA+0x1C    @  R/W Clock Source Select Control Register 2 0x0002_00FF 
    .equ CLKDIV     ,CLK_BA+0x18    @  R/W Clock Divider Number Register 0x0000_0000 
    .equ PLLCON     ,CLK_BA+0x20    @  R/W PLL Control Register 0x0005_C22E 
    .equ FRQDIV     ,CLK_BA+0x24    @  R/W Frequency Divider Control Register 0x0000_0000 
    .equ APBDIV     ,CLK_BA+0x2C    @  R/W APB Divider Control Register 0x0000_0000

@ -----------------------------------------------------------------------------
@ RP2040 Atomic Register Access
@ -----------------------------------------------------------------------------
.macro register_bit_XOR register, bitmask
  ldr  r1, =#0x1000
  ldr  r2, =\register
  adds r2, r1  
  ldr  r3, =\bitmask
  str  r3, [r2]
.endm
.macro register_bit_set register, bitmask
  ldr  r1, =#0x2000
  ldr  r2, =\register
  adds r2, r1  
  ldr  r3, =\bitmask
  str  r3, [r2]
.endm
.macro register_bit_clear register, bitmask
  ldr  r1, =#0x3000
  ldr  r2, =\register
  adds r2, r1  
  ldr  r3, =\bitmask
  str  r3, [r2]
.endm

.org 0x100 @ stag2 boot will branch to here
@ -----------------------------------------------------------------------------
@ RP2040 Peripheral control
@ -----------------------------------------------------------------------------
.macro peripheral_reset peri
  register_bit_set   RESET_BASE, \peri    @ trigger the reset
  register_bit_clear RESET_BASE, \peri    @ trigger the reset
  ldr  r3, =\peri
  ldr  r1, =RESET_DONE
1:
  ldr  r2, [r1]                         @ check done register
  ands r2, r3
  beq  1b                               @ not yet
.endm

@ -----------------------------------------------------------------------------
.global RP2040_init
RP2040_init:
@ -----------------------------------------------------------------------------
@ Setup our own vector table for NVIC
setup_vtor:
  nop
  ldr r0, =addresszero @ external flash adr via XIP
  ldr r1, =vtor_register @ VTOR register
  str r0, [r1]
  bl Reset

.ltorg

@ -----------------------------------------------------------------------------
@ Interrupt vector table
@ -----------------------------------------------------------------------------
.include "vectors.s"      @ You have to change vectors for Porting !

@ -----------------------------------------------------------------------------
@ Include the Forth core of Mecrisp-Stellaris
@ -----------------------------------------------------------------------------
 
.include "../common/forth-core.s"

  
@ -----------------------------------------------------------------------------
.global Reset
Reset: @ Einsprung zu Beginn
@ -----------------------------------------------------------------------------
    nop

// Check if this is core 0, and go to holding pen if not
check_core:
    ldr r0, =SIO_BASE
    ldr r1, [r0, #CPUID]
    cmp r1, #0
    beq 2f

1: @ stop the core1
    wfi
    b 1b
    
2: @ we can start core 0
    
    @ Initialisierungen der Hardware, habe und brauche noch keinen Datenstack dafür
    @ Initialisations for Terminal hardware, without Datastack.
    bl uart_init

    @ Catch the pointers for Flash dictionary
    .include "../common/catchflashpointers.s"

    welcome " with M0 core by Matthias Koch"
    writeln "  modified for RP2040-PICO by juju2013"
    writeln ""

    @ Ready to fly ! 
    .include "../common/boot.s"



.ltorg
