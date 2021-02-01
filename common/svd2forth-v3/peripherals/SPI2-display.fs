\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: SPI2-CR1. ." SPI2-CR1 (read-write) $" SPI2-CR1 @ hex. SPI2-CR1 1b. ;
: SPI2-CR2. ." SPI2-CR2 (read-write) $" SPI2-CR2 @ hex. SPI2-CR2 1b. ;
: SPI2-SR. ." SPI2-SR () $" SPI2-SR @ hex. SPI2-SR 1b. ;
: SPI2-DR. ." SPI2-DR (read-write) $" SPI2-DR @ hex. SPI2-DR 1b. ;
: SPI2-CRCPR. ." SPI2-CRCPR (read-write) $" SPI2-CRCPR @ hex. SPI2-CRCPR 1b. ;
: SPI2-RXCRCR. ." SPI2-RXCRCR (read-only) $" SPI2-RXCRCR @ hex. SPI2-RXCRCR 1b. ;
: SPI2-TXCRCR. ." SPI2-TXCRCR (read-only) $" SPI2-TXCRCR @ hex. SPI2-TXCRCR 1b. ;
: SPI2-I2SCFGR. ." SPI2-I2SCFGR (read-write) $" SPI2-I2SCFGR @ hex. SPI2-I2SCFGR 1b. ;
: SPI2-I2SPR. ." SPI2-I2SPR (read-write) $" SPI2-I2SPR @ hex. SPI2-I2SPR 1b. ;
: SPI2.
SPI2-CR1.
SPI2-CR2.
SPI2-SR.
SPI2-DR.
SPI2-CRCPR.
SPI2-RXCRCR.
SPI2-TXCRCR.
SPI2-I2SCFGR.
SPI2-I2SPR.
;

