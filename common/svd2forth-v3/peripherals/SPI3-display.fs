\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: SPI3-CR1. ." SPI3-CR1 (read-write) $" SPI3-CR1 @ hex. SPI3-CR1 1b. ;
: SPI3-CR2. ." SPI3-CR2 (read-write) $" SPI3-CR2 @ hex. SPI3-CR2 1b. ;
: SPI3-SR. ." SPI3-SR () $" SPI3-SR @ hex. SPI3-SR 1b. ;
: SPI3-DR. ." SPI3-DR (read-write) $" SPI3-DR @ hex. SPI3-DR 1b. ;
: SPI3-CRCPR. ." SPI3-CRCPR (read-write) $" SPI3-CRCPR @ hex. SPI3-CRCPR 1b. ;
: SPI3-RXCRCR. ." SPI3-RXCRCR (read-only) $" SPI3-RXCRCR @ hex. SPI3-RXCRCR 1b. ;
: SPI3-TXCRCR. ." SPI3-TXCRCR (read-only) $" SPI3-TXCRCR @ hex. SPI3-TXCRCR 1b. ;
: SPI3-I2SCFGR. ." SPI3-I2SCFGR (read-write) $" SPI3-I2SCFGR @ hex. SPI3-I2SCFGR 1b. ;
: SPI3-I2SPR. ." SPI3-I2SPR (read-write) $" SPI3-I2SPR @ hex. SPI3-I2SPR 1b. ;
: SPI3.
SPI3-CR1.
SPI3-CR2.
SPI3-SR.
SPI3-DR.
SPI3-CRCPR.
SPI3-RXCRCR.
SPI3-TXCRCR.
SPI3-I2SCFGR.
SPI3-I2SPR.
;

