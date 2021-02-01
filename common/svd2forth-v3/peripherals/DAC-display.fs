\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: DAC-CR. ." DAC-CR (read-write) $" DAC-CR @ hex. DAC-CR 1b. ;
: DAC-SWTRIGR. ." DAC-SWTRIGR (write-only) $" DAC-SWTRIGR @ hex. DAC-SWTRIGR 1b. ;
: DAC-DHR12R1. ." DAC-DHR12R1 (read-write) $" DAC-DHR12R1 @ hex. DAC-DHR12R1 1b. ;
: DAC-DHR12L1. ." DAC-DHR12L1 (read-write) $" DAC-DHR12L1 @ hex. DAC-DHR12L1 1b. ;
: DAC-DHR8R1. ." DAC-DHR8R1 (read-write) $" DAC-DHR8R1 @ hex. DAC-DHR8R1 1b. ;
: DAC-DHR12R2. ." DAC-DHR12R2 (read-write) $" DAC-DHR12R2 @ hex. DAC-DHR12R2 1b. ;
: DAC-DHR12L2. ." DAC-DHR12L2 (read-write) $" DAC-DHR12L2 @ hex. DAC-DHR12L2 1b. ;
: DAC-DHR8R2. ." DAC-DHR8R2 (read-write) $" DAC-DHR8R2 @ hex. DAC-DHR8R2 1b. ;
: DAC-DHR12RD. ." DAC-DHR12RD (read-write) $" DAC-DHR12RD @ hex. DAC-DHR12RD 1b. ;
: DAC-DHR12LD. ." DAC-DHR12LD (read-write) $" DAC-DHR12LD @ hex. DAC-DHR12LD 1b. ;
: DAC-DHR8RD. ." DAC-DHR8RD (read-write) $" DAC-DHR8RD @ hex. DAC-DHR8RD 1b. ;
: DAC-DOR1. ." DAC-DOR1 (read-only) $" DAC-DOR1 @ hex. DAC-DOR1 1b. ;
: DAC-DOR2. ." DAC-DOR2 (read-only) $" DAC-DOR2 @ hex. DAC-DOR2 1b. ;
: DAC.
DAC-CR.
DAC-SWTRIGR.
DAC-DHR12R1.
DAC-DHR12L1.
DAC-DHR8R1.
DAC-DHR12R2.
DAC-DHR12L2.
DAC-DHR8R2.
DAC-DHR12RD.
DAC-DHR12LD.
DAC-DHR8RD.
DAC-DOR1.
DAC-DOR2.
;

