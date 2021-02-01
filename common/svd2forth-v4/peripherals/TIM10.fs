\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40015000 constant TIM10 ( General purpose timer ) 
TIM10 $0 + constant TIM10-CR1 ( control register 1 ) 
TIM10 $4 + constant TIM10-CR2 ( control register 2 ) 
TIM10 $C + constant TIM10-DIER ( DMA/Interrupt enable register ) 
TIM10 $10 + constant TIM10-SR ( status register ) 
TIM10 $14 + constant TIM10-EGR ( event generation register ) 
TIM10 $18 + constant TIM10-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM10 $18 + constant TIM10-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM10 $20 + constant TIM10-CCER ( capture/compare enable  register ) 
TIM10 $24 + constant TIM10-CNT ( counter ) 
TIM10 $28 + constant TIM10-PSC ( prescaler ) 
TIM10 $2C + constant TIM10-ARR ( auto-reload register ) 
TIM10 $34 + constant TIM10-CCR1 ( capture/compare register 1 ) 
