\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40021000 constant RCC ( Reset and clock control ) 
RCC 0x0 + constant RCC-CR ( Clock control register ) 
RCC 0x4 + constant RCC-CFGR ( Clock configuration register  RCC_CFGR ) 
RCC 0x8 + constant RCC-CIR ( Clock interrupt register  RCC_CIR ) 
RCC 0xC + constant RCC-APB2RSTR ( APB2 peripheral reset register  RCC_APB2RSTR ) 
RCC 0x10 + constant RCC-APB1RSTR ( APB1 peripheral reset register  RCC_APB1RSTR ) 
RCC 0x14 + constant RCC-AHBENR ( AHB Peripheral Clock enable register  RCC_AHBENR ) 
RCC 0x18 + constant RCC-APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
RCC 0x1C + constant RCC-APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
RCC 0x20 + constant RCC-BDCR ( Backup domain control register  RCC_BDCR ) 
RCC 0x24 + constant RCC-CSR ( Control/status register  RCC_CSR ) 
