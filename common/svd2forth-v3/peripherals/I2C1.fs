\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40005400 constant I2C1 ( Inter integrated circuit ) 
I2C1 0x0 + constant I2C1-CR1 ( Control register 1 ) 
I2C1 0x4 + constant I2C1-CR2 ( Control register 2 ) 
I2C1 0x8 + constant I2C1-OAR1 ( Own address register 1 ) 
I2C1 0xC + constant I2C1-OAR2 ( Own address register 2 ) 
I2C1 0x10 + constant I2C1-DR ( Data register ) 
I2C1 0x14 + constant I2C1-SR1 ( Status register 1 ) 
I2C1 0x18 + constant I2C1-SR2 ( Status register 2 ) 
I2C1 0x1C + constant I2C1-CCR ( Clock control register ) 
I2C1 0x20 + constant I2C1-TRISE ( TRISE register ) 
