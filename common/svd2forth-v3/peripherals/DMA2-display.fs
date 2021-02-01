\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: DMA2-ISR. ." DMA2-ISR (read-only) $" DMA2-ISR @ hex. DMA2-ISR 1b. ;
: DMA2-IFCR. ." DMA2-IFCR (write-only) $" DMA2-IFCR @ hex. DMA2-IFCR 1b. ;
: DMA2-CCR1. ." DMA2-CCR1 (read-write) $" DMA2-CCR1 @ hex. DMA2-CCR1 1b. ;
: DMA2-CNDTR1. ." DMA2-CNDTR1 (read-write) $" DMA2-CNDTR1 @ hex. DMA2-CNDTR1 1b. ;
: DMA2-CPAR1. ." DMA2-CPAR1 (read-write) $" DMA2-CPAR1 @ hex. DMA2-CPAR1 1b. ;
: DMA2-CMAR1. ." DMA2-CMAR1 (read-write) $" DMA2-CMAR1 @ hex. DMA2-CMAR1 1b. ;
: DMA2-CCR2. ." DMA2-CCR2 (read-write) $" DMA2-CCR2 @ hex. DMA2-CCR2 1b. ;
: DMA2-CNDTR2. ." DMA2-CNDTR2 (read-write) $" DMA2-CNDTR2 @ hex. DMA2-CNDTR2 1b. ;
: DMA2-CPAR2. ." DMA2-CPAR2 (read-write) $" DMA2-CPAR2 @ hex. DMA2-CPAR2 1b. ;
: DMA2-CMAR2. ." DMA2-CMAR2 (read-write) $" DMA2-CMAR2 @ hex. DMA2-CMAR2 1b. ;
: DMA2-CCR3. ." DMA2-CCR3 (read-write) $" DMA2-CCR3 @ hex. DMA2-CCR3 1b. ;
: DMA2-CNDTR3. ." DMA2-CNDTR3 (read-write) $" DMA2-CNDTR3 @ hex. DMA2-CNDTR3 1b. ;
: DMA2-CPAR3. ." DMA2-CPAR3 (read-write) $" DMA2-CPAR3 @ hex. DMA2-CPAR3 1b. ;
: DMA2-CMAR3. ." DMA2-CMAR3 (read-write) $" DMA2-CMAR3 @ hex. DMA2-CMAR3 1b. ;
: DMA2-CCR4. ." DMA2-CCR4 (read-write) $" DMA2-CCR4 @ hex. DMA2-CCR4 1b. ;
: DMA2-CNDTR4. ." DMA2-CNDTR4 (read-write) $" DMA2-CNDTR4 @ hex. DMA2-CNDTR4 1b. ;
: DMA2-CPAR4. ." DMA2-CPAR4 (read-write) $" DMA2-CPAR4 @ hex. DMA2-CPAR4 1b. ;
: DMA2-CMAR4. ." DMA2-CMAR4 (read-write) $" DMA2-CMAR4 @ hex. DMA2-CMAR4 1b. ;
: DMA2-CCR5. ." DMA2-CCR5 (read-write) $" DMA2-CCR5 @ hex. DMA2-CCR5 1b. ;
: DMA2-CNDTR5. ." DMA2-CNDTR5 (read-write) $" DMA2-CNDTR5 @ hex. DMA2-CNDTR5 1b. ;
: DMA2-CPAR5. ." DMA2-CPAR5 (read-write) $" DMA2-CPAR5 @ hex. DMA2-CPAR5 1b. ;
: DMA2-CMAR5. ." DMA2-CMAR5 (read-write) $" DMA2-CMAR5 @ hex. DMA2-CMAR5 1b. ;
: DMA2-CCR6. ." DMA2-CCR6 (read-write) $" DMA2-CCR6 @ hex. DMA2-CCR6 1b. ;
: DMA2-CNDTR6. ." DMA2-CNDTR6 (read-write) $" DMA2-CNDTR6 @ hex. DMA2-CNDTR6 1b. ;
: DMA2-CPAR6. ." DMA2-CPAR6 (read-write) $" DMA2-CPAR6 @ hex. DMA2-CPAR6 1b. ;
: DMA2-CMAR6. ." DMA2-CMAR6 (read-write) $" DMA2-CMAR6 @ hex. DMA2-CMAR6 1b. ;
: DMA2-CCR7. ." DMA2-CCR7 (read-write) $" DMA2-CCR7 @ hex. DMA2-CCR7 1b. ;
: DMA2-CNDTR7. ." DMA2-CNDTR7 (read-write) $" DMA2-CNDTR7 @ hex. DMA2-CNDTR7 1b. ;
: DMA2-CPAR7. ." DMA2-CPAR7 (read-write) $" DMA2-CPAR7 @ hex. DMA2-CPAR7 1b. ;
: DMA2-CMAR7. ." DMA2-CMAR7 (read-write) $" DMA2-CMAR7 @ hex. DMA2-CMAR7 1b. ;
: DMA2.
DMA2-ISR.
DMA2-IFCR.
DMA2-CCR1.
DMA2-CNDTR1.
DMA2-CPAR1.
DMA2-CMAR1.
DMA2-CCR2.
DMA2-CNDTR2.
DMA2-CPAR2.
DMA2-CMAR2.
DMA2-CCR3.
DMA2-CNDTR3.
DMA2-CPAR3.
DMA2-CMAR3.
DMA2-CCR4.
DMA2-CNDTR4.
DMA2-CPAR4.
DMA2-CMAR4.
DMA2-CCR5.
DMA2-CNDTR5.
DMA2-CPAR5.
DMA2-CMAR5.
DMA2-CCR6.
DMA2-CNDTR6.
DMA2-CPAR6.
DMA2-CMAR6.
DMA2-CCR7.
DMA2-CNDTR7.
DMA2-CPAR7.
DMA2-CMAR7.
;

