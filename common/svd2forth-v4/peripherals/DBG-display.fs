\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: DBG-IDCODE. ." DBG-IDCODE (read-only) $" DBG-IDCODE @ hex. DBG-IDCODE 1b. ;
: DBG-CR. ." DBG-CR (read-write) $" DBG-CR @ hex. DBG-CR 1b. ;
: DBG.
DBG-IDCODE.
DBG-CR.
;

