\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM6-CR1. ." TIM6-CR1 (read-write) $" TIM6-CR1 @ hex. TIM6-CR1 1b. ;
: TIM6-CR2. ." TIM6-CR2 (read-write) $" TIM6-CR2 @ hex. TIM6-CR2 1b. ;
: TIM6-DIER. ." TIM6-DIER (read-write) $" TIM6-DIER @ hex. TIM6-DIER 1b. ;
: TIM6-SR. ." TIM6-SR (read-write) $" TIM6-SR @ hex. TIM6-SR 1b. ;
: TIM6-EGR. ." TIM6-EGR (write-only) $" TIM6-EGR @ hex. TIM6-EGR 1b. ;
: TIM6-CNT. ." TIM6-CNT (read-write) $" TIM6-CNT @ hex. TIM6-CNT 1b. ;
: TIM6-PSC. ." TIM6-PSC (read-write) $" TIM6-PSC @ hex. TIM6-PSC 1b. ;
: TIM6-ARR. ." TIM6-ARR (read-write) $" TIM6-ARR @ hex. TIM6-ARR 1b. ;
: TIM6.
TIM6-CR1.
TIM6-CR2.
TIM6-DIER.
TIM6-SR.
TIM6-EGR.
TIM6-CNT.
TIM6-PSC.
TIM6-ARR.
;

