\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40002800 constant RTC ( Real time clock ) 
RTC $0 + constant RTC-CRH ( RTC Control Register High ) 
RTC $4 + constant RTC-CRL ( RTC Control Register Low ) 
RTC $8 + constant RTC-PRLH ( RTC Prescaler Load Register  High ) 
RTC $C + constant RTC-PRLL ( RTC Prescaler Load Register  Low ) 
RTC $10 + constant RTC-DIVH ( RTC Prescaler Divider Register  High ) 
RTC $14 + constant RTC-DIVL ( RTC Prescaler Divider Register  Low ) 
RTC $18 + constant RTC-CNTH ( RTC Counter Register High ) 
RTC $1C + constant RTC-CNTL ( RTC Counter Register Low ) 
RTC $20 + constant RTC-ALRH ( RTC Alarm Register High ) 
RTC $24 + constant RTC-ALRL ( RTC Alarm Register Low ) 
