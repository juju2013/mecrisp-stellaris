\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM7-CR1. ." TIM7-CR1 (read-write) $" TIM7-CR1 @ hex. TIM7-CR1 1b. ;
: TIM7-CR2. ." TIM7-CR2 (read-write) $" TIM7-CR2 @ hex. TIM7-CR2 1b. ;
: TIM7-DIER. ." TIM7-DIER (read-write) $" TIM7-DIER @ hex. TIM7-DIER 1b. ;
: TIM7-SR. ." TIM7-SR (read-write) $" TIM7-SR @ hex. TIM7-SR 1b. ;
: TIM7-EGR. ." TIM7-EGR (write-only) $" TIM7-EGR @ hex. TIM7-EGR 1b. ;
: TIM7-CNT. ." TIM7-CNT (read-write) $" TIM7-CNT @ hex. TIM7-CNT 1b. ;
: TIM7-PSC. ." TIM7-PSC (read-write) $" TIM7-PSC @ hex. TIM7-PSC 1b. ;
: TIM7-ARR. ." TIM7-ARR (read-write) $" TIM7-ARR @ hex. TIM7-ARR 1b. ;
: TIM7.
TIM7-CR1.
TIM7-CR2.
TIM7-DIER.
TIM7-SR.
TIM7-EGR.
TIM7-CNT.
TIM7-PSC.
TIM7-ARR.
;

