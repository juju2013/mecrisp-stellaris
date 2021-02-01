\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40010000 constant AFIO ( Alternate function I/O ) 
AFIO 0x0 + constant AFIO-EVCR ( Event Control Register  AFIO_EVCR ) 
AFIO 0x4 + constant AFIO-MAPR ( AF remap and debug I/O configuration  register AFIO_MAPR ) 
AFIO 0x8 + constant AFIO-EXTICR1 ( External interrupt configuration register 1  AFIO_EXTICR1 ) 
AFIO 0xC + constant AFIO-EXTICR2 ( External interrupt configuration register 2  AFIO_EXTICR2 ) 
AFIO 0x10 + constant AFIO-EXTICR3 ( External interrupt configuration register 3  AFIO_EXTICR3 ) 
AFIO 0x14 + constant AFIO-EXTICR4 ( External interrupt configuration register 4  AFIO_EXTICR4 ) 
AFIO 0x1C + constant AFIO-MAPR2 ( AF remap and debug I/O configuration  register ) 
