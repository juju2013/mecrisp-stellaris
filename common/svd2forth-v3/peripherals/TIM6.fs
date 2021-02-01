\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40001000 constant TIM6 ( Basic timer ) 
TIM6 0x0 + constant TIM6-CR1 ( control register 1 ) 
TIM6 0x4 + constant TIM6-CR2 ( control register 2 ) 
TIM6 0xC + constant TIM6-DIER ( DMA/Interrupt enable register ) 
TIM6 0x10 + constant TIM6-SR ( status register ) 
TIM6 0x14 + constant TIM6-EGR ( event generation register ) 
TIM6 0x24 + constant TIM6-CNT ( counter ) 
TIM6 0x28 + constant TIM6-PSC ( prescaler ) 
TIM6 0x2C + constant TIM6-ARR ( auto-reload register ) 
