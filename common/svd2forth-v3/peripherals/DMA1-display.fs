\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: DMA1-ISR. ." DMA1-ISR (read-only) $" DMA1-ISR @ hex. DMA1-ISR 1b. ;
: DMA1-IFCR. ." DMA1-IFCR (write-only) $" DMA1-IFCR @ hex. DMA1-IFCR 1b. ;
: DMA1-CCR1. ." DMA1-CCR1 (read-write) $" DMA1-CCR1 @ hex. DMA1-CCR1 1b. ;
: DMA1-CNDTR1. ." DMA1-CNDTR1 (read-write) $" DMA1-CNDTR1 @ hex. DMA1-CNDTR1 1b. ;
: DMA1-CPAR1. ." DMA1-CPAR1 (read-write) $" DMA1-CPAR1 @ hex. DMA1-CPAR1 1b. ;
: DMA1-CMAR1. ." DMA1-CMAR1 (read-write) $" DMA1-CMAR1 @ hex. DMA1-CMAR1 1b. ;
: DMA1-CCR2. ." DMA1-CCR2 (read-write) $" DMA1-CCR2 @ hex. DMA1-CCR2 1b. ;
: DMA1-CNDTR2. ." DMA1-CNDTR2 (read-write) $" DMA1-CNDTR2 @ hex. DMA1-CNDTR2 1b. ;
: DMA1-CPAR2. ." DMA1-CPAR2 (read-write) $" DMA1-CPAR2 @ hex. DMA1-CPAR2 1b. ;
: DMA1-CMAR2. ." DMA1-CMAR2 (read-write) $" DMA1-CMAR2 @ hex. DMA1-CMAR2 1b. ;
: DMA1-CCR3. ." DMA1-CCR3 (read-write) $" DMA1-CCR3 @ hex. DMA1-CCR3 1b. ;
: DMA1-CNDTR3. ." DMA1-CNDTR3 (read-write) $" DMA1-CNDTR3 @ hex. DMA1-CNDTR3 1b. ;
: DMA1-CPAR3. ." DMA1-CPAR3 (read-write) $" DMA1-CPAR3 @ hex. DMA1-CPAR3 1b. ;
: DMA1-CMAR3. ." DMA1-CMAR3 (read-write) $" DMA1-CMAR3 @ hex. DMA1-CMAR3 1b. ;
: DMA1-CCR4. ." DMA1-CCR4 (read-write) $" DMA1-CCR4 @ hex. DMA1-CCR4 1b. ;
: DMA1-CNDTR4. ." DMA1-CNDTR4 (read-write) $" DMA1-CNDTR4 @ hex. DMA1-CNDTR4 1b. ;
: DMA1-CPAR4. ." DMA1-CPAR4 (read-write) $" DMA1-CPAR4 @ hex. DMA1-CPAR4 1b. ;
: DMA1-CMAR4. ." DMA1-CMAR4 (read-write) $" DMA1-CMAR4 @ hex. DMA1-CMAR4 1b. ;
: DMA1-CCR5. ." DMA1-CCR5 (read-write) $" DMA1-CCR5 @ hex. DMA1-CCR5 1b. ;
: DMA1-CNDTR5. ." DMA1-CNDTR5 (read-write) $" DMA1-CNDTR5 @ hex. DMA1-CNDTR5 1b. ;
: DMA1-CPAR5. ." DMA1-CPAR5 (read-write) $" DMA1-CPAR5 @ hex. DMA1-CPAR5 1b. ;
: DMA1-CMAR5. ." DMA1-CMAR5 (read-write) $" DMA1-CMAR5 @ hex. DMA1-CMAR5 1b. ;
: DMA1-CCR6. ." DMA1-CCR6 (read-write) $" DMA1-CCR6 @ hex. DMA1-CCR6 1b. ;
: DMA1-CNDTR6. ." DMA1-CNDTR6 (read-write) $" DMA1-CNDTR6 @ hex. DMA1-CNDTR6 1b. ;
: DMA1-CPAR6. ." DMA1-CPAR6 (read-write) $" DMA1-CPAR6 @ hex. DMA1-CPAR6 1b. ;
: DMA1-CMAR6. ." DMA1-CMAR6 (read-write) $" DMA1-CMAR6 @ hex. DMA1-CMAR6 1b. ;
: DMA1-CCR7. ." DMA1-CCR7 (read-write) $" DMA1-CCR7 @ hex. DMA1-CCR7 1b. ;
: DMA1-CNDTR7. ." DMA1-CNDTR7 (read-write) $" DMA1-CNDTR7 @ hex. DMA1-CNDTR7 1b. ;
: DMA1-CPAR7. ." DMA1-CPAR7 (read-write) $" DMA1-CPAR7 @ hex. DMA1-CPAR7 1b. ;
: DMA1-CMAR7. ." DMA1-CMAR7 (read-write) $" DMA1-CMAR7 @ hex. DMA1-CMAR7 1b. ;
: DMA1.
DMA1-ISR.
DMA1-IFCR.
DMA1-CCR1.
DMA1-CNDTR1.
DMA1-CPAR1.
DMA1-CMAR1.
DMA1-CCR2.
DMA1-CNDTR2.
DMA1-CPAR2.
DMA1-CMAR2.
DMA1-CCR3.
DMA1-CNDTR3.
DMA1-CPAR3.
DMA1-CMAR3.
DMA1-CCR4.
DMA1-CNDTR4.
DMA1-CPAR4.
DMA1-CMAR4.
DMA1-CCR5.
DMA1-CNDTR5.
DMA1-CPAR5.
DMA1-CMAR5.
DMA1-CCR6.
DMA1-CNDTR6.
DMA1-CPAR6.
DMA1-CMAR6.
DMA1-CCR7.
DMA1-CNDTR7.
DMA1-CPAR7.
DMA1-CMAR7.
;

