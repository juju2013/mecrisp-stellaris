\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: TIM8-CR1. ." TIM8-CR1 (read-write) $" TIM8-CR1 @ hex. TIM8-CR1 1b. ;
: TIM8-CR2. ." TIM8-CR2 (read-write) $" TIM8-CR2 @ hex. TIM8-CR2 1b. ;
: TIM8-SMCR. ." TIM8-SMCR (read-write) $" TIM8-SMCR @ hex. TIM8-SMCR 1b. ;
: TIM8-DIER. ." TIM8-DIER (read-write) $" TIM8-DIER @ hex. TIM8-DIER 1b. ;
: TIM8-SR. ." TIM8-SR (read-write) $" TIM8-SR @ hex. TIM8-SR 1b. ;
: TIM8-EGR. ." TIM8-EGR (write-only) $" TIM8-EGR @ hex. TIM8-EGR 1b. ;
: TIM8-CCMR1_Output. ." TIM8-CCMR1_Output (read-write) $" TIM8-CCMR1_Output @ hex. TIM8-CCMR1_Output 1b. ;
: TIM8-CCMR1_Input. ." TIM8-CCMR1_Input (read-write) $" TIM8-CCMR1_Input @ hex. TIM8-CCMR1_Input 1b. ;
: TIM8-CCMR2_Output. ." TIM8-CCMR2_Output (read-write) $" TIM8-CCMR2_Output @ hex. TIM8-CCMR2_Output 1b. ;
: TIM8-CCMR2_Input. ." TIM8-CCMR2_Input (read-write) $" TIM8-CCMR2_Input @ hex. TIM8-CCMR2_Input 1b. ;
: TIM8-CCER. ." TIM8-CCER (read-write) $" TIM8-CCER @ hex. TIM8-CCER 1b. ;
: TIM8-CNT. ." TIM8-CNT (read-write) $" TIM8-CNT @ hex. TIM8-CNT 1b. ;
: TIM8-PSC. ." TIM8-PSC (read-write) $" TIM8-PSC @ hex. TIM8-PSC 1b. ;
: TIM8-ARR. ." TIM8-ARR (read-write) $" TIM8-ARR @ hex. TIM8-ARR 1b. ;
: TIM8-CCR1. ." TIM8-CCR1 (read-write) $" TIM8-CCR1 @ hex. TIM8-CCR1 1b. ;
: TIM8-CCR2. ." TIM8-CCR2 (read-write) $" TIM8-CCR2 @ hex. TIM8-CCR2 1b. ;
: TIM8-CCR3. ." TIM8-CCR3 (read-write) $" TIM8-CCR3 @ hex. TIM8-CCR3 1b. ;
: TIM8-CCR4. ." TIM8-CCR4 (read-write) $" TIM8-CCR4 @ hex. TIM8-CCR4 1b. ;
: TIM8-DCR. ." TIM8-DCR (read-write) $" TIM8-DCR @ hex. TIM8-DCR 1b. ;
: TIM8-DMAR. ." TIM8-DMAR (read-write) $" TIM8-DMAR @ hex. TIM8-DMAR 1b. ;
: TIM8-RCR. ." TIM8-RCR (read-write) $" TIM8-RCR @ hex. TIM8-RCR 1b. ;
: TIM8-BDTR. ." TIM8-BDTR (read-write) $" TIM8-BDTR @ hex. TIM8-BDTR 1b. ;
: TIM8.
TIM8-CR1.
TIM8-CR2.
TIM8-SMCR.
TIM8-DIER.
TIM8-SR.
TIM8-EGR.
TIM8-CCMR1_Output.
TIM8-CCMR1_Input.
TIM8-CCMR2_Output.
TIM8-CCMR2_Input.
TIM8-CCER.
TIM8-CNT.
TIM8-PSC.
TIM8-ARR.
TIM8-CCR1.
TIM8-CCR2.
TIM8-CCR3.
TIM8-CCR4.
TIM8-DCR.
TIM8-DMAR.
TIM8-RCR.
TIM8-BDTR.
;

