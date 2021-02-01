\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: USART3-SR. ." USART3-SR () $" USART3-SR @ hex. USART3-SR 1b. ;
: USART3-DR. ." USART3-DR (read-write) $" USART3-DR @ hex. USART3-DR 1b. ;
: USART3-BRR. ." USART3-BRR (read-write) $" USART3-BRR @ hex. USART3-BRR 1b. ;
: USART3-CR1. ." USART3-CR1 (read-write) $" USART3-CR1 @ hex. USART3-CR1 1b. ;
: USART3-CR2. ." USART3-CR2 (read-write) $" USART3-CR2 @ hex. USART3-CR2 1b. ;
: USART3-CR3. ." USART3-CR3 (read-write) $" USART3-CR3 @ hex. USART3-CR3 1b. ;
: USART3-GTPR. ." USART3-GTPR (read-write) $" USART3-GTPR @ hex. USART3-GTPR 1b. ;
: USART3.
USART3-SR.
USART3-DR.
USART3-BRR.
USART3-CR1.
USART3-CR2.
USART3-CR3.
USART3-GTPR.
;

