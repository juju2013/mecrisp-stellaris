\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40014C00 constant TIM9 ( General purpose timer ) 
TIM9 $0 + constant TIM9-CR1 ( control register 1 ) 
TIM9 $4 + constant TIM9-CR2 ( control register 2 ) 
TIM9 $8 + constant TIM9-SMCR ( slave mode control register ) 
TIM9 $C + constant TIM9-DIER ( DMA/Interrupt enable register ) 
TIM9 $10 + constant TIM9-SR ( status register ) 
TIM9 $14 + constant TIM9-EGR ( event generation register ) 
TIM9 $18 + constant TIM9-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM9 $18 + constant TIM9-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM9 $20 + constant TIM9-CCER ( capture/compare enable  register ) 
TIM9 $24 + constant TIM9-CNT ( counter ) 
TIM9 $28 + constant TIM9-PSC ( prescaler ) 
TIM9 $2C + constant TIM9-ARR ( auto-reload register ) 
TIM9 $34 + constant TIM9-CCR1 ( capture/compare register 1 ) 
TIM9 $38 + constant TIM9-CCR2 ( capture/compare register 2 ) 
