\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40005800 constant I2C2 ( Inter integrated circuit ) 
I2C2 0x0 + constant I2C2-CR1 ( Control register 1 ) 
I2C2 0x4 + constant I2C2-CR2 ( Control register 2 ) 
I2C2 0x8 + constant I2C2-OAR1 ( Own address register 1 ) 
I2C2 0xC + constant I2C2-OAR2 ( Own address register 2 ) 
I2C2 0x10 + constant I2C2-DR ( Data register ) 
I2C2 0x14 + constant I2C2-SR1 ( Status register 1 ) 
I2C2 0x18 + constant I2C2-SR2 ( Status register 2 ) 
I2C2 0x1C + constant I2C2-CCR ( Clock control register ) 
I2C2 0x20 + constant I2C2-TRISE ( TRISE register ) 
