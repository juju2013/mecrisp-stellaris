\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: PWR-CR. ." PWR-CR (read-write) $" PWR-CR @ hex. PWR-CR 1b. ;
: PWR-CSR. ." PWR-CSR () $" PWR-CSR @ hex. PWR-CSR 1b. ;
: PWR.
PWR-CR.
PWR-CSR.
;

