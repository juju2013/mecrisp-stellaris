\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

