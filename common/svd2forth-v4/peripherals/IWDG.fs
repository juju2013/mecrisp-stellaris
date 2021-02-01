\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40003000 constant IWDG ( Independent watchdog ) 
IWDG $0 + constant IWDG-KR ( Key register IWDG_KR ) 
IWDG $4 + constant IWDG-PR ( Prescaler register IWDG_PR ) 
IWDG $8 + constant IWDG-RLR ( Reload register IWDG_RLR ) 
IWDG $C + constant IWDG-SR ( Status register IWDG_SR ) 
