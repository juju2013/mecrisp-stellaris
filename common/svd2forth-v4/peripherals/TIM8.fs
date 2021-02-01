\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40013400 constant TIM8 ( Advanced timer ) 
TIM8 $0 + constant TIM8-CR1 ( control register 1 ) 
TIM8 $4 + constant TIM8-CR2 ( control register 2 ) 
TIM8 $8 + constant TIM8-SMCR ( slave mode control register ) 
TIM8 $C + constant TIM8-DIER ( DMA/Interrupt enable register ) 
TIM8 $10 + constant TIM8-SR ( status register ) 
TIM8 $14 + constant TIM8-EGR ( event generation register ) 
TIM8 $18 + constant TIM8-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM8 $18 + constant TIM8-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM8 $1C + constant TIM8-CCMR2_Output ( capture/compare mode register output  mode ) 
TIM8 $1C + constant TIM8-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM8 $20 + constant TIM8-CCER ( capture/compare enable  register ) 
TIM8 $24 + constant TIM8-CNT ( counter ) 
TIM8 $28 + constant TIM8-PSC ( prescaler ) 
TIM8 $2C + constant TIM8-ARR ( auto-reload register ) 
TIM8 $34 + constant TIM8-CCR1 ( capture/compare register 1 ) 
TIM8 $38 + constant TIM8-CCR2 ( capture/compare register 2 ) 
TIM8 $3C + constant TIM8-CCR3 ( capture/compare register 3 ) 
TIM8 $40 + constant TIM8-CCR4 ( capture/compare register 4 ) 
TIM8 $48 + constant TIM8-DCR ( DMA control register ) 
TIM8 $4C + constant TIM8-DMAR ( DMA address for full transfer ) 
TIM8 $30 + constant TIM8-RCR ( repetition counter register ) 
TIM8 $44 + constant TIM8-BDTR ( break and dead-time register ) 
