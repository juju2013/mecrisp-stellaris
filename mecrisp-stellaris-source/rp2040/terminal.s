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
    
    @----- GPIO Pins for UART
    movs  r0, #GPIO_FUNC_UART
    ldr   r1, =IO_BASE
    str   r0, [r1, #0x4]      @ GPIO0/TX
    str   r0, [r1, #0xc]      @ GPIO0/RX
    
    ldr   r1, =PADS_BASE
    movs  r0, #0b01010110     @ OUTPUT
    str   r0, [r1, #0x4]
    str   r0, [r1, #0x8]
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

.ltorg
