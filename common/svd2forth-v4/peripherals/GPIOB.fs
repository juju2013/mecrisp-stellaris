\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40010C00 constant GPIOB ( General purpose I/O ) 
GPIOB $0 + constant GPIOB-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOB $4 + constant GPIOB-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOB $8 + constant GPIOB-IDR ( Port input data register  GPIOn_IDR ) 
GPIOB $C + constant GPIOB-ODR ( Port output data register  GPIOn_ODR ) 
GPIOB $10 + constant GPIOB-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOB $14 + constant GPIOB-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOB $18 + constant GPIOB-LCKR ( Port configuration lock  register ) 
