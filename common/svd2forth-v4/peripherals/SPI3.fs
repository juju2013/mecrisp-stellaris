\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40003C00 constant SPI3 ( Serial peripheral interface ) 
SPI3 $0 + constant SPI3-CR1 ( control register 1 ) 
SPI3 $4 + constant SPI3-CR2 ( control register 2 ) 
SPI3 $8 + constant SPI3-SR ( status register ) 
SPI3 $C + constant SPI3-DR ( data register ) 
SPI3 $10 + constant SPI3-CRCPR ( CRC polynomial register ) 
SPI3 $14 + constant SPI3-RXCRCR ( RX CRC register ) 
SPI3 $18 + constant SPI3-TXCRCR ( TX CRC register ) 
SPI3 $1C + constant SPI3-I2SCFGR ( I2S configuration register ) 
SPI3 $20 + constant SPI3-I2SPR ( I2S prescaler register ) 
