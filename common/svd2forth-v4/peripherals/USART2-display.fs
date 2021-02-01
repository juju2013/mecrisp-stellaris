\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: USART2-SR. ." USART2-SR () $" USART2-SR @ hex. USART2-SR 1b. ;
: USART2-DR. ." USART2-DR (read-write) $" USART2-DR @ hex. USART2-DR 1b. ;
: USART2-BRR. ." USART2-BRR (read-write) $" USART2-BRR @ hex. USART2-BRR 1b. ;
: USART2-CR1. ." USART2-CR1 (read-write) $" USART2-CR1 @ hex. USART2-CR1 1b. ;
: USART2-CR2. ." USART2-CR2 (read-write) $" USART2-CR2 @ hex. USART2-CR2 1b. ;
: USART2-CR3. ." USART2-CR3 (read-write) $" USART2-CR3 @ hex. USART2-CR3 1b. ;
: USART2-GTPR. ." USART2-GTPR (read-write) $" USART2-GTPR @ hex. USART2-GTPR 1b. ;
: USART2.
USART2-SR.
USART2-DR.
USART2-BRR.
USART2-CR1.
USART2-CR2.
USART2-CR3.
USART2-GTPR.
;

