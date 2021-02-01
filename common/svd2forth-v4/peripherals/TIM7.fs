\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40001400 constant TIM7 ( Basic timer ) 
TIM7 $0 + constant TIM7-CR1 ( control register 1 ) 
TIM7 $4 + constant TIM7-CR2 ( control register 2 ) 
TIM7 $C + constant TIM7-DIER ( DMA/Interrupt enable register ) 
TIM7 $10 + constant TIM7-SR ( status register ) 
TIM7 $14 + constant TIM7-EGR ( event generation register ) 
TIM7 $24 + constant TIM7-CNT ( counter ) 
TIM7 $28 + constant TIM7-PSC ( prescaler ) 
TIM7 $2C + constant TIM7-ARR ( auto-reload register ) 
