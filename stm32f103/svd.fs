\ Program Name: 1b.fs  for Mecrisp-Stellaris by Matthias Koch and licensed under the GPL
\ Copyright 2019 t.porter <terry@tjporter.com.au> and licensed under the BSD license.
\ This program must be loaded before memmap.fs as it provided the pretty printing legend for generic 32 bit prints
\ Also included is "bin." which prints the binary form of a number with no spaces between numbers for easy copy and pasting purposes

compiletoflash

: b32loop. ( u -- ) \ print 32 bits in 1 bit groups
0  <#
31 0 DO 
# 32 HOLD LOOP
# #>
TYPE ;

: b32sloop. ( u -- ) \ print 32 bits in 1 bit groups
 0  <#
 31 0 DO
 # LOOP
 # #>
 TYPE ;


: 1b. ( u -- ) cr \ Label 1 bit generic groups
." 3|3|2|2|2|2|2|2|2|2|2|2|1|1|1|1|1|1|1|1|1|1|" cr
." 1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0 " cr
@ binary b32loop. decimal cr ;

: bin. cr         \ for manual operations producing easy to paste binary numbers i.e. " 10 bin. "
." 3322222222221111111111" cr
." 10987654321098765432109876543210 " cr
binary b32sloop. decimal cr ;

compiletoram



\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

$A0000000 constant FSMC ( Flexible static memory controller ) 
FSMC $0 + constant FSMC_BCR1 ( SRAM/NOR-Flash chip-select control register  1 ) 
FSMC $4 + constant FSMC_BTR1 ( SRAM/NOR-Flash chip-select timing register  1 ) 
FSMC $8 + constant FSMC_BCR2 ( SRAM/NOR-Flash chip-select control register  2 ) 
FSMC $C + constant FSMC_BTR2 ( SRAM/NOR-Flash chip-select timing register  2 ) 
FSMC $10 + constant FSMC_BCR3 ( SRAM/NOR-Flash chip-select control register  3 ) 
FSMC $14 + constant FSMC_BTR3 ( SRAM/NOR-Flash chip-select timing register  3 ) 
FSMC $18 + constant FSMC_BCR4 ( SRAM/NOR-Flash chip-select control register  4 ) 
FSMC $1C + constant FSMC_BTR4 ( SRAM/NOR-Flash chip-select timing register  4 ) 
FSMC $60 + constant FSMC_PCR2 ( PC Card/NAND Flash control register  2 ) 
FSMC $64 + constant FSMC_SR2 ( FIFO status and interrupt register  2 ) 
FSMC $68 + constant FSMC_PMEM2 ( Common memory space timing register  2 ) 
FSMC $6C + constant FSMC_PATT2 ( Attribute memory space timing register  2 ) 
FSMC $74 + constant FSMC_ECCR2 ( ECC result register 2 ) 
FSMC $80 + constant FSMC_PCR3 ( PC Card/NAND Flash control register  3 ) 
FSMC $84 + constant FSMC_SR3 ( FIFO status and interrupt register  3 ) 
FSMC $88 + constant FSMC_PMEM3 ( Common memory space timing register  3 ) 
FSMC $8C + constant FSMC_PATT3 ( Attribute memory space timing register  3 ) 
FSMC $94 + constant FSMC_ECCR3 ( ECC result register 3 ) 
FSMC $A0 + constant FSMC_PCR4 ( PC Card/NAND Flash control register  4 ) 
FSMC $A4 + constant FSMC_SR4 ( FIFO status and interrupt register  4 ) 
FSMC $A8 + constant FSMC_PMEM4 ( Common memory space timing register  4 ) 
FSMC $AC + constant FSMC_PATT4 ( Attribute memory space timing register  4 ) 
FSMC $B0 + constant FSMC_PIO4 ( I/O space timing register 4 ) 
FSMC $104 + constant FSMC_BWTR1 ( SRAM/NOR-Flash write timing registers  1 ) 
FSMC $10C + constant FSMC_BWTR2 ( SRAM/NOR-Flash write timing registers  2 ) 
FSMC $114 + constant FSMC_BWTR3 ( SRAM/NOR-Flash write timing registers  3 ) 
FSMC $11C + constant FSMC_BWTR4 ( SRAM/NOR-Flash write timing registers  4 ) 
: FSMC_BCR1. cr ." FSMC_BCR1 (read-write) $" FSMC_BCR1 @ hex. FSMC_BCR1 1b. ;
: FSMC_BTR1. cr ." FSMC_BTR1 (read-write) $" FSMC_BTR1 @ hex. FSMC_BTR1 1b. ;
: FSMC_BCR2. cr ." FSMC_BCR2 (read-write) $" FSMC_BCR2 @ hex. FSMC_BCR2 1b. ;
: FSMC_BTR2. cr ." FSMC_BTR2 (read-write) $" FSMC_BTR2 @ hex. FSMC_BTR2 1b. ;
: FSMC_BCR3. cr ." FSMC_BCR3 (read-write) $" FSMC_BCR3 @ hex. FSMC_BCR3 1b. ;
: FSMC_BTR3. cr ." FSMC_BTR3 (read-write) $" FSMC_BTR3 @ hex. FSMC_BTR3 1b. ;
: FSMC_BCR4. cr ." FSMC_BCR4 (read-write) $" FSMC_BCR4 @ hex. FSMC_BCR4 1b. ;
: FSMC_BTR4. cr ." FSMC_BTR4 (read-write) $" FSMC_BTR4 @ hex. FSMC_BTR4 1b. ;
: FSMC_PCR2. cr ." FSMC_PCR2 (read-write) $" FSMC_PCR2 @ hex. FSMC_PCR2 1b. ;
: FSMC_SR2. cr ." FSMC_SR2 () $" FSMC_SR2 @ hex. FSMC_SR2 1b. ;
: FSMC_PMEM2. cr ." FSMC_PMEM2 (read-write) $" FSMC_PMEM2 @ hex. FSMC_PMEM2 1b. ;
: FSMC_PATT2. cr ." FSMC_PATT2 (read-write) $" FSMC_PATT2 @ hex. FSMC_PATT2 1b. ;
: FSMC_ECCR2. cr ." FSMC_ECCR2 (read-only) $" FSMC_ECCR2 @ hex. FSMC_ECCR2 1b. ;
: FSMC_PCR3. cr ." FSMC_PCR3 (read-write) $" FSMC_PCR3 @ hex. FSMC_PCR3 1b. ;
: FSMC_SR3. cr ." FSMC_SR3 () $" FSMC_SR3 @ hex. FSMC_SR3 1b. ;
: FSMC_PMEM3. cr ." FSMC_PMEM3 (read-write) $" FSMC_PMEM3 @ hex. FSMC_PMEM3 1b. ;
: FSMC_PATT3. cr ." FSMC_PATT3 (read-write) $" FSMC_PATT3 @ hex. FSMC_PATT3 1b. ;
: FSMC_ECCR3. cr ." FSMC_ECCR3 (read-only) $" FSMC_ECCR3 @ hex. FSMC_ECCR3 1b. ;
: FSMC_PCR4. cr ." FSMC_PCR4 (read-write) $" FSMC_PCR4 @ hex. FSMC_PCR4 1b. ;
: FSMC_SR4. cr ." FSMC_SR4 () $" FSMC_SR4 @ hex. FSMC_SR4 1b. ;
: FSMC_PMEM4. cr ." FSMC_PMEM4 (read-write) $" FSMC_PMEM4 @ hex. FSMC_PMEM4 1b. ;
: FSMC_PATT4. cr ." FSMC_PATT4 (read-write) $" FSMC_PATT4 @ hex. FSMC_PATT4 1b. ;
: FSMC_PIO4. cr ." FSMC_PIO4 (read-write) $" FSMC_PIO4 @ hex. FSMC_PIO4 1b. ;
: FSMC_BWTR1. cr ." FSMC_BWTR1 (read-write) $" FSMC_BWTR1 @ hex. FSMC_BWTR1 1b. ;
: FSMC_BWTR2. cr ." FSMC_BWTR2 (read-write) $" FSMC_BWTR2 @ hex. FSMC_BWTR2 1b. ;
: FSMC_BWTR3. cr ." FSMC_BWTR3 (read-write) $" FSMC_BWTR3 @ hex. FSMC_BWTR3 1b. ;
: FSMC_BWTR4. cr ." FSMC_BWTR4 (read-write) $" FSMC_BWTR4 @ hex. FSMC_BWTR4 1b. ;
: FSMC.
FSMC_BCR1.
FSMC_BTR1.
FSMC_BCR2.
FSMC_BTR2.
FSMC_BCR3.
FSMC_BTR3.
FSMC_BCR4.
FSMC_BTR4.
FSMC_PCR2.
FSMC_SR2.
FSMC_PMEM2.
FSMC_PATT2.
FSMC_ECCR2.
FSMC_PCR3.
FSMC_SR3.
FSMC_PMEM3.
FSMC_PATT3.
FSMC_ECCR3.
FSMC_PCR4.
FSMC_SR4.
FSMC_PMEM4.
FSMC_PATT4.
FSMC_PIO4.
FSMC_BWTR1.
FSMC_BWTR2.
FSMC_BWTR3.
FSMC_BWTR4.
;

$40007000 constant PWR ( Power control ) 
PWR $0 + constant PWR_CR ( Power control register  PWR_CR ) 
PWR $4 + constant PWR_CSR ( Power control register  PWR_CR ) 
: PWR_CR. cr ." PWR_CR (read-write) $" PWR_CR @ hex. PWR_CR 1b. ;
: PWR_CSR. cr ." PWR_CSR () $" PWR_CSR @ hex. PWR_CSR 1b. ;
: PWR.
PWR_CR.
PWR_CSR.
;

$40021000 constant RCC ( Reset and clock control ) 
RCC $0 + constant RCC_CR ( Clock control register ) 
RCC $4 + constant RCC_CFGR ( Clock configuration register  RCC_CFGR ) 
RCC $8 + constant RCC_CIR ( Clock interrupt register  RCC_CIR ) 
RCC $C + constant RCC_APB2RSTR ( APB2 peripheral reset register  RCC_APB2RSTR ) 
RCC $10 + constant RCC_APB1RSTR ( APB1 peripheral reset register  RCC_APB1RSTR ) 
RCC $14 + constant RCC_AHBENR ( AHB Peripheral Clock enable register  RCC_AHBENR ) 
RCC $18 + constant RCC_APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
RCC $1C + constant RCC_APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
RCC $20 + constant RCC_BDCR ( Backup domain control register  RCC_BDCR ) 
RCC $24 + constant RCC_CSR ( Control/status register  RCC_CSR ) 
: RCC_CR. cr ." RCC_CR () $" RCC_CR @ hex. RCC_CR 1b. ;
: RCC_CFGR. cr ." RCC_CFGR () $" RCC_CFGR @ hex. RCC_CFGR 1b. ;
: RCC_CIR. cr ." RCC_CIR () $" RCC_CIR @ hex. RCC_CIR 1b. ;
: RCC_APB2RSTR. cr ." RCC_APB2RSTR (read-write) $" RCC_APB2RSTR @ hex. RCC_APB2RSTR 1b. ;
: RCC_APB1RSTR. cr ." RCC_APB1RSTR (read-write) $" RCC_APB1RSTR @ hex. RCC_APB1RSTR 1b. ;
: RCC_AHBENR. cr ." RCC_AHBENR (read-write) $" RCC_AHBENR @ hex. RCC_AHBENR 1b. ;
: RCC_APB2ENR. cr ." RCC_APB2ENR (read-write) $" RCC_APB2ENR @ hex. RCC_APB2ENR 1b. ;
: RCC_APB1ENR. cr ." RCC_APB1ENR (read-write) $" RCC_APB1ENR @ hex. RCC_APB1ENR 1b. ;
: RCC_BDCR. cr ." RCC_BDCR () $" RCC_BDCR @ hex. RCC_BDCR 1b. ;
: RCC_CSR. cr ." RCC_CSR () $" RCC_CSR @ hex. RCC_CSR 1b. ;
: RCC.
RCC_CR.
RCC_CFGR.
RCC_CIR.
RCC_APB2RSTR.
RCC_APB1RSTR.
RCC_AHBENR.
RCC_APB2ENR.
RCC_APB1ENR.
RCC_BDCR.
RCC_CSR.
;

$40010800 constant GPIOA ( General purpose I/O ) 
GPIOA $0 + constant GPIOA_CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOA $4 + constant GPIOA_CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOA $8 + constant GPIOA_IDR ( Port input data register  GPIOn_IDR ) 
GPIOA $C + constant GPIOA_ODR ( Port output data register  GPIOn_ODR ) 
GPIOA $10 + constant GPIOA_BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOA $14 + constant GPIOA_BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOA $18 + constant GPIOA_LCKR ( Port configuration lock  register ) 
: GPIOA_CRL. cr ." GPIOA_CRL (read-write) $" GPIOA_CRL @ hex. GPIOA_CRL 1b. ;
: GPIOA_CRH. cr ." GPIOA_CRH (read-write) $" GPIOA_CRH @ hex. GPIOA_CRH 1b. ;
: GPIOA_IDR. cr ." GPIOA_IDR (read-only) $" GPIOA_IDR @ hex. GPIOA_IDR 1b. ;
: GPIOA_ODR. cr ." GPIOA_ODR (read-write) $" GPIOA_ODR @ hex. GPIOA_ODR 1b. ;
: GPIOA_BSRR. cr ." GPIOA_BSRR (write-only) $" GPIOA_BSRR @ hex. GPIOA_BSRR 1b. ;
: GPIOA_BRR. cr ." GPIOA_BRR (write-only) $" GPIOA_BRR @ hex. GPIOA_BRR 1b. ;
: GPIOA_LCKR. cr ." GPIOA_LCKR (read-write) $" GPIOA_LCKR @ hex. GPIOA_LCKR 1b. ;
: GPIOA.
GPIOA_CRL.
GPIOA_CRH.
GPIOA_IDR.
GPIOA_ODR.
GPIOA_BSRR.
GPIOA_BRR.
GPIOA_LCKR.
;

$40010C00 constant GPIOB ( General purpose I/O ) 
GPIOB $0 + constant GPIOB_CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOB $4 + constant GPIOB_CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOB $8 + constant GPIOB_IDR ( Port input data register  GPIOn_IDR ) 
GPIOB $C + constant GPIOB_ODR ( Port output data register  GPIOn_ODR ) 
GPIOB $10 + constant GPIOB_BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOB $14 + constant GPIOB_BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOB $18 + constant GPIOB_LCKR ( Port configuration lock  register ) 
: GPIOB_CRL. cr ." GPIOB_CRL (read-write) $" GPIOB_CRL @ hex. GPIOB_CRL 1b. ;
: GPIOB_CRH. cr ." GPIOB_CRH (read-write) $" GPIOB_CRH @ hex. GPIOB_CRH 1b. ;
: GPIOB_IDR. cr ." GPIOB_IDR (read-only) $" GPIOB_IDR @ hex. GPIOB_IDR 1b. ;
: GPIOB_ODR. cr ." GPIOB_ODR (read-write) $" GPIOB_ODR @ hex. GPIOB_ODR 1b. ;
: GPIOB_BSRR. cr ." GPIOB_BSRR (write-only) $" GPIOB_BSRR @ hex. GPIOB_BSRR 1b. ;
: GPIOB_BRR. cr ." GPIOB_BRR (write-only) $" GPIOB_BRR @ hex. GPIOB_BRR 1b. ;
: GPIOB_LCKR. cr ." GPIOB_LCKR (read-write) $" GPIOB_LCKR @ hex. GPIOB_LCKR 1b. ;
: GPIOB.
GPIOB_CRL.
GPIOB_CRH.
GPIOB_IDR.
GPIOB_ODR.
GPIOB_BSRR.
GPIOB_BRR.
GPIOB_LCKR.
;

$40011000 constant GPIOC ( General purpose I/O ) 
GPIOC $0 + constant GPIOC_CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOC $4 + constant GPIOC_CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOC $8 + constant GPIOC_IDR ( Port input data register  GPIOn_IDR ) 
GPIOC $C + constant GPIOC_ODR ( Port output data register  GPIOn_ODR ) 
GPIOC $10 + constant GPIOC_BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOC $14 + constant GPIOC_BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOC $18 + constant GPIOC_LCKR ( Port configuration lock  register ) 
: GPIOC_CRL. cr ." GPIOC_CRL (read-write) $" GPIOC_CRL @ hex. GPIOC_CRL 1b. ;
: GPIOC_CRH. cr ." GPIOC_CRH (read-write) $" GPIOC_CRH @ hex. GPIOC_CRH 1b. ;
: GPIOC_IDR. cr ." GPIOC_IDR (read-only) $" GPIOC_IDR @ hex. GPIOC_IDR 1b. ;
: GPIOC_ODR. cr ." GPIOC_ODR (read-write) $" GPIOC_ODR @ hex. GPIOC_ODR 1b. ;
: GPIOC_BSRR. cr ." GPIOC_BSRR (write-only) $" GPIOC_BSRR @ hex. GPIOC_BSRR 1b. ;
: GPIOC_BRR. cr ." GPIOC_BRR (write-only) $" GPIOC_BRR @ hex. GPIOC_BRR 1b. ;
: GPIOC_LCKR. cr ." GPIOC_LCKR (read-write) $" GPIOC_LCKR @ hex. GPIOC_LCKR 1b. ;
: GPIOC.
GPIOC_CRL.
GPIOC_CRH.
GPIOC_IDR.
GPIOC_ODR.
GPIOC_BSRR.
GPIOC_BRR.
GPIOC_LCKR.
;

$40011400 constant GPIOD ( General purpose I/O ) 
GPIOD $0 + constant GPIOD_CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOD $4 + constant GPIOD_CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOD $8 + constant GPIOD_IDR ( Port input data register  GPIOn_IDR ) 
GPIOD $C + constant GPIOD_ODR ( Port output data register  GPIOn_ODR ) 
GPIOD $10 + constant GPIOD_BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOD $14 + constant GPIOD_BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOD $18 + constant GPIOD_LCKR ( Port configuration lock  register ) 
: GPIOD_CRL. cr ." GPIOD_CRL (read-write) $" GPIOD_CRL @ hex. GPIOD_CRL 1b. ;
: GPIOD_CRH. cr ." GPIOD_CRH (read-write) $" GPIOD_CRH @ hex. GPIOD_CRH 1b. ;
: GPIOD_IDR. cr ." GPIOD_IDR (read-only) $" GPIOD_IDR @ hex. GPIOD_IDR 1b. ;
: GPIOD_ODR. cr ." GPIOD_ODR (read-write) $" GPIOD_ODR @ hex. GPIOD_ODR 1b. ;
: GPIOD_BSRR. cr ." GPIOD_BSRR (write-only) $" GPIOD_BSRR @ hex. GPIOD_BSRR 1b. ;
: GPIOD_BRR. cr ." GPIOD_BRR (write-only) $" GPIOD_BRR @ hex. GPIOD_BRR 1b. ;
: GPIOD_LCKR. cr ." GPIOD_LCKR (read-write) $" GPIOD_LCKR @ hex. GPIOD_LCKR 1b. ;
: GPIOD.
GPIOD_CRL.
GPIOD_CRH.
GPIOD_IDR.
GPIOD_ODR.
GPIOD_BSRR.
GPIOD_BRR.
GPIOD_LCKR.
;

$40011800 constant GPIOE ( General purpose I/O ) 
GPIOE $0 + constant GPIOE_CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOE $4 + constant GPIOE_CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOE $8 + constant GPIOE_IDR ( Port input data register  GPIOn_IDR ) 
GPIOE $C + constant GPIOE_ODR ( Port output data register  GPIOn_ODR ) 
GPIOE $10 + constant GPIOE_BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOE $14 + constant GPIOE_BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOE $18 + constant GPIOE_LCKR ( Port configuration lock  register ) 
: GPIOE_CRL. cr ." GPIOE_CRL (read-write) $" GPIOE_CRL @ hex. GPIOE_CRL 1b. ;
: GPIOE_CRH. cr ." GPIOE_CRH (read-write) $" GPIOE_CRH @ hex. GPIOE_CRH 1b. ;
: GPIOE_IDR. cr ." GPIOE_IDR (read-only) $" GPIOE_IDR @ hex. GPIOE_IDR 1b. ;
: GPIOE_ODR. cr ." GPIOE_ODR (read-write) $" GPIOE_ODR @ hex. GPIOE_ODR 1b. ;
: GPIOE_BSRR. cr ." GPIOE_BSRR (write-only) $" GPIOE_BSRR @ hex. GPIOE_BSRR 1b. ;
: GPIOE_BRR. cr ." GPIOE_BRR (write-only) $" GPIOE_BRR @ hex. GPIOE_BRR 1b. ;
: GPIOE_LCKR. cr ." GPIOE_LCKR (read-write) $" GPIOE_LCKR @ hex. GPIOE_LCKR 1b. ;
: GPIOE.
GPIOE_CRL.
GPIOE_CRH.
GPIOE_IDR.
GPIOE_ODR.
GPIOE_BSRR.
GPIOE_BRR.
GPIOE_LCKR.
;

$40011C00 constant GPIOF ( General purpose I/O ) 
GPIOF $0 + constant GPIOF_CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOF $4 + constant GPIOF_CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOF $8 + constant GPIOF_IDR ( Port input data register  GPIOn_IDR ) 
GPIOF $C + constant GPIOF_ODR ( Port output data register  GPIOn_ODR ) 
GPIOF $10 + constant GPIOF_BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOF $14 + constant GPIOF_BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOF $18 + constant GPIOF_LCKR ( Port configuration lock  register ) 
: GPIOF_CRL. cr ." GPIOF_CRL (read-write) $" GPIOF_CRL @ hex. GPIOF_CRL 1b. ;
: GPIOF_CRH. cr ." GPIOF_CRH (read-write) $" GPIOF_CRH @ hex. GPIOF_CRH 1b. ;
: GPIOF_IDR. cr ." GPIOF_IDR (read-only) $" GPIOF_IDR @ hex. GPIOF_IDR 1b. ;
: GPIOF_ODR. cr ." GPIOF_ODR (read-write) $" GPIOF_ODR @ hex. GPIOF_ODR 1b. ;
: GPIOF_BSRR. cr ." GPIOF_BSRR (write-only) $" GPIOF_BSRR @ hex. GPIOF_BSRR 1b. ;
: GPIOF_BRR. cr ." GPIOF_BRR (write-only) $" GPIOF_BRR @ hex. GPIOF_BRR 1b. ;
: GPIOF_LCKR. cr ." GPIOF_LCKR (read-write) $" GPIOF_LCKR @ hex. GPIOF_LCKR 1b. ;
: GPIOF.
GPIOF_CRL.
GPIOF_CRH.
GPIOF_IDR.
GPIOF_ODR.
GPIOF_BSRR.
GPIOF_BRR.
GPIOF_LCKR.
;

$40012000 constant GPIOG ( General purpose I/O ) 
GPIOG $0 + constant GPIOG_CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOG $4 + constant GPIOG_CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOG $8 + constant GPIOG_IDR ( Port input data register  GPIOn_IDR ) 
GPIOG $C + constant GPIOG_ODR ( Port output data register  GPIOn_ODR ) 
GPIOG $10 + constant GPIOG_BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOG $14 + constant GPIOG_BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOG $18 + constant GPIOG_LCKR ( Port configuration lock  register ) 
: GPIOG_CRL. cr ." GPIOG_CRL (read-write) $" GPIOG_CRL @ hex. GPIOG_CRL 1b. ;
: GPIOG_CRH. cr ." GPIOG_CRH (read-write) $" GPIOG_CRH @ hex. GPIOG_CRH 1b. ;
: GPIOG_IDR. cr ." GPIOG_IDR (read-only) $" GPIOG_IDR @ hex. GPIOG_IDR 1b. ;
: GPIOG_ODR. cr ." GPIOG_ODR (read-write) $" GPIOG_ODR @ hex. GPIOG_ODR 1b. ;
: GPIOG_BSRR. cr ." GPIOG_BSRR (write-only) $" GPIOG_BSRR @ hex. GPIOG_BSRR 1b. ;
: GPIOG_BRR. cr ." GPIOG_BRR (write-only) $" GPIOG_BRR @ hex. GPIOG_BRR 1b. ;
: GPIOG_LCKR. cr ." GPIOG_LCKR (read-write) $" GPIOG_LCKR @ hex. GPIOG_LCKR 1b. ;
: GPIOG.
GPIOG_CRL.
GPIOG_CRH.
GPIOG_IDR.
GPIOG_ODR.
GPIOG_BSRR.
GPIOG_BRR.
GPIOG_LCKR.
;

$40010000 constant AFIO ( Alternate function I/O ) 
AFIO $0 + constant AFIO_EVCR ( Event Control Register  AFIO_EVCR ) 
AFIO $4 + constant AFIO_MAPR ( AF remap and debug I/O configuration  register AFIO_MAPR ) 
AFIO $8 + constant AFIO_EXTICR1 ( External interrupt configuration register 1  AFIO_EXTICR1 ) 
AFIO $C + constant AFIO_EXTICR2 ( External interrupt configuration register 2  AFIO_EXTICR2 ) 
AFIO $10 + constant AFIO_EXTICR3 ( External interrupt configuration register 3  AFIO_EXTICR3 ) 
AFIO $14 + constant AFIO_EXTICR4 ( External interrupt configuration register 4  AFIO_EXTICR4 ) 
AFIO $1C + constant AFIO_MAPR2 ( AF remap and debug I/O configuration  register ) 
: AFIO_EVCR. cr ." AFIO_EVCR (read-write) $" AFIO_EVCR @ hex. AFIO_EVCR 1b. ;
: AFIO_MAPR. cr ." AFIO_MAPR () $" AFIO_MAPR @ hex. AFIO_MAPR 1b. ;
: AFIO_EXTICR1. cr ." AFIO_EXTICR1 (read-write) $" AFIO_EXTICR1 @ hex. AFIO_EXTICR1 1b. ;
: AFIO_EXTICR2. cr ." AFIO_EXTICR2 (read-write) $" AFIO_EXTICR2 @ hex. AFIO_EXTICR2 1b. ;
: AFIO_EXTICR3. cr ." AFIO_EXTICR3 (read-write) $" AFIO_EXTICR3 @ hex. AFIO_EXTICR3 1b. ;
: AFIO_EXTICR4. cr ." AFIO_EXTICR4 (read-write) $" AFIO_EXTICR4 @ hex. AFIO_EXTICR4 1b. ;
: AFIO_MAPR2. cr ." AFIO_MAPR2 (read-write) $" AFIO_MAPR2 @ hex. AFIO_MAPR2 1b. ;
: AFIO.
AFIO_EVCR.
AFIO_MAPR.
AFIO_EXTICR1.
AFIO_EXTICR2.
AFIO_EXTICR3.
AFIO_EXTICR4.
AFIO_MAPR2.
;

$40010400 constant EXTI ( EXTI ) 
EXTI $0 + constant EXTI_IMR ( Interrupt mask register  EXTI_IMR ) 
EXTI $4 + constant EXTI_EMR ( Event mask register EXTI_EMR ) 
EXTI $8 + constant EXTI_RTSR ( Rising Trigger selection register  EXTI_RTSR ) 
EXTI $C + constant EXTI_FTSR ( Falling Trigger selection register  EXTI_FTSR ) 
EXTI $10 + constant EXTI_SWIER ( Software interrupt event register  EXTI_SWIER ) 
EXTI $14 + constant EXTI_PR ( Pending register EXTI_PR ) 
: EXTI_IMR. cr ." EXTI_IMR (read-write) $" EXTI_IMR @ hex. EXTI_IMR 1b. ;
: EXTI_EMR. cr ." EXTI_EMR (read-write) $" EXTI_EMR @ hex. EXTI_EMR 1b. ;
: EXTI_RTSR. cr ." EXTI_RTSR (read-write) $" EXTI_RTSR @ hex. EXTI_RTSR 1b. ;
: EXTI_FTSR. cr ." EXTI_FTSR (read-write) $" EXTI_FTSR @ hex. EXTI_FTSR 1b. ;
: EXTI_SWIER. cr ." EXTI_SWIER (read-write) $" EXTI_SWIER @ hex. EXTI_SWIER 1b. ;
: EXTI_PR. cr ." EXTI_PR (read-write) $" EXTI_PR @ hex. EXTI_PR 1b. ;
: EXTI.
EXTI_IMR.
EXTI_EMR.
EXTI_RTSR.
EXTI_FTSR.
EXTI_SWIER.
EXTI_PR.
;

$40020000 constant DMA1 ( DMA controller ) 
DMA1 $0 + constant DMA1_ISR ( DMA interrupt status register  DMA_ISR ) 
DMA1 $4 + constant DMA1_IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA1 $8 + constant DMA1_CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $C + constant DMA1_CNDTR1 ( DMA channel 1 number of data  register ) 
DMA1 $10 + constant DMA1_CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA1 $14 + constant DMA1_CMAR1 ( DMA channel 1 memory address  register ) 
DMA1 $1C + constant DMA1_CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $20 + constant DMA1_CNDTR2 ( DMA channel 2 number of data  register ) 
DMA1 $24 + constant DMA1_CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA1 $28 + constant DMA1_CMAR2 ( DMA channel 2 memory address  register ) 
DMA1 $30 + constant DMA1_CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $34 + constant DMA1_CNDTR3 ( DMA channel 3 number of data  register ) 
DMA1 $38 + constant DMA1_CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA1 $3C + constant DMA1_CMAR3 ( DMA channel 3 memory address  register ) 
DMA1 $44 + constant DMA1_CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $48 + constant DMA1_CNDTR4 ( DMA channel 4 number of data  register ) 
DMA1 $4C + constant DMA1_CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA1 $50 + constant DMA1_CMAR4 ( DMA channel 4 memory address  register ) 
DMA1 $58 + constant DMA1_CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $5C + constant DMA1_CNDTR5 ( DMA channel 5 number of data  register ) 
DMA1 $60 + constant DMA1_CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA1 $64 + constant DMA1_CMAR5 ( DMA channel 5 memory address  register ) 
DMA1 $6C + constant DMA1_CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $70 + constant DMA1_CNDTR6 ( DMA channel 6 number of data  register ) 
DMA1 $74 + constant DMA1_CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA1 $78 + constant DMA1_CMAR6 ( DMA channel 6 memory address  register ) 
DMA1 $80 + constant DMA1_CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $84 + constant DMA1_CNDTR7 ( DMA channel 7 number of data  register ) 
DMA1 $88 + constant DMA1_CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA1 $8C + constant DMA1_CMAR7 ( DMA channel 7 memory address  register ) 
: DMA1_ISR. cr ." DMA1_ISR (read-only) $" DMA1_ISR @ hex. DMA1_ISR 1b. ;
: DMA1_IFCR. cr ." DMA1_IFCR (write-only) $" DMA1_IFCR @ hex. DMA1_IFCR 1b. ;
: DMA1_CCR1. cr ." DMA1_CCR1 (read-write) $" DMA1_CCR1 @ hex. DMA1_CCR1 1b. ;
: DMA1_CNDTR1. cr ." DMA1_CNDTR1 (read-write) $" DMA1_CNDTR1 @ hex. DMA1_CNDTR1 1b. ;
: DMA1_CPAR1. cr ." DMA1_CPAR1 (read-write) $" DMA1_CPAR1 @ hex. DMA1_CPAR1 1b. ;
: DMA1_CMAR1. cr ." DMA1_CMAR1 (read-write) $" DMA1_CMAR1 @ hex. DMA1_CMAR1 1b. ;
: DMA1_CCR2. cr ." DMA1_CCR2 (read-write) $" DMA1_CCR2 @ hex. DMA1_CCR2 1b. ;
: DMA1_CNDTR2. cr ." DMA1_CNDTR2 (read-write) $" DMA1_CNDTR2 @ hex. DMA1_CNDTR2 1b. ;
: DMA1_CPAR2. cr ." DMA1_CPAR2 (read-write) $" DMA1_CPAR2 @ hex. DMA1_CPAR2 1b. ;
: DMA1_CMAR2. cr ." DMA1_CMAR2 (read-write) $" DMA1_CMAR2 @ hex. DMA1_CMAR2 1b. ;
: DMA1_CCR3. cr ." DMA1_CCR3 (read-write) $" DMA1_CCR3 @ hex. DMA1_CCR3 1b. ;
: DMA1_CNDTR3. cr ." DMA1_CNDTR3 (read-write) $" DMA1_CNDTR3 @ hex. DMA1_CNDTR3 1b. ;
: DMA1_CPAR3. cr ." DMA1_CPAR3 (read-write) $" DMA1_CPAR3 @ hex. DMA1_CPAR3 1b. ;
: DMA1_CMAR3. cr ." DMA1_CMAR3 (read-write) $" DMA1_CMAR3 @ hex. DMA1_CMAR3 1b. ;
: DMA1_CCR4. cr ." DMA1_CCR4 (read-write) $" DMA1_CCR4 @ hex. DMA1_CCR4 1b. ;
: DMA1_CNDTR4. cr ." DMA1_CNDTR4 (read-write) $" DMA1_CNDTR4 @ hex. DMA1_CNDTR4 1b. ;
: DMA1_CPAR4. cr ." DMA1_CPAR4 (read-write) $" DMA1_CPAR4 @ hex. DMA1_CPAR4 1b. ;
: DMA1_CMAR4. cr ." DMA1_CMAR4 (read-write) $" DMA1_CMAR4 @ hex. DMA1_CMAR4 1b. ;
: DMA1_CCR5. cr ." DMA1_CCR5 (read-write) $" DMA1_CCR5 @ hex. DMA1_CCR5 1b. ;
: DMA1_CNDTR5. cr ." DMA1_CNDTR5 (read-write) $" DMA1_CNDTR5 @ hex. DMA1_CNDTR5 1b. ;
: DMA1_CPAR5. cr ." DMA1_CPAR5 (read-write) $" DMA1_CPAR5 @ hex. DMA1_CPAR5 1b. ;
: DMA1_CMAR5. cr ." DMA1_CMAR5 (read-write) $" DMA1_CMAR5 @ hex. DMA1_CMAR5 1b. ;
: DMA1_CCR6. cr ." DMA1_CCR6 (read-write) $" DMA1_CCR6 @ hex. DMA1_CCR6 1b. ;
: DMA1_CNDTR6. cr ." DMA1_CNDTR6 (read-write) $" DMA1_CNDTR6 @ hex. DMA1_CNDTR6 1b. ;
: DMA1_CPAR6. cr ." DMA1_CPAR6 (read-write) $" DMA1_CPAR6 @ hex. DMA1_CPAR6 1b. ;
: DMA1_CMAR6. cr ." DMA1_CMAR6 (read-write) $" DMA1_CMAR6 @ hex. DMA1_CMAR6 1b. ;
: DMA1_CCR7. cr ." DMA1_CCR7 (read-write) $" DMA1_CCR7 @ hex. DMA1_CCR7 1b. ;
: DMA1_CNDTR7. cr ." DMA1_CNDTR7 (read-write) $" DMA1_CNDTR7 @ hex. DMA1_CNDTR7 1b. ;
: DMA1_CPAR7. cr ." DMA1_CPAR7 (read-write) $" DMA1_CPAR7 @ hex. DMA1_CPAR7 1b. ;
: DMA1_CMAR7. cr ." DMA1_CMAR7 (read-write) $" DMA1_CMAR7 @ hex. DMA1_CMAR7 1b. ;
: DMA1.
DMA1_ISR.
DMA1_IFCR.
DMA1_CCR1.
DMA1_CNDTR1.
DMA1_CPAR1.
DMA1_CMAR1.
DMA1_CCR2.
DMA1_CNDTR2.
DMA1_CPAR2.
DMA1_CMAR2.
DMA1_CCR3.
DMA1_CNDTR3.
DMA1_CPAR3.
DMA1_CMAR3.
DMA1_CCR4.
DMA1_CNDTR4.
DMA1_CPAR4.
DMA1_CMAR4.
DMA1_CCR5.
DMA1_CNDTR5.
DMA1_CPAR5.
DMA1_CMAR5.
DMA1_CCR6.
DMA1_CNDTR6.
DMA1_CPAR6.
DMA1_CMAR6.
DMA1_CCR7.
DMA1_CNDTR7.
DMA1_CPAR7.
DMA1_CMAR7.
;

$40018000 constant SDIO ( Secure digital input/output  interface ) 
SDIO $0 + constant SDIO_POWER ( Bits 1:0 = PWRCTRL: Power supply control  bits ) 
SDIO $4 + constant SDIO_CLKCR ( SDI clock control register  SDIO_CLKCR ) 
SDIO $8 + constant SDIO_ARG ( Bits 31:0 = : Command argument ) 
SDIO $C + constant SDIO_CMD ( SDIO command register  SDIO_CMD ) 
SDIO $10 + constant SDIO_RESPCMD ( SDIO command register ) 
SDIO $14 + constant SDIO_RESPI1 ( Bits 31:0 = CARDSTATUS1 ) 
SDIO $18 + constant SDIO_RESP2 ( Bits 31:0 = CARDSTATUS2 ) 
SDIO $1C + constant SDIO_RESP3 ( Bits 31:0 = CARDSTATUS3 ) 
SDIO $20 + constant SDIO_RESP4 ( Bits 31:0 = CARDSTATUS4 ) 
SDIO $24 + constant SDIO_DTIMER ( Bits 31:0 = DATATIME: Data timeout  period ) 
SDIO $28 + constant SDIO_DLEN ( Bits 24:0 = DATALENGTH: Data length  value ) 
SDIO $2C + constant SDIO_DCTRL ( SDIO data control register  SDIO_DCTRL ) 
SDIO $30 + constant SDIO_DCOUNT ( Bits 24:0 = DATACOUNT: Data count  value ) 
SDIO $34 + constant SDIO_STA ( SDIO status register  SDIO_STA ) 
SDIO $38 + constant SDIO_ICR ( SDIO interrupt clear register  SDIO_ICR ) 
SDIO $3C + constant SDIO_MASK ( SDIO mask register SDIO_MASK ) 
SDIO $48 + constant SDIO_FIFOCNT ( Bits 23:0 = FIFOCOUNT: Remaining number of  words to be written to or read from the  FIFO ) 
SDIO $80 + constant SDIO_FIFO ( bits 31:0 = FIFOData: Receive and transmit  FIFO data ) 
: SDIO_POWER. cr ." SDIO_POWER (read-write) $" SDIO_POWER @ hex. SDIO_POWER 1b. ;
: SDIO_CLKCR. cr ." SDIO_CLKCR (read-write) $" SDIO_CLKCR @ hex. SDIO_CLKCR 1b. ;
: SDIO_ARG. cr ." SDIO_ARG (read-write) $" SDIO_ARG @ hex. SDIO_ARG 1b. ;
: SDIO_CMD. cr ." SDIO_CMD (read-write) $" SDIO_CMD @ hex. SDIO_CMD 1b. ;
: SDIO_RESPCMD. cr ." SDIO_RESPCMD (read-only) $" SDIO_RESPCMD @ hex. SDIO_RESPCMD 1b. ;
: SDIO_RESPI1. cr ." SDIO_RESPI1 (read-only) $" SDIO_RESPI1 @ hex. SDIO_RESPI1 1b. ;
: SDIO_RESP2. cr ." SDIO_RESP2 (read-only) $" SDIO_RESP2 @ hex. SDIO_RESP2 1b. ;
: SDIO_RESP3. cr ." SDIO_RESP3 (read-only) $" SDIO_RESP3 @ hex. SDIO_RESP3 1b. ;
: SDIO_RESP4. cr ." SDIO_RESP4 (read-only) $" SDIO_RESP4 @ hex. SDIO_RESP4 1b. ;
: SDIO_DTIMER. cr ." SDIO_DTIMER (read-write) $" SDIO_DTIMER @ hex. SDIO_DTIMER 1b. ;
: SDIO_DLEN. cr ." SDIO_DLEN (read-write) $" SDIO_DLEN @ hex. SDIO_DLEN 1b. ;
: SDIO_DCTRL. cr ." SDIO_DCTRL (read-write) $" SDIO_DCTRL @ hex. SDIO_DCTRL 1b. ;
: SDIO_DCOUNT. cr ." SDIO_DCOUNT (read-only) $" SDIO_DCOUNT @ hex. SDIO_DCOUNT 1b. ;
: SDIO_STA. cr ." SDIO_STA (read-only) $" SDIO_STA @ hex. SDIO_STA 1b. ;
: SDIO_ICR. cr ." SDIO_ICR (read-write) $" SDIO_ICR @ hex. SDIO_ICR 1b. ;
: SDIO_MASK. cr ." SDIO_MASK (read-write) $" SDIO_MASK @ hex. SDIO_MASK 1b. ;
: SDIO_FIFOCNT. cr ." SDIO_FIFOCNT (read-only) $" SDIO_FIFOCNT @ hex. SDIO_FIFOCNT 1b. ;
: SDIO_FIFO. cr ." SDIO_FIFO (read-write) $" SDIO_FIFO @ hex. SDIO_FIFO 1b. ;
: SDIO.
SDIO_POWER.
SDIO_CLKCR.
SDIO_ARG.
SDIO_CMD.
SDIO_RESPCMD.
SDIO_RESPI1.
SDIO_RESP2.
SDIO_RESP3.
SDIO_RESP4.
SDIO_DTIMER.
SDIO_DLEN.
SDIO_DCTRL.
SDIO_DCOUNT.
SDIO_STA.
SDIO_ICR.
SDIO_MASK.
SDIO_FIFOCNT.
SDIO_FIFO.
;

$40002800 constant RTC ( Real time clock ) 
RTC $0 + constant RTC_CRH ( RTC Control Register High ) 
RTC $4 + constant RTC_CRL ( RTC Control Register Low ) 
RTC $8 + constant RTC_PRLH ( RTC Prescaler Load Register  High ) 
RTC $C + constant RTC_PRLL ( RTC Prescaler Load Register  Low ) 
RTC $10 + constant RTC_DIVH ( RTC Prescaler Divider Register  High ) 
RTC $14 + constant RTC_DIVL ( RTC Prescaler Divider Register  Low ) 
RTC $18 + constant RTC_CNTH ( RTC Counter Register High ) 
RTC $1C + constant RTC_CNTL ( RTC Counter Register Low ) 
RTC $20 + constant RTC_ALRH ( RTC Alarm Register High ) 
RTC $24 + constant RTC_ALRL ( RTC Alarm Register Low ) 
: RTC_CRH. cr ." RTC_CRH (read-write) $" RTC_CRH @ hex. RTC_CRH 1b. ;
: RTC_CRL. cr ." RTC_CRL () $" RTC_CRL @ hex. RTC_CRL 1b. ;
: RTC_PRLH. cr ." RTC_PRLH (write-only) $" RTC_PRLH @ hex. RTC_PRLH 1b. ;
: RTC_PRLL. cr ." RTC_PRLL (write-only) $" RTC_PRLL @ hex. RTC_PRLL 1b. ;
: RTC_DIVH. cr ." RTC_DIVH (read-only) $" RTC_DIVH @ hex. RTC_DIVH 1b. ;
: RTC_DIVL. cr ." RTC_DIVL (read-only) $" RTC_DIVL @ hex. RTC_DIVL 1b. ;
: RTC_CNTH. cr ." RTC_CNTH (read-write) $" RTC_CNTH @ hex. RTC_CNTH 1b. ;
: RTC_CNTL. cr ." RTC_CNTL (read-write) $" RTC_CNTL @ hex. RTC_CNTL 1b. ;
: RTC_ALRH. cr ." RTC_ALRH (write-only) $" RTC_ALRH @ hex. RTC_ALRH 1b. ;
: RTC_ALRL. cr ." RTC_ALRL (write-only) $" RTC_ALRL @ hex. RTC_ALRL 1b. ;
: RTC.
RTC_CRH.
RTC_CRL.
RTC_PRLH.
RTC_PRLL.
RTC_DIVH.
RTC_DIVL.
RTC_CNTH.
RTC_CNTL.
RTC_ALRH.
RTC_ALRL.
;

$40003000 constant IWDG ( Independent watchdog ) 
IWDG $0 + constant IWDG_KR ( Key register IWDG_KR ) 
IWDG $4 + constant IWDG_PR ( Prescaler register IWDG_PR ) 
IWDG $8 + constant IWDG_RLR ( Reload register IWDG_RLR ) 
IWDG $C + constant IWDG_SR ( Status register IWDG_SR ) 
: IWDG_KR. cr ." IWDG_KR (write-only) $" IWDG_KR @ hex. IWDG_KR 1b. ;
: IWDG_PR. cr ." IWDG_PR (read-write) $" IWDG_PR @ hex. IWDG_PR 1b. ;
: IWDG_RLR. cr ." IWDG_RLR (read-write) $" IWDG_RLR @ hex. IWDG_RLR 1b. ;
: IWDG_SR. cr ." IWDG_SR (read-only) $" IWDG_SR @ hex. IWDG_SR 1b. ;
: IWDG.
IWDG_KR.
IWDG_PR.
IWDG_RLR.
IWDG_SR.
;

$40002C00 constant WWDG ( Window watchdog ) 
WWDG $0 + constant WWDG_CR ( Control register WWDG_CR ) 
WWDG $4 + constant WWDG_CFR ( Configuration register  WWDG_CFR ) 
WWDG $8 + constant WWDG_SR ( Status register WWDG_SR ) 
: WWDG_CR. cr ." WWDG_CR (read-write) $" WWDG_CR @ hex. WWDG_CR 1b. ;
: WWDG_CFR. cr ." WWDG_CFR (read-write) $" WWDG_CFR @ hex. WWDG_CFR 1b. ;
: WWDG_SR. cr ." WWDG_SR (read-write) $" WWDG_SR @ hex. WWDG_SR 1b. ;
: WWDG.
WWDG_CR.
WWDG_CFR.
WWDG_SR.
;

$40012C00 constant TIM1 ( Advanced timer ) 
TIM1 $0 + constant TIM1_CR1 ( control register 1 ) 
TIM1 $4 + constant TIM1_CR2 ( control register 2 ) 
TIM1 $8 + constant TIM1_SMCR ( slave mode control register ) 
TIM1 $C + constant TIM1_DIER ( DMA/Interrupt enable register ) 
TIM1 $10 + constant TIM1_SR ( status register ) 
TIM1 $14 + constant TIM1_EGR ( event generation register ) 
TIM1 $18 + constant TIM1_CCMR1_Output ( capture/compare mode register output  mode ) 
TIM1 $18 + constant TIM1_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM1 $1C + constant TIM1_CCMR2_Output ( capture/compare mode register output  mode ) 
TIM1 $1C + constant TIM1_CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM1 $20 + constant TIM1_CCER ( capture/compare enable  register ) 
TIM1 $24 + constant TIM1_CNT ( counter ) 
TIM1 $28 + constant TIM1_PSC ( prescaler ) 
TIM1 $2C + constant TIM1_ARR ( auto-reload register ) 
TIM1 $34 + constant TIM1_CCR1 ( capture/compare register 1 ) 
TIM1 $38 + constant TIM1_CCR2 ( capture/compare register 2 ) 
TIM1 $3C + constant TIM1_CCR3 ( capture/compare register 3 ) 
TIM1 $40 + constant TIM1_CCR4 ( capture/compare register 4 ) 
TIM1 $48 + constant TIM1_DCR ( DMA control register ) 
TIM1 $4C + constant TIM1_DMAR ( DMA address for full transfer ) 
TIM1 $30 + constant TIM1_RCR ( repetition counter register ) 
TIM1 $44 + constant TIM1_BDTR ( break and dead-time register ) 
: TIM1_CR1. cr ." TIM1_CR1 (read-write) $" TIM1_CR1 @ hex. TIM1_CR1 1b. ;
: TIM1_CR2. cr ." TIM1_CR2 (read-write) $" TIM1_CR2 @ hex. TIM1_CR2 1b. ;
: TIM1_SMCR. cr ." TIM1_SMCR (read-write) $" TIM1_SMCR @ hex. TIM1_SMCR 1b. ;
: TIM1_DIER. cr ." TIM1_DIER (read-write) $" TIM1_DIER @ hex. TIM1_DIER 1b. ;
: TIM1_SR. cr ." TIM1_SR (read-write) $" TIM1_SR @ hex. TIM1_SR 1b. ;
: TIM1_EGR. cr ." TIM1_EGR (write-only) $" TIM1_EGR @ hex. TIM1_EGR 1b. ;
: TIM1_CCMR1_Output. cr ." TIM1_CCMR1_Output (read-write) $" TIM1_CCMR1_Output @ hex. TIM1_CCMR1_Output 1b. ;
: TIM1_CCMR1_Input. cr ." TIM1_CCMR1_Input (read-write) $" TIM1_CCMR1_Input @ hex. TIM1_CCMR1_Input 1b. ;
: TIM1_CCMR2_Output. cr ." TIM1_CCMR2_Output (read-write) $" TIM1_CCMR2_Output @ hex. TIM1_CCMR2_Output 1b. ;
: TIM1_CCMR2_Input. cr ." TIM1_CCMR2_Input (read-write) $" TIM1_CCMR2_Input @ hex. TIM1_CCMR2_Input 1b. ;
: TIM1_CCER. cr ." TIM1_CCER (read-write) $" TIM1_CCER @ hex. TIM1_CCER 1b. ;
: TIM1_CNT. cr ." TIM1_CNT (read-write) $" TIM1_CNT @ hex. TIM1_CNT 1b. ;
: TIM1_PSC. cr ." TIM1_PSC (read-write) $" TIM1_PSC @ hex. TIM1_PSC 1b. ;
: TIM1_ARR. cr ." TIM1_ARR (read-write) $" TIM1_ARR @ hex. TIM1_ARR 1b. ;
: TIM1_CCR1. cr ." TIM1_CCR1 (read-write) $" TIM1_CCR1 @ hex. TIM1_CCR1 1b. ;
: TIM1_CCR2. cr ." TIM1_CCR2 (read-write) $" TIM1_CCR2 @ hex. TIM1_CCR2 1b. ;
: TIM1_CCR3. cr ." TIM1_CCR3 (read-write) $" TIM1_CCR3 @ hex. TIM1_CCR3 1b. ;
: TIM1_CCR4. cr ." TIM1_CCR4 (read-write) $" TIM1_CCR4 @ hex. TIM1_CCR4 1b. ;
: TIM1_DCR. cr ." TIM1_DCR (read-write) $" TIM1_DCR @ hex. TIM1_DCR 1b. ;
: TIM1_DMAR. cr ." TIM1_DMAR (read-write) $" TIM1_DMAR @ hex. TIM1_DMAR 1b. ;
: TIM1_RCR. cr ." TIM1_RCR (read-write) $" TIM1_RCR @ hex. TIM1_RCR 1b. ;
: TIM1_BDTR. cr ." TIM1_BDTR (read-write) $" TIM1_BDTR @ hex. TIM1_BDTR 1b. ;
: TIM1.
TIM1_CR1.
TIM1_CR2.
TIM1_SMCR.
TIM1_DIER.
TIM1_SR.
TIM1_EGR.
TIM1_CCMR1_Output.
TIM1_CCMR1_Input.
TIM1_CCMR2_Output.
TIM1_CCMR2_Input.
TIM1_CCER.
TIM1_CNT.
TIM1_PSC.
TIM1_ARR.
TIM1_CCR1.
TIM1_CCR2.
TIM1_CCR3.
TIM1_CCR4.
TIM1_DCR.
TIM1_DMAR.
TIM1_RCR.
TIM1_BDTR.
;

$40013400 constant TIM8 ( Advanced timer ) 
TIM8 $0 + constant TIM8_CR1 ( control register 1 ) 
TIM8 $4 + constant TIM8_CR2 ( control register 2 ) 
TIM8 $8 + constant TIM8_SMCR ( slave mode control register ) 
TIM8 $C + constant TIM8_DIER ( DMA/Interrupt enable register ) 
TIM8 $10 + constant TIM8_SR ( status register ) 
TIM8 $14 + constant TIM8_EGR ( event generation register ) 
TIM8 $18 + constant TIM8_CCMR1_Output ( capture/compare mode register output  mode ) 
TIM8 $18 + constant TIM8_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM8 $1C + constant TIM8_CCMR2_Output ( capture/compare mode register output  mode ) 
TIM8 $1C + constant TIM8_CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM8 $20 + constant TIM8_CCER ( capture/compare enable  register ) 
TIM8 $24 + constant TIM8_CNT ( counter ) 
TIM8 $28 + constant TIM8_PSC ( prescaler ) 
TIM8 $2C + constant TIM8_ARR ( auto-reload register ) 
TIM8 $34 + constant TIM8_CCR1 ( capture/compare register 1 ) 
TIM8 $38 + constant TIM8_CCR2 ( capture/compare register 2 ) 
TIM8 $3C + constant TIM8_CCR3 ( capture/compare register 3 ) 
TIM8 $40 + constant TIM8_CCR4 ( capture/compare register 4 ) 
TIM8 $48 + constant TIM8_DCR ( DMA control register ) 
TIM8 $4C + constant TIM8_DMAR ( DMA address for full transfer ) 
TIM8 $30 + constant TIM8_RCR ( repetition counter register ) 
TIM8 $44 + constant TIM8_BDTR ( break and dead-time register ) 
: TIM8_CR1. cr ." TIM8_CR1 (read-write) $" TIM8_CR1 @ hex. TIM8_CR1 1b. ;
: TIM8_CR2. cr ." TIM8_CR2 (read-write) $" TIM8_CR2 @ hex. TIM8_CR2 1b. ;
: TIM8_SMCR. cr ." TIM8_SMCR (read-write) $" TIM8_SMCR @ hex. TIM8_SMCR 1b. ;
: TIM8_DIER. cr ." TIM8_DIER (read-write) $" TIM8_DIER @ hex. TIM8_DIER 1b. ;
: TIM8_SR. cr ." TIM8_SR (read-write) $" TIM8_SR @ hex. TIM8_SR 1b. ;
: TIM8_EGR. cr ." TIM8_EGR (write-only) $" TIM8_EGR @ hex. TIM8_EGR 1b. ;
: TIM8_CCMR1_Output. cr ." TIM8_CCMR1_Output (read-write) $" TIM8_CCMR1_Output @ hex. TIM8_CCMR1_Output 1b. ;
: TIM8_CCMR1_Input. cr ." TIM8_CCMR1_Input (read-write) $" TIM8_CCMR1_Input @ hex. TIM8_CCMR1_Input 1b. ;
: TIM8_CCMR2_Output. cr ." TIM8_CCMR2_Output (read-write) $" TIM8_CCMR2_Output @ hex. TIM8_CCMR2_Output 1b. ;
: TIM8_CCMR2_Input. cr ." TIM8_CCMR2_Input (read-write) $" TIM8_CCMR2_Input @ hex. TIM8_CCMR2_Input 1b. ;
: TIM8_CCER. cr ." TIM8_CCER (read-write) $" TIM8_CCER @ hex. TIM8_CCER 1b. ;
: TIM8_CNT. cr ." TIM8_CNT (read-write) $" TIM8_CNT @ hex. TIM8_CNT 1b. ;
: TIM8_PSC. cr ." TIM8_PSC (read-write) $" TIM8_PSC @ hex. TIM8_PSC 1b. ;
: TIM8_ARR. cr ." TIM8_ARR (read-write) $" TIM8_ARR @ hex. TIM8_ARR 1b. ;
: TIM8_CCR1. cr ." TIM8_CCR1 (read-write) $" TIM8_CCR1 @ hex. TIM8_CCR1 1b. ;
: TIM8_CCR2. cr ." TIM8_CCR2 (read-write) $" TIM8_CCR2 @ hex. TIM8_CCR2 1b. ;
: TIM8_CCR3. cr ." TIM8_CCR3 (read-write) $" TIM8_CCR3 @ hex. TIM8_CCR3 1b. ;
: TIM8_CCR4. cr ." TIM8_CCR4 (read-write) $" TIM8_CCR4 @ hex. TIM8_CCR4 1b. ;
: TIM8_DCR. cr ." TIM8_DCR (read-write) $" TIM8_DCR @ hex. TIM8_DCR 1b. ;
: TIM8_DMAR. cr ." TIM8_DMAR (read-write) $" TIM8_DMAR @ hex. TIM8_DMAR 1b. ;
: TIM8_RCR. cr ." TIM8_RCR (read-write) $" TIM8_RCR @ hex. TIM8_RCR 1b. ;
: TIM8_BDTR. cr ." TIM8_BDTR (read-write) $" TIM8_BDTR @ hex. TIM8_BDTR 1b. ;
: TIM8.
TIM8_CR1.
TIM8_CR2.
TIM8_SMCR.
TIM8_DIER.
TIM8_SR.
TIM8_EGR.
TIM8_CCMR1_Output.
TIM8_CCMR1_Input.
TIM8_CCMR2_Output.
TIM8_CCMR2_Input.
TIM8_CCER.
TIM8_CNT.
TIM8_PSC.
TIM8_ARR.
TIM8_CCR1.
TIM8_CCR2.
TIM8_CCR3.
TIM8_CCR4.
TIM8_DCR.
TIM8_DMAR.
TIM8_RCR.
TIM8_BDTR.
;

$40000000 constant TIM2 ( General purpose timer ) 
TIM2 $0 + constant TIM2_CR1 ( control register 1 ) 
TIM2 $4 + constant TIM2_CR2 ( control register 2 ) 
TIM2 $8 + constant TIM2_SMCR ( slave mode control register ) 
TIM2 $C + constant TIM2_DIER ( DMA/Interrupt enable register ) 
TIM2 $10 + constant TIM2_SR ( status register ) 
TIM2 $14 + constant TIM2_EGR ( event generation register ) 
TIM2 $18 + constant TIM2_CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM2 $18 + constant TIM2_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM2 $1C + constant TIM2_CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM2 $1C + constant TIM2_CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM2 $20 + constant TIM2_CCER ( capture/compare enable  register ) 
TIM2 $24 + constant TIM2_CNT ( counter ) 
TIM2 $28 + constant TIM2_PSC ( prescaler ) 
TIM2 $2C + constant TIM2_ARR ( auto-reload register ) 
TIM2 $34 + constant TIM2_CCR1 ( capture/compare register 1 ) 
TIM2 $38 + constant TIM2_CCR2 ( capture/compare register 2 ) 
TIM2 $3C + constant TIM2_CCR3 ( capture/compare register 3 ) 
TIM2 $40 + constant TIM2_CCR4 ( capture/compare register 4 ) 
TIM2 $48 + constant TIM2_DCR ( DMA control register ) 
TIM2 $4C + constant TIM2_DMAR ( DMA address for full transfer ) 
: TIM2_CR1. cr ." TIM2_CR1 (read-write) $" TIM2_CR1 @ hex. TIM2_CR1 1b. ;
: TIM2_CR2. cr ." TIM2_CR2 (read-write) $" TIM2_CR2 @ hex. TIM2_CR2 1b. ;
: TIM2_SMCR. cr ." TIM2_SMCR (read-write) $" TIM2_SMCR @ hex. TIM2_SMCR 1b. ;
: TIM2_DIER. cr ." TIM2_DIER (read-write) $" TIM2_DIER @ hex. TIM2_DIER 1b. ;
: TIM2_SR. cr ." TIM2_SR (read-write) $" TIM2_SR @ hex. TIM2_SR 1b. ;
: TIM2_EGR. cr ." TIM2_EGR (write-only) $" TIM2_EGR @ hex. TIM2_EGR 1b. ;
: TIM2_CCMR1_Output. cr ." TIM2_CCMR1_Output (read-write) $" TIM2_CCMR1_Output @ hex. TIM2_CCMR1_Output 1b. ;
: TIM2_CCMR1_Input. cr ." TIM2_CCMR1_Input (read-write) $" TIM2_CCMR1_Input @ hex. TIM2_CCMR1_Input 1b. ;
: TIM2_CCMR2_Output. cr ." TIM2_CCMR2_Output (read-write) $" TIM2_CCMR2_Output @ hex. TIM2_CCMR2_Output 1b. ;
: TIM2_CCMR2_Input. cr ." TIM2_CCMR2_Input (read-write) $" TIM2_CCMR2_Input @ hex. TIM2_CCMR2_Input 1b. ;
: TIM2_CCER. cr ." TIM2_CCER (read-write) $" TIM2_CCER @ hex. TIM2_CCER 1b. ;
: TIM2_CNT. cr ." TIM2_CNT (read-write) $" TIM2_CNT @ hex. TIM2_CNT 1b. ;
: TIM2_PSC. cr ." TIM2_PSC (read-write) $" TIM2_PSC @ hex. TIM2_PSC 1b. ;
: TIM2_ARR. cr ." TIM2_ARR (read-write) $" TIM2_ARR @ hex. TIM2_ARR 1b. ;
: TIM2_CCR1. cr ." TIM2_CCR1 (read-write) $" TIM2_CCR1 @ hex. TIM2_CCR1 1b. ;
: TIM2_CCR2. cr ." TIM2_CCR2 (read-write) $" TIM2_CCR2 @ hex. TIM2_CCR2 1b. ;
: TIM2_CCR3. cr ." TIM2_CCR3 (read-write) $" TIM2_CCR3 @ hex. TIM2_CCR3 1b. ;
: TIM2_CCR4. cr ." TIM2_CCR4 (read-write) $" TIM2_CCR4 @ hex. TIM2_CCR4 1b. ;
: TIM2_DCR. cr ." TIM2_DCR (read-write) $" TIM2_DCR @ hex. TIM2_DCR 1b. ;
: TIM2_DMAR. cr ." TIM2_DMAR (read-write) $" TIM2_DMAR @ hex. TIM2_DMAR 1b. ;
: TIM2.
TIM2_CR1.
TIM2_CR2.
TIM2_SMCR.
TIM2_DIER.
TIM2_SR.
TIM2_EGR.
TIM2_CCMR1_Output.
TIM2_CCMR1_Input.
TIM2_CCMR2_Output.
TIM2_CCMR2_Input.
TIM2_CCER.
TIM2_CNT.
TIM2_PSC.
TIM2_ARR.
TIM2_CCR1.
TIM2_CCR2.
TIM2_CCR3.
TIM2_CCR4.
TIM2_DCR.
TIM2_DMAR.
;

$40000400 constant TIM3 ( General purpose timer ) 
TIM3 $0 + constant TIM3_CR1 ( control register 1 ) 
TIM3 $4 + constant TIM3_CR2 ( control register 2 ) 
TIM3 $8 + constant TIM3_SMCR ( slave mode control register ) 
TIM3 $C + constant TIM3_DIER ( DMA/Interrupt enable register ) 
TIM3 $10 + constant TIM3_SR ( status register ) 
TIM3 $14 + constant TIM3_EGR ( event generation register ) 
TIM3 $18 + constant TIM3_CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM3 $18 + constant TIM3_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM3 $1C + constant TIM3_CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM3 $1C + constant TIM3_CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM3 $20 + constant TIM3_CCER ( capture/compare enable  register ) 
TIM3 $24 + constant TIM3_CNT ( counter ) 
TIM3 $28 + constant TIM3_PSC ( prescaler ) 
TIM3 $2C + constant TIM3_ARR ( auto-reload register ) 
TIM3 $34 + constant TIM3_CCR1 ( capture/compare register 1 ) 
TIM3 $38 + constant TIM3_CCR2 ( capture/compare register 2 ) 
TIM3 $3C + constant TIM3_CCR3 ( capture/compare register 3 ) 
TIM3 $40 + constant TIM3_CCR4 ( capture/compare register 4 ) 
TIM3 $48 + constant TIM3_DCR ( DMA control register ) 
TIM3 $4C + constant TIM3_DMAR ( DMA address for full transfer ) 
: TIM3_CR1. cr ." TIM3_CR1 (read-write) $" TIM3_CR1 @ hex. TIM3_CR1 1b. ;
: TIM3_CR2. cr ." TIM3_CR2 (read-write) $" TIM3_CR2 @ hex. TIM3_CR2 1b. ;
: TIM3_SMCR. cr ." TIM3_SMCR (read-write) $" TIM3_SMCR @ hex. TIM3_SMCR 1b. ;
: TIM3_DIER. cr ." TIM3_DIER (read-write) $" TIM3_DIER @ hex. TIM3_DIER 1b. ;
: TIM3_SR. cr ." TIM3_SR (read-write) $" TIM3_SR @ hex. TIM3_SR 1b. ;
: TIM3_EGR. cr ." TIM3_EGR (write-only) $" TIM3_EGR @ hex. TIM3_EGR 1b. ;
: TIM3_CCMR1_Output. cr ." TIM3_CCMR1_Output (read-write) $" TIM3_CCMR1_Output @ hex. TIM3_CCMR1_Output 1b. ;
: TIM3_CCMR1_Input. cr ." TIM3_CCMR1_Input (read-write) $" TIM3_CCMR1_Input @ hex. TIM3_CCMR1_Input 1b. ;
: TIM3_CCMR2_Output. cr ." TIM3_CCMR2_Output (read-write) $" TIM3_CCMR2_Output @ hex. TIM3_CCMR2_Output 1b. ;
: TIM3_CCMR2_Input. cr ." TIM3_CCMR2_Input (read-write) $" TIM3_CCMR2_Input @ hex. TIM3_CCMR2_Input 1b. ;
: TIM3_CCER. cr ." TIM3_CCER (read-write) $" TIM3_CCER @ hex. TIM3_CCER 1b. ;
: TIM3_CNT. cr ." TIM3_CNT (read-write) $" TIM3_CNT @ hex. TIM3_CNT 1b. ;
: TIM3_PSC. cr ." TIM3_PSC (read-write) $" TIM3_PSC @ hex. TIM3_PSC 1b. ;
: TIM3_ARR. cr ." TIM3_ARR (read-write) $" TIM3_ARR @ hex. TIM3_ARR 1b. ;
: TIM3_CCR1. cr ." TIM3_CCR1 (read-write) $" TIM3_CCR1 @ hex. TIM3_CCR1 1b. ;
: TIM3_CCR2. cr ." TIM3_CCR2 (read-write) $" TIM3_CCR2 @ hex. TIM3_CCR2 1b. ;
: TIM3_CCR3. cr ." TIM3_CCR3 (read-write) $" TIM3_CCR3 @ hex. TIM3_CCR3 1b. ;
: TIM3_CCR4. cr ." TIM3_CCR4 (read-write) $" TIM3_CCR4 @ hex. TIM3_CCR4 1b. ;
: TIM3_DCR. cr ." TIM3_DCR (read-write) $" TIM3_DCR @ hex. TIM3_DCR 1b. ;
: TIM3_DMAR. cr ." TIM3_DMAR (read-write) $" TIM3_DMAR @ hex. TIM3_DMAR 1b. ;
: TIM3.
TIM3_CR1.
TIM3_CR2.
TIM3_SMCR.
TIM3_DIER.
TIM3_SR.
TIM3_EGR.
TIM3_CCMR1_Output.
TIM3_CCMR1_Input.
TIM3_CCMR2_Output.
TIM3_CCMR2_Input.
TIM3_CCER.
TIM3_CNT.
TIM3_PSC.
TIM3_ARR.
TIM3_CCR1.
TIM3_CCR2.
TIM3_CCR3.
TIM3_CCR4.
TIM3_DCR.
TIM3_DMAR.
;

$40005400 constant I2C1 ( Inter integrated circuit ) 
I2C1 $0 + constant I2C1_CR1 ( Control register 1 ) 
I2C1 $4 + constant I2C1_CR2 ( Control register 2 ) 
I2C1 $8 + constant I2C1_OAR1 ( Own address register 1 ) 
I2C1 $C + constant I2C1_OAR2 ( Own address register 2 ) 
I2C1 $10 + constant I2C1_DR ( Data register ) 
I2C1 $14 + constant I2C1_SR1 ( Status register 1 ) 
I2C1 $18 + constant I2C1_SR2 ( Status register 2 ) 
I2C1 $1C + constant I2C1_CCR ( Clock control register ) 
I2C1 $20 + constant I2C1_TRISE ( TRISE register ) 
: I2C1_CR1. cr ." I2C1_CR1 (read-write) $" I2C1_CR1 @ hex. I2C1_CR1 1b. ;
: I2C1_CR2. cr ." I2C1_CR2 (read-write) $" I2C1_CR2 @ hex. I2C1_CR2 1b. ;
: I2C1_OAR1. cr ." I2C1_OAR1 (read-write) $" I2C1_OAR1 @ hex. I2C1_OAR1 1b. ;
: I2C1_OAR2. cr ." I2C1_OAR2 (read-write) $" I2C1_OAR2 @ hex. I2C1_OAR2 1b. ;
: I2C1_DR. cr ." I2C1_DR (read-write) $" I2C1_DR @ hex. I2C1_DR 1b. ;
: I2C1_SR1. cr ." I2C1_SR1 () $" I2C1_SR1 @ hex. I2C1_SR1 1b. ;
: I2C1_SR2. cr ." I2C1_SR2 (read-only) $" I2C1_SR2 @ hex. I2C1_SR2 1b. ;
: I2C1_CCR. cr ." I2C1_CCR (read-write) $" I2C1_CCR @ hex. I2C1_CCR 1b. ;
: I2C1_TRISE. cr ." I2C1_TRISE (read-write) $" I2C1_TRISE @ hex. I2C1_TRISE 1b. ;
: I2C1.
I2C1_CR1.
I2C1_CR2.
I2C1_OAR1.
I2C1_OAR2.
I2C1_DR.
I2C1_SR1.
I2C1_SR2.
I2C1_CCR.
I2C1_TRISE.
;

$40005800 constant I2C2 ( Inter integrated circuit ) 
I2C2 $0 + constant I2C2_CR1 ( Control register 1 ) 
I2C2 $4 + constant I2C2_CR2 ( Control register 2 ) 
I2C2 $8 + constant I2C2_OAR1 ( Own address register 1 ) 
I2C2 $C + constant I2C2_OAR2 ( Own address register 2 ) 
I2C2 $10 + constant I2C2_DR ( Data register ) 
I2C2 $14 + constant I2C2_SR1 ( Status register 1 ) 
I2C2 $18 + constant I2C2_SR2 ( Status register 2 ) 
I2C2 $1C + constant I2C2_CCR ( Clock control register ) 
I2C2 $20 + constant I2C2_TRISE ( TRISE register ) 
: I2C2_CR1. cr ." I2C2_CR1 (read-write) $" I2C2_CR1 @ hex. I2C2_CR1 1b. ;
: I2C2_CR2. cr ." I2C2_CR2 (read-write) $" I2C2_CR2 @ hex. I2C2_CR2 1b. ;
: I2C2_OAR1. cr ." I2C2_OAR1 (read-write) $" I2C2_OAR1 @ hex. I2C2_OAR1 1b. ;
: I2C2_OAR2. cr ." I2C2_OAR2 (read-write) $" I2C2_OAR2 @ hex. I2C2_OAR2 1b. ;
: I2C2_DR. cr ." I2C2_DR (read-write) $" I2C2_DR @ hex. I2C2_DR 1b. ;
: I2C2_SR1. cr ." I2C2_SR1 () $" I2C2_SR1 @ hex. I2C2_SR1 1b. ;
: I2C2_SR2. cr ." I2C2_SR2 (read-only) $" I2C2_SR2 @ hex. I2C2_SR2 1b. ;
: I2C2_CCR. cr ." I2C2_CCR (read-write) $" I2C2_CCR @ hex. I2C2_CCR 1b. ;
: I2C2_TRISE. cr ." I2C2_TRISE (read-write) $" I2C2_TRISE @ hex. I2C2_TRISE 1b. ;
: I2C2.
I2C2_CR1.
I2C2_CR2.
I2C2_OAR1.
I2C2_OAR2.
I2C2_DR.
I2C2_SR1.
I2C2_SR2.
I2C2_CCR.
I2C2_TRISE.
;

$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1_CR1 ( control register 1 ) 
SPI1 $4 + constant SPI1_CR2 ( control register 2 ) 
SPI1 $8 + constant SPI1_SR ( status register ) 
SPI1 $C + constant SPI1_DR ( data register ) 
SPI1 $10 + constant SPI1_CRCPR ( CRC polynomial register ) 
SPI1 $14 + constant SPI1_RXCRCR ( RX CRC register ) 
SPI1 $18 + constant SPI1_TXCRCR ( TX CRC register ) 
SPI1 $1C + constant SPI1_I2SCFGR ( I2S configuration register ) 
SPI1 $20 + constant SPI1_I2SPR ( I2S prescaler register ) 
: SPI1_CR1. cr ." SPI1_CR1 (read-write) $" SPI1_CR1 @ hex. SPI1_CR1 1b. ;
: SPI1_CR2. cr ." SPI1_CR2 (read-write) $" SPI1_CR2 @ hex. SPI1_CR2 1b. ;
: SPI1_SR. cr ." SPI1_SR () $" SPI1_SR @ hex. SPI1_SR 1b. ;
: SPI1_DR. cr ." SPI1_DR (read-write) $" SPI1_DR @ hex. SPI1_DR 1b. ;
: SPI1_CRCPR. cr ." SPI1_CRCPR (read-write) $" SPI1_CRCPR @ hex. SPI1_CRCPR 1b. ;
: SPI1_RXCRCR. cr ." SPI1_RXCRCR (read-only) $" SPI1_RXCRCR @ hex. SPI1_RXCRCR 1b. ;
: SPI1_TXCRCR. cr ." SPI1_TXCRCR (read-only) $" SPI1_TXCRCR @ hex. SPI1_TXCRCR 1b. ;
: SPI1_I2SCFGR. cr ." SPI1_I2SCFGR (read-write) $" SPI1_I2SCFGR @ hex. SPI1_I2SCFGR 1b. ;
: SPI1_I2SPR. cr ." SPI1_I2SPR (read-write) $" SPI1_I2SPR @ hex. SPI1_I2SPR 1b. ;
: SPI1.
SPI1_CR1.
SPI1_CR2.
SPI1_SR.
SPI1_DR.
SPI1_CRCPR.
SPI1_RXCRCR.
SPI1_TXCRCR.
SPI1_I2SCFGR.
SPI1_I2SPR.
;

$40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 $0 + constant USART1_SR ( Status register ) 
USART1 $4 + constant USART1_DR ( Data register ) 
USART1 $8 + constant USART1_BRR ( Baud rate register ) 
USART1 $C + constant USART1_CR1 ( Control register 1 ) 
USART1 $10 + constant USART1_CR2 ( Control register 2 ) 
USART1 $14 + constant USART1_CR3 ( Control register 3 ) 
USART1 $18 + constant USART1_GTPR ( Guard time and prescaler  register ) 
: USART1_SR. cr ." USART1_SR () $" USART1_SR @ hex. USART1_SR 1b. ;
: USART1_DR. cr ." USART1_DR (read-write) $" USART1_DR @ hex. USART1_DR 1b. ;
: USART1_BRR. cr ." USART1_BRR (read-write) $" USART1_BRR @ hex. USART1_BRR 1b. ;
: USART1_CR1. cr ." USART1_CR1 (read-write) $" USART1_CR1 @ hex. USART1_CR1 1b. ;
: USART1_CR2. cr ." USART1_CR2 (read-write) $" USART1_CR2 @ hex. USART1_CR2 1b. ;
: USART1_CR3. cr ." USART1_CR3 (read-write) $" USART1_CR3 @ hex. USART1_CR3 1b. ;
: USART1_GTPR. cr ." USART1_GTPR (read-write) $" USART1_GTPR @ hex. USART1_GTPR 1b. ;
: USART1.
USART1_SR.
USART1_DR.
USART1_BRR.
USART1_CR1.
USART1_CR2.
USART1_CR3.
USART1_GTPR.
;

$40004400 constant USART2 ( Universal synchronous asynchronous receiver  transmitter ) 
USART2 $0 + constant USART2_SR ( Status register ) 
USART2 $4 + constant USART2_DR ( Data register ) 
USART2 $8 + constant USART2_BRR ( Baud rate register ) 
USART2 $C + constant USART2_CR1 ( Control register 1 ) 
USART2 $10 + constant USART2_CR2 ( Control register 2 ) 
USART2 $14 + constant USART2_CR3 ( Control register 3 ) 
USART2 $18 + constant USART2_GTPR ( Guard time and prescaler  register ) 
: USART2_SR. cr ." USART2_SR () $" USART2_SR @ hex. USART2_SR 1b. ;
: USART2_DR. cr ." USART2_DR (read-write) $" USART2_DR @ hex. USART2_DR 1b. ;
: USART2_BRR. cr ." USART2_BRR (read-write) $" USART2_BRR @ hex. USART2_BRR 1b. ;
: USART2_CR1. cr ." USART2_CR1 (read-write) $" USART2_CR1 @ hex. USART2_CR1 1b. ;
: USART2_CR2. cr ." USART2_CR2 (read-write) $" USART2_CR2 @ hex. USART2_CR2 1b. ;
: USART2_CR3. cr ." USART2_CR3 (read-write) $" USART2_CR3 @ hex. USART2_CR3 1b. ;
: USART2_GTPR. cr ." USART2_GTPR (read-write) $" USART2_GTPR @ hex. USART2_GTPR 1b. ;
: USART2.
USART2_SR.
USART2_DR.
USART2_BRR.
USART2_CR1.
USART2_CR2.
USART2_CR3.
USART2_GTPR.
;

$40004800 constant USART3 ( Universal synchronous asynchronous receiver  transmitter ) 
USART3 $0 + constant USART3_SR ( Status register ) 
USART3 $4 + constant USART3_DR ( Data register ) 
USART3 $8 + constant USART3_BRR ( Baud rate register ) 
USART3 $C + constant USART3_CR1 ( Control register 1 ) 
USART3 $10 + constant USART3_CR2 ( Control register 2 ) 
USART3 $14 + constant USART3_CR3 ( Control register 3 ) 
USART3 $18 + constant USART3_GTPR ( Guard time and prescaler  register ) 
: USART3_SR. cr ." USART3_SR () $" USART3_SR @ hex. USART3_SR 1b. ;
: USART3_DR. cr ." USART3_DR (read-write) $" USART3_DR @ hex. USART3_DR 1b. ;
: USART3_BRR. cr ." USART3_BRR (read-write) $" USART3_BRR @ hex. USART3_BRR 1b. ;
: USART3_CR1. cr ." USART3_CR1 (read-write) $" USART3_CR1 @ hex. USART3_CR1 1b. ;
: USART3_CR2. cr ." USART3_CR2 (read-write) $" USART3_CR2 @ hex. USART3_CR2 1b. ;
: USART3_CR3. cr ." USART3_CR3 (read-write) $" USART3_CR3 @ hex. USART3_CR3 1b. ;
: USART3_GTPR. cr ." USART3_GTPR (read-write) $" USART3_GTPR @ hex. USART3_GTPR 1b. ;
: USART3.
USART3_SR.
USART3_DR.
USART3_BRR.
USART3_CR1.
USART3_CR2.
USART3_CR3.
USART3_GTPR.
;

$40012400 constant ADC1 ( Analog to digital converter ) 
ADC1 $0 + constant ADC1_SR ( status register ) 
ADC1 $4 + constant ADC1_CR1 ( control register 1 ) 
ADC1 $8 + constant ADC1_CR2 ( control register 2 ) 
ADC1 $C + constant ADC1_SMPR1 ( sample time register 1 ) 
ADC1 $10 + constant ADC1_SMPR2 ( sample time register 2 ) 
ADC1 $14 + constant ADC1_JOFR1 ( injected channel data offset register  x ) 
ADC1 $18 + constant ADC1_JOFR2 ( injected channel data offset register  x ) 
ADC1 $1C + constant ADC1_JOFR3 ( injected channel data offset register  x ) 
ADC1 $20 + constant ADC1_JOFR4 ( injected channel data offset register  x ) 
ADC1 $24 + constant ADC1_HTR ( watchdog higher threshold  register ) 
ADC1 $28 + constant ADC1_LTR ( watchdog lower threshold  register ) 
ADC1 $2C + constant ADC1_SQR1 ( regular sequence register 1 ) 
ADC1 $30 + constant ADC1_SQR2 ( regular sequence register 2 ) 
ADC1 $34 + constant ADC1_SQR3 ( regular sequence register 3 ) 
ADC1 $38 + constant ADC1_JSQR ( injected sequence register ) 
ADC1 $3C + constant ADC1_JDR1 ( injected data register x ) 
ADC1 $40 + constant ADC1_JDR2 ( injected data register x ) 
ADC1 $44 + constant ADC1_JDR3 ( injected data register x ) 
ADC1 $48 + constant ADC1_JDR4 ( injected data register x ) 
ADC1 $4C + constant ADC1_DR ( regular data register ) 
: ADC1_SR. cr ." ADC1_SR (read-write) $" ADC1_SR @ hex. ADC1_SR 1b. ;
: ADC1_CR1. cr ." ADC1_CR1 (read-write) $" ADC1_CR1 @ hex. ADC1_CR1 1b. ;
: ADC1_CR2. cr ." ADC1_CR2 (read-write) $" ADC1_CR2 @ hex. ADC1_CR2 1b. ;
: ADC1_SMPR1. cr ." ADC1_SMPR1 (read-write) $" ADC1_SMPR1 @ hex. ADC1_SMPR1 1b. ;
: ADC1_SMPR2. cr ." ADC1_SMPR2 (read-write) $" ADC1_SMPR2 @ hex. ADC1_SMPR2 1b. ;
: ADC1_JOFR1. cr ." ADC1_JOFR1 (read-write) $" ADC1_JOFR1 @ hex. ADC1_JOFR1 1b. ;
: ADC1_JOFR2. cr ." ADC1_JOFR2 (read-write) $" ADC1_JOFR2 @ hex. ADC1_JOFR2 1b. ;
: ADC1_JOFR3. cr ." ADC1_JOFR3 (read-write) $" ADC1_JOFR3 @ hex. ADC1_JOFR3 1b. ;
: ADC1_JOFR4. cr ." ADC1_JOFR4 (read-write) $" ADC1_JOFR4 @ hex. ADC1_JOFR4 1b. ;
: ADC1_HTR. cr ." ADC1_HTR (read-write) $" ADC1_HTR @ hex. ADC1_HTR 1b. ;
: ADC1_LTR. cr ." ADC1_LTR (read-write) $" ADC1_LTR @ hex. ADC1_LTR 1b. ;
: ADC1_SQR1. cr ." ADC1_SQR1 (read-write) $" ADC1_SQR1 @ hex. ADC1_SQR1 1b. ;
: ADC1_SQR2. cr ." ADC1_SQR2 (read-write) $" ADC1_SQR2 @ hex. ADC1_SQR2 1b. ;
: ADC1_SQR3. cr ." ADC1_SQR3 (read-write) $" ADC1_SQR3 @ hex. ADC1_SQR3 1b. ;
: ADC1_JSQR. cr ." ADC1_JSQR (read-write) $" ADC1_JSQR @ hex. ADC1_JSQR 1b. ;
: ADC1_JDR1. cr ." ADC1_JDR1 (read-only) $" ADC1_JDR1 @ hex. ADC1_JDR1 1b. ;
: ADC1_JDR2. cr ." ADC1_JDR2 (read-only) $" ADC1_JDR2 @ hex. ADC1_JDR2 1b. ;
: ADC1_JDR3. cr ." ADC1_JDR3 (read-only) $" ADC1_JDR3 @ hex. ADC1_JDR3 1b. ;
: ADC1_JDR4. cr ." ADC1_JDR4 (read-only) $" ADC1_JDR4 @ hex. ADC1_JDR4 1b. ;
: ADC1_DR. cr ." ADC1_DR (read-only) $" ADC1_DR @ hex. ADC1_DR 1b. ;
: ADC1.
ADC1_SR.
ADC1_CR1.
ADC1_CR2.
ADC1_SMPR1.
ADC1_SMPR2.
ADC1_JOFR1.
ADC1_JOFR2.
ADC1_JOFR3.
ADC1_JOFR4.
ADC1_HTR.
ADC1_LTR.
ADC1_SQR1.
ADC1_SQR2.
ADC1_SQR3.
ADC1_JSQR.
ADC1_JDR1.
ADC1_JDR2.
ADC1_JDR3.
ADC1_JDR4.
ADC1_DR.
;

$40012800 constant ADC2 ( Analog to digital converter ) 
ADC2 $0 + constant ADC2_SR ( status register ) 
ADC2 $4 + constant ADC2_CR1 ( control register 1 ) 
ADC2 $8 + constant ADC2_CR2 ( control register 2 ) 
ADC2 $C + constant ADC2_SMPR1 ( sample time register 1 ) 
ADC2 $10 + constant ADC2_SMPR2 ( sample time register 2 ) 
ADC2 $14 + constant ADC2_JOFR1 ( injected channel data offset register  x ) 
ADC2 $18 + constant ADC2_JOFR2 ( injected channel data offset register  x ) 
ADC2 $1C + constant ADC2_JOFR3 ( injected channel data offset register  x ) 
ADC2 $20 + constant ADC2_JOFR4 ( injected channel data offset register  x ) 
ADC2 $24 + constant ADC2_HTR ( watchdog higher threshold  register ) 
ADC2 $28 + constant ADC2_LTR ( watchdog lower threshold  register ) 
ADC2 $2C + constant ADC2_SQR1 ( regular sequence register 1 ) 
ADC2 $30 + constant ADC2_SQR2 ( regular sequence register 2 ) 
ADC2 $34 + constant ADC2_SQR3 ( regular sequence register 3 ) 
ADC2 $38 + constant ADC2_JSQR ( injected sequence register ) 
ADC2 $3C + constant ADC2_JDR1 ( injected data register x ) 
ADC2 $40 + constant ADC2_JDR2 ( injected data register x ) 
ADC2 $44 + constant ADC2_JDR3 ( injected data register x ) 
ADC2 $48 + constant ADC2_JDR4 ( injected data register x ) 
ADC2 $4C + constant ADC2_DR ( regular data register ) 
: ADC2_SR. cr ." ADC2_SR (read-write) $" ADC2_SR @ hex. ADC2_SR 1b. ;
: ADC2_CR1. cr ." ADC2_CR1 (read-write) $" ADC2_CR1 @ hex. ADC2_CR1 1b. ;
: ADC2_CR2. cr ." ADC2_CR2 (read-write) $" ADC2_CR2 @ hex. ADC2_CR2 1b. ;
: ADC2_SMPR1. cr ." ADC2_SMPR1 (read-write) $" ADC2_SMPR1 @ hex. ADC2_SMPR1 1b. ;
: ADC2_SMPR2. cr ." ADC2_SMPR2 (read-write) $" ADC2_SMPR2 @ hex. ADC2_SMPR2 1b. ;
: ADC2_JOFR1. cr ." ADC2_JOFR1 (read-write) $" ADC2_JOFR1 @ hex. ADC2_JOFR1 1b. ;
: ADC2_JOFR2. cr ." ADC2_JOFR2 (read-write) $" ADC2_JOFR2 @ hex. ADC2_JOFR2 1b. ;
: ADC2_JOFR3. cr ." ADC2_JOFR3 (read-write) $" ADC2_JOFR3 @ hex. ADC2_JOFR3 1b. ;
: ADC2_JOFR4. cr ." ADC2_JOFR4 (read-write) $" ADC2_JOFR4 @ hex. ADC2_JOFR4 1b. ;
: ADC2_HTR. cr ." ADC2_HTR (read-write) $" ADC2_HTR @ hex. ADC2_HTR 1b. ;
: ADC2_LTR. cr ." ADC2_LTR (read-write) $" ADC2_LTR @ hex. ADC2_LTR 1b. ;
: ADC2_SQR1. cr ." ADC2_SQR1 (read-write) $" ADC2_SQR1 @ hex. ADC2_SQR1 1b. ;
: ADC2_SQR2. cr ." ADC2_SQR2 (read-write) $" ADC2_SQR2 @ hex. ADC2_SQR2 1b. ;
: ADC2_SQR3. cr ." ADC2_SQR3 (read-write) $" ADC2_SQR3 @ hex. ADC2_SQR3 1b. ;
: ADC2_JSQR. cr ." ADC2_JSQR (read-write) $" ADC2_JSQR @ hex. ADC2_JSQR 1b. ;
: ADC2_JDR1. cr ." ADC2_JDR1 (read-only) $" ADC2_JDR1 @ hex. ADC2_JDR1 1b. ;
: ADC2_JDR2. cr ." ADC2_JDR2 (read-only) $" ADC2_JDR2 @ hex. ADC2_JDR2 1b. ;
: ADC2_JDR3. cr ." ADC2_JDR3 (read-only) $" ADC2_JDR3 @ hex. ADC2_JDR3 1b. ;
: ADC2_JDR4. cr ." ADC2_JDR4 (read-only) $" ADC2_JDR4 @ hex. ADC2_JDR4 1b. ;
: ADC2_DR. cr ." ADC2_DR (read-only) $" ADC2_DR @ hex. ADC2_DR 1b. ;
: ADC2.
ADC2_SR.
ADC2_CR1.
ADC2_CR2.
ADC2_SMPR1.
ADC2_SMPR2.
ADC2_JOFR1.
ADC2_JOFR2.
ADC2_JOFR3.
ADC2_JOFR4.
ADC2_HTR.
ADC2_LTR.
ADC2_SQR1.
ADC2_SQR2.
ADC2_SQR3.
ADC2_JSQR.
ADC2_JDR1.
ADC2_JDR2.
ADC2_JDR3.
ADC2_JDR4.
ADC2_DR.
;

$40013C00 constant ADC3 ( Analog to digital converter ) 
ADC3 $0 + constant ADC3_SR ( status register ) 
ADC3 $4 + constant ADC3_CR1 ( control register 1 ) 
ADC3 $8 + constant ADC3_CR2 ( control register 2 ) 
ADC3 $C + constant ADC3_SMPR1 ( sample time register 1 ) 
ADC3 $10 + constant ADC3_SMPR2 ( sample time register 2 ) 
ADC3 $14 + constant ADC3_JOFR1 ( injected channel data offset register  x ) 
ADC3 $18 + constant ADC3_JOFR2 ( injected channel data offset register  x ) 
ADC3 $1C + constant ADC3_JOFR3 ( injected channel data offset register  x ) 
ADC3 $20 + constant ADC3_JOFR4 ( injected channel data offset register  x ) 
ADC3 $24 + constant ADC3_HTR ( watchdog higher threshold  register ) 
ADC3 $28 + constant ADC3_LTR ( watchdog lower threshold  register ) 
ADC3 $2C + constant ADC3_SQR1 ( regular sequence register 1 ) 
ADC3 $30 + constant ADC3_SQR2 ( regular sequence register 2 ) 
ADC3 $34 + constant ADC3_SQR3 ( regular sequence register 3 ) 
ADC3 $38 + constant ADC3_JSQR ( injected sequence register ) 
ADC3 $3C + constant ADC3_JDR1 ( injected data register x ) 
ADC3 $40 + constant ADC3_JDR2 ( injected data register x ) 
ADC3 $44 + constant ADC3_JDR3 ( injected data register x ) 
ADC3 $48 + constant ADC3_JDR4 ( injected data register x ) 
ADC3 $4C + constant ADC3_DR ( regular data register ) 
: ADC3_SR. cr ." ADC3_SR (read-write) $" ADC3_SR @ hex. ADC3_SR 1b. ;
: ADC3_CR1. cr ." ADC3_CR1 (read-write) $" ADC3_CR1 @ hex. ADC3_CR1 1b. ;
: ADC3_CR2. cr ." ADC3_CR2 (read-write) $" ADC3_CR2 @ hex. ADC3_CR2 1b. ;
: ADC3_SMPR1. cr ." ADC3_SMPR1 (read-write) $" ADC3_SMPR1 @ hex. ADC3_SMPR1 1b. ;
: ADC3_SMPR2. cr ." ADC3_SMPR2 (read-write) $" ADC3_SMPR2 @ hex. ADC3_SMPR2 1b. ;
: ADC3_JOFR1. cr ." ADC3_JOFR1 (read-write) $" ADC3_JOFR1 @ hex. ADC3_JOFR1 1b. ;
: ADC3_JOFR2. cr ." ADC3_JOFR2 (read-write) $" ADC3_JOFR2 @ hex. ADC3_JOFR2 1b. ;
: ADC3_JOFR3. cr ." ADC3_JOFR3 (read-write) $" ADC3_JOFR3 @ hex. ADC3_JOFR3 1b. ;
: ADC3_JOFR4. cr ." ADC3_JOFR4 (read-write) $" ADC3_JOFR4 @ hex. ADC3_JOFR4 1b. ;
: ADC3_HTR. cr ." ADC3_HTR (read-write) $" ADC3_HTR @ hex. ADC3_HTR 1b. ;
: ADC3_LTR. cr ." ADC3_LTR (read-write) $" ADC3_LTR @ hex. ADC3_LTR 1b. ;
: ADC3_SQR1. cr ." ADC3_SQR1 (read-write) $" ADC3_SQR1 @ hex. ADC3_SQR1 1b. ;
: ADC3_SQR2. cr ." ADC3_SQR2 (read-write) $" ADC3_SQR2 @ hex. ADC3_SQR2 1b. ;
: ADC3_SQR3. cr ." ADC3_SQR3 (read-write) $" ADC3_SQR3 @ hex. ADC3_SQR3 1b. ;
: ADC3_JSQR. cr ." ADC3_JSQR (read-write) $" ADC3_JSQR @ hex. ADC3_JSQR 1b. ;
: ADC3_JDR1. cr ." ADC3_JDR1 (read-only) $" ADC3_JDR1 @ hex. ADC3_JDR1 1b. ;
: ADC3_JDR2. cr ." ADC3_JDR2 (read-only) $" ADC3_JDR2 @ hex. ADC3_JDR2 1b. ;
: ADC3_JDR3. cr ." ADC3_JDR3 (read-only) $" ADC3_JDR3 @ hex. ADC3_JDR3 1b. ;
: ADC3_JDR4. cr ." ADC3_JDR4 (read-only) $" ADC3_JDR4 @ hex. ADC3_JDR4 1b. ;
: ADC3_DR. cr ." ADC3_DR (read-only) $" ADC3_DR @ hex. ADC3_DR 1b. ;
: ADC3.
ADC3_SR.
ADC3_CR1.
ADC3_CR2.
ADC3_SMPR1.
ADC3_SMPR2.
ADC3_JOFR1.
ADC3_JOFR2.
ADC3_JOFR3.
ADC3_JOFR4.
ADC3_HTR.
ADC3_LTR.
ADC3_SQR1.
ADC3_SQR2.
ADC3_SQR3.
ADC3_JSQR.
ADC3_JDR1.
ADC3_JDR2.
ADC3_JDR3.
ADC3_JDR4.
ADC3_DR.
;

$40007400 constant DAC ( Digital to analog converter ) 
DAC $0 + constant DAC_CR ( Control register DAC_CR ) 
DAC $4 + constant DAC_SWTRIGR ( DAC software trigger register  DAC_SWTRIGR ) 
DAC $8 + constant DAC_DHR12R1 ( DAC channel1 12-bit right-aligned data  holding registerDAC_DHR12R1 ) 
DAC $C + constant DAC_DHR12L1 ( DAC channel1 12-bit left aligned data  holding register DAC_DHR12L1 ) 
DAC $10 + constant DAC_DHR8R1 ( DAC channel1 8-bit right aligned data  holding register DAC_DHR8R1 ) 
DAC $14 + constant DAC_DHR12R2 ( DAC channel2 12-bit right aligned data  holding register DAC_DHR12R2 ) 
DAC $18 + constant DAC_DHR12L2 ( DAC channel2 12-bit left aligned data  holding register DAC_DHR12L2 ) 
DAC $1C + constant DAC_DHR8R2 ( DAC channel2 8-bit right-aligned data  holding register DAC_DHR8R2 ) 
DAC $20 + constant DAC_DHR12RD ( Dual DAC 12-bit right-aligned data holding  register DAC_DHR12RD, Bits 31:28 Reserved, Bits 15:12  Reserved ) 
DAC $24 + constant DAC_DHR12LD ( DUAL DAC 12-bit left aligned data holding  register DAC_DHR12LD, Bits 19:16 Reserved, Bits 3:0  Reserved ) 
DAC $28 + constant DAC_DHR8RD ( DUAL DAC 8-bit right aligned data holding  register DAC_DHR8RD, Bits 31:16 Reserved ) 
DAC $2C + constant DAC_DOR1 ( DAC channel1 data output register  DAC_DOR1 ) 
DAC $30 + constant DAC_DOR2 ( DAC channel2 data output register  DAC_DOR2 ) 
: DAC_CR. cr ." DAC_CR (read-write) $" DAC_CR @ hex. DAC_CR 1b. ;
: DAC_SWTRIGR. cr ." DAC_SWTRIGR (write-only) $" DAC_SWTRIGR @ hex. DAC_SWTRIGR 1b. ;
: DAC_DHR12R1. cr ." DAC_DHR12R1 (read-write) $" DAC_DHR12R1 @ hex. DAC_DHR12R1 1b. ;
: DAC_DHR12L1. cr ." DAC_DHR12L1 (read-write) $" DAC_DHR12L1 @ hex. DAC_DHR12L1 1b. ;
: DAC_DHR8R1. cr ." DAC_DHR8R1 (read-write) $" DAC_DHR8R1 @ hex. DAC_DHR8R1 1b. ;
: DAC_DHR12R2. cr ." DAC_DHR12R2 (read-write) $" DAC_DHR12R2 @ hex. DAC_DHR12R2 1b. ;
: DAC_DHR12L2. cr ." DAC_DHR12L2 (read-write) $" DAC_DHR12L2 @ hex. DAC_DHR12L2 1b. ;
: DAC_DHR8R2. cr ." DAC_DHR8R2 (read-write) $" DAC_DHR8R2 @ hex. DAC_DHR8R2 1b. ;
: DAC_DHR12RD. cr ." DAC_DHR12RD (read-write) $" DAC_DHR12RD @ hex. DAC_DHR12RD 1b. ;
: DAC_DHR12LD. cr ." DAC_DHR12LD (read-write) $" DAC_DHR12LD @ hex. DAC_DHR12LD 1b. ;
: DAC_DHR8RD. cr ." DAC_DHR8RD (read-write) $" DAC_DHR8RD @ hex. DAC_DHR8RD 1b. ;
: DAC_DOR1. cr ." DAC_DOR1 (read-only) $" DAC_DOR1 @ hex. DAC_DOR1 1b. ;
: DAC_DOR2. cr ." DAC_DOR2 (read-only) $" DAC_DOR2 @ hex. DAC_DOR2 1b. ;
: DAC.
DAC_CR.
DAC_SWTRIGR.
DAC_DHR12R1.
DAC_DHR12L1.
DAC_DHR8R1.
DAC_DHR12R2.
DAC_DHR12L2.
DAC_DHR8R2.
DAC_DHR12RD.
DAC_DHR12LD.
DAC_DHR8RD.
DAC_DOR1.
DAC_DOR2.
;

$E0042000 constant DBG ( Debug support ) 
DBG $0 + constant DBG_IDCODE ( DBGMCU_IDCODE ) 
DBG $4 + constant DBG_CR ( DBGMCU_CR ) 
: DBG_IDCODE. cr ." DBG_IDCODE (read-only) $" DBG_IDCODE @ hex. DBG_IDCODE 1b. ;
: DBG_CR. cr ." DBG_CR (read-write) $" DBG_CR @ hex. DBG_CR 1b. ;
: DBG.
DBG_IDCODE.
DBG_CR.
;

$40004C00 constant UART4 ( Universal asynchronous receiver  transmitter ) 
UART4 $0 + constant UART4_SR ( UART4_SR ) 
UART4 $4 + constant UART4_DR ( UART4_DR ) 
UART4 $8 + constant UART4_BRR ( UART4_BRR ) 
UART4 $C + constant UART4_CR1 ( UART4_CR1 ) 
UART4 $10 + constant UART4_CR2 ( UART4_CR2 ) 
UART4 $14 + constant UART4_CR3 ( UART4_CR3 ) 
: UART4_SR. cr ." UART4_SR () $" UART4_SR @ hex. UART4_SR 1b. ;
: UART4_DR. cr ." UART4_DR (read-write) $" UART4_DR @ hex. UART4_DR 1b. ;
: UART4_BRR. cr ." UART4_BRR (read-write) $" UART4_BRR @ hex. UART4_BRR 1b. ;
: UART4_CR1. cr ." UART4_CR1 (read-write) $" UART4_CR1 @ hex. UART4_CR1 1b. ;
: UART4_CR2. cr ." UART4_CR2 (read-write) $" UART4_CR2 @ hex. UART4_CR2 1b. ;
: UART4_CR3. cr ." UART4_CR3 (read-write) $" UART4_CR3 @ hex. UART4_CR3 1b. ;
: UART4.
UART4_SR.
UART4_DR.
UART4_BRR.
UART4_CR1.
UART4_CR2.
UART4_CR3.
;

$40005000 constant UART5 ( Universal asynchronous receiver  transmitter ) 
UART5 $0 + constant UART5_SR ( UART4_SR ) 
UART5 $4 + constant UART5_DR ( UART4_DR ) 
UART5 $8 + constant UART5_BRR ( UART4_BRR ) 
UART5 $C + constant UART5_CR1 ( UART4_CR1 ) 
UART5 $10 + constant UART5_CR2 ( UART4_CR2 ) 
UART5 $14 + constant UART5_CR3 ( UART4_CR3 ) 
: UART5_SR. cr ." UART5_SR () $" UART5_SR @ hex. UART5_SR 1b. ;
: UART5_DR. cr ." UART5_DR (read-write) $" UART5_DR @ hex. UART5_DR 1b. ;
: UART5_BRR. cr ." UART5_BRR (read-write) $" UART5_BRR @ hex. UART5_BRR 1b. ;
: UART5_CR1. cr ." UART5_CR1 (read-write) $" UART5_CR1 @ hex. UART5_CR1 1b. ;
: UART5_CR2. cr ." UART5_CR2 (read-write) $" UART5_CR2 @ hex. UART5_CR2 1b. ;
: UART5_CR3. cr ." UART5_CR3 (read-write) $" UART5_CR3 @ hex. UART5_CR3 1b. ;
: UART5.
UART5_SR.
UART5_DR.
UART5_BRR.
UART5_CR1.
UART5_CR2.
UART5_CR3.
;

$40023000 constant CRC ( CRC calculation unit ) 
CRC $0 + constant CRC_DR ( Data register ) 
CRC $4 + constant CRC_IDR ( Independent Data register ) 
CRC $8 + constant CRC_CR ( Control register ) 
: CRC_DR. cr ." CRC_DR (read-write) $" CRC_DR @ hex. CRC_DR 1b. ;
: CRC_IDR. cr ." CRC_IDR (read-write) $" CRC_IDR @ hex. CRC_IDR 1b. ;
: CRC_CR. cr ." CRC_CR (write-only) $" CRC_CR @ hex. CRC_CR 1b. ;
: CRC.
CRC_DR.
CRC_IDR.
CRC_CR.
;

$40022000 constant FLASH ( FLASH ) 
FLASH $0 + constant FLASH_ACR ( Flash access control register ) 
FLASH $4 + constant FLASH_KEYR ( Flash key register ) 
FLASH $8 + constant FLASH_OPTKEYR ( Flash option key register ) 
FLASH $C + constant FLASH_SR ( Status register ) 
FLASH $10 + constant FLASH_CR ( Control register ) 
FLASH $14 + constant FLASH_AR ( Flash address register ) 
FLASH $1C + constant FLASH_OBR ( Option byte register ) 
FLASH $20 + constant FLASH_WRPR ( Write protection register ) 
: FLASH_ACR. cr ." FLASH_ACR () $" FLASH_ACR @ hex. FLASH_ACR 1b. ;
: FLASH_KEYR. cr ." FLASH_KEYR (write-only) $" FLASH_KEYR @ hex. FLASH_KEYR 1b. ;
: FLASH_OPTKEYR. cr ." FLASH_OPTKEYR (write-only) $" FLASH_OPTKEYR @ hex. FLASH_OPTKEYR 1b. ;
: FLASH_SR. cr ." FLASH_SR () $" FLASH_SR @ hex. FLASH_SR 1b. ;
: FLASH_CR. cr ." FLASH_CR (read-write) $" FLASH_CR @ hex. FLASH_CR 1b. ;
: FLASH_AR. cr ." FLASH_AR (write-only) $" FLASH_AR @ hex. FLASH_AR 1b. ;
: FLASH_OBR. cr ." FLASH_OBR (read-only) $" FLASH_OBR @ hex. FLASH_OBR 1b. ;
: FLASH_WRPR. cr ." FLASH_WRPR (read-only) $" FLASH_WRPR @ hex. FLASH_WRPR 1b. ;
: FLASH.
FLASH_ACR.
FLASH_KEYR.
FLASH_OPTKEYR.
FLASH_SR.
FLASH_CR.
FLASH_AR.
FLASH_OBR.
FLASH_WRPR.
;

$E000E000 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $4 + constant NVIC_ICTR ( Interrupt Controller Type  Register ) 
NVIC $F00 + constant NVIC_STIR ( Software Triggered Interrupt  Register ) 
NVIC $100 + constant NVIC_ISER0 ( Interrupt Set-Enable Register ) 
NVIC $104 + constant NVIC_ISER1 ( Interrupt Set-Enable Register ) 
NVIC $180 + constant NVIC_ICER0 ( Interrupt Clear-Enable  Register ) 
NVIC $184 + constant NVIC_ICER1 ( Interrupt Clear-Enable  Register ) 
NVIC $200 + constant NVIC_ISPR0 ( Interrupt Set-Pending Register ) 
NVIC $204 + constant NVIC_ISPR1 ( Interrupt Set-Pending Register ) 
NVIC $280 + constant NVIC_ICPR0 ( Interrupt Clear-Pending  Register ) 
NVIC $284 + constant NVIC_ICPR1 ( Interrupt Clear-Pending  Register ) 
NVIC $300 + constant NVIC_IABR0 ( Interrupt Active Bit Register ) 
NVIC $304 + constant NVIC_IABR1 ( Interrupt Active Bit Register ) 
NVIC $400 + constant NVIC_IPR0 ( Interrupt Priority Register ) 
NVIC $404 + constant NVIC_IPR1 ( Interrupt Priority Register ) 
NVIC $408 + constant NVIC_IPR2 ( Interrupt Priority Register ) 
NVIC $40C + constant NVIC_IPR3 ( Interrupt Priority Register ) 
NVIC $410 + constant NVIC_IPR4 ( Interrupt Priority Register ) 
NVIC $414 + constant NVIC_IPR5 ( Interrupt Priority Register ) 
NVIC $418 + constant NVIC_IPR6 ( Interrupt Priority Register ) 
NVIC $41C + constant NVIC_IPR7 ( Interrupt Priority Register ) 
NVIC $420 + constant NVIC_IPR8 ( Interrupt Priority Register ) 
NVIC $424 + constant NVIC_IPR9 ( Interrupt Priority Register ) 
NVIC $428 + constant NVIC_IPR10 ( Interrupt Priority Register ) 
NVIC $42C + constant NVIC_IPR11 ( Interrupt Priority Register ) 
NVIC $430 + constant NVIC_IPR12 ( Interrupt Priority Register ) 
NVIC $434 + constant NVIC_IPR13 ( Interrupt Priority Register ) 
NVIC $438 + constant NVIC_IPR14 ( Interrupt Priority Register ) 
: NVIC_ICTR. cr ." NVIC_ICTR (read-only) $" NVIC_ICTR @ hex. NVIC_ICTR 1b. ;
: NVIC_STIR. cr ." NVIC_STIR (write-only) $" NVIC_STIR @ hex. NVIC_STIR 1b. ;
: NVIC_ISER0. cr ." NVIC_ISER0 (read-write) $" NVIC_ISER0 @ hex. NVIC_ISER0 1b. ;
: NVIC_ISER1. cr ." NVIC_ISER1 (read-write) $" NVIC_ISER1 @ hex. NVIC_ISER1 1b. ;
: NVIC_ICER0. cr ." NVIC_ICER0 (read-write) $" NVIC_ICER0 @ hex. NVIC_ICER0 1b. ;
: NVIC_ICER1. cr ." NVIC_ICER1 (read-write) $" NVIC_ICER1 @ hex. NVIC_ICER1 1b. ;
: NVIC_ISPR0. cr ." NVIC_ISPR0 (read-write) $" NVIC_ISPR0 @ hex. NVIC_ISPR0 1b. ;
: NVIC_ISPR1. cr ." NVIC_ISPR1 (read-write) $" NVIC_ISPR1 @ hex. NVIC_ISPR1 1b. ;
: NVIC_ICPR0. cr ." NVIC_ICPR0 (read-write) $" NVIC_ICPR0 @ hex. NVIC_ICPR0 1b. ;
: NVIC_ICPR1. cr ." NVIC_ICPR1 (read-write) $" NVIC_ICPR1 @ hex. NVIC_ICPR1 1b. ;
: NVIC_IABR0. cr ." NVIC_IABR0 (read-only) $" NVIC_IABR0 @ hex. NVIC_IABR0 1b. ;
: NVIC_IABR1. cr ." NVIC_IABR1 (read-only) $" NVIC_IABR1 @ hex. NVIC_IABR1 1b. ;
: NVIC_IPR0. cr ." NVIC_IPR0 (read-write) $" NVIC_IPR0 @ hex. NVIC_IPR0 1b. ;
: NVIC_IPR1. cr ." NVIC_IPR1 (read-write) $" NVIC_IPR1 @ hex. NVIC_IPR1 1b. ;
: NVIC_IPR2. cr ." NVIC_IPR2 (read-write) $" NVIC_IPR2 @ hex. NVIC_IPR2 1b. ;
: NVIC_IPR3. cr ." NVIC_IPR3 (read-write) $" NVIC_IPR3 @ hex. NVIC_IPR3 1b. ;
: NVIC_IPR4. cr ." NVIC_IPR4 (read-write) $" NVIC_IPR4 @ hex. NVIC_IPR4 1b. ;
: NVIC_IPR5. cr ." NVIC_IPR5 (read-write) $" NVIC_IPR5 @ hex. NVIC_IPR5 1b. ;
: NVIC_IPR6. cr ." NVIC_IPR6 (read-write) $" NVIC_IPR6 @ hex. NVIC_IPR6 1b. ;
: NVIC_IPR7. cr ." NVIC_IPR7 (read-write) $" NVIC_IPR7 @ hex. NVIC_IPR7 1b. ;
: NVIC_IPR8. cr ." NVIC_IPR8 (read-write) $" NVIC_IPR8 @ hex. NVIC_IPR8 1b. ;
: NVIC_IPR9. cr ." NVIC_IPR9 (read-write) $" NVIC_IPR9 @ hex. NVIC_IPR9 1b. ;
: NVIC_IPR10. cr ." NVIC_IPR10 (read-write) $" NVIC_IPR10 @ hex. NVIC_IPR10 1b. ;
: NVIC_IPR11. cr ." NVIC_IPR11 (read-write) $" NVIC_IPR11 @ hex. NVIC_IPR11 1b. ;
: NVIC_IPR12. cr ." NVIC_IPR12 (read-write) $" NVIC_IPR12 @ hex. NVIC_IPR12 1b. ;
: NVIC_IPR13. cr ." NVIC_IPR13 (read-write) $" NVIC_IPR13 @ hex. NVIC_IPR13 1b. ;
: NVIC_IPR14. cr ." NVIC_IPR14 (read-write) $" NVIC_IPR14 @ hex. NVIC_IPR14 1b. ;
: NVIC.
NVIC_ICTR.
NVIC_STIR.
NVIC_ISER0.
NVIC_ISER1.
NVIC_ICER0.
NVIC_ICER1.
NVIC_ISPR0.
NVIC_ISPR1.
NVIC_ICPR0.
NVIC_ICPR1.
NVIC_IABR0.
NVIC_IABR1.
NVIC_IPR0.
NVIC_IPR1.
NVIC_IPR2.
NVIC_IPR3.
NVIC_IPR4.
NVIC_IPR5.
NVIC_IPR6.
NVIC_IPR7.
NVIC_IPR8.
NVIC_IPR9.
NVIC_IPR10.
NVIC_IPR11.
NVIC_IPR12.
NVIC_IPR13.
NVIC_IPR14.
;


compiletoram
