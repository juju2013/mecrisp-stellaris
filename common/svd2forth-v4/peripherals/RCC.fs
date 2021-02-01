\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40021000 constant RCC ( Reset and clock control ) 
RCC $0 + constant RCC-CR ( Clock control register ) 
RCC $4 + constant RCC-CFGR ( Clock configuration register  RCC_CFGR ) 
RCC $8 + constant RCC-CIR ( Clock interrupt register  RCC_CIR ) 
RCC $C + constant RCC-APB2RSTR ( APB2 peripheral reset register  RCC_APB2RSTR ) 
RCC $10 + constant RCC-APB1RSTR ( APB1 peripheral reset register  RCC_APB1RSTR ) 
RCC $14 + constant RCC-AHBENR ( AHB Peripheral Clock enable register  RCC_AHBENR ) 
RCC $18 + constant RCC-APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
RCC $1C + constant RCC-APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
RCC $20 + constant RCC-BDCR ( Backup domain control register  RCC_BDCR ) 
RCC $24 + constant RCC-CSR ( Control/status register  RCC_CSR ) 
