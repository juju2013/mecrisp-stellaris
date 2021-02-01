\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40011000 constant GPIOC ( General purpose I/O ) 
GPIOC $0 + constant GPIOC-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOC $4 + constant GPIOC-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOC $8 + constant GPIOC-IDR ( Port input data register  GPIOn_IDR ) 
GPIOC $C + constant GPIOC-ODR ( Port output data register  GPIOn_ODR ) 
GPIOC $10 + constant GPIOC-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOC $14 + constant GPIOC-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOC $18 + constant GPIOC-LCKR ( Port configuration lock  register ) 
