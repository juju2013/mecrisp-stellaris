\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40000C00 constant TIM5 ( General purpose timer ) 
TIM5 $0 + constant TIM5-CR1 ( control register 1 ) 
TIM5 $4 + constant TIM5-CR2 ( control register 2 ) 
TIM5 $8 + constant TIM5-SMCR ( slave mode control register ) 
TIM5 $C + constant TIM5-DIER ( DMA/Interrupt enable register ) 
TIM5 $10 + constant TIM5-SR ( status register ) 
TIM5 $14 + constant TIM5-EGR ( event generation register ) 
TIM5 $18 + constant TIM5-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM5 $18 + constant TIM5-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM5 $1C + constant TIM5-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM5 $1C + constant TIM5-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM5 $20 + constant TIM5-CCER ( capture/compare enable  register ) 
TIM5 $24 + constant TIM5-CNT ( counter ) 
TIM5 $28 + constant TIM5-PSC ( prescaler ) 
TIM5 $2C + constant TIM5-ARR ( auto-reload register ) 
TIM5 $34 + constant TIM5-CCR1 ( capture/compare register 1 ) 
TIM5 $38 + constant TIM5-CCR2 ( capture/compare register 2 ) 
TIM5 $3C + constant TIM5-CCR3 ( capture/compare register 3 ) 
TIM5 $40 + constant TIM5-CCR4 ( capture/compare register 4 ) 
TIM5 $48 + constant TIM5-DCR ( DMA control register ) 
TIM5 $4C + constant TIM5-DMAR ( DMA address for full transfer ) 
