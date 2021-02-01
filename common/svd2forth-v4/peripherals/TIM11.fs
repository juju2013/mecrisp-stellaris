\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40015400 constant TIM11 ( General purpose timer ) 
TIM11 $0 + constant TIM11-CR1 ( control register 1 ) 
TIM11 $4 + constant TIM11-CR2 ( control register 2 ) 
TIM11 $C + constant TIM11-DIER ( DMA/Interrupt enable register ) 
TIM11 $10 + constant TIM11-SR ( status register ) 
TIM11 $14 + constant TIM11-EGR ( event generation register ) 
TIM11 $18 + constant TIM11-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM11 $18 + constant TIM11-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM11 $20 + constant TIM11-CCER ( capture/compare enable  register ) 
TIM11 $24 + constant TIM11-CNT ( counter ) 
TIM11 $28 + constant TIM11-PSC ( prescaler ) 
TIM11 $2C + constant TIM11-ARR ( auto-reload register ) 
TIM11 $34 + constant TIM11-CCR1 ( capture/compare register 1 ) 
