\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM14-CR1. ." TIM14-CR1 (read-write) $" TIM14-CR1 @ hex. TIM14-CR1 1b. ;
: TIM14-CR2. ." TIM14-CR2 (read-write) $" TIM14-CR2 @ hex. TIM14-CR2 1b. ;
: TIM14-DIER. ." TIM14-DIER (read-write) $" TIM14-DIER @ hex. TIM14-DIER 1b. ;
: TIM14-SR. ." TIM14-SR (read-write) $" TIM14-SR @ hex. TIM14-SR 1b. ;
: TIM14-EGR. ." TIM14-EGR (write-only) $" TIM14-EGR @ hex. TIM14-EGR 1b. ;
: TIM14-CCMR1_Output. ." TIM14-CCMR1_Output (read-write) $" TIM14-CCMR1_Output @ hex. TIM14-CCMR1_Output 1b. ;
: TIM14-CCMR1_Input. ." TIM14-CCMR1_Input (read-write) $" TIM14-CCMR1_Input @ hex. TIM14-CCMR1_Input 1b. ;
: TIM14-CCER. ." TIM14-CCER (read-write) $" TIM14-CCER @ hex. TIM14-CCER 1b. ;
: TIM14-CNT. ." TIM14-CNT (read-write) $" TIM14-CNT @ hex. TIM14-CNT 1b. ;
: TIM14-PSC. ." TIM14-PSC (read-write) $" TIM14-PSC @ hex. TIM14-PSC 1b. ;
: TIM14-ARR. ." TIM14-ARR (read-write) $" TIM14-ARR @ hex. TIM14-ARR 1b. ;
: TIM14-CCR1. ." TIM14-CCR1 (read-write) $" TIM14-CCR1 @ hex. TIM14-CCR1 1b. ;
: TIM14.
TIM14-CR1.
TIM14-CR2.
TIM14-DIER.
TIM14-SR.
TIM14-EGR.
TIM14-CCMR1_Output.
TIM14-CCMR1_Input.
TIM14-CCER.
TIM14-CNT.
TIM14-PSC.
TIM14-ARR.
TIM14-CCR1.
;

