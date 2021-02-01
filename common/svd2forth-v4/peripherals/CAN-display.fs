\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: CAN-CAN_MCR. ." CAN-CAN_MCR (read-write) $" CAN-CAN_MCR @ hex. CAN-CAN_MCR 1b. ;
: CAN-CAN_MSR. ." CAN-CAN_MSR () $" CAN-CAN_MSR @ hex. CAN-CAN_MSR 1b. ;
: CAN-CAN_TSR. ." CAN-CAN_TSR () $" CAN-CAN_TSR @ hex. CAN-CAN_TSR 1b. ;
: CAN-CAN_RF0R. ." CAN-CAN_RF0R () $" CAN-CAN_RF0R @ hex. CAN-CAN_RF0R 1b. ;
: CAN-CAN_RF1R. ." CAN-CAN_RF1R () $" CAN-CAN_RF1R @ hex. CAN-CAN_RF1R 1b. ;
: CAN-CAN_IER. ." CAN-CAN_IER (read-write) $" CAN-CAN_IER @ hex. CAN-CAN_IER 1b. ;
: CAN-CAN_ESR. ." CAN-CAN_ESR () $" CAN-CAN_ESR @ hex. CAN-CAN_ESR 1b. ;
: CAN-CAN_BTR. ." CAN-CAN_BTR (read-write) $" CAN-CAN_BTR @ hex. CAN-CAN_BTR 1b. ;
: CAN-CAN_TI0R. ." CAN-CAN_TI0R (read-write) $" CAN-CAN_TI0R @ hex. CAN-CAN_TI0R 1b. ;
: CAN-CAN_TDT0R. ." CAN-CAN_TDT0R (read-write) $" CAN-CAN_TDT0R @ hex. CAN-CAN_TDT0R 1b. ;
: CAN-CAN_TDL0R. ." CAN-CAN_TDL0R (read-write) $" CAN-CAN_TDL0R @ hex. CAN-CAN_TDL0R 1b. ;
: CAN-CAN_TDH0R. ." CAN-CAN_TDH0R (read-write) $" CAN-CAN_TDH0R @ hex. CAN-CAN_TDH0R 1b. ;
: CAN-CAN_TI1R. ." CAN-CAN_TI1R (read-write) $" CAN-CAN_TI1R @ hex. CAN-CAN_TI1R 1b. ;
: CAN-CAN_TDT1R. ." CAN-CAN_TDT1R (read-write) $" CAN-CAN_TDT1R @ hex. CAN-CAN_TDT1R 1b. ;
: CAN-CAN_TDL1R. ." CAN-CAN_TDL1R (read-write) $" CAN-CAN_TDL1R @ hex. CAN-CAN_TDL1R 1b. ;
: CAN-CAN_TDH1R. ." CAN-CAN_TDH1R (read-write) $" CAN-CAN_TDH1R @ hex. CAN-CAN_TDH1R 1b. ;
: CAN-CAN_TI2R. ." CAN-CAN_TI2R (read-write) $" CAN-CAN_TI2R @ hex. CAN-CAN_TI2R 1b. ;
: CAN-CAN_TDT2R. ." CAN-CAN_TDT2R (read-write) $" CAN-CAN_TDT2R @ hex. CAN-CAN_TDT2R 1b. ;
: CAN-CAN_TDL2R. ." CAN-CAN_TDL2R (read-write) $" CAN-CAN_TDL2R @ hex. CAN-CAN_TDL2R 1b. ;
: CAN-CAN_TDH2R. ." CAN-CAN_TDH2R (read-write) $" CAN-CAN_TDH2R @ hex. CAN-CAN_TDH2R 1b. ;
: CAN-CAN_RI0R. ." CAN-CAN_RI0R (read-only) $" CAN-CAN_RI0R @ hex. CAN-CAN_RI0R 1b. ;
: CAN-CAN_RDT0R. ." CAN-CAN_RDT0R (read-only) $" CAN-CAN_RDT0R @ hex. CAN-CAN_RDT0R 1b. ;
: CAN-CAN_RDL0R. ." CAN-CAN_RDL0R (read-only) $" CAN-CAN_RDL0R @ hex. CAN-CAN_RDL0R 1b. ;
: CAN-CAN_RDH0R. ." CAN-CAN_RDH0R (read-only) $" CAN-CAN_RDH0R @ hex. CAN-CAN_RDH0R 1b. ;
: CAN-CAN_RI1R. ." CAN-CAN_RI1R (read-only) $" CAN-CAN_RI1R @ hex. CAN-CAN_RI1R 1b. ;
: CAN-CAN_RDT1R. ." CAN-CAN_RDT1R (read-only) $" CAN-CAN_RDT1R @ hex. CAN-CAN_RDT1R 1b. ;
: CAN-CAN_RDL1R. ." CAN-CAN_RDL1R (read-only) $" CAN-CAN_RDL1R @ hex. CAN-CAN_RDL1R 1b. ;
: CAN-CAN_RDH1R. ." CAN-CAN_RDH1R (read-only) $" CAN-CAN_RDH1R @ hex. CAN-CAN_RDH1R 1b. ;
: CAN-CAN_FMR. ." CAN-CAN_FMR (read-write) $" CAN-CAN_FMR @ hex. CAN-CAN_FMR 1b. ;
: CAN-CAN_FM1R. ." CAN-CAN_FM1R (read-write) $" CAN-CAN_FM1R @ hex. CAN-CAN_FM1R 1b. ;
: CAN-CAN_FS1R. ." CAN-CAN_FS1R (read-write) $" CAN-CAN_FS1R @ hex. CAN-CAN_FS1R 1b. ;
: CAN-CAN_FFA1R. ." CAN-CAN_FFA1R (read-write) $" CAN-CAN_FFA1R @ hex. CAN-CAN_FFA1R 1b. ;
: CAN-CAN_FA1R. ." CAN-CAN_FA1R (read-write) $" CAN-CAN_FA1R @ hex. CAN-CAN_FA1R 1b. ;
: CAN-F0R1. ." CAN-F0R1 (read-write) $" CAN-F0R1 @ hex. CAN-F0R1 1b. ;
: CAN-F0R2. ." CAN-F0R2 (read-write) $" CAN-F0R2 @ hex. CAN-F0R2 1b. ;
: CAN-F1R1. ." CAN-F1R1 (read-write) $" CAN-F1R1 @ hex. CAN-F1R1 1b. ;
: CAN-F1R2. ." CAN-F1R2 (read-write) $" CAN-F1R2 @ hex. CAN-F1R2 1b. ;
: CAN-F2R1. ." CAN-F2R1 (read-write) $" CAN-F2R1 @ hex. CAN-F2R1 1b. ;
: CAN-F2R2. ." CAN-F2R2 (read-write) $" CAN-F2R2 @ hex. CAN-F2R2 1b. ;
: CAN-F3R1. ." CAN-F3R1 (read-write) $" CAN-F3R1 @ hex. CAN-F3R1 1b. ;
: CAN-F3R2. ." CAN-F3R2 (read-write) $" CAN-F3R2 @ hex. CAN-F3R2 1b. ;
: CAN-F4R1. ." CAN-F4R1 (read-write) $" CAN-F4R1 @ hex. CAN-F4R1 1b. ;
: CAN-F4R2. ." CAN-F4R2 (read-write) $" CAN-F4R2 @ hex. CAN-F4R2 1b. ;
: CAN-F5R1. ." CAN-F5R1 (read-write) $" CAN-F5R1 @ hex. CAN-F5R1 1b. ;
: CAN-F5R2. ." CAN-F5R2 (read-write) $" CAN-F5R2 @ hex. CAN-F5R2 1b. ;
: CAN-F6R1. ." CAN-F6R1 (read-write) $" CAN-F6R1 @ hex. CAN-F6R1 1b. ;
: CAN-F6R2. ." CAN-F6R2 (read-write) $" CAN-F6R2 @ hex. CAN-F6R2 1b. ;
: CAN-F7R1. ." CAN-F7R1 (read-write) $" CAN-F7R1 @ hex. CAN-F7R1 1b. ;
: CAN-F7R2. ." CAN-F7R2 (read-write) $" CAN-F7R2 @ hex. CAN-F7R2 1b. ;
: CAN-F8R1. ." CAN-F8R1 (read-write) $" CAN-F8R1 @ hex. CAN-F8R1 1b. ;
: CAN-F8R2. ." CAN-F8R2 (read-write) $" CAN-F8R2 @ hex. CAN-F8R2 1b. ;
: CAN-F9R1. ." CAN-F9R1 (read-write) $" CAN-F9R1 @ hex. CAN-F9R1 1b. ;
: CAN-F9R2. ." CAN-F9R2 (read-write) $" CAN-F9R2 @ hex. CAN-F9R2 1b. ;
: CAN-F10R1. ." CAN-F10R1 (read-write) $" CAN-F10R1 @ hex. CAN-F10R1 1b. ;
: CAN-F10R2. ." CAN-F10R2 (read-write) $" CAN-F10R2 @ hex. CAN-F10R2 1b. ;
: CAN-F11R1. ." CAN-F11R1 (read-write) $" CAN-F11R1 @ hex. CAN-F11R1 1b. ;
: CAN-F11R2. ." CAN-F11R2 (read-write) $" CAN-F11R2 @ hex. CAN-F11R2 1b. ;
: CAN-F12R1. ." CAN-F12R1 (read-write) $" CAN-F12R1 @ hex. CAN-F12R1 1b. ;
: CAN-F12R2. ." CAN-F12R2 (read-write) $" CAN-F12R2 @ hex. CAN-F12R2 1b. ;
: CAN-F13R1. ." CAN-F13R1 (read-write) $" CAN-F13R1 @ hex. CAN-F13R1 1b. ;
: CAN-F13R2. ." CAN-F13R2 (read-write) $" CAN-F13R2 @ hex. CAN-F13R2 1b. ;
: CAN.
CAN-CAN_MCR.
CAN-CAN_MSR.
CAN-CAN_TSR.
CAN-CAN_RF0R.
CAN-CAN_RF1R.
CAN-CAN_IER.
CAN-CAN_ESR.
CAN-CAN_BTR.
CAN-CAN_TI0R.
CAN-CAN_TDT0R.
CAN-CAN_TDL0R.
CAN-CAN_TDH0R.
CAN-CAN_TI1R.
CAN-CAN_TDT1R.
CAN-CAN_TDL1R.
CAN-CAN_TDH1R.
CAN-CAN_TI2R.
CAN-CAN_TDT2R.
CAN-CAN_TDL2R.
CAN-CAN_TDH2R.
CAN-CAN_RI0R.
CAN-CAN_RDT0R.
CAN-CAN_RDL0R.
CAN-CAN_RDH0R.
CAN-CAN_RI1R.
CAN-CAN_RDT1R.
CAN-CAN_RDL1R.
CAN-CAN_RDH1R.
CAN-CAN_FMR.
CAN-CAN_FM1R.
CAN-CAN_FS1R.
CAN-CAN_FFA1R.
CAN-CAN_FA1R.
CAN-F0R1.
CAN-F0R2.
CAN-F1R1.
CAN-F1R2.
CAN-F2R1.
CAN-F2R2.
CAN-F3R1.
CAN-F3R2.
CAN-F4R1.
CAN-F4R2.
CAN-F5R1.
CAN-F5R2.
CAN-F6R1.
CAN-F6R2.
CAN-F7R1.
CAN-F7R2.
CAN-F8R1.
CAN-F8R2.
CAN-F9R1.
CAN-F9R2.
CAN-F10R1.
CAN-F10R2.
CAN-F11R1.
CAN-F11R2.
CAN-F12R1.
CAN-F12R2.
CAN-F13R1.
CAN-F13R2.
;

