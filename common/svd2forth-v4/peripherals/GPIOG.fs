\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40012000 constant GPIOG ( General purpose I/O ) 
GPIOG $0 + constant GPIOG-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOG $4 + constant GPIOG-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOG $8 + constant GPIOG-IDR ( Port input data register  GPIOn_IDR ) 
GPIOG $C + constant GPIOG-ODR ( Port output data register  GPIOn_ODR ) 
GPIOG $10 + constant GPIOG-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOG $14 + constant GPIOG-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOG $18 + constant GPIOG-LCKR ( Port configuration lock  register ) 
