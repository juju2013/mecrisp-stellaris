\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

