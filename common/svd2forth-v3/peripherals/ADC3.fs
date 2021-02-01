\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40013C00 constant ADC3 ( Analog to digital converter ) 
ADC3 0x0 + constant ADC3-SR ( status register ) 
ADC3 0x4 + constant ADC3-CR1 ( control register 1 ) 
ADC3 0x8 + constant ADC3-CR2 ( control register 2 ) 
ADC3 0xC + constant ADC3-SMPR1 ( sample time register 1 ) 
ADC3 0x10 + constant ADC3-SMPR2 ( sample time register 2 ) 
ADC3 0x14 + constant ADC3-JOFR1 ( injected channel data offset register  x ) 
ADC3 0x18 + constant ADC3-JOFR2 ( injected channel data offset register  x ) 
ADC3 0x1C + constant ADC3-JOFR3 ( injected channel data offset register  x ) 
ADC3 0x20 + constant ADC3-JOFR4 ( injected channel data offset register  x ) 
ADC3 0x24 + constant ADC3-HTR ( watchdog higher threshold  register ) 
ADC3 0x28 + constant ADC3-LTR ( watchdog lower threshold  register ) 
ADC3 0x2C + constant ADC3-SQR1 ( regular sequence register 1 ) 
ADC3 0x30 + constant ADC3-SQR2 ( regular sequence register 2 ) 
ADC3 0x34 + constant ADC3-SQR3 ( regular sequence register 3 ) 
ADC3 0x38 + constant ADC3-JSQR ( injected sequence register ) 
ADC3 0x3C + constant ADC3-JDR1 ( injected data register x ) 
ADC3 0x40 + constant ADC3-JDR2 ( injected data register x ) 
ADC3 0x44 + constant ADC3-JDR3 ( injected data register x ) 
ADC3 0x48 + constant ADC3-JDR4 ( injected data register x ) 
ADC3 0x4C + constant ADC3-DR ( regular data register ) 
