\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

