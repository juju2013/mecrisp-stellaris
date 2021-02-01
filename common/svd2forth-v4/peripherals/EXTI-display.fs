\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: EXTI-IMR. ." EXTI-IMR (read-write) $" EXTI-IMR @ hex. EXTI-IMR 1b. ;
: EXTI-EMR. ." EXTI-EMR (read-write) $" EXTI-EMR @ hex. EXTI-EMR 1b. ;
: EXTI-RTSR. ." EXTI-RTSR (read-write) $" EXTI-RTSR @ hex. EXTI-RTSR 1b. ;
: EXTI-FTSR. ." EXTI-FTSR (read-write) $" EXTI-FTSR @ hex. EXTI-FTSR 1b. ;
: EXTI-SWIER. ." EXTI-SWIER (read-write) $" EXTI-SWIER @ hex. EXTI-SWIER 1b. ;
: EXTI-PR. ." EXTI-PR (read-write) $" EXTI-PR @ hex. EXTI-PR 1b. ;
: EXTI.
EXTI-IMR.
EXTI-EMR.
EXTI-RTSR.
EXTI-FTSR.
EXTI-SWIER.
EXTI-PR.
;

