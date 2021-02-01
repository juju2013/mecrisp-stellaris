\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: RTC-CRH. ." RTC-CRH (read-write) $" RTC-CRH @ hex. RTC-CRH 1b. ;
: RTC-CRL. ." RTC-CRL () $" RTC-CRL @ hex. RTC-CRL 1b. ;
: RTC-PRLH. ." RTC-PRLH (write-only) $" RTC-PRLH @ hex. RTC-PRLH 1b. ;
: RTC-PRLL. ." RTC-PRLL (write-only) $" RTC-PRLL @ hex. RTC-PRLL 1b. ;
: RTC-DIVH. ." RTC-DIVH (read-only) $" RTC-DIVH @ hex. RTC-DIVH 1b. ;
: RTC-DIVL. ." RTC-DIVL (read-only) $" RTC-DIVL @ hex. RTC-DIVL 1b. ;
: RTC-CNTH. ." RTC-CNTH (read-write) $" RTC-CNTH @ hex. RTC-CNTH 1b. ;
: RTC-CNTL. ." RTC-CNTL (read-write) $" RTC-CNTL @ hex. RTC-CNTL 1b. ;
: RTC-ALRH. ." RTC-ALRH (write-only) $" RTC-ALRH @ hex. RTC-ALRH 1b. ;
: RTC-ALRL. ." RTC-ALRL (write-only) $" RTC-ALRL @ hex. RTC-ALRL 1b. ;
: RTC.
RTC-CRH.
RTC-CRL.
RTC-PRLH.
RTC-PRLL.
RTC-DIVH.
RTC-DIVL.
RTC-CNTH.
RTC-CNTL.
RTC-ALRH.
RTC-ALRL.
;

