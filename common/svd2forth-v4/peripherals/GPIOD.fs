\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40011400 constant GPIOD ( General purpose I/O ) 
GPIOD $0 + constant GPIOD-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOD $4 + constant GPIOD-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOD $8 + constant GPIOD-IDR ( Port input data register  GPIOn_IDR ) 
GPIOD $C + constant GPIOD-ODR ( Port output data register  GPIOn_ODR ) 
GPIOD $10 + constant GPIOD-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOD $14 + constant GPIOD-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOD $18 + constant GPIOD-LCKR ( Port configuration lock  register ) 
