\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40004400 constant USART2 ( Universal synchronous asynchronous receiver  transmitter ) 
USART2 0x0 + constant USART2-SR ( Status register ) 
USART2 0x4 + constant USART2-DR ( Data register ) 
USART2 0x8 + constant USART2-BRR ( Baud rate register ) 
USART2 0xC + constant USART2-CR1 ( Control register 1 ) 
USART2 0x10 + constant USART2-CR2 ( Control register 2 ) 
USART2 0x14 + constant USART2-CR3 ( Control register 3 ) 
USART2 0x18 + constant USART2-GTPR ( Guard time and prescaler  register ) 
