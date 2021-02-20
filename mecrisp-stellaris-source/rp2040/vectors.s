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



@ -----------------------------------------------------------------------------
@ Interruptvektortabelle
@ -----------------------------------------------------------------------------
.org 0x200 @ see the main source file for the boot chain & VTOR arrangement
.equ addresszero, . @ This is needed to circumvent address relocation issues.
.word returnstackanfang  @ 00: Stack top address

@ Special interrupt handlers for this particular chip:

.word Reset+1 	/*RESET*/ 	
.word faulthandler+1 	/*NMI */	
.word faulthandler+1		/*hard_fault */	
.word 0				 		/*Reserved */		@ reserved
.word 0				 		/*Reserved */		@ reserved
.word 0				 		/*Reserved */		@ reserved
.word 0				 		/*Reserved */		@ reserved
.word 0				 		/*Reserved */		@ reserved
.word 0				 		/*Reserved */		@ reserved
.word 0				 		/*Reserved */		@ reserved
.word nullhandler+1		/*svcall */	
.word 0				 		/*Reserved */		@ reserved
.word 0				 		/*Reserved */		@ reserved
.word irq_vektor_pendsv+1		/*pendsv */
.word irq_vektor_systick+1	/*sys tick */	


.word irq_vektor_timer0+1  	        /*TIMER_IRQ_0 */		
.word irq_vektor_timer1+1  	        /*TIMER_IRQ_1 */		
.word irq_vektor_timer2+1  	        /*TIMER_IRQ_2 */		
.word irq_vektor_timer3+1  	        /*TIMER_IRQ_3 */		
.word irq_vektor_pwmwrap+1 	        /*PWM_IRQ_WRAP */		
.word irq_vektor_usbctrl+1 	        /*USBCTRL_IRQ  */		
.word irq_vektor_xip+1 	            /*XIP_IRQ  */		
.word irq_vektor_pio00+1 	          /*PIO0_IRQ_0  */		
.word irq_vektor_pio01+1 	          /*PIO0_IRQ_1  */		
.word irq_vektor_pio10+1 	          /*PIO1_IRQ_0  */		
.word irq_vektor_pio11+1 	          /*PIO1_IRQ_1  */		
.word irq_vektor_dma0+1 	          /*DMA_IRQ_0  */		
.word irq_vektor_dma1+1 	          /*DMA_IRQ_1  */		
.word irq_vektor_iobank0+1 	        /*IO_IRQ_BANK0  */		
.word irq_vektor_ioqspi+1 	        /*IO_IRQ_QSPI  */		
.word irq_vektor_sioproc0+1 	      /*SIO_IRQ_PROC0  */		
.word irq_vektor_sioproc1+1 	      /*SIO_IRQ_PROC1  */		
.word irq_vektor_clocks+1 	        /*CLOCKS_IRQ  */		
.word irq_vektor_spi0+1 	          /*SPI0_IRQ  */		
.word irq_vektor_spi1+1 	          /*SPI1_IRQ  */		
.word irq_vektor_uart0+1 	          /*UART0_IRQ  */		
.word irq_vektor_uart1+1 	          /*UART1_IRQ  */		
.word irq_vektor_adcfifo+1 	        /*ADC_IRQ_FIFO  */		
.word irq_vektor_i2c0+1 	          /*I2C0_IRQ  */		
.word irq_vektor_i2c1+1 	          /*I2C1_IRQ  */		
.word irq_vektor_rtc+1 	            /*RTC_IRQ  */		

@ XXX FIXME Should we ? will exceed thumb branch limit in boot.s :
.word irq_vektor_ispr26+1 	        /*ISPR only  */		
.word irq_vektor_ispr27+1 	        /*ISPR only  */		
.word irq_vektor_ispr28+1 	        /*ISPR only  */		
.word irq_vektor_ispr29+1 	        /*ISPR only  */		
.word irq_vektor_ispr30+1 	        /*ISPR only  */		
.word irq_vektor_ispr31+1 	        /*ISPR only  */		
