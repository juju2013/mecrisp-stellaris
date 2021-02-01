\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM2-CR1. ." TIM2-CR1 (read-write) $" TIM2-CR1 @ hex. TIM2-CR1 1b. ;
: TIM2-CR2. ." TIM2-CR2 (read-write) $" TIM2-CR2 @ hex. TIM2-CR2 1b. ;
: TIM2-SMCR. ." TIM2-SMCR (read-write) $" TIM2-SMCR @ hex. TIM2-SMCR 1b. ;
: TIM2-DIER. ." TIM2-DIER (read-write) $" TIM2-DIER @ hex. TIM2-DIER 1b. ;
: TIM2-SR. ." TIM2-SR (read-write) $" TIM2-SR @ hex. TIM2-SR 1b. ;
: TIM2-EGR. ." TIM2-EGR (write-only) $" TIM2-EGR @ hex. TIM2-EGR 1b. ;
: TIM2-CCMR1_Output. ." TIM2-CCMR1_Output (read-write) $" TIM2-CCMR1_Output @ hex. TIM2-CCMR1_Output 1b. ;
: TIM2-CCMR1_Input. ." TIM2-CCMR1_Input (read-write) $" TIM2-CCMR1_Input @ hex. TIM2-CCMR1_Input 1b. ;
: TIM2-CCMR2_Output. ." TIM2-CCMR2_Output (read-write) $" TIM2-CCMR2_Output @ hex. TIM2-CCMR2_Output 1b. ;
: TIM2-CCMR2_Input. ." TIM2-CCMR2_Input (read-write) $" TIM2-CCMR2_Input @ hex. TIM2-CCMR2_Input 1b. ;
: TIM2-CCER. ." TIM2-CCER (read-write) $" TIM2-CCER @ hex. TIM2-CCER 1b. ;
: TIM2-CNT. ." TIM2-CNT (read-write) $" TIM2-CNT @ hex. TIM2-CNT 1b. ;
: TIM2-PSC. ." TIM2-PSC (read-write) $" TIM2-PSC @ hex. TIM2-PSC 1b. ;
: TIM2-ARR. ." TIM2-ARR (read-write) $" TIM2-ARR @ hex. TIM2-ARR 1b. ;
: TIM2-CCR1. ." TIM2-CCR1 (read-write) $" TIM2-CCR1 @ hex. TIM2-CCR1 1b. ;
: TIM2-CCR2. ." TIM2-CCR2 (read-write) $" TIM2-CCR2 @ hex. TIM2-CCR2 1b. ;
: TIM2-CCR3. ." TIM2-CCR3 (read-write) $" TIM2-CCR3 @ hex. TIM2-CCR3 1b. ;
: TIM2-CCR4. ." TIM2-CCR4 (read-write) $" TIM2-CCR4 @ hex. TIM2-CCR4 1b. ;
: TIM2-DCR. ." TIM2-DCR (read-write) $" TIM2-DCR @ hex. TIM2-DCR 1b. ;
: TIM2-DMAR. ." TIM2-DMAR (read-write) $" TIM2-DMAR @ hex. TIM2-DMAR 1b. ;
: TIM2.
TIM2-CR1.
TIM2-CR2.
TIM2-SMCR.
TIM2-DIER.
TIM2-SR.
TIM2-EGR.
TIM2-CCMR1_Output.
TIM2-CCMR1_Input.
TIM2-CCMR2_Output.
TIM2-CCMR2_Input.
TIM2-CCER.
TIM2-CNT.
TIM2-PSC.
TIM2-ARR.
TIM2-CCR1.
TIM2-CCR2.
TIM2-CCR3.
TIM2-CCR4.
TIM2-DCR.
TIM2-DMAR.
;

