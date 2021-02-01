\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40003800 constant SPI2 ( Serial peripheral interface ) 
SPI2 0x0 + constant SPI2-CR1 ( control register 1 ) 
SPI2 0x4 + constant SPI2-CR2 ( control register 2 ) 
SPI2 0x8 + constant SPI2-SR ( status register ) 
SPI2 0xC + constant SPI2-DR ( data register ) 
SPI2 0x10 + constant SPI2-CRCPR ( CRC polynomial register ) 
SPI2 0x14 + constant SPI2-RXCRCR ( RX CRC register ) 
SPI2 0x18 + constant SPI2-TXCRCR ( TX CRC register ) 
SPI2 0x1C + constant SPI2-I2SCFGR ( I2S configuration register ) 
SPI2 0x20 + constant SPI2-I2SPR ( I2S prescaler register ) 
