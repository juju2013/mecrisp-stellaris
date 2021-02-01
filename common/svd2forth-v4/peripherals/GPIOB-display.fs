\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

