\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: I2C1-CR1. ." I2C1-CR1 (read-write) $" I2C1-CR1 @ hex. I2C1-CR1 1b. ;
: I2C1-CR2. ." I2C1-CR2 (read-write) $" I2C1-CR2 @ hex. I2C1-CR2 1b. ;
: I2C1-OAR1. ." I2C1-OAR1 (read-write) $" I2C1-OAR1 @ hex. I2C1-OAR1 1b. ;
: I2C1-OAR2. ." I2C1-OAR2 (read-write) $" I2C1-OAR2 @ hex. I2C1-OAR2 1b. ;
: I2C1-DR. ." I2C1-DR (read-write) $" I2C1-DR @ hex. I2C1-DR 1b. ;
: I2C1-SR1. ." I2C1-SR1 () $" I2C1-SR1 @ hex. I2C1-SR1 1b. ;
: I2C1-SR2. ." I2C1-SR2 (read-only) $" I2C1-SR2 @ hex. I2C1-SR2 1b. ;
: I2C1-CCR. ." I2C1-CCR (read-write) $" I2C1-CCR @ hex. I2C1-CCR 1b. ;
: I2C1-TRISE. ." I2C1-TRISE (read-write) $" I2C1-TRISE @ hex. I2C1-TRISE 1b. ;
: I2C1.
I2C1-CR1.
I2C1-CR2.
I2C1-OAR1.
I2C1-OAR2.
I2C1-DR.
I2C1-SR1.
I2C1-SR2.
I2C1-CCR.
I2C1-TRISE.
;

