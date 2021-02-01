\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: ADC1-SR. ." ADC1-SR (read-write) $" ADC1-SR @ hex. ADC1-SR 1b. ;
: ADC1-CR1. ." ADC1-CR1 (read-write) $" ADC1-CR1 @ hex. ADC1-CR1 1b. ;
: ADC1-CR2. ." ADC1-CR2 (read-write) $" ADC1-CR2 @ hex. ADC1-CR2 1b. ;
: ADC1-SMPR1. ." ADC1-SMPR1 (read-write) $" ADC1-SMPR1 @ hex. ADC1-SMPR1 1b. ;
: ADC1-SMPR2. ." ADC1-SMPR2 (read-write) $" ADC1-SMPR2 @ hex. ADC1-SMPR2 1b. ;
: ADC1-JOFR1. ." ADC1-JOFR1 (read-write) $" ADC1-JOFR1 @ hex. ADC1-JOFR1 1b. ;
: ADC1-JOFR2. ." ADC1-JOFR2 (read-write) $" ADC1-JOFR2 @ hex. ADC1-JOFR2 1b. ;
: ADC1-JOFR3. ." ADC1-JOFR3 (read-write) $" ADC1-JOFR3 @ hex. ADC1-JOFR3 1b. ;
: ADC1-JOFR4. ." ADC1-JOFR4 (read-write) $" ADC1-JOFR4 @ hex. ADC1-JOFR4 1b. ;
: ADC1-HTR. ." ADC1-HTR (read-write) $" ADC1-HTR @ hex. ADC1-HTR 1b. ;
: ADC1-LTR. ." ADC1-LTR (read-write) $" ADC1-LTR @ hex. ADC1-LTR 1b. ;
: ADC1-SQR1. ." ADC1-SQR1 (read-write) $" ADC1-SQR1 @ hex. ADC1-SQR1 1b. ;
: ADC1-SQR2. ." ADC1-SQR2 (read-write) $" ADC1-SQR2 @ hex. ADC1-SQR2 1b. ;
: ADC1-SQR3. ." ADC1-SQR3 (read-write) $" ADC1-SQR3 @ hex. ADC1-SQR3 1b. ;
: ADC1-JSQR. ." ADC1-JSQR (read-write) $" ADC1-JSQR @ hex. ADC1-JSQR 1b. ;
: ADC1-JDR1. ." ADC1-JDR1 (read-only) $" ADC1-JDR1 @ hex. ADC1-JDR1 1b. ;
: ADC1-JDR2. ." ADC1-JDR2 (read-only) $" ADC1-JDR2 @ hex. ADC1-JDR2 1b. ;
: ADC1-JDR3. ." ADC1-JDR3 (read-only) $" ADC1-JDR3 @ hex. ADC1-JDR3 1b. ;
: ADC1-JDR4. ." ADC1-JDR4 (read-only) $" ADC1-JDR4 @ hex. ADC1-JDR4 1b. ;
: ADC1-DR. ." ADC1-DR (read-only) $" ADC1-DR @ hex. ADC1-DR 1b. ;
: ADC1.
ADC1-SR.
ADC1-CR1.
ADC1-CR2.
ADC1-SMPR1.
ADC1-SMPR2.
ADC1-JOFR1.
ADC1-JOFR2.
ADC1-JOFR3.
ADC1-JOFR4.
ADC1-HTR.
ADC1-LTR.
ADC1-SQR1.
ADC1-SQR2.
ADC1-SQR3.
ADC1-JSQR.
ADC1-JDR1.
ADC1-JDR2.
ADC1-JDR3.
ADC1-JDR4.
ADC1-DR.
;

