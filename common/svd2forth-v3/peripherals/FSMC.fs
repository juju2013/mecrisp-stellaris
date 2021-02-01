\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0xA0000000 constant FSMC ( Flexible static memory controller ) 
FSMC 0x0 + constant FSMC-BCR1 ( SRAM/NOR-Flash chip-select control register  1 ) 
FSMC 0x4 + constant FSMC-BTR1 ( SRAM/NOR-Flash chip-select timing register  1 ) 
FSMC 0x8 + constant FSMC-BCR2 ( SRAM/NOR-Flash chip-select control register  2 ) 
FSMC 0xC + constant FSMC-BTR2 ( SRAM/NOR-Flash chip-select timing register  2 ) 
FSMC 0x10 + constant FSMC-BCR3 ( SRAM/NOR-Flash chip-select control register  3 ) 
FSMC 0x14 + constant FSMC-BTR3 ( SRAM/NOR-Flash chip-select timing register  3 ) 
FSMC 0x18 + constant FSMC-BCR4 ( SRAM/NOR-Flash chip-select control register  4 ) 
FSMC 0x1C + constant FSMC-BTR4 ( SRAM/NOR-Flash chip-select timing register  4 ) 
FSMC 0x60 + constant FSMC-PCR2 ( PC Card/NAND Flash control register  2 ) 
FSMC 0x64 + constant FSMC-SR2 ( FIFO status and interrupt register  2 ) 
FSMC 0x68 + constant FSMC-PMEM2 ( Common memory space timing register  2 ) 
FSMC 0x6C + constant FSMC-PATT2 ( Attribute memory space timing register  2 ) 
FSMC 0x74 + constant FSMC-ECCR2 ( ECC result register 2 ) 
FSMC 0x80 + constant FSMC-PCR3 ( PC Card/NAND Flash control register  3 ) 
FSMC 0x84 + constant FSMC-SR3 ( FIFO status and interrupt register  3 ) 
FSMC 0x88 + constant FSMC-PMEM3 ( Common memory space timing register  3 ) 
FSMC 0x8C + constant FSMC-PATT3 ( Attribute memory space timing register  3 ) 
FSMC 0x94 + constant FSMC-ECCR3 ( ECC result register 3 ) 
FSMC 0xA0 + constant FSMC-PCR4 ( PC Card/NAND Flash control register  4 ) 
FSMC 0xA4 + constant FSMC-SR4 ( FIFO status and interrupt register  4 ) 
FSMC 0xA8 + constant FSMC-PMEM4 ( Common memory space timing register  4 ) 
FSMC 0xAC + constant FSMC-PATT4 ( Attribute memory space timing register  4 ) 
FSMC 0xB0 + constant FSMC-PIO4 ( I/O space timing register 4 ) 
FSMC 0x104 + constant FSMC-BWTR1 ( SRAM/NOR-Flash write timing registers  1 ) 
FSMC 0x10C + constant FSMC-BWTR2 ( SRAM/NOR-Flash write timing registers  2 ) 
FSMC 0x114 + constant FSMC-BWTR3 ( SRAM/NOR-Flash write timing registers  3 ) 
FSMC 0x11C + constant FSMC-BWTR4 ( SRAM/NOR-Flash write timing registers  4 ) 
