\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM10-CR1. ." TIM10-CR1 (read-write) $" TIM10-CR1 @ hex. TIM10-CR1 1b. ;
: TIM10-CR2. ." TIM10-CR2 (read-write) $" TIM10-CR2 @ hex. TIM10-CR2 1b. ;
: TIM10-DIER. ." TIM10-DIER (read-write) $" TIM10-DIER @ hex. TIM10-DIER 1b. ;
: TIM10-SR. ." TIM10-SR (read-write) $" TIM10-SR @ hex. TIM10-SR 1b. ;
: TIM10-EGR. ." TIM10-EGR (write-only) $" TIM10-EGR @ hex. TIM10-EGR 1b. ;
: TIM10-CCMR1_Output. ." TIM10-CCMR1_Output (read-write) $" TIM10-CCMR1_Output @ hex. TIM10-CCMR1_Output 1b. ;
: TIM10-CCMR1_Input. ." TIM10-CCMR1_Input (read-write) $" TIM10-CCMR1_Input @ hex. TIM10-CCMR1_Input 1b. ;
: TIM10-CCER. ." TIM10-CCER (read-write) $" TIM10-CCER @ hex. TIM10-CCER 1b. ;
: TIM10-CNT. ." TIM10-CNT (read-write) $" TIM10-CNT @ hex. TIM10-CNT 1b. ;
: TIM10-PSC. ." TIM10-PSC (read-write) $" TIM10-PSC @ hex. TIM10-PSC 1b. ;
: TIM10-ARR. ." TIM10-ARR (read-write) $" TIM10-ARR @ hex. TIM10-ARR 1b. ;
: TIM10-CCR1. ." TIM10-CCR1 (read-write) $" TIM10-CCR1 @ hex. TIM10-CCR1 1b. ;
: TIM10.
TIM10-CR1.
TIM10-CR2.
TIM10-DIER.
TIM10-SR.
TIM10-EGR.
TIM10-CCMR1_Output.
TIM10-CCMR1_Input.
TIM10-CCER.
TIM10-CNT.
TIM10-PSC.
TIM10-ARR.
TIM10-CCR1.
;

