\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40001000 constant TIM6 ( Basic timer ) 
TIM6 $0 + constant TIM6-CR1 ( control register 1 ) 
TIM6 $4 + constant TIM6-CR2 ( control register 2 ) 
TIM6 $C + constant TIM6-DIER ( DMA/Interrupt enable register ) 
TIM6 $10 + constant TIM6-SR ( status register ) 
TIM6 $14 + constant TIM6-EGR ( event generation register ) 
TIM6 $24 + constant TIM6-CNT ( counter ) 
TIM6 $28 + constant TIM6-PSC ( prescaler ) 
TIM6 $2C + constant TIM6-ARR ( auto-reload register ) 
