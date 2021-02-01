\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$E0042000 constant DBG ( Debug support ) 
DBG $0 + constant DBG-IDCODE ( DBGMCU_IDCODE ) 
DBG $4 + constant DBG-CR ( DBGMCU_CR ) 
