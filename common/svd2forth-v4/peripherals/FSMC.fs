\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$A0000000 constant FSMC ( Flexible static memory controller ) 
FSMC $0 + constant FSMC-BCR1 ( SRAM/NOR-Flash chip-select control register  1 ) 
FSMC $4 + constant FSMC-BTR1 ( SRAM/NOR-Flash chip-select timing register  1 ) 
FSMC $8 + constant FSMC-BCR2 ( SRAM/NOR-Flash chip-select control register  2 ) 
FSMC $C + constant FSMC-BTR2 ( SRAM/NOR-Flash chip-select timing register  2 ) 
FSMC $10 + constant FSMC-BCR3 ( SRAM/NOR-Flash chip-select control register  3 ) 
FSMC $14 + constant FSMC-BTR3 ( SRAM/NOR-Flash chip-select timing register  3 ) 
FSMC $18 + constant FSMC-BCR4 ( SRAM/NOR-Flash chip-select control register  4 ) 
FSMC $1C + constant FSMC-BTR4 ( SRAM/NOR-Flash chip-select timing register  4 ) 
FSMC $60 + constant FSMC-PCR2 ( PC Card/NAND Flash control register  2 ) 
FSMC $64 + constant FSMC-SR2 ( FIFO status and interrupt register  2 ) 
FSMC $68 + constant FSMC-PMEM2 ( Common memory space timing register  2 ) 
FSMC $6C + constant FSMC-PATT2 ( Attribute memory space timing register  2 ) 
FSMC $74 + constant FSMC-ECCR2 ( ECC result register 2 ) 
FSMC $80 + constant FSMC-PCR3 ( PC Card/NAND Flash control register  3 ) 
FSMC $84 + constant FSMC-SR3 ( FIFO status and interrupt register  3 ) 
FSMC $88 + constant FSMC-PMEM3 ( Common memory space timing register  3 ) 
FSMC $8C + constant FSMC-PATT3 ( Attribute memory space timing register  3 ) 
FSMC $94 + constant FSMC-ECCR3 ( ECC result register 3 ) 
FSMC $A0 + constant FSMC-PCR4 ( PC Card/NAND Flash control register  4 ) 
FSMC $A4 + constant FSMC-SR4 ( FIFO status and interrupt register  4 ) 
FSMC $A8 + constant FSMC-PMEM4 ( Common memory space timing register  4 ) 
FSMC $AC + constant FSMC-PATT4 ( Attribute memory space timing register  4 ) 
FSMC $B0 + constant FSMC-PIO4 ( I/O space timing register 4 ) 
FSMC $104 + constant FSMC-BWTR1 ( SRAM/NOR-Flash write timing registers  1 ) 
FSMC $10C + constant FSMC-BWTR2 ( SRAM/NOR-Flash write timing registers  2 ) 
FSMC $114 + constant FSMC-BWTR3 ( SRAM/NOR-Flash write timing registers  3 ) 
FSMC $11C + constant FSMC-BWTR4 ( SRAM/NOR-Flash write timing registers  4 ) 
