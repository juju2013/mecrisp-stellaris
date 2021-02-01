\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40000000 constant TIM2 ( General purpose timer ) 
TIM2 0x0 + constant TIM2-CR1 ( control register 1 ) 
TIM2 0x4 + constant TIM2-CR2 ( control register 2 ) 
TIM2 0x8 + constant TIM2-SMCR ( slave mode control register ) 
TIM2 0xC + constant TIM2-DIER ( DMA/Interrupt enable register ) 
TIM2 0x10 + constant TIM2-SR ( status register ) 
TIM2 0x14 + constant TIM2-EGR ( event generation register ) 
TIM2 0x18 + constant TIM2-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM2 0x18 + constant TIM2-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM2 0x1C + constant TIM2-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM2 0x1C + constant TIM2-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM2 0x20 + constant TIM2-CCER ( capture/compare enable  register ) 
TIM2 0x24 + constant TIM2-CNT ( counter ) 
TIM2 0x28 + constant TIM2-PSC ( prescaler ) 
TIM2 0x2C + constant TIM2-ARR ( auto-reload register ) 
TIM2 0x34 + constant TIM2-CCR1 ( capture/compare register 1 ) 
TIM2 0x38 + constant TIM2-CCR2 ( capture/compare register 2 ) 
TIM2 0x3C + constant TIM2-CCR3 ( capture/compare register 3 ) 
TIM2 0x40 + constant TIM2-CCR4 ( capture/compare register 4 ) 
TIM2 0x48 + constant TIM2-DCR ( DMA control register ) 
TIM2 0x4C + constant TIM2-DMAR ( DMA address for full transfer ) 
