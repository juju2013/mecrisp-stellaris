\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40000400 constant TIM3 ( General purpose timer ) 
TIM3 0x0 + constant TIM3-CR1 ( control register 1 ) 
TIM3 0x4 + constant TIM3-CR2 ( control register 2 ) 
TIM3 0x8 + constant TIM3-SMCR ( slave mode control register ) 
TIM3 0xC + constant TIM3-DIER ( DMA/Interrupt enable register ) 
TIM3 0x10 + constant TIM3-SR ( status register ) 
TIM3 0x14 + constant TIM3-EGR ( event generation register ) 
TIM3 0x18 + constant TIM3-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM3 0x18 + constant TIM3-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM3 0x1C + constant TIM3-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM3 0x1C + constant TIM3-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM3 0x20 + constant TIM3-CCER ( capture/compare enable  register ) 
TIM3 0x24 + constant TIM3-CNT ( counter ) 
TIM3 0x28 + constant TIM3-PSC ( prescaler ) 
TIM3 0x2C + constant TIM3-ARR ( auto-reload register ) 
TIM3 0x34 + constant TIM3-CCR1 ( capture/compare register 1 ) 
TIM3 0x38 + constant TIM3-CCR2 ( capture/compare register 2 ) 
TIM3 0x3C + constant TIM3-CCR3 ( capture/compare register 3 ) 
TIM3 0x40 + constant TIM3-CCR4 ( capture/compare register 4 ) 
TIM3 0x48 + constant TIM3-DCR ( DMA control register ) 
TIM3 0x4C + constant TIM3-DMAR ( DMA address for full transfer ) 
