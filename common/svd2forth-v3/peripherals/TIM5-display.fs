\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM5-CR1. ." TIM5-CR1 (read-write) $" TIM5-CR1 @ hex. TIM5-CR1 1b. ;
: TIM5-CR2. ." TIM5-CR2 (read-write) $" TIM5-CR2 @ hex. TIM5-CR2 1b. ;
: TIM5-SMCR. ." TIM5-SMCR (read-write) $" TIM5-SMCR @ hex. TIM5-SMCR 1b. ;
: TIM5-DIER. ." TIM5-DIER (read-write) $" TIM5-DIER @ hex. TIM5-DIER 1b. ;
: TIM5-SR. ." TIM5-SR (read-write) $" TIM5-SR @ hex. TIM5-SR 1b. ;
: TIM5-EGR. ." TIM5-EGR (write-only) $" TIM5-EGR @ hex. TIM5-EGR 1b. ;
: TIM5-CCMR1_Output. ." TIM5-CCMR1_Output (read-write) $" TIM5-CCMR1_Output @ hex. TIM5-CCMR1_Output 1b. ;
: TIM5-CCMR1_Input. ." TIM5-CCMR1_Input (read-write) $" TIM5-CCMR1_Input @ hex. TIM5-CCMR1_Input 1b. ;
: TIM5-CCMR2_Output. ." TIM5-CCMR2_Output (read-write) $" TIM5-CCMR2_Output @ hex. TIM5-CCMR2_Output 1b. ;
: TIM5-CCMR2_Input. ." TIM5-CCMR2_Input (read-write) $" TIM5-CCMR2_Input @ hex. TIM5-CCMR2_Input 1b. ;
: TIM5-CCER. ." TIM5-CCER (read-write) $" TIM5-CCER @ hex. TIM5-CCER 1b. ;
: TIM5-CNT. ." TIM5-CNT (read-write) $" TIM5-CNT @ hex. TIM5-CNT 1b. ;
: TIM5-PSC. ." TIM5-PSC (read-write) $" TIM5-PSC @ hex. TIM5-PSC 1b. ;
: TIM5-ARR. ." TIM5-ARR (read-write) $" TIM5-ARR @ hex. TIM5-ARR 1b. ;
: TIM5-CCR1. ." TIM5-CCR1 (read-write) $" TIM5-CCR1 @ hex. TIM5-CCR1 1b. ;
: TIM5-CCR2. ." TIM5-CCR2 (read-write) $" TIM5-CCR2 @ hex. TIM5-CCR2 1b. ;
: TIM5-CCR3. ." TIM5-CCR3 (read-write) $" TIM5-CCR3 @ hex. TIM5-CCR3 1b. ;
: TIM5-CCR4. ." TIM5-CCR4 (read-write) $" TIM5-CCR4 @ hex. TIM5-CCR4 1b. ;
: TIM5-DCR. ." TIM5-DCR (read-write) $" TIM5-DCR @ hex. TIM5-DCR 1b. ;
: TIM5-DMAR. ." TIM5-DMAR (read-write) $" TIM5-DMAR @ hex. TIM5-DMAR 1b. ;
: TIM5.
TIM5-CR1.
TIM5-CR2.
TIM5-SMCR.
TIM5-DIER.
TIM5-SR.
TIM5-EGR.
TIM5-CCMR1_Output.
TIM5-CCMR1_Input.
TIM5-CCMR2_Output.
TIM5-CCMR2_Input.
TIM5-CCER.
TIM5-CNT.
TIM5-PSC.
TIM5-ARR.
TIM5-CCR1.
TIM5-CCR2.
TIM5-CCR3.
TIM5-CCR4.
TIM5-DCR.
TIM5-DMAR.
;

