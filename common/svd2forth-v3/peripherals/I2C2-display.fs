\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: I2C2-CR1. ." I2C2-CR1 (read-write) $" I2C2-CR1 @ hex. I2C2-CR1 1b. ;
: I2C2-CR2. ." I2C2-CR2 (read-write) $" I2C2-CR2 @ hex. I2C2-CR2 1b. ;
: I2C2-OAR1. ." I2C2-OAR1 (read-write) $" I2C2-OAR1 @ hex. I2C2-OAR1 1b. ;
: I2C2-OAR2. ." I2C2-OAR2 (read-write) $" I2C2-OAR2 @ hex. I2C2-OAR2 1b. ;
: I2C2-DR. ." I2C2-DR (read-write) $" I2C2-DR @ hex. I2C2-DR 1b. ;
: I2C2-SR1. ." I2C2-SR1 () $" I2C2-SR1 @ hex. I2C2-SR1 1b. ;
: I2C2-SR2. ." I2C2-SR2 (read-only) $" I2C2-SR2 @ hex. I2C2-SR2 1b. ;
: I2C2-CCR. ." I2C2-CCR (read-write) $" I2C2-CCR @ hex. I2C2-CCR 1b. ;
: I2C2-TRISE. ." I2C2-TRISE (read-write) $" I2C2-TRISE @ hex. I2C2-TRISE 1b. ;
: I2C2.
I2C2-CR1.
I2C2-CR2.
I2C2-OAR1.
I2C2-OAR2.
I2C2-DR.
I2C2-SR1.
I2C2-SR2.
I2C2-CCR.
I2C2-TRISE.
;

