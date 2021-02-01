\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40010400 constant EXTI ( EXTI ) 
EXTI $0 + constant EXTI-IMR ( Interrupt mask register  EXTI_IMR ) 
EXTI $4 + constant EXTI-EMR ( Event mask register EXTI_EMR ) 
EXTI $8 + constant EXTI-RTSR ( Rising Trigger selection register  EXTI_RTSR ) 
EXTI $C + constant EXTI-FTSR ( Falling Trigger selection register  EXTI_FTSR ) 
EXTI $10 + constant EXTI-SWIER ( Software interrupt event register  EXTI_SWIER ) 
EXTI $14 + constant EXTI-PR ( Pending register EXTI_PR ) 
