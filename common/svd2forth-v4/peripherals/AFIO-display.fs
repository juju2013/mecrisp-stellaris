\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

