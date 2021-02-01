\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

