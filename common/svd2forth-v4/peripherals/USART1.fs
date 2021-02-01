\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 $0 + constant USART1-SR ( Status register ) 
USART1 $4 + constant USART1-DR ( Data register ) 
USART1 $8 + constant USART1-BRR ( Baud rate register ) 
USART1 $C + constant USART1-CR1 ( Control register 1 ) 
USART1 $10 + constant USART1-CR2 ( Control register 2 ) 
USART1 $14 + constant USART1-CR3 ( Control register 3 ) 
USART1 $18 + constant USART1-GTPR ( Guard time and prescaler  register ) 
