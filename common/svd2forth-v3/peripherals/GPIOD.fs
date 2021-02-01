\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40011400 constant GPIOD ( General purpose I/O ) 
GPIOD 0x0 + constant GPIOD-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOD 0x4 + constant GPIOD-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOD 0x8 + constant GPIOD-IDR ( Port input data register  GPIOn_IDR ) 
GPIOD 0xC + constant GPIOD-ODR ( Port output data register  GPIOn_ODR ) 
GPIOD 0x10 + constant GPIOD-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOD 0x14 + constant GPIOD-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOD 0x18 + constant GPIOD-LCKR ( Port configuration lock  register ) 
