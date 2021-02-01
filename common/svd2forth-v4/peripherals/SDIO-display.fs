\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: SDIO-POWER. ." SDIO-POWER (read-write) $" SDIO-POWER @ hex. SDIO-POWER 1b. ;
: SDIO-CLKCR. ." SDIO-CLKCR (read-write) $" SDIO-CLKCR @ hex. SDIO-CLKCR 1b. ;
: SDIO-ARG. ." SDIO-ARG (read-write) $" SDIO-ARG @ hex. SDIO-ARG 1b. ;
: SDIO-CMD. ." SDIO-CMD (read-write) $" SDIO-CMD @ hex. SDIO-CMD 1b. ;
: SDIO-RESPCMD. ." SDIO-RESPCMD (read-only) $" SDIO-RESPCMD @ hex. SDIO-RESPCMD 1b. ;
: SDIO-RESPI1. ." SDIO-RESPI1 (read-only) $" SDIO-RESPI1 @ hex. SDIO-RESPI1 1b. ;
: SDIO-RESP2. ." SDIO-RESP2 (read-only) $" SDIO-RESP2 @ hex. SDIO-RESP2 1b. ;
: SDIO-RESP3. ." SDIO-RESP3 (read-only) $" SDIO-RESP3 @ hex. SDIO-RESP3 1b. ;
: SDIO-RESP4. ." SDIO-RESP4 (read-only) $" SDIO-RESP4 @ hex. SDIO-RESP4 1b. ;
: SDIO-DTIMER. ." SDIO-DTIMER (read-write) $" SDIO-DTIMER @ hex. SDIO-DTIMER 1b. ;
: SDIO-DLEN. ." SDIO-DLEN (read-write) $" SDIO-DLEN @ hex. SDIO-DLEN 1b. ;
: SDIO-DCTRL. ." SDIO-DCTRL (read-write) $" SDIO-DCTRL @ hex. SDIO-DCTRL 1b. ;
: SDIO-DCOUNT. ." SDIO-DCOUNT (read-only) $" SDIO-DCOUNT @ hex. SDIO-DCOUNT 1b. ;
: SDIO-STA. ." SDIO-STA (read-only) $" SDIO-STA @ hex. SDIO-STA 1b. ;
: SDIO-ICR. ." SDIO-ICR (read-write) $" SDIO-ICR @ hex. SDIO-ICR 1b. ;
: SDIO-MASK. ." SDIO-MASK (read-write) $" SDIO-MASK @ hex. SDIO-MASK 1b. ;
: SDIO-FIFOCNT. ." SDIO-FIFOCNT (read-only) $" SDIO-FIFOCNT @ hex. SDIO-FIFOCNT 1b. ;
: SDIO-FIFO. ." SDIO-FIFO (read-write) $" SDIO-FIFO @ hex. SDIO-FIFO 1b. ;
: SDIO.
SDIO-POWER.
SDIO-CLKCR.
SDIO-ARG.
SDIO-CMD.
SDIO-RESPCMD.
SDIO-RESPI1.
SDIO-RESP2.
SDIO-RESP3.
SDIO-RESP4.
SDIO-DTIMER.
SDIO-DLEN.
SDIO-DCTRL.
SDIO-DCOUNT.
SDIO-STA.
SDIO-ICR.
SDIO-MASK.
SDIO-FIFOCNT.
SDIO-FIFO.
;

