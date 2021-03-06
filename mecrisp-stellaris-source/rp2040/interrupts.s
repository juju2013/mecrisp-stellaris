@
@    Mecrisp-Stellaris - A native code Forth implementation for ARM-Cortex M microcontrollers
@    Copyright (C) 2013  Matthias Koch
@    Copyright (C) 2021  juju2013@github
@
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

@ Routinen für die Interrupthandler, die zur Laufzeit neu gesetzt werden können.
@ Code for interrupt handlers that are exchangeable on the fly

@------------------------------------------------------------------------------
@ Alle Interrupthandler funktionieren gleich und werden komfortabel mit einem Makro erzeugt:
@ All interrupt handlers work the same way and are generated with a macro:
@ 
@ All interrupts generated code is too big for thumb, so it's split into 2 parts
@ This is part1
@------------------------------------------------------------------------------
.ltorg

interrupt pendsv
interrupt bod_out
interrupt timer0  	
interrupt timer1  	
interrupt timer2  	
interrupt timer3  	
interrupt pwmwrap 	
interrupt usbctrl 	
interrupt xip 	    
interrupt pio00 	  
interrupt pio01 	  
interrupt pio10 	  
interrupt pio11 	  
.ltorg
interrupt dma0 	  
interrupt dma1 	  
interrupt iobank0 	
interrupt ioqspi 	
interrupt sioproc0 
interrupt sioproc1 
interrupt clocks 	
interrupt spi0 	  
interrupt spi1 	  
interrupt uart0 	  
interrupt uart1 	  
interrupt adcfifo 	
interrupt i2c0 	  
interrupt i2c1 	  
interrupt rtc 	    
interrupt ispr
.ltorg

