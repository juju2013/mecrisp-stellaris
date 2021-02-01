\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40018000 constant SDIO ( Secure digital input/output  interface ) 
SDIO $0 + constant SDIO-POWER ( Bits 1:0 = PWRCTRL: Power supply control  bits ) 
SDIO $4 + constant SDIO-CLKCR ( SDI clock control register  SDIO_CLKCR ) 
SDIO $8 + constant SDIO-ARG ( Bits 31:0 = : Command argument ) 
SDIO $C + constant SDIO-CMD ( SDIO command register  SDIO_CMD ) 
SDIO $10 + constant SDIO-RESPCMD ( SDIO command register ) 
SDIO $14 + constant SDIO-RESPI1 ( Bits 31:0 = CARDSTATUS1 ) 
SDIO $18 + constant SDIO-RESP2 ( Bits 31:0 = CARDSTATUS2 ) 
SDIO $1C + constant SDIO-RESP3 ( Bits 31:0 = CARDSTATUS3 ) 
SDIO $20 + constant SDIO-RESP4 ( Bits 31:0 = CARDSTATUS4 ) 
SDIO $24 + constant SDIO-DTIMER ( Bits 31:0 = DATATIME: Data timeout  period ) 
SDIO $28 + constant SDIO-DLEN ( Bits 24:0 = DATALENGTH: Data length  value ) 
SDIO $2C + constant SDIO-DCTRL ( SDIO data control register  SDIO_DCTRL ) 
SDIO $30 + constant SDIO-DCOUNT ( Bits 24:0 = DATACOUNT: Data count  value ) 
SDIO $34 + constant SDIO-STA ( SDIO status register  SDIO_STA ) 
SDIO $38 + constant SDIO-ICR ( SDIO interrupt clear register  SDIO_ICR ) 
SDIO $3C + constant SDIO-MASK ( SDIO mask register SDIO_MASK ) 
SDIO $48 + constant SDIO-FIFOCNT ( Bits 23:0 = FIFOCOUNT: Remaining number of  words to be written to or read from the  FIFO ) 
SDIO $80 + constant SDIO-FIFO ( bits 31:0 = FIFOData: Receive and transmit  FIFO data ) 
