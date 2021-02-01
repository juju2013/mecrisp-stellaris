\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40001800 constant TIM12 ( General purpose timer ) 
TIM12 0x0 + constant TIM12-CR1 ( control register 1 ) 
TIM12 0x4 + constant TIM12-CR2 ( control register 2 ) 
TIM12 0x8 + constant TIM12-SMCR ( slave mode control register ) 
TIM12 0xC + constant TIM12-DIER ( DMA/Interrupt enable register ) 
TIM12 0x10 + constant TIM12-SR ( status register ) 
TIM12 0x14 + constant TIM12-EGR ( event generation register ) 
TIM12 0x18 + constant TIM12-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM12 0x18 + constant TIM12-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM12 0x20 + constant TIM12-CCER ( capture/compare enable  register ) 
TIM12 0x24 + constant TIM12-CNT ( counter ) 
TIM12 0x28 + constant TIM12-PSC ( prescaler ) 
TIM12 0x2C + constant TIM12-ARR ( auto-reload register ) 
TIM12 0x34 + constant TIM12-CCR1 ( capture/compare register 1 ) 
TIM12 0x38 + constant TIM12-CCR2 ( capture/compare register 2 ) 
