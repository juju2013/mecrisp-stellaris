\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40013C00 constant ADC3 ( Analog to digital converter ) 
ADC3 $0 + constant ADC3-SR ( status register ) 
ADC3 $4 + constant ADC3-CR1 ( control register 1 ) 
ADC3 $8 + constant ADC3-CR2 ( control register 2 ) 
ADC3 $C + constant ADC3-SMPR1 ( sample time register 1 ) 
ADC3 $10 + constant ADC3-SMPR2 ( sample time register 2 ) 
ADC3 $14 + constant ADC3-JOFR1 ( injected channel data offset register  x ) 
ADC3 $18 + constant ADC3-JOFR2 ( injected channel data offset register  x ) 
ADC3 $1C + constant ADC3-JOFR3 ( injected channel data offset register  x ) 
ADC3 $20 + constant ADC3-JOFR4 ( injected channel data offset register  x ) 
ADC3 $24 + constant ADC3-HTR ( watchdog higher threshold  register ) 
ADC3 $28 + constant ADC3-LTR ( watchdog lower threshold  register ) 
ADC3 $2C + constant ADC3-SQR1 ( regular sequence register 1 ) 
ADC3 $30 + constant ADC3-SQR2 ( regular sequence register 2 ) 
ADC3 $34 + constant ADC3-SQR3 ( regular sequence register 3 ) 
ADC3 $38 + constant ADC3-JSQR ( injected sequence register ) 
ADC3 $3C + constant ADC3-JDR1 ( injected data register x ) 
ADC3 $40 + constant ADC3-JDR2 ( injected data register x ) 
ADC3 $44 + constant ADC3-JDR3 ( injected data register x ) 
ADC3 $48 + constant ADC3-JDR4 ( injected data register x ) 
ADC3 $4C + constant ADC3-DR ( regular data register ) 
