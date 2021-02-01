\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM11-CR1. ." TIM11-CR1 (read-write) $" TIM11-CR1 @ hex. TIM11-CR1 1b. ;
: TIM11-CR2. ." TIM11-CR2 (read-write) $" TIM11-CR2 @ hex. TIM11-CR2 1b. ;
: TIM11-DIER. ." TIM11-DIER (read-write) $" TIM11-DIER @ hex. TIM11-DIER 1b. ;
: TIM11-SR. ." TIM11-SR (read-write) $" TIM11-SR @ hex. TIM11-SR 1b. ;
: TIM11-EGR. ." TIM11-EGR (write-only) $" TIM11-EGR @ hex. TIM11-EGR 1b. ;
: TIM11-CCMR1_Output. ." TIM11-CCMR1_Output (read-write) $" TIM11-CCMR1_Output @ hex. TIM11-CCMR1_Output 1b. ;
: TIM11-CCMR1_Input. ." TIM11-CCMR1_Input (read-write) $" TIM11-CCMR1_Input @ hex. TIM11-CCMR1_Input 1b. ;
: TIM11-CCER. ." TIM11-CCER (read-write) $" TIM11-CCER @ hex. TIM11-CCER 1b. ;
: TIM11-CNT. ." TIM11-CNT (read-write) $" TIM11-CNT @ hex. TIM11-CNT 1b. ;
: TIM11-PSC. ." TIM11-PSC (read-write) $" TIM11-PSC @ hex. TIM11-PSC 1b. ;
: TIM11-ARR. ." TIM11-ARR (read-write) $" TIM11-ARR @ hex. TIM11-ARR 1b. ;
: TIM11-CCR1. ." TIM11-CCR1 (read-write) $" TIM11-CCR1 @ hex. TIM11-CCR1 1b. ;
: TIM11.
TIM11-CR1.
TIM11-CR2.
TIM11-DIER.
TIM11-SR.
TIM11-EGR.
TIM11-CCMR1_Output.
TIM11-CCMR1_Input.
TIM11-CCER.
TIM11-CNT.
TIM11-PSC.
TIM11-ARR.
TIM11-CCR1.
;

