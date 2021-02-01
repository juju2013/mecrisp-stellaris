\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: ADC2-SR. ." ADC2-SR (read-write) $" ADC2-SR @ hex. ADC2-SR 1b. ;
: ADC2-CR1. ." ADC2-CR1 (read-write) $" ADC2-CR1 @ hex. ADC2-CR1 1b. ;
: ADC2-CR2. ." ADC2-CR2 (read-write) $" ADC2-CR2 @ hex. ADC2-CR2 1b. ;
: ADC2-SMPR1. ." ADC2-SMPR1 (read-write) $" ADC2-SMPR1 @ hex. ADC2-SMPR1 1b. ;
: ADC2-SMPR2. ." ADC2-SMPR2 (read-write) $" ADC2-SMPR2 @ hex. ADC2-SMPR2 1b. ;
: ADC2-JOFR1. ." ADC2-JOFR1 (read-write) $" ADC2-JOFR1 @ hex. ADC2-JOFR1 1b. ;
: ADC2-JOFR2. ." ADC2-JOFR2 (read-write) $" ADC2-JOFR2 @ hex. ADC2-JOFR2 1b. ;
: ADC2-JOFR3. ." ADC2-JOFR3 (read-write) $" ADC2-JOFR3 @ hex. ADC2-JOFR3 1b. ;
: ADC2-JOFR4. ." ADC2-JOFR4 (read-write) $" ADC2-JOFR4 @ hex. ADC2-JOFR4 1b. ;
: ADC2-HTR. ." ADC2-HTR (read-write) $" ADC2-HTR @ hex. ADC2-HTR 1b. ;
: ADC2-LTR. ." ADC2-LTR (read-write) $" ADC2-LTR @ hex. ADC2-LTR 1b. ;
: ADC2-SQR1. ." ADC2-SQR1 (read-write) $" ADC2-SQR1 @ hex. ADC2-SQR1 1b. ;
: ADC2-SQR2. ." ADC2-SQR2 (read-write) $" ADC2-SQR2 @ hex. ADC2-SQR2 1b. ;
: ADC2-SQR3. ." ADC2-SQR3 (read-write) $" ADC2-SQR3 @ hex. ADC2-SQR3 1b. ;
: ADC2-JSQR. ." ADC2-JSQR (read-write) $" ADC2-JSQR @ hex. ADC2-JSQR 1b. ;
: ADC2-JDR1. ." ADC2-JDR1 (read-only) $" ADC2-JDR1 @ hex. ADC2-JDR1 1b. ;
: ADC2-JDR2. ." ADC2-JDR2 (read-only) $" ADC2-JDR2 @ hex. ADC2-JDR2 1b. ;
: ADC2-JDR3. ." ADC2-JDR3 (read-only) $" ADC2-JDR3 @ hex. ADC2-JDR3 1b. ;
: ADC2-JDR4. ." ADC2-JDR4 (read-only) $" ADC2-JDR4 @ hex. ADC2-JDR4 1b. ;
: ADC2-DR. ." ADC2-DR (read-only) $" ADC2-DR @ hex. ADC2-DR 1b. ;
: ADC2.
ADC2-SR.
ADC2-CR1.
ADC2-CR2.
ADC2-SMPR1.
ADC2-SMPR2.
ADC2-JOFR1.
ADC2-JOFR2.
ADC2-JOFR3.
ADC2-JOFR4.
ADC2-HTR.
ADC2-LTR.
ADC2-SQR1.
ADC2-SQR2.
ADC2-SQR3.
ADC2-JSQR.
ADC2-JDR1.
ADC2-JDR2.
ADC2-JDR3.
ADC2-JDR4.
ADC2-DR.
;

