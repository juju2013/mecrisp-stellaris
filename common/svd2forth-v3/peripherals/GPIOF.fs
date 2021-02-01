\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40011C00 constant GPIOF ( General purpose I/O ) 
GPIOF 0x0 + constant GPIOF-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOF 0x4 + constant GPIOF-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOF 0x8 + constant GPIOF-IDR ( Port input data register  GPIOn_IDR ) 
GPIOF 0xC + constant GPIOF-ODR ( Port output data register  GPIOn_ODR ) 
GPIOF 0x10 + constant GPIOF-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOF 0x14 + constant GPIOF-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOF 0x18 + constant GPIOF-LCKR ( Port configuration lock  register ) 
