\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40002000 constant TIM14 ( General purpose timer ) 
TIM14 0x0 + constant TIM14-CR1 ( control register 1 ) 
TIM14 0x4 + constant TIM14-CR2 ( control register 2 ) 
TIM14 0xC + constant TIM14-DIER ( DMA/Interrupt enable register ) 
TIM14 0x10 + constant TIM14-SR ( status register ) 
TIM14 0x14 + constant TIM14-EGR ( event generation register ) 
TIM14 0x18 + constant TIM14-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM14 0x18 + constant TIM14-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM14 0x20 + constant TIM14-CCER ( capture/compare enable  register ) 
TIM14 0x24 + constant TIM14-CNT ( counter ) 
TIM14 0x28 + constant TIM14-PSC ( prescaler ) 
TIM14 0x2C + constant TIM14-ARR ( auto-reload register ) 
TIM14 0x34 + constant TIM14-CCR1 ( capture/compare register 1 ) 
