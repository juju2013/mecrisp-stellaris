\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40007400 constant DAC ( Digital to analog converter ) 
DAC 0x0 + constant DAC-CR ( Control register DAC_CR ) 
DAC 0x4 + constant DAC-SWTRIGR ( DAC software trigger register  DAC_SWTRIGR ) 
DAC 0x8 + constant DAC-DHR12R1 ( DAC channel1 12-bit right-aligned data  holding registerDAC_DHR12R1 ) 
DAC 0xC + constant DAC-DHR12L1 ( DAC channel1 12-bit left aligned data  holding register DAC_DHR12L1 ) 
DAC 0x10 + constant DAC-DHR8R1 ( DAC channel1 8-bit right aligned data  holding register DAC_DHR8R1 ) 
DAC 0x14 + constant DAC-DHR12R2 ( DAC channel2 12-bit right aligned data  holding register DAC_DHR12R2 ) 
DAC 0x18 + constant DAC-DHR12L2 ( DAC channel2 12-bit left aligned data  holding register DAC_DHR12L2 ) 
DAC 0x1C + constant DAC-DHR8R2 ( DAC channel2 8-bit right-aligned data  holding register DAC_DHR8R2 ) 
DAC 0x20 + constant DAC-DHR12RD ( Dual DAC 12-bit right-aligned data holding  register DAC_DHR12RD, Bits 31:28 Reserved, Bits 15:12  Reserved ) 
DAC 0x24 + constant DAC-DHR12LD ( DUAL DAC 12-bit left aligned data holding  register DAC_DHR12LD, Bits 19:16 Reserved, Bits 3:0  Reserved ) 
DAC 0x28 + constant DAC-DHR8RD ( DUAL DAC 8-bit right aligned data holding  register DAC_DHR8RD, Bits 31:16 Reserved ) 
DAC 0x2C + constant DAC-DOR1 ( DAC channel1 data output register  DAC_DOR1 ) 
DAC 0x30 + constant DAC-DOR2 ( DAC channel2 data output register  DAC_DOR2 ) 
