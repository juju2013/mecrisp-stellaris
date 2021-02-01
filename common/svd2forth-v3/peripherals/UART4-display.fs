\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: UART4-SR. ." UART4-SR () $" UART4-SR @ hex. UART4-SR 1b. ;
: UART4-DR. ." UART4-DR (read-write) $" UART4-DR @ hex. UART4-DR 1b. ;
: UART4-BRR. ." UART4-BRR (read-write) $" UART4-BRR @ hex. UART4-BRR 1b. ;
: UART4-CR1. ." UART4-CR1 (read-write) $" UART4-CR1 @ hex. UART4-CR1 1b. ;
: UART4-CR2. ." UART4-CR2 (read-write) $" UART4-CR2 @ hex. UART4-CR2 1b. ;
: UART4-CR3. ." UART4-CR3 (read-write) $" UART4-CR3 @ hex. UART4-CR3 1b. ;
: UART4.
UART4-SR.
UART4-DR.
UART4-BRR.
UART4-CR1.
UART4-CR2.
UART4-CR3.
;

