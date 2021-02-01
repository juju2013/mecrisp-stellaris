\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40005800 constant I2C2 ( Inter integrated circuit ) 
I2C2 $0 + constant I2C2-CR1 ( Control register 1 ) 
I2C2 $4 + constant I2C2-CR2 ( Control register 2 ) 
I2C2 $8 + constant I2C2-OAR1 ( Own address register 1 ) 
I2C2 $C + constant I2C2-OAR2 ( Own address register 2 ) 
I2C2 $10 + constant I2C2-DR ( Data register ) 
I2C2 $14 + constant I2C2-SR1 ( Status register 1 ) 
I2C2 $18 + constant I2C2-SR2 ( Status register 2 ) 
I2C2 $1C + constant I2C2-CCR ( Clock control register ) 
I2C2 $20 + constant I2C2-TRISE ( TRISE register ) 
