\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40002800 constant RTC ( Real time clock ) 
RTC 0x0 + constant RTC-CRH ( RTC Control Register High ) 
RTC 0x4 + constant RTC-CRL ( RTC Control Register Low ) 
RTC 0x8 + constant RTC-PRLH ( RTC Prescaler Load Register  High ) 
RTC 0xC + constant RTC-PRLL ( RTC Prescaler Load Register  Low ) 
RTC 0x10 + constant RTC-DIVH ( RTC Prescaler Divider Register  High ) 
RTC 0x14 + constant RTC-DIVL ( RTC Prescaler Divider Register  Low ) 
RTC 0x18 + constant RTC-CNTH ( RTC Counter Register High ) 
RTC 0x1C + constant RTC-CNTL ( RTC Counter Register Low ) 
RTC 0x20 + constant RTC-ALRH ( RTC Alarm Register High ) 
RTC 0x24 + constant RTC-ALRL ( RTC Alarm Register Low ) 
