\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1-CR1 ( control register 1 ) 
SPI1 $4 + constant SPI1-CR2 ( control register 2 ) 
SPI1 $8 + constant SPI1-SR ( status register ) 
SPI1 $C + constant SPI1-DR ( data register ) 
SPI1 $10 + constant SPI1-CRCPR ( CRC polynomial register ) 
SPI1 $14 + constant SPI1-RXCRCR ( RX CRC register ) 
SPI1 $18 + constant SPI1-TXCRCR ( TX CRC register ) 
SPI1 $1C + constant SPI1-I2SCFGR ( I2S configuration register ) 
SPI1 $20 + constant SPI1-I2SPR ( I2S prescaler register ) 
