\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40005000 constant UART5 ( Universal asynchronous receiver  transmitter ) 
UART5 $0 + constant UART5-SR ( UART4_SR ) 
UART5 $4 + constant UART5-DR ( UART4_DR ) 
UART5 $8 + constant UART5-BRR ( UART4_BRR ) 
UART5 $C + constant UART5-CR1 ( UART4_CR1 ) 
UART5 $10 + constant UART5-CR2 ( UART4_CR2 ) 
UART5 $14 + constant UART5-CR3 ( UART4_CR3 ) 
