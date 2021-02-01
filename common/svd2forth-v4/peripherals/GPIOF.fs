\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40011C00 constant GPIOF ( General purpose I/O ) 
GPIOF $0 + constant GPIOF-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOF $4 + constant GPIOF-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOF $8 + constant GPIOF-IDR ( Port input data register  GPIOn_IDR ) 
GPIOF $C + constant GPIOF-ODR ( Port output data register  GPIOn_ODR ) 
GPIOF $10 + constant GPIOF-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOF $14 + constant GPIOF-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOF $18 + constant GPIOF-LCKR ( Port configuration lock  register ) 
