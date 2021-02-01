\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

