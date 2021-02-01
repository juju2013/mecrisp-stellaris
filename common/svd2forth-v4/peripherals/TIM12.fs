\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40001800 constant TIM12 ( General purpose timer ) 
TIM12 $0 + constant TIM12-CR1 ( control register 1 ) 
TIM12 $4 + constant TIM12-CR2 ( control register 2 ) 
TIM12 $8 + constant TIM12-SMCR ( slave mode control register ) 
TIM12 $C + constant TIM12-DIER ( DMA/Interrupt enable register ) 
TIM12 $10 + constant TIM12-SR ( status register ) 
TIM12 $14 + constant TIM12-EGR ( event generation register ) 
TIM12 $18 + constant TIM12-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM12 $18 + constant TIM12-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM12 $20 + constant TIM12-CCER ( capture/compare enable  register ) 
TIM12 $24 + constant TIM12-CNT ( counter ) 
TIM12 $28 + constant TIM12-PSC ( prescaler ) 
TIM12 $2C + constant TIM12-ARR ( auto-reload register ) 
TIM12 $34 + constant TIM12-CCR1 ( capture/compare register 1 ) 
TIM12 $38 + constant TIM12-CCR2 ( capture/compare register 2 ) 
