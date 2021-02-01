\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40012800 constant ADC2 ( Analog to digital converter ) 
ADC2 $0 + constant ADC2-SR ( status register ) 
ADC2 $4 + constant ADC2-CR1 ( control register 1 ) 
ADC2 $8 + constant ADC2-CR2 ( control register 2 ) 
ADC2 $C + constant ADC2-SMPR1 ( sample time register 1 ) 
ADC2 $10 + constant ADC2-SMPR2 ( sample time register 2 ) 
ADC2 $14 + constant ADC2-JOFR1 ( injected channel data offset register  x ) 
ADC2 $18 + constant ADC2-JOFR2 ( injected channel data offset register  x ) 
ADC2 $1C + constant ADC2-JOFR3 ( injected channel data offset register  x ) 
ADC2 $20 + constant ADC2-JOFR4 ( injected channel data offset register  x ) 
ADC2 $24 + constant ADC2-HTR ( watchdog higher threshold  register ) 
ADC2 $28 + constant ADC2-LTR ( watchdog lower threshold  register ) 
ADC2 $2C + constant ADC2-SQR1 ( regular sequence register 1 ) 
ADC2 $30 + constant ADC2-SQR2 ( regular sequence register 2 ) 
ADC2 $34 + constant ADC2-SQR3 ( regular sequence register 3 ) 
ADC2 $38 + constant ADC2-JSQR ( injected sequence register ) 
ADC2 $3C + constant ADC2-JDR1 ( injected data register x ) 
ADC2 $40 + constant ADC2-JDR2 ( injected data register x ) 
ADC2 $44 + constant ADC2-JDR3 ( injected data register x ) 
ADC2 $48 + constant ADC2-JDR4 ( injected data register x ) 
ADC2 $4C + constant ADC2-DR ( regular data register ) 
