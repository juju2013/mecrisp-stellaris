@
@    Mecrisp-Stellaris - A native code Forth implementation for ARM-Cortex M microcontrollers
@    Copyright (C) 2013  Matthias Koch
@    Copyright (C) 2021  juju2013@github

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

@ Terminalroutinen
@ Terminal code and initialisations.
@ Porting: Rewrite this !

    .equ UART_BASE  ,0x40034000     @ UART0
    .equ UARTDR     ,UART_BASE+0    @ Data Register, UARTDR
    .equ UARTRSR    ,UART_BASE+4    @ Receive Status Register/Error Clear Register, UARTRSR/UARTECR
    .equ UARTFR     ,UART_BASE+0x18 @ Flag Register
    .equ UARTIBRD   ,UART_BASE+0x24 @ Integer Baud Rate Register, UARTIBRD
    .equ UARTFBRD   ,UART_BASE+0x28 @ Fractional Baud Rate Register, UARTFBRD
    .equ UARTLCR_H  ,UART_BASE+0x2c @ Line Control Register, UARTLCR_H
    .equ UARTCR     ,UART_BASE+0x30 @ Control Register, UARTCR

    .equ SIO_BASE       , 0xd0000000
    .equ CPUID          , 0                   @ Processor core identifier
    
    .equ vtor_register  , 0xe000ed08          @ VTOR Register

    .equ CLOCKS_BASE    , 0x40008000          @ clocls base
    .equ CLR_PERI_CTRL  , CLOCKS_BASE+0x48    @ Clock control, can be changed on-the-fly (except for auxsrc)
    .equ CLK_REF_CTRL   , CLOCKS_BASE+0x30    @ Clock control, can be changed on-the-fly (except for auxsrc)
    .equ CLK_SYS_CTRL   , CLOCKS_BASE+0x3c    @ Clock control, can be changed on-the-fly (except for auxsrc)
    .equ CLK_SYS_RESUS_CTRL, CLOCKS_BASE+0x78 @ RESUS
    .equ CLOCK_UART     , BIT11               @ clock for UART
    .equ XOSC_BASE      , 0x40024000          @ XOSC base
    .equ XOSC_ENABLE    , 0x00fabaa0
    
    .equ PLL_SYS_BASE   , 0x40028000          @ PLL SYS
    .equ PLL_SYS_PWR    , PLL_SYS_BASE+0x4    @ PLL Power
    .equ PLL_SYS_FBDIV  , PLL_SYS_BASE+0x8    @ PLL Power
    .equ PLL_SYS_PRIM   , PLL_SYS_BASE+0xc    @ PLL Primary Post Divider
    
    .equ RESET_BASE     , 0x4000c000          @ reset control
    .equ RESET_DONE     , RESET_BASE+0x8      @ bit set after reset
    .equ RESET_UART0    , BIT22               @ UART0 Reset bit
    

@----- wait clock be selected, r1 is the clock's base address
clock_wait: 
1:  
  ldr   r2, [r1, #4]
  cmp   r2, #0
  beq   1b
  bx    lr

@ -----------------------------------------------------------------------------
pll_init:
@ -----------------------------------------------------------------------------
  push  {lr}
  
  @---- enable PLL
  peripheral_reset RESET_PLL

  ldr   r0, =0x1
  ldr   r1, =PLL_SYS_BASE
  str   r0, [r1]                @ divide by 1
  
  ldr   r0, =0x1f
  ldr   r1, =PLL_SYS_PWR
  str   r0, [r1]                @ power off
  
  str   r0, [r1]                @ Feedback divisor
  movs  r0, #0
  ldr   r1, =PLL_SYS_FBDIV
  movs  r0, #0x7d
  str   r0, [r1]                @ Feedback divisor
  
  register_bit_clear PLL_SYS_PWR, (BIT5+BIT3+BIT0)    @ power PLL ON
  
  ldr   r1, =PLL_SYS_BASE
  ldr   r2, =BIT31
1:
  ldr   r0, [r1]
  ands  r0, r2
  beq   1b                      @ wait PLL to lock
  
  ldr   r0, =0x62000
  ldr   r1, =PLL_SYS_PRIM
  str   r0, [r1]                @ post divid for 125mhz
  
  pop   {pc}
  
@ -----------------------------------------------------------------------------
.global clocks_init
clocks_init: @ Intialise PLL_SYS, CLK_REF, CLK_SYS
@ -----------------------------------------------------------------------------
.equ CLK_ENABLEBIT, 0x800
.equ RESET_PLL, BIT12

  push {lr}
  
  @--- call ROM enable_clocks
  ldrh r0, =0x14
  ldr  r1, =rom_enable_clocks
  ldrh r1, [r1]
  ldrh r2, [r0, #4]
  ldrh r0, [r0]
  blx  r2
  cmp  r0, #0
  beq  1f
  blx  r0
1:
  
  ldr  r1, =CLK_SYS_RESUS_CTRL  @ disable resus
  str  r0, [r1]

  @--- before changing auxsrc, free them from clocks 
  movs r0, #0
  ldr  r1, =CLK_REF_CTRL
  str  r0,[r1]
  bl   clock_wait
  ldr  r1, =CLK_SYS_CTRL
  str  r0,[r1]
  bl   clock_wait

  @ enable XOSC
  ldr  r0, =XOSC_BASE
  ldr  r1, =XOSC_ENABLE
  str  r1, [r0]

  bl   pll_init

  @---- set clk_ref
  ldr  r1, =CLK_REF_CTRL
  movs r0, #0
  str  r0, [r1]
  bl   clock_wait
  movs r0, #2                 @ use XOSC
  str  r0, [r1]
  bl   clock_wait
  ldr  r0,  =BIT8
  str  r0, [r1, #4]           @ divisor INT = 1

  @---- set clk_sys
  ldr  r1, =CLK_SYS_CTRL
  movs r0, #0
  str  r0, [r1]
  bl   clock_wait
  movs r0, #1                 @ aux src, pll_sys
  str  r0, [r1]  
  bl   clock_wait
  ldr  r0,  =BIT8
  str  r0, [r1, #4]           @ divisor INT = 1

  pop {pc}

@ -----------------------------------------------------------------------------
.global uart_init
uart_init: @ Intialise the uart0
@ -----------------------------------------------------------------------------

    @----- UART init
    register_bit_set  CLR_PERI_CTRL, CLOCK_UART     @ Enable peri_clk
    peripheral_reset  RESET_UART0                   @ reset/dereset the UART
    
    @----- Baudrate 115200
    @ on pico board, after stage2 boot, we're running at 125Mhz with a peri_clk divisor = 1
    movs  r0, #67
    ldr   r1, =UARTIBRD
    str   r0, [r1]
    movs  r0, #52
    ldr   r1, =UARTFBRD
    str   r0, [r1]

    @----- 8N1, enable FIFO
    ldr   r0, =(BIT6+BIT5+BIT4)
    ldr   r1, =UARTLCR_H
    str   r0, [r1]
    
    @----- Enable tx/rx
    ldr   r0, =(BIT9+BIT8+BIT0)
    ldr   r1, =UARTCR
    str   r0, [r1]
    
    @----- GPIO PADS for UART
    .equ  PAD_CONFIG, 0b01010110
    register_bit_set (PADS_BASE+4), PAD_CONFIG 
    register_bit_set (PADS_BASE+8), PAD_CONFIG 

    @----- GPIO Pins for UART
    .equ  GPIO_UART, 0x2
    ldr   r0, =GPIO_UART
    ldr   r1, =IO_BASE
    str   r0, [r1, #0x4]
    str   r0, [r1, #0xc]
    
    bx lr

.include "../common/terminalhooks.s"

@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-emit"
serial_emit: @ ( c -- ) Emit one character
@ -----------------------------------------------------------------------------
   push   {lr}

1: bl     serial_qemit
   cmp    tos, #0
   drop
   beq    1b

   ldr    r2, =UARTDR
   strb   tos,[r2]         @ Output the character
   drop

   pop    {pc}

@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-key"
serial_key: @ ( -- c ) Receive one character
@ -----------------------------------------------------------------------------
  nop
  push    {lr}

1: bl     serial_qkey
  cmp     tos, #0
  drop
  beq    1b

  pushdatos
  ldr     r2,=UARTDR
  ldrb    tos,[r2]         @ Fetch the character

  pop     {pc}

@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-emit?"
serial_qemit:  @ ( -- ? ) Ready to send a character ?
@ -----------------------------------------------------------------------------
  push    {lr}
  bl      pause

  pushdaconst 0  @ False Flag
  ldr     r0, =UARTFR
  ldr     r1,[r0]
  movs    r0, #BIT5  @ TX FIFO FULL
  tst     r1, r0
  bne     1f
  mvns    tos, tos @ True Flag

1: pop {pc}

@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "serial-key?"
serial_qkey:  @ ( -- ? ) Is there a key press ?
@ -----------------------------------------------------------------------------
  push    {lr}
  bl      pause

  pushdaconst 0  @ False Flag
  ldr     r0, =UARTFR
  ldr     r1,[r0]
  movs    r0, #BIT4  @ RX FIFO empty
  tst     r1, r0
  bne     1f
  mvns    tos, tos @ True Flag

1: pop    {pc}

.align 2
.equ rom_enable_clocks, .
.byte 'E','C'

.ltorg
