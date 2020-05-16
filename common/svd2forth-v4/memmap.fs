\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

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
: FSMC-BCR1. ." FSMC-BCR1 (read-write) $" FSMC-BCR1 @ hex. FSMC-BCR1 1b. ;
: FSMC-BTR1. ." FSMC-BTR1 (read-write) $" FSMC-BTR1 @ hex. FSMC-BTR1 1b. ;
: FSMC-BCR2. ." FSMC-BCR2 (read-write) $" FSMC-BCR2 @ hex. FSMC-BCR2 1b. ;
: FSMC-BTR2. ." FSMC-BTR2 (read-write) $" FSMC-BTR2 @ hex. FSMC-BTR2 1b. ;
: FSMC-BCR3. ." FSMC-BCR3 (read-write) $" FSMC-BCR3 @ hex. FSMC-BCR3 1b. ;
: FSMC-BTR3. ." FSMC-BTR3 (read-write) $" FSMC-BTR3 @ hex. FSMC-BTR3 1b. ;
: FSMC-BCR4. ." FSMC-BCR4 (read-write) $" FSMC-BCR4 @ hex. FSMC-BCR4 1b. ;
: FSMC-BTR4. ." FSMC-BTR4 (read-write) $" FSMC-BTR4 @ hex. FSMC-BTR4 1b. ;
: FSMC-PCR2. ." FSMC-PCR2 (read-write) $" FSMC-PCR2 @ hex. FSMC-PCR2 1b. ;
: FSMC-SR2. ." FSMC-SR2 () $" FSMC-SR2 @ hex. FSMC-SR2 1b. ;
: FSMC-PMEM2. ." FSMC-PMEM2 (read-write) $" FSMC-PMEM2 @ hex. FSMC-PMEM2 1b. ;
: FSMC-PATT2. ." FSMC-PATT2 (read-write) $" FSMC-PATT2 @ hex. FSMC-PATT2 1b. ;
: FSMC-ECCR2. ." FSMC-ECCR2 (read-only) $" FSMC-ECCR2 @ hex. FSMC-ECCR2 1b. ;
: FSMC-PCR3. ." FSMC-PCR3 (read-write) $" FSMC-PCR3 @ hex. FSMC-PCR3 1b. ;
: FSMC-SR3. ." FSMC-SR3 () $" FSMC-SR3 @ hex. FSMC-SR3 1b. ;
: FSMC-PMEM3. ." FSMC-PMEM3 (read-write) $" FSMC-PMEM3 @ hex. FSMC-PMEM3 1b. ;
: FSMC-PATT3. ." FSMC-PATT3 (read-write) $" FSMC-PATT3 @ hex. FSMC-PATT3 1b. ;
: FSMC-ECCR3. ." FSMC-ECCR3 (read-only) $" FSMC-ECCR3 @ hex. FSMC-ECCR3 1b. ;
: FSMC-PCR4. ." FSMC-PCR4 (read-write) $" FSMC-PCR4 @ hex. FSMC-PCR4 1b. ;
: FSMC-SR4. ." FSMC-SR4 () $" FSMC-SR4 @ hex. FSMC-SR4 1b. ;
: FSMC-PMEM4. ." FSMC-PMEM4 (read-write) $" FSMC-PMEM4 @ hex. FSMC-PMEM4 1b. ;
: FSMC-PATT4. ." FSMC-PATT4 (read-write) $" FSMC-PATT4 @ hex. FSMC-PATT4 1b. ;
: FSMC-PIO4. ." FSMC-PIO4 (read-write) $" FSMC-PIO4 @ hex. FSMC-PIO4 1b. ;
: FSMC-BWTR1. ." FSMC-BWTR1 (read-write) $" FSMC-BWTR1 @ hex. FSMC-BWTR1 1b. ;
: FSMC-BWTR2. ." FSMC-BWTR2 (read-write) $" FSMC-BWTR2 @ hex. FSMC-BWTR2 1b. ;
: FSMC-BWTR3. ." FSMC-BWTR3 (read-write) $" FSMC-BWTR3 @ hex. FSMC-BWTR3 1b. ;
: FSMC-BWTR4. ." FSMC-BWTR4 (read-write) $" FSMC-BWTR4 @ hex. FSMC-BWTR4 1b. ;
: FSMC.
FSMC-BCR1.
FSMC-BTR1.
FSMC-BCR2.
FSMC-BTR2.
FSMC-BCR3.
FSMC-BTR3.
FSMC-BCR4.
FSMC-BTR4.
FSMC-PCR2.
FSMC-SR2.
FSMC-PMEM2.
FSMC-PATT2.
FSMC-ECCR2.
FSMC-PCR3.
FSMC-SR3.
FSMC-PMEM3.
FSMC-PATT3.
FSMC-ECCR3.
FSMC-PCR4.
FSMC-SR4.
FSMC-PMEM4.
FSMC-PATT4.
FSMC-PIO4.
FSMC-BWTR1.
FSMC-BWTR2.
FSMC-BWTR3.
FSMC-BWTR4.
;

$40007000 constant PWR ( Power control ) 
PWR $0 + constant PWR-CR ( Power control register  PWR_CR ) 
PWR $4 + constant PWR-CSR ( Power control register  PWR_CR ) 
: PWR-CR. ." PWR-CR (read-write) $" PWR-CR @ hex. PWR-CR 1b. ;
: PWR-CSR. ." PWR-CSR () $" PWR-CSR @ hex. PWR-CSR 1b. ;
: PWR.
PWR-CR.
PWR-CSR.
;

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
: RCC-CR. ." RCC-CR () $" RCC-CR @ hex. RCC-CR 1b. ;
: RCC-CFGR. ." RCC-CFGR () $" RCC-CFGR @ hex. RCC-CFGR 1b. ;
: RCC-CIR. ." RCC-CIR () $" RCC-CIR @ hex. RCC-CIR 1b. ;
: RCC-APB2RSTR. ." RCC-APB2RSTR (read-write) $" RCC-APB2RSTR @ hex. RCC-APB2RSTR 1b. ;
: RCC-APB1RSTR. ." RCC-APB1RSTR (read-write) $" RCC-APB1RSTR @ hex. RCC-APB1RSTR 1b. ;
: RCC-AHBENR. ." RCC-AHBENR (read-write) $" RCC-AHBENR @ hex. RCC-AHBENR 1b. ;
: RCC-APB2ENR. ." RCC-APB2ENR (read-write) $" RCC-APB2ENR @ hex. RCC-APB2ENR 1b. ;
: RCC-APB1ENR. ." RCC-APB1ENR (read-write) $" RCC-APB1ENR @ hex. RCC-APB1ENR 1b. ;
: RCC-BDCR. ." RCC-BDCR () $" RCC-BDCR @ hex. RCC-BDCR 1b. ;
: RCC-CSR. ." RCC-CSR () $" RCC-CSR @ hex. RCC-CSR 1b. ;
: RCC.
RCC-CR.
RCC-CFGR.
RCC-CIR.
RCC-APB2RSTR.
RCC-APB1RSTR.
RCC-AHBENR.
RCC-APB2ENR.
RCC-APB1ENR.
RCC-BDCR.
RCC-CSR.
;

$40010800 constant GPIOA ( General purpose I/O ) 
GPIOA $0 + constant GPIOA-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOA $4 + constant GPIOA-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOA $8 + constant GPIOA-IDR ( Port input data register  GPIOn_IDR ) 
GPIOA $C + constant GPIOA-ODR ( Port output data register  GPIOn_ODR ) 
GPIOA $10 + constant GPIOA-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOA $14 + constant GPIOA-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOA $18 + constant GPIOA-LCKR ( Port configuration lock  register ) 
: GPIOA-CRL. ." GPIOA-CRL (read-write) $" GPIOA-CRL @ hex. GPIOA-CRL 1b. ;
: GPIOA-CRH. ." GPIOA-CRH (read-write) $" GPIOA-CRH @ hex. GPIOA-CRH 1b. ;
: GPIOA-IDR. ." GPIOA-IDR (read-only) $" GPIOA-IDR @ hex. GPIOA-IDR 1b. ;
: GPIOA-ODR. ." GPIOA-ODR (read-write) $" GPIOA-ODR @ hex. GPIOA-ODR 1b. ;
: GPIOA-BSRR. ." GPIOA-BSRR (write-only) $" GPIOA-BSRR @ hex. GPIOA-BSRR 1b. ;
: GPIOA-BRR. ." GPIOA-BRR (write-only) $" GPIOA-BRR @ hex. GPIOA-BRR 1b. ;
: GPIOA-LCKR. ." GPIOA-LCKR (read-write) $" GPIOA-LCKR @ hex. GPIOA-LCKR 1b. ;
: GPIOA.
GPIOA-CRL.
GPIOA-CRH.
GPIOA-IDR.
GPIOA-ODR.
GPIOA-BSRR.
GPIOA-BRR.
GPIOA-LCKR.
;

$40010C00 constant GPIOB ( General purpose I/O ) 
GPIOB $0 + constant GPIOB-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOB $4 + constant GPIOB-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOB $8 + constant GPIOB-IDR ( Port input data register  GPIOn_IDR ) 
GPIOB $C + constant GPIOB-ODR ( Port output data register  GPIOn_ODR ) 
GPIOB $10 + constant GPIOB-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOB $14 + constant GPIOB-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOB $18 + constant GPIOB-LCKR ( Port configuration lock  register ) 
: GPIOB-CRL. ." GPIOB-CRL (read-write) $" GPIOB-CRL @ hex. GPIOB-CRL 1b. ;
: GPIOB-CRH. ." GPIOB-CRH (read-write) $" GPIOB-CRH @ hex. GPIOB-CRH 1b. ;
: GPIOB-IDR. ." GPIOB-IDR (read-only) $" GPIOB-IDR @ hex. GPIOB-IDR 1b. ;
: GPIOB-ODR. ." GPIOB-ODR (read-write) $" GPIOB-ODR @ hex. GPIOB-ODR 1b. ;
: GPIOB-BSRR. ." GPIOB-BSRR (write-only) $" GPIOB-BSRR @ hex. GPIOB-BSRR 1b. ;
: GPIOB-BRR. ." GPIOB-BRR (write-only) $" GPIOB-BRR @ hex. GPIOB-BRR 1b. ;
: GPIOB-LCKR. ." GPIOB-LCKR (read-write) $" GPIOB-LCKR @ hex. GPIOB-LCKR 1b. ;
: GPIOB.
GPIOB-CRL.
GPIOB-CRH.
GPIOB-IDR.
GPIOB-ODR.
GPIOB-BSRR.
GPIOB-BRR.
GPIOB-LCKR.
;

$40011000 constant GPIOC ( General purpose I/O ) 
GPIOC $0 + constant GPIOC-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOC $4 + constant GPIOC-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOC $8 + constant GPIOC-IDR ( Port input data register  GPIOn_IDR ) 
GPIOC $C + constant GPIOC-ODR ( Port output data register  GPIOn_ODR ) 
GPIOC $10 + constant GPIOC-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOC $14 + constant GPIOC-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOC $18 + constant GPIOC-LCKR ( Port configuration lock  register ) 
: GPIOC-CRL. ." GPIOC-CRL (read-write) $" GPIOC-CRL @ hex. GPIOC-CRL 1b. ;
: GPIOC-CRH. ." GPIOC-CRH (read-write) $" GPIOC-CRH @ hex. GPIOC-CRH 1b. ;
: GPIOC-IDR. ." GPIOC-IDR (read-only) $" GPIOC-IDR @ hex. GPIOC-IDR 1b. ;
: GPIOC-ODR. ." GPIOC-ODR (read-write) $" GPIOC-ODR @ hex. GPIOC-ODR 1b. ;
: GPIOC-BSRR. ." GPIOC-BSRR (write-only) $" GPIOC-BSRR @ hex. GPIOC-BSRR 1b. ;
: GPIOC-BRR. ." GPIOC-BRR (write-only) $" GPIOC-BRR @ hex. GPIOC-BRR 1b. ;
: GPIOC-LCKR. ." GPIOC-LCKR (read-write) $" GPIOC-LCKR @ hex. GPIOC-LCKR 1b. ;
: GPIOC.
GPIOC-CRL.
GPIOC-CRH.
GPIOC-IDR.
GPIOC-ODR.
GPIOC-BSRR.
GPIOC-BRR.
GPIOC-LCKR.
;

$40011400 constant GPIOD ( General purpose I/O ) 
GPIOD $0 + constant GPIOD-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOD $4 + constant GPIOD-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOD $8 + constant GPIOD-IDR ( Port input data register  GPIOn_IDR ) 
GPIOD $C + constant GPIOD-ODR ( Port output data register  GPIOn_ODR ) 
GPIOD $10 + constant GPIOD-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOD $14 + constant GPIOD-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOD $18 + constant GPIOD-LCKR ( Port configuration lock  register ) 
: GPIOD-CRL. ." GPIOD-CRL (read-write) $" GPIOD-CRL @ hex. GPIOD-CRL 1b. ;
: GPIOD-CRH. ." GPIOD-CRH (read-write) $" GPIOD-CRH @ hex. GPIOD-CRH 1b. ;
: GPIOD-IDR. ." GPIOD-IDR (read-only) $" GPIOD-IDR @ hex. GPIOD-IDR 1b. ;
: GPIOD-ODR. ." GPIOD-ODR (read-write) $" GPIOD-ODR @ hex. GPIOD-ODR 1b. ;
: GPIOD-BSRR. ." GPIOD-BSRR (write-only) $" GPIOD-BSRR @ hex. GPIOD-BSRR 1b. ;
: GPIOD-BRR. ." GPIOD-BRR (write-only) $" GPIOD-BRR @ hex. GPIOD-BRR 1b. ;
: GPIOD-LCKR. ." GPIOD-LCKR (read-write) $" GPIOD-LCKR @ hex. GPIOD-LCKR 1b. ;
: GPIOD.
GPIOD-CRL.
GPIOD-CRH.
GPIOD-IDR.
GPIOD-ODR.
GPIOD-BSRR.
GPIOD-BRR.
GPIOD-LCKR.
;

$40011800 constant GPIOE ( General purpose I/O ) 
GPIOE $0 + constant GPIOE-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOE $4 + constant GPIOE-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOE $8 + constant GPIOE-IDR ( Port input data register  GPIOn_IDR ) 
GPIOE $C + constant GPIOE-ODR ( Port output data register  GPIOn_ODR ) 
GPIOE $10 + constant GPIOE-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOE $14 + constant GPIOE-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOE $18 + constant GPIOE-LCKR ( Port configuration lock  register ) 
: GPIOE-CRL. ." GPIOE-CRL (read-write) $" GPIOE-CRL @ hex. GPIOE-CRL 1b. ;
: GPIOE-CRH. ." GPIOE-CRH (read-write) $" GPIOE-CRH @ hex. GPIOE-CRH 1b. ;
: GPIOE-IDR. ." GPIOE-IDR (read-only) $" GPIOE-IDR @ hex. GPIOE-IDR 1b. ;
: GPIOE-ODR. ." GPIOE-ODR (read-write) $" GPIOE-ODR @ hex. GPIOE-ODR 1b. ;
: GPIOE-BSRR. ." GPIOE-BSRR (write-only) $" GPIOE-BSRR @ hex. GPIOE-BSRR 1b. ;
: GPIOE-BRR. ." GPIOE-BRR (write-only) $" GPIOE-BRR @ hex. GPIOE-BRR 1b. ;
: GPIOE-LCKR. ." GPIOE-LCKR (read-write) $" GPIOE-LCKR @ hex. GPIOE-LCKR 1b. ;
: GPIOE.
GPIOE-CRL.
GPIOE-CRH.
GPIOE-IDR.
GPIOE-ODR.
GPIOE-BSRR.
GPIOE-BRR.
GPIOE-LCKR.
;

$40011C00 constant GPIOF ( General purpose I/O ) 
GPIOF $0 + constant GPIOF-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOF $4 + constant GPIOF-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOF $8 + constant GPIOF-IDR ( Port input data register  GPIOn_IDR ) 
GPIOF $C + constant GPIOF-ODR ( Port output data register  GPIOn_ODR ) 
GPIOF $10 + constant GPIOF-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOF $14 + constant GPIOF-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOF $18 + constant GPIOF-LCKR ( Port configuration lock  register ) 
: GPIOF-CRL. ." GPIOF-CRL (read-write) $" GPIOF-CRL @ hex. GPIOF-CRL 1b. ;
: GPIOF-CRH. ." GPIOF-CRH (read-write) $" GPIOF-CRH @ hex. GPIOF-CRH 1b. ;
: GPIOF-IDR. ." GPIOF-IDR (read-only) $" GPIOF-IDR @ hex. GPIOF-IDR 1b. ;
: GPIOF-ODR. ." GPIOF-ODR (read-write) $" GPIOF-ODR @ hex. GPIOF-ODR 1b. ;
: GPIOF-BSRR. ." GPIOF-BSRR (write-only) $" GPIOF-BSRR @ hex. GPIOF-BSRR 1b. ;
: GPIOF-BRR. ." GPIOF-BRR (write-only) $" GPIOF-BRR @ hex. GPIOF-BRR 1b. ;
: GPIOF-LCKR. ." GPIOF-LCKR (read-write) $" GPIOF-LCKR @ hex. GPIOF-LCKR 1b. ;
: GPIOF.
GPIOF-CRL.
GPIOF-CRH.
GPIOF-IDR.
GPIOF-ODR.
GPIOF-BSRR.
GPIOF-BRR.
GPIOF-LCKR.
;

$40012000 constant GPIOG ( General purpose I/O ) 
GPIOG $0 + constant GPIOG-CRL ( Port configuration register low  GPIOn_CRL ) 
GPIOG $4 + constant GPIOG-CRH ( Port configuration register high  GPIOn_CRL ) 
GPIOG $8 + constant GPIOG-IDR ( Port input data register  GPIOn_IDR ) 
GPIOG $C + constant GPIOG-ODR ( Port output data register  GPIOn_ODR ) 
GPIOG $10 + constant GPIOG-BSRR ( Port bit set/reset register  GPIOn_BSRR ) 
GPIOG $14 + constant GPIOG-BRR ( Port bit reset register  GPIOn_BRR ) 
GPIOG $18 + constant GPIOG-LCKR ( Port configuration lock  register ) 
: GPIOG-CRL. ." GPIOG-CRL (read-write) $" GPIOG-CRL @ hex. GPIOG-CRL 1b. ;
: GPIOG-CRH. ." GPIOG-CRH (read-write) $" GPIOG-CRH @ hex. GPIOG-CRH 1b. ;
: GPIOG-IDR. ." GPIOG-IDR (read-only) $" GPIOG-IDR @ hex. GPIOG-IDR 1b. ;
: GPIOG-ODR. ." GPIOG-ODR (read-write) $" GPIOG-ODR @ hex. GPIOG-ODR 1b. ;
: GPIOG-BSRR. ." GPIOG-BSRR (write-only) $" GPIOG-BSRR @ hex. GPIOG-BSRR 1b. ;
: GPIOG-BRR. ." GPIOG-BRR (write-only) $" GPIOG-BRR @ hex. GPIOG-BRR 1b. ;
: GPIOG-LCKR. ." GPIOG-LCKR (read-write) $" GPIOG-LCKR @ hex. GPIOG-LCKR 1b. ;
: GPIOG.
GPIOG-CRL.
GPIOG-CRH.
GPIOG-IDR.
GPIOG-ODR.
GPIOG-BSRR.
GPIOG-BRR.
GPIOG-LCKR.
;

$40010000 constant AFIO ( Alternate function I/O ) 
AFIO $0 + constant AFIO-EVCR ( Event Control Register  AFIO_EVCR ) 
AFIO $4 + constant AFIO-MAPR ( AF remap and debug I/O configuration  register AFIO_MAPR ) 
AFIO $8 + constant AFIO-EXTICR1 ( External interrupt configuration register 1  AFIO_EXTICR1 ) 
AFIO $C + constant AFIO-EXTICR2 ( External interrupt configuration register 2  AFIO_EXTICR2 ) 
AFIO $10 + constant AFIO-EXTICR3 ( External interrupt configuration register 3  AFIO_EXTICR3 ) 
AFIO $14 + constant AFIO-EXTICR4 ( External interrupt configuration register 4  AFIO_EXTICR4 ) 
AFIO $1C + constant AFIO-MAPR2 ( AF remap and debug I/O configuration  register ) 
: AFIO-EVCR. ." AFIO-EVCR (read-write) $" AFIO-EVCR @ hex. AFIO-EVCR 1b. ;
: AFIO-MAPR. ." AFIO-MAPR () $" AFIO-MAPR @ hex. AFIO-MAPR 1b. ;
: AFIO-EXTICR1. ." AFIO-EXTICR1 (read-write) $" AFIO-EXTICR1 @ hex. AFIO-EXTICR1 1b. ;
: AFIO-EXTICR2. ." AFIO-EXTICR2 (read-write) $" AFIO-EXTICR2 @ hex. AFIO-EXTICR2 1b. ;
: AFIO-EXTICR3. ." AFIO-EXTICR3 (read-write) $" AFIO-EXTICR3 @ hex. AFIO-EXTICR3 1b. ;
: AFIO-EXTICR4. ." AFIO-EXTICR4 (read-write) $" AFIO-EXTICR4 @ hex. AFIO-EXTICR4 1b. ;
: AFIO-MAPR2. ." AFIO-MAPR2 (read-write) $" AFIO-MAPR2 @ hex. AFIO-MAPR2 1b. ;
: AFIO.
AFIO-EVCR.
AFIO-MAPR.
AFIO-EXTICR1.
AFIO-EXTICR2.
AFIO-EXTICR3.
AFIO-EXTICR4.
AFIO-MAPR2.
;

$40010400 constant EXTI ( EXTI ) 
EXTI $0 + constant EXTI-IMR ( Interrupt mask register  EXTI_IMR ) 
EXTI $4 + constant EXTI-EMR ( Event mask register EXTI_EMR ) 
EXTI $8 + constant EXTI-RTSR ( Rising Trigger selection register  EXTI_RTSR ) 
EXTI $C + constant EXTI-FTSR ( Falling Trigger selection register  EXTI_FTSR ) 
EXTI $10 + constant EXTI-SWIER ( Software interrupt event register  EXTI_SWIER ) 
EXTI $14 + constant EXTI-PR ( Pending register EXTI_PR ) 
: EXTI-IMR. ." EXTI-IMR (read-write) $" EXTI-IMR @ hex. EXTI-IMR 1b. ;
: EXTI-EMR. ." EXTI-EMR (read-write) $" EXTI-EMR @ hex. EXTI-EMR 1b. ;
: EXTI-RTSR. ." EXTI-RTSR (read-write) $" EXTI-RTSR @ hex. EXTI-RTSR 1b. ;
: EXTI-FTSR. ." EXTI-FTSR (read-write) $" EXTI-FTSR @ hex. EXTI-FTSR 1b. ;
: EXTI-SWIER. ." EXTI-SWIER (read-write) $" EXTI-SWIER @ hex. EXTI-SWIER 1b. ;
: EXTI-PR. ." EXTI-PR (read-write) $" EXTI-PR @ hex. EXTI-PR 1b. ;
: EXTI.
EXTI-IMR.
EXTI-EMR.
EXTI-RTSR.
EXTI-FTSR.
EXTI-SWIER.
EXTI-PR.
;

$40020000 constant DMA1 ( DMA controller ) 
DMA1 $0 + constant DMA1-ISR ( DMA interrupt status register  DMA_ISR ) 
DMA1 $4 + constant DMA1-IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA1 $8 + constant DMA1-CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $C + constant DMA1-CNDTR1 ( DMA channel 1 number of data  register ) 
DMA1 $10 + constant DMA1-CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA1 $14 + constant DMA1-CMAR1 ( DMA channel 1 memory address  register ) 
DMA1 $1C + constant DMA1-CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $20 + constant DMA1-CNDTR2 ( DMA channel 2 number of data  register ) 
DMA1 $24 + constant DMA1-CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA1 $28 + constant DMA1-CMAR2 ( DMA channel 2 memory address  register ) 
DMA1 $30 + constant DMA1-CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $34 + constant DMA1-CNDTR3 ( DMA channel 3 number of data  register ) 
DMA1 $38 + constant DMA1-CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA1 $3C + constant DMA1-CMAR3 ( DMA channel 3 memory address  register ) 
DMA1 $44 + constant DMA1-CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $48 + constant DMA1-CNDTR4 ( DMA channel 4 number of data  register ) 
DMA1 $4C + constant DMA1-CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA1 $50 + constant DMA1-CMAR4 ( DMA channel 4 memory address  register ) 
DMA1 $58 + constant DMA1-CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $5C + constant DMA1-CNDTR5 ( DMA channel 5 number of data  register ) 
DMA1 $60 + constant DMA1-CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA1 $64 + constant DMA1-CMAR5 ( DMA channel 5 memory address  register ) 
DMA1 $6C + constant DMA1-CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $70 + constant DMA1-CNDTR6 ( DMA channel 6 number of data  register ) 
DMA1 $74 + constant DMA1-CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA1 $78 + constant DMA1-CMAR6 ( DMA channel 6 memory address  register ) 
DMA1 $80 + constant DMA1-CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $84 + constant DMA1-CNDTR7 ( DMA channel 7 number of data  register ) 
DMA1 $88 + constant DMA1-CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA1 $8C + constant DMA1-CMAR7 ( DMA channel 7 memory address  register ) 
: DMA1-ISR. ." DMA1-ISR (read-only) $" DMA1-ISR @ hex. DMA1-ISR 1b. ;
: DMA1-IFCR. ." DMA1-IFCR (write-only) $" DMA1-IFCR @ hex. DMA1-IFCR 1b. ;
: DMA1-CCR1. ." DMA1-CCR1 (read-write) $" DMA1-CCR1 @ hex. DMA1-CCR1 1b. ;
: DMA1-CNDTR1. ." DMA1-CNDTR1 (read-write) $" DMA1-CNDTR1 @ hex. DMA1-CNDTR1 1b. ;
: DMA1-CPAR1. ." DMA1-CPAR1 (read-write) $" DMA1-CPAR1 @ hex. DMA1-CPAR1 1b. ;
: DMA1-CMAR1. ." DMA1-CMAR1 (read-write) $" DMA1-CMAR1 @ hex. DMA1-CMAR1 1b. ;
: DMA1-CCR2. ." DMA1-CCR2 (read-write) $" DMA1-CCR2 @ hex. DMA1-CCR2 1b. ;
: DMA1-CNDTR2. ." DMA1-CNDTR2 (read-write) $" DMA1-CNDTR2 @ hex. DMA1-CNDTR2 1b. ;
: DMA1-CPAR2. ." DMA1-CPAR2 (read-write) $" DMA1-CPAR2 @ hex. DMA1-CPAR2 1b. ;
: DMA1-CMAR2. ." DMA1-CMAR2 (read-write) $" DMA1-CMAR2 @ hex. DMA1-CMAR2 1b. ;
: DMA1-CCR3. ." DMA1-CCR3 (read-write) $" DMA1-CCR3 @ hex. DMA1-CCR3 1b. ;
: DMA1-CNDTR3. ." DMA1-CNDTR3 (read-write) $" DMA1-CNDTR3 @ hex. DMA1-CNDTR3 1b. ;
: DMA1-CPAR3. ." DMA1-CPAR3 (read-write) $" DMA1-CPAR3 @ hex. DMA1-CPAR3 1b. ;
: DMA1-CMAR3. ." DMA1-CMAR3 (read-write) $" DMA1-CMAR3 @ hex. DMA1-CMAR3 1b. ;
: DMA1-CCR4. ." DMA1-CCR4 (read-write) $" DMA1-CCR4 @ hex. DMA1-CCR4 1b. ;
: DMA1-CNDTR4. ." DMA1-CNDTR4 (read-write) $" DMA1-CNDTR4 @ hex. DMA1-CNDTR4 1b. ;
: DMA1-CPAR4. ." DMA1-CPAR4 (read-write) $" DMA1-CPAR4 @ hex. DMA1-CPAR4 1b. ;
: DMA1-CMAR4. ." DMA1-CMAR4 (read-write) $" DMA1-CMAR4 @ hex. DMA1-CMAR4 1b. ;
: DMA1-CCR5. ." DMA1-CCR5 (read-write) $" DMA1-CCR5 @ hex. DMA1-CCR5 1b. ;
: DMA1-CNDTR5. ." DMA1-CNDTR5 (read-write) $" DMA1-CNDTR5 @ hex. DMA1-CNDTR5 1b. ;
: DMA1-CPAR5. ." DMA1-CPAR5 (read-write) $" DMA1-CPAR5 @ hex. DMA1-CPAR5 1b. ;
: DMA1-CMAR5. ." DMA1-CMAR5 (read-write) $" DMA1-CMAR5 @ hex. DMA1-CMAR5 1b. ;
: DMA1-CCR6. ." DMA1-CCR6 (read-write) $" DMA1-CCR6 @ hex. DMA1-CCR6 1b. ;
: DMA1-CNDTR6. ." DMA1-CNDTR6 (read-write) $" DMA1-CNDTR6 @ hex. DMA1-CNDTR6 1b. ;
: DMA1-CPAR6. ." DMA1-CPAR6 (read-write) $" DMA1-CPAR6 @ hex. DMA1-CPAR6 1b. ;
: DMA1-CMAR6. ." DMA1-CMAR6 (read-write) $" DMA1-CMAR6 @ hex. DMA1-CMAR6 1b. ;
: DMA1-CCR7. ." DMA1-CCR7 (read-write) $" DMA1-CCR7 @ hex. DMA1-CCR7 1b. ;
: DMA1-CNDTR7. ." DMA1-CNDTR7 (read-write) $" DMA1-CNDTR7 @ hex. DMA1-CNDTR7 1b. ;
: DMA1-CPAR7. ." DMA1-CPAR7 (read-write) $" DMA1-CPAR7 @ hex. DMA1-CPAR7 1b. ;
: DMA1-CMAR7. ." DMA1-CMAR7 (read-write) $" DMA1-CMAR7 @ hex. DMA1-CMAR7 1b. ;
: DMA1.
DMA1-ISR.
DMA1-IFCR.
DMA1-CCR1.
DMA1-CNDTR1.
DMA1-CPAR1.
DMA1-CMAR1.
DMA1-CCR2.
DMA1-CNDTR2.
DMA1-CPAR2.
DMA1-CMAR2.
DMA1-CCR3.
DMA1-CNDTR3.
DMA1-CPAR3.
DMA1-CMAR3.
DMA1-CCR4.
DMA1-CNDTR4.
DMA1-CPAR4.
DMA1-CMAR4.
DMA1-CCR5.
DMA1-CNDTR5.
DMA1-CPAR5.
DMA1-CMAR5.
DMA1-CCR6.
DMA1-CNDTR6.
DMA1-CPAR6.
DMA1-CMAR6.
DMA1-CCR7.
DMA1-CNDTR7.
DMA1-CPAR7.
DMA1-CMAR7.
;

$40020400 constant DMA2 ( DMA controller ) 
DMA2 $0 + constant DMA2-ISR ( DMA interrupt status register  DMA_ISR ) 
DMA2 $4 + constant DMA2-IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA2 $8 + constant DMA2-CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $C + constant DMA2-CNDTR1 ( DMA channel 1 number of data  register ) 
DMA2 $10 + constant DMA2-CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA2 $14 + constant DMA2-CMAR1 ( DMA channel 1 memory address  register ) 
DMA2 $1C + constant DMA2-CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $20 + constant DMA2-CNDTR2 ( DMA channel 2 number of data  register ) 
DMA2 $24 + constant DMA2-CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA2 $28 + constant DMA2-CMAR2 ( DMA channel 2 memory address  register ) 
DMA2 $30 + constant DMA2-CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $34 + constant DMA2-CNDTR3 ( DMA channel 3 number of data  register ) 
DMA2 $38 + constant DMA2-CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA2 $3C + constant DMA2-CMAR3 ( DMA channel 3 memory address  register ) 
DMA2 $44 + constant DMA2-CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $48 + constant DMA2-CNDTR4 ( DMA channel 4 number of data  register ) 
DMA2 $4C + constant DMA2-CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA2 $50 + constant DMA2-CMAR4 ( DMA channel 4 memory address  register ) 
DMA2 $58 + constant DMA2-CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $5C + constant DMA2-CNDTR5 ( DMA channel 5 number of data  register ) 
DMA2 $60 + constant DMA2-CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA2 $64 + constant DMA2-CMAR5 ( DMA channel 5 memory address  register ) 
DMA2 $6C + constant DMA2-CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $70 + constant DMA2-CNDTR6 ( DMA channel 6 number of data  register ) 
DMA2 $74 + constant DMA2-CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA2 $78 + constant DMA2-CMAR6 ( DMA channel 6 memory address  register ) 
DMA2 $80 + constant DMA2-CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $84 + constant DMA2-CNDTR7 ( DMA channel 7 number of data  register ) 
DMA2 $88 + constant DMA2-CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA2 $8C + constant DMA2-CMAR7 ( DMA channel 7 memory address  register ) 
: DMA2-ISR. ." DMA2-ISR (read-only) $" DMA2-ISR @ hex. DMA2-ISR 1b. ;
: DMA2-IFCR. ." DMA2-IFCR (write-only) $" DMA2-IFCR @ hex. DMA2-IFCR 1b. ;
: DMA2-CCR1. ." DMA2-CCR1 (read-write) $" DMA2-CCR1 @ hex. DMA2-CCR1 1b. ;
: DMA2-CNDTR1. ." DMA2-CNDTR1 (read-write) $" DMA2-CNDTR1 @ hex. DMA2-CNDTR1 1b. ;
: DMA2-CPAR1. ." DMA2-CPAR1 (read-write) $" DMA2-CPAR1 @ hex. DMA2-CPAR1 1b. ;
: DMA2-CMAR1. ." DMA2-CMAR1 (read-write) $" DMA2-CMAR1 @ hex. DMA2-CMAR1 1b. ;
: DMA2-CCR2. ." DMA2-CCR2 (read-write) $" DMA2-CCR2 @ hex. DMA2-CCR2 1b. ;
: DMA2-CNDTR2. ." DMA2-CNDTR2 (read-write) $" DMA2-CNDTR2 @ hex. DMA2-CNDTR2 1b. ;
: DMA2-CPAR2. ." DMA2-CPAR2 (read-write) $" DMA2-CPAR2 @ hex. DMA2-CPAR2 1b. ;
: DMA2-CMAR2. ." DMA2-CMAR2 (read-write) $" DMA2-CMAR2 @ hex. DMA2-CMAR2 1b. ;
: DMA2-CCR3. ." DMA2-CCR3 (read-write) $" DMA2-CCR3 @ hex. DMA2-CCR3 1b. ;
: DMA2-CNDTR3. ." DMA2-CNDTR3 (read-write) $" DMA2-CNDTR3 @ hex. DMA2-CNDTR3 1b. ;
: DMA2-CPAR3. ." DMA2-CPAR3 (read-write) $" DMA2-CPAR3 @ hex. DMA2-CPAR3 1b. ;
: DMA2-CMAR3. ." DMA2-CMAR3 (read-write) $" DMA2-CMAR3 @ hex. DMA2-CMAR3 1b. ;
: DMA2-CCR4. ." DMA2-CCR4 (read-write) $" DMA2-CCR4 @ hex. DMA2-CCR4 1b. ;
: DMA2-CNDTR4. ." DMA2-CNDTR4 (read-write) $" DMA2-CNDTR4 @ hex. DMA2-CNDTR4 1b. ;
: DMA2-CPAR4. ." DMA2-CPAR4 (read-write) $" DMA2-CPAR4 @ hex. DMA2-CPAR4 1b. ;
: DMA2-CMAR4. ." DMA2-CMAR4 (read-write) $" DMA2-CMAR4 @ hex. DMA2-CMAR4 1b. ;
: DMA2-CCR5. ." DMA2-CCR5 (read-write) $" DMA2-CCR5 @ hex. DMA2-CCR5 1b. ;
: DMA2-CNDTR5. ." DMA2-CNDTR5 (read-write) $" DMA2-CNDTR5 @ hex. DMA2-CNDTR5 1b. ;
: DMA2-CPAR5. ." DMA2-CPAR5 (read-write) $" DMA2-CPAR5 @ hex. DMA2-CPAR5 1b. ;
: DMA2-CMAR5. ." DMA2-CMAR5 (read-write) $" DMA2-CMAR5 @ hex. DMA2-CMAR5 1b. ;
: DMA2-CCR6. ." DMA2-CCR6 (read-write) $" DMA2-CCR6 @ hex. DMA2-CCR6 1b. ;
: DMA2-CNDTR6. ." DMA2-CNDTR6 (read-write) $" DMA2-CNDTR6 @ hex. DMA2-CNDTR6 1b. ;
: DMA2-CPAR6. ." DMA2-CPAR6 (read-write) $" DMA2-CPAR6 @ hex. DMA2-CPAR6 1b. ;
: DMA2-CMAR6. ." DMA2-CMAR6 (read-write) $" DMA2-CMAR6 @ hex. DMA2-CMAR6 1b. ;
: DMA2-CCR7. ." DMA2-CCR7 (read-write) $" DMA2-CCR7 @ hex. DMA2-CCR7 1b. ;
: DMA2-CNDTR7. ." DMA2-CNDTR7 (read-write) $" DMA2-CNDTR7 @ hex. DMA2-CNDTR7 1b. ;
: DMA2-CPAR7. ." DMA2-CPAR7 (read-write) $" DMA2-CPAR7 @ hex. DMA2-CPAR7 1b. ;
: DMA2-CMAR7. ." DMA2-CMAR7 (read-write) $" DMA2-CMAR7 @ hex. DMA2-CMAR7 1b. ;
: DMA2.
DMA2-ISR.
DMA2-IFCR.
DMA2-CCR1.
DMA2-CNDTR1.
DMA2-CPAR1.
DMA2-CMAR1.
DMA2-CCR2.
DMA2-CNDTR2.
DMA2-CPAR2.
DMA2-CMAR2.
DMA2-CCR3.
DMA2-CNDTR3.
DMA2-CPAR3.
DMA2-CMAR3.
DMA2-CCR4.
DMA2-CNDTR4.
DMA2-CPAR4.
DMA2-CMAR4.
DMA2-CCR5.
DMA2-CNDTR5.
DMA2-CPAR5.
DMA2-CMAR5.
DMA2-CCR6.
DMA2-CNDTR6.
DMA2-CPAR6.
DMA2-CMAR6.
DMA2-CCR7.
DMA2-CNDTR7.
DMA2-CPAR7.
DMA2-CMAR7.
;

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
: SDIO-POWER. ." SDIO-POWER (read-write) $" SDIO-POWER @ hex. SDIO-POWER 1b. ;
: SDIO-CLKCR. ." SDIO-CLKCR (read-write) $" SDIO-CLKCR @ hex. SDIO-CLKCR 1b. ;
: SDIO-ARG. ." SDIO-ARG (read-write) $" SDIO-ARG @ hex. SDIO-ARG 1b. ;
: SDIO-CMD. ." SDIO-CMD (read-write) $" SDIO-CMD @ hex. SDIO-CMD 1b. ;
: SDIO-RESPCMD. ." SDIO-RESPCMD (read-only) $" SDIO-RESPCMD @ hex. SDIO-RESPCMD 1b. ;
: SDIO-RESPI1. ." SDIO-RESPI1 (read-only) $" SDIO-RESPI1 @ hex. SDIO-RESPI1 1b. ;
: SDIO-RESP2. ." SDIO-RESP2 (read-only) $" SDIO-RESP2 @ hex. SDIO-RESP2 1b. ;
: SDIO-RESP3. ." SDIO-RESP3 (read-only) $" SDIO-RESP3 @ hex. SDIO-RESP3 1b. ;
: SDIO-RESP4. ." SDIO-RESP4 (read-only) $" SDIO-RESP4 @ hex. SDIO-RESP4 1b. ;
: SDIO-DTIMER. ." SDIO-DTIMER (read-write) $" SDIO-DTIMER @ hex. SDIO-DTIMER 1b. ;
: SDIO-DLEN. ." SDIO-DLEN (read-write) $" SDIO-DLEN @ hex. SDIO-DLEN 1b. ;
: SDIO-DCTRL. ." SDIO-DCTRL (read-write) $" SDIO-DCTRL @ hex. SDIO-DCTRL 1b. ;
: SDIO-DCOUNT. ." SDIO-DCOUNT (read-only) $" SDIO-DCOUNT @ hex. SDIO-DCOUNT 1b. ;
: SDIO-STA. ." SDIO-STA (read-only) $" SDIO-STA @ hex. SDIO-STA 1b. ;
: SDIO-ICR. ." SDIO-ICR (read-write) $" SDIO-ICR @ hex. SDIO-ICR 1b. ;
: SDIO-MASK. ." SDIO-MASK (read-write) $" SDIO-MASK @ hex. SDIO-MASK 1b. ;
: SDIO-FIFOCNT. ." SDIO-FIFOCNT (read-only) $" SDIO-FIFOCNT @ hex. SDIO-FIFOCNT 1b. ;
: SDIO-FIFO. ." SDIO-FIFO (read-write) $" SDIO-FIFO @ hex. SDIO-FIFO 1b. ;
: SDIO.
SDIO-POWER.
SDIO-CLKCR.
SDIO-ARG.
SDIO-CMD.
SDIO-RESPCMD.
SDIO-RESPI1.
SDIO-RESP2.
SDIO-RESP3.
SDIO-RESP4.
SDIO-DTIMER.
SDIO-DLEN.
SDIO-DCTRL.
SDIO-DCOUNT.
SDIO-STA.
SDIO-ICR.
SDIO-MASK.
SDIO-FIFOCNT.
SDIO-FIFO.
;

$40002800 constant RTC ( Real time clock ) 
RTC $0 + constant RTC-CRH ( RTC Control Register High ) 
RTC $4 + constant RTC-CRL ( RTC Control Register Low ) 
RTC $8 + constant RTC-PRLH ( RTC Prescaler Load Register  High ) 
RTC $C + constant RTC-PRLL ( RTC Prescaler Load Register  Low ) 
RTC $10 + constant RTC-DIVH ( RTC Prescaler Divider Register  High ) 
RTC $14 + constant RTC-DIVL ( RTC Prescaler Divider Register  Low ) 
RTC $18 + constant RTC-CNTH ( RTC Counter Register High ) 
RTC $1C + constant RTC-CNTL ( RTC Counter Register Low ) 
RTC $20 + constant RTC-ALRH ( RTC Alarm Register High ) 
RTC $24 + constant RTC-ALRL ( RTC Alarm Register Low ) 
: RTC-CRH. ." RTC-CRH (read-write) $" RTC-CRH @ hex. RTC-CRH 1b. ;
: RTC-CRL. ." RTC-CRL () $" RTC-CRL @ hex. RTC-CRL 1b. ;
: RTC-PRLH. ." RTC-PRLH (write-only) $" RTC-PRLH @ hex. RTC-PRLH 1b. ;
: RTC-PRLL. ." RTC-PRLL (write-only) $" RTC-PRLL @ hex. RTC-PRLL 1b. ;
: RTC-DIVH. ." RTC-DIVH (read-only) $" RTC-DIVH @ hex. RTC-DIVH 1b. ;
: RTC-DIVL. ." RTC-DIVL (read-only) $" RTC-DIVL @ hex. RTC-DIVL 1b. ;
: RTC-CNTH. ." RTC-CNTH (read-write) $" RTC-CNTH @ hex. RTC-CNTH 1b. ;
: RTC-CNTL. ." RTC-CNTL (read-write) $" RTC-CNTL @ hex. RTC-CNTL 1b. ;
: RTC-ALRH. ." RTC-ALRH (write-only) $" RTC-ALRH @ hex. RTC-ALRH 1b. ;
: RTC-ALRL. ." RTC-ALRL (write-only) $" RTC-ALRL @ hex. RTC-ALRL 1b. ;
: RTC.
RTC-CRH.
RTC-CRL.
RTC-PRLH.
RTC-PRLL.
RTC-DIVH.
RTC-DIVL.
RTC-CNTH.
RTC-CNTL.
RTC-ALRH.
RTC-ALRL.
;

$40006C04 constant BKP ( Backup registers ) 
BKP $0 + constant BKP-DR1 ( Backup data register BKP_DR ) 
BKP $4 + constant BKP-DR2 ( Backup data register BKP_DR ) 
BKP $8 + constant BKP-DR3 ( Backup data register BKP_DR ) 
BKP $C + constant BKP-DR4 ( Backup data register BKP_DR ) 
BKP $10 + constant BKP-DR5 ( Backup data register BKP_DR ) 
BKP $14 + constant BKP-DR6 ( Backup data register BKP_DR ) 
BKP $18 + constant BKP-DR7 ( Backup data register BKP_DR ) 
BKP $1C + constant BKP-DR8 ( Backup data register BKP_DR ) 
BKP $20 + constant BKP-DR9 ( Backup data register BKP_DR ) 
BKP $24 + constant BKP-DR10 ( Backup data register BKP_DR ) 
BKP $3C + constant BKP-DR11 ( Backup data register BKP_DR ) 
BKP $40 + constant BKP-DR12 ( Backup data register BKP_DR ) 
BKP $44 + constant BKP-DR13 ( Backup data register BKP_DR ) 
BKP $48 + constant BKP-DR14 ( Backup data register BKP_DR ) 
BKP $4C + constant BKP-DR15 ( Backup data register BKP_DR ) 
BKP $50 + constant BKP-DR16 ( Backup data register BKP_DR ) 
BKP $54 + constant BKP-DR17 ( Backup data register BKP_DR ) 
BKP $58 + constant BKP-DR18 ( Backup data register BKP_DR ) 
BKP $5C + constant BKP-DR19 ( Backup data register BKP_DR ) 
BKP $60 + constant BKP-DR20 ( Backup data register BKP_DR ) 
BKP $64 + constant BKP-DR21 ( Backup data register BKP_DR ) 
BKP $68 + constant BKP-DR22 ( Backup data register BKP_DR ) 
BKP $6C + constant BKP-DR23 ( Backup data register BKP_DR ) 
BKP $70 + constant BKP-DR24 ( Backup data register BKP_DR ) 
BKP $74 + constant BKP-DR25 ( Backup data register BKP_DR ) 
BKP $78 + constant BKP-DR26 ( Backup data register BKP_DR ) 
BKP $7C + constant BKP-DR27 ( Backup data register BKP_DR ) 
BKP $80 + constant BKP-DR28 ( Backup data register BKP_DR ) 
BKP $84 + constant BKP-DR29 ( Backup data register BKP_DR ) 
BKP $88 + constant BKP-DR30 ( Backup data register BKP_DR ) 
BKP $8C + constant BKP-DR31 ( Backup data register BKP_DR ) 
BKP $90 + constant BKP-DR32 ( Backup data register BKP_DR ) 
BKP $94 + constant BKP-DR33 ( Backup data register BKP_DR ) 
BKP $98 + constant BKP-DR34 ( Backup data register BKP_DR ) 
BKP $9C + constant BKP-DR35 ( Backup data register BKP_DR ) 
BKP $A0 + constant BKP-DR36 ( Backup data register BKP_DR ) 
BKP $A4 + constant BKP-DR37 ( Backup data register BKP_DR ) 
BKP $A8 + constant BKP-DR38 ( Backup data register BKP_DR ) 
BKP $AC + constant BKP-DR39 ( Backup data register BKP_DR ) 
BKP $B0 + constant BKP-DR40 ( Backup data register BKP_DR ) 
BKP $B4 + constant BKP-DR41 ( Backup data register BKP_DR ) 
BKP $B8 + constant BKP-DR42 ( Backup data register BKP_DR ) 
BKP $28 + constant BKP-RTCCR ( RTC clock calibration register  BKP_RTCCR ) 
BKP $2C + constant BKP-CR ( Backup control register  BKP_CR ) 
BKP $30 + constant BKP-CSR ( BKP_CSR control/status register  BKP_CSR ) 
: BKP-DR1. ." BKP-DR1 (read-write) $" BKP-DR1 @ hex. BKP-DR1 1b. ;
: BKP-DR2. ." BKP-DR2 (read-write) $" BKP-DR2 @ hex. BKP-DR2 1b. ;
: BKP-DR3. ." BKP-DR3 (read-write) $" BKP-DR3 @ hex. BKP-DR3 1b. ;
: BKP-DR4. ." BKP-DR4 (read-write) $" BKP-DR4 @ hex. BKP-DR4 1b. ;
: BKP-DR5. ." BKP-DR5 (read-write) $" BKP-DR5 @ hex. BKP-DR5 1b. ;
: BKP-DR6. ." BKP-DR6 (read-write) $" BKP-DR6 @ hex. BKP-DR6 1b. ;
: BKP-DR7. ." BKP-DR7 (read-write) $" BKP-DR7 @ hex. BKP-DR7 1b. ;
: BKP-DR8. ." BKP-DR8 (read-write) $" BKP-DR8 @ hex. BKP-DR8 1b. ;
: BKP-DR9. ." BKP-DR9 (read-write) $" BKP-DR9 @ hex. BKP-DR9 1b. ;
: BKP-DR10. ." BKP-DR10 (read-write) $" BKP-DR10 @ hex. BKP-DR10 1b. ;
: BKP-DR11. ." BKP-DR11 (read-write) $" BKP-DR11 @ hex. BKP-DR11 1b. ;
: BKP-DR12. ." BKP-DR12 (read-write) $" BKP-DR12 @ hex. BKP-DR12 1b. ;
: BKP-DR13. ." BKP-DR13 (read-write) $" BKP-DR13 @ hex. BKP-DR13 1b. ;
: BKP-DR14. ." BKP-DR14 (read-write) $" BKP-DR14 @ hex. BKP-DR14 1b. ;
: BKP-DR15. ." BKP-DR15 (read-write) $" BKP-DR15 @ hex. BKP-DR15 1b. ;
: BKP-DR16. ." BKP-DR16 (read-write) $" BKP-DR16 @ hex. BKP-DR16 1b. ;
: BKP-DR17. ." BKP-DR17 (read-write) $" BKP-DR17 @ hex. BKP-DR17 1b. ;
: BKP-DR18. ." BKP-DR18 (read-write) $" BKP-DR18 @ hex. BKP-DR18 1b. ;
: BKP-DR19. ." BKP-DR19 (read-write) $" BKP-DR19 @ hex. BKP-DR19 1b. ;
: BKP-DR20. ." BKP-DR20 (read-write) $" BKP-DR20 @ hex. BKP-DR20 1b. ;
: BKP-DR21. ." BKP-DR21 (read-write) $" BKP-DR21 @ hex. BKP-DR21 1b. ;
: BKP-DR22. ." BKP-DR22 (read-write) $" BKP-DR22 @ hex. BKP-DR22 1b. ;
: BKP-DR23. ." BKP-DR23 (read-write) $" BKP-DR23 @ hex. BKP-DR23 1b. ;
: BKP-DR24. ." BKP-DR24 (read-write) $" BKP-DR24 @ hex. BKP-DR24 1b. ;
: BKP-DR25. ." BKP-DR25 (read-write) $" BKP-DR25 @ hex. BKP-DR25 1b. ;
: BKP-DR26. ." BKP-DR26 (read-write) $" BKP-DR26 @ hex. BKP-DR26 1b. ;
: BKP-DR27. ." BKP-DR27 (read-write) $" BKP-DR27 @ hex. BKP-DR27 1b. ;
: BKP-DR28. ." BKP-DR28 (read-write) $" BKP-DR28 @ hex. BKP-DR28 1b. ;
: BKP-DR29. ." BKP-DR29 (read-write) $" BKP-DR29 @ hex. BKP-DR29 1b. ;
: BKP-DR30. ." BKP-DR30 (read-write) $" BKP-DR30 @ hex. BKP-DR30 1b. ;
: BKP-DR31. ." BKP-DR31 (read-write) $" BKP-DR31 @ hex. BKP-DR31 1b. ;
: BKP-DR32. ." BKP-DR32 (read-write) $" BKP-DR32 @ hex. BKP-DR32 1b. ;
: BKP-DR33. ." BKP-DR33 (read-write) $" BKP-DR33 @ hex. BKP-DR33 1b. ;
: BKP-DR34. ." BKP-DR34 (read-write) $" BKP-DR34 @ hex. BKP-DR34 1b. ;
: BKP-DR35. ." BKP-DR35 (read-write) $" BKP-DR35 @ hex. BKP-DR35 1b. ;
: BKP-DR36. ." BKP-DR36 (read-write) $" BKP-DR36 @ hex. BKP-DR36 1b. ;
: BKP-DR37. ." BKP-DR37 (read-write) $" BKP-DR37 @ hex. BKP-DR37 1b. ;
: BKP-DR38. ." BKP-DR38 (read-write) $" BKP-DR38 @ hex. BKP-DR38 1b. ;
: BKP-DR39. ." BKP-DR39 (read-write) $" BKP-DR39 @ hex. BKP-DR39 1b. ;
: BKP-DR40. ." BKP-DR40 (read-write) $" BKP-DR40 @ hex. BKP-DR40 1b. ;
: BKP-DR41. ." BKP-DR41 (read-write) $" BKP-DR41 @ hex. BKP-DR41 1b. ;
: BKP-DR42. ." BKP-DR42 (read-write) $" BKP-DR42 @ hex. BKP-DR42 1b. ;
: BKP-RTCCR. ." BKP-RTCCR (read-write) $" BKP-RTCCR @ hex. BKP-RTCCR 1b. ;
: BKP-CR. ." BKP-CR (read-write) $" BKP-CR @ hex. BKP-CR 1b. ;
: BKP-CSR. ." BKP-CSR () $" BKP-CSR @ hex. BKP-CSR 1b. ;
: BKP.
BKP-DR1.
BKP-DR2.
BKP-DR3.
BKP-DR4.
BKP-DR5.
BKP-DR6.
BKP-DR7.
BKP-DR8.
BKP-DR9.
BKP-DR10.
BKP-DR11.
BKP-DR12.
BKP-DR13.
BKP-DR14.
BKP-DR15.
BKP-DR16.
BKP-DR17.
BKP-DR18.
BKP-DR19.
BKP-DR20.
BKP-DR21.
BKP-DR22.
BKP-DR23.
BKP-DR24.
BKP-DR25.
BKP-DR26.
BKP-DR27.
BKP-DR28.
BKP-DR29.
BKP-DR30.
BKP-DR31.
BKP-DR32.
BKP-DR33.
BKP-DR34.
BKP-DR35.
BKP-DR36.
BKP-DR37.
BKP-DR38.
BKP-DR39.
BKP-DR40.
BKP-DR41.
BKP-DR42.
BKP-RTCCR.
BKP-CR.
BKP-CSR.
;

$40003000 constant IWDG ( Independent watchdog ) 
IWDG $0 + constant IWDG-KR ( Key register IWDG_KR ) 
IWDG $4 + constant IWDG-PR ( Prescaler register IWDG_PR ) 
IWDG $8 + constant IWDG-RLR ( Reload register IWDG_RLR ) 
IWDG $C + constant IWDG-SR ( Status register IWDG_SR ) 
: IWDG-KR. ." IWDG-KR (write-only) $" IWDG-KR @ hex. IWDG-KR 1b. ;
: IWDG-PR. ." IWDG-PR (read-write) $" IWDG-PR @ hex. IWDG-PR 1b. ;
: IWDG-RLR. ." IWDG-RLR (read-write) $" IWDG-RLR @ hex. IWDG-RLR 1b. ;
: IWDG-SR. ." IWDG-SR (read-only) $" IWDG-SR @ hex. IWDG-SR 1b. ;
: IWDG.
IWDG-KR.
IWDG-PR.
IWDG-RLR.
IWDG-SR.
;

$40002C00 constant WWDG ( Window watchdog ) 
WWDG $0 + constant WWDG-CR ( Control register WWDG_CR ) 
WWDG $4 + constant WWDG-CFR ( Configuration register  WWDG_CFR ) 
WWDG $8 + constant WWDG-SR ( Status register WWDG_SR ) 
: WWDG-CR. ." WWDG-CR (read-write) $" WWDG-CR @ hex. WWDG-CR 1b. ;
: WWDG-CFR. ." WWDG-CFR (read-write) $" WWDG-CFR @ hex. WWDG-CFR 1b. ;
: WWDG-SR. ." WWDG-SR (read-write) $" WWDG-SR @ hex. WWDG-SR 1b. ;
: WWDG.
WWDG-CR.
WWDG-CFR.
WWDG-SR.
;

$40012C00 constant TIM1 ( Advanced timer ) 
TIM1 $0 + constant TIM1-CR1 ( control register 1 ) 
TIM1 $4 + constant TIM1-CR2 ( control register 2 ) 
TIM1 $8 + constant TIM1-SMCR ( slave mode control register ) 
TIM1 $C + constant TIM1-DIER ( DMA/Interrupt enable register ) 
TIM1 $10 + constant TIM1-SR ( status register ) 
TIM1 $14 + constant TIM1-EGR ( event generation register ) 
TIM1 $18 + constant TIM1-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM1 $18 + constant TIM1-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM1 $1C + constant TIM1-CCMR2_Output ( capture/compare mode register output  mode ) 
TIM1 $1C + constant TIM1-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM1 $20 + constant TIM1-CCER ( capture/compare enable  register ) 
TIM1 $24 + constant TIM1-CNT ( counter ) 
TIM1 $28 + constant TIM1-PSC ( prescaler ) 
TIM1 $2C + constant TIM1-ARR ( auto-reload register ) 
TIM1 $34 + constant TIM1-CCR1 ( capture/compare register 1 ) 
TIM1 $38 + constant TIM1-CCR2 ( capture/compare register 2 ) 
TIM1 $3C + constant TIM1-CCR3 ( capture/compare register 3 ) 
TIM1 $40 + constant TIM1-CCR4 ( capture/compare register 4 ) 
TIM1 $48 + constant TIM1-DCR ( DMA control register ) 
TIM1 $4C + constant TIM1-DMAR ( DMA address for full transfer ) 
TIM1 $30 + constant TIM1-RCR ( repetition counter register ) 
TIM1 $44 + constant TIM1-BDTR ( break and dead-time register ) 
: TIM1-CR1. ." TIM1-CR1 (read-write) $" TIM1-CR1 @ hex. TIM1-CR1 1b. ;
: TIM1-CR2. ." TIM1-CR2 (read-write) $" TIM1-CR2 @ hex. TIM1-CR2 1b. ;
: TIM1-SMCR. ." TIM1-SMCR (read-write) $" TIM1-SMCR @ hex. TIM1-SMCR 1b. ;
: TIM1-DIER. ." TIM1-DIER (read-write) $" TIM1-DIER @ hex. TIM1-DIER 1b. ;
: TIM1-SR. ." TIM1-SR (read-write) $" TIM1-SR @ hex. TIM1-SR 1b. ;
: TIM1-EGR. ." TIM1-EGR (write-only) $" TIM1-EGR @ hex. TIM1-EGR 1b. ;
: TIM1-CCMR1_Output. ." TIM1-CCMR1_Output (read-write) $" TIM1-CCMR1_Output @ hex. TIM1-CCMR1_Output 1b. ;
: TIM1-CCMR1_Input. ." TIM1-CCMR1_Input (read-write) $" TIM1-CCMR1_Input @ hex. TIM1-CCMR1_Input 1b. ;
: TIM1-CCMR2_Output. ." TIM1-CCMR2_Output (read-write) $" TIM1-CCMR2_Output @ hex. TIM1-CCMR2_Output 1b. ;
: TIM1-CCMR2_Input. ." TIM1-CCMR2_Input (read-write) $" TIM1-CCMR2_Input @ hex. TIM1-CCMR2_Input 1b. ;
: TIM1-CCER. ." TIM1-CCER (read-write) $" TIM1-CCER @ hex. TIM1-CCER 1b. ;
: TIM1-CNT. ." TIM1-CNT (read-write) $" TIM1-CNT @ hex. TIM1-CNT 1b. ;
: TIM1-PSC. ." TIM1-PSC (read-write) $" TIM1-PSC @ hex. TIM1-PSC 1b. ;
: TIM1-ARR. ." TIM1-ARR (read-write) $" TIM1-ARR @ hex. TIM1-ARR 1b. ;
: TIM1-CCR1. ." TIM1-CCR1 (read-write) $" TIM1-CCR1 @ hex. TIM1-CCR1 1b. ;
: TIM1-CCR2. ." TIM1-CCR2 (read-write) $" TIM1-CCR2 @ hex. TIM1-CCR2 1b. ;
: TIM1-CCR3. ." TIM1-CCR3 (read-write) $" TIM1-CCR3 @ hex. TIM1-CCR3 1b. ;
: TIM1-CCR4. ." TIM1-CCR4 (read-write) $" TIM1-CCR4 @ hex. TIM1-CCR4 1b. ;
: TIM1-DCR. ." TIM1-DCR (read-write) $" TIM1-DCR @ hex. TIM1-DCR 1b. ;
: TIM1-DMAR. ." TIM1-DMAR (read-write) $" TIM1-DMAR @ hex. TIM1-DMAR 1b. ;
: TIM1-RCR. ." TIM1-RCR (read-write) $" TIM1-RCR @ hex. TIM1-RCR 1b. ;
: TIM1-BDTR. ." TIM1-BDTR (read-write) $" TIM1-BDTR @ hex. TIM1-BDTR 1b. ;
: TIM1.
TIM1-CR1.
TIM1-CR2.
TIM1-SMCR.
TIM1-DIER.
TIM1-SR.
TIM1-EGR.
TIM1-CCMR1_Output.
TIM1-CCMR1_Input.
TIM1-CCMR2_Output.
TIM1-CCMR2_Input.
TIM1-CCER.
TIM1-CNT.
TIM1-PSC.
TIM1-ARR.
TIM1-CCR1.
TIM1-CCR2.
TIM1-CCR3.
TIM1-CCR4.
TIM1-DCR.
TIM1-DMAR.
TIM1-RCR.
TIM1-BDTR.
;

$40013400 constant TIM8 ( Advanced timer ) 
TIM8 $0 + constant TIM8-CR1 ( control register 1 ) 
TIM8 $4 + constant TIM8-CR2 ( control register 2 ) 
TIM8 $8 + constant TIM8-SMCR ( slave mode control register ) 
TIM8 $C + constant TIM8-DIER ( DMA/Interrupt enable register ) 
TIM8 $10 + constant TIM8-SR ( status register ) 
TIM8 $14 + constant TIM8-EGR ( event generation register ) 
TIM8 $18 + constant TIM8-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM8 $18 + constant TIM8-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM8 $1C + constant TIM8-CCMR2_Output ( capture/compare mode register output  mode ) 
TIM8 $1C + constant TIM8-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM8 $20 + constant TIM8-CCER ( capture/compare enable  register ) 
TIM8 $24 + constant TIM8-CNT ( counter ) 
TIM8 $28 + constant TIM8-PSC ( prescaler ) 
TIM8 $2C + constant TIM8-ARR ( auto-reload register ) 
TIM8 $34 + constant TIM8-CCR1 ( capture/compare register 1 ) 
TIM8 $38 + constant TIM8-CCR2 ( capture/compare register 2 ) 
TIM8 $3C + constant TIM8-CCR3 ( capture/compare register 3 ) 
TIM8 $40 + constant TIM8-CCR4 ( capture/compare register 4 ) 
TIM8 $48 + constant TIM8-DCR ( DMA control register ) 
TIM8 $4C + constant TIM8-DMAR ( DMA address for full transfer ) 
TIM8 $30 + constant TIM8-RCR ( repetition counter register ) 
TIM8 $44 + constant TIM8-BDTR ( break and dead-time register ) 
: TIM8-CR1. ." TIM8-CR1 (read-write) $" TIM8-CR1 @ hex. TIM8-CR1 1b. ;
: TIM8-CR2. ." TIM8-CR2 (read-write) $" TIM8-CR2 @ hex. TIM8-CR2 1b. ;
: TIM8-SMCR. ." TIM8-SMCR (read-write) $" TIM8-SMCR @ hex. TIM8-SMCR 1b. ;
: TIM8-DIER. ." TIM8-DIER (read-write) $" TIM8-DIER @ hex. TIM8-DIER 1b. ;
: TIM8-SR. ." TIM8-SR (read-write) $" TIM8-SR @ hex. TIM8-SR 1b. ;
: TIM8-EGR. ." TIM8-EGR (write-only) $" TIM8-EGR @ hex. TIM8-EGR 1b. ;
: TIM8-CCMR1_Output. ." TIM8-CCMR1_Output (read-write) $" TIM8-CCMR1_Output @ hex. TIM8-CCMR1_Output 1b. ;
: TIM8-CCMR1_Input. ." TIM8-CCMR1_Input (read-write) $" TIM8-CCMR1_Input @ hex. TIM8-CCMR1_Input 1b. ;
: TIM8-CCMR2_Output. ." TIM8-CCMR2_Output (read-write) $" TIM8-CCMR2_Output @ hex. TIM8-CCMR2_Output 1b. ;
: TIM8-CCMR2_Input. ." TIM8-CCMR2_Input (read-write) $" TIM8-CCMR2_Input @ hex. TIM8-CCMR2_Input 1b. ;
: TIM8-CCER. ." TIM8-CCER (read-write) $" TIM8-CCER @ hex. TIM8-CCER 1b. ;
: TIM8-CNT. ." TIM8-CNT (read-write) $" TIM8-CNT @ hex. TIM8-CNT 1b. ;
: TIM8-PSC. ." TIM8-PSC (read-write) $" TIM8-PSC @ hex. TIM8-PSC 1b. ;
: TIM8-ARR. ." TIM8-ARR (read-write) $" TIM8-ARR @ hex. TIM8-ARR 1b. ;
: TIM8-CCR1. ." TIM8-CCR1 (read-write) $" TIM8-CCR1 @ hex. TIM8-CCR1 1b. ;
: TIM8-CCR2. ." TIM8-CCR2 (read-write) $" TIM8-CCR2 @ hex. TIM8-CCR2 1b. ;
: TIM8-CCR3. ." TIM8-CCR3 (read-write) $" TIM8-CCR3 @ hex. TIM8-CCR3 1b. ;
: TIM8-CCR4. ." TIM8-CCR4 (read-write) $" TIM8-CCR4 @ hex. TIM8-CCR4 1b. ;
: TIM8-DCR. ." TIM8-DCR (read-write) $" TIM8-DCR @ hex. TIM8-DCR 1b. ;
: TIM8-DMAR. ." TIM8-DMAR (read-write) $" TIM8-DMAR @ hex. TIM8-DMAR 1b. ;
: TIM8-RCR. ." TIM8-RCR (read-write) $" TIM8-RCR @ hex. TIM8-RCR 1b. ;
: TIM8-BDTR. ." TIM8-BDTR (read-write) $" TIM8-BDTR @ hex. TIM8-BDTR 1b. ;
: TIM8.
TIM8-CR1.
TIM8-CR2.
TIM8-SMCR.
TIM8-DIER.
TIM8-SR.
TIM8-EGR.
TIM8-CCMR1_Output.
TIM8-CCMR1_Input.
TIM8-CCMR2_Output.
TIM8-CCMR2_Input.
TIM8-CCER.
TIM8-CNT.
TIM8-PSC.
TIM8-ARR.
TIM8-CCR1.
TIM8-CCR2.
TIM8-CCR3.
TIM8-CCR4.
TIM8-DCR.
TIM8-DMAR.
TIM8-RCR.
TIM8-BDTR.
;

$40000000 constant TIM2 ( General purpose timer ) 
TIM2 $0 + constant TIM2-CR1 ( control register 1 ) 
TIM2 $4 + constant TIM2-CR2 ( control register 2 ) 
TIM2 $8 + constant TIM2-SMCR ( slave mode control register ) 
TIM2 $C + constant TIM2-DIER ( DMA/Interrupt enable register ) 
TIM2 $10 + constant TIM2-SR ( status register ) 
TIM2 $14 + constant TIM2-EGR ( event generation register ) 
TIM2 $18 + constant TIM2-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM2 $18 + constant TIM2-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM2 $1C + constant TIM2-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM2 $1C + constant TIM2-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM2 $20 + constant TIM2-CCER ( capture/compare enable  register ) 
TIM2 $24 + constant TIM2-CNT ( counter ) 
TIM2 $28 + constant TIM2-PSC ( prescaler ) 
TIM2 $2C + constant TIM2-ARR ( auto-reload register ) 
TIM2 $34 + constant TIM2-CCR1 ( capture/compare register 1 ) 
TIM2 $38 + constant TIM2-CCR2 ( capture/compare register 2 ) 
TIM2 $3C + constant TIM2-CCR3 ( capture/compare register 3 ) 
TIM2 $40 + constant TIM2-CCR4 ( capture/compare register 4 ) 
TIM2 $48 + constant TIM2-DCR ( DMA control register ) 
TIM2 $4C + constant TIM2-DMAR ( DMA address for full transfer ) 
: TIM2-CR1. ." TIM2-CR1 (read-write) $" TIM2-CR1 @ hex. TIM2-CR1 1b. ;
: TIM2-CR2. ." TIM2-CR2 (read-write) $" TIM2-CR2 @ hex. TIM2-CR2 1b. ;
: TIM2-SMCR. ." TIM2-SMCR (read-write) $" TIM2-SMCR @ hex. TIM2-SMCR 1b. ;
: TIM2-DIER. ." TIM2-DIER (read-write) $" TIM2-DIER @ hex. TIM2-DIER 1b. ;
: TIM2-SR. ." TIM2-SR (read-write) $" TIM2-SR @ hex. TIM2-SR 1b. ;
: TIM2-EGR. ." TIM2-EGR (write-only) $" TIM2-EGR @ hex. TIM2-EGR 1b. ;
: TIM2-CCMR1_Output. ." TIM2-CCMR1_Output (read-write) $" TIM2-CCMR1_Output @ hex. TIM2-CCMR1_Output 1b. ;
: TIM2-CCMR1_Input. ." TIM2-CCMR1_Input (read-write) $" TIM2-CCMR1_Input @ hex. TIM2-CCMR1_Input 1b. ;
: TIM2-CCMR2_Output. ." TIM2-CCMR2_Output (read-write) $" TIM2-CCMR2_Output @ hex. TIM2-CCMR2_Output 1b. ;
: TIM2-CCMR2_Input. ." TIM2-CCMR2_Input (read-write) $" TIM2-CCMR2_Input @ hex. TIM2-CCMR2_Input 1b. ;
: TIM2-CCER. ." TIM2-CCER (read-write) $" TIM2-CCER @ hex. TIM2-CCER 1b. ;
: TIM2-CNT. ." TIM2-CNT (read-write) $" TIM2-CNT @ hex. TIM2-CNT 1b. ;
: TIM2-PSC. ." TIM2-PSC (read-write) $" TIM2-PSC @ hex. TIM2-PSC 1b. ;
: TIM2-ARR. ." TIM2-ARR (read-write) $" TIM2-ARR @ hex. TIM2-ARR 1b. ;
: TIM2-CCR1. ." TIM2-CCR1 (read-write) $" TIM2-CCR1 @ hex. TIM2-CCR1 1b. ;
: TIM2-CCR2. ." TIM2-CCR2 (read-write) $" TIM2-CCR2 @ hex. TIM2-CCR2 1b. ;
: TIM2-CCR3. ." TIM2-CCR3 (read-write) $" TIM2-CCR3 @ hex. TIM2-CCR3 1b. ;
: TIM2-CCR4. ." TIM2-CCR4 (read-write) $" TIM2-CCR4 @ hex. TIM2-CCR4 1b. ;
: TIM2-DCR. ." TIM2-DCR (read-write) $" TIM2-DCR @ hex. TIM2-DCR 1b. ;
: TIM2-DMAR. ." TIM2-DMAR (read-write) $" TIM2-DMAR @ hex. TIM2-DMAR 1b. ;
: TIM2.
TIM2-CR1.
TIM2-CR2.
TIM2-SMCR.
TIM2-DIER.
TIM2-SR.
TIM2-EGR.
TIM2-CCMR1_Output.
TIM2-CCMR1_Input.
TIM2-CCMR2_Output.
TIM2-CCMR2_Input.
TIM2-CCER.
TIM2-CNT.
TIM2-PSC.
TIM2-ARR.
TIM2-CCR1.
TIM2-CCR2.
TIM2-CCR3.
TIM2-CCR4.
TIM2-DCR.
TIM2-DMAR.
;

$40000400 constant TIM3 ( General purpose timer ) 
TIM3 $0 + constant TIM3-CR1 ( control register 1 ) 
TIM3 $4 + constant TIM3-CR2 ( control register 2 ) 
TIM3 $8 + constant TIM3-SMCR ( slave mode control register ) 
TIM3 $C + constant TIM3-DIER ( DMA/Interrupt enable register ) 
TIM3 $10 + constant TIM3-SR ( status register ) 
TIM3 $14 + constant TIM3-EGR ( event generation register ) 
TIM3 $18 + constant TIM3-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM3 $18 + constant TIM3-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM3 $1C + constant TIM3-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM3 $1C + constant TIM3-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM3 $20 + constant TIM3-CCER ( capture/compare enable  register ) 
TIM3 $24 + constant TIM3-CNT ( counter ) 
TIM3 $28 + constant TIM3-PSC ( prescaler ) 
TIM3 $2C + constant TIM3-ARR ( auto-reload register ) 
TIM3 $34 + constant TIM3-CCR1 ( capture/compare register 1 ) 
TIM3 $38 + constant TIM3-CCR2 ( capture/compare register 2 ) 
TIM3 $3C + constant TIM3-CCR3 ( capture/compare register 3 ) 
TIM3 $40 + constant TIM3-CCR4 ( capture/compare register 4 ) 
TIM3 $48 + constant TIM3-DCR ( DMA control register ) 
TIM3 $4C + constant TIM3-DMAR ( DMA address for full transfer ) 
: TIM3-CR1. ." TIM3-CR1 (read-write) $" TIM3-CR1 @ hex. TIM3-CR1 1b. ;
: TIM3-CR2. ." TIM3-CR2 (read-write) $" TIM3-CR2 @ hex. TIM3-CR2 1b. ;
: TIM3-SMCR. ." TIM3-SMCR (read-write) $" TIM3-SMCR @ hex. TIM3-SMCR 1b. ;
: TIM3-DIER. ." TIM3-DIER (read-write) $" TIM3-DIER @ hex. TIM3-DIER 1b. ;
: TIM3-SR. ." TIM3-SR (read-write) $" TIM3-SR @ hex. TIM3-SR 1b. ;
: TIM3-EGR. ." TIM3-EGR (write-only) $" TIM3-EGR @ hex. TIM3-EGR 1b. ;
: TIM3-CCMR1_Output. ." TIM3-CCMR1_Output (read-write) $" TIM3-CCMR1_Output @ hex. TIM3-CCMR1_Output 1b. ;
: TIM3-CCMR1_Input. ." TIM3-CCMR1_Input (read-write) $" TIM3-CCMR1_Input @ hex. TIM3-CCMR1_Input 1b. ;
: TIM3-CCMR2_Output. ." TIM3-CCMR2_Output (read-write) $" TIM3-CCMR2_Output @ hex. TIM3-CCMR2_Output 1b. ;
: TIM3-CCMR2_Input. ." TIM3-CCMR2_Input (read-write) $" TIM3-CCMR2_Input @ hex. TIM3-CCMR2_Input 1b. ;
: TIM3-CCER. ." TIM3-CCER (read-write) $" TIM3-CCER @ hex. TIM3-CCER 1b. ;
: TIM3-CNT. ." TIM3-CNT (read-write) $" TIM3-CNT @ hex. TIM3-CNT 1b. ;
: TIM3-PSC. ." TIM3-PSC (read-write) $" TIM3-PSC @ hex. TIM3-PSC 1b. ;
: TIM3-ARR. ." TIM3-ARR (read-write) $" TIM3-ARR @ hex. TIM3-ARR 1b. ;
: TIM3-CCR1. ." TIM3-CCR1 (read-write) $" TIM3-CCR1 @ hex. TIM3-CCR1 1b. ;
: TIM3-CCR2. ." TIM3-CCR2 (read-write) $" TIM3-CCR2 @ hex. TIM3-CCR2 1b. ;
: TIM3-CCR3. ." TIM3-CCR3 (read-write) $" TIM3-CCR3 @ hex. TIM3-CCR3 1b. ;
: TIM3-CCR4. ." TIM3-CCR4 (read-write) $" TIM3-CCR4 @ hex. TIM3-CCR4 1b. ;
: TIM3-DCR. ." TIM3-DCR (read-write) $" TIM3-DCR @ hex. TIM3-DCR 1b. ;
: TIM3-DMAR. ." TIM3-DMAR (read-write) $" TIM3-DMAR @ hex. TIM3-DMAR 1b. ;
: TIM3.
TIM3-CR1.
TIM3-CR2.
TIM3-SMCR.
TIM3-DIER.
TIM3-SR.
TIM3-EGR.
TIM3-CCMR1_Output.
TIM3-CCMR1_Input.
TIM3-CCMR2_Output.
TIM3-CCMR2_Input.
TIM3-CCER.
TIM3-CNT.
TIM3-PSC.
TIM3-ARR.
TIM3-CCR1.
TIM3-CCR2.
TIM3-CCR3.
TIM3-CCR4.
TIM3-DCR.
TIM3-DMAR.
;

$40000800 constant TIM4 ( General purpose timer ) 
TIM4 $0 + constant TIM4-CR1 ( control register 1 ) 
TIM4 $4 + constant TIM4-CR2 ( control register 2 ) 
TIM4 $8 + constant TIM4-SMCR ( slave mode control register ) 
TIM4 $C + constant TIM4-DIER ( DMA/Interrupt enable register ) 
TIM4 $10 + constant TIM4-SR ( status register ) 
TIM4 $14 + constant TIM4-EGR ( event generation register ) 
TIM4 $18 + constant TIM4-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM4 $18 + constant TIM4-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM4 $1C + constant TIM4-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM4 $1C + constant TIM4-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM4 $20 + constant TIM4-CCER ( capture/compare enable  register ) 
TIM4 $24 + constant TIM4-CNT ( counter ) 
TIM4 $28 + constant TIM4-PSC ( prescaler ) 
TIM4 $2C + constant TIM4-ARR ( auto-reload register ) 
TIM4 $34 + constant TIM4-CCR1 ( capture/compare register 1 ) 
TIM4 $38 + constant TIM4-CCR2 ( capture/compare register 2 ) 
TIM4 $3C + constant TIM4-CCR3 ( capture/compare register 3 ) 
TIM4 $40 + constant TIM4-CCR4 ( capture/compare register 4 ) 
TIM4 $48 + constant TIM4-DCR ( DMA control register ) 
TIM4 $4C + constant TIM4-DMAR ( DMA address for full transfer ) 
: TIM4-CR1. ." TIM4-CR1 (read-write) $" TIM4-CR1 @ hex. TIM4-CR1 1b. ;
: TIM4-CR2. ." TIM4-CR2 (read-write) $" TIM4-CR2 @ hex. TIM4-CR2 1b. ;
: TIM4-SMCR. ." TIM4-SMCR (read-write) $" TIM4-SMCR @ hex. TIM4-SMCR 1b. ;
: TIM4-DIER. ." TIM4-DIER (read-write) $" TIM4-DIER @ hex. TIM4-DIER 1b. ;
: TIM4-SR. ." TIM4-SR (read-write) $" TIM4-SR @ hex. TIM4-SR 1b. ;
: TIM4-EGR. ." TIM4-EGR (write-only) $" TIM4-EGR @ hex. TIM4-EGR 1b. ;
: TIM4-CCMR1_Output. ." TIM4-CCMR1_Output (read-write) $" TIM4-CCMR1_Output @ hex. TIM4-CCMR1_Output 1b. ;
: TIM4-CCMR1_Input. ." TIM4-CCMR1_Input (read-write) $" TIM4-CCMR1_Input @ hex. TIM4-CCMR1_Input 1b. ;
: TIM4-CCMR2_Output. ." TIM4-CCMR2_Output (read-write) $" TIM4-CCMR2_Output @ hex. TIM4-CCMR2_Output 1b. ;
: TIM4-CCMR2_Input. ." TIM4-CCMR2_Input (read-write) $" TIM4-CCMR2_Input @ hex. TIM4-CCMR2_Input 1b. ;
: TIM4-CCER. ." TIM4-CCER (read-write) $" TIM4-CCER @ hex. TIM4-CCER 1b. ;
: TIM4-CNT. ." TIM4-CNT (read-write) $" TIM4-CNT @ hex. TIM4-CNT 1b. ;
: TIM4-PSC. ." TIM4-PSC (read-write) $" TIM4-PSC @ hex. TIM4-PSC 1b. ;
: TIM4-ARR. ." TIM4-ARR (read-write) $" TIM4-ARR @ hex. TIM4-ARR 1b. ;
: TIM4-CCR1. ." TIM4-CCR1 (read-write) $" TIM4-CCR1 @ hex. TIM4-CCR1 1b. ;
: TIM4-CCR2. ." TIM4-CCR2 (read-write) $" TIM4-CCR2 @ hex. TIM4-CCR2 1b. ;
: TIM4-CCR3. ." TIM4-CCR3 (read-write) $" TIM4-CCR3 @ hex. TIM4-CCR3 1b. ;
: TIM4-CCR4. ." TIM4-CCR4 (read-write) $" TIM4-CCR4 @ hex. TIM4-CCR4 1b. ;
: TIM4-DCR. ." TIM4-DCR (read-write) $" TIM4-DCR @ hex. TIM4-DCR 1b. ;
: TIM4-DMAR. ." TIM4-DMAR (read-write) $" TIM4-DMAR @ hex. TIM4-DMAR 1b. ;
: TIM4.
TIM4-CR1.
TIM4-CR2.
TIM4-SMCR.
TIM4-DIER.
TIM4-SR.
TIM4-EGR.
TIM4-CCMR1_Output.
TIM4-CCMR1_Input.
TIM4-CCMR2_Output.
TIM4-CCMR2_Input.
TIM4-CCER.
TIM4-CNT.
TIM4-PSC.
TIM4-ARR.
TIM4-CCR1.
TIM4-CCR2.
TIM4-CCR3.
TIM4-CCR4.
TIM4-DCR.
TIM4-DMAR.
;

$40000C00 constant TIM5 ( General purpose timer ) 
TIM5 $0 + constant TIM5-CR1 ( control register 1 ) 
TIM5 $4 + constant TIM5-CR2 ( control register 2 ) 
TIM5 $8 + constant TIM5-SMCR ( slave mode control register ) 
TIM5 $C + constant TIM5-DIER ( DMA/Interrupt enable register ) 
TIM5 $10 + constant TIM5-SR ( status register ) 
TIM5 $14 + constant TIM5-EGR ( event generation register ) 
TIM5 $18 + constant TIM5-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM5 $18 + constant TIM5-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM5 $1C + constant TIM5-CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM5 $1C + constant TIM5-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM5 $20 + constant TIM5-CCER ( capture/compare enable  register ) 
TIM5 $24 + constant TIM5-CNT ( counter ) 
TIM5 $28 + constant TIM5-PSC ( prescaler ) 
TIM5 $2C + constant TIM5-ARR ( auto-reload register ) 
TIM5 $34 + constant TIM5-CCR1 ( capture/compare register 1 ) 
TIM5 $38 + constant TIM5-CCR2 ( capture/compare register 2 ) 
TIM5 $3C + constant TIM5-CCR3 ( capture/compare register 3 ) 
TIM5 $40 + constant TIM5-CCR4 ( capture/compare register 4 ) 
TIM5 $48 + constant TIM5-DCR ( DMA control register ) 
TIM5 $4C + constant TIM5-DMAR ( DMA address for full transfer ) 
: TIM5-CR1. ." TIM5-CR1 (read-write) $" TIM5-CR1 @ hex. TIM5-CR1 1b. ;
: TIM5-CR2. ." TIM5-CR2 (read-write) $" TIM5-CR2 @ hex. TIM5-CR2 1b. ;
: TIM5-SMCR. ." TIM5-SMCR (read-write) $" TIM5-SMCR @ hex. TIM5-SMCR 1b. ;
: TIM5-DIER. ." TIM5-DIER (read-write) $" TIM5-DIER @ hex. TIM5-DIER 1b. ;
: TIM5-SR. ." TIM5-SR (read-write) $" TIM5-SR @ hex. TIM5-SR 1b. ;
: TIM5-EGR. ." TIM5-EGR (write-only) $" TIM5-EGR @ hex. TIM5-EGR 1b. ;
: TIM5-CCMR1_Output. ." TIM5-CCMR1_Output (read-write) $" TIM5-CCMR1_Output @ hex. TIM5-CCMR1_Output 1b. ;
: TIM5-CCMR1_Input. ." TIM5-CCMR1_Input (read-write) $" TIM5-CCMR1_Input @ hex. TIM5-CCMR1_Input 1b. ;
: TIM5-CCMR2_Output. ." TIM5-CCMR2_Output (read-write) $" TIM5-CCMR2_Output @ hex. TIM5-CCMR2_Output 1b. ;
: TIM5-CCMR2_Input. ." TIM5-CCMR2_Input (read-write) $" TIM5-CCMR2_Input @ hex. TIM5-CCMR2_Input 1b. ;
: TIM5-CCER. ." TIM5-CCER (read-write) $" TIM5-CCER @ hex. TIM5-CCER 1b. ;
: TIM5-CNT. ." TIM5-CNT (read-write) $" TIM5-CNT @ hex. TIM5-CNT 1b. ;
: TIM5-PSC. ." TIM5-PSC (read-write) $" TIM5-PSC @ hex. TIM5-PSC 1b. ;
: TIM5-ARR. ." TIM5-ARR (read-write) $" TIM5-ARR @ hex. TIM5-ARR 1b. ;
: TIM5-CCR1. ." TIM5-CCR1 (read-write) $" TIM5-CCR1 @ hex. TIM5-CCR1 1b. ;
: TIM5-CCR2. ." TIM5-CCR2 (read-write) $" TIM5-CCR2 @ hex. TIM5-CCR2 1b. ;
: TIM5-CCR3. ." TIM5-CCR3 (read-write) $" TIM5-CCR3 @ hex. TIM5-CCR3 1b. ;
: TIM5-CCR4. ." TIM5-CCR4 (read-write) $" TIM5-CCR4 @ hex. TIM5-CCR4 1b. ;
: TIM5-DCR. ." TIM5-DCR (read-write) $" TIM5-DCR @ hex. TIM5-DCR 1b. ;
: TIM5-DMAR. ." TIM5-DMAR (read-write) $" TIM5-DMAR @ hex. TIM5-DMAR 1b. ;
: TIM5.
TIM5-CR1.
TIM5-CR2.
TIM5-SMCR.
TIM5-DIER.
TIM5-SR.
TIM5-EGR.
TIM5-CCMR1_Output.
TIM5-CCMR1_Input.
TIM5-CCMR2_Output.
TIM5-CCMR2_Input.
TIM5-CCER.
TIM5-CNT.
TIM5-PSC.
TIM5-ARR.
TIM5-CCR1.
TIM5-CCR2.
TIM5-CCR3.
TIM5-CCR4.
TIM5-DCR.
TIM5-DMAR.
;

$40014C00 constant TIM9 ( General purpose timer ) 
TIM9 $0 + constant TIM9-CR1 ( control register 1 ) 
TIM9 $4 + constant TIM9-CR2 ( control register 2 ) 
TIM9 $8 + constant TIM9-SMCR ( slave mode control register ) 
TIM9 $C + constant TIM9-DIER ( DMA/Interrupt enable register ) 
TIM9 $10 + constant TIM9-SR ( status register ) 
TIM9 $14 + constant TIM9-EGR ( event generation register ) 
TIM9 $18 + constant TIM9-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM9 $18 + constant TIM9-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM9 $20 + constant TIM9-CCER ( capture/compare enable  register ) 
TIM9 $24 + constant TIM9-CNT ( counter ) 
TIM9 $28 + constant TIM9-PSC ( prescaler ) 
TIM9 $2C + constant TIM9-ARR ( auto-reload register ) 
TIM9 $34 + constant TIM9-CCR1 ( capture/compare register 1 ) 
TIM9 $38 + constant TIM9-CCR2 ( capture/compare register 2 ) 
: TIM9-CR1. ." TIM9-CR1 (read-write) $" TIM9-CR1 @ hex. TIM9-CR1 1b. ;
: TIM9-CR2. ." TIM9-CR2 (read-write) $" TIM9-CR2 @ hex. TIM9-CR2 1b. ;
: TIM9-SMCR. ." TIM9-SMCR (read-write) $" TIM9-SMCR @ hex. TIM9-SMCR 1b. ;
: TIM9-DIER. ." TIM9-DIER (read-write) $" TIM9-DIER @ hex. TIM9-DIER 1b. ;
: TIM9-SR. ." TIM9-SR (read-write) $" TIM9-SR @ hex. TIM9-SR 1b. ;
: TIM9-EGR. ." TIM9-EGR (write-only) $" TIM9-EGR @ hex. TIM9-EGR 1b. ;
: TIM9-CCMR1_Output. ." TIM9-CCMR1_Output (read-write) $" TIM9-CCMR1_Output @ hex. TIM9-CCMR1_Output 1b. ;
: TIM9-CCMR1_Input. ." TIM9-CCMR1_Input (read-write) $" TIM9-CCMR1_Input @ hex. TIM9-CCMR1_Input 1b. ;
: TIM9-CCER. ." TIM9-CCER (read-write) $" TIM9-CCER @ hex. TIM9-CCER 1b. ;
: TIM9-CNT. ." TIM9-CNT (read-write) $" TIM9-CNT @ hex. TIM9-CNT 1b. ;
: TIM9-PSC. ." TIM9-PSC (read-write) $" TIM9-PSC @ hex. TIM9-PSC 1b. ;
: TIM9-ARR. ." TIM9-ARR (read-write) $" TIM9-ARR @ hex. TIM9-ARR 1b. ;
: TIM9-CCR1. ." TIM9-CCR1 (read-write) $" TIM9-CCR1 @ hex. TIM9-CCR1 1b. ;
: TIM9-CCR2. ." TIM9-CCR2 (read-write) $" TIM9-CCR2 @ hex. TIM9-CCR2 1b. ;
: TIM9.
TIM9-CR1.
TIM9-CR2.
TIM9-SMCR.
TIM9-DIER.
TIM9-SR.
TIM9-EGR.
TIM9-CCMR1_Output.
TIM9-CCMR1_Input.
TIM9-CCER.
TIM9-CNT.
TIM9-PSC.
TIM9-ARR.
TIM9-CCR1.
TIM9-CCR2.
;

$40001800 constant TIM12 ( General purpose timer ) 
TIM12 $0 + constant TIM12-CR1 ( control register 1 ) 
TIM12 $4 + constant TIM12-CR2 ( control register 2 ) 
TIM12 $8 + constant TIM12-SMCR ( slave mode control register ) 
TIM12 $C + constant TIM12-DIER ( DMA/Interrupt enable register ) 
TIM12 $10 + constant TIM12-SR ( status register ) 
TIM12 $14 + constant TIM12-EGR ( event generation register ) 
TIM12 $18 + constant TIM12-CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM12 $18 + constant TIM12-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM12 $20 + constant TIM12-CCER ( capture/compare enable  register ) 
TIM12 $24 + constant TIM12-CNT ( counter ) 
TIM12 $28 + constant TIM12-PSC ( prescaler ) 
TIM12 $2C + constant TIM12-ARR ( auto-reload register ) 
TIM12 $34 + constant TIM12-CCR1 ( capture/compare register 1 ) 
TIM12 $38 + constant TIM12-CCR2 ( capture/compare register 2 ) 
: TIM12-CR1. ." TIM12-CR1 (read-write) $" TIM12-CR1 @ hex. TIM12-CR1 1b. ;
: TIM12-CR2. ." TIM12-CR2 (read-write) $" TIM12-CR2 @ hex. TIM12-CR2 1b. ;
: TIM12-SMCR. ." TIM12-SMCR (read-write) $" TIM12-SMCR @ hex. TIM12-SMCR 1b. ;
: TIM12-DIER. ." TIM12-DIER (read-write) $" TIM12-DIER @ hex. TIM12-DIER 1b. ;
: TIM12-SR. ." TIM12-SR (read-write) $" TIM12-SR @ hex. TIM12-SR 1b. ;
: TIM12-EGR. ." TIM12-EGR (write-only) $" TIM12-EGR @ hex. TIM12-EGR 1b. ;
: TIM12-CCMR1_Output. ." TIM12-CCMR1_Output (read-write) $" TIM12-CCMR1_Output @ hex. TIM12-CCMR1_Output 1b. ;
: TIM12-CCMR1_Input. ." TIM12-CCMR1_Input (read-write) $" TIM12-CCMR1_Input @ hex. TIM12-CCMR1_Input 1b. ;
: TIM12-CCER. ." TIM12-CCER (read-write) $" TIM12-CCER @ hex. TIM12-CCER 1b. ;
: TIM12-CNT. ." TIM12-CNT (read-write) $" TIM12-CNT @ hex. TIM12-CNT 1b. ;
: TIM12-PSC. ." TIM12-PSC (read-write) $" TIM12-PSC @ hex. TIM12-PSC 1b. ;
: TIM12-ARR. ." TIM12-ARR (read-write) $" TIM12-ARR @ hex. TIM12-ARR 1b. ;
: TIM12-CCR1. ." TIM12-CCR1 (read-write) $" TIM12-CCR1 @ hex. TIM12-CCR1 1b. ;
: TIM12-CCR2. ." TIM12-CCR2 (read-write) $" TIM12-CCR2 @ hex. TIM12-CCR2 1b. ;
: TIM12.
TIM12-CR1.
TIM12-CR2.
TIM12-SMCR.
TIM12-DIER.
TIM12-SR.
TIM12-EGR.
TIM12-CCMR1_Output.
TIM12-CCMR1_Input.
TIM12-CCER.
TIM12-CNT.
TIM12-PSC.
TIM12-ARR.
TIM12-CCR1.
TIM12-CCR2.
;

$40015000 constant TIM10 ( General purpose timer ) 
TIM10 $0 + constant TIM10-CR1 ( control register 1 ) 
TIM10 $4 + constant TIM10-CR2 ( control register 2 ) 
TIM10 $C + constant TIM10-DIER ( DMA/Interrupt enable register ) 
TIM10 $10 + constant TIM10-SR ( status register ) 
TIM10 $14 + constant TIM10-EGR ( event generation register ) 
TIM10 $18 + constant TIM10-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM10 $18 + constant TIM10-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM10 $20 + constant TIM10-CCER ( capture/compare enable  register ) 
TIM10 $24 + constant TIM10-CNT ( counter ) 
TIM10 $28 + constant TIM10-PSC ( prescaler ) 
TIM10 $2C + constant TIM10-ARR ( auto-reload register ) 
TIM10 $34 + constant TIM10-CCR1 ( capture/compare register 1 ) 
: TIM10-CR1. ." TIM10-CR1 (read-write) $" TIM10-CR1 @ hex. TIM10-CR1 1b. ;
: TIM10-CR2. ." TIM10-CR2 (read-write) $" TIM10-CR2 @ hex. TIM10-CR2 1b. ;
: TIM10-DIER. ." TIM10-DIER (read-write) $" TIM10-DIER @ hex. TIM10-DIER 1b. ;
: TIM10-SR. ." TIM10-SR (read-write) $" TIM10-SR @ hex. TIM10-SR 1b. ;
: TIM10-EGR. ." TIM10-EGR (write-only) $" TIM10-EGR @ hex. TIM10-EGR 1b. ;
: TIM10-CCMR1_Output. ." TIM10-CCMR1_Output (read-write) $" TIM10-CCMR1_Output @ hex. TIM10-CCMR1_Output 1b. ;
: TIM10-CCMR1_Input. ." TIM10-CCMR1_Input (read-write) $" TIM10-CCMR1_Input @ hex. TIM10-CCMR1_Input 1b. ;
: TIM10-CCER. ." TIM10-CCER (read-write) $" TIM10-CCER @ hex. TIM10-CCER 1b. ;
: TIM10-CNT. ." TIM10-CNT (read-write) $" TIM10-CNT @ hex. TIM10-CNT 1b. ;
: TIM10-PSC. ." TIM10-PSC (read-write) $" TIM10-PSC @ hex. TIM10-PSC 1b. ;
: TIM10-ARR. ." TIM10-ARR (read-write) $" TIM10-ARR @ hex. TIM10-ARR 1b. ;
: TIM10-CCR1. ." TIM10-CCR1 (read-write) $" TIM10-CCR1 @ hex. TIM10-CCR1 1b. ;
: TIM10.
TIM10-CR1.
TIM10-CR2.
TIM10-DIER.
TIM10-SR.
TIM10-EGR.
TIM10-CCMR1_Output.
TIM10-CCMR1_Input.
TIM10-CCER.
TIM10-CNT.
TIM10-PSC.
TIM10-ARR.
TIM10-CCR1.
;

$40015400 constant TIM11 ( General purpose timer ) 
TIM11 $0 + constant TIM11-CR1 ( control register 1 ) 
TIM11 $4 + constant TIM11-CR2 ( control register 2 ) 
TIM11 $C + constant TIM11-DIER ( DMA/Interrupt enable register ) 
TIM11 $10 + constant TIM11-SR ( status register ) 
TIM11 $14 + constant TIM11-EGR ( event generation register ) 
TIM11 $18 + constant TIM11-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM11 $18 + constant TIM11-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM11 $20 + constant TIM11-CCER ( capture/compare enable  register ) 
TIM11 $24 + constant TIM11-CNT ( counter ) 
TIM11 $28 + constant TIM11-PSC ( prescaler ) 
TIM11 $2C + constant TIM11-ARR ( auto-reload register ) 
TIM11 $34 + constant TIM11-CCR1 ( capture/compare register 1 ) 
: TIM11-CR1. ." TIM11-CR1 (read-write) $" TIM11-CR1 @ hex. TIM11-CR1 1b. ;
: TIM11-CR2. ." TIM11-CR2 (read-write) $" TIM11-CR2 @ hex. TIM11-CR2 1b. ;
: TIM11-DIER. ." TIM11-DIER (read-write) $" TIM11-DIER @ hex. TIM11-DIER 1b. ;
: TIM11-SR. ." TIM11-SR (read-write) $" TIM11-SR @ hex. TIM11-SR 1b. ;
: TIM11-EGR. ." TIM11-EGR (write-only) $" TIM11-EGR @ hex. TIM11-EGR 1b. ;
: TIM11-CCMR1_Output. ." TIM11-CCMR1_Output (read-write) $" TIM11-CCMR1_Output @ hex. TIM11-CCMR1_Output 1b. ;
: TIM11-CCMR1_Input. ." TIM11-CCMR1_Input (read-write) $" TIM11-CCMR1_Input @ hex. TIM11-CCMR1_Input 1b. ;
: TIM11-CCER. ." TIM11-CCER (read-write) $" TIM11-CCER @ hex. TIM11-CCER 1b. ;
: TIM11-CNT. ." TIM11-CNT (read-write) $" TIM11-CNT @ hex. TIM11-CNT 1b. ;
: TIM11-PSC. ." TIM11-PSC (read-write) $" TIM11-PSC @ hex. TIM11-PSC 1b. ;
: TIM11-ARR. ." TIM11-ARR (read-write) $" TIM11-ARR @ hex. TIM11-ARR 1b. ;
: TIM11-CCR1. ." TIM11-CCR1 (read-write) $" TIM11-CCR1 @ hex. TIM11-CCR1 1b. ;
: TIM11.
TIM11-CR1.
TIM11-CR2.
TIM11-DIER.
TIM11-SR.
TIM11-EGR.
TIM11-CCMR1_Output.
TIM11-CCMR1_Input.
TIM11-CCER.
TIM11-CNT.
TIM11-PSC.
TIM11-ARR.
TIM11-CCR1.
;

$40001C00 constant TIM13 ( General purpose timer ) 
TIM13 $0 + constant TIM13-CR1 ( control register 1 ) 
TIM13 $4 + constant TIM13-CR2 ( control register 2 ) 
TIM13 $C + constant TIM13-DIER ( DMA/Interrupt enable register ) 
TIM13 $10 + constant TIM13-SR ( status register ) 
TIM13 $14 + constant TIM13-EGR ( event generation register ) 
TIM13 $18 + constant TIM13-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM13 $18 + constant TIM13-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM13 $20 + constant TIM13-CCER ( capture/compare enable  register ) 
TIM13 $24 + constant TIM13-CNT ( counter ) 
TIM13 $28 + constant TIM13-PSC ( prescaler ) 
TIM13 $2C + constant TIM13-ARR ( auto-reload register ) 
TIM13 $34 + constant TIM13-CCR1 ( capture/compare register 1 ) 
: TIM13-CR1. ." TIM13-CR1 (read-write) $" TIM13-CR1 @ hex. TIM13-CR1 1b. ;
: TIM13-CR2. ." TIM13-CR2 (read-write) $" TIM13-CR2 @ hex. TIM13-CR2 1b. ;
: TIM13-DIER. ." TIM13-DIER (read-write) $" TIM13-DIER @ hex. TIM13-DIER 1b. ;
: TIM13-SR. ." TIM13-SR (read-write) $" TIM13-SR @ hex. TIM13-SR 1b. ;
: TIM13-EGR. ." TIM13-EGR (write-only) $" TIM13-EGR @ hex. TIM13-EGR 1b. ;
: TIM13-CCMR1_Output. ." TIM13-CCMR1_Output (read-write) $" TIM13-CCMR1_Output @ hex. TIM13-CCMR1_Output 1b. ;
: TIM13-CCMR1_Input. ." TIM13-CCMR1_Input (read-write) $" TIM13-CCMR1_Input @ hex. TIM13-CCMR1_Input 1b. ;
: TIM13-CCER. ." TIM13-CCER (read-write) $" TIM13-CCER @ hex. TIM13-CCER 1b. ;
: TIM13-CNT. ." TIM13-CNT (read-write) $" TIM13-CNT @ hex. TIM13-CNT 1b. ;
: TIM13-PSC. ." TIM13-PSC (read-write) $" TIM13-PSC @ hex. TIM13-PSC 1b. ;
: TIM13-ARR. ." TIM13-ARR (read-write) $" TIM13-ARR @ hex. TIM13-ARR 1b. ;
: TIM13-CCR1. ." TIM13-CCR1 (read-write) $" TIM13-CCR1 @ hex. TIM13-CCR1 1b. ;
: TIM13.
TIM13-CR1.
TIM13-CR2.
TIM13-DIER.
TIM13-SR.
TIM13-EGR.
TIM13-CCMR1_Output.
TIM13-CCMR1_Input.
TIM13-CCER.
TIM13-CNT.
TIM13-PSC.
TIM13-ARR.
TIM13-CCR1.
;

$40002000 constant TIM14 ( General purpose timer ) 
TIM14 $0 + constant TIM14-CR1 ( control register 1 ) 
TIM14 $4 + constant TIM14-CR2 ( control register 2 ) 
TIM14 $C + constant TIM14-DIER ( DMA/Interrupt enable register ) 
TIM14 $10 + constant TIM14-SR ( status register ) 
TIM14 $14 + constant TIM14-EGR ( event generation register ) 
TIM14 $18 + constant TIM14-CCMR1_Output ( capture/compare mode register output  mode ) 
TIM14 $18 + constant TIM14-CCMR1_Input ( capture/compare mode register input  mode ) 
TIM14 $20 + constant TIM14-CCER ( capture/compare enable  register ) 
TIM14 $24 + constant TIM14-CNT ( counter ) 
TIM14 $28 + constant TIM14-PSC ( prescaler ) 
TIM14 $2C + constant TIM14-ARR ( auto-reload register ) 
TIM14 $34 + constant TIM14-CCR1 ( capture/compare register 1 ) 
: TIM14-CR1. ." TIM14-CR1 (read-write) $" TIM14-CR1 @ hex. TIM14-CR1 1b. ;
: TIM14-CR2. ." TIM14-CR2 (read-write) $" TIM14-CR2 @ hex. TIM14-CR2 1b. ;
: TIM14-DIER. ." TIM14-DIER (read-write) $" TIM14-DIER @ hex. TIM14-DIER 1b. ;
: TIM14-SR. ." TIM14-SR (read-write) $" TIM14-SR @ hex. TIM14-SR 1b. ;
: TIM14-EGR. ." TIM14-EGR (write-only) $" TIM14-EGR @ hex. TIM14-EGR 1b. ;
: TIM14-CCMR1_Output. ." TIM14-CCMR1_Output (read-write) $" TIM14-CCMR1_Output @ hex. TIM14-CCMR1_Output 1b. ;
: TIM14-CCMR1_Input. ." TIM14-CCMR1_Input (read-write) $" TIM14-CCMR1_Input @ hex. TIM14-CCMR1_Input 1b. ;
: TIM14-CCER. ." TIM14-CCER (read-write) $" TIM14-CCER @ hex. TIM14-CCER 1b. ;
: TIM14-CNT. ." TIM14-CNT (read-write) $" TIM14-CNT @ hex. TIM14-CNT 1b. ;
: TIM14-PSC. ." TIM14-PSC (read-write) $" TIM14-PSC @ hex. TIM14-PSC 1b. ;
: TIM14-ARR. ." TIM14-ARR (read-write) $" TIM14-ARR @ hex. TIM14-ARR 1b. ;
: TIM14-CCR1. ." TIM14-CCR1 (read-write) $" TIM14-CCR1 @ hex. TIM14-CCR1 1b. ;
: TIM14.
TIM14-CR1.
TIM14-CR2.
TIM14-DIER.
TIM14-SR.
TIM14-EGR.
TIM14-CCMR1_Output.
TIM14-CCMR1_Input.
TIM14-CCER.
TIM14-CNT.
TIM14-PSC.
TIM14-ARR.
TIM14-CCR1.
;

$40001000 constant TIM6 ( Basic timer ) 
TIM6 $0 + constant TIM6-CR1 ( control register 1 ) 
TIM6 $4 + constant TIM6-CR2 ( control register 2 ) 
TIM6 $C + constant TIM6-DIER ( DMA/Interrupt enable register ) 
TIM6 $10 + constant TIM6-SR ( status register ) 
TIM6 $14 + constant TIM6-EGR ( event generation register ) 
TIM6 $24 + constant TIM6-CNT ( counter ) 
TIM6 $28 + constant TIM6-PSC ( prescaler ) 
TIM6 $2C + constant TIM6-ARR ( auto-reload register ) 
: TIM6-CR1. ." TIM6-CR1 (read-write) $" TIM6-CR1 @ hex. TIM6-CR1 1b. ;
: TIM6-CR2. ." TIM6-CR2 (read-write) $" TIM6-CR2 @ hex. TIM6-CR2 1b. ;
: TIM6-DIER. ." TIM6-DIER (read-write) $" TIM6-DIER @ hex. TIM6-DIER 1b. ;
: TIM6-SR. ." TIM6-SR (read-write) $" TIM6-SR @ hex. TIM6-SR 1b. ;
: TIM6-EGR. ." TIM6-EGR (write-only) $" TIM6-EGR @ hex. TIM6-EGR 1b. ;
: TIM6-CNT. ." TIM6-CNT (read-write) $" TIM6-CNT @ hex. TIM6-CNT 1b. ;
: TIM6-PSC. ." TIM6-PSC (read-write) $" TIM6-PSC @ hex. TIM6-PSC 1b. ;
: TIM6-ARR. ." TIM6-ARR (read-write) $" TIM6-ARR @ hex. TIM6-ARR 1b. ;
: TIM6.
TIM6-CR1.
TIM6-CR2.
TIM6-DIER.
TIM6-SR.
TIM6-EGR.
TIM6-CNT.
TIM6-PSC.
TIM6-ARR.
;

$40001400 constant TIM7 ( Basic timer ) 
TIM7 $0 + constant TIM7-CR1 ( control register 1 ) 
TIM7 $4 + constant TIM7-CR2 ( control register 2 ) 
TIM7 $C + constant TIM7-DIER ( DMA/Interrupt enable register ) 
TIM7 $10 + constant TIM7-SR ( status register ) 
TIM7 $14 + constant TIM7-EGR ( event generation register ) 
TIM7 $24 + constant TIM7-CNT ( counter ) 
TIM7 $28 + constant TIM7-PSC ( prescaler ) 
TIM7 $2C + constant TIM7-ARR ( auto-reload register ) 
: TIM7-CR1. ." TIM7-CR1 (read-write) $" TIM7-CR1 @ hex. TIM7-CR1 1b. ;
: TIM7-CR2. ." TIM7-CR2 (read-write) $" TIM7-CR2 @ hex. TIM7-CR2 1b. ;
: TIM7-DIER. ." TIM7-DIER (read-write) $" TIM7-DIER @ hex. TIM7-DIER 1b. ;
: TIM7-SR. ." TIM7-SR (read-write) $" TIM7-SR @ hex. TIM7-SR 1b. ;
: TIM7-EGR. ." TIM7-EGR (write-only) $" TIM7-EGR @ hex. TIM7-EGR 1b. ;
: TIM7-CNT. ." TIM7-CNT (read-write) $" TIM7-CNT @ hex. TIM7-CNT 1b. ;
: TIM7-PSC. ." TIM7-PSC (read-write) $" TIM7-PSC @ hex. TIM7-PSC 1b. ;
: TIM7-ARR. ." TIM7-ARR (read-write) $" TIM7-ARR @ hex. TIM7-ARR 1b. ;
: TIM7.
TIM7-CR1.
TIM7-CR2.
TIM7-DIER.
TIM7-SR.
TIM7-EGR.
TIM7-CNT.
TIM7-PSC.
TIM7-ARR.
;

$40005400 constant I2C1 ( Inter integrated circuit ) 
I2C1 $0 + constant I2C1-CR1 ( Control register 1 ) 
I2C1 $4 + constant I2C1-CR2 ( Control register 2 ) 
I2C1 $8 + constant I2C1-OAR1 ( Own address register 1 ) 
I2C1 $C + constant I2C1-OAR2 ( Own address register 2 ) 
I2C1 $10 + constant I2C1-DR ( Data register ) 
I2C1 $14 + constant I2C1-SR1 ( Status register 1 ) 
I2C1 $18 + constant I2C1-SR2 ( Status register 2 ) 
I2C1 $1C + constant I2C1-CCR ( Clock control register ) 
I2C1 $20 + constant I2C1-TRISE ( TRISE register ) 
: I2C1-CR1. ." I2C1-CR1 (read-write) $" I2C1-CR1 @ hex. I2C1-CR1 1b. ;
: I2C1-CR2. ." I2C1-CR2 (read-write) $" I2C1-CR2 @ hex. I2C1-CR2 1b. ;
: I2C1-OAR1. ." I2C1-OAR1 (read-write) $" I2C1-OAR1 @ hex. I2C1-OAR1 1b. ;
: I2C1-OAR2. ." I2C1-OAR2 (read-write) $" I2C1-OAR2 @ hex. I2C1-OAR2 1b. ;
: I2C1-DR. ." I2C1-DR (read-write) $" I2C1-DR @ hex. I2C1-DR 1b. ;
: I2C1-SR1. ." I2C1-SR1 () $" I2C1-SR1 @ hex. I2C1-SR1 1b. ;
: I2C1-SR2. ." I2C1-SR2 (read-only) $" I2C1-SR2 @ hex. I2C1-SR2 1b. ;
: I2C1-CCR. ." I2C1-CCR (read-write) $" I2C1-CCR @ hex. I2C1-CCR 1b. ;
: I2C1-TRISE. ." I2C1-TRISE (read-write) $" I2C1-TRISE @ hex. I2C1-TRISE 1b. ;
: I2C1.
I2C1-CR1.
I2C1-CR2.
I2C1-OAR1.
I2C1-OAR2.
I2C1-DR.
I2C1-SR1.
I2C1-SR2.
I2C1-CCR.
I2C1-TRISE.
;

$40005800 constant I2C2 ( Inter integrated circuit ) 
I2C2 $0 + constant I2C2-CR1 ( Control register 1 ) 
I2C2 $4 + constant I2C2-CR2 ( Control register 2 ) 
I2C2 $8 + constant I2C2-OAR1 ( Own address register 1 ) 
I2C2 $C + constant I2C2-OAR2 ( Own address register 2 ) 
I2C2 $10 + constant I2C2-DR ( Data register ) 
I2C2 $14 + constant I2C2-SR1 ( Status register 1 ) 
I2C2 $18 + constant I2C2-SR2 ( Status register 2 ) 
I2C2 $1C + constant I2C2-CCR ( Clock control register ) 
I2C2 $20 + constant I2C2-TRISE ( TRISE register ) 
: I2C2-CR1. ." I2C2-CR1 (read-write) $" I2C2-CR1 @ hex. I2C2-CR1 1b. ;
: I2C2-CR2. ." I2C2-CR2 (read-write) $" I2C2-CR2 @ hex. I2C2-CR2 1b. ;
: I2C2-OAR1. ." I2C2-OAR1 (read-write) $" I2C2-OAR1 @ hex. I2C2-OAR1 1b. ;
: I2C2-OAR2. ." I2C2-OAR2 (read-write) $" I2C2-OAR2 @ hex. I2C2-OAR2 1b. ;
: I2C2-DR. ." I2C2-DR (read-write) $" I2C2-DR @ hex. I2C2-DR 1b. ;
: I2C2-SR1. ." I2C2-SR1 () $" I2C2-SR1 @ hex. I2C2-SR1 1b. ;
: I2C2-SR2. ." I2C2-SR2 (read-only) $" I2C2-SR2 @ hex. I2C2-SR2 1b. ;
: I2C2-CCR. ." I2C2-CCR (read-write) $" I2C2-CCR @ hex. I2C2-CCR 1b. ;
: I2C2-TRISE. ." I2C2-TRISE (read-write) $" I2C2-TRISE @ hex. I2C2-TRISE 1b. ;
: I2C2.
I2C2-CR1.
I2C2-CR2.
I2C2-OAR1.
I2C2-OAR2.
I2C2-DR.
I2C2-SR1.
I2C2-SR2.
I2C2-CCR.
I2C2-TRISE.
;

$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1-CR1 ( control register 1 ) 
SPI1 $4 + constant SPI1-CR2 ( control register 2 ) 
SPI1 $8 + constant SPI1-SR ( status register ) 
SPI1 $C + constant SPI1-DR ( data register ) 
SPI1 $10 + constant SPI1-CRCPR ( CRC polynomial register ) 
SPI1 $14 + constant SPI1-RXCRCR ( RX CRC register ) 
SPI1 $18 + constant SPI1-TXCRCR ( TX CRC register ) 
SPI1 $1C + constant SPI1-I2SCFGR ( I2S configuration register ) 
SPI1 $20 + constant SPI1-I2SPR ( I2S prescaler register ) 
: SPI1-CR1. ." SPI1-CR1 (read-write) $" SPI1-CR1 @ hex. SPI1-CR1 1b. ;
: SPI1-CR2. ." SPI1-CR2 (read-write) $" SPI1-CR2 @ hex. SPI1-CR2 1b. ;
: SPI1-SR. ." SPI1-SR () $" SPI1-SR @ hex. SPI1-SR 1b. ;
: SPI1-DR. ." SPI1-DR (read-write) $" SPI1-DR @ hex. SPI1-DR 1b. ;
: SPI1-CRCPR. ." SPI1-CRCPR (read-write) $" SPI1-CRCPR @ hex. SPI1-CRCPR 1b. ;
: SPI1-RXCRCR. ." SPI1-RXCRCR (read-only) $" SPI1-RXCRCR @ hex. SPI1-RXCRCR 1b. ;
: SPI1-TXCRCR. ." SPI1-TXCRCR (read-only) $" SPI1-TXCRCR @ hex. SPI1-TXCRCR 1b. ;
: SPI1-I2SCFGR. ." SPI1-I2SCFGR (read-write) $" SPI1-I2SCFGR @ hex. SPI1-I2SCFGR 1b. ;
: SPI1-I2SPR. ." SPI1-I2SPR (read-write) $" SPI1-I2SPR @ hex. SPI1-I2SPR 1b. ;
: SPI1.
SPI1-CR1.
SPI1-CR2.
SPI1-SR.
SPI1-DR.
SPI1-CRCPR.
SPI1-RXCRCR.
SPI1-TXCRCR.
SPI1-I2SCFGR.
SPI1-I2SPR.
;

$40003800 constant SPI2 ( Serial peripheral interface ) 
SPI2 $0 + constant SPI2-CR1 ( control register 1 ) 
SPI2 $4 + constant SPI2-CR2 ( control register 2 ) 
SPI2 $8 + constant SPI2-SR ( status register ) 
SPI2 $C + constant SPI2-DR ( data register ) 
SPI2 $10 + constant SPI2-CRCPR ( CRC polynomial register ) 
SPI2 $14 + constant SPI2-RXCRCR ( RX CRC register ) 
SPI2 $18 + constant SPI2-TXCRCR ( TX CRC register ) 
SPI2 $1C + constant SPI2-I2SCFGR ( I2S configuration register ) 
SPI2 $20 + constant SPI2-I2SPR ( I2S prescaler register ) 
: SPI2-CR1. ." SPI2-CR1 (read-write) $" SPI2-CR1 @ hex. SPI2-CR1 1b. ;
: SPI2-CR2. ." SPI2-CR2 (read-write) $" SPI2-CR2 @ hex. SPI2-CR2 1b. ;
: SPI2-SR. ." SPI2-SR () $" SPI2-SR @ hex. SPI2-SR 1b. ;
: SPI2-DR. ." SPI2-DR (read-write) $" SPI2-DR @ hex. SPI2-DR 1b. ;
: SPI2-CRCPR. ." SPI2-CRCPR (read-write) $" SPI2-CRCPR @ hex. SPI2-CRCPR 1b. ;
: SPI2-RXCRCR. ." SPI2-RXCRCR (read-only) $" SPI2-RXCRCR @ hex. SPI2-RXCRCR 1b. ;
: SPI2-TXCRCR. ." SPI2-TXCRCR (read-only) $" SPI2-TXCRCR @ hex. SPI2-TXCRCR 1b. ;
: SPI2-I2SCFGR. ." SPI2-I2SCFGR (read-write) $" SPI2-I2SCFGR @ hex. SPI2-I2SCFGR 1b. ;
: SPI2-I2SPR. ." SPI2-I2SPR (read-write) $" SPI2-I2SPR @ hex. SPI2-I2SPR 1b. ;
: SPI2.
SPI2-CR1.
SPI2-CR2.
SPI2-SR.
SPI2-DR.
SPI2-CRCPR.
SPI2-RXCRCR.
SPI2-TXCRCR.
SPI2-I2SCFGR.
SPI2-I2SPR.
;

$40003C00 constant SPI3 ( Serial peripheral interface ) 
SPI3 $0 + constant SPI3-CR1 ( control register 1 ) 
SPI3 $4 + constant SPI3-CR2 ( control register 2 ) 
SPI3 $8 + constant SPI3-SR ( status register ) 
SPI3 $C + constant SPI3-DR ( data register ) 
SPI3 $10 + constant SPI3-CRCPR ( CRC polynomial register ) 
SPI3 $14 + constant SPI3-RXCRCR ( RX CRC register ) 
SPI3 $18 + constant SPI3-TXCRCR ( TX CRC register ) 
SPI3 $1C + constant SPI3-I2SCFGR ( I2S configuration register ) 
SPI3 $20 + constant SPI3-I2SPR ( I2S prescaler register ) 
: SPI3-CR1. ." SPI3-CR1 (read-write) $" SPI3-CR1 @ hex. SPI3-CR1 1b. ;
: SPI3-CR2. ." SPI3-CR2 (read-write) $" SPI3-CR2 @ hex. SPI3-CR2 1b. ;
: SPI3-SR. ." SPI3-SR () $" SPI3-SR @ hex. SPI3-SR 1b. ;
: SPI3-DR. ." SPI3-DR (read-write) $" SPI3-DR @ hex. SPI3-DR 1b. ;
: SPI3-CRCPR. ." SPI3-CRCPR (read-write) $" SPI3-CRCPR @ hex. SPI3-CRCPR 1b. ;
: SPI3-RXCRCR. ." SPI3-RXCRCR (read-only) $" SPI3-RXCRCR @ hex. SPI3-RXCRCR 1b. ;
: SPI3-TXCRCR. ." SPI3-TXCRCR (read-only) $" SPI3-TXCRCR @ hex. SPI3-TXCRCR 1b. ;
: SPI3-I2SCFGR. ." SPI3-I2SCFGR (read-write) $" SPI3-I2SCFGR @ hex. SPI3-I2SCFGR 1b. ;
: SPI3-I2SPR. ." SPI3-I2SPR (read-write) $" SPI3-I2SPR @ hex. SPI3-I2SPR 1b. ;
: SPI3.
SPI3-CR1.
SPI3-CR2.
SPI3-SR.
SPI3-DR.
SPI3-CRCPR.
SPI3-RXCRCR.
SPI3-TXCRCR.
SPI3-I2SCFGR.
SPI3-I2SPR.
;

$40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 $0 + constant USART1-SR ( Status register ) 
USART1 $4 + constant USART1-DR ( Data register ) 
USART1 $8 + constant USART1-BRR ( Baud rate register ) 
USART1 $C + constant USART1-CR1 ( Control register 1 ) 
USART1 $10 + constant USART1-CR2 ( Control register 2 ) 
USART1 $14 + constant USART1-CR3 ( Control register 3 ) 
USART1 $18 + constant USART1-GTPR ( Guard time and prescaler  register ) 
: USART1-SR. ." USART1-SR () $" USART1-SR @ hex. USART1-SR 1b. ;
: USART1-DR. ." USART1-DR (read-write) $" USART1-DR @ hex. USART1-DR 1b. ;
: USART1-BRR. ." USART1-BRR (read-write) $" USART1-BRR @ hex. USART1-BRR 1b. ;
: USART1-CR1. ." USART1-CR1 (read-write) $" USART1-CR1 @ hex. USART1-CR1 1b. ;
: USART1-CR2. ." USART1-CR2 (read-write) $" USART1-CR2 @ hex. USART1-CR2 1b. ;
: USART1-CR3. ." USART1-CR3 (read-write) $" USART1-CR3 @ hex. USART1-CR3 1b. ;
: USART1-GTPR. ." USART1-GTPR (read-write) $" USART1-GTPR @ hex. USART1-GTPR 1b. ;
: USART1.
USART1-SR.
USART1-DR.
USART1-BRR.
USART1-CR1.
USART1-CR2.
USART1-CR3.
USART1-GTPR.
;

$40004400 constant USART2 ( Universal synchronous asynchronous receiver  transmitter ) 
USART2 $0 + constant USART2-SR ( Status register ) 
USART2 $4 + constant USART2-DR ( Data register ) 
USART2 $8 + constant USART2-BRR ( Baud rate register ) 
USART2 $C + constant USART2-CR1 ( Control register 1 ) 
USART2 $10 + constant USART2-CR2 ( Control register 2 ) 
USART2 $14 + constant USART2-CR3 ( Control register 3 ) 
USART2 $18 + constant USART2-GTPR ( Guard time and prescaler  register ) 
: USART2-SR. ." USART2-SR () $" USART2-SR @ hex. USART2-SR 1b. ;
: USART2-DR. ." USART2-DR (read-write) $" USART2-DR @ hex. USART2-DR 1b. ;
: USART2-BRR. ." USART2-BRR (read-write) $" USART2-BRR @ hex. USART2-BRR 1b. ;
: USART2-CR1. ." USART2-CR1 (read-write) $" USART2-CR1 @ hex. USART2-CR1 1b. ;
: USART2-CR2. ." USART2-CR2 (read-write) $" USART2-CR2 @ hex. USART2-CR2 1b. ;
: USART2-CR3. ." USART2-CR3 (read-write) $" USART2-CR3 @ hex. USART2-CR3 1b. ;
: USART2-GTPR. ." USART2-GTPR (read-write) $" USART2-GTPR @ hex. USART2-GTPR 1b. ;
: USART2.
USART2-SR.
USART2-DR.
USART2-BRR.
USART2-CR1.
USART2-CR2.
USART2-CR3.
USART2-GTPR.
;

$40004800 constant USART3 ( Universal synchronous asynchronous receiver  transmitter ) 
USART3 $0 + constant USART3-SR ( Status register ) 
USART3 $4 + constant USART3-DR ( Data register ) 
USART3 $8 + constant USART3-BRR ( Baud rate register ) 
USART3 $C + constant USART3-CR1 ( Control register 1 ) 
USART3 $10 + constant USART3-CR2 ( Control register 2 ) 
USART3 $14 + constant USART3-CR3 ( Control register 3 ) 
USART3 $18 + constant USART3-GTPR ( Guard time and prescaler  register ) 
: USART3-SR. ." USART3-SR () $" USART3-SR @ hex. USART3-SR 1b. ;
: USART3-DR. ." USART3-DR (read-write) $" USART3-DR @ hex. USART3-DR 1b. ;
: USART3-BRR. ." USART3-BRR (read-write) $" USART3-BRR @ hex. USART3-BRR 1b. ;
: USART3-CR1. ." USART3-CR1 (read-write) $" USART3-CR1 @ hex. USART3-CR1 1b. ;
: USART3-CR2. ." USART3-CR2 (read-write) $" USART3-CR2 @ hex. USART3-CR2 1b. ;
: USART3-CR3. ." USART3-CR3 (read-write) $" USART3-CR3 @ hex. USART3-CR3 1b. ;
: USART3-GTPR. ." USART3-GTPR (read-write) $" USART3-GTPR @ hex. USART3-GTPR 1b. ;
: USART3.
USART3-SR.
USART3-DR.
USART3-BRR.
USART3-CR1.
USART3-CR2.
USART3-CR3.
USART3-GTPR.
;

$40012400 constant ADC1 ( Analog to digital converter ) 
ADC1 $0 + constant ADC1-SR ( status register ) 
ADC1 $4 + constant ADC1-CR1 ( control register 1 ) 
ADC1 $8 + constant ADC1-CR2 ( control register 2 ) 
ADC1 $C + constant ADC1-SMPR1 ( sample time register 1 ) 
ADC1 $10 + constant ADC1-SMPR2 ( sample time register 2 ) 
ADC1 $14 + constant ADC1-JOFR1 ( injected channel data offset register  x ) 
ADC1 $18 + constant ADC1-JOFR2 ( injected channel data offset register  x ) 
ADC1 $1C + constant ADC1-JOFR3 ( injected channel data offset register  x ) 
ADC1 $20 + constant ADC1-JOFR4 ( injected channel data offset register  x ) 
ADC1 $24 + constant ADC1-HTR ( watchdog higher threshold  register ) 
ADC1 $28 + constant ADC1-LTR ( watchdog lower threshold  register ) 
ADC1 $2C + constant ADC1-SQR1 ( regular sequence register 1 ) 
ADC1 $30 + constant ADC1-SQR2 ( regular sequence register 2 ) 
ADC1 $34 + constant ADC1-SQR3 ( regular sequence register 3 ) 
ADC1 $38 + constant ADC1-JSQR ( injected sequence register ) 
ADC1 $3C + constant ADC1-JDR1 ( injected data register x ) 
ADC1 $40 + constant ADC1-JDR2 ( injected data register x ) 
ADC1 $44 + constant ADC1-JDR3 ( injected data register x ) 
ADC1 $48 + constant ADC1-JDR4 ( injected data register x ) 
ADC1 $4C + constant ADC1-DR ( regular data register ) 
: ADC1-SR. ." ADC1-SR (read-write) $" ADC1-SR @ hex. ADC1-SR 1b. ;
: ADC1-CR1. ." ADC1-CR1 (read-write) $" ADC1-CR1 @ hex. ADC1-CR1 1b. ;
: ADC1-CR2. ." ADC1-CR2 (read-write) $" ADC1-CR2 @ hex. ADC1-CR2 1b. ;
: ADC1-SMPR1. ." ADC1-SMPR1 (read-write) $" ADC1-SMPR1 @ hex. ADC1-SMPR1 1b. ;
: ADC1-SMPR2. ." ADC1-SMPR2 (read-write) $" ADC1-SMPR2 @ hex. ADC1-SMPR2 1b. ;
: ADC1-JOFR1. ." ADC1-JOFR1 (read-write) $" ADC1-JOFR1 @ hex. ADC1-JOFR1 1b. ;
: ADC1-JOFR2. ." ADC1-JOFR2 (read-write) $" ADC1-JOFR2 @ hex. ADC1-JOFR2 1b. ;
: ADC1-JOFR3. ." ADC1-JOFR3 (read-write) $" ADC1-JOFR3 @ hex. ADC1-JOFR3 1b. ;
: ADC1-JOFR4. ." ADC1-JOFR4 (read-write) $" ADC1-JOFR4 @ hex. ADC1-JOFR4 1b. ;
: ADC1-HTR. ." ADC1-HTR (read-write) $" ADC1-HTR @ hex. ADC1-HTR 1b. ;
: ADC1-LTR. ." ADC1-LTR (read-write) $" ADC1-LTR @ hex. ADC1-LTR 1b. ;
: ADC1-SQR1. ." ADC1-SQR1 (read-write) $" ADC1-SQR1 @ hex. ADC1-SQR1 1b. ;
: ADC1-SQR2. ." ADC1-SQR2 (read-write) $" ADC1-SQR2 @ hex. ADC1-SQR2 1b. ;
: ADC1-SQR3. ." ADC1-SQR3 (read-write) $" ADC1-SQR3 @ hex. ADC1-SQR3 1b. ;
: ADC1-JSQR. ." ADC1-JSQR (read-write) $" ADC1-JSQR @ hex. ADC1-JSQR 1b. ;
: ADC1-JDR1. ." ADC1-JDR1 (read-only) $" ADC1-JDR1 @ hex. ADC1-JDR1 1b. ;
: ADC1-JDR2. ." ADC1-JDR2 (read-only) $" ADC1-JDR2 @ hex. ADC1-JDR2 1b. ;
: ADC1-JDR3. ." ADC1-JDR3 (read-only) $" ADC1-JDR3 @ hex. ADC1-JDR3 1b. ;
: ADC1-JDR4. ." ADC1-JDR4 (read-only) $" ADC1-JDR4 @ hex. ADC1-JDR4 1b. ;
: ADC1-DR. ." ADC1-DR (read-only) $" ADC1-DR @ hex. ADC1-DR 1b. ;
: ADC1.
ADC1-SR.
ADC1-CR1.
ADC1-CR2.
ADC1-SMPR1.
ADC1-SMPR2.
ADC1-JOFR1.
ADC1-JOFR2.
ADC1-JOFR3.
ADC1-JOFR4.
ADC1-HTR.
ADC1-LTR.
ADC1-SQR1.
ADC1-SQR2.
ADC1-SQR3.
ADC1-JSQR.
ADC1-JDR1.
ADC1-JDR2.
ADC1-JDR3.
ADC1-JDR4.
ADC1-DR.
;

$40012800 constant ADC2 ( Analog to digital converter ) 
ADC2 $0 + constant ADC2-SR ( status register ) 
ADC2 $4 + constant ADC2-CR1 ( control register 1 ) 
ADC2 $8 + constant ADC2-CR2 ( control register 2 ) 
ADC2 $C + constant ADC2-SMPR1 ( sample time register 1 ) 
ADC2 $10 + constant ADC2-SMPR2 ( sample time register 2 ) 
ADC2 $14 + constant ADC2-JOFR1 ( injected channel data offset register  x ) 
ADC2 $18 + constant ADC2-JOFR2 ( injected channel data offset register  x ) 
ADC2 $1C + constant ADC2-JOFR3 ( injected channel data offset register  x ) 
ADC2 $20 + constant ADC2-JOFR4 ( injected channel data offset register  x ) 
ADC2 $24 + constant ADC2-HTR ( watchdog higher threshold  register ) 
ADC2 $28 + constant ADC2-LTR ( watchdog lower threshold  register ) 
ADC2 $2C + constant ADC2-SQR1 ( regular sequence register 1 ) 
ADC2 $30 + constant ADC2-SQR2 ( regular sequence register 2 ) 
ADC2 $34 + constant ADC2-SQR3 ( regular sequence register 3 ) 
ADC2 $38 + constant ADC2-JSQR ( injected sequence register ) 
ADC2 $3C + constant ADC2-JDR1 ( injected data register x ) 
ADC2 $40 + constant ADC2-JDR2 ( injected data register x ) 
ADC2 $44 + constant ADC2-JDR3 ( injected data register x ) 
ADC2 $48 + constant ADC2-JDR4 ( injected data register x ) 
ADC2 $4C + constant ADC2-DR ( regular data register ) 
: ADC2-SR. ." ADC2-SR (read-write) $" ADC2-SR @ hex. ADC2-SR 1b. ;
: ADC2-CR1. ." ADC2-CR1 (read-write) $" ADC2-CR1 @ hex. ADC2-CR1 1b. ;
: ADC2-CR2. ." ADC2-CR2 (read-write) $" ADC2-CR2 @ hex. ADC2-CR2 1b. ;
: ADC2-SMPR1. ." ADC2-SMPR1 (read-write) $" ADC2-SMPR1 @ hex. ADC2-SMPR1 1b. ;
: ADC2-SMPR2. ." ADC2-SMPR2 (read-write) $" ADC2-SMPR2 @ hex. ADC2-SMPR2 1b. ;
: ADC2-JOFR1. ." ADC2-JOFR1 (read-write) $" ADC2-JOFR1 @ hex. ADC2-JOFR1 1b. ;
: ADC2-JOFR2. ." ADC2-JOFR2 (read-write) $" ADC2-JOFR2 @ hex. ADC2-JOFR2 1b. ;
: ADC2-JOFR3. ." ADC2-JOFR3 (read-write) $" ADC2-JOFR3 @ hex. ADC2-JOFR3 1b. ;
: ADC2-JOFR4. ." ADC2-JOFR4 (read-write) $" ADC2-JOFR4 @ hex. ADC2-JOFR4 1b. ;
: ADC2-HTR. ." ADC2-HTR (read-write) $" ADC2-HTR @ hex. ADC2-HTR 1b. ;
: ADC2-LTR. ." ADC2-LTR (read-write) $" ADC2-LTR @ hex. ADC2-LTR 1b. ;
: ADC2-SQR1. ." ADC2-SQR1 (read-write) $" ADC2-SQR1 @ hex. ADC2-SQR1 1b. ;
: ADC2-SQR2. ." ADC2-SQR2 (read-write) $" ADC2-SQR2 @ hex. ADC2-SQR2 1b. ;
: ADC2-SQR3. ." ADC2-SQR3 (read-write) $" ADC2-SQR3 @ hex. ADC2-SQR3 1b. ;
: ADC2-JSQR. ." ADC2-JSQR (read-write) $" ADC2-JSQR @ hex. ADC2-JSQR 1b. ;
: ADC2-JDR1. ." ADC2-JDR1 (read-only) $" ADC2-JDR1 @ hex. ADC2-JDR1 1b. ;
: ADC2-JDR2. ." ADC2-JDR2 (read-only) $" ADC2-JDR2 @ hex. ADC2-JDR2 1b. ;
: ADC2-JDR3. ." ADC2-JDR3 (read-only) $" ADC2-JDR3 @ hex. ADC2-JDR3 1b. ;
: ADC2-JDR4. ." ADC2-JDR4 (read-only) $" ADC2-JDR4 @ hex. ADC2-JDR4 1b. ;
: ADC2-DR. ." ADC2-DR (read-only) $" ADC2-DR @ hex. ADC2-DR 1b. ;
: ADC2.
ADC2-SR.
ADC2-CR1.
ADC2-CR2.
ADC2-SMPR1.
ADC2-SMPR2.
ADC2-JOFR1.
ADC2-JOFR2.
ADC2-JOFR3.
ADC2-JOFR4.
ADC2-HTR.
ADC2-LTR.
ADC2-SQR1.
ADC2-SQR2.
ADC2-SQR3.
ADC2-JSQR.
ADC2-JDR1.
ADC2-JDR2.
ADC2-JDR3.
ADC2-JDR4.
ADC2-DR.
;

$40013C00 constant ADC3 ( Analog to digital converter ) 
ADC3 $0 + constant ADC3-SR ( status register ) 
ADC3 $4 + constant ADC3-CR1 ( control register 1 ) 
ADC3 $8 + constant ADC3-CR2 ( control register 2 ) 
ADC3 $C + constant ADC3-SMPR1 ( sample time register 1 ) 
ADC3 $10 + constant ADC3-SMPR2 ( sample time register 2 ) 
ADC3 $14 + constant ADC3-JOFR1 ( injected channel data offset register  x ) 
ADC3 $18 + constant ADC3-JOFR2 ( injected channel data offset register  x ) 
ADC3 $1C + constant ADC3-JOFR3 ( injected channel data offset register  x ) 
ADC3 $20 + constant ADC3-JOFR4 ( injected channel data offset register  x ) 
ADC3 $24 + constant ADC3-HTR ( watchdog higher threshold  register ) 
ADC3 $28 + constant ADC3-LTR ( watchdog lower threshold  register ) 
ADC3 $2C + constant ADC3-SQR1 ( regular sequence register 1 ) 
ADC3 $30 + constant ADC3-SQR2 ( regular sequence register 2 ) 
ADC3 $34 + constant ADC3-SQR3 ( regular sequence register 3 ) 
ADC3 $38 + constant ADC3-JSQR ( injected sequence register ) 
ADC3 $3C + constant ADC3-JDR1 ( injected data register x ) 
ADC3 $40 + constant ADC3-JDR2 ( injected data register x ) 
ADC3 $44 + constant ADC3-JDR3 ( injected data register x ) 
ADC3 $48 + constant ADC3-JDR4 ( injected data register x ) 
ADC3 $4C + constant ADC3-DR ( regular data register ) 
: ADC3-SR. ." ADC3-SR (read-write) $" ADC3-SR @ hex. ADC3-SR 1b. ;
: ADC3-CR1. ." ADC3-CR1 (read-write) $" ADC3-CR1 @ hex. ADC3-CR1 1b. ;
: ADC3-CR2. ." ADC3-CR2 (read-write) $" ADC3-CR2 @ hex. ADC3-CR2 1b. ;
: ADC3-SMPR1. ." ADC3-SMPR1 (read-write) $" ADC3-SMPR1 @ hex. ADC3-SMPR1 1b. ;
: ADC3-SMPR2. ." ADC3-SMPR2 (read-write) $" ADC3-SMPR2 @ hex. ADC3-SMPR2 1b. ;
: ADC3-JOFR1. ." ADC3-JOFR1 (read-write) $" ADC3-JOFR1 @ hex. ADC3-JOFR1 1b. ;
: ADC3-JOFR2. ." ADC3-JOFR2 (read-write) $" ADC3-JOFR2 @ hex. ADC3-JOFR2 1b. ;
: ADC3-JOFR3. ." ADC3-JOFR3 (read-write) $" ADC3-JOFR3 @ hex. ADC3-JOFR3 1b. ;
: ADC3-JOFR4. ." ADC3-JOFR4 (read-write) $" ADC3-JOFR4 @ hex. ADC3-JOFR4 1b. ;
: ADC3-HTR. ." ADC3-HTR (read-write) $" ADC3-HTR @ hex. ADC3-HTR 1b. ;
: ADC3-LTR. ." ADC3-LTR (read-write) $" ADC3-LTR @ hex. ADC3-LTR 1b. ;
: ADC3-SQR1. ." ADC3-SQR1 (read-write) $" ADC3-SQR1 @ hex. ADC3-SQR1 1b. ;
: ADC3-SQR2. ." ADC3-SQR2 (read-write) $" ADC3-SQR2 @ hex. ADC3-SQR2 1b. ;
: ADC3-SQR3. ." ADC3-SQR3 (read-write) $" ADC3-SQR3 @ hex. ADC3-SQR3 1b. ;
: ADC3-JSQR. ." ADC3-JSQR (read-write) $" ADC3-JSQR @ hex. ADC3-JSQR 1b. ;
: ADC3-JDR1. ." ADC3-JDR1 (read-only) $" ADC3-JDR1 @ hex. ADC3-JDR1 1b. ;
: ADC3-JDR2. ." ADC3-JDR2 (read-only) $" ADC3-JDR2 @ hex. ADC3-JDR2 1b. ;
: ADC3-JDR3. ." ADC3-JDR3 (read-only) $" ADC3-JDR3 @ hex. ADC3-JDR3 1b. ;
: ADC3-JDR4. ." ADC3-JDR4 (read-only) $" ADC3-JDR4 @ hex. ADC3-JDR4 1b. ;
: ADC3-DR. ." ADC3-DR (read-only) $" ADC3-DR @ hex. ADC3-DR 1b. ;
: ADC3.
ADC3-SR.
ADC3-CR1.
ADC3-CR2.
ADC3-SMPR1.
ADC3-SMPR2.
ADC3-JOFR1.
ADC3-JOFR2.
ADC3-JOFR3.
ADC3-JOFR4.
ADC3-HTR.
ADC3-LTR.
ADC3-SQR1.
ADC3-SQR2.
ADC3-SQR3.
ADC3-JSQR.
ADC3-JDR1.
ADC3-JDR2.
ADC3-JDR3.
ADC3-JDR4.
ADC3-DR.
;

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
: CAN-CAN_MCR. ." CAN-CAN_MCR (read-write) $" CAN-CAN_MCR @ hex. CAN-CAN_MCR 1b. ;
: CAN-CAN_MSR. ." CAN-CAN_MSR () $" CAN-CAN_MSR @ hex. CAN-CAN_MSR 1b. ;
: CAN-CAN_TSR. ." CAN-CAN_TSR () $" CAN-CAN_TSR @ hex. CAN-CAN_TSR 1b. ;
: CAN-CAN_RF0R. ." CAN-CAN_RF0R () $" CAN-CAN_RF0R @ hex. CAN-CAN_RF0R 1b. ;
: CAN-CAN_RF1R. ." CAN-CAN_RF1R () $" CAN-CAN_RF1R @ hex. CAN-CAN_RF1R 1b. ;
: CAN-CAN_IER. ." CAN-CAN_IER (read-write) $" CAN-CAN_IER @ hex. CAN-CAN_IER 1b. ;
: CAN-CAN_ESR. ." CAN-CAN_ESR () $" CAN-CAN_ESR @ hex. CAN-CAN_ESR 1b. ;
: CAN-CAN_BTR. ." CAN-CAN_BTR (read-write) $" CAN-CAN_BTR @ hex. CAN-CAN_BTR 1b. ;
: CAN-CAN_TI0R. ." CAN-CAN_TI0R (read-write) $" CAN-CAN_TI0R @ hex. CAN-CAN_TI0R 1b. ;
: CAN-CAN_TDT0R. ." CAN-CAN_TDT0R (read-write) $" CAN-CAN_TDT0R @ hex. CAN-CAN_TDT0R 1b. ;
: CAN-CAN_TDL0R. ." CAN-CAN_TDL0R (read-write) $" CAN-CAN_TDL0R @ hex. CAN-CAN_TDL0R 1b. ;
: CAN-CAN_TDH0R. ." CAN-CAN_TDH0R (read-write) $" CAN-CAN_TDH0R @ hex. CAN-CAN_TDH0R 1b. ;
: CAN-CAN_TI1R. ." CAN-CAN_TI1R (read-write) $" CAN-CAN_TI1R @ hex. CAN-CAN_TI1R 1b. ;
: CAN-CAN_TDT1R. ." CAN-CAN_TDT1R (read-write) $" CAN-CAN_TDT1R @ hex. CAN-CAN_TDT1R 1b. ;
: CAN-CAN_TDL1R. ." CAN-CAN_TDL1R (read-write) $" CAN-CAN_TDL1R @ hex. CAN-CAN_TDL1R 1b. ;
: CAN-CAN_TDH1R. ." CAN-CAN_TDH1R (read-write) $" CAN-CAN_TDH1R @ hex. CAN-CAN_TDH1R 1b. ;
: CAN-CAN_TI2R. ." CAN-CAN_TI2R (read-write) $" CAN-CAN_TI2R @ hex. CAN-CAN_TI2R 1b. ;
: CAN-CAN_TDT2R. ." CAN-CAN_TDT2R (read-write) $" CAN-CAN_TDT2R @ hex. CAN-CAN_TDT2R 1b. ;
: CAN-CAN_TDL2R. ." CAN-CAN_TDL2R (read-write) $" CAN-CAN_TDL2R @ hex. CAN-CAN_TDL2R 1b. ;
: CAN-CAN_TDH2R. ." CAN-CAN_TDH2R (read-write) $" CAN-CAN_TDH2R @ hex. CAN-CAN_TDH2R 1b. ;
: CAN-CAN_RI0R. ." CAN-CAN_RI0R (read-only) $" CAN-CAN_RI0R @ hex. CAN-CAN_RI0R 1b. ;
: CAN-CAN_RDT0R. ." CAN-CAN_RDT0R (read-only) $" CAN-CAN_RDT0R @ hex. CAN-CAN_RDT0R 1b. ;
: CAN-CAN_RDL0R. ." CAN-CAN_RDL0R (read-only) $" CAN-CAN_RDL0R @ hex. CAN-CAN_RDL0R 1b. ;
: CAN-CAN_RDH0R. ." CAN-CAN_RDH0R (read-only) $" CAN-CAN_RDH0R @ hex. CAN-CAN_RDH0R 1b. ;
: CAN-CAN_RI1R. ." CAN-CAN_RI1R (read-only) $" CAN-CAN_RI1R @ hex. CAN-CAN_RI1R 1b. ;
: CAN-CAN_RDT1R. ." CAN-CAN_RDT1R (read-only) $" CAN-CAN_RDT1R @ hex. CAN-CAN_RDT1R 1b. ;
: CAN-CAN_RDL1R. ." CAN-CAN_RDL1R (read-only) $" CAN-CAN_RDL1R @ hex. CAN-CAN_RDL1R 1b. ;
: CAN-CAN_RDH1R. ." CAN-CAN_RDH1R (read-only) $" CAN-CAN_RDH1R @ hex. CAN-CAN_RDH1R 1b. ;
: CAN-CAN_FMR. ." CAN-CAN_FMR (read-write) $" CAN-CAN_FMR @ hex. CAN-CAN_FMR 1b. ;
: CAN-CAN_FM1R. ." CAN-CAN_FM1R (read-write) $" CAN-CAN_FM1R @ hex. CAN-CAN_FM1R 1b. ;
: CAN-CAN_FS1R. ." CAN-CAN_FS1R (read-write) $" CAN-CAN_FS1R @ hex. CAN-CAN_FS1R 1b. ;
: CAN-CAN_FFA1R. ." CAN-CAN_FFA1R (read-write) $" CAN-CAN_FFA1R @ hex. CAN-CAN_FFA1R 1b. ;
: CAN-CAN_FA1R. ." CAN-CAN_FA1R (read-write) $" CAN-CAN_FA1R @ hex. CAN-CAN_FA1R 1b. ;
: CAN-F0R1. ." CAN-F0R1 (read-write) $" CAN-F0R1 @ hex. CAN-F0R1 1b. ;
: CAN-F0R2. ." CAN-F0R2 (read-write) $" CAN-F0R2 @ hex. CAN-F0R2 1b. ;
: CAN-F1R1. ." CAN-F1R1 (read-write) $" CAN-F1R1 @ hex. CAN-F1R1 1b. ;
: CAN-F1R2. ." CAN-F1R2 (read-write) $" CAN-F1R2 @ hex. CAN-F1R2 1b. ;
: CAN-F2R1. ." CAN-F2R1 (read-write) $" CAN-F2R1 @ hex. CAN-F2R1 1b. ;
: CAN-F2R2. ." CAN-F2R2 (read-write) $" CAN-F2R2 @ hex. CAN-F2R2 1b. ;
: CAN-F3R1. ." CAN-F3R1 (read-write) $" CAN-F3R1 @ hex. CAN-F3R1 1b. ;
: CAN-F3R2. ." CAN-F3R2 (read-write) $" CAN-F3R2 @ hex. CAN-F3R2 1b. ;
: CAN-F4R1. ." CAN-F4R1 (read-write) $" CAN-F4R1 @ hex. CAN-F4R1 1b. ;
: CAN-F4R2. ." CAN-F4R2 (read-write) $" CAN-F4R2 @ hex. CAN-F4R2 1b. ;
: CAN-F5R1. ." CAN-F5R1 (read-write) $" CAN-F5R1 @ hex. CAN-F5R1 1b. ;
: CAN-F5R2. ." CAN-F5R2 (read-write) $" CAN-F5R2 @ hex. CAN-F5R2 1b. ;
: CAN-F6R1. ." CAN-F6R1 (read-write) $" CAN-F6R1 @ hex. CAN-F6R1 1b. ;
: CAN-F6R2. ." CAN-F6R2 (read-write) $" CAN-F6R2 @ hex. CAN-F6R2 1b. ;
: CAN-F7R1. ." CAN-F7R1 (read-write) $" CAN-F7R1 @ hex. CAN-F7R1 1b. ;
: CAN-F7R2. ." CAN-F7R2 (read-write) $" CAN-F7R2 @ hex. CAN-F7R2 1b. ;
: CAN-F8R1. ." CAN-F8R1 (read-write) $" CAN-F8R1 @ hex. CAN-F8R1 1b. ;
: CAN-F8R2. ." CAN-F8R2 (read-write) $" CAN-F8R2 @ hex. CAN-F8R2 1b. ;
: CAN-F9R1. ." CAN-F9R1 (read-write) $" CAN-F9R1 @ hex. CAN-F9R1 1b. ;
: CAN-F9R2. ." CAN-F9R2 (read-write) $" CAN-F9R2 @ hex. CAN-F9R2 1b. ;
: CAN-F10R1. ." CAN-F10R1 (read-write) $" CAN-F10R1 @ hex. CAN-F10R1 1b. ;
: CAN-F10R2. ." CAN-F10R2 (read-write) $" CAN-F10R2 @ hex. CAN-F10R2 1b. ;
: CAN-F11R1. ." CAN-F11R1 (read-write) $" CAN-F11R1 @ hex. CAN-F11R1 1b. ;
: CAN-F11R2. ." CAN-F11R2 (read-write) $" CAN-F11R2 @ hex. CAN-F11R2 1b. ;
: CAN-F12R1. ." CAN-F12R1 (read-write) $" CAN-F12R1 @ hex. CAN-F12R1 1b. ;
: CAN-F12R2. ." CAN-F12R2 (read-write) $" CAN-F12R2 @ hex. CAN-F12R2 1b. ;
: CAN-F13R1. ." CAN-F13R1 (read-write) $" CAN-F13R1 @ hex. CAN-F13R1 1b. ;
: CAN-F13R2. ." CAN-F13R2 (read-write) $" CAN-F13R2 @ hex. CAN-F13R2 1b. ;
: CAN.
CAN-CAN_MCR.
CAN-CAN_MSR.
CAN-CAN_TSR.
CAN-CAN_RF0R.
CAN-CAN_RF1R.
CAN-CAN_IER.
CAN-CAN_ESR.
CAN-CAN_BTR.
CAN-CAN_TI0R.
CAN-CAN_TDT0R.
CAN-CAN_TDL0R.
CAN-CAN_TDH0R.
CAN-CAN_TI1R.
CAN-CAN_TDT1R.
CAN-CAN_TDL1R.
CAN-CAN_TDH1R.
CAN-CAN_TI2R.
CAN-CAN_TDT2R.
CAN-CAN_TDL2R.
CAN-CAN_TDH2R.
CAN-CAN_RI0R.
CAN-CAN_RDT0R.
CAN-CAN_RDL0R.
CAN-CAN_RDH0R.
CAN-CAN_RI1R.
CAN-CAN_RDT1R.
CAN-CAN_RDL1R.
CAN-CAN_RDH1R.
CAN-CAN_FMR.
CAN-CAN_FM1R.
CAN-CAN_FS1R.
CAN-CAN_FFA1R.
CAN-CAN_FA1R.
CAN-F0R1.
CAN-F0R2.
CAN-F1R1.
CAN-F1R2.
CAN-F2R1.
CAN-F2R2.
CAN-F3R1.
CAN-F3R2.
CAN-F4R1.
CAN-F4R2.
CAN-F5R1.
CAN-F5R2.
CAN-F6R1.
CAN-F6R2.
CAN-F7R1.
CAN-F7R2.
CAN-F8R1.
CAN-F8R2.
CAN-F9R1.
CAN-F9R2.
CAN-F10R1.
CAN-F10R2.
CAN-F11R1.
CAN-F11R2.
CAN-F12R1.
CAN-F12R2.
CAN-F13R1.
CAN-F13R2.
;

$40007400 constant DAC ( Digital to analog converter ) 
DAC $0 + constant DAC-CR ( Control register DAC_CR ) 
DAC $4 + constant DAC-SWTRIGR ( DAC software trigger register  DAC_SWTRIGR ) 
DAC $8 + constant DAC-DHR12R1 ( DAC channel1 12-bit right-aligned data  holding registerDAC_DHR12R1 ) 
DAC $C + constant DAC-DHR12L1 ( DAC channel1 12-bit left aligned data  holding register DAC_DHR12L1 ) 
DAC $10 + constant DAC-DHR8R1 ( DAC channel1 8-bit right aligned data  holding register DAC_DHR8R1 ) 
DAC $14 + constant DAC-DHR12R2 ( DAC channel2 12-bit right aligned data  holding register DAC_DHR12R2 ) 
DAC $18 + constant DAC-DHR12L2 ( DAC channel2 12-bit left aligned data  holding register DAC_DHR12L2 ) 
DAC $1C + constant DAC-DHR8R2 ( DAC channel2 8-bit right-aligned data  holding register DAC_DHR8R2 ) 
DAC $20 + constant DAC-DHR12RD ( Dual DAC 12-bit right-aligned data holding  register DAC_DHR12RD, Bits 31:28 Reserved, Bits 15:12  Reserved ) 
DAC $24 + constant DAC-DHR12LD ( DUAL DAC 12-bit left aligned data holding  register DAC_DHR12LD, Bits 19:16 Reserved, Bits 3:0  Reserved ) 
DAC $28 + constant DAC-DHR8RD ( DUAL DAC 8-bit right aligned data holding  register DAC_DHR8RD, Bits 31:16 Reserved ) 
DAC $2C + constant DAC-DOR1 ( DAC channel1 data output register  DAC_DOR1 ) 
DAC $30 + constant DAC-DOR2 ( DAC channel2 data output register  DAC_DOR2 ) 
: DAC-CR. ." DAC-CR (read-write) $" DAC-CR @ hex. DAC-CR 1b. ;
: DAC-SWTRIGR. ." DAC-SWTRIGR (write-only) $" DAC-SWTRIGR @ hex. DAC-SWTRIGR 1b. ;
: DAC-DHR12R1. ." DAC-DHR12R1 (read-write) $" DAC-DHR12R1 @ hex. DAC-DHR12R1 1b. ;
: DAC-DHR12L1. ." DAC-DHR12L1 (read-write) $" DAC-DHR12L1 @ hex. DAC-DHR12L1 1b. ;
: DAC-DHR8R1. ." DAC-DHR8R1 (read-write) $" DAC-DHR8R1 @ hex. DAC-DHR8R1 1b. ;
: DAC-DHR12R2. ." DAC-DHR12R2 (read-write) $" DAC-DHR12R2 @ hex. DAC-DHR12R2 1b. ;
: DAC-DHR12L2. ." DAC-DHR12L2 (read-write) $" DAC-DHR12L2 @ hex. DAC-DHR12L2 1b. ;
: DAC-DHR8R2. ." DAC-DHR8R2 (read-write) $" DAC-DHR8R2 @ hex. DAC-DHR8R2 1b. ;
: DAC-DHR12RD. ." DAC-DHR12RD (read-write) $" DAC-DHR12RD @ hex. DAC-DHR12RD 1b. ;
: DAC-DHR12LD. ." DAC-DHR12LD (read-write) $" DAC-DHR12LD @ hex. DAC-DHR12LD 1b. ;
: DAC-DHR8RD. ." DAC-DHR8RD (read-write) $" DAC-DHR8RD @ hex. DAC-DHR8RD 1b. ;
: DAC-DOR1. ." DAC-DOR1 (read-only) $" DAC-DOR1 @ hex. DAC-DOR1 1b. ;
: DAC-DOR2. ." DAC-DOR2 (read-only) $" DAC-DOR2 @ hex. DAC-DOR2 1b. ;
: DAC.
DAC-CR.
DAC-SWTRIGR.
DAC-DHR12R1.
DAC-DHR12L1.
DAC-DHR8R1.
DAC-DHR12R2.
DAC-DHR12L2.
DAC-DHR8R2.
DAC-DHR12RD.
DAC-DHR12LD.
DAC-DHR8RD.
DAC-DOR1.
DAC-DOR2.
;

$E0042000 constant DBG ( Debug support ) 
DBG $0 + constant DBG-IDCODE ( DBGMCU_IDCODE ) 
DBG $4 + constant DBG-CR ( DBGMCU_CR ) 
: DBG-IDCODE. ." DBG-IDCODE (read-only) $" DBG-IDCODE @ hex. DBG-IDCODE 1b. ;
: DBG-CR. ." DBG-CR (read-write) $" DBG-CR @ hex. DBG-CR 1b. ;
: DBG.
DBG-IDCODE.
DBG-CR.
;

$40004C00 constant UART4 ( Universal asynchronous receiver  transmitter ) 
UART4 $0 + constant UART4-SR ( UART4_SR ) 
UART4 $4 + constant UART4-DR ( UART4_DR ) 
UART4 $8 + constant UART4-BRR ( UART4_BRR ) 
UART4 $C + constant UART4-CR1 ( UART4_CR1 ) 
UART4 $10 + constant UART4-CR2 ( UART4_CR2 ) 
UART4 $14 + constant UART4-CR3 ( UART4_CR3 ) 
: UART4-SR. ." UART4-SR () $" UART4-SR @ hex. UART4-SR 1b. ;
: UART4-DR. ." UART4-DR (read-write) $" UART4-DR @ hex. UART4-DR 1b. ;
: UART4-BRR. ." UART4-BRR (read-write) $" UART4-BRR @ hex. UART4-BRR 1b. ;
: UART4-CR1. ." UART4-CR1 (read-write) $" UART4-CR1 @ hex. UART4-CR1 1b. ;
: UART4-CR2. ." UART4-CR2 (read-write) $" UART4-CR2 @ hex. UART4-CR2 1b. ;
: UART4-CR3. ." UART4-CR3 (read-write) $" UART4-CR3 @ hex. UART4-CR3 1b. ;
: UART4.
UART4-SR.
UART4-DR.
UART4-BRR.
UART4-CR1.
UART4-CR2.
UART4-CR3.
;

$40005000 constant UART5 ( Universal asynchronous receiver  transmitter ) 
UART5 $0 + constant UART5-SR ( UART4_SR ) 
UART5 $4 + constant UART5-DR ( UART4_DR ) 
UART5 $8 + constant UART5-BRR ( UART4_BRR ) 
UART5 $C + constant UART5-CR1 ( UART4_CR1 ) 
UART5 $10 + constant UART5-CR2 ( UART4_CR2 ) 
UART5 $14 + constant UART5-CR3 ( UART4_CR3 ) 
: UART5-SR. ." UART5-SR () $" UART5-SR @ hex. UART5-SR 1b. ;
: UART5-DR. ." UART5-DR (read-write) $" UART5-DR @ hex. UART5-DR 1b. ;
: UART5-BRR. ." UART5-BRR (read-write) $" UART5-BRR @ hex. UART5-BRR 1b. ;
: UART5-CR1. ." UART5-CR1 (read-write) $" UART5-CR1 @ hex. UART5-CR1 1b. ;
: UART5-CR2. ." UART5-CR2 (read-write) $" UART5-CR2 @ hex. UART5-CR2 1b. ;
: UART5-CR3. ." UART5-CR3 (read-write) $" UART5-CR3 @ hex. UART5-CR3 1b. ;
: UART5.
UART5-SR.
UART5-DR.
UART5-BRR.
UART5-CR1.
UART5-CR2.
UART5-CR3.
;

$40023000 constant CRC ( CRC calculation unit ) 
CRC $0 + constant CRC-DR ( Data register ) 
CRC $4 + constant CRC-IDR ( Independent Data register ) 
CRC $8 + constant CRC-CR ( Control register ) 
: CRC-DR. ." CRC-DR (read-write) $" CRC-DR @ hex. CRC-DR 1b. ;
: CRC-IDR. ." CRC-IDR (read-write) $" CRC-IDR @ hex. CRC-IDR 1b. ;
: CRC-CR. ." CRC-CR (write-only) $" CRC-CR @ hex. CRC-CR 1b. ;
: CRC.
CRC-DR.
CRC-IDR.
CRC-CR.
;

$40022000 constant FLASH ( FLASH ) 
FLASH $0 + constant FLASH-ACR ( Flash access control register ) 
FLASH $4 + constant FLASH-KEYR ( Flash key register ) 
FLASH $8 + constant FLASH-OPTKEYR ( Flash option key register ) 
FLASH $C + constant FLASH-SR ( Status register ) 
FLASH $10 + constant FLASH-CR ( Control register ) 
FLASH $14 + constant FLASH-AR ( Flash address register ) 
FLASH $1C + constant FLASH-OBR ( Option byte register ) 
FLASH $20 + constant FLASH-WRPR ( Write protection register ) 
: FLASH-ACR. ." FLASH-ACR () $" FLASH-ACR @ hex. FLASH-ACR 1b. ;
: FLASH-KEYR. ." FLASH-KEYR (write-only) $" FLASH-KEYR @ hex. FLASH-KEYR 1b. ;
: FLASH-OPTKEYR. ." FLASH-OPTKEYR (write-only) $" FLASH-OPTKEYR @ hex. FLASH-OPTKEYR 1b. ;
: FLASH-SR. ." FLASH-SR () $" FLASH-SR @ hex. FLASH-SR 1b. ;
: FLASH-CR. ." FLASH-CR (read-write) $" FLASH-CR @ hex. FLASH-CR 1b. ;
: FLASH-AR. ." FLASH-AR (write-only) $" FLASH-AR @ hex. FLASH-AR 1b. ;
: FLASH-OBR. ." FLASH-OBR (read-only) $" FLASH-OBR @ hex. FLASH-OBR 1b. ;
: FLASH-WRPR. ." FLASH-WRPR (read-only) $" FLASH-WRPR @ hex. FLASH-WRPR 1b. ;
: FLASH.
FLASH-ACR.
FLASH-KEYR.
FLASH-OPTKEYR.
FLASH-SR.
FLASH-CR.
FLASH-AR.
FLASH-OBR.
FLASH-WRPR.
;

$E000E000 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $4 + constant NVIC-ICTR ( Interrupt Controller Type  Register ) 
NVIC $F00 + constant NVIC-STIR ( Software Triggered Interrupt  Register ) 
NVIC $100 + constant NVIC-ISER0 ( Interrupt Set-Enable Register ) 
NVIC $104 + constant NVIC-ISER1 ( Interrupt Set-Enable Register ) 
NVIC $180 + constant NVIC-ICER0 ( Interrupt Clear-Enable  Register ) 
NVIC $184 + constant NVIC-ICER1 ( Interrupt Clear-Enable  Register ) 
NVIC $200 + constant NVIC-ISPR0 ( Interrupt Set-Pending Register ) 
NVIC $204 + constant NVIC-ISPR1 ( Interrupt Set-Pending Register ) 
NVIC $280 + constant NVIC-ICPR0 ( Interrupt Clear-Pending  Register ) 
NVIC $284 + constant NVIC-ICPR1 ( Interrupt Clear-Pending  Register ) 
NVIC $300 + constant NVIC-IABR0 ( Interrupt Active Bit Register ) 
NVIC $304 + constant NVIC-IABR1 ( Interrupt Active Bit Register ) 
NVIC $400 + constant NVIC-IPR0 ( Interrupt Priority Register ) 
NVIC $404 + constant NVIC-IPR1 ( Interrupt Priority Register ) 
NVIC $408 + constant NVIC-IPR2 ( Interrupt Priority Register ) 
NVIC $40C + constant NVIC-IPR3 ( Interrupt Priority Register ) 
NVIC $410 + constant NVIC-IPR4 ( Interrupt Priority Register ) 
NVIC $414 + constant NVIC-IPR5 ( Interrupt Priority Register ) 
NVIC $418 + constant NVIC-IPR6 ( Interrupt Priority Register ) 
NVIC $41C + constant NVIC-IPR7 ( Interrupt Priority Register ) 
NVIC $420 + constant NVIC-IPR8 ( Interrupt Priority Register ) 
NVIC $424 + constant NVIC-IPR9 ( Interrupt Priority Register ) 
NVIC $428 + constant NVIC-IPR10 ( Interrupt Priority Register ) 
NVIC $42C + constant NVIC-IPR11 ( Interrupt Priority Register ) 
NVIC $430 + constant NVIC-IPR12 ( Interrupt Priority Register ) 
NVIC $434 + constant NVIC-IPR13 ( Interrupt Priority Register ) 
NVIC $438 + constant NVIC-IPR14 ( Interrupt Priority Register ) 
: NVIC-ICTR. ." NVIC-ICTR (read-only) $" NVIC-ICTR @ hex. NVIC-ICTR 1b. ;
: NVIC-STIR. ." NVIC-STIR (write-only) $" NVIC-STIR @ hex. NVIC-STIR 1b. ;
: NVIC-ISER0. ." NVIC-ISER0 (read-write) $" NVIC-ISER0 @ hex. NVIC-ISER0 1b. ;
: NVIC-ISER1. ." NVIC-ISER1 (read-write) $" NVIC-ISER1 @ hex. NVIC-ISER1 1b. ;
: NVIC-ICER0. ." NVIC-ICER0 (read-write) $" NVIC-ICER0 @ hex. NVIC-ICER0 1b. ;
: NVIC-ICER1. ." NVIC-ICER1 (read-write) $" NVIC-ICER1 @ hex. NVIC-ICER1 1b. ;
: NVIC-ISPR0. ." NVIC-ISPR0 (read-write) $" NVIC-ISPR0 @ hex. NVIC-ISPR0 1b. ;
: NVIC-ISPR1. ." NVIC-ISPR1 (read-write) $" NVIC-ISPR1 @ hex. NVIC-ISPR1 1b. ;
: NVIC-ICPR0. ." NVIC-ICPR0 (read-write) $" NVIC-ICPR0 @ hex. NVIC-ICPR0 1b. ;
: NVIC-ICPR1. ." NVIC-ICPR1 (read-write) $" NVIC-ICPR1 @ hex. NVIC-ICPR1 1b. ;
: NVIC-IABR0. ." NVIC-IABR0 (read-only) $" NVIC-IABR0 @ hex. NVIC-IABR0 1b. ;
: NVIC-IABR1. ." NVIC-IABR1 (read-only) $" NVIC-IABR1 @ hex. NVIC-IABR1 1b. ;
: NVIC-IPR0. ." NVIC-IPR0 (read-write) $" NVIC-IPR0 @ hex. NVIC-IPR0 1b. ;
: NVIC-IPR1. ." NVIC-IPR1 (read-write) $" NVIC-IPR1 @ hex. NVIC-IPR1 1b. ;
: NVIC-IPR2. ." NVIC-IPR2 (read-write) $" NVIC-IPR2 @ hex. NVIC-IPR2 1b. ;
: NVIC-IPR3. ." NVIC-IPR3 (read-write) $" NVIC-IPR3 @ hex. NVIC-IPR3 1b. ;
: NVIC-IPR4. ." NVIC-IPR4 (read-write) $" NVIC-IPR4 @ hex. NVIC-IPR4 1b. ;
: NVIC-IPR5. ." NVIC-IPR5 (read-write) $" NVIC-IPR5 @ hex. NVIC-IPR5 1b. ;
: NVIC-IPR6. ." NVIC-IPR6 (read-write) $" NVIC-IPR6 @ hex. NVIC-IPR6 1b. ;
: NVIC-IPR7. ." NVIC-IPR7 (read-write) $" NVIC-IPR7 @ hex. NVIC-IPR7 1b. ;
: NVIC-IPR8. ." NVIC-IPR8 (read-write) $" NVIC-IPR8 @ hex. NVIC-IPR8 1b. ;
: NVIC-IPR9. ." NVIC-IPR9 (read-write) $" NVIC-IPR9 @ hex. NVIC-IPR9 1b. ;
: NVIC-IPR10. ." NVIC-IPR10 (read-write) $" NVIC-IPR10 @ hex. NVIC-IPR10 1b. ;
: NVIC-IPR11. ." NVIC-IPR11 (read-write) $" NVIC-IPR11 @ hex. NVIC-IPR11 1b. ;
: NVIC-IPR12. ." NVIC-IPR12 (read-write) $" NVIC-IPR12 @ hex. NVIC-IPR12 1b. ;
: NVIC-IPR13. ." NVIC-IPR13 (read-write) $" NVIC-IPR13 @ hex. NVIC-IPR13 1b. ;
: NVIC-IPR14. ." NVIC-IPR14 (read-write) $" NVIC-IPR14 @ hex. NVIC-IPR14 1b. ;
: NVIC.
NVIC-ICTR.
NVIC-STIR.
NVIC-ISER0.
NVIC-ISER1.
NVIC-ICER0.
NVIC-ICER1.
NVIC-ISPR0.
NVIC-ISPR1.
NVIC-ICPR0.
NVIC-ICPR1.
NVIC-IABR0.
NVIC-IABR1.
NVIC-IPR0.
NVIC-IPR1.
NVIC-IPR2.
NVIC-IPR3.
NVIC-IPR4.
NVIC-IPR5.
NVIC-IPR6.
NVIC-IPR7.
NVIC-IPR8.
NVIC-IPR9.
NVIC-IPR10.
NVIC-IPR11.
NVIC-IPR12.
NVIC-IPR13.
NVIC-IPR14.
;

$40005C00 constant USB ( Universal serial bus full-speed device  interface ) 
USB $0 + constant USB-EP0R ( endpoint 0 register ) 
USB $4 + constant USB-EP1R ( endpoint 1 register ) 
USB $8 + constant USB-EP2R ( endpoint 2 register ) 
USB $C + constant USB-EP3R ( endpoint 3 register ) 
USB $10 + constant USB-EP4R ( endpoint 4 register ) 
USB $14 + constant USB-EP5R ( endpoint 5 register ) 
USB $18 + constant USB-EP6R ( endpoint 6 register ) 
USB $1C + constant USB-EP7R ( endpoint 7 register ) 
USB $40 + constant USB-CNTR ( control register ) 
USB $44 + constant USB-ISTR ( interrupt status register ) 
USB $48 + constant USB-FNR ( frame number register ) 
USB $4C + constant USB-DADDR ( device address ) 
USB $50 + constant USB-BTABLE ( Buffer table address ) 
: USB-EP0R. ." USB-EP0R (read-write) $" USB-EP0R @ hex. USB-EP0R 1b. ;
: USB-EP1R. ." USB-EP1R (read-write) $" USB-EP1R @ hex. USB-EP1R 1b. ;
: USB-EP2R. ." USB-EP2R (read-write) $" USB-EP2R @ hex. USB-EP2R 1b. ;
: USB-EP3R. ." USB-EP3R (read-write) $" USB-EP3R @ hex. USB-EP3R 1b. ;
: USB-EP4R. ." USB-EP4R (read-write) $" USB-EP4R @ hex. USB-EP4R 1b. ;
: USB-EP5R. ." USB-EP5R (read-write) $" USB-EP5R @ hex. USB-EP5R 1b. ;
: USB-EP6R. ." USB-EP6R (read-write) $" USB-EP6R @ hex. USB-EP6R 1b. ;
: USB-EP7R. ." USB-EP7R (read-write) $" USB-EP7R @ hex. USB-EP7R 1b. ;
: USB-CNTR. ." USB-CNTR (read-write) $" USB-CNTR @ hex. USB-CNTR 1b. ;
: USB-ISTR. ." USB-ISTR (read-write) $" USB-ISTR @ hex. USB-ISTR 1b. ;
: USB-FNR. ." USB-FNR (read-only) $" USB-FNR @ hex. USB-FNR 1b. ;
: USB-DADDR. ." USB-DADDR (read-write) $" USB-DADDR @ hex. USB-DADDR 1b. ;
: USB-BTABLE. ." USB-BTABLE (read-write) $" USB-BTABLE @ hex. USB-BTABLE 1b. ;
: USB.
USB-EP0R.
USB-EP1R.
USB-EP2R.
USB-EP3R.
USB-EP4R.
USB-EP5R.
USB-EP6R.
USB-EP7R.
USB-CNTR.
USB-ISTR.
USB-FNR.
USB-DADDR.
USB-BTABLE.
;


compiletoram
