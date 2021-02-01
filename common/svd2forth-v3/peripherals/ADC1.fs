\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40012400 constant ADC1 ( Analog to digital converter ) 
ADC1 0x0 + constant ADC1-SR ( status register ) 
ADC1 0x4 + constant ADC1-CR1 ( control register 1 ) 
ADC1 0x8 + constant ADC1-CR2 ( control register 2 ) 
ADC1 0xC + constant ADC1-SMPR1 ( sample time register 1 ) 
ADC1 0x10 + constant ADC1-SMPR2 ( sample time register 2 ) 
ADC1 0x14 + constant ADC1-JOFR1 ( injected channel data offset register  x ) 
ADC1 0x18 + constant ADC1-JOFR2 ( injected channel data offset register  x ) 
ADC1 0x1C + constant ADC1-JOFR3 ( injected channel data offset register  x ) 
ADC1 0x20 + constant ADC1-JOFR4 ( injected channel data offset register  x ) 
ADC1 0x24 + constant ADC1-HTR ( watchdog higher threshold  register ) 
ADC1 0x28 + constant ADC1-LTR ( watchdog lower threshold  register ) 
ADC1 0x2C + constant ADC1-SQR1 ( regular sequence register 1 ) 
ADC1 0x30 + constant ADC1-SQR2 ( regular sequence register 2 ) 
ADC1 0x34 + constant ADC1-SQR3 ( regular sequence register 3 ) 
ADC1 0x38 + constant ADC1-JSQR ( injected sequence register ) 
ADC1 0x3C + constant ADC1-JDR1 ( injected data register x ) 
ADC1 0x40 + constant ADC1-JDR2 ( injected data register x ) 
ADC1 0x44 + constant ADC1-JDR3 ( injected data register x ) 
ADC1 0x48 + constant ADC1-JDR4 ( injected data register x ) 
ADC1 0x4C + constant ADC1-DR ( regular data register ) 
