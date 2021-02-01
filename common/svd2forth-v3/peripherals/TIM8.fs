\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40013400 constant TIM8 ( Advanced timer ) 
TIM8 0x0 + constant TIM8-CR1 ( control register 1 ) 
TIM8 0x4 + constant TIM8-CR2 ( control register 2 ) 
TIM8 0x8 + constant TIM8-SMCR ( slave mode control register ) 
TIM8 0xC + constant TIM8-DIER ( DMA/Interrupt enable register ) 
TIM8 0x10 + constant TIM8-SR ( status register ) 
TIM8 0x14 + constant TIM8-EGR ( event generation register ) 
TIM8 0x18 + constant TIM8-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM8 0x18 + constant TIM8-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM8 0x1C + constant TIM8-CCMR2_Output ( capture/compare mode register output  mode ) 
TIM8 0x1C + constant TIM8-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM8 0x20 + constant TIM8-CCER ( capture/compare enable  register ) 
TIM8 0x24 + constant TIM8-CNT ( counter ) 
TIM8 0x28 + constant TIM8-PSC ( prescaler ) 
TIM8 0x2C + constant TIM8-ARR ( auto-reload register ) 
TIM8 0x34 + constant TIM8-CCR1 ( capture/compare register 1 ) 
TIM8 0x38 + constant TIM8-CCR2 ( capture/compare register 2 ) 
TIM8 0x3C + constant TIM8-CCR3 ( capture/compare register 3 ) 
TIM8 0x40 + constant TIM8-CCR4 ( capture/compare register 4 ) 
TIM8 0x48 + constant TIM8-DCR ( DMA control register ) 
TIM8 0x4C + constant TIM8-DMAR ( DMA address for full transfer ) 
TIM8 0x30 + constant TIM8-RCR ( repetition counter register ) 
TIM8 0x44 + constant TIM8-BDTR ( break and dead-time register ) 
