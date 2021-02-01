\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40023000 constant CRC ( CRC calculation unit ) 
CRC $0 + constant CRC-DR ( Data register ) 
CRC $4 + constant CRC-IDR ( Independent Data register ) 
CRC $8 + constant CRC-CR ( Control register ) 
