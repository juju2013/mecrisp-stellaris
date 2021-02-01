\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40010C00 constant GPIOB ( General purpose I/O ) 
GPIOB 0x0 + constant GPIOB-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOB 0x4 + constant GPIOB-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOB 0x8 + constant GPIOB-IDR ( Port input data register  GPIOn_IDR ) 
GPIOB 0xC + constant GPIOB-ODR ( Port output data register  GPIOn_ODR ) 
GPIOB 0x10 + constant GPIOB-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOB 0x14 + constant GPIOB-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOB 0x18 + constant GPIOB-LCKR ( Port configuration lock  register ) 
