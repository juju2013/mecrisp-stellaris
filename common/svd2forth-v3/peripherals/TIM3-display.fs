\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM3-CR1. ." TIM3-CR1 (read-write) $" TIM3-CR1 @ hex. TIM3-CR1 1b. ;
: TIM3-CR2. ." TIM3-CR2 (read-write) $" TIM3-CR2 @ hex. TIM3-CR2 1b. ;
: TIM3-SMCR. ." TIM3-SMCR (read-write) $" TIM3-SMCR @ hex. TIM3-SMCR 1b. ;
: TIM3-DIER. ." TIM3-DIER (read-write) $" TIM3-DIER @ hex. TIM3-DIER 1b. ;
: TIM3-SR. ." TIM3-SR (read-write) $" TIM3-SR @ hex. TIM3-SR 1b. ;
: TIM3-EGR. ." TIM3-EGR (write-only) $" TIM3-EGR @ hex. TIM3-EGR 1b. ;
: TIM3-CCMR1_Output. ." TIM3-CCMR1_Output (read-write) $" TIM3-CCMR1_Output @ hex. TIM3-CCMR1_Output 1b. ;
: TIM3-CCMR1_Input. ." TIM3-CCMR1_Input (read-write) $" TIM3-CCMR1_Input @ hex. TIM3-CCMR1_Input 1b. ;
: TIM3-CCMR2_Output. ." TIM3-CCMR2_Output (read-write) $" TIM3-CCMR2_Output @ hex. TIM3-CCMR2_Output 1b. ;
: TIM3-CCMR2_Input. ." TIM3-CCMR2_Input (read-write) $" TIM3-CCMR2_Input @ hex. TIM3-CCMR2_Input 1b. ;
: TIM3-CCER. ." TIM3-CCER (read-write) $" TIM3-CCER @ hex. TIM3-CCER 1b. ;
: TIM3-CNT. ." TIM3-CNT (read-write) $" TIM3-CNT @ hex. TIM3-CNT 1b. ;
: TIM3-PSC. ." TIM3-PSC (read-write) $" TIM3-PSC @ hex. TIM3-PSC 1b. ;
: TIM3-ARR. ." TIM3-ARR (read-write) $" TIM3-ARR @ hex. TIM3-ARR 1b. ;
: TIM3-CCR1. ." TIM3-CCR1 (read-write) $" TIM3-CCR1 @ hex. TIM3-CCR1 1b. ;
: TIM3-CCR2. ." TIM3-CCR2 (read-write) $" TIM3-CCR2 @ hex. TIM3-CCR2 1b. ;
: TIM3-CCR3. ." TIM3-CCR3 (read-write) $" TIM3-CCR3 @ hex. TIM3-CCR3 1b. ;
: TIM3-CCR4. ." TIM3-CCR4 (read-write) $" TIM3-CCR4 @ hex. TIM3-CCR4 1b. ;
: TIM3-DCR. ." TIM3-DCR (read-write) $" TIM3-DCR @ hex. TIM3-DCR 1b. ;
: TIM3-DMAR. ." TIM3-DMAR (read-write) $" TIM3-DMAR @ hex. TIM3-DMAR 1b. ;
: TIM3.
TIM3-CR1.
TIM3-CR2.
TIM3-SMCR.
TIM3-DIER.
TIM3-SR.
TIM3-EGR.
TIM3-CCMR1_Output.
TIM3-CCMR1_Input.
TIM3-CCMR2_Output.
TIM3-CCMR2_Input.
TIM3-CCER.
TIM3-CNT.
TIM3-PSC.
TIM3-ARR.
TIM3-CCR1.
TIM3-CCR2.
TIM3-CCR3.
TIM3-CCR4.
TIM3-DCR.
TIM3-DMAR.
;

