\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: FLASH-ACR. ." FLASH-ACR () $" FLASH-ACR @ hex. FLASH-ACR 1b. ;
: FLASH-KEYR. ." FLASH-KEYR (write-only) $" FLASH-KEYR @ hex. FLASH-KEYR 1b. ;
: FLASH-OPTKEYR. ." FLASH-OPTKEYR (write-only) $" FLASH-OPTKEYR @ hex. FLASH-OPTKEYR 1b. ;
: FLASH-SR. ." FLASH-SR () $" FLASH-SR @ hex. FLASH-SR 1b. ;
: FLASH-CR. ." FLASH-CR (read-write) $" FLASH-CR @ hex. FLASH-CR 1b. ;
: FLASH-AR. ." FLASH-AR (write-only) $" FLASH-AR @ hex. FLASH-AR 1b. ;
: FLASH-OBR. ." FLASH-OBR (read-only) $" FLASH-OBR @ hex. FLASH-OBR 1b. ;
: FLASH-WRPR. ." FLASH-WRPR (read-only) $" FLASH-WRPR @ hex. FLASH-WRPR 1b. ;
: FLASH.
FLASH-ACR.
FLASH-KEYR.
FLASH-OPTKEYR.
FLASH-SR.
FLASH-CR.
FLASH-AR.
FLASH-OBR.
FLASH-WRPR.
;

