\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM9-CR1. ." TIM9-CR1 (read-write) $" TIM9-CR1 @ hex. TIM9-CR1 1b. ;
: TIM9-CR2. ." TIM9-CR2 (read-write) $" TIM9-CR2 @ hex. TIM9-CR2 1b. ;
: TIM9-SMCR. ." TIM9-SMCR (read-write) $" TIM9-SMCR @ hex. TIM9-SMCR 1b. ;
: TIM9-DIER. ." TIM9-DIER (read-write) $" TIM9-DIER @ hex. TIM9-DIER 1b. ;
: TIM9-SR. ." TIM9-SR (read-write) $" TIM9-SR @ hex. TIM9-SR 1b. ;
: TIM9-EGR. ." TIM9-EGR (write-only) $" TIM9-EGR @ hex. TIM9-EGR 1b. ;
: TIM9-CCMR1_Output. ." TIM9-CCMR1_Output (read-write) $" TIM9-CCMR1_Output @ hex. TIM9-CCMR1_Output 1b. ;
: TIM9-CCMR1_Input. ." TIM9-CCMR1_Input (read-write) $" TIM9-CCMR1_Input @ hex. TIM9-CCMR1_Input 1b. ;
: TIM9-CCER. ." TIM9-CCER (read-write) $" TIM9-CCER @ hex. TIM9-CCER 1b. ;
: TIM9-CNT. ." TIM9-CNT (read-write) $" TIM9-CNT @ hex. TIM9-CNT 1b. ;
: TIM9-PSC. ." TIM9-PSC (read-write) $" TIM9-PSC @ hex. TIM9-PSC 1b. ;
: TIM9-ARR. ." TIM9-ARR (read-write) $" TIM9-ARR @ hex. TIM9-ARR 1b. ;
: TIM9-CCR1. ." TIM9-CCR1 (read-write) $" TIM9-CCR1 @ hex. TIM9-CCR1 1b. ;
: TIM9-CCR2. ." TIM9-CCR2 (read-write) $" TIM9-CCR2 @ hex. TIM9-CCR2 1b. ;
: TIM9.
TIM9-CR1.
TIM9-CR2.
TIM9-SMCR.
TIM9-DIER.
TIM9-SR.
TIM9-EGR.
TIM9-CCMR1_Output.
TIM9-CCMR1_Input.
TIM9-CCER.
TIM9-CNT.
TIM9-PSC.
TIM9-ARR.
TIM9-CCR1.
TIM9-CCR2.
;

