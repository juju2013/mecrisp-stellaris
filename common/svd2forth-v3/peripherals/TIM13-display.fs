\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM13-CR1. ." TIM13-CR1 (read-write) $" TIM13-CR1 @ hex. TIM13-CR1 1b. ;
: TIM13-CR2. ." TIM13-CR2 (read-write) $" TIM13-CR2 @ hex. TIM13-CR2 1b. ;
: TIM13-DIER. ." TIM13-DIER (read-write) $" TIM13-DIER @ hex. TIM13-DIER 1b. ;
: TIM13-SR. ." TIM13-SR (read-write) $" TIM13-SR @ hex. TIM13-SR 1b. ;
: TIM13-EGR. ." TIM13-EGR (write-only) $" TIM13-EGR @ hex. TIM13-EGR 1b. ;
: TIM13-CCMR1_Output. ." TIM13-CCMR1_Output (read-write) $" TIM13-CCMR1_Output @ hex. TIM13-CCMR1_Output 1b. ;
: TIM13-CCMR1_Input. ." TIM13-CCMR1_Input (read-write) $" TIM13-CCMR1_Input @ hex. TIM13-CCMR1_Input 1b. ;
: TIM13-CCER. ." TIM13-CCER (read-write) $" TIM13-CCER @ hex. TIM13-CCER 1b. ;
: TIM13-CNT. ." TIM13-CNT (read-write) $" TIM13-CNT @ hex. TIM13-CNT 1b. ;
: TIM13-PSC. ." TIM13-PSC (read-write) $" TIM13-PSC @ hex. TIM13-PSC 1b. ;
: TIM13-ARR. ." TIM13-ARR (read-write) $" TIM13-ARR @ hex. TIM13-ARR 1b. ;
: TIM13-CCR1. ." TIM13-CCR1 (read-write) $" TIM13-CCR1 @ hex. TIM13-CCR1 1b. ;
: TIM13.
TIM13-CR1.
TIM13-CR2.
TIM13-DIER.
TIM13-SR.
TIM13-EGR.
TIM13-CCMR1_Output.
TIM13-CCMR1_Input.
TIM13-CCER.
TIM13-CNT.
TIM13-PSC.
TIM13-ARR.
TIM13-CCR1.
;

