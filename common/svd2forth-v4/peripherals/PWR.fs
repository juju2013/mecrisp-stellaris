\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40007000 constant PWR ( Power control ) 
PWR $0 + constant PWR-CR ( Power control register  PWR_CR ) 
PWR $4 + constant PWR-CSR ( Power control register  PWR_CR ) 
