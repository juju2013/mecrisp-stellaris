\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40010800 constant GPIOA ( General purpose I/O ) 
GPIOA 0x0 + constant GPIOA-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOA 0x4 + constant GPIOA-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOA 0x8 + constant GPIOA-IDR ( Port input data register  GPIOn_IDR ) 
GPIOA 0xC + constant GPIOA-ODR ( Port output data register  GPIOn_ODR ) 
GPIOA 0x10 + constant GPIOA-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOA 0x14 + constant GPIOA-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOA 0x18 + constant GPIOA-LCKR ( Port configuration lock  register ) 
