\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM1-CR1. ." TIM1-CR1 (read-write) $" TIM1-CR1 @ hex. TIM1-CR1 1b. ;
: TIM1-CR2. ." TIM1-CR2 (read-write) $" TIM1-CR2 @ hex. TIM1-CR2 1b. ;
: TIM1-SMCR. ." TIM1-SMCR (read-write) $" TIM1-SMCR @ hex. TIM1-SMCR 1b. ;
: TIM1-DIER. ." TIM1-DIER (read-write) $" TIM1-DIER @ hex. TIM1-DIER 1b. ;
: TIM1-SR. ." TIM1-SR (read-write) $" TIM1-SR @ hex. TIM1-SR 1b. ;
: TIM1-EGR. ." TIM1-EGR (write-only) $" TIM1-EGR @ hex. TIM1-EGR 1b. ;
: TIM1-CCMR1_Output. ." TIM1-CCMR1_Output (read-write) $" TIM1-CCMR1_Output @ hex. TIM1-CCMR1_Output 1b. ;
: TIM1-CCMR1_Input. ." TIM1-CCMR1_Input (read-write) $" TIM1-CCMR1_Input @ hex. TIM1-CCMR1_Input 1b. ;
: TIM1-CCMR2_Output. ." TIM1-CCMR2_Output (read-write) $" TIM1-CCMR2_Output @ hex. TIM1-CCMR2_Output 1b. ;
: TIM1-CCMR2_Input. ." TIM1-CCMR2_Input (read-write) $" TIM1-CCMR2_Input @ hex. TIM1-CCMR2_Input 1b. ;
: TIM1-CCER. ." TIM1-CCER (read-write) $" TIM1-CCER @ hex. TIM1-CCER 1b. ;
: TIM1-CNT. ." TIM1-CNT (read-write) $" TIM1-CNT @ hex. TIM1-CNT 1b. ;
: TIM1-PSC. ." TIM1-PSC (read-write) $" TIM1-PSC @ hex. TIM1-PSC 1b. ;
: TIM1-ARR. ." TIM1-ARR (read-write) $" TIM1-ARR @ hex. TIM1-ARR 1b. ;
: TIM1-CCR1. ." TIM1-CCR1 (read-write) $" TIM1-CCR1 @ hex. TIM1-CCR1 1b. ;
: TIM1-CCR2. ." TIM1-CCR2 (read-write) $" TIM1-CCR2 @ hex. TIM1-CCR2 1b. ;
: TIM1-CCR3. ." TIM1-CCR3 (read-write) $" TIM1-CCR3 @ hex. TIM1-CCR3 1b. ;
: TIM1-CCR4. ." TIM1-CCR4 (read-write) $" TIM1-CCR4 @ hex. TIM1-CCR4 1b. ;
: TIM1-DCR. ." TIM1-DCR (read-write) $" TIM1-DCR @ hex. TIM1-DCR 1b. ;
: TIM1-DMAR. ." TIM1-DMAR (read-write) $" TIM1-DMAR @ hex. TIM1-DMAR 1b. ;
: TIM1-RCR. ." TIM1-RCR (read-write) $" TIM1-RCR @ hex. TIM1-RCR 1b. ;
: TIM1-BDTR. ." TIM1-BDTR (read-write) $" TIM1-BDTR @ hex. TIM1-BDTR 1b. ;
: TIM1.
TIM1-CR1.
TIM1-CR2.
TIM1-SMCR.
TIM1-DIER.
TIM1-SR.
TIM1-EGR.
TIM1-CCMR1_Output.
TIM1-CCMR1_Input.
TIM1-CCMR2_Output.
TIM1-CCMR2_Input.
TIM1-CCER.
TIM1-CNT.
TIM1-PSC.
TIM1-ARR.
TIM1-CCR1.
TIM1-CCR2.
TIM1-CCR3.
TIM1-CCR4.
TIM1-DCR.
TIM1-DMAR.
TIM1-RCR.
TIM1-BDTR.
;

