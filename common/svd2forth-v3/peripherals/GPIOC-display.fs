\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

