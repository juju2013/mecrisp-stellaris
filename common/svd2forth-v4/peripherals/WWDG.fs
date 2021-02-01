\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40002C00 constant WWDG ( Window watchdog ) 
WWDG $0 + constant WWDG-CR ( Control register WWDG_CR ) 
WWDG $4 + constant WWDG-CFR ( Configuration register  WWDG_CFR ) 
WWDG $8 + constant WWDG-SR ( Status register WWDG_SR ) 
