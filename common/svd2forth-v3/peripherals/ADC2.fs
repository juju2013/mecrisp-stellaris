\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40012800 constant ADC2 ( Analog to digital converter ) 
ADC2 0x0 + constant ADC2-SR ( status register ) 
ADC2 0x4 + constant ADC2-CR1 ( control register 1 ) 
ADC2 0x8 + constant ADC2-CR2 ( control register 2 ) 
ADC2 0xC + constant ADC2-SMPR1 ( sample time register 1 ) 
ADC2 0x10 + constant ADC2-SMPR2 ( sample time register 2 ) 
ADC2 0x14 + constant ADC2-JOFR1 ( injected channel data offset register  x ) 
ADC2 0x18 + constant ADC2-JOFR2 ( injected channel data offset register  x ) 
ADC2 0x1C + constant ADC2-JOFR3 ( injected channel data offset register  x ) 
ADC2 0x20 + constant ADC2-JOFR4 ( injected channel data offset register  x ) 
ADC2 0x24 + constant ADC2-HTR ( watchdog higher threshold  register ) 
ADC2 0x28 + constant ADC2-LTR ( watchdog lower threshold  register ) 
ADC2 0x2C + constant ADC2-SQR1 ( regular sequence register 1 ) 
ADC2 0x30 + constant ADC2-SQR2 ( regular sequence register 2 ) 
ADC2 0x34 + constant ADC2-SQR3 ( regular sequence register 3 ) 
ADC2 0x38 + constant ADC2-JSQR ( injected sequence register ) 
ADC2 0x3C + constant ADC2-JDR1 ( injected data register x ) 
ADC2 0x40 + constant ADC2-JDR2 ( injected data register x ) 
ADC2 0x44 + constant ADC2-JDR3 ( injected data register x ) 
ADC2 0x48 + constant ADC2-JDR4 ( injected data register x ) 
ADC2 0x4C + constant ADC2-DR ( regular data register ) 
