\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40001C00 constant TIM13 ( General purpose timer ) 
TIM13 0x0 + constant TIM13-CR1 ( control register 1 ) 
TIM13 0x4 + constant TIM13-CR2 ( control register 2 ) 
TIM13 0xC + constant TIM13-DIER ( DMA/Interrupt enable register ) 
TIM13 0x10 + constant TIM13-SR ( status register ) 
TIM13 0x14 + constant TIM13-EGR ( event generation register ) 
TIM13 0x18 + constant TIM13-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM13 0x18 + constant TIM13-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM13 0x20 + constant TIM13-CCER ( capture/compare enable  register ) 
TIM13 0x24 + constant TIM13-CNT ( counter ) 
TIM13 0x28 + constant TIM13-PSC ( prescaler ) 
TIM13 0x2C + constant TIM13-ARR ( auto-reload register ) 
TIM13 0x34 + constant TIM13-CCR1 ( capture/compare register 1 ) 
