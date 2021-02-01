\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

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

