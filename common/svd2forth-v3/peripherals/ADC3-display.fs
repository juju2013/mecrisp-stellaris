\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: ADC3-SR. ." ADC3-SR (read-write) $" ADC3-SR @ hex. ADC3-SR 1b. ;
: ADC3-CR1. ." ADC3-CR1 (read-write) $" ADC3-CR1 @ hex. ADC3-CR1 1b. ;
: ADC3-CR2. ." ADC3-CR2 (read-write) $" ADC3-CR2 @ hex. ADC3-CR2 1b. ;
: ADC3-SMPR1. ." ADC3-SMPR1 (read-write) $" ADC3-SMPR1 @ hex. ADC3-SMPR1 1b. ;
: ADC3-SMPR2. ." ADC3-SMPR2 (read-write) $" ADC3-SMPR2 @ hex. ADC3-SMPR2 1b. ;
: ADC3-JOFR1. ." ADC3-JOFR1 (read-write) $" ADC3-JOFR1 @ hex. ADC3-JOFR1 1b. ;
: ADC3-JOFR2. ." ADC3-JOFR2 (read-write) $" ADC3-JOFR2 @ hex. ADC3-JOFR2 1b. ;
: ADC3-JOFR3. ." ADC3-JOFR3 (read-write) $" ADC3-JOFR3 @ hex. ADC3-JOFR3 1b. ;
: ADC3-JOFR4. ." ADC3-JOFR4 (read-write) $" ADC3-JOFR4 @ hex. ADC3-JOFR4 1b. ;
: ADC3-HTR. ." ADC3-HTR (read-write) $" ADC3-HTR @ hex. ADC3-HTR 1b. ;
: ADC3-LTR. ." ADC3-LTR (read-write) $" ADC3-LTR @ hex. ADC3-LTR 1b. ;
: ADC3-SQR1. ." ADC3-SQR1 (read-write) $" ADC3-SQR1 @ hex. ADC3-SQR1 1b. ;
: ADC3-SQR2. ." ADC3-SQR2 (read-write) $" ADC3-SQR2 @ hex. ADC3-SQR2 1b. ;
: ADC3-SQR3. ." ADC3-SQR3 (read-write) $" ADC3-SQR3 @ hex. ADC3-SQR3 1b. ;
: ADC3-JSQR. ." ADC3-JSQR (read-write) $" ADC3-JSQR @ hex. ADC3-JSQR 1b. ;
: ADC3-JDR1. ." ADC3-JDR1 (read-only) $" ADC3-JDR1 @ hex. ADC3-JDR1 1b. ;
: ADC3-JDR2. ." ADC3-JDR2 (read-only) $" ADC3-JDR2 @ hex. ADC3-JDR2 1b. ;
: ADC3-JDR3. ." ADC3-JDR3 (read-only) $" ADC3-JDR3 @ hex. ADC3-JDR3 1b. ;
: ADC3-JDR4. ." ADC3-JDR4 (read-only) $" ADC3-JDR4 @ hex. ADC3-JDR4 1b. ;
: ADC3-DR. ." ADC3-DR (read-only) $" ADC3-DR @ hex. ADC3-DR 1b. ;
: ADC3.
ADC3-SR.
ADC3-CR1.
ADC3-CR2.
ADC3-SMPR1.
ADC3-SMPR2.
ADC3-JOFR1.
ADC3-JOFR2.
ADC3-JOFR3.
ADC3-JOFR4.
ADC3-HTR.
ADC3-LTR.
ADC3-SQR1.
ADC3-SQR2.
ADC3-SQR3.
ADC3-JSQR.
ADC3-JDR1.
ADC3-JDR2.
ADC3-JDR3.
ADC3-JDR4.
ADC3-DR.
;

