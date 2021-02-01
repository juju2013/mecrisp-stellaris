\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40001C00 constant TIM13 ( General purpose timer ) 
TIM13 $0 + constant TIM13-CR1 ( control register 1 ) 
TIM13 $4 + constant TIM13-CR2 ( control register 2 ) 
TIM13 $C + constant TIM13-DIER ( DMA/Interrupt enable register ) 
TIM13 $10 + constant TIM13-SR ( status register ) 
TIM13 $14 + constant TIM13-EGR ( event generation register ) 
TIM13 $18 + constant TIM13-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM13 $18 + constant TIM13-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM13 $20 + constant TIM13-CCER ( capture/compare enable  register ) 
TIM13 $24 + constant TIM13-CNT ( counter ) 
TIM13 $28 + constant TIM13-PSC ( prescaler ) 
TIM13 $2C + constant TIM13-ARR ( auto-reload register ) 
TIM13 $34 + constant TIM13-CCR1 ( capture/compare register 1 ) 
