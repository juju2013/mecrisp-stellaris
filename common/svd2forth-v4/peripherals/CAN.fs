\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40006400 constant CAN ( Controller area network ) 
CAN $0 + constant CAN-CAN_MCR ( CAN_MCR ) 
CAN $4 + constant CAN-CAN_MSR ( CAN_MSR ) 
CAN $8 + constant CAN-CAN_TSR ( CAN_TSR ) 
CAN $C + constant CAN-CAN_RF0R ( CAN_RF0R ) 
CAN $10 + constant CAN-CAN_RF1R ( CAN_RF1R ) 
CAN $14 + constant CAN-CAN_IER ( CAN_IER ) 
CAN $18 + constant CAN-CAN_ESR ( CAN_ESR ) 
CAN $1C + constant CAN-CAN_BTR ( CAN_BTR ) 
CAN $180 + constant CAN-CAN_TI0R ( CAN_TI0R ) 
CAN $184 + constant CAN-CAN_TDT0R ( CAN_TDT0R ) 
CAN $188 + constant CAN-CAN_TDL0R ( CAN_TDL0R ) 
CAN $18C + constant CAN-CAN_TDH0R ( CAN_TDH0R ) 
CAN $190 + constant CAN-CAN_TI1R ( CAN_TI1R ) 
CAN $194 + constant CAN-CAN_TDT1R ( CAN_TDT1R ) 
CAN $198 + constant CAN-CAN_TDL1R ( CAN_TDL1R ) 
CAN $19C + constant CAN-CAN_TDH1R ( CAN_TDH1R ) 
CAN $1A0 + constant CAN-CAN_TI2R ( CAN_TI2R ) 
CAN $1A4 + constant CAN-CAN_TDT2R ( CAN_TDT2R ) 
CAN $1A8 + constant CAN-CAN_TDL2R ( CAN_TDL2R ) 
CAN $1AC + constant CAN-CAN_TDH2R ( CAN_TDH2R ) 
CAN $1B0 + constant CAN-CAN_RI0R ( CAN_RI0R ) 
CAN $1B4 + constant CAN-CAN_RDT0R ( CAN_RDT0R ) 
CAN $1B8 + constant CAN-CAN_RDL0R ( CAN_RDL0R ) 
CAN $1BC + constant CAN-CAN_RDH0R ( CAN_RDH0R ) 
CAN $1C0 + constant CAN-CAN_RI1R ( CAN_RI1R ) 
CAN $1C4 + constant CAN-CAN_RDT1R ( CAN_RDT1R ) 
CAN $1C8 + constant CAN-CAN_RDL1R ( CAN_RDL1R ) 
CAN $1CC + constant CAN-CAN_RDH1R ( CAN_RDH1R ) 
CAN $200 + constant CAN-CAN_FMR ( CAN_FMR ) 
CAN $204 + constant CAN-CAN_FM1R ( CAN_FM1R ) 
CAN $20C + constant CAN-CAN_FS1R ( CAN_FS1R ) 
CAN $214 + constant CAN-CAN_FFA1R ( CAN_FFA1R ) 
CAN $21C + constant CAN-CAN_FA1R ( CAN_FA1R ) 
CAN $240 + constant CAN-F0R1 ( Filter bank 0 register 1 ) 
CAN $244 + constant CAN-F0R2 ( Filter bank 0 register 2 ) 
CAN $248 + constant CAN-F1R1 ( Filter bank 1 register 1 ) 
CAN $24C + constant CAN-F1R2 ( Filter bank 1 register 2 ) 
CAN $250 + constant CAN-F2R1 ( Filter bank 2 register 1 ) 
CAN $254 + constant CAN-F2R2 ( Filter bank 2 register 2 ) 
CAN $258 + constant CAN-F3R1 ( Filter bank 3 register 1 ) 
CAN $25C + constant CAN-F3R2 ( Filter bank 3 register 2 ) 
CAN $260 + constant CAN-F4R1 ( Filter bank 4 register 1 ) 
CAN $264 + constant CAN-F4R2 ( Filter bank 4 register 2 ) 
CAN $268 + constant CAN-F5R1 ( Filter bank 5 register 1 ) 
CAN $26C + constant CAN-F5R2 ( Filter bank 5 register 2 ) 
CAN $270 + constant CAN-F6R1 ( Filter bank 6 register 1 ) 
CAN $274 + constant CAN-F6R2 ( Filter bank 6 register 2 ) 
CAN $278 + constant CAN-F7R1 ( Filter bank 7 register 1 ) 
CAN $27C + constant CAN-F7R2 ( Filter bank 7 register 2 ) 
CAN $280 + constant CAN-F8R1 ( Filter bank 8 register 1 ) 
CAN $284 + constant CAN-F8R2 ( Filter bank 8 register 2 ) 
CAN $288 + constant CAN-F9R1 ( Filter bank 9 register 1 ) 
CAN $28C + constant CAN-F9R2 ( Filter bank 9 register 2 ) 
CAN $290 + constant CAN-F10R1 ( Filter bank 10 register 1 ) 
CAN $294 + constant CAN-F10R2 ( Filter bank 10 register 2 ) 
CAN $298 + constant CAN-F11R1 ( Filter bank 11 register 1 ) 
CAN $29C + constant CAN-F11R2 ( Filter bank 11 register 2 ) 
CAN $2A0 + constant CAN-F12R1 ( Filter bank 4 register 1 ) 
CAN $2A4 + constant CAN-F12R2 ( Filter bank 12 register 2 ) 
CAN $2A8 + constant CAN-F13R1 ( Filter bank 13 register 1 ) 
CAN $2AC + constant CAN-F13R2 ( Filter bank 13 register 2 ) 
