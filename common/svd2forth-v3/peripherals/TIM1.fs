\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40012C00 constant TIM1 ( Advanced timer ) 
TIM1 0x0 + constant TIM1-CR1 ( control register 1 ) 
TIM1 0x4 + constant TIM1-CR2 ( control register 2 ) 
TIM1 0x8 + constant TIM1-SMCR ( slave mode control register ) 
TIM1 0xC + constant TIM1-DIER ( DMA/Interrupt enable register ) 
TIM1 0x10 + constant TIM1-SR ( status register ) 
TIM1 0x14 + constant TIM1-EGR ( event generation register ) 
TIM1 0x18 + constant TIM1-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM1 0x18 + constant TIM1-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM1 0x1C + constant TIM1-CCMR2_Output ( capture/compare mode register output  mode ) 
TIM1 0x1C + constant TIM1-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM1 0x20 + constant TIM1-CCER ( capture/compare enable  register ) 
TIM1 0x24 + constant TIM1-CNT ( counter ) 
TIM1 0x28 + constant TIM1-PSC ( prescaler ) 
TIM1 0x2C + constant TIM1-ARR ( auto-reload register ) 
TIM1 0x34 + constant TIM1-CCR1 ( capture/compare register 1 ) 
TIM1 0x38 + constant TIM1-CCR2 ( capture/compare register 2 ) 
TIM1 0x3C + constant TIM1-CCR3 ( capture/compare register 3 ) 
TIM1 0x40 + constant TIM1-CCR4 ( capture/compare register 4 ) 
TIM1 0x48 + constant TIM1-DCR ( DMA control register ) 
TIM1 0x4C + constant TIM1-DMAR ( DMA address for full transfer ) 
TIM1 0x30 + constant TIM1-RCR ( repetition counter register ) 
TIM1 0x44 + constant TIM1-BDTR ( break and dead-time register ) 
