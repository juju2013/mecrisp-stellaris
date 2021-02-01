\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: WWDG-CR. ." WWDG-CR (read-write) $" WWDG-CR @ hex. WWDG-CR 1b. ;
: WWDG-CFR. ." WWDG-CFR (read-write) $" WWDG-CFR @ hex. WWDG-CFR 1b. ;
: WWDG-SR. ." WWDG-SR (read-write) $" WWDG-SR @ hex. WWDG-SR 1b. ;
: WWDG.
WWDG-CR.
WWDG-CFR.
WWDG-SR.
;

