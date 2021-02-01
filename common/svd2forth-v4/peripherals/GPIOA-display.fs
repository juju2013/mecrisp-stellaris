\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

