\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 0x0 + constant USART1-SR ( Status register ) 
USART1 0x4 + constant USART1-DR ( Data register ) 
USART1 0x8 + constant USART1-BRR ( Baud rate register ) 
USART1 0xC + constant USART1-CR1 ( Control register 1 ) 
USART1 0x10 + constant USART1-CR2 ( Control register 2 ) 
USART1 0x14 + constant USART1-CR3 ( Control register 3 ) 
USART1 0x18 + constant USART1-GTPR ( Guard time and prescaler  register ) 
