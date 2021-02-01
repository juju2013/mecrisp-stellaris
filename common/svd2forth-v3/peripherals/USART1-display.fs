\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: USART1-SR. ." USART1-SR () $" USART1-SR @ hex. USART1-SR 1b. ;
: USART1-DR. ." USART1-DR (read-write) $" USART1-DR @ hex. USART1-DR 1b. ;
: USART1-BRR. ." USART1-BRR (read-write) $" USART1-BRR @ hex. USART1-BRR 1b. ;
: USART1-CR1. ." USART1-CR1 (read-write) $" USART1-CR1 @ hex. USART1-CR1 1b. ;
: USART1-CR2. ." USART1-CR2 (read-write) $" USART1-CR2 @ hex. USART1-CR2 1b. ;
: USART1-CR3. ." USART1-CR3 (read-write) $" USART1-CR3 @ hex. USART1-CR3 1b. ;
: USART1-GTPR. ." USART1-GTPR (read-write) $" USART1-GTPR @ hex. USART1-GTPR 1b. ;
: USART1.
USART1-SR.
USART1-DR.
USART1-BRR.
USART1-CR1.
USART1-CR2.
USART1-CR3.
USART1-GTPR.
;

