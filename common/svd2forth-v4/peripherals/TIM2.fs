\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40000000 constant TIM2 ( General purpose timer ) 
TIM2 $0 + constant TIM2-CR1 ( control register 1 ) 
TIM2 $4 + constant TIM2-CR2 ( control register 2 ) 
TIM2 $8 + constant TIM2-SMCR ( slave mode control register ) 
TIM2 $C + constant TIM2-DIER ( DMA/Interrupt enable register ) 
TIM2 $10 + constant TIM2-SR ( status register ) 
TIM2 $14 + constant TIM2-EGR ( event generation register ) 
TIM2 $18 + constant TIM2-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM2 $18 + constant TIM2-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM2 $1C + constant TIM2-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM2 $1C + constant TIM2-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM2 $20 + constant TIM2-CCER ( capture/compare enable  register ) 
TIM2 $24 + constant TIM2-CNT ( counter ) 
TIM2 $28 + constant TIM2-PSC ( prescaler ) 
TIM2 $2C + constant TIM2-ARR ( auto-reload register ) 
TIM2 $34 + constant TIM2-CCR1 ( capture/compare register 1 ) 
TIM2 $38 + constant TIM2-CCR2 ( capture/compare register 2 ) 
TIM2 $3C + constant TIM2-CCR3 ( capture/compare register 3 ) 
TIM2 $40 + constant TIM2-CCR4 ( capture/compare register 4 ) 
TIM2 $48 + constant TIM2-DCR ( DMA control register ) 
TIM2 $4C + constant TIM2-DMAR ( DMA address for full transfer ) 
