\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40000800 constant TIM4 ( General purpose timer ) 
TIM4 $0 + constant TIM4-CR1 ( control register 1 ) 
TIM4 $4 + constant TIM4-CR2 ( control register 2 ) 
TIM4 $8 + constant TIM4-SMCR ( slave mode control register ) 
TIM4 $C + constant TIM4-DIER ( DMA/Interrupt enable register ) 
TIM4 $10 + constant TIM4-SR ( status register ) 
TIM4 $14 + constant TIM4-EGR ( event generation register ) 
TIM4 $18 + constant TIM4-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM4 $18 + constant TIM4-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM4 $1C + constant TIM4-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM4 $1C + constant TIM4-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM4 $20 + constant TIM4-CCER ( capture/compare enable  register ) 
TIM4 $24 + constant TIM4-CNT ( counter ) 
TIM4 $28 + constant TIM4-PSC ( prescaler ) 
TIM4 $2C + constant TIM4-ARR ( auto-reload register ) 
TIM4 $34 + constant TIM4-CCR1 ( capture/compare register 1 ) 
TIM4 $38 + constant TIM4-CCR2 ( capture/compare register 2 ) 
TIM4 $3C + constant TIM4-CCR3 ( capture/compare register 3 ) 
TIM4 $40 + constant TIM4-CCR4 ( capture/compare register 4 ) 
TIM4 $48 + constant TIM4-DCR ( DMA control register ) 
TIM4 $4C + constant TIM4-DMAR ( DMA address for full transfer ) 
