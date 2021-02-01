\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40022000 constant FLASH ( FLASH ) 
FLASH 0x0 + constant FLASH-ACR ( Flash access control register ) 
FLASH 0x4 + constant FLASH-KEYR ( Flash key register ) 
FLASH 0x8 + constant FLASH-OPTKEYR ( Flash option key register ) 
FLASH 0xC + constant FLASH-SR ( Status register ) 
FLASH 0x10 + constant FLASH-CR ( Control register ) 
FLASH 0x14 + constant FLASH-AR ( Flash address register ) 
FLASH 0x1C + constant FLASH-OBR ( Option byte register ) 
FLASH 0x20 + constant FLASH-WRPR ( Write protection register ) 
