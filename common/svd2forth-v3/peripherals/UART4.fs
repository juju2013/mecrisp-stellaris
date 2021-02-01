\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40004C00 constant UART4 ( Universal asynchronous receiver  transmitter ) 
UART4 0x0 + constant UART4-SR ( UART4_SR ) 
UART4 0x4 + constant UART4-DR ( UART4_DR ) 
UART4 0x8 + constant UART4-BRR ( UART4_BRR ) 
UART4 0xC + constant UART4-CR1 ( UART4_CR1 ) 
UART4 0x10 + constant UART4-CR2 ( UART4_CR2 ) 
UART4 0x14 + constant UART4-CR3 ( UART4_CR3 ) 
