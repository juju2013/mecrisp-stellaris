\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: UART5-SR. ." UART5-SR () $" UART5-SR @ hex. UART5-SR 1b. ;
: UART5-DR. ." UART5-DR (read-write) $" UART5-DR @ hex. UART5-DR 1b. ;
: UART5-BRR. ." UART5-BRR (read-write) $" UART5-BRR @ hex. UART5-BRR 1b. ;
: UART5-CR1. ." UART5-CR1 (read-write) $" UART5-CR1 @ hex. UART5-CR1 1b. ;
: UART5-CR2. ." UART5-CR2 (read-write) $" UART5-CR2 @ hex. UART5-CR2 1b. ;
: UART5-CR3. ." UART5-CR3 (read-write) $" UART5-CR3 @ hex. UART5-CR3 1b. ;
: UART5.
UART5-SR.
UART5-DR.
UART5-BRR.
UART5-CR1.
UART5-CR2.
UART5-CR3.
;

