\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40003C00 constant SPI3 ( Serial peripheral interface ) 
SPI3 0x0 + constant SPI3-CR1 ( control register 1 ) 
SPI3 0x4 + constant SPI3-CR2 ( control register 2 ) 
SPI3 0x8 + constant SPI3-SR ( status register ) 
SPI3 0xC + constant SPI3-DR ( data register ) 
SPI3 0x10 + constant SPI3-CRCPR ( CRC polynomial register ) 
SPI3 0x14 + constant SPI3-RXCRCR ( RX CRC register ) 
SPI3 0x18 + constant SPI3-TXCRCR ( TX CRC register ) 
SPI3 0x1C + constant SPI3-I2SCFGR ( I2S configuration register ) 
SPI3 0x20 + constant SPI3-I2SPR ( I2S prescaler register ) 
