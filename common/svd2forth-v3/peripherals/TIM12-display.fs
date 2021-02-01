\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM12-CR1. ." TIM12-CR1 (read-write) $" TIM12-CR1 @ hex. TIM12-CR1 1b. ;
: TIM12-CR2. ." TIM12-CR2 (read-write) $" TIM12-CR2 @ hex. TIM12-CR2 1b. ;
: TIM12-SMCR. ." TIM12-SMCR (read-write) $" TIM12-SMCR @ hex. TIM12-SMCR 1b. ;
: TIM12-DIER. ." TIM12-DIER (read-write) $" TIM12-DIER @ hex. TIM12-DIER 1b. ;
: TIM12-SR. ." TIM12-SR (read-write) $" TIM12-SR @ hex. TIM12-SR 1b. ;
: TIM12-EGR. ." TIM12-EGR (write-only) $" TIM12-EGR @ hex. TIM12-EGR 1b. ;
: TIM12-CCMR1_Output. ." TIM12-CCMR1_Output (read-write) $" TIM12-CCMR1_Output @ hex. TIM12-CCMR1_Output 1b. ;
: TIM12-CCMR1_Input. ." TIM12-CCMR1_Input (read-write) $" TIM12-CCMR1_Input @ hex. TIM12-CCMR1_Input 1b. ;
: TIM12-CCER. ." TIM12-CCER (read-write) $" TIM12-CCER @ hex. TIM12-CCER 1b. ;
: TIM12-CNT. ." TIM12-CNT (read-write) $" TIM12-CNT @ hex. TIM12-CNT 1b. ;
: TIM12-PSC. ." TIM12-PSC (read-write) $" TIM12-PSC @ hex. TIM12-PSC 1b. ;
: TIM12-ARR. ." TIM12-ARR (read-write) $" TIM12-ARR @ hex. TIM12-ARR 1b. ;
: TIM12-CCR1. ." TIM12-CCR1 (read-write) $" TIM12-CCR1 @ hex. TIM12-CCR1 1b. ;
: TIM12-CCR2. ." TIM12-CCR2 (read-write) $" TIM12-CCR2 @ hex. TIM12-CCR2 1b. ;
: TIM12.
TIM12-CR1.
TIM12-CR2.
TIM12-SMCR.
TIM12-DIER.
TIM12-SR.
TIM12-EGR.
TIM12-CCMR1_Output.
TIM12-CCMR1_Input.
TIM12-CCER.
TIM12-CNT.
TIM12-PSC.
TIM12-ARR.
TIM12-CCR1.
TIM12-CCR2.
;

