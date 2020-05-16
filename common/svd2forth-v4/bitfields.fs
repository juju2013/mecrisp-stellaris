\ STM32F103xx Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2018 and released under the GPL V2.
\ Replace 'bis!' (set bit) with 'bic!' to CLEAR bit, 'bit@' to test bit etc.


\ FSMC-BCR1 (read-write)
: FSMC-BCR1_CBURSTRW   %1 19 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_CBURSTRW    CBURSTRW
: FSMC-BCR1_ASYNCWAIT   %1 15 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_ASYNCWAIT    ASYNCWAIT
: FSMC-BCR1_EXTMOD   %1 14 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_EXTMOD    EXTMOD
: FSMC-BCR1_WAITEN   %1 13 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_WAITEN    WAITEN
: FSMC-BCR1_WREN   %1 12 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_WREN    WREN
: FSMC-BCR1_WAITCFG   %1 11 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_WAITCFG    WAITCFG
: FSMC-BCR1_WAITPOL   %1 9 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_WAITPOL    WAITPOL
: FSMC-BCR1_BURSTEN   %1 8 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_BURSTEN    BURSTEN
: FSMC-BCR1_FACCEN   %1 6 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_FACCEN    FACCEN
: FSMC-BCR1_MWID   ( %XX -- ) 4 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_MWID    MWID
: FSMC-BCR1_MTYP   ( %XX -- ) 2 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_MTYP    MTYP
: FSMC-BCR1_MUXEN   %1 1 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_MUXEN    MUXEN
: FSMC-BCR1_MBKEN   %1 0 lshift FSMC-BCR1 bis! ;  \ FSMC-BCR1_MBKEN    MBKEN

\ FSMC-BTR1 (read-write)
: FSMC-BTR1_ACCMOD   ( %XX -- ) 28 lshift FSMC-BTR1 bis! ;  \ FSMC-BTR1_ACCMOD    ACCMOD
: FSMC-BTR1_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BTR1 bis! ;  \ FSMC-BTR1_DATLAT    DATLAT
: FSMC-BTR1_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BTR1 bis! ;  \ FSMC-BTR1_CLKDIV    CLKDIV
: FSMC-BTR1_BUSTURN   ( %XXXX -- ) 16 lshift FSMC-BTR1 bis! ;  \ FSMC-BTR1_BUSTURN    BUSTURN
: FSMC-BTR1_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BTR1 bis! ;  \ FSMC-BTR1_DATAST    DATAST
: FSMC-BTR1_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BTR1 bis! ;  \ FSMC-BTR1_ADDHLD    ADDHLD
: FSMC-BTR1_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BTR1 bis! ;  \ FSMC-BTR1_ADDSET    ADDSET

\ FSMC-BCR2 (read-write)
: FSMC-BCR2_CBURSTRW   %1 19 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_CBURSTRW    CBURSTRW
: FSMC-BCR2_ASYNCWAIT   %1 15 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_ASYNCWAIT    ASYNCWAIT
: FSMC-BCR2_EXTMOD   %1 14 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_EXTMOD    EXTMOD
: FSMC-BCR2_WAITEN   %1 13 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_WAITEN    WAITEN
: FSMC-BCR2_WREN   %1 12 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_WREN    WREN
: FSMC-BCR2_WAITCFG   %1 11 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_WAITCFG    WAITCFG
: FSMC-BCR2_WRAPMOD   %1 10 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_WRAPMOD    WRAPMOD
: FSMC-BCR2_WAITPOL   %1 9 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_WAITPOL    WAITPOL
: FSMC-BCR2_BURSTEN   %1 8 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_BURSTEN    BURSTEN
: FSMC-BCR2_FACCEN   %1 6 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_FACCEN    FACCEN
: FSMC-BCR2_MWID   ( %XX -- ) 4 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_MWID    MWID
: FSMC-BCR2_MTYP   ( %XX -- ) 2 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_MTYP    MTYP
: FSMC-BCR2_MUXEN   %1 1 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_MUXEN    MUXEN
: FSMC-BCR2_MBKEN   %1 0 lshift FSMC-BCR2 bis! ;  \ FSMC-BCR2_MBKEN    MBKEN

\ FSMC-BTR2 (read-write)
: FSMC-BTR2_ACCMOD   ( %XX -- ) 28 lshift FSMC-BTR2 bis! ;  \ FSMC-BTR2_ACCMOD    ACCMOD
: FSMC-BTR2_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BTR2 bis! ;  \ FSMC-BTR2_DATLAT    DATLAT
: FSMC-BTR2_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BTR2 bis! ;  \ FSMC-BTR2_CLKDIV    CLKDIV
: FSMC-BTR2_BUSTURN   ( %XXXX -- ) 16 lshift FSMC-BTR2 bis! ;  \ FSMC-BTR2_BUSTURN    BUSTURN
: FSMC-BTR2_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BTR2 bis! ;  \ FSMC-BTR2_DATAST    DATAST
: FSMC-BTR2_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BTR2 bis! ;  \ FSMC-BTR2_ADDHLD    ADDHLD
: FSMC-BTR2_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BTR2 bis! ;  \ FSMC-BTR2_ADDSET    ADDSET

\ FSMC-BCR3 (read-write)
: FSMC-BCR3_CBURSTRW   %1 19 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_CBURSTRW    CBURSTRW
: FSMC-BCR3_ASYNCWAIT   %1 15 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_ASYNCWAIT    ASYNCWAIT
: FSMC-BCR3_EXTMOD   %1 14 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_EXTMOD    EXTMOD
: FSMC-BCR3_WAITEN   %1 13 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_WAITEN    WAITEN
: FSMC-BCR3_WREN   %1 12 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_WREN    WREN
: FSMC-BCR3_WAITCFG   %1 11 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_WAITCFG    WAITCFG
: FSMC-BCR3_WRAPMOD   %1 10 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_WRAPMOD    WRAPMOD
: FSMC-BCR3_WAITPOL   %1 9 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_WAITPOL    WAITPOL
: FSMC-BCR3_BURSTEN   %1 8 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_BURSTEN    BURSTEN
: FSMC-BCR3_FACCEN   %1 6 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_FACCEN    FACCEN
: FSMC-BCR3_MWID   ( %XX -- ) 4 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_MWID    MWID
: FSMC-BCR3_MTYP   ( %XX -- ) 2 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_MTYP    MTYP
: FSMC-BCR3_MUXEN   %1 1 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_MUXEN    MUXEN
: FSMC-BCR3_MBKEN   %1 0 lshift FSMC-BCR3 bis! ;  \ FSMC-BCR3_MBKEN    MBKEN

\ FSMC-BTR3 (read-write)
: FSMC-BTR3_ACCMOD   ( %XX -- ) 28 lshift FSMC-BTR3 bis! ;  \ FSMC-BTR3_ACCMOD    ACCMOD
: FSMC-BTR3_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BTR3 bis! ;  \ FSMC-BTR3_DATLAT    DATLAT
: FSMC-BTR3_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BTR3 bis! ;  \ FSMC-BTR3_CLKDIV    CLKDIV
: FSMC-BTR3_BUSTURN   ( %XXXX -- ) 16 lshift FSMC-BTR3 bis! ;  \ FSMC-BTR3_BUSTURN    BUSTURN
: FSMC-BTR3_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BTR3 bis! ;  \ FSMC-BTR3_DATAST    DATAST
: FSMC-BTR3_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BTR3 bis! ;  \ FSMC-BTR3_ADDHLD    ADDHLD
: FSMC-BTR3_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BTR3 bis! ;  \ FSMC-BTR3_ADDSET    ADDSET

\ FSMC-BCR4 (read-write)
: FSMC-BCR4_CBURSTRW   %1 19 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_CBURSTRW    CBURSTRW
: FSMC-BCR4_ASYNCWAIT   %1 15 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_ASYNCWAIT    ASYNCWAIT
: FSMC-BCR4_EXTMOD   %1 14 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_EXTMOD    EXTMOD
: FSMC-BCR4_WAITEN   %1 13 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_WAITEN    WAITEN
: FSMC-BCR4_WREN   %1 12 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_WREN    WREN
: FSMC-BCR4_WAITCFG   %1 11 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_WAITCFG    WAITCFG
: FSMC-BCR4_WRAPMOD   %1 10 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_WRAPMOD    WRAPMOD
: FSMC-BCR4_WAITPOL   %1 9 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_WAITPOL    WAITPOL
: FSMC-BCR4_BURSTEN   %1 8 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_BURSTEN    BURSTEN
: FSMC-BCR4_FACCEN   %1 6 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_FACCEN    FACCEN
: FSMC-BCR4_MWID   ( %XX -- ) 4 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_MWID    MWID
: FSMC-BCR4_MTYP   ( %XX -- ) 2 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_MTYP    MTYP
: FSMC-BCR4_MUXEN   %1 1 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_MUXEN    MUXEN
: FSMC-BCR4_MBKEN   %1 0 lshift FSMC-BCR4 bis! ;  \ FSMC-BCR4_MBKEN    MBKEN

\ FSMC-BTR4 (read-write)
: FSMC-BTR4_ACCMOD   ( %XX -- ) 28 lshift FSMC-BTR4 bis! ;  \ FSMC-BTR4_ACCMOD    ACCMOD
: FSMC-BTR4_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BTR4 bis! ;  \ FSMC-BTR4_DATLAT    DATLAT
: FSMC-BTR4_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BTR4 bis! ;  \ FSMC-BTR4_CLKDIV    CLKDIV
: FSMC-BTR4_BUSTURN   ( %XXXX -- ) 16 lshift FSMC-BTR4 bis! ;  \ FSMC-BTR4_BUSTURN    BUSTURN
: FSMC-BTR4_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BTR4 bis! ;  \ FSMC-BTR4_DATAST    DATAST
: FSMC-BTR4_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BTR4 bis! ;  \ FSMC-BTR4_ADDHLD    ADDHLD
: FSMC-BTR4_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BTR4 bis! ;  \ FSMC-BTR4_ADDSET    ADDSET

\ FSMC-PCR2 (read-write)
: FSMC-PCR2_ECCPS   ( %XXX -- ) 17 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_ECCPS    ECCPS
: FSMC-PCR2_TAR   ( %XXXX -- ) 13 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_TAR    TAR
: FSMC-PCR2_TCLR   ( %XXXX -- ) 9 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_TCLR    TCLR
: FSMC-PCR2_ECCEN   %1 6 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_ECCEN    ECCEN
: FSMC-PCR2_PWID   ( %XX -- ) 4 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_PWID    PWID
: FSMC-PCR2_PTYP   %1 3 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_PTYP    PTYP
: FSMC-PCR2_PBKEN   %1 2 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_PBKEN    PBKEN
: FSMC-PCR2_PWAITEN   %1 1 lshift FSMC-PCR2 bis! ;  \ FSMC-PCR2_PWAITEN    PWAITEN

\ FSMC-SR2 ()
: FSMC-SR2_FEMPT   %1 6 lshift FSMC-SR2 bis! ;  \ FSMC-SR2_FEMPT    FEMPT
: FSMC-SR2_IFEN   %1 5 lshift FSMC-SR2 bis! ;  \ FSMC-SR2_IFEN    IFEN
: FSMC-SR2_ILEN   %1 4 lshift FSMC-SR2 bis! ;  \ FSMC-SR2_ILEN    ILEN
: FSMC-SR2_IREN   %1 3 lshift FSMC-SR2 bis! ;  \ FSMC-SR2_IREN    IREN
: FSMC-SR2_IFS   %1 2 lshift FSMC-SR2 bis! ;  \ FSMC-SR2_IFS    IFS
: FSMC-SR2_ILS   %1 1 lshift FSMC-SR2 bis! ;  \ FSMC-SR2_ILS    ILS
: FSMC-SR2_IRS   %1 0 lshift FSMC-SR2 bis! ;  \ FSMC-SR2_IRS    IRS

\ FSMC-PMEM2 (read-write)
: FSMC-PMEM2_MEMHIZx   ( %XXXXXXXX -- ) 24 lshift FSMC-PMEM2 bis! ;  \ FSMC-PMEM2_MEMHIZx    MEMHIZx
: FSMC-PMEM2_MEMHOLDx   ( %XXXXXXXX -- ) 16 lshift FSMC-PMEM2 bis! ;  \ FSMC-PMEM2_MEMHOLDx    MEMHOLDx
: FSMC-PMEM2_MEMWAITx   ( %XXXXXXXX -- ) 8 lshift FSMC-PMEM2 bis! ;  \ FSMC-PMEM2_MEMWAITx    MEMWAITx
: FSMC-PMEM2_MEMSETx   ( %XXXXXXXX -- ) 0 lshift FSMC-PMEM2 bis! ;  \ FSMC-PMEM2_MEMSETx    MEMSETx

\ FSMC-PATT2 (read-write)
: FSMC-PATT2_ATTHIZx   ( %XXXXXXXX -- ) 24 lshift FSMC-PATT2 bis! ;  \ FSMC-PATT2_ATTHIZx    Attribute memory x databus HiZ  time
: FSMC-PATT2_ATTHOLDx   ( %XXXXXXXX -- ) 16 lshift FSMC-PATT2 bis! ;  \ FSMC-PATT2_ATTHOLDx    Attribute memory x hold  time
: FSMC-PATT2_ATTWAITx   ( %XXXXXXXX -- ) 8 lshift FSMC-PATT2 bis! ;  \ FSMC-PATT2_ATTWAITx    Attribute memory x wait  time
: FSMC-PATT2_ATTSETx   ( %XXXXXXXX -- ) 0 lshift FSMC-PATT2 bis! ;  \ FSMC-PATT2_ATTSETx    Attribute memory x setup  time

\ FSMC-ECCR2 (read-only)
: FSMC-ECCR2_ECCx   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FSMC-ECCR2 bis! ;  \ FSMC-ECCR2_ECCx    ECC result

\ FSMC-PCR3 (read-write)
: FSMC-PCR3_ECCPS   ( %XXX -- ) 17 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_ECCPS    ECCPS
: FSMC-PCR3_TAR   ( %XXXX -- ) 13 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_TAR    TAR
: FSMC-PCR3_TCLR   ( %XXXX -- ) 9 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_TCLR    TCLR
: FSMC-PCR3_ECCEN   %1 6 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_ECCEN    ECCEN
: FSMC-PCR3_PWID   ( %XX -- ) 4 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_PWID    PWID
: FSMC-PCR3_PTYP   %1 3 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_PTYP    PTYP
: FSMC-PCR3_PBKEN   %1 2 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_PBKEN    PBKEN
: FSMC-PCR3_PWAITEN   %1 1 lshift FSMC-PCR3 bis! ;  \ FSMC-PCR3_PWAITEN    PWAITEN

\ FSMC-SR3 ()
: FSMC-SR3_FEMPT   %1 6 lshift FSMC-SR3 bis! ;  \ FSMC-SR3_FEMPT    FEMPT
: FSMC-SR3_IFEN   %1 5 lshift FSMC-SR3 bis! ;  \ FSMC-SR3_IFEN    IFEN
: FSMC-SR3_ILEN   %1 4 lshift FSMC-SR3 bis! ;  \ FSMC-SR3_ILEN    ILEN
: FSMC-SR3_IREN   %1 3 lshift FSMC-SR3 bis! ;  \ FSMC-SR3_IREN    IREN
: FSMC-SR3_IFS   %1 2 lshift FSMC-SR3 bis! ;  \ FSMC-SR3_IFS    IFS
: FSMC-SR3_ILS   %1 1 lshift FSMC-SR3 bis! ;  \ FSMC-SR3_ILS    ILS
: FSMC-SR3_IRS   %1 0 lshift FSMC-SR3 bis! ;  \ FSMC-SR3_IRS    IRS

\ FSMC-PMEM3 (read-write)
: FSMC-PMEM3_MEMHIZx   ( %XXXXXXXX -- ) 24 lshift FSMC-PMEM3 bis! ;  \ FSMC-PMEM3_MEMHIZx    MEMHIZx
: FSMC-PMEM3_MEMHOLDx   ( %XXXXXXXX -- ) 16 lshift FSMC-PMEM3 bis! ;  \ FSMC-PMEM3_MEMHOLDx    MEMHOLDx
: FSMC-PMEM3_MEMWAITx   ( %XXXXXXXX -- ) 8 lshift FSMC-PMEM3 bis! ;  \ FSMC-PMEM3_MEMWAITx    MEMWAITx
: FSMC-PMEM3_MEMSETx   ( %XXXXXXXX -- ) 0 lshift FSMC-PMEM3 bis! ;  \ FSMC-PMEM3_MEMSETx    MEMSETx

\ FSMC-PATT3 (read-write)
: FSMC-PATT3_ATTHIZx   ( %XXXXXXXX -- ) 24 lshift FSMC-PATT3 bis! ;  \ FSMC-PATT3_ATTHIZx    ATTHIZx
: FSMC-PATT3_ATTHOLDx   ( %XXXXXXXX -- ) 16 lshift FSMC-PATT3 bis! ;  \ FSMC-PATT3_ATTHOLDx    ATTHOLDx
: FSMC-PATT3_ATTWAITx   ( %XXXXXXXX -- ) 8 lshift FSMC-PATT3 bis! ;  \ FSMC-PATT3_ATTWAITx    ATTWAITx
: FSMC-PATT3_ATTSETx   ( %XXXXXXXX -- ) 0 lshift FSMC-PATT3 bis! ;  \ FSMC-PATT3_ATTSETx    ATTSETx

\ FSMC-ECCR3 (read-only)
: FSMC-ECCR3_ECCx   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FSMC-ECCR3 bis! ;  \ FSMC-ECCR3_ECCx    ECCx

\ FSMC-PCR4 (read-write)
: FSMC-PCR4_ECCPS   ( %XXX -- ) 17 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_ECCPS    ECCPS
: FSMC-PCR4_TAR   ( %XXXX -- ) 13 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_TAR    TAR
: FSMC-PCR4_TCLR   ( %XXXX -- ) 9 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_TCLR    TCLR
: FSMC-PCR4_ECCEN   %1 6 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_ECCEN    ECCEN
: FSMC-PCR4_PWID   ( %XX -- ) 4 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_PWID    PWID
: FSMC-PCR4_PTYP   %1 3 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_PTYP    PTYP
: FSMC-PCR4_PBKEN   %1 2 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_PBKEN    PBKEN
: FSMC-PCR4_PWAITEN   %1 1 lshift FSMC-PCR4 bis! ;  \ FSMC-PCR4_PWAITEN    PWAITEN

\ FSMC-SR4 ()
: FSMC-SR4_FEMPT   %1 6 lshift FSMC-SR4 bis! ;  \ FSMC-SR4_FEMPT    FEMPT
: FSMC-SR4_IFEN   %1 5 lshift FSMC-SR4 bis! ;  \ FSMC-SR4_IFEN    IFEN
: FSMC-SR4_ILEN   %1 4 lshift FSMC-SR4 bis! ;  \ FSMC-SR4_ILEN    ILEN
: FSMC-SR4_IREN   %1 3 lshift FSMC-SR4 bis! ;  \ FSMC-SR4_IREN    IREN
: FSMC-SR4_IFS   %1 2 lshift FSMC-SR4 bis! ;  \ FSMC-SR4_IFS    IFS
: FSMC-SR4_ILS   %1 1 lshift FSMC-SR4 bis! ;  \ FSMC-SR4_ILS    ILS
: FSMC-SR4_IRS   %1 0 lshift FSMC-SR4 bis! ;  \ FSMC-SR4_IRS    IRS

\ FSMC-PMEM4 (read-write)
: FSMC-PMEM4_MEMHIZx   ( %XXXXXXXX -- ) 24 lshift FSMC-PMEM4 bis! ;  \ FSMC-PMEM4_MEMHIZx    MEMHIZx
: FSMC-PMEM4_MEMHOLDx   ( %XXXXXXXX -- ) 16 lshift FSMC-PMEM4 bis! ;  \ FSMC-PMEM4_MEMHOLDx    MEMHOLDx
: FSMC-PMEM4_MEMWAITx   ( %XXXXXXXX -- ) 8 lshift FSMC-PMEM4 bis! ;  \ FSMC-PMEM4_MEMWAITx    MEMWAITx
: FSMC-PMEM4_MEMSETx   ( %XXXXXXXX -- ) 0 lshift FSMC-PMEM4 bis! ;  \ FSMC-PMEM4_MEMSETx    MEMSETx

\ FSMC-PATT4 (read-write)
: FSMC-PATT4_ATTHIZx   ( %XXXXXXXX -- ) 24 lshift FSMC-PATT4 bis! ;  \ FSMC-PATT4_ATTHIZx    ATTHIZx
: FSMC-PATT4_ATTHOLDx   ( %XXXXXXXX -- ) 16 lshift FSMC-PATT4 bis! ;  \ FSMC-PATT4_ATTHOLDx    ATTHOLDx
: FSMC-PATT4_ATTWAITx   ( %XXXXXXXX -- ) 8 lshift FSMC-PATT4 bis! ;  \ FSMC-PATT4_ATTWAITx    ATTWAITx
: FSMC-PATT4_ATTSETx   ( %XXXXXXXX -- ) 0 lshift FSMC-PATT4 bis! ;  \ FSMC-PATT4_ATTSETx    ATTSETx

\ FSMC-PIO4 (read-write)
: FSMC-PIO4_IOHIZx   ( %XXXXXXXX -- ) 24 lshift FSMC-PIO4 bis! ;  \ FSMC-PIO4_IOHIZx    IOHIZx
: FSMC-PIO4_IOHOLDx   ( %XXXXXXXX -- ) 16 lshift FSMC-PIO4 bis! ;  \ FSMC-PIO4_IOHOLDx    IOHOLDx
: FSMC-PIO4_IOWAITx   ( %XXXXXXXX -- ) 8 lshift FSMC-PIO4 bis! ;  \ FSMC-PIO4_IOWAITx    IOWAITx
: FSMC-PIO4_IOSETx   ( %XXXXXXXX -- ) 0 lshift FSMC-PIO4 bis! ;  \ FSMC-PIO4_IOSETx    IOSETx

\ FSMC-BWTR1 (read-write)
: FSMC-BWTR1_ACCMOD   ( %XX -- ) 28 lshift FSMC-BWTR1 bis! ;  \ FSMC-BWTR1_ACCMOD    ACCMOD
: FSMC-BWTR1_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BWTR1 bis! ;  \ FSMC-BWTR1_DATLAT    DATLAT
: FSMC-BWTR1_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BWTR1 bis! ;  \ FSMC-BWTR1_CLKDIV    CLKDIV
: FSMC-BWTR1_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BWTR1 bis! ;  \ FSMC-BWTR1_DATAST    DATAST
: FSMC-BWTR1_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BWTR1 bis! ;  \ FSMC-BWTR1_ADDHLD    ADDHLD
: FSMC-BWTR1_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BWTR1 bis! ;  \ FSMC-BWTR1_ADDSET    ADDSET

\ FSMC-BWTR2 (read-write)
: FSMC-BWTR2_ACCMOD   ( %XX -- ) 28 lshift FSMC-BWTR2 bis! ;  \ FSMC-BWTR2_ACCMOD    ACCMOD
: FSMC-BWTR2_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BWTR2 bis! ;  \ FSMC-BWTR2_DATLAT    DATLAT
: FSMC-BWTR2_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BWTR2 bis! ;  \ FSMC-BWTR2_CLKDIV    CLKDIV
: FSMC-BWTR2_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BWTR2 bis! ;  \ FSMC-BWTR2_DATAST    DATAST
: FSMC-BWTR2_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BWTR2 bis! ;  \ FSMC-BWTR2_ADDHLD    ADDHLD
: FSMC-BWTR2_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BWTR2 bis! ;  \ FSMC-BWTR2_ADDSET    ADDSET

\ FSMC-BWTR3 (read-write)
: FSMC-BWTR3_ACCMOD   ( %XX -- ) 28 lshift FSMC-BWTR3 bis! ;  \ FSMC-BWTR3_ACCMOD    ACCMOD
: FSMC-BWTR3_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BWTR3 bis! ;  \ FSMC-BWTR3_DATLAT    DATLAT
: FSMC-BWTR3_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BWTR3 bis! ;  \ FSMC-BWTR3_CLKDIV    CLKDIV
: FSMC-BWTR3_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BWTR3 bis! ;  \ FSMC-BWTR3_DATAST    DATAST
: FSMC-BWTR3_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BWTR3 bis! ;  \ FSMC-BWTR3_ADDHLD    ADDHLD
: FSMC-BWTR3_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BWTR3 bis! ;  \ FSMC-BWTR3_ADDSET    ADDSET

\ FSMC-BWTR4 (read-write)
: FSMC-BWTR4_ACCMOD   ( %XX -- ) 28 lshift FSMC-BWTR4 bis! ;  \ FSMC-BWTR4_ACCMOD    ACCMOD
: FSMC-BWTR4_DATLAT   ( %XXXX -- ) 24 lshift FSMC-BWTR4 bis! ;  \ FSMC-BWTR4_DATLAT    DATLAT
: FSMC-BWTR4_CLKDIV   ( %XXXX -- ) 20 lshift FSMC-BWTR4 bis! ;  \ FSMC-BWTR4_CLKDIV    CLKDIV
: FSMC-BWTR4_DATAST   ( %XXXXXXXX -- ) 8 lshift FSMC-BWTR4 bis! ;  \ FSMC-BWTR4_DATAST    DATAST
: FSMC-BWTR4_ADDHLD   ( %XXXX -- ) 4 lshift FSMC-BWTR4 bis! ;  \ FSMC-BWTR4_ADDHLD    ADDHLD
: FSMC-BWTR4_ADDSET   ( %XXXX -- ) 0 lshift FSMC-BWTR4 bis! ;  \ FSMC-BWTR4_ADDSET    ADDSET

\ PWR-CR (read-write)
: PWR-CR_LPDS   %1 0 lshift PWR-CR bis! ;  \ PWR-CR_LPDS    Low Power Deep Sleep
: PWR-CR_PDDS   %1 1 lshift PWR-CR bis! ;  \ PWR-CR_PDDS    Power Down Deep Sleep
: PWR-CR_CWUF   %1 2 lshift PWR-CR bis! ;  \ PWR-CR_CWUF    Clear Wake-up Flag
: PWR-CR_CSBF   %1 3 lshift PWR-CR bis! ;  \ PWR-CR_CSBF    Clear STANDBY Flag
: PWR-CR_PVDE   %1 4 lshift PWR-CR bis! ;  \ PWR-CR_PVDE    Power Voltage Detector  Enable
: PWR-CR_PLS   ( %XXX -- ) 5 lshift PWR-CR bis! ;  \ PWR-CR_PLS    PVD Level Selection
: PWR-CR_DBP   %1 8 lshift PWR-CR bis! ;  \ PWR-CR_DBP    Disable Backup Domain write  protection

\ PWR-CSR ()
: PWR-CSR_WUF   %1 0 lshift PWR-CSR bis! ;  \ PWR-CSR_WUF    Wake-Up Flag
: PWR-CSR_SBF   %1 1 lshift PWR-CSR bis! ;  \ PWR-CSR_SBF    STANDBY Flag
: PWR-CSR_PVDO   %1 2 lshift PWR-CSR bis! ;  \ PWR-CSR_PVDO    PVD Output
: PWR-CSR_EWUP   %1 8 lshift PWR-CSR bis! ;  \ PWR-CSR_EWUP    Enable WKUP pin

\ RCC-CR ()
: RCC-CR_HSION   %1 0 lshift RCC-CR bis! ;  \ RCC-CR_HSION    Internal High Speed clock  enable
: RCC-CR_HSIRDY   %1 1 lshift RCC-CR bis! ;  \ RCC-CR_HSIRDY    Internal High Speed clock ready  flag
: RCC-CR_HSITRIM   ( %XXXXX -- ) 3 lshift RCC-CR bis! ;  \ RCC-CR_HSITRIM    Internal High Speed clock  trimming
: RCC-CR_HSICAL   ( %XXXXXXXX -- ) 8 lshift RCC-CR bis! ;  \ RCC-CR_HSICAL    Internal High Speed clock  Calibration
: RCC-CR_HSEON   %1 16 lshift RCC-CR bis! ;  \ RCC-CR_HSEON    External High Speed clock  enable
: RCC-CR_HSERDY   %1 17 lshift RCC-CR bis! ;  \ RCC-CR_HSERDY    External High Speed clock ready  flag
: RCC-CR_HSEBYP   %1 18 lshift RCC-CR bis! ;  \ RCC-CR_HSEBYP    External High Speed clock  Bypass
: RCC-CR_CSSON   %1 19 lshift RCC-CR bis! ;  \ RCC-CR_CSSON    Clock Security System  enable
: RCC-CR_PLLON   %1 24 lshift RCC-CR bis! ;  \ RCC-CR_PLLON    PLL enable
: RCC-CR_PLLRDY   %1 25 lshift RCC-CR bis! ;  \ RCC-CR_PLLRDY    PLL clock ready flag

\ RCC-CFGR ()
: RCC-CFGR_SW   ( %XX -- ) 0 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SW    System clock Switch
: RCC-CFGR_SWS   ( %XX -- ) 2 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SWS    System Clock Switch Status
: RCC-CFGR_HPRE   ( %XXXX -- ) 4 lshift RCC-CFGR bis! ;  \ RCC-CFGR_HPRE    AHB prescaler
: RCC-CFGR_PPRE1   ( %XXX -- ) 8 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE1    APB Low speed prescaler  APB1
: RCC-CFGR_PPRE2   ( %XXX -- ) 11 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE2    APB High speed prescaler  APB2
: RCC-CFGR_ADCPRE   ( %XX -- ) 14 lshift RCC-CFGR bis! ;  \ RCC-CFGR_ADCPRE    ADC prescaler
: RCC-CFGR_PLLSRC   %1 16 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PLLSRC    PLL entry clock source
: RCC-CFGR_PLLXTPRE   %1 17 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PLLXTPRE    HSE divider for PLL entry
: RCC-CFGR_PLLMUL   ( %XXXX -- ) 18 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PLLMUL    PLL Multiplication Factor
: RCC-CFGR_OTGFSPRE   %1 22 lshift RCC-CFGR bis! ;  \ RCC-CFGR_OTGFSPRE    USB OTG FS prescaler
: RCC-CFGR_MCO   ( %XXX -- ) 24 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCO    Microcontroller clock  output

\ RCC-CIR ()
: RCC-CIR_LSIRDYF   %1 0 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYF    LSI Ready Interrupt flag
: RCC-CIR_LSERDYF   %1 1 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYF    LSE Ready Interrupt flag
: RCC-CIR_HSIRDYF   %1 2 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYF    HSI Ready Interrupt flag
: RCC-CIR_HSERDYF   %1 3 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYF    HSE Ready Interrupt flag
: RCC-CIR_PLLRDYF   %1 4 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYF    PLL Ready Interrupt flag
: RCC-CIR_CSSF   %1 7 lshift RCC-CIR bis! ;  \ RCC-CIR_CSSF    Clock Security System Interrupt  flag
: RCC-CIR_LSIRDYIE   %1 8 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYIE    LSI Ready Interrupt Enable
: RCC-CIR_LSERDYIE   %1 9 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYIE    LSE Ready Interrupt Enable
: RCC-CIR_HSIRDYIE   %1 10 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYIE    HSI Ready Interrupt Enable
: RCC-CIR_HSERDYIE   %1 11 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYIE    HSE Ready Interrupt Enable
: RCC-CIR_PLLRDYIE   %1 12 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYIE    PLL Ready Interrupt Enable
: RCC-CIR_LSIRDYC   %1 16 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYC    LSI Ready Interrupt Clear
: RCC-CIR_LSERDYC   %1 17 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYC    LSE Ready Interrupt Clear
: RCC-CIR_HSIRDYC   %1 18 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYC    HSI Ready Interrupt Clear
: RCC-CIR_HSERDYC   %1 19 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYC    HSE Ready Interrupt Clear
: RCC-CIR_PLLRDYC   %1 20 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYC    PLL Ready Interrupt Clear
: RCC-CIR_CSSC   %1 23 lshift RCC-CIR bis! ;  \ RCC-CIR_CSSC    Clock security system interrupt  clear

\ RCC-APB2RSTR (read-write)
: RCC-APB2RSTR_AFIORST   %1 0 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_AFIORST    Alternate function I/O  reset
: RCC-APB2RSTR_IOPARST   %1 2 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_IOPARST    IO port A reset
: RCC-APB2RSTR_IOPBRST   %1 3 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_IOPBRST    IO port B reset
: RCC-APB2RSTR_IOPCRST   %1 4 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_IOPCRST    IO port C reset
: RCC-APB2RSTR_IOPDRST   %1 5 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_IOPDRST    IO port D reset
: RCC-APB2RSTR_IOPERST   %1 6 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_IOPERST    IO port E reset
: RCC-APB2RSTR_IOPFRST   %1 7 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_IOPFRST    IO port F reset
: RCC-APB2RSTR_IOPGRST   %1 8 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_IOPGRST    IO port G reset
: RCC-APB2RSTR_ADC1RST   %1 9 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_ADC1RST    ADC 1 interface reset
: RCC-APB2RSTR_ADC2RST   %1 10 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_ADC2RST    ADC 2 interface reset
: RCC-APB2RSTR_TIM1RST   %1 11 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM1RST    TIM1 timer reset
: RCC-APB2RSTR_SPI1RST   %1 12 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_SPI1RST    SPI 1 reset
: RCC-APB2RSTR_TIM8RST   %1 13 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM8RST    TIM8 timer reset
: RCC-APB2RSTR_USART1RST   %1 14 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_USART1RST    USART1 reset
: RCC-APB2RSTR_ADC3RST   %1 15 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_ADC3RST    ADC 3 interface reset
: RCC-APB2RSTR_TIM9RST   %1 19 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM9RST    TIM9 timer reset
: RCC-APB2RSTR_TIM10RST   %1 20 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM10RST    TIM10 timer reset
: RCC-APB2RSTR_TIM11RST   %1 21 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM11RST    TIM11 timer reset

\ RCC-APB1RSTR (read-write)
: RCC-APB1RSTR_TIM2RST   %1 0 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM2RST    Timer 2 reset
: RCC-APB1RSTR_TIM3RST   %1 1 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM3RST    Timer 3 reset
: RCC-APB1RSTR_TIM4RST   %1 2 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM4RST    Timer 4 reset
: RCC-APB1RSTR_TIM5RST   %1 3 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM5RST    Timer 5 reset
: RCC-APB1RSTR_TIM6RST   %1 4 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM6RST    Timer 6 reset
: RCC-APB1RSTR_TIM7RST   %1 5 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM7RST    Timer 7 reset
: RCC-APB1RSTR_TIM12RST   %1 6 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM12RST    Timer 12 reset
: RCC-APB1RSTR_TIM13RST   %1 7 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM13RST    Timer 13 reset
: RCC-APB1RSTR_TIM14RST   %1 8 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM14RST    Timer 14 reset
: RCC-APB1RSTR_WWDGRST   %1 11 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_WWDGRST    Window watchdog reset
: RCC-APB1RSTR_SPI2RST   %1 14 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_SPI2RST    SPI2 reset
: RCC-APB1RSTR_SPI3RST   %1 15 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_SPI3RST    SPI3 reset
: RCC-APB1RSTR_USART2RST   %1 17 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_USART2RST    USART 2 reset
: RCC-APB1RSTR_USART3RST   %1 18 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_USART3RST    USART 3 reset
: RCC-APB1RSTR_UART4RST   %1 19 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_UART4RST    UART 4 reset
: RCC-APB1RSTR_UART5RST   %1 20 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_UART5RST    UART 5 reset
: RCC-APB1RSTR_I2C1RST   %1 21 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_I2C1RST    I2C1 reset
: RCC-APB1RSTR_I2C2RST   %1 22 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_I2C2RST    I2C2 reset
: RCC-APB1RSTR_USBRST   %1 23 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_USBRST    USB reset
: RCC-APB1RSTR_CANRST   %1 25 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_CANRST    CAN reset
: RCC-APB1RSTR_BKPRST   %1 27 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_BKPRST    Backup interface reset
: RCC-APB1RSTR_PWRRST   %1 28 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_PWRRST    Power interface reset
: RCC-APB1RSTR_DACRST   %1 29 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_DACRST    DAC interface reset

\ RCC-AHBENR (read-write)
: RCC-AHBENR_DMA1EN   %1 0 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_DMA1EN    DMA1 clock enable
: RCC-AHBENR_DMA2EN   %1 1 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_DMA2EN    DMA2 clock enable
: RCC-AHBENR_SRAMEN   %1 2 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_SRAMEN    SRAM interface clock  enable
: RCC-AHBENR_FLITFEN   %1 4 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_FLITFEN    FLITF clock enable
: RCC-AHBENR_CRCEN   %1 6 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_CRCEN    CRC clock enable
: RCC-AHBENR_FSMCEN   %1 8 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_FSMCEN    FSMC clock enable
: RCC-AHBENR_SDIOEN   %1 10 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_SDIOEN    SDIO clock enable

\ RCC-APB2ENR (read-write)
: RCC-APB2ENR_AFIOEN   %1 0 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_AFIOEN    Alternate function I/O clock  enable
: RCC-APB2ENR_IOPAEN   %1 2 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_IOPAEN    I/O port A clock enable
: RCC-APB2ENR_IOPBEN   %1 3 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_IOPBEN    I/O port B clock enable
: RCC-APB2ENR_IOPCEN   %1 4 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_IOPCEN    I/O port C clock enable
: RCC-APB2ENR_IOPDEN   %1 5 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_IOPDEN    I/O port D clock enable
: RCC-APB2ENR_IOPEEN   %1 6 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_IOPEEN    I/O port E clock enable
: RCC-APB2ENR_IOPFEN   %1 7 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_IOPFEN    I/O port F clock enable
: RCC-APB2ENR_IOPGEN   %1 8 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_IOPGEN    I/O port G clock enable
: RCC-APB2ENR_ADC1EN   %1 9 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_ADC1EN    ADC 1 interface clock  enable
: RCC-APB2ENR_ADC2EN   %1 10 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_ADC2EN    ADC 2 interface clock  enable
: RCC-APB2ENR_TIM1EN   %1 11 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM1EN    TIM1 Timer clock enable
: RCC-APB2ENR_SPI1EN   %1 12 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SPI1EN    SPI 1 clock enable
: RCC-APB2ENR_TIM8EN   %1 13 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM8EN    TIM8 Timer clock enable
: RCC-APB2ENR_USART1EN   %1 14 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_USART1EN    USART1 clock enable
: RCC-APB2ENR_ADC3EN   %1 15 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_ADC3EN    ADC3 interface clock  enable
: RCC-APB2ENR_TIM9EN   %1 19 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM9EN    TIM9 Timer clock enable
: RCC-APB2ENR_TIM10EN   %1 20 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM10EN    TIM10 Timer clock enable
: RCC-APB2ENR_TIM11EN   %1 21 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM11EN    TIM11 Timer clock enable

\ RCC-APB1ENR (read-write)
: RCC-APB1ENR_TIM2EN   %1 0 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM2EN    Timer 2 clock enable
: RCC-APB1ENR_TIM3EN   %1 1 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM3EN    Timer 3 clock enable
: RCC-APB1ENR_TIM4EN   %1 2 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM4EN    Timer 4 clock enable
: RCC-APB1ENR_TIM5EN   %1 3 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM5EN    Timer 5 clock enable
: RCC-APB1ENR_TIM6EN   %1 4 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM6EN    Timer 6 clock enable
: RCC-APB1ENR_TIM7EN   %1 5 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM7EN    Timer 7 clock enable
: RCC-APB1ENR_TIM12EN   %1 6 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM12EN    Timer 12 clock enable
: RCC-APB1ENR_TIM13EN   %1 7 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM13EN    Timer 13 clock enable
: RCC-APB1ENR_TIM14EN   %1 8 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM14EN    Timer 14 clock enable
: RCC-APB1ENR_WWDGEN   %1 11 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_WWDGEN    Window watchdog clock  enable
: RCC-APB1ENR_SPI2EN   %1 14 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_SPI2EN    SPI 2 clock enable
: RCC-APB1ENR_SPI3EN   %1 15 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_SPI3EN    SPI 3 clock enable
: RCC-APB1ENR_USART2EN   %1 17 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_USART2EN    USART 2 clock enable
: RCC-APB1ENR_USART3EN   %1 18 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_USART3EN    USART 3 clock enable
: RCC-APB1ENR_UART4EN   %1 19 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_UART4EN    UART 4 clock enable
: RCC-APB1ENR_UART5EN   %1 20 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_UART5EN    UART 5 clock enable
: RCC-APB1ENR_I2C1EN   %1 21 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_I2C1EN    I2C 1 clock enable
: RCC-APB1ENR_I2C2EN   %1 22 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_I2C2EN    I2C 2 clock enable
: RCC-APB1ENR_USBEN   %1 23 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_USBEN    USB clock enable
: RCC-APB1ENR_CANEN   %1 25 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_CANEN    CAN clock enable
: RCC-APB1ENR_BKPEN   %1 27 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_BKPEN    Backup interface clock  enable
: RCC-APB1ENR_PWREN   %1 28 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_PWREN    Power interface clock  enable
: RCC-APB1ENR_DACEN   %1 29 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_DACEN    DAC interface clock enable

\ RCC-BDCR ()
: RCC-BDCR_LSEON   %1 0 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSEON    External Low Speed oscillator  enable
: RCC-BDCR_LSERDY   %1 1 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSERDY    External Low Speed oscillator  ready
: RCC-BDCR_LSEBYP   %1 2 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSEBYP    External Low Speed oscillator  bypass
: RCC-BDCR_RTCSEL   ( %XX -- ) 8 lshift RCC-BDCR bis! ;  \ RCC-BDCR_RTCSEL    RTC clock source selection
: RCC-BDCR_RTCEN   %1 15 lshift RCC-BDCR bis! ;  \ RCC-BDCR_RTCEN    RTC clock enable
: RCC-BDCR_BDRST   %1 16 lshift RCC-BDCR bis! ;  \ RCC-BDCR_BDRST    Backup domain software  reset

\ RCC-CSR ()
: RCC-CSR_LSION   %1 0 lshift RCC-CSR bis! ;  \ RCC-CSR_LSION    Internal low speed oscillator  enable
: RCC-CSR_LSIRDY   %1 1 lshift RCC-CSR bis! ;  \ RCC-CSR_LSIRDY    Internal low speed oscillator  ready
: RCC-CSR_RMVF   %1 24 lshift RCC-CSR bis! ;  \ RCC-CSR_RMVF    Remove reset flag
: RCC-CSR_PINRSTF   %1 26 lshift RCC-CSR bis! ;  \ RCC-CSR_PINRSTF    PIN reset flag
: RCC-CSR_PORRSTF   %1 27 lshift RCC-CSR bis! ;  \ RCC-CSR_PORRSTF    POR/PDR reset flag
: RCC-CSR_SFTRSTF   %1 28 lshift RCC-CSR bis! ;  \ RCC-CSR_SFTRSTF    Software reset flag
: RCC-CSR_IWDGRSTF   %1 29 lshift RCC-CSR bis! ;  \ RCC-CSR_IWDGRSTF    Independent watchdog reset  flag
: RCC-CSR_WWDGRSTF   %1 30 lshift RCC-CSR bis! ;  \ RCC-CSR_WWDGRSTF    Window watchdog reset flag
: RCC-CSR_LPWRRSTF   %1 31 lshift RCC-CSR bis! ;  \ RCC-CSR_LPWRRSTF    Low-power reset flag

\ GPIOA-CRL (read-write)
: GPIOA-CRL_MODE0   ( %XX -- ) 0 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE0    Port n.0 mode bits
: GPIOA-CRL_CNF0   ( %XX -- ) 2 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF0    Port n.0 configuration  bits
: GPIOA-CRL_MODE1   ( %XX -- ) 4 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE1    Port n.1 mode bits
: GPIOA-CRL_CNF1   ( %XX -- ) 6 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF1    Port n.1 configuration  bits
: GPIOA-CRL_MODE2   ( %XX -- ) 8 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE2    Port n.2 mode bits
: GPIOA-CRL_CNF2   ( %XX -- ) 10 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF2    Port n.2 configuration  bits
: GPIOA-CRL_MODE3   ( %XX -- ) 12 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE3    Port n.3 mode bits
: GPIOA-CRL_CNF3   ( %XX -- ) 14 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF3    Port n.3 configuration  bits
: GPIOA-CRL_MODE4   ( %XX -- ) 16 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE4    Port n.4 mode bits
: GPIOA-CRL_CNF4   ( %XX -- ) 18 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF4    Port n.4 configuration  bits
: GPIOA-CRL_MODE5   ( %XX -- ) 20 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE5    Port n.5 mode bits
: GPIOA-CRL_CNF5   ( %XX -- ) 22 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF5    Port n.5 configuration  bits
: GPIOA-CRL_MODE6   ( %XX -- ) 24 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE6    Port n.6 mode bits
: GPIOA-CRL_CNF6   ( %XX -- ) 26 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF6    Port n.6 configuration  bits
: GPIOA-CRL_MODE7   ( %XX -- ) 28 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_MODE7    Port n.7 mode bits
: GPIOA-CRL_CNF7   ( %XX -- ) 30 lshift GPIOA-CRL bis! ;  \ GPIOA-CRL_CNF7    Port n.7 configuration  bits

\ GPIOA-CRH (read-write)
: GPIOA-CRH_MODE8   ( %XX -- ) 0 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE8    Port n.8 mode bits
: GPIOA-CRH_CNF8   ( %XX -- ) 2 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF8    Port n.8 configuration  bits
: GPIOA-CRH_MODE9   ( %XX -- ) 4 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE9    Port n.9 mode bits
: GPIOA-CRH_CNF9   ( %XX -- ) 6 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF9    Port n.9 configuration  bits
: GPIOA-CRH_MODE10   ( %XX -- ) 8 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE10    Port n.10 mode bits
: GPIOA-CRH_CNF10   ( %XX -- ) 10 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF10    Port n.10 configuration  bits
: GPIOA-CRH_MODE11   ( %XX -- ) 12 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE11    Port n.11 mode bits
: GPIOA-CRH_CNF11   ( %XX -- ) 14 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF11    Port n.11 configuration  bits
: GPIOA-CRH_MODE12   ( %XX -- ) 16 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE12    Port n.12 mode bits
: GPIOA-CRH_CNF12   ( %XX -- ) 18 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF12    Port n.12 configuration  bits
: GPIOA-CRH_MODE13   ( %XX -- ) 20 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE13    Port n.13 mode bits
: GPIOA-CRH_CNF13   ( %XX -- ) 22 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF13    Port n.13 configuration  bits
: GPIOA-CRH_MODE14   ( %XX -- ) 24 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE14    Port n.14 mode bits
: GPIOA-CRH_CNF14   ( %XX -- ) 26 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF14    Port n.14 configuration  bits
: GPIOA-CRH_MODE15   ( %XX -- ) 28 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_MODE15    Port n.15 mode bits
: GPIOA-CRH_CNF15   ( %XX -- ) 30 lshift GPIOA-CRH bis! ;  \ GPIOA-CRH_CNF15    Port n.15 configuration  bits

\ GPIOA-IDR (read-only)
: GPIOA-IDR_IDR0   %1 0 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR0    Port input data
: GPIOA-IDR_IDR1   %1 1 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR1    Port input data
: GPIOA-IDR_IDR2   %1 2 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR2    Port input data
: GPIOA-IDR_IDR3   %1 3 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR3    Port input data
: GPIOA-IDR_IDR4   %1 4 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR4    Port input data
: GPIOA-IDR_IDR5   %1 5 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR5    Port input data
: GPIOA-IDR_IDR6   %1 6 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR6    Port input data
: GPIOA-IDR_IDR7   %1 7 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR7    Port input data
: GPIOA-IDR_IDR8   %1 8 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR8    Port input data
: GPIOA-IDR_IDR9   %1 9 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR9    Port input data
: GPIOA-IDR_IDR10   %1 10 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR10    Port input data
: GPIOA-IDR_IDR11   %1 11 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR11    Port input data
: GPIOA-IDR_IDR12   %1 12 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR12    Port input data
: GPIOA-IDR_IDR13   %1 13 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR13    Port input data
: GPIOA-IDR_IDR14   %1 14 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR14    Port input data
: GPIOA-IDR_IDR15   %1 15 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR15    Port input data

\ GPIOA-ODR (read-write)
: GPIOA-ODR_ODR0   %1 0 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR0    Port output data
: GPIOA-ODR_ODR1   %1 1 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR1    Port output data
: GPIOA-ODR_ODR2   %1 2 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR2    Port output data
: GPIOA-ODR_ODR3   %1 3 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR3    Port output data
: GPIOA-ODR_ODR4   %1 4 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR4    Port output data
: GPIOA-ODR_ODR5   %1 5 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR5    Port output data
: GPIOA-ODR_ODR6   %1 6 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR6    Port output data
: GPIOA-ODR_ODR7   %1 7 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR7    Port output data
: GPIOA-ODR_ODR8   %1 8 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR8    Port output data
: GPIOA-ODR_ODR9   %1 9 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR9    Port output data
: GPIOA-ODR_ODR10   %1 10 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR10    Port output data
: GPIOA-ODR_ODR11   %1 11 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR11    Port output data
: GPIOA-ODR_ODR12   %1 12 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR12    Port output data
: GPIOA-ODR_ODR13   %1 13 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR13    Port output data
: GPIOA-ODR_ODR14   %1 14 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR14    Port output data
: GPIOA-ODR_ODR15   %1 15 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR15    Port output data

\ GPIOA-BSRR (write-only)
: GPIOA-BSRR_BS0   %1 0 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS0    Set bit 0
: GPIOA-BSRR_BS1   %1 1 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS1    Set bit 1
: GPIOA-BSRR_BS2   %1 2 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS2    Set bit 1
: GPIOA-BSRR_BS3   %1 3 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS3    Set bit 3
: GPIOA-BSRR_BS4   %1 4 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS4    Set bit 4
: GPIOA-BSRR_BS5   %1 5 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS5    Set bit 5
: GPIOA-BSRR_BS6   %1 6 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS6    Set bit 6
: GPIOA-BSRR_BS7   %1 7 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS7    Set bit 7
: GPIOA-BSRR_BS8   %1 8 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS8    Set bit 8
: GPIOA-BSRR_BS9   %1 9 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS9    Set bit 9
: GPIOA-BSRR_BS10   %1 10 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS10    Set bit 10
: GPIOA-BSRR_BS11   %1 11 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS11    Set bit 11
: GPIOA-BSRR_BS12   %1 12 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS12    Set bit 12
: GPIOA-BSRR_BS13   %1 13 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS13    Set bit 13
: GPIOA-BSRR_BS14   %1 14 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS14    Set bit 14
: GPIOA-BSRR_BS15   %1 15 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS15    Set bit 15
: GPIOA-BSRR_BR0   %1 16 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR0    Reset bit 0
: GPIOA-BSRR_BR1   %1 17 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR1    Reset bit 1
: GPIOA-BSRR_BR2   %1 18 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR2    Reset bit 2
: GPIOA-BSRR_BR3   %1 19 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR3    Reset bit 3
: GPIOA-BSRR_BR4   %1 20 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR4    Reset bit 4
: GPIOA-BSRR_BR5   %1 21 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR5    Reset bit 5
: GPIOA-BSRR_BR6   %1 22 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR6    Reset bit 6
: GPIOA-BSRR_BR7   %1 23 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR7    Reset bit 7
: GPIOA-BSRR_BR8   %1 24 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR8    Reset bit 8
: GPIOA-BSRR_BR9   %1 25 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR9    Reset bit 9
: GPIOA-BSRR_BR10   %1 26 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR10    Reset bit 10
: GPIOA-BSRR_BR11   %1 27 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR11    Reset bit 11
: GPIOA-BSRR_BR12   %1 28 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR12    Reset bit 12
: GPIOA-BSRR_BR13   %1 29 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR13    Reset bit 13
: GPIOA-BSRR_BR14   %1 30 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR14    Reset bit 14
: GPIOA-BSRR_BR15   %1 31 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR15    Reset bit 15

\ GPIOA-BRR (write-only)
: GPIOA-BRR_BR0   %1 0 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR0    Reset bit 0
: GPIOA-BRR_BR1   %1 1 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR1    Reset bit 1
: GPIOA-BRR_BR2   %1 2 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR2    Reset bit 1
: GPIOA-BRR_BR3   %1 3 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR3    Reset bit 3
: GPIOA-BRR_BR4   %1 4 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR4    Reset bit 4
: GPIOA-BRR_BR5   %1 5 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR5    Reset bit 5
: GPIOA-BRR_BR6   %1 6 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR6    Reset bit 6
: GPIOA-BRR_BR7   %1 7 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR7    Reset bit 7
: GPIOA-BRR_BR8   %1 8 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR8    Reset bit 8
: GPIOA-BRR_BR9   %1 9 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR9    Reset bit 9
: GPIOA-BRR_BR10   %1 10 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR10    Reset bit 10
: GPIOA-BRR_BR11   %1 11 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR11    Reset bit 11
: GPIOA-BRR_BR12   %1 12 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR12    Reset bit 12
: GPIOA-BRR_BR13   %1 13 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR13    Reset bit 13
: GPIOA-BRR_BR14   %1 14 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR14    Reset bit 14
: GPIOA-BRR_BR15   %1 15 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR15    Reset bit 15

\ GPIOA-LCKR (read-write)
: GPIOA-LCKR_LCK0   %1 0 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK0    Port A Lock bit 0
: GPIOA-LCKR_LCK1   %1 1 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK1    Port A Lock bit 1
: GPIOA-LCKR_LCK2   %1 2 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK2    Port A Lock bit 2
: GPIOA-LCKR_LCK3   %1 3 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK3    Port A Lock bit 3
: GPIOA-LCKR_LCK4   %1 4 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK4    Port A Lock bit 4
: GPIOA-LCKR_LCK5   %1 5 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK5    Port A Lock bit 5
: GPIOA-LCKR_LCK6   %1 6 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK6    Port A Lock bit 6
: GPIOA-LCKR_LCK7   %1 7 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK7    Port A Lock bit 7
: GPIOA-LCKR_LCK8   %1 8 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK8    Port A Lock bit 8
: GPIOA-LCKR_LCK9   %1 9 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK9    Port A Lock bit 9
: GPIOA-LCKR_LCK10   %1 10 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK10    Port A Lock bit 10
: GPIOA-LCKR_LCK11   %1 11 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK11    Port A Lock bit 11
: GPIOA-LCKR_LCK12   %1 12 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK12    Port A Lock bit 12
: GPIOA-LCKR_LCK13   %1 13 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK13    Port A Lock bit 13
: GPIOA-LCKR_LCK14   %1 14 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK14    Port A Lock bit 14
: GPIOA-LCKR_LCK15   %1 15 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK15    Port A Lock bit 15
: GPIOA-LCKR_LCKK   %1 16 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCKK    Lock key

\ GPIOB-CRL (read-write)
: GPIOB-CRL_MODE0   ( %XX -- ) 0 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE0    Port n.0 mode bits
: GPIOB-CRL_CNF0   ( %XX -- ) 2 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF0    Port n.0 configuration  bits
: GPIOB-CRL_MODE1   ( %XX -- ) 4 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE1    Port n.1 mode bits
: GPIOB-CRL_CNF1   ( %XX -- ) 6 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF1    Port n.1 configuration  bits
: GPIOB-CRL_MODE2   ( %XX -- ) 8 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE2    Port n.2 mode bits
: GPIOB-CRL_CNF2   ( %XX -- ) 10 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF2    Port n.2 configuration  bits
: GPIOB-CRL_MODE3   ( %XX -- ) 12 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE3    Port n.3 mode bits
: GPIOB-CRL_CNF3   ( %XX -- ) 14 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF3    Port n.3 configuration  bits
: GPIOB-CRL_MODE4   ( %XX -- ) 16 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE4    Port n.4 mode bits
: GPIOB-CRL_CNF4   ( %XX -- ) 18 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF4    Port n.4 configuration  bits
: GPIOB-CRL_MODE5   ( %XX -- ) 20 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE5    Port n.5 mode bits
: GPIOB-CRL_CNF5   ( %XX -- ) 22 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF5    Port n.5 configuration  bits
: GPIOB-CRL_MODE6   ( %XX -- ) 24 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE6    Port n.6 mode bits
: GPIOB-CRL_CNF6   ( %XX -- ) 26 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF6    Port n.6 configuration  bits
: GPIOB-CRL_MODE7   ( %XX -- ) 28 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_MODE7    Port n.7 mode bits
: GPIOB-CRL_CNF7   ( %XX -- ) 30 lshift GPIOB-CRL bis! ;  \ GPIOB-CRL_CNF7    Port n.7 configuration  bits

\ GPIOB-CRH (read-write)
: GPIOB-CRH_MODE8   ( %XX -- ) 0 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE8    Port n.8 mode bits
: GPIOB-CRH_CNF8   ( %XX -- ) 2 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF8    Port n.8 configuration  bits
: GPIOB-CRH_MODE9   ( %XX -- ) 4 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE9    Port n.9 mode bits
: GPIOB-CRH_CNF9   ( %XX -- ) 6 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF9    Port n.9 configuration  bits
: GPIOB-CRH_MODE10   ( %XX -- ) 8 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE10    Port n.10 mode bits
: GPIOB-CRH_CNF10   ( %XX -- ) 10 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF10    Port n.10 configuration  bits
: GPIOB-CRH_MODE11   ( %XX -- ) 12 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE11    Port n.11 mode bits
: GPIOB-CRH_CNF11   ( %XX -- ) 14 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF11    Port n.11 configuration  bits
: GPIOB-CRH_MODE12   ( %XX -- ) 16 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE12    Port n.12 mode bits
: GPIOB-CRH_CNF12   ( %XX -- ) 18 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF12    Port n.12 configuration  bits
: GPIOB-CRH_MODE13   ( %XX -- ) 20 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE13    Port n.13 mode bits
: GPIOB-CRH_CNF13   ( %XX -- ) 22 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF13    Port n.13 configuration  bits
: GPIOB-CRH_MODE14   ( %XX -- ) 24 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE14    Port n.14 mode bits
: GPIOB-CRH_CNF14   ( %XX -- ) 26 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF14    Port n.14 configuration  bits
: GPIOB-CRH_MODE15   ( %XX -- ) 28 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_MODE15    Port n.15 mode bits
: GPIOB-CRH_CNF15   ( %XX -- ) 30 lshift GPIOB-CRH bis! ;  \ GPIOB-CRH_CNF15    Port n.15 configuration  bits

\ GPIOB-IDR (read-only)
: GPIOB-IDR_IDR0   %1 0 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR0    Port input data
: GPIOB-IDR_IDR1   %1 1 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR1    Port input data
: GPIOB-IDR_IDR2   %1 2 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR2    Port input data
: GPIOB-IDR_IDR3   %1 3 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR3    Port input data
: GPIOB-IDR_IDR4   %1 4 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR4    Port input data
: GPIOB-IDR_IDR5   %1 5 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR5    Port input data
: GPIOB-IDR_IDR6   %1 6 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR6    Port input data
: GPIOB-IDR_IDR7   %1 7 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR7    Port input data
: GPIOB-IDR_IDR8   %1 8 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR8    Port input data
: GPIOB-IDR_IDR9   %1 9 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR9    Port input data
: GPIOB-IDR_IDR10   %1 10 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR10    Port input data
: GPIOB-IDR_IDR11   %1 11 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR11    Port input data
: GPIOB-IDR_IDR12   %1 12 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR12    Port input data
: GPIOB-IDR_IDR13   %1 13 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR13    Port input data
: GPIOB-IDR_IDR14   %1 14 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR14    Port input data
: GPIOB-IDR_IDR15   %1 15 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR15    Port input data

\ GPIOB-ODR (read-write)
: GPIOB-ODR_ODR0   %1 0 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR0    Port output data
: GPIOB-ODR_ODR1   %1 1 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR1    Port output data
: GPIOB-ODR_ODR2   %1 2 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR2    Port output data
: GPIOB-ODR_ODR3   %1 3 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR3    Port output data
: GPIOB-ODR_ODR4   %1 4 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR4    Port output data
: GPIOB-ODR_ODR5   %1 5 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR5    Port output data
: GPIOB-ODR_ODR6   %1 6 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR6    Port output data
: GPIOB-ODR_ODR7   %1 7 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR7    Port output data
: GPIOB-ODR_ODR8   %1 8 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR8    Port output data
: GPIOB-ODR_ODR9   %1 9 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR9    Port output data
: GPIOB-ODR_ODR10   %1 10 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR10    Port output data
: GPIOB-ODR_ODR11   %1 11 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR11    Port output data
: GPIOB-ODR_ODR12   %1 12 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR12    Port output data
: GPIOB-ODR_ODR13   %1 13 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR13    Port output data
: GPIOB-ODR_ODR14   %1 14 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR14    Port output data
: GPIOB-ODR_ODR15   %1 15 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR15    Port output data

\ GPIOB-BSRR (write-only)
: GPIOB-BSRR_BS0   %1 0 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS0    Set bit 0
: GPIOB-BSRR_BS1   %1 1 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS1    Set bit 1
: GPIOB-BSRR_BS2   %1 2 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS2    Set bit 1
: GPIOB-BSRR_BS3   %1 3 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS3    Set bit 3
: GPIOB-BSRR_BS4   %1 4 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS4    Set bit 4
: GPIOB-BSRR_BS5   %1 5 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS5    Set bit 5
: GPIOB-BSRR_BS6   %1 6 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS6    Set bit 6
: GPIOB-BSRR_BS7   %1 7 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS7    Set bit 7
: GPIOB-BSRR_BS8   %1 8 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS8    Set bit 8
: GPIOB-BSRR_BS9   %1 9 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS9    Set bit 9
: GPIOB-BSRR_BS10   %1 10 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS10    Set bit 10
: GPIOB-BSRR_BS11   %1 11 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS11    Set bit 11
: GPIOB-BSRR_BS12   %1 12 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS12    Set bit 12
: GPIOB-BSRR_BS13   %1 13 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS13    Set bit 13
: GPIOB-BSRR_BS14   %1 14 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS14    Set bit 14
: GPIOB-BSRR_BS15   %1 15 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS15    Set bit 15
: GPIOB-BSRR_BR0   %1 16 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR0    Reset bit 0
: GPIOB-BSRR_BR1   %1 17 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR1    Reset bit 1
: GPIOB-BSRR_BR2   %1 18 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR2    Reset bit 2
: GPIOB-BSRR_BR3   %1 19 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR3    Reset bit 3
: GPIOB-BSRR_BR4   %1 20 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR4    Reset bit 4
: GPIOB-BSRR_BR5   %1 21 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR5    Reset bit 5
: GPIOB-BSRR_BR6   %1 22 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR6    Reset bit 6
: GPIOB-BSRR_BR7   %1 23 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR7    Reset bit 7
: GPIOB-BSRR_BR8   %1 24 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR8    Reset bit 8
: GPIOB-BSRR_BR9   %1 25 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR9    Reset bit 9
: GPIOB-BSRR_BR10   %1 26 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR10    Reset bit 10
: GPIOB-BSRR_BR11   %1 27 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR11    Reset bit 11
: GPIOB-BSRR_BR12   %1 28 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR12    Reset bit 12
: GPIOB-BSRR_BR13   %1 29 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR13    Reset bit 13
: GPIOB-BSRR_BR14   %1 30 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR14    Reset bit 14
: GPIOB-BSRR_BR15   %1 31 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR15    Reset bit 15

\ GPIOB-BRR (write-only)
: GPIOB-BRR_BR0   %1 0 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR0    Reset bit 0
: GPIOB-BRR_BR1   %1 1 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR1    Reset bit 1
: GPIOB-BRR_BR2   %1 2 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR2    Reset bit 1
: GPIOB-BRR_BR3   %1 3 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR3    Reset bit 3
: GPIOB-BRR_BR4   %1 4 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR4    Reset bit 4
: GPIOB-BRR_BR5   %1 5 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR5    Reset bit 5
: GPIOB-BRR_BR6   %1 6 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR6    Reset bit 6
: GPIOB-BRR_BR7   %1 7 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR7    Reset bit 7
: GPIOB-BRR_BR8   %1 8 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR8    Reset bit 8
: GPIOB-BRR_BR9   %1 9 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR9    Reset bit 9
: GPIOB-BRR_BR10   %1 10 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR10    Reset bit 10
: GPIOB-BRR_BR11   %1 11 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR11    Reset bit 11
: GPIOB-BRR_BR12   %1 12 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR12    Reset bit 12
: GPIOB-BRR_BR13   %1 13 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR13    Reset bit 13
: GPIOB-BRR_BR14   %1 14 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR14    Reset bit 14
: GPIOB-BRR_BR15   %1 15 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR15    Reset bit 15

\ GPIOB-LCKR (read-write)
: GPIOB-LCKR_LCK0   %1 0 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK0    Port A Lock bit 0
: GPIOB-LCKR_LCK1   %1 1 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK1    Port A Lock bit 1
: GPIOB-LCKR_LCK2   %1 2 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK2    Port A Lock bit 2
: GPIOB-LCKR_LCK3   %1 3 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK3    Port A Lock bit 3
: GPIOB-LCKR_LCK4   %1 4 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK4    Port A Lock bit 4
: GPIOB-LCKR_LCK5   %1 5 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK5    Port A Lock bit 5
: GPIOB-LCKR_LCK6   %1 6 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK6    Port A Lock bit 6
: GPIOB-LCKR_LCK7   %1 7 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK7    Port A Lock bit 7
: GPIOB-LCKR_LCK8   %1 8 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK8    Port A Lock bit 8
: GPIOB-LCKR_LCK9   %1 9 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK9    Port A Lock bit 9
: GPIOB-LCKR_LCK10   %1 10 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK10    Port A Lock bit 10
: GPIOB-LCKR_LCK11   %1 11 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK11    Port A Lock bit 11
: GPIOB-LCKR_LCK12   %1 12 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK12    Port A Lock bit 12
: GPIOB-LCKR_LCK13   %1 13 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK13    Port A Lock bit 13
: GPIOB-LCKR_LCK14   %1 14 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK14    Port A Lock bit 14
: GPIOB-LCKR_LCK15   %1 15 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK15    Port A Lock bit 15
: GPIOB-LCKR_LCKK   %1 16 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCKK    Lock key

\ GPIOC-CRL (read-write)
: GPIOC-CRL_MODE0   ( %XX -- ) 0 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE0    Port n.0 mode bits
: GPIOC-CRL_CNF0   ( %XX -- ) 2 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF0    Port n.0 configuration  bits
: GPIOC-CRL_MODE1   ( %XX -- ) 4 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE1    Port n.1 mode bits
: GPIOC-CRL_CNF1   ( %XX -- ) 6 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF1    Port n.1 configuration  bits
: GPIOC-CRL_MODE2   ( %XX -- ) 8 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE2    Port n.2 mode bits
: GPIOC-CRL_CNF2   ( %XX -- ) 10 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF2    Port n.2 configuration  bits
: GPIOC-CRL_MODE3   ( %XX -- ) 12 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE3    Port n.3 mode bits
: GPIOC-CRL_CNF3   ( %XX -- ) 14 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF3    Port n.3 configuration  bits
: GPIOC-CRL_MODE4   ( %XX -- ) 16 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE4    Port n.4 mode bits
: GPIOC-CRL_CNF4   ( %XX -- ) 18 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF4    Port n.4 configuration  bits
: GPIOC-CRL_MODE5   ( %XX -- ) 20 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE5    Port n.5 mode bits
: GPIOC-CRL_CNF5   ( %XX -- ) 22 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF5    Port n.5 configuration  bits
: GPIOC-CRL_MODE6   ( %XX -- ) 24 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE6    Port n.6 mode bits
: GPIOC-CRL_CNF6   ( %XX -- ) 26 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF6    Port n.6 configuration  bits
: GPIOC-CRL_MODE7   ( %XX -- ) 28 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_MODE7    Port n.7 mode bits
: GPIOC-CRL_CNF7   ( %XX -- ) 30 lshift GPIOC-CRL bis! ;  \ GPIOC-CRL_CNF7    Port n.7 configuration  bits

\ GPIOC-CRH (read-write)
: GPIOC-CRH_MODE8   ( %XX -- ) 0 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE8    Port n.8 mode bits
: GPIOC-CRH_CNF8   ( %XX -- ) 2 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF8    Port n.8 configuration  bits
: GPIOC-CRH_MODE9   ( %XX -- ) 4 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE9    Port n.9 mode bits
: GPIOC-CRH_CNF9   ( %XX -- ) 6 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF9    Port n.9 configuration  bits
: GPIOC-CRH_MODE10   ( %XX -- ) 8 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE10    Port n.10 mode bits
: GPIOC-CRH_CNF10   ( %XX -- ) 10 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF10    Port n.10 configuration  bits
: GPIOC-CRH_MODE11   ( %XX -- ) 12 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE11    Port n.11 mode bits
: GPIOC-CRH_CNF11   ( %XX -- ) 14 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF11    Port n.11 configuration  bits
: GPIOC-CRH_MODE12   ( %XX -- ) 16 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE12    Port n.12 mode bits
: GPIOC-CRH_CNF12   ( %XX -- ) 18 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF12    Port n.12 configuration  bits
: GPIOC-CRH_MODE13   ( %XX -- ) 20 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE13    Port n.13 mode bits
: GPIOC-CRH_CNF13   ( %XX -- ) 22 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF13    Port n.13 configuration  bits
: GPIOC-CRH_MODE14   ( %XX -- ) 24 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE14    Port n.14 mode bits
: GPIOC-CRH_CNF14   ( %XX -- ) 26 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF14    Port n.14 configuration  bits
: GPIOC-CRH_MODE15   ( %XX -- ) 28 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_MODE15    Port n.15 mode bits
: GPIOC-CRH_CNF15   ( %XX -- ) 30 lshift GPIOC-CRH bis! ;  \ GPIOC-CRH_CNF15    Port n.15 configuration  bits

\ GPIOC-IDR (read-only)
: GPIOC-IDR_IDR0   %1 0 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR0    Port input data
: GPIOC-IDR_IDR1   %1 1 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR1    Port input data
: GPIOC-IDR_IDR2   %1 2 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR2    Port input data
: GPIOC-IDR_IDR3   %1 3 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR3    Port input data
: GPIOC-IDR_IDR4   %1 4 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR4    Port input data
: GPIOC-IDR_IDR5   %1 5 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR5    Port input data
: GPIOC-IDR_IDR6   %1 6 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR6    Port input data
: GPIOC-IDR_IDR7   %1 7 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR7    Port input data
: GPIOC-IDR_IDR8   %1 8 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR8    Port input data
: GPIOC-IDR_IDR9   %1 9 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR9    Port input data
: GPIOC-IDR_IDR10   %1 10 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR10    Port input data
: GPIOC-IDR_IDR11   %1 11 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR11    Port input data
: GPIOC-IDR_IDR12   %1 12 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR12    Port input data
: GPIOC-IDR_IDR13   %1 13 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR13    Port input data
: GPIOC-IDR_IDR14   %1 14 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR14    Port input data
: GPIOC-IDR_IDR15   %1 15 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR15    Port input data

\ GPIOC-ODR (read-write)
: GPIOC-ODR_ODR0   %1 0 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR0    Port output data
: GPIOC-ODR_ODR1   %1 1 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR1    Port output data
: GPIOC-ODR_ODR2   %1 2 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR2    Port output data
: GPIOC-ODR_ODR3   %1 3 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR3    Port output data
: GPIOC-ODR_ODR4   %1 4 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR4    Port output data
: GPIOC-ODR_ODR5   %1 5 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR5    Port output data
: GPIOC-ODR_ODR6   %1 6 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR6    Port output data
: GPIOC-ODR_ODR7   %1 7 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR7    Port output data
: GPIOC-ODR_ODR8   %1 8 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR8    Port output data
: GPIOC-ODR_ODR9   %1 9 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR9    Port output data
: GPIOC-ODR_ODR10   %1 10 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR10    Port output data
: GPIOC-ODR_ODR11   %1 11 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR11    Port output data
: GPIOC-ODR_ODR12   %1 12 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR12    Port output data
: GPIOC-ODR_ODR13   %1 13 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR13    Port output data
: GPIOC-ODR_ODR14   %1 14 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR14    Port output data
: GPIOC-ODR_ODR15   %1 15 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR15    Port output data

\ GPIOC-BSRR (write-only)
: GPIOC-BSRR_BS0   %1 0 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS0    Set bit 0
: GPIOC-BSRR_BS1   %1 1 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS1    Set bit 1
: GPIOC-BSRR_BS2   %1 2 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS2    Set bit 1
: GPIOC-BSRR_BS3   %1 3 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS3    Set bit 3
: GPIOC-BSRR_BS4   %1 4 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS4    Set bit 4
: GPIOC-BSRR_BS5   %1 5 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS5    Set bit 5
: GPIOC-BSRR_BS6   %1 6 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS6    Set bit 6
: GPIOC-BSRR_BS7   %1 7 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS7    Set bit 7
: GPIOC-BSRR_BS8   %1 8 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS8    Set bit 8
: GPIOC-BSRR_BS9   %1 9 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS9    Set bit 9
: GPIOC-BSRR_BS10   %1 10 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS10    Set bit 10
: GPIOC-BSRR_BS11   %1 11 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS11    Set bit 11
: GPIOC-BSRR_BS12   %1 12 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS12    Set bit 12
: GPIOC-BSRR_BS13   %1 13 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS13    Set bit 13
: GPIOC-BSRR_BS14   %1 14 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS14    Set bit 14
: GPIOC-BSRR_BS15   %1 15 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS15    Set bit 15
: GPIOC-BSRR_BR0   %1 16 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR0    Reset bit 0
: GPIOC-BSRR_BR1   %1 17 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR1    Reset bit 1
: GPIOC-BSRR_BR2   %1 18 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR2    Reset bit 2
: GPIOC-BSRR_BR3   %1 19 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR3    Reset bit 3
: GPIOC-BSRR_BR4   %1 20 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR4    Reset bit 4
: GPIOC-BSRR_BR5   %1 21 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR5    Reset bit 5
: GPIOC-BSRR_BR6   %1 22 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR6    Reset bit 6
: GPIOC-BSRR_BR7   %1 23 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR7    Reset bit 7
: GPIOC-BSRR_BR8   %1 24 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR8    Reset bit 8
: GPIOC-BSRR_BR9   %1 25 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR9    Reset bit 9
: GPIOC-BSRR_BR10   %1 26 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR10    Reset bit 10
: GPIOC-BSRR_BR11   %1 27 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR11    Reset bit 11
: GPIOC-BSRR_BR12   %1 28 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR12    Reset bit 12
: GPIOC-BSRR_BR13   %1 29 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR13    Reset bit 13
: GPIOC-BSRR_BR14   %1 30 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR14    Reset bit 14
: GPIOC-BSRR_BR15   %1 31 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR15    Reset bit 15

\ GPIOC-BRR (write-only)
: GPIOC-BRR_BR0   %1 0 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR0    Reset bit 0
: GPIOC-BRR_BR1   %1 1 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR1    Reset bit 1
: GPIOC-BRR_BR2   %1 2 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR2    Reset bit 1
: GPIOC-BRR_BR3   %1 3 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR3    Reset bit 3
: GPIOC-BRR_BR4   %1 4 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR4    Reset bit 4
: GPIOC-BRR_BR5   %1 5 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR5    Reset bit 5
: GPIOC-BRR_BR6   %1 6 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR6    Reset bit 6
: GPIOC-BRR_BR7   %1 7 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR7    Reset bit 7
: GPIOC-BRR_BR8   %1 8 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR8    Reset bit 8
: GPIOC-BRR_BR9   %1 9 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR9    Reset bit 9
: GPIOC-BRR_BR10   %1 10 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR10    Reset bit 10
: GPIOC-BRR_BR11   %1 11 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR11    Reset bit 11
: GPIOC-BRR_BR12   %1 12 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR12    Reset bit 12
: GPIOC-BRR_BR13   %1 13 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR13    Reset bit 13
: GPIOC-BRR_BR14   %1 14 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR14    Reset bit 14
: GPIOC-BRR_BR15   %1 15 lshift GPIOC-BRR bis! ;  \ GPIOC-BRR_BR15    Reset bit 15

\ GPIOC-LCKR (read-write)
: GPIOC-LCKR_LCK0   %1 0 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK0    Port A Lock bit 0
: GPIOC-LCKR_LCK1   %1 1 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK1    Port A Lock bit 1
: GPIOC-LCKR_LCK2   %1 2 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK2    Port A Lock bit 2
: GPIOC-LCKR_LCK3   %1 3 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK3    Port A Lock bit 3
: GPIOC-LCKR_LCK4   %1 4 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK4    Port A Lock bit 4
: GPIOC-LCKR_LCK5   %1 5 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK5    Port A Lock bit 5
: GPIOC-LCKR_LCK6   %1 6 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK6    Port A Lock bit 6
: GPIOC-LCKR_LCK7   %1 7 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK7    Port A Lock bit 7
: GPIOC-LCKR_LCK8   %1 8 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK8    Port A Lock bit 8
: GPIOC-LCKR_LCK9   %1 9 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK9    Port A Lock bit 9
: GPIOC-LCKR_LCK10   %1 10 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK10    Port A Lock bit 10
: GPIOC-LCKR_LCK11   %1 11 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK11    Port A Lock bit 11
: GPIOC-LCKR_LCK12   %1 12 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK12    Port A Lock bit 12
: GPIOC-LCKR_LCK13   %1 13 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK13    Port A Lock bit 13
: GPIOC-LCKR_LCK14   %1 14 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK14    Port A Lock bit 14
: GPIOC-LCKR_LCK15   %1 15 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK15    Port A Lock bit 15
: GPIOC-LCKR_LCKK   %1 16 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCKK    Lock key

\ GPIOD-CRL (read-write)
: GPIOD-CRL_MODE0   ( %XX -- ) 0 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE0    Port n.0 mode bits
: GPIOD-CRL_CNF0   ( %XX -- ) 2 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF0    Port n.0 configuration  bits
: GPIOD-CRL_MODE1   ( %XX -- ) 4 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE1    Port n.1 mode bits
: GPIOD-CRL_CNF1   ( %XX -- ) 6 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF1    Port n.1 configuration  bits
: GPIOD-CRL_MODE2   ( %XX -- ) 8 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE2    Port n.2 mode bits
: GPIOD-CRL_CNF2   ( %XX -- ) 10 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF2    Port n.2 configuration  bits
: GPIOD-CRL_MODE3   ( %XX -- ) 12 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE3    Port n.3 mode bits
: GPIOD-CRL_CNF3   ( %XX -- ) 14 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF3    Port n.3 configuration  bits
: GPIOD-CRL_MODE4   ( %XX -- ) 16 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE4    Port n.4 mode bits
: GPIOD-CRL_CNF4   ( %XX -- ) 18 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF4    Port n.4 configuration  bits
: GPIOD-CRL_MODE5   ( %XX -- ) 20 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE5    Port n.5 mode bits
: GPIOD-CRL_CNF5   ( %XX -- ) 22 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF5    Port n.5 configuration  bits
: GPIOD-CRL_MODE6   ( %XX -- ) 24 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE6    Port n.6 mode bits
: GPIOD-CRL_CNF6   ( %XX -- ) 26 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF6    Port n.6 configuration  bits
: GPIOD-CRL_MODE7   ( %XX -- ) 28 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_MODE7    Port n.7 mode bits
: GPIOD-CRL_CNF7   ( %XX -- ) 30 lshift GPIOD-CRL bis! ;  \ GPIOD-CRL_CNF7    Port n.7 configuration  bits

\ GPIOD-CRH (read-write)
: GPIOD-CRH_MODE8   ( %XX -- ) 0 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE8    Port n.8 mode bits
: GPIOD-CRH_CNF8   ( %XX -- ) 2 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF8    Port n.8 configuration  bits
: GPIOD-CRH_MODE9   ( %XX -- ) 4 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE9    Port n.9 mode bits
: GPIOD-CRH_CNF9   ( %XX -- ) 6 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF9    Port n.9 configuration  bits
: GPIOD-CRH_MODE10   ( %XX -- ) 8 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE10    Port n.10 mode bits
: GPIOD-CRH_CNF10   ( %XX -- ) 10 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF10    Port n.10 configuration  bits
: GPIOD-CRH_MODE11   ( %XX -- ) 12 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE11    Port n.11 mode bits
: GPIOD-CRH_CNF11   ( %XX -- ) 14 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF11    Port n.11 configuration  bits
: GPIOD-CRH_MODE12   ( %XX -- ) 16 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE12    Port n.12 mode bits
: GPIOD-CRH_CNF12   ( %XX -- ) 18 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF12    Port n.12 configuration  bits
: GPIOD-CRH_MODE13   ( %XX -- ) 20 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE13    Port n.13 mode bits
: GPIOD-CRH_CNF13   ( %XX -- ) 22 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF13    Port n.13 configuration  bits
: GPIOD-CRH_MODE14   ( %XX -- ) 24 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE14    Port n.14 mode bits
: GPIOD-CRH_CNF14   ( %XX -- ) 26 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF14    Port n.14 configuration  bits
: GPIOD-CRH_MODE15   ( %XX -- ) 28 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_MODE15    Port n.15 mode bits
: GPIOD-CRH_CNF15   ( %XX -- ) 30 lshift GPIOD-CRH bis! ;  \ GPIOD-CRH_CNF15    Port n.15 configuration  bits

\ GPIOD-IDR (read-only)
: GPIOD-IDR_IDR0   %1 0 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR0    Port input data
: GPIOD-IDR_IDR1   %1 1 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR1    Port input data
: GPIOD-IDR_IDR2   %1 2 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR2    Port input data
: GPIOD-IDR_IDR3   %1 3 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR3    Port input data
: GPIOD-IDR_IDR4   %1 4 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR4    Port input data
: GPIOD-IDR_IDR5   %1 5 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR5    Port input data
: GPIOD-IDR_IDR6   %1 6 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR6    Port input data
: GPIOD-IDR_IDR7   %1 7 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR7    Port input data
: GPIOD-IDR_IDR8   %1 8 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR8    Port input data
: GPIOD-IDR_IDR9   %1 9 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR9    Port input data
: GPIOD-IDR_IDR10   %1 10 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR10    Port input data
: GPIOD-IDR_IDR11   %1 11 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR11    Port input data
: GPIOD-IDR_IDR12   %1 12 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR12    Port input data
: GPIOD-IDR_IDR13   %1 13 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR13    Port input data
: GPIOD-IDR_IDR14   %1 14 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR14    Port input data
: GPIOD-IDR_IDR15   %1 15 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR15    Port input data

\ GPIOD-ODR (read-write)
: GPIOD-ODR_ODR0   %1 0 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR0    Port output data
: GPIOD-ODR_ODR1   %1 1 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR1    Port output data
: GPIOD-ODR_ODR2   %1 2 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR2    Port output data
: GPIOD-ODR_ODR3   %1 3 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR3    Port output data
: GPIOD-ODR_ODR4   %1 4 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR4    Port output data
: GPIOD-ODR_ODR5   %1 5 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR5    Port output data
: GPIOD-ODR_ODR6   %1 6 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR6    Port output data
: GPIOD-ODR_ODR7   %1 7 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR7    Port output data
: GPIOD-ODR_ODR8   %1 8 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR8    Port output data
: GPIOD-ODR_ODR9   %1 9 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR9    Port output data
: GPIOD-ODR_ODR10   %1 10 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR10    Port output data
: GPIOD-ODR_ODR11   %1 11 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR11    Port output data
: GPIOD-ODR_ODR12   %1 12 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR12    Port output data
: GPIOD-ODR_ODR13   %1 13 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR13    Port output data
: GPIOD-ODR_ODR14   %1 14 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR14    Port output data
: GPIOD-ODR_ODR15   %1 15 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR15    Port output data

\ GPIOD-BSRR (write-only)
: GPIOD-BSRR_BS0   %1 0 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS0    Set bit 0
: GPIOD-BSRR_BS1   %1 1 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS1    Set bit 1
: GPIOD-BSRR_BS2   %1 2 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS2    Set bit 1
: GPIOD-BSRR_BS3   %1 3 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS3    Set bit 3
: GPIOD-BSRR_BS4   %1 4 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS4    Set bit 4
: GPIOD-BSRR_BS5   %1 5 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS5    Set bit 5
: GPIOD-BSRR_BS6   %1 6 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS6    Set bit 6
: GPIOD-BSRR_BS7   %1 7 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS7    Set bit 7
: GPIOD-BSRR_BS8   %1 8 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS8    Set bit 8
: GPIOD-BSRR_BS9   %1 9 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS9    Set bit 9
: GPIOD-BSRR_BS10   %1 10 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS10    Set bit 10
: GPIOD-BSRR_BS11   %1 11 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS11    Set bit 11
: GPIOD-BSRR_BS12   %1 12 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS12    Set bit 12
: GPIOD-BSRR_BS13   %1 13 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS13    Set bit 13
: GPIOD-BSRR_BS14   %1 14 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS14    Set bit 14
: GPIOD-BSRR_BS15   %1 15 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS15    Set bit 15
: GPIOD-BSRR_BR0   %1 16 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR0    Reset bit 0
: GPIOD-BSRR_BR1   %1 17 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR1    Reset bit 1
: GPIOD-BSRR_BR2   %1 18 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR2    Reset bit 2
: GPIOD-BSRR_BR3   %1 19 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR3    Reset bit 3
: GPIOD-BSRR_BR4   %1 20 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR4    Reset bit 4
: GPIOD-BSRR_BR5   %1 21 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR5    Reset bit 5
: GPIOD-BSRR_BR6   %1 22 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR6    Reset bit 6
: GPIOD-BSRR_BR7   %1 23 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR7    Reset bit 7
: GPIOD-BSRR_BR8   %1 24 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR8    Reset bit 8
: GPIOD-BSRR_BR9   %1 25 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR9    Reset bit 9
: GPIOD-BSRR_BR10   %1 26 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR10    Reset bit 10
: GPIOD-BSRR_BR11   %1 27 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR11    Reset bit 11
: GPIOD-BSRR_BR12   %1 28 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR12    Reset bit 12
: GPIOD-BSRR_BR13   %1 29 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR13    Reset bit 13
: GPIOD-BSRR_BR14   %1 30 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR14    Reset bit 14
: GPIOD-BSRR_BR15   %1 31 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR15    Reset bit 15

\ GPIOD-BRR (write-only)
: GPIOD-BRR_BR0   %1 0 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR0    Reset bit 0
: GPIOD-BRR_BR1   %1 1 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR1    Reset bit 1
: GPIOD-BRR_BR2   %1 2 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR2    Reset bit 1
: GPIOD-BRR_BR3   %1 3 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR3    Reset bit 3
: GPIOD-BRR_BR4   %1 4 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR4    Reset bit 4
: GPIOD-BRR_BR5   %1 5 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR5    Reset bit 5
: GPIOD-BRR_BR6   %1 6 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR6    Reset bit 6
: GPIOD-BRR_BR7   %1 7 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR7    Reset bit 7
: GPIOD-BRR_BR8   %1 8 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR8    Reset bit 8
: GPIOD-BRR_BR9   %1 9 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR9    Reset bit 9
: GPIOD-BRR_BR10   %1 10 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR10    Reset bit 10
: GPIOD-BRR_BR11   %1 11 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR11    Reset bit 11
: GPIOD-BRR_BR12   %1 12 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR12    Reset bit 12
: GPIOD-BRR_BR13   %1 13 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR13    Reset bit 13
: GPIOD-BRR_BR14   %1 14 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR14    Reset bit 14
: GPIOD-BRR_BR15   %1 15 lshift GPIOD-BRR bis! ;  \ GPIOD-BRR_BR15    Reset bit 15

\ GPIOD-LCKR (read-write)
: GPIOD-LCKR_LCK0   %1 0 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK0    Port A Lock bit 0
: GPIOD-LCKR_LCK1   %1 1 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK1    Port A Lock bit 1
: GPIOD-LCKR_LCK2   %1 2 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK2    Port A Lock bit 2
: GPIOD-LCKR_LCK3   %1 3 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK3    Port A Lock bit 3
: GPIOD-LCKR_LCK4   %1 4 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK4    Port A Lock bit 4
: GPIOD-LCKR_LCK5   %1 5 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK5    Port A Lock bit 5
: GPIOD-LCKR_LCK6   %1 6 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK6    Port A Lock bit 6
: GPIOD-LCKR_LCK7   %1 7 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK7    Port A Lock bit 7
: GPIOD-LCKR_LCK8   %1 8 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK8    Port A Lock bit 8
: GPIOD-LCKR_LCK9   %1 9 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK9    Port A Lock bit 9
: GPIOD-LCKR_LCK10   %1 10 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK10    Port A Lock bit 10
: GPIOD-LCKR_LCK11   %1 11 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK11    Port A Lock bit 11
: GPIOD-LCKR_LCK12   %1 12 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK12    Port A Lock bit 12
: GPIOD-LCKR_LCK13   %1 13 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK13    Port A Lock bit 13
: GPIOD-LCKR_LCK14   %1 14 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK14    Port A Lock bit 14
: GPIOD-LCKR_LCK15   %1 15 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK15    Port A Lock bit 15
: GPIOD-LCKR_LCKK   %1 16 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCKK    Lock key

\ GPIOE-CRL (read-write)
: GPIOE-CRL_MODE0   ( %XX -- ) 0 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE0    Port n.0 mode bits
: GPIOE-CRL_CNF0   ( %XX -- ) 2 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF0    Port n.0 configuration  bits
: GPIOE-CRL_MODE1   ( %XX -- ) 4 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE1    Port n.1 mode bits
: GPIOE-CRL_CNF1   ( %XX -- ) 6 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF1    Port n.1 configuration  bits
: GPIOE-CRL_MODE2   ( %XX -- ) 8 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE2    Port n.2 mode bits
: GPIOE-CRL_CNF2   ( %XX -- ) 10 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF2    Port n.2 configuration  bits
: GPIOE-CRL_MODE3   ( %XX -- ) 12 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE3    Port n.3 mode bits
: GPIOE-CRL_CNF3   ( %XX -- ) 14 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF3    Port n.3 configuration  bits
: GPIOE-CRL_MODE4   ( %XX -- ) 16 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE4    Port n.4 mode bits
: GPIOE-CRL_CNF4   ( %XX -- ) 18 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF4    Port n.4 configuration  bits
: GPIOE-CRL_MODE5   ( %XX -- ) 20 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE5    Port n.5 mode bits
: GPIOE-CRL_CNF5   ( %XX -- ) 22 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF5    Port n.5 configuration  bits
: GPIOE-CRL_MODE6   ( %XX -- ) 24 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE6    Port n.6 mode bits
: GPIOE-CRL_CNF6   ( %XX -- ) 26 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF6    Port n.6 configuration  bits
: GPIOE-CRL_MODE7   ( %XX -- ) 28 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_MODE7    Port n.7 mode bits
: GPIOE-CRL_CNF7   ( %XX -- ) 30 lshift GPIOE-CRL bis! ;  \ GPIOE-CRL_CNF7    Port n.7 configuration  bits

\ GPIOE-CRH (read-write)
: GPIOE-CRH_MODE8   ( %XX -- ) 0 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE8    Port n.8 mode bits
: GPIOE-CRH_CNF8   ( %XX -- ) 2 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF8    Port n.8 configuration  bits
: GPIOE-CRH_MODE9   ( %XX -- ) 4 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE9    Port n.9 mode bits
: GPIOE-CRH_CNF9   ( %XX -- ) 6 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF9    Port n.9 configuration  bits
: GPIOE-CRH_MODE10   ( %XX -- ) 8 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE10    Port n.10 mode bits
: GPIOE-CRH_CNF10   ( %XX -- ) 10 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF10    Port n.10 configuration  bits
: GPIOE-CRH_MODE11   ( %XX -- ) 12 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE11    Port n.11 mode bits
: GPIOE-CRH_CNF11   ( %XX -- ) 14 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF11    Port n.11 configuration  bits
: GPIOE-CRH_MODE12   ( %XX -- ) 16 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE12    Port n.12 mode bits
: GPIOE-CRH_CNF12   ( %XX -- ) 18 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF12    Port n.12 configuration  bits
: GPIOE-CRH_MODE13   ( %XX -- ) 20 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE13    Port n.13 mode bits
: GPIOE-CRH_CNF13   ( %XX -- ) 22 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF13    Port n.13 configuration  bits
: GPIOE-CRH_MODE14   ( %XX -- ) 24 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE14    Port n.14 mode bits
: GPIOE-CRH_CNF14   ( %XX -- ) 26 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF14    Port n.14 configuration  bits
: GPIOE-CRH_MODE15   ( %XX -- ) 28 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_MODE15    Port n.15 mode bits
: GPIOE-CRH_CNF15   ( %XX -- ) 30 lshift GPIOE-CRH bis! ;  \ GPIOE-CRH_CNF15    Port n.15 configuration  bits

\ GPIOE-IDR (read-only)
: GPIOE-IDR_IDR0   %1 0 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR0    Port input data
: GPIOE-IDR_IDR1   %1 1 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR1    Port input data
: GPIOE-IDR_IDR2   %1 2 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR2    Port input data
: GPIOE-IDR_IDR3   %1 3 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR3    Port input data
: GPIOE-IDR_IDR4   %1 4 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR4    Port input data
: GPIOE-IDR_IDR5   %1 5 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR5    Port input data
: GPIOE-IDR_IDR6   %1 6 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR6    Port input data
: GPIOE-IDR_IDR7   %1 7 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR7    Port input data
: GPIOE-IDR_IDR8   %1 8 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR8    Port input data
: GPIOE-IDR_IDR9   %1 9 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR9    Port input data
: GPIOE-IDR_IDR10   %1 10 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR10    Port input data
: GPIOE-IDR_IDR11   %1 11 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR11    Port input data
: GPIOE-IDR_IDR12   %1 12 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR12    Port input data
: GPIOE-IDR_IDR13   %1 13 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR13    Port input data
: GPIOE-IDR_IDR14   %1 14 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR14    Port input data
: GPIOE-IDR_IDR15   %1 15 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR15    Port input data

\ GPIOE-ODR (read-write)
: GPIOE-ODR_ODR0   %1 0 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR0    Port output data
: GPIOE-ODR_ODR1   %1 1 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR1    Port output data
: GPIOE-ODR_ODR2   %1 2 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR2    Port output data
: GPIOE-ODR_ODR3   %1 3 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR3    Port output data
: GPIOE-ODR_ODR4   %1 4 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR4    Port output data
: GPIOE-ODR_ODR5   %1 5 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR5    Port output data
: GPIOE-ODR_ODR6   %1 6 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR6    Port output data
: GPIOE-ODR_ODR7   %1 7 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR7    Port output data
: GPIOE-ODR_ODR8   %1 8 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR8    Port output data
: GPIOE-ODR_ODR9   %1 9 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR9    Port output data
: GPIOE-ODR_ODR10   %1 10 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR10    Port output data
: GPIOE-ODR_ODR11   %1 11 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR11    Port output data
: GPIOE-ODR_ODR12   %1 12 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR12    Port output data
: GPIOE-ODR_ODR13   %1 13 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR13    Port output data
: GPIOE-ODR_ODR14   %1 14 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR14    Port output data
: GPIOE-ODR_ODR15   %1 15 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR15    Port output data

\ GPIOE-BSRR (write-only)
: GPIOE-BSRR_BS0   %1 0 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS0    Set bit 0
: GPIOE-BSRR_BS1   %1 1 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS1    Set bit 1
: GPIOE-BSRR_BS2   %1 2 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS2    Set bit 1
: GPIOE-BSRR_BS3   %1 3 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS3    Set bit 3
: GPIOE-BSRR_BS4   %1 4 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS4    Set bit 4
: GPIOE-BSRR_BS5   %1 5 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS5    Set bit 5
: GPIOE-BSRR_BS6   %1 6 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS6    Set bit 6
: GPIOE-BSRR_BS7   %1 7 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS7    Set bit 7
: GPIOE-BSRR_BS8   %1 8 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS8    Set bit 8
: GPIOE-BSRR_BS9   %1 9 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS9    Set bit 9
: GPIOE-BSRR_BS10   %1 10 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS10    Set bit 10
: GPIOE-BSRR_BS11   %1 11 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS11    Set bit 11
: GPIOE-BSRR_BS12   %1 12 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS12    Set bit 12
: GPIOE-BSRR_BS13   %1 13 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS13    Set bit 13
: GPIOE-BSRR_BS14   %1 14 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS14    Set bit 14
: GPIOE-BSRR_BS15   %1 15 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS15    Set bit 15
: GPIOE-BSRR_BR0   %1 16 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR0    Reset bit 0
: GPIOE-BSRR_BR1   %1 17 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR1    Reset bit 1
: GPIOE-BSRR_BR2   %1 18 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR2    Reset bit 2
: GPIOE-BSRR_BR3   %1 19 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR3    Reset bit 3
: GPIOE-BSRR_BR4   %1 20 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR4    Reset bit 4
: GPIOE-BSRR_BR5   %1 21 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR5    Reset bit 5
: GPIOE-BSRR_BR6   %1 22 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR6    Reset bit 6
: GPIOE-BSRR_BR7   %1 23 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR7    Reset bit 7
: GPIOE-BSRR_BR8   %1 24 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR8    Reset bit 8
: GPIOE-BSRR_BR9   %1 25 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR9    Reset bit 9
: GPIOE-BSRR_BR10   %1 26 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR10    Reset bit 10
: GPIOE-BSRR_BR11   %1 27 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR11    Reset bit 11
: GPIOE-BSRR_BR12   %1 28 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR12    Reset bit 12
: GPIOE-BSRR_BR13   %1 29 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR13    Reset bit 13
: GPIOE-BSRR_BR14   %1 30 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR14    Reset bit 14
: GPIOE-BSRR_BR15   %1 31 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR15    Reset bit 15

\ GPIOE-BRR (write-only)
: GPIOE-BRR_BR0   %1 0 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR0    Reset bit 0
: GPIOE-BRR_BR1   %1 1 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR1    Reset bit 1
: GPIOE-BRR_BR2   %1 2 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR2    Reset bit 1
: GPIOE-BRR_BR3   %1 3 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR3    Reset bit 3
: GPIOE-BRR_BR4   %1 4 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR4    Reset bit 4
: GPIOE-BRR_BR5   %1 5 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR5    Reset bit 5
: GPIOE-BRR_BR6   %1 6 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR6    Reset bit 6
: GPIOE-BRR_BR7   %1 7 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR7    Reset bit 7
: GPIOE-BRR_BR8   %1 8 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR8    Reset bit 8
: GPIOE-BRR_BR9   %1 9 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR9    Reset bit 9
: GPIOE-BRR_BR10   %1 10 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR10    Reset bit 10
: GPIOE-BRR_BR11   %1 11 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR11    Reset bit 11
: GPIOE-BRR_BR12   %1 12 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR12    Reset bit 12
: GPIOE-BRR_BR13   %1 13 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR13    Reset bit 13
: GPIOE-BRR_BR14   %1 14 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR14    Reset bit 14
: GPIOE-BRR_BR15   %1 15 lshift GPIOE-BRR bis! ;  \ GPIOE-BRR_BR15    Reset bit 15

\ GPIOE-LCKR (read-write)
: GPIOE-LCKR_LCK0   %1 0 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK0    Port A Lock bit 0
: GPIOE-LCKR_LCK1   %1 1 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK1    Port A Lock bit 1
: GPIOE-LCKR_LCK2   %1 2 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK2    Port A Lock bit 2
: GPIOE-LCKR_LCK3   %1 3 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK3    Port A Lock bit 3
: GPIOE-LCKR_LCK4   %1 4 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK4    Port A Lock bit 4
: GPIOE-LCKR_LCK5   %1 5 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK5    Port A Lock bit 5
: GPIOE-LCKR_LCK6   %1 6 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK6    Port A Lock bit 6
: GPIOE-LCKR_LCK7   %1 7 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK7    Port A Lock bit 7
: GPIOE-LCKR_LCK8   %1 8 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK8    Port A Lock bit 8
: GPIOE-LCKR_LCK9   %1 9 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK9    Port A Lock bit 9
: GPIOE-LCKR_LCK10   %1 10 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK10    Port A Lock bit 10
: GPIOE-LCKR_LCK11   %1 11 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK11    Port A Lock bit 11
: GPIOE-LCKR_LCK12   %1 12 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK12    Port A Lock bit 12
: GPIOE-LCKR_LCK13   %1 13 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK13    Port A Lock bit 13
: GPIOE-LCKR_LCK14   %1 14 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK14    Port A Lock bit 14
: GPIOE-LCKR_LCK15   %1 15 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK15    Port A Lock bit 15
: GPIOE-LCKR_LCKK   %1 16 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCKK    Lock key

\ GPIOF-CRL (read-write)
: GPIOF-CRL_MODE0   ( %XX -- ) 0 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE0    Port n.0 mode bits
: GPIOF-CRL_CNF0   ( %XX -- ) 2 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF0    Port n.0 configuration  bits
: GPIOF-CRL_MODE1   ( %XX -- ) 4 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE1    Port n.1 mode bits
: GPIOF-CRL_CNF1   ( %XX -- ) 6 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF1    Port n.1 configuration  bits
: GPIOF-CRL_MODE2   ( %XX -- ) 8 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE2    Port n.2 mode bits
: GPIOF-CRL_CNF2   ( %XX -- ) 10 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF2    Port n.2 configuration  bits
: GPIOF-CRL_MODE3   ( %XX -- ) 12 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE3    Port n.3 mode bits
: GPIOF-CRL_CNF3   ( %XX -- ) 14 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF3    Port n.3 configuration  bits
: GPIOF-CRL_MODE4   ( %XX -- ) 16 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE4    Port n.4 mode bits
: GPIOF-CRL_CNF4   ( %XX -- ) 18 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF4    Port n.4 configuration  bits
: GPIOF-CRL_MODE5   ( %XX -- ) 20 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE5    Port n.5 mode bits
: GPIOF-CRL_CNF5   ( %XX -- ) 22 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF5    Port n.5 configuration  bits
: GPIOF-CRL_MODE6   ( %XX -- ) 24 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE6    Port n.6 mode bits
: GPIOF-CRL_CNF6   ( %XX -- ) 26 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF6    Port n.6 configuration  bits
: GPIOF-CRL_MODE7   ( %XX -- ) 28 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_MODE7    Port n.7 mode bits
: GPIOF-CRL_CNF7   ( %XX -- ) 30 lshift GPIOF-CRL bis! ;  \ GPIOF-CRL_CNF7    Port n.7 configuration  bits

\ GPIOF-CRH (read-write)
: GPIOF-CRH_MODE8   ( %XX -- ) 0 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE8    Port n.8 mode bits
: GPIOF-CRH_CNF8   ( %XX -- ) 2 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF8    Port n.8 configuration  bits
: GPIOF-CRH_MODE9   ( %XX -- ) 4 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE9    Port n.9 mode bits
: GPIOF-CRH_CNF9   ( %XX -- ) 6 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF9    Port n.9 configuration  bits
: GPIOF-CRH_MODE10   ( %XX -- ) 8 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE10    Port n.10 mode bits
: GPIOF-CRH_CNF10   ( %XX -- ) 10 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF10    Port n.10 configuration  bits
: GPIOF-CRH_MODE11   ( %XX -- ) 12 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE11    Port n.11 mode bits
: GPIOF-CRH_CNF11   ( %XX -- ) 14 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF11    Port n.11 configuration  bits
: GPIOF-CRH_MODE12   ( %XX -- ) 16 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE12    Port n.12 mode bits
: GPIOF-CRH_CNF12   ( %XX -- ) 18 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF12    Port n.12 configuration  bits
: GPIOF-CRH_MODE13   ( %XX -- ) 20 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE13    Port n.13 mode bits
: GPIOF-CRH_CNF13   ( %XX -- ) 22 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF13    Port n.13 configuration  bits
: GPIOF-CRH_MODE14   ( %XX -- ) 24 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE14    Port n.14 mode bits
: GPIOF-CRH_CNF14   ( %XX -- ) 26 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF14    Port n.14 configuration  bits
: GPIOF-CRH_MODE15   ( %XX -- ) 28 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_MODE15    Port n.15 mode bits
: GPIOF-CRH_CNF15   ( %XX -- ) 30 lshift GPIOF-CRH bis! ;  \ GPIOF-CRH_CNF15    Port n.15 configuration  bits

\ GPIOF-IDR (read-only)
: GPIOF-IDR_IDR0   %1 0 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR0    Port input data
: GPIOF-IDR_IDR1   %1 1 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR1    Port input data
: GPIOF-IDR_IDR2   %1 2 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR2    Port input data
: GPIOF-IDR_IDR3   %1 3 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR3    Port input data
: GPIOF-IDR_IDR4   %1 4 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR4    Port input data
: GPIOF-IDR_IDR5   %1 5 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR5    Port input data
: GPIOF-IDR_IDR6   %1 6 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR6    Port input data
: GPIOF-IDR_IDR7   %1 7 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR7    Port input data
: GPIOF-IDR_IDR8   %1 8 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR8    Port input data
: GPIOF-IDR_IDR9   %1 9 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR9    Port input data
: GPIOF-IDR_IDR10   %1 10 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR10    Port input data
: GPIOF-IDR_IDR11   %1 11 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR11    Port input data
: GPIOF-IDR_IDR12   %1 12 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR12    Port input data
: GPIOF-IDR_IDR13   %1 13 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR13    Port input data
: GPIOF-IDR_IDR14   %1 14 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR14    Port input data
: GPIOF-IDR_IDR15   %1 15 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR15    Port input data

\ GPIOF-ODR (read-write)
: GPIOF-ODR_ODR0   %1 0 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR0    Port output data
: GPIOF-ODR_ODR1   %1 1 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR1    Port output data
: GPIOF-ODR_ODR2   %1 2 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR2    Port output data
: GPIOF-ODR_ODR3   %1 3 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR3    Port output data
: GPIOF-ODR_ODR4   %1 4 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR4    Port output data
: GPIOF-ODR_ODR5   %1 5 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR5    Port output data
: GPIOF-ODR_ODR6   %1 6 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR6    Port output data
: GPIOF-ODR_ODR7   %1 7 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR7    Port output data
: GPIOF-ODR_ODR8   %1 8 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR8    Port output data
: GPIOF-ODR_ODR9   %1 9 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR9    Port output data
: GPIOF-ODR_ODR10   %1 10 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR10    Port output data
: GPIOF-ODR_ODR11   %1 11 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR11    Port output data
: GPIOF-ODR_ODR12   %1 12 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR12    Port output data
: GPIOF-ODR_ODR13   %1 13 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR13    Port output data
: GPIOF-ODR_ODR14   %1 14 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR14    Port output data
: GPIOF-ODR_ODR15   %1 15 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR15    Port output data

\ GPIOF-BSRR (write-only)
: GPIOF-BSRR_BS0   %1 0 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS0    Set bit 0
: GPIOF-BSRR_BS1   %1 1 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS1    Set bit 1
: GPIOF-BSRR_BS2   %1 2 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS2    Set bit 1
: GPIOF-BSRR_BS3   %1 3 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS3    Set bit 3
: GPIOF-BSRR_BS4   %1 4 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS4    Set bit 4
: GPIOF-BSRR_BS5   %1 5 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS5    Set bit 5
: GPIOF-BSRR_BS6   %1 6 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS6    Set bit 6
: GPIOF-BSRR_BS7   %1 7 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS7    Set bit 7
: GPIOF-BSRR_BS8   %1 8 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS8    Set bit 8
: GPIOF-BSRR_BS9   %1 9 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS9    Set bit 9
: GPIOF-BSRR_BS10   %1 10 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS10    Set bit 10
: GPIOF-BSRR_BS11   %1 11 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS11    Set bit 11
: GPIOF-BSRR_BS12   %1 12 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS12    Set bit 12
: GPIOF-BSRR_BS13   %1 13 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS13    Set bit 13
: GPIOF-BSRR_BS14   %1 14 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS14    Set bit 14
: GPIOF-BSRR_BS15   %1 15 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS15    Set bit 15
: GPIOF-BSRR_BR0   %1 16 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR0    Reset bit 0
: GPIOF-BSRR_BR1   %1 17 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR1    Reset bit 1
: GPIOF-BSRR_BR2   %1 18 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR2    Reset bit 2
: GPIOF-BSRR_BR3   %1 19 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR3    Reset bit 3
: GPIOF-BSRR_BR4   %1 20 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR4    Reset bit 4
: GPIOF-BSRR_BR5   %1 21 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR5    Reset bit 5
: GPIOF-BSRR_BR6   %1 22 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR6    Reset bit 6
: GPIOF-BSRR_BR7   %1 23 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR7    Reset bit 7
: GPIOF-BSRR_BR8   %1 24 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR8    Reset bit 8
: GPIOF-BSRR_BR9   %1 25 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR9    Reset bit 9
: GPIOF-BSRR_BR10   %1 26 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR10    Reset bit 10
: GPIOF-BSRR_BR11   %1 27 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR11    Reset bit 11
: GPIOF-BSRR_BR12   %1 28 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR12    Reset bit 12
: GPIOF-BSRR_BR13   %1 29 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR13    Reset bit 13
: GPIOF-BSRR_BR14   %1 30 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR14    Reset bit 14
: GPIOF-BSRR_BR15   %1 31 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR15    Reset bit 15

\ GPIOF-BRR (write-only)
: GPIOF-BRR_BR0   %1 0 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR0    Reset bit 0
: GPIOF-BRR_BR1   %1 1 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR1    Reset bit 1
: GPIOF-BRR_BR2   %1 2 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR2    Reset bit 1
: GPIOF-BRR_BR3   %1 3 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR3    Reset bit 3
: GPIOF-BRR_BR4   %1 4 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR4    Reset bit 4
: GPIOF-BRR_BR5   %1 5 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR5    Reset bit 5
: GPIOF-BRR_BR6   %1 6 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR6    Reset bit 6
: GPIOF-BRR_BR7   %1 7 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR7    Reset bit 7
: GPIOF-BRR_BR8   %1 8 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR8    Reset bit 8
: GPIOF-BRR_BR9   %1 9 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR9    Reset bit 9
: GPIOF-BRR_BR10   %1 10 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR10    Reset bit 10
: GPIOF-BRR_BR11   %1 11 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR11    Reset bit 11
: GPIOF-BRR_BR12   %1 12 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR12    Reset bit 12
: GPIOF-BRR_BR13   %1 13 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR13    Reset bit 13
: GPIOF-BRR_BR14   %1 14 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR14    Reset bit 14
: GPIOF-BRR_BR15   %1 15 lshift GPIOF-BRR bis! ;  \ GPIOF-BRR_BR15    Reset bit 15

\ GPIOF-LCKR (read-write)
: GPIOF-LCKR_LCK0   %1 0 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK0    Port A Lock bit 0
: GPIOF-LCKR_LCK1   %1 1 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK1    Port A Lock bit 1
: GPIOF-LCKR_LCK2   %1 2 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK2    Port A Lock bit 2
: GPIOF-LCKR_LCK3   %1 3 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK3    Port A Lock bit 3
: GPIOF-LCKR_LCK4   %1 4 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK4    Port A Lock bit 4
: GPIOF-LCKR_LCK5   %1 5 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK5    Port A Lock bit 5
: GPIOF-LCKR_LCK6   %1 6 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK6    Port A Lock bit 6
: GPIOF-LCKR_LCK7   %1 7 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK7    Port A Lock bit 7
: GPIOF-LCKR_LCK8   %1 8 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK8    Port A Lock bit 8
: GPIOF-LCKR_LCK9   %1 9 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK9    Port A Lock bit 9
: GPIOF-LCKR_LCK10   %1 10 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK10    Port A Lock bit 10
: GPIOF-LCKR_LCK11   %1 11 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK11    Port A Lock bit 11
: GPIOF-LCKR_LCK12   %1 12 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK12    Port A Lock bit 12
: GPIOF-LCKR_LCK13   %1 13 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK13    Port A Lock bit 13
: GPIOF-LCKR_LCK14   %1 14 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK14    Port A Lock bit 14
: GPIOF-LCKR_LCK15   %1 15 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK15    Port A Lock bit 15
: GPIOF-LCKR_LCKK   %1 16 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCKK    Lock key

\ GPIOG-CRL (read-write)
: GPIOG-CRL_MODE0   ( %XX -- ) 0 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE0    Port n.0 mode bits
: GPIOG-CRL_CNF0   ( %XX -- ) 2 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF0    Port n.0 configuration  bits
: GPIOG-CRL_MODE1   ( %XX -- ) 4 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE1    Port n.1 mode bits
: GPIOG-CRL_CNF1   ( %XX -- ) 6 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF1    Port n.1 configuration  bits
: GPIOG-CRL_MODE2   ( %XX -- ) 8 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE2    Port n.2 mode bits
: GPIOG-CRL_CNF2   ( %XX -- ) 10 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF2    Port n.2 configuration  bits
: GPIOG-CRL_MODE3   ( %XX -- ) 12 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE3    Port n.3 mode bits
: GPIOG-CRL_CNF3   ( %XX -- ) 14 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF3    Port n.3 configuration  bits
: GPIOG-CRL_MODE4   ( %XX -- ) 16 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE4    Port n.4 mode bits
: GPIOG-CRL_CNF4   ( %XX -- ) 18 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF4    Port n.4 configuration  bits
: GPIOG-CRL_MODE5   ( %XX -- ) 20 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE5    Port n.5 mode bits
: GPIOG-CRL_CNF5   ( %XX -- ) 22 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF5    Port n.5 configuration  bits
: GPIOG-CRL_MODE6   ( %XX -- ) 24 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE6    Port n.6 mode bits
: GPIOG-CRL_CNF6   ( %XX -- ) 26 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF6    Port n.6 configuration  bits
: GPIOG-CRL_MODE7   ( %XX -- ) 28 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_MODE7    Port n.7 mode bits
: GPIOG-CRL_CNF7   ( %XX -- ) 30 lshift GPIOG-CRL bis! ;  \ GPIOG-CRL_CNF7    Port n.7 configuration  bits

\ GPIOG-CRH (read-write)
: GPIOG-CRH_MODE8   ( %XX -- ) 0 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE8    Port n.8 mode bits
: GPIOG-CRH_CNF8   ( %XX -- ) 2 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF8    Port n.8 configuration  bits
: GPIOG-CRH_MODE9   ( %XX -- ) 4 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE9    Port n.9 mode bits
: GPIOG-CRH_CNF9   ( %XX -- ) 6 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF9    Port n.9 configuration  bits
: GPIOG-CRH_MODE10   ( %XX -- ) 8 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE10    Port n.10 mode bits
: GPIOG-CRH_CNF10   ( %XX -- ) 10 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF10    Port n.10 configuration  bits
: GPIOG-CRH_MODE11   ( %XX -- ) 12 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE11    Port n.11 mode bits
: GPIOG-CRH_CNF11   ( %XX -- ) 14 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF11    Port n.11 configuration  bits
: GPIOG-CRH_MODE12   ( %XX -- ) 16 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE12    Port n.12 mode bits
: GPIOG-CRH_CNF12   ( %XX -- ) 18 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF12    Port n.12 configuration  bits
: GPIOG-CRH_MODE13   ( %XX -- ) 20 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE13    Port n.13 mode bits
: GPIOG-CRH_CNF13   ( %XX -- ) 22 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF13    Port n.13 configuration  bits
: GPIOG-CRH_MODE14   ( %XX -- ) 24 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE14    Port n.14 mode bits
: GPIOG-CRH_CNF14   ( %XX -- ) 26 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF14    Port n.14 configuration  bits
: GPIOG-CRH_MODE15   ( %XX -- ) 28 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_MODE15    Port n.15 mode bits
: GPIOG-CRH_CNF15   ( %XX -- ) 30 lshift GPIOG-CRH bis! ;  \ GPIOG-CRH_CNF15    Port n.15 configuration  bits

\ GPIOG-IDR (read-only)
: GPIOG-IDR_IDR0   %1 0 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR0    Port input data
: GPIOG-IDR_IDR1   %1 1 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR1    Port input data
: GPIOG-IDR_IDR2   %1 2 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR2    Port input data
: GPIOG-IDR_IDR3   %1 3 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR3    Port input data
: GPIOG-IDR_IDR4   %1 4 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR4    Port input data
: GPIOG-IDR_IDR5   %1 5 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR5    Port input data
: GPIOG-IDR_IDR6   %1 6 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR6    Port input data
: GPIOG-IDR_IDR7   %1 7 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR7    Port input data
: GPIOG-IDR_IDR8   %1 8 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR8    Port input data
: GPIOG-IDR_IDR9   %1 9 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR9    Port input data
: GPIOG-IDR_IDR10   %1 10 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR10    Port input data
: GPIOG-IDR_IDR11   %1 11 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR11    Port input data
: GPIOG-IDR_IDR12   %1 12 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR12    Port input data
: GPIOG-IDR_IDR13   %1 13 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR13    Port input data
: GPIOG-IDR_IDR14   %1 14 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR14    Port input data
: GPIOG-IDR_IDR15   %1 15 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR15    Port input data

\ GPIOG-ODR (read-write)
: GPIOG-ODR_ODR0   %1 0 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR0    Port output data
: GPIOG-ODR_ODR1   %1 1 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR1    Port output data
: GPIOG-ODR_ODR2   %1 2 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR2    Port output data
: GPIOG-ODR_ODR3   %1 3 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR3    Port output data
: GPIOG-ODR_ODR4   %1 4 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR4    Port output data
: GPIOG-ODR_ODR5   %1 5 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR5    Port output data
: GPIOG-ODR_ODR6   %1 6 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR6    Port output data
: GPIOG-ODR_ODR7   %1 7 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR7    Port output data
: GPIOG-ODR_ODR8   %1 8 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR8    Port output data
: GPIOG-ODR_ODR9   %1 9 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR9    Port output data
: GPIOG-ODR_ODR10   %1 10 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR10    Port output data
: GPIOG-ODR_ODR11   %1 11 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR11    Port output data
: GPIOG-ODR_ODR12   %1 12 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR12    Port output data
: GPIOG-ODR_ODR13   %1 13 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR13    Port output data
: GPIOG-ODR_ODR14   %1 14 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR14    Port output data
: GPIOG-ODR_ODR15   %1 15 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR15    Port output data

\ GPIOG-BSRR (write-only)
: GPIOG-BSRR_BS0   %1 0 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS0    Set bit 0
: GPIOG-BSRR_BS1   %1 1 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS1    Set bit 1
: GPIOG-BSRR_BS2   %1 2 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS2    Set bit 1
: GPIOG-BSRR_BS3   %1 3 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS3    Set bit 3
: GPIOG-BSRR_BS4   %1 4 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS4    Set bit 4
: GPIOG-BSRR_BS5   %1 5 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS5    Set bit 5
: GPIOG-BSRR_BS6   %1 6 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS6    Set bit 6
: GPIOG-BSRR_BS7   %1 7 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS7    Set bit 7
: GPIOG-BSRR_BS8   %1 8 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS8    Set bit 8
: GPIOG-BSRR_BS9   %1 9 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS9    Set bit 9
: GPIOG-BSRR_BS10   %1 10 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS10    Set bit 10
: GPIOG-BSRR_BS11   %1 11 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS11    Set bit 11
: GPIOG-BSRR_BS12   %1 12 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS12    Set bit 12
: GPIOG-BSRR_BS13   %1 13 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS13    Set bit 13
: GPIOG-BSRR_BS14   %1 14 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS14    Set bit 14
: GPIOG-BSRR_BS15   %1 15 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS15    Set bit 15
: GPIOG-BSRR_BR0   %1 16 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR0    Reset bit 0
: GPIOG-BSRR_BR1   %1 17 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR1    Reset bit 1
: GPIOG-BSRR_BR2   %1 18 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR2    Reset bit 2
: GPIOG-BSRR_BR3   %1 19 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR3    Reset bit 3
: GPIOG-BSRR_BR4   %1 20 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR4    Reset bit 4
: GPIOG-BSRR_BR5   %1 21 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR5    Reset bit 5
: GPIOG-BSRR_BR6   %1 22 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR6    Reset bit 6
: GPIOG-BSRR_BR7   %1 23 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR7    Reset bit 7
: GPIOG-BSRR_BR8   %1 24 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR8    Reset bit 8
: GPIOG-BSRR_BR9   %1 25 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR9    Reset bit 9
: GPIOG-BSRR_BR10   %1 26 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR10    Reset bit 10
: GPIOG-BSRR_BR11   %1 27 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR11    Reset bit 11
: GPIOG-BSRR_BR12   %1 28 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR12    Reset bit 12
: GPIOG-BSRR_BR13   %1 29 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR13    Reset bit 13
: GPIOG-BSRR_BR14   %1 30 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR14    Reset bit 14
: GPIOG-BSRR_BR15   %1 31 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR15    Reset bit 15

\ GPIOG-BRR (write-only)
: GPIOG-BRR_BR0   %1 0 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR0    Reset bit 0
: GPIOG-BRR_BR1   %1 1 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR1    Reset bit 1
: GPIOG-BRR_BR2   %1 2 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR2    Reset bit 1
: GPIOG-BRR_BR3   %1 3 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR3    Reset bit 3
: GPIOG-BRR_BR4   %1 4 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR4    Reset bit 4
: GPIOG-BRR_BR5   %1 5 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR5    Reset bit 5
: GPIOG-BRR_BR6   %1 6 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR6    Reset bit 6
: GPIOG-BRR_BR7   %1 7 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR7    Reset bit 7
: GPIOG-BRR_BR8   %1 8 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR8    Reset bit 8
: GPIOG-BRR_BR9   %1 9 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR9    Reset bit 9
: GPIOG-BRR_BR10   %1 10 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR10    Reset bit 10
: GPIOG-BRR_BR11   %1 11 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR11    Reset bit 11
: GPIOG-BRR_BR12   %1 12 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR12    Reset bit 12
: GPIOG-BRR_BR13   %1 13 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR13    Reset bit 13
: GPIOG-BRR_BR14   %1 14 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR14    Reset bit 14
: GPIOG-BRR_BR15   %1 15 lshift GPIOG-BRR bis! ;  \ GPIOG-BRR_BR15    Reset bit 15

\ GPIOG-LCKR (read-write)
: GPIOG-LCKR_LCK0   %1 0 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK0    Port A Lock bit 0
: GPIOG-LCKR_LCK1   %1 1 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK1    Port A Lock bit 1
: GPIOG-LCKR_LCK2   %1 2 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK2    Port A Lock bit 2
: GPIOG-LCKR_LCK3   %1 3 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK3    Port A Lock bit 3
: GPIOG-LCKR_LCK4   %1 4 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK4    Port A Lock bit 4
: GPIOG-LCKR_LCK5   %1 5 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK5    Port A Lock bit 5
: GPIOG-LCKR_LCK6   %1 6 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK6    Port A Lock bit 6
: GPIOG-LCKR_LCK7   %1 7 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK7    Port A Lock bit 7
: GPIOG-LCKR_LCK8   %1 8 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK8    Port A Lock bit 8
: GPIOG-LCKR_LCK9   %1 9 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK9    Port A Lock bit 9
: GPIOG-LCKR_LCK10   %1 10 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK10    Port A Lock bit 10
: GPIOG-LCKR_LCK11   %1 11 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK11    Port A Lock bit 11
: GPIOG-LCKR_LCK12   %1 12 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK12    Port A Lock bit 12
: GPIOG-LCKR_LCK13   %1 13 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK13    Port A Lock bit 13
: GPIOG-LCKR_LCK14   %1 14 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK14    Port A Lock bit 14
: GPIOG-LCKR_LCK15   %1 15 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK15    Port A Lock bit 15
: GPIOG-LCKR_LCKK   %1 16 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCKK    Lock key

\ AFIO-EVCR (read-write)
: AFIO-EVCR_PIN   ( %XXXX -- ) 0 lshift AFIO-EVCR bis! ;  \ AFIO-EVCR_PIN    Pin selection
: AFIO-EVCR_PORT   ( %XXX -- ) 4 lshift AFIO-EVCR bis! ;  \ AFIO-EVCR_PORT    Port selection
: AFIO-EVCR_EVOE   %1 7 lshift AFIO-EVCR bis! ;  \ AFIO-EVCR_EVOE    Event Output Enable

\ AFIO-MAPR ()
: AFIO-MAPR_SPI1_REMAP   %1 0 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_SPI1_REMAP    SPI1 remapping
: AFIO-MAPR_I2C1_REMAP   %1 1 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_I2C1_REMAP    I2C1 remapping
: AFIO-MAPR_USART1_REMAP   %1 2 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_USART1_REMAP    USART1 remapping
: AFIO-MAPR_USART2_REMAP   %1 3 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_USART2_REMAP    USART2 remapping
: AFIO-MAPR_USART3_REMAP   ( %XX -- ) 4 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_USART3_REMAP    USART3 remapping
: AFIO-MAPR_TIM1_REMAP   ( %XX -- ) 6 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_TIM1_REMAP    TIM1 remapping
: AFIO-MAPR_TIM2_REMAP   ( %XX -- ) 8 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_TIM2_REMAP    TIM2 remapping
: AFIO-MAPR_TIM3_REMAP   ( %XX -- ) 10 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_TIM3_REMAP    TIM3 remapping
: AFIO-MAPR_TIM4_REMAP   %1 12 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_TIM4_REMAP    TIM4 remapping
: AFIO-MAPR_CAN_REMAP   ( %XX -- ) 13 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_CAN_REMAP    CAN1 remapping
: AFIO-MAPR_PD01_REMAP   %1 15 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_PD01_REMAP    Port D0/Port D1 mapping on  OSCIN/OSCOUT
: AFIO-MAPR_TIM5CH4_IREMAP   %1 16 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_TIM5CH4_IREMAP    Set and cleared by  software
: AFIO-MAPR_ADC1_ETRGINJ_REMAP   %1 17 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_ADC1_ETRGINJ_REMAP    ADC 1 External trigger injected  conversion remapping
: AFIO-MAPR_ADC1_ETRGREG_REMAP   %1 18 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_ADC1_ETRGREG_REMAP    ADC 1 external trigger regular  conversion remapping
: AFIO-MAPR_ADC2_ETRGINJ_REMAP   %1 19 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_ADC2_ETRGINJ_REMAP    ADC 2 external trigger injected  conversion remapping
: AFIO-MAPR_ADC2_ETRGREG_REMAP   %1 20 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_ADC2_ETRGREG_REMAP    ADC 2 external trigger regular  conversion remapping
: AFIO-MAPR_SWJ_CFG   ( %XXX -- ) 24 lshift AFIO-MAPR bis! ;  \ AFIO-MAPR_SWJ_CFG    Serial wire JTAG  configuration

\ AFIO-EXTICR1 (read-write)
: AFIO-EXTICR1_EXTI0   ( %XXXX -- ) 0 lshift AFIO-EXTICR1 bis! ;  \ AFIO-EXTICR1_EXTI0    EXTI0 configuration
: AFIO-EXTICR1_EXTI1   ( %XXXX -- ) 4 lshift AFIO-EXTICR1 bis! ;  \ AFIO-EXTICR1_EXTI1    EXTI1 configuration
: AFIO-EXTICR1_EXTI2   ( %XXXX -- ) 8 lshift AFIO-EXTICR1 bis! ;  \ AFIO-EXTICR1_EXTI2    EXTI2 configuration
: AFIO-EXTICR1_EXTI3   ( %XXXX -- ) 12 lshift AFIO-EXTICR1 bis! ;  \ AFIO-EXTICR1_EXTI3    EXTI3 configuration

\ AFIO-EXTICR2 (read-write)
: AFIO-EXTICR2_EXTI4   ( %XXXX -- ) 0 lshift AFIO-EXTICR2 bis! ;  \ AFIO-EXTICR2_EXTI4    EXTI4 configuration
: AFIO-EXTICR2_EXTI5   ( %XXXX -- ) 4 lshift AFIO-EXTICR2 bis! ;  \ AFIO-EXTICR2_EXTI5    EXTI5 configuration
: AFIO-EXTICR2_EXTI6   ( %XXXX -- ) 8 lshift AFIO-EXTICR2 bis! ;  \ AFIO-EXTICR2_EXTI6    EXTI6 configuration
: AFIO-EXTICR2_EXTI7   ( %XXXX -- ) 12 lshift AFIO-EXTICR2 bis! ;  \ AFIO-EXTICR2_EXTI7    EXTI7 configuration

\ AFIO-EXTICR3 (read-write)
: AFIO-EXTICR3_EXTI8   ( %XXXX -- ) 0 lshift AFIO-EXTICR3 bis! ;  \ AFIO-EXTICR3_EXTI8    EXTI8 configuration
: AFIO-EXTICR3_EXTI9   ( %XXXX -- ) 4 lshift AFIO-EXTICR3 bis! ;  \ AFIO-EXTICR3_EXTI9    EXTI9 configuration
: AFIO-EXTICR3_EXTI10   ( %XXXX -- ) 8 lshift AFIO-EXTICR3 bis! ;  \ AFIO-EXTICR3_EXTI10    EXTI10 configuration
: AFIO-EXTICR3_EXTI11   ( %XXXX -- ) 12 lshift AFIO-EXTICR3 bis! ;  \ AFIO-EXTICR3_EXTI11    EXTI11 configuration

\ AFIO-EXTICR4 (read-write)
: AFIO-EXTICR4_EXTI12   ( %XXXX -- ) 0 lshift AFIO-EXTICR4 bis! ;  \ AFIO-EXTICR4_EXTI12    EXTI12 configuration
: AFIO-EXTICR4_EXTI13   ( %XXXX -- ) 4 lshift AFIO-EXTICR4 bis! ;  \ AFIO-EXTICR4_EXTI13    EXTI13 configuration
: AFIO-EXTICR4_EXTI14   ( %XXXX -- ) 8 lshift AFIO-EXTICR4 bis! ;  \ AFIO-EXTICR4_EXTI14    EXTI14 configuration
: AFIO-EXTICR4_EXTI15   ( %XXXX -- ) 12 lshift AFIO-EXTICR4 bis! ;  \ AFIO-EXTICR4_EXTI15    EXTI15 configuration

\ AFIO-MAPR2 (read-write)
: AFIO-MAPR2_TIM9_REMAP   %1 5 lshift AFIO-MAPR2 bis! ;  \ AFIO-MAPR2_TIM9_REMAP    TIM9 remapping
: AFIO-MAPR2_TIM10_REMAP   %1 6 lshift AFIO-MAPR2 bis! ;  \ AFIO-MAPR2_TIM10_REMAP    TIM10 remapping
: AFIO-MAPR2_TIM11_REMAP   %1 7 lshift AFIO-MAPR2 bis! ;  \ AFIO-MAPR2_TIM11_REMAP    TIM11 remapping
: AFIO-MAPR2_TIM13_REMAP   %1 8 lshift AFIO-MAPR2 bis! ;  \ AFIO-MAPR2_TIM13_REMAP    TIM13 remapping
: AFIO-MAPR2_TIM14_REMAP   %1 9 lshift AFIO-MAPR2 bis! ;  \ AFIO-MAPR2_TIM14_REMAP    TIM14 remapping
: AFIO-MAPR2_FSMC_NADV   %1 10 lshift AFIO-MAPR2 bis! ;  \ AFIO-MAPR2_FSMC_NADV    NADV connect/disconnect

\ EXTI-IMR (read-write)
: EXTI-IMR_MR0   %1 0 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR0    Interrupt Mask on line 0
: EXTI-IMR_MR1   %1 1 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR1    Interrupt Mask on line 1
: EXTI-IMR_MR2   %1 2 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR2    Interrupt Mask on line 2
: EXTI-IMR_MR3   %1 3 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR3    Interrupt Mask on line 3
: EXTI-IMR_MR4   %1 4 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR4    Interrupt Mask on line 4
: EXTI-IMR_MR5   %1 5 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR5    Interrupt Mask on line 5
: EXTI-IMR_MR6   %1 6 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR6    Interrupt Mask on line 6
: EXTI-IMR_MR7   %1 7 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR7    Interrupt Mask on line 7
: EXTI-IMR_MR8   %1 8 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR8    Interrupt Mask on line 8
: EXTI-IMR_MR9   %1 9 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR9    Interrupt Mask on line 9
: EXTI-IMR_MR10   %1 10 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR10    Interrupt Mask on line 10
: EXTI-IMR_MR11   %1 11 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR11    Interrupt Mask on line 11
: EXTI-IMR_MR12   %1 12 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR12    Interrupt Mask on line 12
: EXTI-IMR_MR13   %1 13 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR13    Interrupt Mask on line 13
: EXTI-IMR_MR14   %1 14 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR14    Interrupt Mask on line 14
: EXTI-IMR_MR15   %1 15 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR15    Interrupt Mask on line 15
: EXTI-IMR_MR16   %1 16 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR16    Interrupt Mask on line 16
: EXTI-IMR_MR17   %1 17 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR17    Interrupt Mask on line 17
: EXTI-IMR_MR18   %1 18 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR18    Interrupt Mask on line 18

\ EXTI-EMR (read-write)
: EXTI-EMR_MR0   %1 0 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR0    Event Mask on line 0
: EXTI-EMR_MR1   %1 1 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR1    Event Mask on line 1
: EXTI-EMR_MR2   %1 2 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR2    Event Mask on line 2
: EXTI-EMR_MR3   %1 3 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR3    Event Mask on line 3
: EXTI-EMR_MR4   %1 4 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR4    Event Mask on line 4
: EXTI-EMR_MR5   %1 5 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR5    Event Mask on line 5
: EXTI-EMR_MR6   %1 6 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR6    Event Mask on line 6
: EXTI-EMR_MR7   %1 7 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR7    Event Mask on line 7
: EXTI-EMR_MR8   %1 8 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR8    Event Mask on line 8
: EXTI-EMR_MR9   %1 9 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR9    Event Mask on line 9
: EXTI-EMR_MR10   %1 10 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR10    Event Mask on line 10
: EXTI-EMR_MR11   %1 11 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR11    Event Mask on line 11
: EXTI-EMR_MR12   %1 12 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR12    Event Mask on line 12
: EXTI-EMR_MR13   %1 13 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR13    Event Mask on line 13
: EXTI-EMR_MR14   %1 14 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR14    Event Mask on line 14
: EXTI-EMR_MR15   %1 15 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR15    Event Mask on line 15
: EXTI-EMR_MR16   %1 16 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR16    Event Mask on line 16
: EXTI-EMR_MR17   %1 17 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR17    Event Mask on line 17
: EXTI-EMR_MR18   %1 18 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR18    Event Mask on line 18

\ EXTI-RTSR (read-write)
: EXTI-RTSR_TR0   %1 0 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR0    Rising trigger event configuration of  line 0
: EXTI-RTSR_TR1   %1 1 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR1    Rising trigger event configuration of  line 1
: EXTI-RTSR_TR2   %1 2 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR2    Rising trigger event configuration of  line 2
: EXTI-RTSR_TR3   %1 3 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR3    Rising trigger event configuration of  line 3
: EXTI-RTSR_TR4   %1 4 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR4    Rising trigger event configuration of  line 4
: EXTI-RTSR_TR5   %1 5 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR5    Rising trigger event configuration of  line 5
: EXTI-RTSR_TR6   %1 6 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR6    Rising trigger event configuration of  line 6
: EXTI-RTSR_TR7   %1 7 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR7    Rising trigger event configuration of  line 7
: EXTI-RTSR_TR8   %1 8 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR8    Rising trigger event configuration of  line 8
: EXTI-RTSR_TR9   %1 9 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR9    Rising trigger event configuration of  line 9
: EXTI-RTSR_TR10   %1 10 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR10    Rising trigger event configuration of  line 10
: EXTI-RTSR_TR11   %1 11 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR11    Rising trigger event configuration of  line 11
: EXTI-RTSR_TR12   %1 12 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR12    Rising trigger event configuration of  line 12
: EXTI-RTSR_TR13   %1 13 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR13    Rising trigger event configuration of  line 13
: EXTI-RTSR_TR14   %1 14 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR14    Rising trigger event configuration of  line 14
: EXTI-RTSR_TR15   %1 15 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR15    Rising trigger event configuration of  line 15
: EXTI-RTSR_TR16   %1 16 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR16    Rising trigger event configuration of  line 16
: EXTI-RTSR_TR17   %1 17 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR17    Rising trigger event configuration of  line 17
: EXTI-RTSR_TR18   %1 18 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR18    Rising trigger event configuration of  line 18

\ EXTI-FTSR (read-write)
: EXTI-FTSR_TR0   %1 0 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR0    Falling trigger event configuration of  line 0
: EXTI-FTSR_TR1   %1 1 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR1    Falling trigger event configuration of  line 1
: EXTI-FTSR_TR2   %1 2 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR2    Falling trigger event configuration of  line 2
: EXTI-FTSR_TR3   %1 3 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR3    Falling trigger event configuration of  line 3
: EXTI-FTSR_TR4   %1 4 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR4    Falling trigger event configuration of  line 4
: EXTI-FTSR_TR5   %1 5 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR5    Falling trigger event configuration of  line 5
: EXTI-FTSR_TR6   %1 6 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR6    Falling trigger event configuration of  line 6
: EXTI-FTSR_TR7   %1 7 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR7    Falling trigger event configuration of  line 7
: EXTI-FTSR_TR8   %1 8 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR8    Falling trigger event configuration of  line 8
: EXTI-FTSR_TR9   %1 9 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR9    Falling trigger event configuration of  line 9
: EXTI-FTSR_TR10   %1 10 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR10    Falling trigger event configuration of  line 10
: EXTI-FTSR_TR11   %1 11 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR11    Falling trigger event configuration of  line 11
: EXTI-FTSR_TR12   %1 12 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR12    Falling trigger event configuration of  line 12
: EXTI-FTSR_TR13   %1 13 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR13    Falling trigger event configuration of  line 13
: EXTI-FTSR_TR14   %1 14 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR14    Falling trigger event configuration of  line 14
: EXTI-FTSR_TR15   %1 15 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR15    Falling trigger event configuration of  line 15
: EXTI-FTSR_TR16   %1 16 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR16    Falling trigger event configuration of  line 16
: EXTI-FTSR_TR17   %1 17 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR17    Falling trigger event configuration of  line 17
: EXTI-FTSR_TR18   %1 18 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR18    Falling trigger event configuration of  line 18

\ EXTI-SWIER (read-write)
: EXTI-SWIER_SWIER0   %1 0 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER0    Software Interrupt on line  0
: EXTI-SWIER_SWIER1   %1 1 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER1    Software Interrupt on line  1
: EXTI-SWIER_SWIER2   %1 2 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER2    Software Interrupt on line  2
: EXTI-SWIER_SWIER3   %1 3 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER3    Software Interrupt on line  3
: EXTI-SWIER_SWIER4   %1 4 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER4    Software Interrupt on line  4
: EXTI-SWIER_SWIER5   %1 5 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER5    Software Interrupt on line  5
: EXTI-SWIER_SWIER6   %1 6 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER6    Software Interrupt on line  6
: EXTI-SWIER_SWIER7   %1 7 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER7    Software Interrupt on line  7
: EXTI-SWIER_SWIER8   %1 8 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER8    Software Interrupt on line  8
: EXTI-SWIER_SWIER9   %1 9 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER9    Software Interrupt on line  9
: EXTI-SWIER_SWIER10   %1 10 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER10    Software Interrupt on line  10
: EXTI-SWIER_SWIER11   %1 11 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER11    Software Interrupt on line  11
: EXTI-SWIER_SWIER12   %1 12 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER12    Software Interrupt on line  12
: EXTI-SWIER_SWIER13   %1 13 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER13    Software Interrupt on line  13
: EXTI-SWIER_SWIER14   %1 14 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER14    Software Interrupt on line  14
: EXTI-SWIER_SWIER15   %1 15 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER15    Software Interrupt on line  15
: EXTI-SWIER_SWIER16   %1 16 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER16    Software Interrupt on line  16
: EXTI-SWIER_SWIER17   %1 17 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER17    Software Interrupt on line  17
: EXTI-SWIER_SWIER18   %1 18 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER18    Software Interrupt on line  18

\ EXTI-PR (read-write)
: EXTI-PR_PR0   %1 0 lshift EXTI-PR bis! ;  \ EXTI-PR_PR0    Pending bit 0
: EXTI-PR_PR1   %1 1 lshift EXTI-PR bis! ;  \ EXTI-PR_PR1    Pending bit 1
: EXTI-PR_PR2   %1 2 lshift EXTI-PR bis! ;  \ EXTI-PR_PR2    Pending bit 2
: EXTI-PR_PR3   %1 3 lshift EXTI-PR bis! ;  \ EXTI-PR_PR3    Pending bit 3
: EXTI-PR_PR4   %1 4 lshift EXTI-PR bis! ;  \ EXTI-PR_PR4    Pending bit 4
: EXTI-PR_PR5   %1 5 lshift EXTI-PR bis! ;  \ EXTI-PR_PR5    Pending bit 5
: EXTI-PR_PR6   %1 6 lshift EXTI-PR bis! ;  \ EXTI-PR_PR6    Pending bit 6
: EXTI-PR_PR7   %1 7 lshift EXTI-PR bis! ;  \ EXTI-PR_PR7    Pending bit 7
: EXTI-PR_PR8   %1 8 lshift EXTI-PR bis! ;  \ EXTI-PR_PR8    Pending bit 8
: EXTI-PR_PR9   %1 9 lshift EXTI-PR bis! ;  \ EXTI-PR_PR9    Pending bit 9
: EXTI-PR_PR10   %1 10 lshift EXTI-PR bis! ;  \ EXTI-PR_PR10    Pending bit 10
: EXTI-PR_PR11   %1 11 lshift EXTI-PR bis! ;  \ EXTI-PR_PR11    Pending bit 11
: EXTI-PR_PR12   %1 12 lshift EXTI-PR bis! ;  \ EXTI-PR_PR12    Pending bit 12
: EXTI-PR_PR13   %1 13 lshift EXTI-PR bis! ;  \ EXTI-PR_PR13    Pending bit 13
: EXTI-PR_PR14   %1 14 lshift EXTI-PR bis! ;  \ EXTI-PR_PR14    Pending bit 14
: EXTI-PR_PR15   %1 15 lshift EXTI-PR bis! ;  \ EXTI-PR_PR15    Pending bit 15
: EXTI-PR_PR16   %1 16 lshift EXTI-PR bis! ;  \ EXTI-PR_PR16    Pending bit 16
: EXTI-PR_PR17   %1 17 lshift EXTI-PR bis! ;  \ EXTI-PR_PR17    Pending bit 17
: EXTI-PR_PR18   %1 18 lshift EXTI-PR bis! ;  \ EXTI-PR_PR18    Pending bit 18

\ DMA1-ISR (read-only)
: DMA1-ISR_GIF1   %1 0 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF1    Channel 1 Global interrupt  flag
: DMA1-ISR_TCIF1   %1 1 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF1    Channel 1 Transfer Complete  flag
: DMA1-ISR_HTIF1   %1 2 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF1    Channel 1 Half Transfer Complete  flag
: DMA1-ISR_TEIF1   %1 3 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF1    Channel 1 Transfer Error  flag
: DMA1-ISR_GIF2   %1 4 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF2    Channel 2 Global interrupt  flag
: DMA1-ISR_TCIF2   %1 5 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF2    Channel 2 Transfer Complete  flag
: DMA1-ISR_HTIF2   %1 6 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF2    Channel 2 Half Transfer Complete  flag
: DMA1-ISR_TEIF2   %1 7 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF2    Channel 2 Transfer Error  flag
: DMA1-ISR_GIF3   %1 8 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF3    Channel 3 Global interrupt  flag
: DMA1-ISR_TCIF3   %1 9 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF3    Channel 3 Transfer Complete  flag
: DMA1-ISR_HTIF3   %1 10 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF3    Channel 3 Half Transfer Complete  flag
: DMA1-ISR_TEIF3   %1 11 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF3    Channel 3 Transfer Error  flag
: DMA1-ISR_GIF4   %1 12 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF4    Channel 4 Global interrupt  flag
: DMA1-ISR_TCIF4   %1 13 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF4    Channel 4 Transfer Complete  flag
: DMA1-ISR_HTIF4   %1 14 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF4    Channel 4 Half Transfer Complete  flag
: DMA1-ISR_TEIF4   %1 15 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF4    Channel 4 Transfer Error  flag
: DMA1-ISR_GIF5   %1 16 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF5    Channel 5 Global interrupt  flag
: DMA1-ISR_TCIF5   %1 17 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF5    Channel 5 Transfer Complete  flag
: DMA1-ISR_HTIF5   %1 18 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF5    Channel 5 Half Transfer Complete  flag
: DMA1-ISR_TEIF5   %1 19 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF5    Channel 5 Transfer Error  flag
: DMA1-ISR_GIF6   %1 20 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF6    Channel 6 Global interrupt  flag
: DMA1-ISR_TCIF6   %1 21 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF6    Channel 6 Transfer Complete  flag
: DMA1-ISR_HTIF6   %1 22 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF6    Channel 6 Half Transfer Complete  flag
: DMA1-ISR_TEIF6   %1 23 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF6    Channel 6 Transfer Error  flag
: DMA1-ISR_GIF7   %1 24 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF7    Channel 7 Global interrupt  flag
: DMA1-ISR_TCIF7   %1 25 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF7    Channel 7 Transfer Complete  flag
: DMA1-ISR_HTIF7   %1 26 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF7    Channel 7 Half Transfer Complete  flag
: DMA1-ISR_TEIF7   %1 27 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF7    Channel 7 Transfer Error  flag

\ DMA1-IFCR (write-only)
: DMA1-IFCR_CGIF1   %1 0 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF1    Channel 1 Global interrupt  clear
: DMA1-IFCR_CGIF2   %1 4 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF2    Channel 2 Global interrupt  clear
: DMA1-IFCR_CGIF3   %1 8 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF3    Channel 3 Global interrupt  clear
: DMA1-IFCR_CGIF4   %1 12 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF4    Channel 4 Global interrupt  clear
: DMA1-IFCR_CGIF5   %1 16 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF5    Channel 5 Global interrupt  clear
: DMA1-IFCR_CGIF6   %1 20 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF6    Channel 6 Global interrupt  clear
: DMA1-IFCR_CGIF7   %1 24 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF7    Channel 7 Global interrupt  clear
: DMA1-IFCR_CTCIF1   %1 1 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF1    Channel 1 Transfer Complete  clear
: DMA1-IFCR_CTCIF2   %1 5 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF2    Channel 2 Transfer Complete  clear
: DMA1-IFCR_CTCIF3   %1 9 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF3    Channel 3 Transfer Complete  clear
: DMA1-IFCR_CTCIF4   %1 13 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF4    Channel 4 Transfer Complete  clear
: DMA1-IFCR_CTCIF5   %1 17 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF5    Channel 5 Transfer Complete  clear
: DMA1-IFCR_CTCIF6   %1 21 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF6    Channel 6 Transfer Complete  clear
: DMA1-IFCR_CTCIF7   %1 25 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF7    Channel 7 Transfer Complete  clear
: DMA1-IFCR_CHTIF1   %1 2 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF1    Channel 1 Half Transfer  clear
: DMA1-IFCR_CHTIF2   %1 6 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF2    Channel 2 Half Transfer  clear
: DMA1-IFCR_CHTIF3   %1 10 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF3    Channel 3 Half Transfer  clear
: DMA1-IFCR_CHTIF4   %1 14 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF4    Channel 4 Half Transfer  clear
: DMA1-IFCR_CHTIF5   %1 18 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF5    Channel 5 Half Transfer  clear
: DMA1-IFCR_CHTIF6   %1 22 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF6    Channel 6 Half Transfer  clear
: DMA1-IFCR_CHTIF7   %1 26 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF7    Channel 7 Half Transfer  clear
: DMA1-IFCR_CTEIF1   %1 3 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF1    Channel 1 Transfer Error  clear
: DMA1-IFCR_CTEIF2   %1 7 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF2    Channel 2 Transfer Error  clear
: DMA1-IFCR_CTEIF3   %1 11 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF3    Channel 3 Transfer Error  clear
: DMA1-IFCR_CTEIF4   %1 15 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF4    Channel 4 Transfer Error  clear
: DMA1-IFCR_CTEIF5   %1 19 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF5    Channel 5 Transfer Error  clear
: DMA1-IFCR_CTEIF6   %1 23 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF6    Channel 6 Transfer Error  clear
: DMA1-IFCR_CTEIF7   %1 27 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF7    Channel 7 Transfer Error  clear

\ DMA1-CCR1 (read-write)
: DMA1-CCR1_EN   %1 0 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_EN    Channel enable
: DMA1-CCR1_TCIE   %1 1 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_TCIE    Transfer complete interrupt  enable
: DMA1-CCR1_HTIE   %1 2 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_HTIE    Half Transfer interrupt  enable
: DMA1-CCR1_TEIE   %1 3 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_TEIE    Transfer error interrupt  enable
: DMA1-CCR1_DIR   %1 4 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_DIR    Data transfer direction
: DMA1-CCR1_CIRC   %1 5 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_CIRC    Circular mode
: DMA1-CCR1_PINC   %1 6 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_PINC    Peripheral increment mode
: DMA1-CCR1_MINC   %1 7 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_MINC    Memory increment mode
: DMA1-CCR1_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_PSIZE    Peripheral size
: DMA1-CCR1_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_MSIZE    Memory size
: DMA1-CCR1_PL   ( %XX -- ) 12 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_PL    Channel Priority level
: DMA1-CCR1_MEM2MEM   %1 14 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_MEM2MEM    Memory to memory mode

\ DMA1-CNDTR1 (read-write)
: DMA1-CNDTR1_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR1 bis! ;  \ DMA1-CNDTR1_NDT    Number of data to transfer

\ DMA1-CPAR1 (read-write)
: DMA1-CPAR1_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR1 bis! ;  \ DMA1-CPAR1_PA    Peripheral address

\ DMA1-CMAR1 (read-write)
: DMA1-CMAR1_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR1 bis! ;  \ DMA1-CMAR1_MA    Memory address

\ DMA1-CCR2 (read-write)
: DMA1-CCR2_EN   %1 0 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_EN    Channel enable
: DMA1-CCR2_TCIE   %1 1 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_TCIE    Transfer complete interrupt  enable
: DMA1-CCR2_HTIE   %1 2 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_HTIE    Half Transfer interrupt  enable
: DMA1-CCR2_TEIE   %1 3 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_TEIE    Transfer error interrupt  enable
: DMA1-CCR2_DIR   %1 4 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_DIR    Data transfer direction
: DMA1-CCR2_CIRC   %1 5 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_CIRC    Circular mode
: DMA1-CCR2_PINC   %1 6 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_PINC    Peripheral increment mode
: DMA1-CCR2_MINC   %1 7 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_MINC    Memory increment mode
: DMA1-CCR2_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_PSIZE    Peripheral size
: DMA1-CCR2_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_MSIZE    Memory size
: DMA1-CCR2_PL   ( %XX -- ) 12 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_PL    Channel Priority level
: DMA1-CCR2_MEM2MEM   %1 14 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_MEM2MEM    Memory to memory mode

\ DMA1-CNDTR2 (read-write)
: DMA1-CNDTR2_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR2 bis! ;  \ DMA1-CNDTR2_NDT    Number of data to transfer

\ DMA1-CPAR2 (read-write)
: DMA1-CPAR2_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR2 bis! ;  \ DMA1-CPAR2_PA    Peripheral address

\ DMA1-CMAR2 (read-write)
: DMA1-CMAR2_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR2 bis! ;  \ DMA1-CMAR2_MA    Memory address

\ DMA1-CCR3 (read-write)
: DMA1-CCR3_EN   %1 0 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_EN    Channel enable
: DMA1-CCR3_TCIE   %1 1 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_TCIE    Transfer complete interrupt  enable
: DMA1-CCR3_HTIE   %1 2 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_HTIE    Half Transfer interrupt  enable
: DMA1-CCR3_TEIE   %1 3 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_TEIE    Transfer error interrupt  enable
: DMA1-CCR3_DIR   %1 4 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_DIR    Data transfer direction
: DMA1-CCR3_CIRC   %1 5 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_CIRC    Circular mode
: DMA1-CCR3_PINC   %1 6 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_PINC    Peripheral increment mode
: DMA1-CCR3_MINC   %1 7 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_MINC    Memory increment mode
: DMA1-CCR3_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_PSIZE    Peripheral size
: DMA1-CCR3_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_MSIZE    Memory size
: DMA1-CCR3_PL   ( %XX -- ) 12 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_PL    Channel Priority level
: DMA1-CCR3_MEM2MEM   %1 14 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_MEM2MEM    Memory to memory mode

\ DMA1-CNDTR3 (read-write)
: DMA1-CNDTR3_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR3 bis! ;  \ DMA1-CNDTR3_NDT    Number of data to transfer

\ DMA1-CPAR3 (read-write)
: DMA1-CPAR3_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR3 bis! ;  \ DMA1-CPAR3_PA    Peripheral address

\ DMA1-CMAR3 (read-write)
: DMA1-CMAR3_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR3 bis! ;  \ DMA1-CMAR3_MA    Memory address

\ DMA1-CCR4 (read-write)
: DMA1-CCR4_EN   %1 0 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_EN    Channel enable
: DMA1-CCR4_TCIE   %1 1 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_TCIE    Transfer complete interrupt  enable
: DMA1-CCR4_HTIE   %1 2 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_HTIE    Half Transfer interrupt  enable
: DMA1-CCR4_TEIE   %1 3 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_TEIE    Transfer error interrupt  enable
: DMA1-CCR4_DIR   %1 4 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_DIR    Data transfer direction
: DMA1-CCR4_CIRC   %1 5 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_CIRC    Circular mode
: DMA1-CCR4_PINC   %1 6 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_PINC    Peripheral increment mode
: DMA1-CCR4_MINC   %1 7 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_MINC    Memory increment mode
: DMA1-CCR4_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_PSIZE    Peripheral size
: DMA1-CCR4_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_MSIZE    Memory size
: DMA1-CCR4_PL   ( %XX -- ) 12 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_PL    Channel Priority level
: DMA1-CCR4_MEM2MEM   %1 14 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_MEM2MEM    Memory to memory mode

\ DMA1-CNDTR4 (read-write)
: DMA1-CNDTR4_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR4 bis! ;  \ DMA1-CNDTR4_NDT    Number of data to transfer

\ DMA1-CPAR4 (read-write)
: DMA1-CPAR4_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR4 bis! ;  \ DMA1-CPAR4_PA    Peripheral address

\ DMA1-CMAR4 (read-write)
: DMA1-CMAR4_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR4 bis! ;  \ DMA1-CMAR4_MA    Memory address

\ DMA1-CCR5 (read-write)
: DMA1-CCR5_EN   %1 0 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_EN    Channel enable
: DMA1-CCR5_TCIE   %1 1 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_TCIE    Transfer complete interrupt  enable
: DMA1-CCR5_HTIE   %1 2 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_HTIE    Half Transfer interrupt  enable
: DMA1-CCR5_TEIE   %1 3 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_TEIE    Transfer error interrupt  enable
: DMA1-CCR5_DIR   %1 4 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_DIR    Data transfer direction
: DMA1-CCR5_CIRC   %1 5 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_CIRC    Circular mode
: DMA1-CCR5_PINC   %1 6 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_PINC    Peripheral increment mode
: DMA1-CCR5_MINC   %1 7 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_MINC    Memory increment mode
: DMA1-CCR5_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_PSIZE    Peripheral size
: DMA1-CCR5_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_MSIZE    Memory size
: DMA1-CCR5_PL   ( %XX -- ) 12 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_PL    Channel Priority level
: DMA1-CCR5_MEM2MEM   %1 14 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_MEM2MEM    Memory to memory mode

\ DMA1-CNDTR5 (read-write)
: DMA1-CNDTR5_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR5 bis! ;  \ DMA1-CNDTR5_NDT    Number of data to transfer

\ DMA1-CPAR5 (read-write)
: DMA1-CPAR5_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR5 bis! ;  \ DMA1-CPAR5_PA    Peripheral address

\ DMA1-CMAR5 (read-write)
: DMA1-CMAR5_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR5 bis! ;  \ DMA1-CMAR5_MA    Memory address

\ DMA1-CCR6 (read-write)
: DMA1-CCR6_EN   %1 0 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_EN    Channel enable
: DMA1-CCR6_TCIE   %1 1 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_TCIE    Transfer complete interrupt  enable
: DMA1-CCR6_HTIE   %1 2 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_HTIE    Half Transfer interrupt  enable
: DMA1-CCR6_TEIE   %1 3 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_TEIE    Transfer error interrupt  enable
: DMA1-CCR6_DIR   %1 4 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_DIR    Data transfer direction
: DMA1-CCR6_CIRC   %1 5 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_CIRC    Circular mode
: DMA1-CCR6_PINC   %1 6 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_PINC    Peripheral increment mode
: DMA1-CCR6_MINC   %1 7 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_MINC    Memory increment mode
: DMA1-CCR6_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_PSIZE    Peripheral size
: DMA1-CCR6_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_MSIZE    Memory size
: DMA1-CCR6_PL   ( %XX -- ) 12 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_PL    Channel Priority level
: DMA1-CCR6_MEM2MEM   %1 14 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_MEM2MEM    Memory to memory mode

\ DMA1-CNDTR6 (read-write)
: DMA1-CNDTR6_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR6 bis! ;  \ DMA1-CNDTR6_NDT    Number of data to transfer

\ DMA1-CPAR6 (read-write)
: DMA1-CPAR6_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR6 bis! ;  \ DMA1-CPAR6_PA    Peripheral address

\ DMA1-CMAR6 (read-write)
: DMA1-CMAR6_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR6 bis! ;  \ DMA1-CMAR6_MA    Memory address

\ DMA1-CCR7 (read-write)
: DMA1-CCR7_EN   %1 0 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_EN    Channel enable
: DMA1-CCR7_TCIE   %1 1 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_TCIE    Transfer complete interrupt  enable
: DMA1-CCR7_HTIE   %1 2 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_HTIE    Half Transfer interrupt  enable
: DMA1-CCR7_TEIE   %1 3 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_TEIE    Transfer error interrupt  enable
: DMA1-CCR7_DIR   %1 4 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_DIR    Data transfer direction
: DMA1-CCR7_CIRC   %1 5 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_CIRC    Circular mode
: DMA1-CCR7_PINC   %1 6 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_PINC    Peripheral increment mode
: DMA1-CCR7_MINC   %1 7 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_MINC    Memory increment mode
: DMA1-CCR7_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_PSIZE    Peripheral size
: DMA1-CCR7_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_MSIZE    Memory size
: DMA1-CCR7_PL   ( %XX -- ) 12 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_PL    Channel Priority level
: DMA1-CCR7_MEM2MEM   %1 14 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_MEM2MEM    Memory to memory mode

\ DMA1-CNDTR7 (read-write)
: DMA1-CNDTR7_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR7 bis! ;  \ DMA1-CNDTR7_NDT    Number of data to transfer

\ DMA1-CPAR7 (read-write)
: DMA1-CPAR7_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR7 bis! ;  \ DMA1-CPAR7_PA    Peripheral address

\ DMA1-CMAR7 (read-write)
: DMA1-CMAR7_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR7 bis! ;  \ DMA1-CMAR7_MA    Memory address

\ DMA2-ISR (read-only)
: DMA2-ISR_GIF1   %1 0 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF1    Channel 1 Global interrupt  flag
: DMA2-ISR_TCIF1   %1 1 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF1    Channel 1 Transfer Complete  flag
: DMA2-ISR_HTIF1   %1 2 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF1    Channel 1 Half Transfer Complete  flag
: DMA2-ISR_TEIF1   %1 3 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF1    Channel 1 Transfer Error  flag
: DMA2-ISR_GIF2   %1 4 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF2    Channel 2 Global interrupt  flag
: DMA2-ISR_TCIF2   %1 5 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF2    Channel 2 Transfer Complete  flag
: DMA2-ISR_HTIF2   %1 6 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF2    Channel 2 Half Transfer Complete  flag
: DMA2-ISR_TEIF2   %1 7 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF2    Channel 2 Transfer Error  flag
: DMA2-ISR_GIF3   %1 8 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF3    Channel 3 Global interrupt  flag
: DMA2-ISR_TCIF3   %1 9 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF3    Channel 3 Transfer Complete  flag
: DMA2-ISR_HTIF3   %1 10 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF3    Channel 3 Half Transfer Complete  flag
: DMA2-ISR_TEIF3   %1 11 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF3    Channel 3 Transfer Error  flag
: DMA2-ISR_GIF4   %1 12 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF4    Channel 4 Global interrupt  flag
: DMA2-ISR_TCIF4   %1 13 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF4    Channel 4 Transfer Complete  flag
: DMA2-ISR_HTIF4   %1 14 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF4    Channel 4 Half Transfer Complete  flag
: DMA2-ISR_TEIF4   %1 15 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF4    Channel 4 Transfer Error  flag
: DMA2-ISR_GIF5   %1 16 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF5    Channel 5 Global interrupt  flag
: DMA2-ISR_TCIF5   %1 17 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF5    Channel 5 Transfer Complete  flag
: DMA2-ISR_HTIF5   %1 18 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF5    Channel 5 Half Transfer Complete  flag
: DMA2-ISR_TEIF5   %1 19 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF5    Channel 5 Transfer Error  flag
: DMA2-ISR_GIF6   %1 20 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF6    Channel 6 Global interrupt  flag
: DMA2-ISR_TCIF6   %1 21 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF6    Channel 6 Transfer Complete  flag
: DMA2-ISR_HTIF6   %1 22 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF6    Channel 6 Half Transfer Complete  flag
: DMA2-ISR_TEIF6   %1 23 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF6    Channel 6 Transfer Error  flag
: DMA2-ISR_GIF7   %1 24 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF7    Channel 7 Global interrupt  flag
: DMA2-ISR_TCIF7   %1 25 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF7    Channel 7 Transfer Complete  flag
: DMA2-ISR_HTIF7   %1 26 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF7    Channel 7 Half Transfer Complete  flag
: DMA2-ISR_TEIF7   %1 27 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF7    Channel 7 Transfer Error  flag

\ DMA2-IFCR (write-only)
: DMA2-IFCR_CGIF1   %1 0 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF1    Channel 1 Global interrupt  clear
: DMA2-IFCR_CGIF2   %1 4 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF2    Channel 2 Global interrupt  clear
: DMA2-IFCR_CGIF3   %1 8 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF3    Channel 3 Global interrupt  clear
: DMA2-IFCR_CGIF4   %1 12 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF4    Channel 4 Global interrupt  clear
: DMA2-IFCR_CGIF5   %1 16 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF5    Channel 5 Global interrupt  clear
: DMA2-IFCR_CGIF6   %1 20 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF6    Channel 6 Global interrupt  clear
: DMA2-IFCR_CGIF7   %1 24 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF7    Channel 7 Global interrupt  clear
: DMA2-IFCR_CTCIF1   %1 1 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF1    Channel 1 Transfer Complete  clear
: DMA2-IFCR_CTCIF2   %1 5 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF2    Channel 2 Transfer Complete  clear
: DMA2-IFCR_CTCIF3   %1 9 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF3    Channel 3 Transfer Complete  clear
: DMA2-IFCR_CTCIF4   %1 13 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF4    Channel 4 Transfer Complete  clear
: DMA2-IFCR_CTCIF5   %1 17 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF5    Channel 5 Transfer Complete  clear
: DMA2-IFCR_CTCIF6   %1 21 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF6    Channel 6 Transfer Complete  clear
: DMA2-IFCR_CTCIF7   %1 25 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF7    Channel 7 Transfer Complete  clear
: DMA2-IFCR_CHTIF1   %1 2 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF1    Channel 1 Half Transfer  clear
: DMA2-IFCR_CHTIF2   %1 6 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF2    Channel 2 Half Transfer  clear
: DMA2-IFCR_CHTIF3   %1 10 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF3    Channel 3 Half Transfer  clear
: DMA2-IFCR_CHTIF4   %1 14 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF4    Channel 4 Half Transfer  clear
: DMA2-IFCR_CHTIF5   %1 18 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF5    Channel 5 Half Transfer  clear
: DMA2-IFCR_CHTIF6   %1 22 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF6    Channel 6 Half Transfer  clear
: DMA2-IFCR_CHTIF7   %1 26 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF7    Channel 7 Half Transfer  clear
: DMA2-IFCR_CTEIF1   %1 3 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF1    Channel 1 Transfer Error  clear
: DMA2-IFCR_CTEIF2   %1 7 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF2    Channel 2 Transfer Error  clear
: DMA2-IFCR_CTEIF3   %1 11 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF3    Channel 3 Transfer Error  clear
: DMA2-IFCR_CTEIF4   %1 15 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF4    Channel 4 Transfer Error  clear
: DMA2-IFCR_CTEIF5   %1 19 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF5    Channel 5 Transfer Error  clear
: DMA2-IFCR_CTEIF6   %1 23 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF6    Channel 6 Transfer Error  clear
: DMA2-IFCR_CTEIF7   %1 27 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF7    Channel 7 Transfer Error  clear

\ DMA2-CCR1 (read-write)
: DMA2-CCR1_EN   %1 0 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_EN    Channel enable
: DMA2-CCR1_TCIE   %1 1 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_TCIE    Transfer complete interrupt  enable
: DMA2-CCR1_HTIE   %1 2 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_HTIE    Half Transfer interrupt  enable
: DMA2-CCR1_TEIE   %1 3 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_TEIE    Transfer error interrupt  enable
: DMA2-CCR1_DIR   %1 4 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_DIR    Data transfer direction
: DMA2-CCR1_CIRC   %1 5 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_CIRC    Circular mode
: DMA2-CCR1_PINC   %1 6 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_PINC    Peripheral increment mode
: DMA2-CCR1_MINC   %1 7 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_MINC    Memory increment mode
: DMA2-CCR1_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_PSIZE    Peripheral size
: DMA2-CCR1_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_MSIZE    Memory size
: DMA2-CCR1_PL   ( %XX -- ) 12 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_PL    Channel Priority level
: DMA2-CCR1_MEM2MEM   %1 14 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_MEM2MEM    Memory to memory mode

\ DMA2-CNDTR1 (read-write)
: DMA2-CNDTR1_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR1 bis! ;  \ DMA2-CNDTR1_NDT    Number of data to transfer

\ DMA2-CPAR1 (read-write)
: DMA2-CPAR1_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR1 bis! ;  \ DMA2-CPAR1_PA    Peripheral address

\ DMA2-CMAR1 (read-write)
: DMA2-CMAR1_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR1 bis! ;  \ DMA2-CMAR1_MA    Memory address

\ DMA2-CCR2 (read-write)
: DMA2-CCR2_EN   %1 0 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_EN    Channel enable
: DMA2-CCR2_TCIE   %1 1 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_TCIE    Transfer complete interrupt  enable
: DMA2-CCR2_HTIE   %1 2 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_HTIE    Half Transfer interrupt  enable
: DMA2-CCR2_TEIE   %1 3 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_TEIE    Transfer error interrupt  enable
: DMA2-CCR2_DIR   %1 4 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_DIR    Data transfer direction
: DMA2-CCR2_CIRC   %1 5 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_CIRC    Circular mode
: DMA2-CCR2_PINC   %1 6 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_PINC    Peripheral increment mode
: DMA2-CCR2_MINC   %1 7 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_MINC    Memory increment mode
: DMA2-CCR2_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_PSIZE    Peripheral size
: DMA2-CCR2_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_MSIZE    Memory size
: DMA2-CCR2_PL   ( %XX -- ) 12 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_PL    Channel Priority level
: DMA2-CCR2_MEM2MEM   %1 14 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_MEM2MEM    Memory to memory mode

\ DMA2-CNDTR2 (read-write)
: DMA2-CNDTR2_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR2 bis! ;  \ DMA2-CNDTR2_NDT    Number of data to transfer

\ DMA2-CPAR2 (read-write)
: DMA2-CPAR2_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR2 bis! ;  \ DMA2-CPAR2_PA    Peripheral address

\ DMA2-CMAR2 (read-write)
: DMA2-CMAR2_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR2 bis! ;  \ DMA2-CMAR2_MA    Memory address

\ DMA2-CCR3 (read-write)
: DMA2-CCR3_EN   %1 0 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_EN    Channel enable
: DMA2-CCR3_TCIE   %1 1 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_TCIE    Transfer complete interrupt  enable
: DMA2-CCR3_HTIE   %1 2 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_HTIE    Half Transfer interrupt  enable
: DMA2-CCR3_TEIE   %1 3 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_TEIE    Transfer error interrupt  enable
: DMA2-CCR3_DIR   %1 4 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_DIR    Data transfer direction
: DMA2-CCR3_CIRC   %1 5 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_CIRC    Circular mode
: DMA2-CCR3_PINC   %1 6 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_PINC    Peripheral increment mode
: DMA2-CCR3_MINC   %1 7 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_MINC    Memory increment mode
: DMA2-CCR3_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_PSIZE    Peripheral size
: DMA2-CCR3_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_MSIZE    Memory size
: DMA2-CCR3_PL   ( %XX -- ) 12 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_PL    Channel Priority level
: DMA2-CCR3_MEM2MEM   %1 14 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_MEM2MEM    Memory to memory mode

\ DMA2-CNDTR3 (read-write)
: DMA2-CNDTR3_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR3 bis! ;  \ DMA2-CNDTR3_NDT    Number of data to transfer

\ DMA2-CPAR3 (read-write)
: DMA2-CPAR3_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR3 bis! ;  \ DMA2-CPAR3_PA    Peripheral address

\ DMA2-CMAR3 (read-write)
: DMA2-CMAR3_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR3 bis! ;  \ DMA2-CMAR3_MA    Memory address

\ DMA2-CCR4 (read-write)
: DMA2-CCR4_EN   %1 0 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_EN    Channel enable
: DMA2-CCR4_TCIE   %1 1 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_TCIE    Transfer complete interrupt  enable
: DMA2-CCR4_HTIE   %1 2 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_HTIE    Half Transfer interrupt  enable
: DMA2-CCR4_TEIE   %1 3 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_TEIE    Transfer error interrupt  enable
: DMA2-CCR4_DIR   %1 4 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_DIR    Data transfer direction
: DMA2-CCR4_CIRC   %1 5 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_CIRC    Circular mode
: DMA2-CCR4_PINC   %1 6 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_PINC    Peripheral increment mode
: DMA2-CCR4_MINC   %1 7 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_MINC    Memory increment mode
: DMA2-CCR4_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_PSIZE    Peripheral size
: DMA2-CCR4_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_MSIZE    Memory size
: DMA2-CCR4_PL   ( %XX -- ) 12 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_PL    Channel Priority level
: DMA2-CCR4_MEM2MEM   %1 14 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_MEM2MEM    Memory to memory mode

\ DMA2-CNDTR4 (read-write)
: DMA2-CNDTR4_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR4 bis! ;  \ DMA2-CNDTR4_NDT    Number of data to transfer

\ DMA2-CPAR4 (read-write)
: DMA2-CPAR4_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR4 bis! ;  \ DMA2-CPAR4_PA    Peripheral address

\ DMA2-CMAR4 (read-write)
: DMA2-CMAR4_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR4 bis! ;  \ DMA2-CMAR4_MA    Memory address

\ DMA2-CCR5 (read-write)
: DMA2-CCR5_EN   %1 0 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_EN    Channel enable
: DMA2-CCR5_TCIE   %1 1 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_TCIE    Transfer complete interrupt  enable
: DMA2-CCR5_HTIE   %1 2 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_HTIE    Half Transfer interrupt  enable
: DMA2-CCR5_TEIE   %1 3 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_TEIE    Transfer error interrupt  enable
: DMA2-CCR5_DIR   %1 4 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_DIR    Data transfer direction
: DMA2-CCR5_CIRC   %1 5 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_CIRC    Circular mode
: DMA2-CCR5_PINC   %1 6 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_PINC    Peripheral increment mode
: DMA2-CCR5_MINC   %1 7 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_MINC    Memory increment mode
: DMA2-CCR5_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_PSIZE    Peripheral size
: DMA2-CCR5_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_MSIZE    Memory size
: DMA2-CCR5_PL   ( %XX -- ) 12 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_PL    Channel Priority level
: DMA2-CCR5_MEM2MEM   %1 14 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_MEM2MEM    Memory to memory mode

\ DMA2-CNDTR5 (read-write)
: DMA2-CNDTR5_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR5 bis! ;  \ DMA2-CNDTR5_NDT    Number of data to transfer

\ DMA2-CPAR5 (read-write)
: DMA2-CPAR5_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR5 bis! ;  \ DMA2-CPAR5_PA    Peripheral address

\ DMA2-CMAR5 (read-write)
: DMA2-CMAR5_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR5 bis! ;  \ DMA2-CMAR5_MA    Memory address

\ DMA2-CCR6 (read-write)
: DMA2-CCR6_EN   %1 0 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_EN    Channel enable
: DMA2-CCR6_TCIE   %1 1 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_TCIE    Transfer complete interrupt  enable
: DMA2-CCR6_HTIE   %1 2 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_HTIE    Half Transfer interrupt  enable
: DMA2-CCR6_TEIE   %1 3 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_TEIE    Transfer error interrupt  enable
: DMA2-CCR6_DIR   %1 4 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_DIR    Data transfer direction
: DMA2-CCR6_CIRC   %1 5 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_CIRC    Circular mode
: DMA2-CCR6_PINC   %1 6 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_PINC    Peripheral increment mode
: DMA2-CCR6_MINC   %1 7 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_MINC    Memory increment mode
: DMA2-CCR6_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_PSIZE    Peripheral size
: DMA2-CCR6_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_MSIZE    Memory size
: DMA2-CCR6_PL   ( %XX -- ) 12 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_PL    Channel Priority level
: DMA2-CCR6_MEM2MEM   %1 14 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_MEM2MEM    Memory to memory mode

\ DMA2-CNDTR6 (read-write)
: DMA2-CNDTR6_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR6 bis! ;  \ DMA2-CNDTR6_NDT    Number of data to transfer

\ DMA2-CPAR6 (read-write)
: DMA2-CPAR6_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR6 bis! ;  \ DMA2-CPAR6_PA    Peripheral address

\ DMA2-CMAR6 (read-write)
: DMA2-CMAR6_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR6 bis! ;  \ DMA2-CMAR6_MA    Memory address

\ DMA2-CCR7 (read-write)
: DMA2-CCR7_EN   %1 0 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_EN    Channel enable
: DMA2-CCR7_TCIE   %1 1 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_TCIE    Transfer complete interrupt  enable
: DMA2-CCR7_HTIE   %1 2 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_HTIE    Half Transfer interrupt  enable
: DMA2-CCR7_TEIE   %1 3 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_TEIE    Transfer error interrupt  enable
: DMA2-CCR7_DIR   %1 4 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_DIR    Data transfer direction
: DMA2-CCR7_CIRC   %1 5 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_CIRC    Circular mode
: DMA2-CCR7_PINC   %1 6 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_PINC    Peripheral increment mode
: DMA2-CCR7_MINC   %1 7 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_MINC    Memory increment mode
: DMA2-CCR7_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_PSIZE    Peripheral size
: DMA2-CCR7_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_MSIZE    Memory size
: DMA2-CCR7_PL   ( %XX -- ) 12 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_PL    Channel Priority level
: DMA2-CCR7_MEM2MEM   %1 14 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_MEM2MEM    Memory to memory mode

\ DMA2-CNDTR7 (read-write)
: DMA2-CNDTR7_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR7 bis! ;  \ DMA2-CNDTR7_NDT    Number of data to transfer

\ DMA2-CPAR7 (read-write)
: DMA2-CPAR7_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR7 bis! ;  \ DMA2-CPAR7_PA    Peripheral address

\ DMA2-CMAR7 (read-write)
: DMA2-CMAR7_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR7 bis! ;  \ DMA2-CMAR7_MA    Memory address

\ SDIO-POWER (read-write)
: SDIO-POWER_PWRCTRL   ( %XX -- ) 0 lshift SDIO-POWER bis! ;  \ SDIO-POWER_PWRCTRL    PWRCTRL

\ SDIO-CLKCR (read-write)
: SDIO-CLKCR_CLKDIV   ( %XXXXXXXX -- ) 0 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_CLKDIV    Clock divide factor
: SDIO-CLKCR_CLKEN   %1 8 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_CLKEN    Clock enable bit
: SDIO-CLKCR_PWRSAV   %1 9 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_PWRSAV    Power saving configuration  bit
: SDIO-CLKCR_BYPASS   %1 10 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_BYPASS    Clock divider bypass enable  bit
: SDIO-CLKCR_WIDBUS   ( %XX -- ) 11 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_WIDBUS    Wide bus mode enable bit
: SDIO-CLKCR_NEGEDGE   %1 13 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_NEGEDGE    SDIO_CK dephasing selection  bit
: SDIO-CLKCR_HWFC_EN   %1 14 lshift SDIO-CLKCR bis! ;  \ SDIO-CLKCR_HWFC_EN    HW Flow Control enable

\ SDIO-ARG (read-write)
: SDIO-ARG_CMDARG   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-ARG bis! ;  \ SDIO-ARG_CMDARG    Command argument

\ SDIO-CMD (read-write)
: SDIO-CMD_CMDINDEX   ( %XXXXXX -- ) 0 lshift SDIO-CMD bis! ;  \ SDIO-CMD_CMDINDEX    CMDINDEX
: SDIO-CMD_WAITRESP   ( %XX -- ) 6 lshift SDIO-CMD bis! ;  \ SDIO-CMD_WAITRESP    WAITRESP
: SDIO-CMD_WAITINT   %1 8 lshift SDIO-CMD bis! ;  \ SDIO-CMD_WAITINT    WAITINT
: SDIO-CMD_WAITPEND   %1 9 lshift SDIO-CMD bis! ;  \ SDIO-CMD_WAITPEND    WAITPEND
: SDIO-CMD_CPSMEN   %1 10 lshift SDIO-CMD bis! ;  \ SDIO-CMD_CPSMEN    CPSMEN
: SDIO-CMD_SDIOSuspend   %1 11 lshift SDIO-CMD bis! ;  \ SDIO-CMD_SDIOSuspend    SDIOSuspend
: SDIO-CMD_ENCMDcompl   %1 12 lshift SDIO-CMD bis! ;  \ SDIO-CMD_ENCMDcompl    ENCMDcompl
: SDIO-CMD_nIEN   %1 13 lshift SDIO-CMD bis! ;  \ SDIO-CMD_nIEN    nIEN
: SDIO-CMD_CE_ATACMD   %1 14 lshift SDIO-CMD bis! ;  \ SDIO-CMD_CE_ATACMD    CE_ATACMD

\ SDIO-RESPCMD (read-only)
: SDIO-RESPCMD_RESPCMD   ( %XXXXXX -- ) 0 lshift SDIO-RESPCMD bis! ;  \ SDIO-RESPCMD_RESPCMD    RESPCMD

\ SDIO-RESPI1 (read-only)
: SDIO-RESPI1_CARDSTATUS1   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESPI1 bis! ;  \ SDIO-RESPI1_CARDSTATUS1    CARDSTATUS1

\ SDIO-RESP2 (read-only)
: SDIO-RESP2_CARDSTATUS2   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESP2 bis! ;  \ SDIO-RESP2_CARDSTATUS2    CARDSTATUS2

\ SDIO-RESP3 (read-only)
: SDIO-RESP3_CARDSTATUS3   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESP3 bis! ;  \ SDIO-RESP3_CARDSTATUS3    CARDSTATUS3

\ SDIO-RESP4 (read-only)
: SDIO-RESP4_CARDSTATUS4   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-RESP4 bis! ;  \ SDIO-RESP4_CARDSTATUS4    CARDSTATUS4

\ SDIO-DTIMER (read-write)
: SDIO-DTIMER_DATATIME   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-DTIMER bis! ;  \ SDIO-DTIMER_DATATIME    Data timeout period

\ SDIO-DLEN (read-write)
: SDIO-DLEN_DATALENGTH  0 lshift SDIO-DLEN bis! ;  \ SDIO-DLEN_DATALENGTH    Data length value

\ SDIO-DCTRL (read-write)
: SDIO-DCTRL_DTEN   %1 0 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DTEN    DTEN
: SDIO-DCTRL_DTDIR   %1 1 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DTDIR    DTDIR
: SDIO-DCTRL_DTMODE   %1 2 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DTMODE    DTMODE
: SDIO-DCTRL_DMAEN   %1 3 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DMAEN    DMAEN
: SDIO-DCTRL_DBLOCKSIZE   ( %XXXX -- ) 4 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_DBLOCKSIZE    DBLOCKSIZE
: SDIO-DCTRL_PWSTART   %1 8 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_PWSTART    PWSTART
: SDIO-DCTRL_PWSTOP   %1 9 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_PWSTOP    PWSTOP
: SDIO-DCTRL_RWMOD   %1 10 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_RWMOD    RWMOD
: SDIO-DCTRL_SDIOEN   %1 11 lshift SDIO-DCTRL bis! ;  \ SDIO-DCTRL_SDIOEN    SDIOEN

\ SDIO-DCOUNT (read-only)
: SDIO-DCOUNT_DATACOUNT  0 lshift SDIO-DCOUNT bis! ;  \ SDIO-DCOUNT_DATACOUNT    Data count value

\ SDIO-STA (read-only)
: SDIO-STA_CCRCFAIL   %1 0 lshift SDIO-STA bis! ;  \ SDIO-STA_CCRCFAIL    CCRCFAIL
: SDIO-STA_DCRCFAIL   %1 1 lshift SDIO-STA bis! ;  \ SDIO-STA_DCRCFAIL    DCRCFAIL
: SDIO-STA_CTIMEOUT   %1 2 lshift SDIO-STA bis! ;  \ SDIO-STA_CTIMEOUT    CTIMEOUT
: SDIO-STA_DTIMEOUT   %1 3 lshift SDIO-STA bis! ;  \ SDIO-STA_DTIMEOUT    DTIMEOUT
: SDIO-STA_TXUNDERR   %1 4 lshift SDIO-STA bis! ;  \ SDIO-STA_TXUNDERR    TXUNDERR
: SDIO-STA_RXOVERR   %1 5 lshift SDIO-STA bis! ;  \ SDIO-STA_RXOVERR    RXOVERR
: SDIO-STA_CMDREND   %1 6 lshift SDIO-STA bis! ;  \ SDIO-STA_CMDREND    CMDREND
: SDIO-STA_CMDSENT   %1 7 lshift SDIO-STA bis! ;  \ SDIO-STA_CMDSENT    CMDSENT
: SDIO-STA_DATAEND   %1 8 lshift SDIO-STA bis! ;  \ SDIO-STA_DATAEND    DATAEND
: SDIO-STA_STBITERR   %1 9 lshift SDIO-STA bis! ;  \ SDIO-STA_STBITERR    STBITERR
: SDIO-STA_DBCKEND   %1 10 lshift SDIO-STA bis! ;  \ SDIO-STA_DBCKEND    DBCKEND
: SDIO-STA_CMDACT   %1 11 lshift SDIO-STA bis! ;  \ SDIO-STA_CMDACT    CMDACT
: SDIO-STA_TXACT   %1 12 lshift SDIO-STA bis! ;  \ SDIO-STA_TXACT    TXACT
: SDIO-STA_RXACT   %1 13 lshift SDIO-STA bis! ;  \ SDIO-STA_RXACT    RXACT
: SDIO-STA_TXFIFOHE   %1 14 lshift SDIO-STA bis! ;  \ SDIO-STA_TXFIFOHE    TXFIFOHE
: SDIO-STA_RXFIFOHF   %1 15 lshift SDIO-STA bis! ;  \ SDIO-STA_RXFIFOHF    RXFIFOHF
: SDIO-STA_TXFIFOF   %1 16 lshift SDIO-STA bis! ;  \ SDIO-STA_TXFIFOF    TXFIFOF
: SDIO-STA_RXFIFOF   %1 17 lshift SDIO-STA bis! ;  \ SDIO-STA_RXFIFOF    RXFIFOF
: SDIO-STA_TXFIFOE   %1 18 lshift SDIO-STA bis! ;  \ SDIO-STA_TXFIFOE    TXFIFOE
: SDIO-STA_RXFIFOE   %1 19 lshift SDIO-STA bis! ;  \ SDIO-STA_RXFIFOE    RXFIFOE
: SDIO-STA_TXDAVL   %1 20 lshift SDIO-STA bis! ;  \ SDIO-STA_TXDAVL    TXDAVL
: SDIO-STA_RXDAVL   %1 21 lshift SDIO-STA bis! ;  \ SDIO-STA_RXDAVL    RXDAVL
: SDIO-STA_SDIOIT   %1 22 lshift SDIO-STA bis! ;  \ SDIO-STA_SDIOIT    SDIOIT
: SDIO-STA_CEATAEND   %1 23 lshift SDIO-STA bis! ;  \ SDIO-STA_CEATAEND    CEATAEND

\ SDIO-ICR (read-write)
: SDIO-ICR_CCRCFAILC   %1 0 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CCRCFAILC    CCRCFAILC
: SDIO-ICR_DCRCFAILC   %1 1 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DCRCFAILC    DCRCFAILC
: SDIO-ICR_CTIMEOUTC   %1 2 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CTIMEOUTC    CTIMEOUTC
: SDIO-ICR_DTIMEOUTC   %1 3 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DTIMEOUTC    DTIMEOUTC
: SDIO-ICR_TXUNDERRC   %1 4 lshift SDIO-ICR bis! ;  \ SDIO-ICR_TXUNDERRC    TXUNDERRC
: SDIO-ICR_RXOVERRC   %1 5 lshift SDIO-ICR bis! ;  \ SDIO-ICR_RXOVERRC    RXOVERRC
: SDIO-ICR_CMDRENDC   %1 6 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CMDRENDC    CMDRENDC
: SDIO-ICR_CMDSENTC   %1 7 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CMDSENTC    CMDSENTC
: SDIO-ICR_DATAENDC   %1 8 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DATAENDC    DATAENDC
: SDIO-ICR_STBITERRC   %1 9 lshift SDIO-ICR bis! ;  \ SDIO-ICR_STBITERRC    STBITERRC
: SDIO-ICR_DBCKENDC   %1 10 lshift SDIO-ICR bis! ;  \ SDIO-ICR_DBCKENDC    DBCKENDC
: SDIO-ICR_SDIOITC   %1 22 lshift SDIO-ICR bis! ;  \ SDIO-ICR_SDIOITC    SDIOITC
: SDIO-ICR_CEATAENDC   %1 23 lshift SDIO-ICR bis! ;  \ SDIO-ICR_CEATAENDC    CEATAENDC

\ SDIO-MASK (read-write)
: SDIO-MASK_CCRCFAILIE   %1 0 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CCRCFAILIE    CCRCFAILIE
: SDIO-MASK_DCRCFAILIE   %1 1 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DCRCFAILIE    DCRCFAILIE
: SDIO-MASK_CTIMEOUTIE   %1 2 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CTIMEOUTIE    CTIMEOUTIE
: SDIO-MASK_DTIMEOUTIE   %1 3 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DTIMEOUTIE    DTIMEOUTIE
: SDIO-MASK_TXUNDERRIE   %1 4 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXUNDERRIE    TXUNDERRIE
: SDIO-MASK_RXOVERRIE   %1 5 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXOVERRIE    RXOVERRIE
: SDIO-MASK_CMDRENDIE   %1 6 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CMDRENDIE    CMDRENDIE
: SDIO-MASK_CMDSENTIE   %1 7 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CMDSENTIE    CMDSENTIE
: SDIO-MASK_DATAENDIE   %1 8 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DATAENDIE    DATAENDIE
: SDIO-MASK_STBITERRIE   %1 9 lshift SDIO-MASK bis! ;  \ SDIO-MASK_STBITERRIE    STBITERRIE
: SDIO-MASK_DBACKENDIE   %1 10 lshift SDIO-MASK bis! ;  \ SDIO-MASK_DBACKENDIE    DBACKENDIE
: SDIO-MASK_CMDACTIE   %1 11 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CMDACTIE    CMDACTIE
: SDIO-MASK_TXACTIE   %1 12 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXACTIE    TXACTIE
: SDIO-MASK_RXACTIE   %1 13 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXACTIE    RXACTIE
: SDIO-MASK_TXFIFOHEIE   %1 14 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXFIFOHEIE    TXFIFOHEIE
: SDIO-MASK_RXFIFOHFIE   %1 15 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXFIFOHFIE    RXFIFOHFIE
: SDIO-MASK_TXFIFOFIE   %1 16 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXFIFOFIE    TXFIFOFIE
: SDIO-MASK_RXFIFOFIE   %1 17 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXFIFOFIE    RXFIFOFIE
: SDIO-MASK_TXFIFOEIE   %1 18 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXFIFOEIE    TXFIFOEIE
: SDIO-MASK_RXFIFOEIE   %1 19 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXFIFOEIE    RXFIFOEIE
: SDIO-MASK_TXDAVLIE   %1 20 lshift SDIO-MASK bis! ;  \ SDIO-MASK_TXDAVLIE    TXDAVLIE
: SDIO-MASK_RXDAVLIE   %1 21 lshift SDIO-MASK bis! ;  \ SDIO-MASK_RXDAVLIE    RXDAVLIE
: SDIO-MASK_SDIOITIE   %1 22 lshift SDIO-MASK bis! ;  \ SDIO-MASK_SDIOITIE    SDIOITIE
: SDIO-MASK_CEATENDIE   %1 23 lshift SDIO-MASK bis! ;  \ SDIO-MASK_CEATENDIE    CEATENDIE

\ SDIO-FIFOCNT (read-only)
: SDIO-FIFOCNT_FIF0COUNT   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-FIFOCNT bis! ;  \ SDIO-FIFOCNT_FIF0COUNT    FIF0COUNT

\ SDIO-FIFO (read-write)
: SDIO-FIFO_FIFOData   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SDIO-FIFO bis! ;  \ SDIO-FIFO_FIFOData    FIFOData

\ RTC-CRH (read-write)
: RTC-CRH_SECIE   %1 0 lshift RTC-CRH bis! ;  \ RTC-CRH_SECIE    Second interrupt Enable
: RTC-CRH_ALRIE   %1 1 lshift RTC-CRH bis! ;  \ RTC-CRH_ALRIE    Alarm interrupt Enable
: RTC-CRH_OWIE   %1 2 lshift RTC-CRH bis! ;  \ RTC-CRH_OWIE    Overflow interrupt Enable

\ RTC-CRL ()
: RTC-CRL_SECF   %1 0 lshift RTC-CRL bis! ;  \ RTC-CRL_SECF    Second Flag
: RTC-CRL_ALRF   %1 1 lshift RTC-CRL bis! ;  \ RTC-CRL_ALRF    Alarm Flag
: RTC-CRL_OWF   %1 2 lshift RTC-CRL bis! ;  \ RTC-CRL_OWF    Overflow Flag
: RTC-CRL_RSF   %1 3 lshift RTC-CRL bis! ;  \ RTC-CRL_RSF    Registers Synchronized  Flag
: RTC-CRL_CNF   %1 4 lshift RTC-CRL bis! ;  \ RTC-CRL_CNF    Configuration Flag
: RTC-CRL_RTOFF   %1 5 lshift RTC-CRL bis! ;  \ RTC-CRL_RTOFF    RTC operation OFF

\ RTC-PRLH (write-only)
: RTC-PRLH_PRLH   ( %XXXX -- ) 0 lshift RTC-PRLH bis! ;  \ RTC-PRLH_PRLH    RTC Prescaler Load Register  High

\ RTC-PRLL (write-only)
: RTC-PRLL_PRLL   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-PRLL bis! ;  \ RTC-PRLL_PRLL    RTC Prescaler Divider Register  Low

\ RTC-DIVH (read-only)
: RTC-DIVH_DIVH   ( %XXXX -- ) 0 lshift RTC-DIVH bis! ;  \ RTC-DIVH_DIVH    RTC prescaler divider register  high

\ RTC-DIVL (read-only)
: RTC-DIVL_DIVL   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-DIVL bis! ;  \ RTC-DIVL_DIVL    RTC prescaler divider register  Low

\ RTC-CNTH (read-write)
: RTC-CNTH_CNTH   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-CNTH bis! ;  \ RTC-CNTH_CNTH    RTC counter register high

\ RTC-CNTL (read-write)
: RTC-CNTL_CNTL   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-CNTL bis! ;  \ RTC-CNTL_CNTL    RTC counter register Low

\ RTC-ALRH (write-only)
: RTC-ALRH_ALRH   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRH bis! ;  \ RTC-ALRH_ALRH    RTC alarm register high

\ RTC-ALRL (write-only)
: RTC-ALRL_ALRL   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRL bis! ;  \ RTC-ALRL_ALRL    RTC alarm register low

\ BKP-DR1 (read-write)
: BKP-DR1_D1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR1 bis! ;  \ BKP-DR1_D1    Backup data

\ BKP-DR2 (read-write)
: BKP-DR2_D2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR2 bis! ;  \ BKP-DR2_D2    Backup data

\ BKP-DR3 (read-write)
: BKP-DR3_D3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR3 bis! ;  \ BKP-DR3_D3    Backup data

\ BKP-DR4 (read-write)
: BKP-DR4_D4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR4 bis! ;  \ BKP-DR4_D4    Backup data

\ BKP-DR5 (read-write)
: BKP-DR5_D5   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR5 bis! ;  \ BKP-DR5_D5    Backup data

\ BKP-DR6 (read-write)
: BKP-DR6_D6   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR6 bis! ;  \ BKP-DR6_D6    Backup data

\ BKP-DR7 (read-write)
: BKP-DR7_D7   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR7 bis! ;  \ BKP-DR7_D7    Backup data

\ BKP-DR8 (read-write)
: BKP-DR8_D8   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR8 bis! ;  \ BKP-DR8_D8    Backup data

\ BKP-DR9 (read-write)
: BKP-DR9_D9   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR9 bis! ;  \ BKP-DR9_D9    Backup data

\ BKP-DR10 (read-write)
: BKP-DR10_D10   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR10 bis! ;  \ BKP-DR10_D10    Backup data

\ BKP-DR11 (read-write)
: BKP-DR11_DR11   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR11 bis! ;  \ BKP-DR11_DR11    Backup data

\ BKP-DR12 (read-write)
: BKP-DR12_DR12   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR12 bis! ;  \ BKP-DR12_DR12    Backup data

\ BKP-DR13 (read-write)
: BKP-DR13_DR13   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR13 bis! ;  \ BKP-DR13_DR13    Backup data

\ BKP-DR14 (read-write)
: BKP-DR14_D14   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR14 bis! ;  \ BKP-DR14_D14    Backup data

\ BKP-DR15 (read-write)
: BKP-DR15_D15   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR15 bis! ;  \ BKP-DR15_D15    Backup data

\ BKP-DR16 (read-write)
: BKP-DR16_D16   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR16 bis! ;  \ BKP-DR16_D16    Backup data

\ BKP-DR17 (read-write)
: BKP-DR17_D17   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR17 bis! ;  \ BKP-DR17_D17    Backup data

\ BKP-DR18 (read-write)
: BKP-DR18_D18   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR18 bis! ;  \ BKP-DR18_D18    Backup data

\ BKP-DR19 (read-write)
: BKP-DR19_D19   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR19 bis! ;  \ BKP-DR19_D19    Backup data

\ BKP-DR20 (read-write)
: BKP-DR20_D20   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR20 bis! ;  \ BKP-DR20_D20    Backup data

\ BKP-DR21 (read-write)
: BKP-DR21_D21   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR21 bis! ;  \ BKP-DR21_D21    Backup data

\ BKP-DR22 (read-write)
: BKP-DR22_D22   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR22 bis! ;  \ BKP-DR22_D22    Backup data

\ BKP-DR23 (read-write)
: BKP-DR23_D23   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR23 bis! ;  \ BKP-DR23_D23    Backup data

\ BKP-DR24 (read-write)
: BKP-DR24_D24   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR24 bis! ;  \ BKP-DR24_D24    Backup data

\ BKP-DR25 (read-write)
: BKP-DR25_D25   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR25 bis! ;  \ BKP-DR25_D25    Backup data

\ BKP-DR26 (read-write)
: BKP-DR26_D26   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR26 bis! ;  \ BKP-DR26_D26    Backup data

\ BKP-DR27 (read-write)
: BKP-DR27_D27   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR27 bis! ;  \ BKP-DR27_D27    Backup data

\ BKP-DR28 (read-write)
: BKP-DR28_D28   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR28 bis! ;  \ BKP-DR28_D28    Backup data

\ BKP-DR29 (read-write)
: BKP-DR29_D29   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR29 bis! ;  \ BKP-DR29_D29    Backup data

\ BKP-DR30 (read-write)
: BKP-DR30_D30   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR30 bis! ;  \ BKP-DR30_D30    Backup data

\ BKP-DR31 (read-write)
: BKP-DR31_D31   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR31 bis! ;  \ BKP-DR31_D31    Backup data

\ BKP-DR32 (read-write)
: BKP-DR32_D32   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR32 bis! ;  \ BKP-DR32_D32    Backup data

\ BKP-DR33 (read-write)
: BKP-DR33_D33   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR33 bis! ;  \ BKP-DR33_D33    Backup data

\ BKP-DR34 (read-write)
: BKP-DR34_D34   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR34 bis! ;  \ BKP-DR34_D34    Backup data

\ BKP-DR35 (read-write)
: BKP-DR35_D35   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR35 bis! ;  \ BKP-DR35_D35    Backup data

\ BKP-DR36 (read-write)
: BKP-DR36_D36   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR36 bis! ;  \ BKP-DR36_D36    Backup data

\ BKP-DR37 (read-write)
: BKP-DR37_D37   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR37 bis! ;  \ BKP-DR37_D37    Backup data

\ BKP-DR38 (read-write)
: BKP-DR38_D38   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR38 bis! ;  \ BKP-DR38_D38    Backup data

\ BKP-DR39 (read-write)
: BKP-DR39_D39   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR39 bis! ;  \ BKP-DR39_D39    Backup data

\ BKP-DR40 (read-write)
: BKP-DR40_D40   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR40 bis! ;  \ BKP-DR40_D40    Backup data

\ BKP-DR41 (read-write)
: BKP-DR41_D41   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR41 bis! ;  \ BKP-DR41_D41    Backup data

\ BKP-DR42 (read-write)
: BKP-DR42_D42   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift BKP-DR42 bis! ;  \ BKP-DR42_D42    Backup data

\ BKP-RTCCR (read-write)
: BKP-RTCCR_CAL   ( %XXXXXXX -- ) 0 lshift BKP-RTCCR bis! ;  \ BKP-RTCCR_CAL    Calibration value
: BKP-RTCCR_CCO   %1 7 lshift BKP-RTCCR bis! ;  \ BKP-RTCCR_CCO    Calibration Clock Output
: BKP-RTCCR_ASOE   %1 8 lshift BKP-RTCCR bis! ;  \ BKP-RTCCR_ASOE    Alarm or second output  enable
: BKP-RTCCR_ASOS   %1 9 lshift BKP-RTCCR bis! ;  \ BKP-RTCCR_ASOS    Alarm or second output  selection

\ BKP-CR (read-write)
: BKP-CR_TPE   %1 0 lshift BKP-CR bis! ;  \ BKP-CR_TPE    Tamper pin enable
: BKP-CR_TPAL   %1 1 lshift BKP-CR bis! ;  \ BKP-CR_TPAL    Tamper pin active level

\ BKP-CSR ()
: BKP-CSR_CTE   %1 0 lshift BKP-CSR bis! ;  \ BKP-CSR_CTE    Clear Tamper event
: BKP-CSR_CTI   %1 1 lshift BKP-CSR bis! ;  \ BKP-CSR_CTI    Clear Tamper Interrupt
: BKP-CSR_TPIE   %1 2 lshift BKP-CSR bis! ;  \ BKP-CSR_TPIE    Tamper Pin interrupt  enable
: BKP-CSR_TEF   %1 8 lshift BKP-CSR bis! ;  \ BKP-CSR_TEF    Tamper Event Flag
: BKP-CSR_TIF   %1 9 lshift BKP-CSR bis! ;  \ BKP-CSR_TIF    Tamper Interrupt Flag

\ IWDG-KR (write-only)
: IWDG-KR_KEY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift IWDG-KR bis! ;  \ IWDG-KR_KEY    Key value

\ IWDG-PR (read-write)
: IWDG-PR_PR   ( %XXX -- ) 0 lshift IWDG-PR bis! ;  \ IWDG-PR_PR    Prescaler divider

\ IWDG-RLR (read-write)
: IWDG-RLR_RL   ( %XXXXXXXXXXX -- ) 0 lshift IWDG-RLR bis! ;  \ IWDG-RLR_RL    Watchdog counter reload  value

\ IWDG-SR (read-only)
: IWDG-SR_PVU   %1 0 lshift IWDG-SR bis! ;  \ IWDG-SR_PVU    Watchdog prescaler value  update
: IWDG-SR_RVU   %1 1 lshift IWDG-SR bis! ;  \ IWDG-SR_RVU    Watchdog counter reload value  update

\ WWDG-CR (read-write)
: WWDG-CR_T   ( %XXXXXXX -- ) 0 lshift WWDG-CR bis! ;  \ WWDG-CR_T    7-bit counter MSB to LSB
: WWDG-CR_WDGA   %1 7 lshift WWDG-CR bis! ;  \ WWDG-CR_WDGA    Activation bit

\ WWDG-CFR (read-write)
: WWDG-CFR_W   ( %XXXXXXX -- ) 0 lshift WWDG-CFR bis! ;  \ WWDG-CFR_W    7-bit window value
: WWDG-CFR_WDGTB   ( %XX -- ) 7 lshift WWDG-CFR bis! ;  \ WWDG-CFR_WDGTB    Timer Base
: WWDG-CFR_EWI   %1 9 lshift WWDG-CFR bis! ;  \ WWDG-CFR_EWI    Early Wakeup Interrupt

\ WWDG-SR (read-write)
: WWDG-SR_EWI   %1 0 lshift WWDG-SR bis! ;  \ WWDG-SR_EWI    Early Wakeup Interrupt

\ TIM1-CR1 (read-write)
: TIM1-CR1_CKD   ( %XX -- ) 8 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_CKD    Clock division
: TIM1-CR1_ARPE   %1 7 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_ARPE    Auto-reload preload enable
: TIM1-CR1_CMS   ( %XX -- ) 5 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_CMS    Center-aligned mode  selection
: TIM1-CR1_DIR   %1 4 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_DIR    Direction
: TIM1-CR1_OPM   %1 3 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_OPM    One-pulse mode
: TIM1-CR1_URS   %1 2 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_URS    Update request source
: TIM1-CR1_UDIS   %1 1 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_UDIS    Update disable
: TIM1-CR1_CEN   %1 0 lshift TIM1-CR1 bis! ;  \ TIM1-CR1_CEN    Counter enable

\ TIM1-CR2 (read-write)
: TIM1-CR2_OIS4   %1 14 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS4    Output Idle state 4
: TIM1-CR2_OIS3N   %1 13 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS3N    Output Idle state 3
: TIM1-CR2_OIS3   %1 12 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS3    Output Idle state 3
: TIM1-CR2_OIS2N   %1 11 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS2N    Output Idle state 2
: TIM1-CR2_OIS2   %1 10 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS2    Output Idle state 2
: TIM1-CR2_OIS1N   %1 9 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS1N    Output Idle state 1
: TIM1-CR2_OIS1   %1 8 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_OIS1    Output Idle state 1
: TIM1-CR2_TI1S   %1 7 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_TI1S    TI1 selection
: TIM1-CR2_MMS   ( %XXX -- ) 4 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_MMS    Master mode selection
: TIM1-CR2_CCDS   %1 3 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_CCDS    Capture/compare DMA  selection
: TIM1-CR2_CCUS   %1 2 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_CCUS    Capture/compare control update  selection
: TIM1-CR2_CCPC   %1 0 lshift TIM1-CR2 bis! ;  \ TIM1-CR2_CCPC    Capture/compare preloaded  control

\ TIM1-SMCR (read-write)
: TIM1-SMCR_ETP   %1 15 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ETP    External trigger polarity
: TIM1-SMCR_ECE   %1 14 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ECE    External clock enable
: TIM1-SMCR_ETPS   ( %XX -- ) 12 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ETPS    External trigger prescaler
: TIM1-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_ETF    External trigger filter
: TIM1-SMCR_MSM   %1 7 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_MSM    Master/Slave mode
: TIM1-SMCR_TS   ( %XXX -- ) 4 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_TS    Trigger selection
: TIM1-SMCR_SMS   ( %XXX -- ) 0 lshift TIM1-SMCR bis! ;  \ TIM1-SMCR_SMS    Slave mode selection

\ TIM1-DIER (read-write)
: TIM1-DIER_TDE   %1 14 lshift TIM1-DIER bis! ;  \ TIM1-DIER_TDE    Trigger DMA request enable
: TIM1-DIER_COMDE   %1 13 lshift TIM1-DIER bis! ;  \ TIM1-DIER_COMDE    COM DMA request enable
: TIM1-DIER_CC4DE   %1 12 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM1-DIER_CC3DE   %1 11 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM1-DIER_CC2DE   %1 10 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM1-DIER_CC1DE   %1 9 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM1-DIER_UDE   %1 8 lshift TIM1-DIER bis! ;  \ TIM1-DIER_UDE    Update DMA request enable
: TIM1-DIER_TIE   %1 6 lshift TIM1-DIER bis! ;  \ TIM1-DIER_TIE    Trigger interrupt enable
: TIM1-DIER_CC4IE   %1 4 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM1-DIER_CC3IE   %1 3 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM1-DIER_CC2IE   %1 2 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM1-DIER_CC1IE   %1 1 lshift TIM1-DIER bis! ;  \ TIM1-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM1-DIER_UIE   %1 0 lshift TIM1-DIER bis! ;  \ TIM1-DIER_UIE    Update interrupt enable
: TIM1-DIER_BIE   %1 7 lshift TIM1-DIER bis! ;  \ TIM1-DIER_BIE    Break interrupt enable
: TIM1-DIER_COMIE   %1 5 lshift TIM1-DIER bis! ;  \ TIM1-DIER_COMIE    COM interrupt enable

\ TIM1-SR (read-write)
: TIM1-SR_CC4OF   %1 12 lshift TIM1-SR bis! ;  \ TIM1-SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM1-SR_CC3OF   %1 11 lshift TIM1-SR bis! ;  \ TIM1-SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM1-SR_CC2OF   %1 10 lshift TIM1-SR bis! ;  \ TIM1-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM1-SR_CC1OF   %1 9 lshift TIM1-SR bis! ;  \ TIM1-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM1-SR_BIF   %1 7 lshift TIM1-SR bis! ;  \ TIM1-SR_BIF    Break interrupt flag
: TIM1-SR_TIF   %1 6 lshift TIM1-SR bis! ;  \ TIM1-SR_TIF    Trigger interrupt flag
: TIM1-SR_COMIF   %1 5 lshift TIM1-SR bis! ;  \ TIM1-SR_COMIF    COM interrupt flag
: TIM1-SR_CC4IF   %1 4 lshift TIM1-SR bis! ;  \ TIM1-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM1-SR_CC3IF   %1 3 lshift TIM1-SR bis! ;  \ TIM1-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM1-SR_CC2IF   %1 2 lshift TIM1-SR bis! ;  \ TIM1-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM1-SR_CC1IF   %1 1 lshift TIM1-SR bis! ;  \ TIM1-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM1-SR_UIF   %1 0 lshift TIM1-SR bis! ;  \ TIM1-SR_UIF    Update interrupt flag

\ TIM1-EGR (write-only)
: TIM1-EGR_BG   %1 7 lshift TIM1-EGR bis! ;  \ TIM1-EGR_BG    Break generation
: TIM1-EGR_TG   %1 6 lshift TIM1-EGR bis! ;  \ TIM1-EGR_TG    Trigger generation
: TIM1-EGR_COMG   %1 5 lshift TIM1-EGR bis! ;  \ TIM1-EGR_COMG    Capture/Compare control update  generation
: TIM1-EGR_CC4G   %1 4 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC4G    Capture/compare 4  generation
: TIM1-EGR_CC3G   %1 3 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC3G    Capture/compare 3  generation
: TIM1-EGR_CC2G   %1 2 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC2G    Capture/compare 2  generation
: TIM1-EGR_CC1G   %1 1 lshift TIM1-EGR bis! ;  \ TIM1-EGR_CC1G    Capture/compare 1  generation
: TIM1-EGR_UG   %1 0 lshift TIM1-EGR bis! ;  \ TIM1-EGR_UG    Update generation

\ TIM1-CCMR1_Output (read-write)
: TIM1-CCMR1_Output_OC2CE   %1 15 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2CE    Output Compare 2 clear  enable
: TIM1-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2M    Output Compare 2 mode
: TIM1-CCMR1_Output_OC2PE   %1 11 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2PE    Output Compare 2 preload  enable
: TIM1-CCMR1_Output_OC2FE   %1 10 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC2FE    Output Compare 2 fast  enable
: TIM1-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM1-CCMR1_Output_OC1CE   %1 7 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1CE    Output Compare 1 clear  enable
: TIM1-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM1-CCMR1_Output_OC1PE   %1 3 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM1-CCMR1_Output_OC1FE   %1 2 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM1-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM1-CCMR1_Output bis! ;  \ TIM1-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM1-CCMR1_Input (read-write)
: TIM1-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_IC2F    Input capture 2 filter
: TIM1-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM1-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM1-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_IC1F    Input capture 1 filter
: TIM1-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM1-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM1-CCMR1_Input bis! ;  \ TIM1-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM1-CCMR2_Output (read-write)
: TIM1-CCMR2_Output_OC4CE   %1 15 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM1-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4M    Output compare 4 mode
: TIM1-CCMR2_Output_OC4PE   %1 11 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM1-CCMR2_Output_OC4FE   %1 10 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM1-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM1-CCMR2_Output_OC3CE   %1 7 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM1-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3M    Output compare 3 mode
: TIM1-CCMR2_Output_OC3PE   %1 3 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM1-CCMR2_Output_OC3FE   %1 2 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM1-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM1-CCMR2_Output bis! ;  \ TIM1-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM1-CCMR2_Input (read-write)
: TIM1-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC4F    Input capture 4 filter
: TIM1-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM1-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM1-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC3F    Input capture 3 filter
: TIM1-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM1-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM1-CCMR2_Input bis! ;  \ TIM1-CCMR2_Input_CC3S    Capture/compare 3  selection

\ TIM1-CCER (read-write)
: TIM1-CCER_CC4P   %1 13 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM1-CCER_CC4E   %1 12 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC4E    Capture/Compare 4 output  enable
: TIM1-CCER_CC3NP   %1 11 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM1-CCER_CC3NE   %1 10 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3NE    Capture/Compare 3 complementary output  enable
: TIM1-CCER_CC3P   %1 9 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM1-CCER_CC3E   %1 8 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC3E    Capture/Compare 3 output  enable
: TIM1-CCER_CC2NP   %1 7 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM1-CCER_CC2NE   %1 6 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2NE    Capture/Compare 2 complementary output  enable
: TIM1-CCER_CC2P   %1 5 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM1-CCER_CC2E   %1 4 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC2E    Capture/Compare 2 output  enable
: TIM1-CCER_CC1NP   %1 3 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM1-CCER_CC1NE   %1 2 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1NE    Capture/Compare 1 complementary output  enable
: TIM1-CCER_CC1P   %1 1 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM1-CCER_CC1E   %1 0 lshift TIM1-CCER bis! ;  \ TIM1-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM1-CNT (read-write)
: TIM1-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CNT bis! ;  \ TIM1-CNT_CNT    counter value

\ TIM1-PSC (read-write)
: TIM1-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-PSC bis! ;  \ TIM1-PSC_PSC    Prescaler value

\ TIM1-ARR (read-write)
: TIM1-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-ARR bis! ;  \ TIM1-ARR_ARR    Auto-reload value

\ TIM1-CCR1 (read-write)
: TIM1-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR1 bis! ;  \ TIM1-CCR1_CCR1    Capture/Compare 1 value

\ TIM1-CCR2 (read-write)
: TIM1-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR2 bis! ;  \ TIM1-CCR2_CCR2    Capture/Compare 2 value

\ TIM1-CCR3 (read-write)
: TIM1-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR3 bis! ;  \ TIM1-CCR3_CCR3    Capture/Compare value

\ TIM1-CCR4 (read-write)
: TIM1-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-CCR4 bis! ;  \ TIM1-CCR4_CCR4    Capture/Compare value

\ TIM1-DCR (read-write)
: TIM1-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM1-DCR bis! ;  \ TIM1-DCR_DBL    DMA burst length
: TIM1-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM1-DCR bis! ;  \ TIM1-DCR_DBA    DMA base address

\ TIM1-DMAR (read-write)
: TIM1-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1-DMAR bis! ;  \ TIM1-DMAR_DMAB    DMA register for burst  accesses

\ TIM1-RCR (read-write)
: TIM1-RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM1-RCR bis! ;  \ TIM1-RCR_REP    Repetition counter value

\ TIM1-BDTR (read-write)
: TIM1-BDTR_MOE   %1 15 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_MOE    Main output enable
: TIM1-BDTR_AOE   %1 14 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_AOE    Automatic output enable
: TIM1-BDTR_BKP   %1 13 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_BKP    Break polarity
: TIM1-BDTR_BKE   %1 12 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_BKE    Break enable
: TIM1-BDTR_OSSR   %1 11 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_OSSR    Off-state selection for Run  mode
: TIM1-BDTR_OSSI   %1 10 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_OSSI    Off-state selection for Idle  mode
: TIM1-BDTR_LOCK   ( %XX -- ) 8 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_LOCK    Lock configuration
: TIM1-BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM1-BDTR bis! ;  \ TIM1-BDTR_DTG    Dead-time generator setup

\ TIM8-CR1 (read-write)
: TIM8-CR1_CKD   ( %XX -- ) 8 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_CKD    Clock division
: TIM8-CR1_ARPE   %1 7 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_ARPE    Auto-reload preload enable
: TIM8-CR1_CMS   ( %XX -- ) 5 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_CMS    Center-aligned mode  selection
: TIM8-CR1_DIR   %1 4 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_DIR    Direction
: TIM8-CR1_OPM   %1 3 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_OPM    One-pulse mode
: TIM8-CR1_URS   %1 2 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_URS    Update request source
: TIM8-CR1_UDIS   %1 1 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_UDIS    Update disable
: TIM8-CR1_CEN   %1 0 lshift TIM8-CR1 bis! ;  \ TIM8-CR1_CEN    Counter enable

\ TIM8-CR2 (read-write)
: TIM8-CR2_OIS4   %1 14 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS4    Output Idle state 4
: TIM8-CR2_OIS3N   %1 13 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS3N    Output Idle state 3
: TIM8-CR2_OIS3   %1 12 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS3    Output Idle state 3
: TIM8-CR2_OIS2N   %1 11 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS2N    Output Idle state 2
: TIM8-CR2_OIS2   %1 10 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS2    Output Idle state 2
: TIM8-CR2_OIS1N   %1 9 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS1N    Output Idle state 1
: TIM8-CR2_OIS1   %1 8 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_OIS1    Output Idle state 1
: TIM8-CR2_TI1S   %1 7 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_TI1S    TI1 selection
: TIM8-CR2_MMS   ( %XXX -- ) 4 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_MMS    Master mode selection
: TIM8-CR2_CCDS   %1 3 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_CCDS    Capture/compare DMA  selection
: TIM8-CR2_CCUS   %1 2 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_CCUS    Capture/compare control update  selection
: TIM8-CR2_CCPC   %1 0 lshift TIM8-CR2 bis! ;  \ TIM8-CR2_CCPC    Capture/compare preloaded  control

\ TIM8-SMCR (read-write)
: TIM8-SMCR_ETP   %1 15 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ETP    External trigger polarity
: TIM8-SMCR_ECE   %1 14 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ECE    External clock enable
: TIM8-SMCR_ETPS   ( %XX -- ) 12 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ETPS    External trigger prescaler
: TIM8-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_ETF    External trigger filter
: TIM8-SMCR_MSM   %1 7 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_MSM    Master/Slave mode
: TIM8-SMCR_TS   ( %XXX -- ) 4 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_TS    Trigger selection
: TIM8-SMCR_SMS   ( %XXX -- ) 0 lshift TIM8-SMCR bis! ;  \ TIM8-SMCR_SMS    Slave mode selection

\ TIM8-DIER (read-write)
: TIM8-DIER_TDE   %1 14 lshift TIM8-DIER bis! ;  \ TIM8-DIER_TDE    Trigger DMA request enable
: TIM8-DIER_COMDE   %1 13 lshift TIM8-DIER bis! ;  \ TIM8-DIER_COMDE    COM DMA request enable
: TIM8-DIER_CC4DE   %1 12 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM8-DIER_CC3DE   %1 11 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM8-DIER_CC2DE   %1 10 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM8-DIER_CC1DE   %1 9 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM8-DIER_UDE   %1 8 lshift TIM8-DIER bis! ;  \ TIM8-DIER_UDE    Update DMA request enable
: TIM8-DIER_TIE   %1 6 lshift TIM8-DIER bis! ;  \ TIM8-DIER_TIE    Trigger interrupt enable
: TIM8-DIER_CC4IE   %1 4 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM8-DIER_CC3IE   %1 3 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM8-DIER_CC2IE   %1 2 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM8-DIER_CC1IE   %1 1 lshift TIM8-DIER bis! ;  \ TIM8-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM8-DIER_UIE   %1 0 lshift TIM8-DIER bis! ;  \ TIM8-DIER_UIE    Update interrupt enable
: TIM8-DIER_BIE   %1 7 lshift TIM8-DIER bis! ;  \ TIM8-DIER_BIE    Break interrupt enable
: TIM8-DIER_COMIE   %1 5 lshift TIM8-DIER bis! ;  \ TIM8-DIER_COMIE    COM interrupt enable

\ TIM8-SR (read-write)
: TIM8-SR_CC4OF   %1 12 lshift TIM8-SR bis! ;  \ TIM8-SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM8-SR_CC3OF   %1 11 lshift TIM8-SR bis! ;  \ TIM8-SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM8-SR_CC2OF   %1 10 lshift TIM8-SR bis! ;  \ TIM8-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM8-SR_CC1OF   %1 9 lshift TIM8-SR bis! ;  \ TIM8-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM8-SR_BIF   %1 7 lshift TIM8-SR bis! ;  \ TIM8-SR_BIF    Break interrupt flag
: TIM8-SR_TIF   %1 6 lshift TIM8-SR bis! ;  \ TIM8-SR_TIF    Trigger interrupt flag
: TIM8-SR_COMIF   %1 5 lshift TIM8-SR bis! ;  \ TIM8-SR_COMIF    COM interrupt flag
: TIM8-SR_CC4IF   %1 4 lshift TIM8-SR bis! ;  \ TIM8-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM8-SR_CC3IF   %1 3 lshift TIM8-SR bis! ;  \ TIM8-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM8-SR_CC2IF   %1 2 lshift TIM8-SR bis! ;  \ TIM8-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM8-SR_CC1IF   %1 1 lshift TIM8-SR bis! ;  \ TIM8-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM8-SR_UIF   %1 0 lshift TIM8-SR bis! ;  \ TIM8-SR_UIF    Update interrupt flag

\ TIM8-EGR (write-only)
: TIM8-EGR_BG   %1 7 lshift TIM8-EGR bis! ;  \ TIM8-EGR_BG    Break generation
: TIM8-EGR_TG   %1 6 lshift TIM8-EGR bis! ;  \ TIM8-EGR_TG    Trigger generation
: TIM8-EGR_COMG   %1 5 lshift TIM8-EGR bis! ;  \ TIM8-EGR_COMG    Capture/Compare control update  generation
: TIM8-EGR_CC4G   %1 4 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC4G    Capture/compare 4  generation
: TIM8-EGR_CC3G   %1 3 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC3G    Capture/compare 3  generation
: TIM8-EGR_CC2G   %1 2 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC2G    Capture/compare 2  generation
: TIM8-EGR_CC1G   %1 1 lshift TIM8-EGR bis! ;  \ TIM8-EGR_CC1G    Capture/compare 1  generation
: TIM8-EGR_UG   %1 0 lshift TIM8-EGR bis! ;  \ TIM8-EGR_UG    Update generation

\ TIM8-CCMR1_Output (read-write)
: TIM8-CCMR1_Output_OC2CE   %1 15 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2CE    Output Compare 2 clear  enable
: TIM8-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2M    Output Compare 2 mode
: TIM8-CCMR1_Output_OC2PE   %1 11 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2PE    Output Compare 2 preload  enable
: TIM8-CCMR1_Output_OC2FE   %1 10 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC2FE    Output Compare 2 fast  enable
: TIM8-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM8-CCMR1_Output_OC1CE   %1 7 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1CE    Output Compare 1 clear  enable
: TIM8-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM8-CCMR1_Output_OC1PE   %1 3 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM8-CCMR1_Output_OC1FE   %1 2 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM8-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM8-CCMR1_Output bis! ;  \ TIM8-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM8-CCMR1_Input (read-write)
: TIM8-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_IC2F    Input capture 2 filter
: TIM8-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM8-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM8-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_IC1F    Input capture 1 filter
: TIM8-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM8-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM8-CCMR1_Input bis! ;  \ TIM8-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM8-CCMR2_Output (read-write)
: TIM8-CCMR2_Output_OC4CE   %1 15 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM8-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4M    Output compare 4 mode
: TIM8-CCMR2_Output_OC4PE   %1 11 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM8-CCMR2_Output_OC4FE   %1 10 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM8-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM8-CCMR2_Output_OC3CE   %1 7 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM8-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3M    Output compare 3 mode
: TIM8-CCMR2_Output_OC3PE   %1 3 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM8-CCMR2_Output_OC3FE   %1 2 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM8-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM8-CCMR2_Output bis! ;  \ TIM8-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM8-CCMR2_Input (read-write)
: TIM8-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC4F    Input capture 4 filter
: TIM8-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM8-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM8-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC3F    Input capture 3 filter
: TIM8-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM8-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM8-CCMR2_Input bis! ;  \ TIM8-CCMR2_Input_CC3S    Capture/compare 3  selection

\ TIM8-CCER (read-write)
: TIM8-CCER_CC4P   %1 13 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM8-CCER_CC4E   %1 12 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC4E    Capture/Compare 4 output  enable
: TIM8-CCER_CC3NP   %1 11 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM8-CCER_CC3NE   %1 10 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3NE    Capture/Compare 3 complementary output  enable
: TIM8-CCER_CC3P   %1 9 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM8-CCER_CC3E   %1 8 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC3E    Capture/Compare 3 output  enable
: TIM8-CCER_CC2NP   %1 7 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM8-CCER_CC2NE   %1 6 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2NE    Capture/Compare 2 complementary output  enable
: TIM8-CCER_CC2P   %1 5 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM8-CCER_CC2E   %1 4 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC2E    Capture/Compare 2 output  enable
: TIM8-CCER_CC1NP   %1 3 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM8-CCER_CC1NE   %1 2 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1NE    Capture/Compare 1 complementary output  enable
: TIM8-CCER_CC1P   %1 1 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM8-CCER_CC1E   %1 0 lshift TIM8-CCER bis! ;  \ TIM8-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM8-CNT (read-write)
: TIM8-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CNT bis! ;  \ TIM8-CNT_CNT    counter value

\ TIM8-PSC (read-write)
: TIM8-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-PSC bis! ;  \ TIM8-PSC_PSC    Prescaler value

\ TIM8-ARR (read-write)
: TIM8-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-ARR bis! ;  \ TIM8-ARR_ARR    Auto-reload value

\ TIM8-CCR1 (read-write)
: TIM8-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR1 bis! ;  \ TIM8-CCR1_CCR1    Capture/Compare 1 value

\ TIM8-CCR2 (read-write)
: TIM8-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR2 bis! ;  \ TIM8-CCR2_CCR2    Capture/Compare 2 value

\ TIM8-CCR3 (read-write)
: TIM8-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR3 bis! ;  \ TIM8-CCR3_CCR3    Capture/Compare value

\ TIM8-CCR4 (read-write)
: TIM8-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-CCR4 bis! ;  \ TIM8-CCR4_CCR4    Capture/Compare value

\ TIM8-DCR (read-write)
: TIM8-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM8-DCR bis! ;  \ TIM8-DCR_DBL    DMA burst length
: TIM8-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM8-DCR bis! ;  \ TIM8-DCR_DBA    DMA base address

\ TIM8-DMAR (read-write)
: TIM8-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM8-DMAR bis! ;  \ TIM8-DMAR_DMAB    DMA register for burst  accesses

\ TIM8-RCR (read-write)
: TIM8-RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM8-RCR bis! ;  \ TIM8-RCR_REP    Repetition counter value

\ TIM8-BDTR (read-write)
: TIM8-BDTR_MOE   %1 15 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_MOE    Main output enable
: TIM8-BDTR_AOE   %1 14 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_AOE    Automatic output enable
: TIM8-BDTR_BKP   %1 13 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_BKP    Break polarity
: TIM8-BDTR_BKE   %1 12 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_BKE    Break enable
: TIM8-BDTR_OSSR   %1 11 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_OSSR    Off-state selection for Run  mode
: TIM8-BDTR_OSSI   %1 10 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_OSSI    Off-state selection for Idle  mode
: TIM8-BDTR_LOCK   ( %XX -- ) 8 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_LOCK    Lock configuration
: TIM8-BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM8-BDTR bis! ;  \ TIM8-BDTR_DTG    Dead-time generator setup

\ TIM2-CR1 (read-write)
: TIM2-CR1_CKD   ( %XX -- ) 8 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CKD    Clock division
: TIM2-CR1_ARPE   %1 7 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_ARPE    Auto-reload preload enable
: TIM2-CR1_CMS   ( %XX -- ) 5 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CMS    Center-aligned mode  selection
: TIM2-CR1_DIR   %1 4 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_DIR    Direction
: TIM2-CR1_OPM   %1 3 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_OPM    One-pulse mode
: TIM2-CR1_URS   %1 2 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_URS    Update request source
: TIM2-CR1_UDIS   %1 1 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_UDIS    Update disable
: TIM2-CR1_CEN   %1 0 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CEN    Counter enable

\ TIM2-CR2 (read-write)
: TIM2-CR2_TI1S   %1 7 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_TI1S    TI1 selection
: TIM2-CR2_MMS   ( %XXX -- ) 4 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_MMS    Master mode selection
: TIM2-CR2_CCDS   %1 3 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_CCDS    Capture/compare DMA  selection

\ TIM2-SMCR (read-write)
: TIM2-SMCR_ETP   %1 15 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETP    External trigger polarity
: TIM2-SMCR_ECE   %1 14 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ECE    External clock enable
: TIM2-SMCR_ETPS   ( %XX -- ) 12 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETPS    External trigger prescaler
: TIM2-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETF    External trigger filter
: TIM2-SMCR_MSM   %1 7 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_MSM    Master/Slave mode
: TIM2-SMCR_TS   ( %XXX -- ) 4 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_TS    Trigger selection
: TIM2-SMCR_SMS   ( %XXX -- ) 0 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_SMS    Slave mode selection

\ TIM2-DIER (read-write)
: TIM2-DIER_TDE   %1 14 lshift TIM2-DIER bis! ;  \ TIM2-DIER_TDE    Trigger DMA request enable
: TIM2-DIER_CC4DE   %1 12 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM2-DIER_CC3DE   %1 11 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM2-DIER_CC2DE   %1 10 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM2-DIER_CC1DE   %1 9 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM2-DIER_UDE   %1 8 lshift TIM2-DIER bis! ;  \ TIM2-DIER_UDE    Update DMA request enable
: TIM2-DIER_TIE   %1 6 lshift TIM2-DIER bis! ;  \ TIM2-DIER_TIE    Trigger interrupt enable
: TIM2-DIER_CC4IE   %1 4 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM2-DIER_CC3IE   %1 3 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM2-DIER_CC2IE   %1 2 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM2-DIER_CC1IE   %1 1 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM2-DIER_UIE   %1 0 lshift TIM2-DIER bis! ;  \ TIM2-DIER_UIE    Update interrupt enable

\ TIM2-SR (read-write)
: TIM2-SR_CC4OF   %1 12 lshift TIM2-SR bis! ;  \ TIM2-SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM2-SR_CC3OF   %1 11 lshift TIM2-SR bis! ;  \ TIM2-SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM2-SR_CC2OF   %1 10 lshift TIM2-SR bis! ;  \ TIM2-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM2-SR_CC1OF   %1 9 lshift TIM2-SR bis! ;  \ TIM2-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM2-SR_TIF   %1 6 lshift TIM2-SR bis! ;  \ TIM2-SR_TIF    Trigger interrupt flag
: TIM2-SR_CC4IF   %1 4 lshift TIM2-SR bis! ;  \ TIM2-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM2-SR_CC3IF   %1 3 lshift TIM2-SR bis! ;  \ TIM2-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM2-SR_CC2IF   %1 2 lshift TIM2-SR bis! ;  \ TIM2-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM2-SR_CC1IF   %1 1 lshift TIM2-SR bis! ;  \ TIM2-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM2-SR_UIF   %1 0 lshift TIM2-SR bis! ;  \ TIM2-SR_UIF    Update interrupt flag

\ TIM2-EGR (write-only)
: TIM2-EGR_TG   %1 6 lshift TIM2-EGR bis! ;  \ TIM2-EGR_TG    Trigger generation
: TIM2-EGR_CC4G   %1 4 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC4G    Capture/compare 4  generation
: TIM2-EGR_CC3G   %1 3 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC3G    Capture/compare 3  generation
: TIM2-EGR_CC2G   %1 2 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC2G    Capture/compare 2  generation
: TIM2-EGR_CC1G   %1 1 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC1G    Capture/compare 1  generation
: TIM2-EGR_UG   %1 0 lshift TIM2-EGR bis! ;  \ TIM2-EGR_UG    Update generation

\ TIM2-CCMR1_Output (read-write)
: TIM2-CCMR1_Output_OC2CE   %1 15 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM2-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2M    Output compare 2 mode
: TIM2-CCMR1_Output_OC2PE   %1 11 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM2-CCMR1_Output_OC2FE   %1 10 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM2-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM2-CCMR1_Output_OC1CE   %1 7 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM2-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1M    Output compare 1 mode
: TIM2-CCMR1_Output_OC1PE   %1 3 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM2-CCMR1_Output_OC1FE   %1 2 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM2-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM2-CCMR1_Input (read-write)
: TIM2-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC2F    Input capture 2 filter
: TIM2-CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM2-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_CC2S    Capture/compare 2  selection
: TIM2-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC1F    Input capture 1 filter
: TIM2-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM2-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM2-CCMR2_Output (read-write)
: TIM2-CCMR2_Output_O24CE   %1 15 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_O24CE    Output compare 4 clear  enable
: TIM2-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4M    Output compare 4 mode
: TIM2-CCMR2_Output_OC4PE   %1 11 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM2-CCMR2_Output_OC4FE   %1 10 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM2-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM2-CCMR2_Output_OC3CE   %1 7 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM2-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3M    Output compare 3 mode
: TIM2-CCMR2_Output_OC3PE   %1 3 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM2-CCMR2_Output_OC3FE   %1 2 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM2-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM2-CCMR2_Input (read-write)
: TIM2-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC4F    Input capture 4 filter
: TIM2-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM2-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM2-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC3F    Input capture 3 filter
: TIM2-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM2-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_CC3S    Capture/Compare 3  selection

\ TIM2-CCER (read-write)
: TIM2-CCER_CC4P   %1 13 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM2-CCER_CC4E   %1 12 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4E    Capture/Compare 4 output  enable
: TIM2-CCER_CC3P   %1 9 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM2-CCER_CC3E   %1 8 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3E    Capture/Compare 3 output  enable
: TIM2-CCER_CC2P   %1 5 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM2-CCER_CC2E   %1 4 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2E    Capture/Compare 2 output  enable
: TIM2-CCER_CC1P   %1 1 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM2-CCER_CC1E   %1 0 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM2-CNT (read-write)
: TIM2-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CNT bis! ;  \ TIM2-CNT_CNT    counter value

\ TIM2-PSC (read-write)
: TIM2-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-PSC bis! ;  \ TIM2-PSC_PSC    Prescaler value

\ TIM2-ARR (read-write)
: TIM2-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-ARR bis! ;  \ TIM2-ARR_ARR    Auto-reload value

\ TIM2-CCR1 (read-write)
: TIM2-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR1 bis! ;  \ TIM2-CCR1_CCR1    Capture/Compare 1 value

\ TIM2-CCR2 (read-write)
: TIM2-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR2 bis! ;  \ TIM2-CCR2_CCR2    Capture/Compare 2 value

\ TIM2-CCR3 (read-write)
: TIM2-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR3 bis! ;  \ TIM2-CCR3_CCR3    Capture/Compare value

\ TIM2-CCR4 (read-write)
: TIM2-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR4 bis! ;  \ TIM2-CCR4_CCR4    Capture/Compare value

\ TIM2-DCR (read-write)
: TIM2-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM2-DCR bis! ;  \ TIM2-DCR_DBL    DMA burst length
: TIM2-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM2-DCR bis! ;  \ TIM2-DCR_DBA    DMA base address

\ TIM2-DMAR (read-write)
: TIM2-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-DMAR bis! ;  \ TIM2-DMAR_DMAB    DMA register for burst  accesses

\ TIM3-CR1 (read-write)
: TIM3-CR1_CKD   ( %XX -- ) 8 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CKD    Clock division
: TIM3-CR1_ARPE   %1 7 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_ARPE    Auto-reload preload enable
: TIM3-CR1_CMS   ( %XX -- ) 5 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CMS    Center-aligned mode  selection
: TIM3-CR1_DIR   %1 4 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_DIR    Direction
: TIM3-CR1_OPM   %1 3 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_OPM    One-pulse mode
: TIM3-CR1_URS   %1 2 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_URS    Update request source
: TIM3-CR1_UDIS   %1 1 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_UDIS    Update disable
: TIM3-CR1_CEN   %1 0 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CEN    Counter enable

\ TIM3-CR2 (read-write)
: TIM3-CR2_TI1S   %1 7 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_TI1S    TI1 selection
: TIM3-CR2_MMS   ( %XXX -- ) 4 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_MMS    Master mode selection
: TIM3-CR2_CCDS   %1 3 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_CCDS    Capture/compare DMA  selection

\ TIM3-SMCR (read-write)
: TIM3-SMCR_ETP   %1 15 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETP    External trigger polarity
: TIM3-SMCR_ECE   %1 14 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ECE    External clock enable
: TIM3-SMCR_ETPS   ( %XX -- ) 12 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETPS    External trigger prescaler
: TIM3-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETF    External trigger filter
: TIM3-SMCR_MSM   %1 7 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_MSM    Master/Slave mode
: TIM3-SMCR_TS   ( %XXX -- ) 4 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_TS    Trigger selection
: TIM3-SMCR_SMS   ( %XXX -- ) 0 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_SMS    Slave mode selection

\ TIM3-DIER (read-write)
: TIM3-DIER_TDE   %1 14 lshift TIM3-DIER bis! ;  \ TIM3-DIER_TDE    Trigger DMA request enable
: TIM3-DIER_CC4DE   %1 12 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM3-DIER_CC3DE   %1 11 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM3-DIER_CC2DE   %1 10 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM3-DIER_CC1DE   %1 9 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM3-DIER_UDE   %1 8 lshift TIM3-DIER bis! ;  \ TIM3-DIER_UDE    Update DMA request enable
: TIM3-DIER_TIE   %1 6 lshift TIM3-DIER bis! ;  \ TIM3-DIER_TIE    Trigger interrupt enable
: TIM3-DIER_CC4IE   %1 4 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM3-DIER_CC3IE   %1 3 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM3-DIER_CC2IE   %1 2 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM3-DIER_CC1IE   %1 1 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM3-DIER_UIE   %1 0 lshift TIM3-DIER bis! ;  \ TIM3-DIER_UIE    Update interrupt enable

\ TIM3-SR (read-write)
: TIM3-SR_CC4OF   %1 12 lshift TIM3-SR bis! ;  \ TIM3-SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM3-SR_CC3OF   %1 11 lshift TIM3-SR bis! ;  \ TIM3-SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM3-SR_CC2OF   %1 10 lshift TIM3-SR bis! ;  \ TIM3-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM3-SR_CC1OF   %1 9 lshift TIM3-SR bis! ;  \ TIM3-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM3-SR_TIF   %1 6 lshift TIM3-SR bis! ;  \ TIM3-SR_TIF    Trigger interrupt flag
: TIM3-SR_CC4IF   %1 4 lshift TIM3-SR bis! ;  \ TIM3-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM3-SR_CC3IF   %1 3 lshift TIM3-SR bis! ;  \ TIM3-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM3-SR_CC2IF   %1 2 lshift TIM3-SR bis! ;  \ TIM3-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM3-SR_CC1IF   %1 1 lshift TIM3-SR bis! ;  \ TIM3-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM3-SR_UIF   %1 0 lshift TIM3-SR bis! ;  \ TIM3-SR_UIF    Update interrupt flag

\ TIM3-EGR (write-only)
: TIM3-EGR_TG   %1 6 lshift TIM3-EGR bis! ;  \ TIM3-EGR_TG    Trigger generation
: TIM3-EGR_CC4G   %1 4 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC4G    Capture/compare 4  generation
: TIM3-EGR_CC3G   %1 3 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC3G    Capture/compare 3  generation
: TIM3-EGR_CC2G   %1 2 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC2G    Capture/compare 2  generation
: TIM3-EGR_CC1G   %1 1 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC1G    Capture/compare 1  generation
: TIM3-EGR_UG   %1 0 lshift TIM3-EGR bis! ;  \ TIM3-EGR_UG    Update generation

\ TIM3-CCMR1_Output (read-write)
: TIM3-CCMR1_Output_OC2CE   %1 15 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM3-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2M    Output compare 2 mode
: TIM3-CCMR1_Output_OC2PE   %1 11 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM3-CCMR1_Output_OC2FE   %1 10 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM3-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM3-CCMR1_Output_OC1CE   %1 7 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM3-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1M    Output compare 1 mode
: TIM3-CCMR1_Output_OC1PE   %1 3 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM3-CCMR1_Output_OC1FE   %1 2 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM3-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM3-CCMR1_Input (read-write)
: TIM3-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC2F    Input capture 2 filter
: TIM3-CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM3-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_CC2S    Capture/compare 2  selection
: TIM3-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC1F    Input capture 1 filter
: TIM3-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM3-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM3-CCMR2_Output (read-write)
: TIM3-CCMR2_Output_O24CE   %1 15 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_O24CE    Output compare 4 clear  enable
: TIM3-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4M    Output compare 4 mode
: TIM3-CCMR2_Output_OC4PE   %1 11 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM3-CCMR2_Output_OC4FE   %1 10 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM3-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM3-CCMR2_Output_OC3CE   %1 7 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM3-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3M    Output compare 3 mode
: TIM3-CCMR2_Output_OC3PE   %1 3 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM3-CCMR2_Output_OC3FE   %1 2 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM3-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM3-CCMR2_Input (read-write)
: TIM3-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC4F    Input capture 4 filter
: TIM3-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM3-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM3-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC3F    Input capture 3 filter
: TIM3-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM3-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_CC3S    Capture/Compare 3  selection

\ TIM3-CCER (read-write)
: TIM3-CCER_CC4P   %1 13 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM3-CCER_CC4E   %1 12 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4E    Capture/Compare 4 output  enable
: TIM3-CCER_CC3P   %1 9 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM3-CCER_CC3E   %1 8 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3E    Capture/Compare 3 output  enable
: TIM3-CCER_CC2P   %1 5 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM3-CCER_CC2E   %1 4 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2E    Capture/Compare 2 output  enable
: TIM3-CCER_CC1P   %1 1 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM3-CCER_CC1E   %1 0 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM3-CNT (read-write)
: TIM3-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CNT bis! ;  \ TIM3-CNT_CNT    counter value

\ TIM3-PSC (read-write)
: TIM3-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-PSC bis! ;  \ TIM3-PSC_PSC    Prescaler value

\ TIM3-ARR (read-write)
: TIM3-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-ARR bis! ;  \ TIM3-ARR_ARR    Auto-reload value

\ TIM3-CCR1 (read-write)
: TIM3-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR1 bis! ;  \ TIM3-CCR1_CCR1    Capture/Compare 1 value

\ TIM3-CCR2 (read-write)
: TIM3-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR2 bis! ;  \ TIM3-CCR2_CCR2    Capture/Compare 2 value

\ TIM3-CCR3 (read-write)
: TIM3-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR3 bis! ;  \ TIM3-CCR3_CCR3    Capture/Compare value

\ TIM3-CCR4 (read-write)
: TIM3-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR4 bis! ;  \ TIM3-CCR4_CCR4    Capture/Compare value

\ TIM3-DCR (read-write)
: TIM3-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM3-DCR bis! ;  \ TIM3-DCR_DBL    DMA burst length
: TIM3-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM3-DCR bis! ;  \ TIM3-DCR_DBA    DMA base address

\ TIM3-DMAR (read-write)
: TIM3-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-DMAR bis! ;  \ TIM3-DMAR_DMAB    DMA register for burst  accesses

\ TIM4-CR1 (read-write)
: TIM4-CR1_CKD   ( %XX -- ) 8 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CKD    Clock division
: TIM4-CR1_ARPE   %1 7 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_ARPE    Auto-reload preload enable
: TIM4-CR1_CMS   ( %XX -- ) 5 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CMS    Center-aligned mode  selection
: TIM4-CR1_DIR   %1 4 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_DIR    Direction
: TIM4-CR1_OPM   %1 3 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_OPM    One-pulse mode
: TIM4-CR1_URS   %1 2 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_URS    Update request source
: TIM4-CR1_UDIS   %1 1 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_UDIS    Update disable
: TIM4-CR1_CEN   %1 0 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CEN    Counter enable

\ TIM4-CR2 (read-write)
: TIM4-CR2_TI1S   %1 7 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_TI1S    TI1 selection
: TIM4-CR2_MMS   ( %XXX -- ) 4 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_MMS    Master mode selection
: TIM4-CR2_CCDS   %1 3 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_CCDS    Capture/compare DMA  selection

\ TIM4-SMCR (read-write)
: TIM4-SMCR_ETP   %1 15 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETP    External trigger polarity
: TIM4-SMCR_ECE   %1 14 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ECE    External clock enable
: TIM4-SMCR_ETPS   ( %XX -- ) 12 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETPS    External trigger prescaler
: TIM4-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETF    External trigger filter
: TIM4-SMCR_MSM   %1 7 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_MSM    Master/Slave mode
: TIM4-SMCR_TS   ( %XXX -- ) 4 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_TS    Trigger selection
: TIM4-SMCR_SMS   ( %XXX -- ) 0 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_SMS    Slave mode selection

\ TIM4-DIER (read-write)
: TIM4-DIER_TDE   %1 14 lshift TIM4-DIER bis! ;  \ TIM4-DIER_TDE    Trigger DMA request enable
: TIM4-DIER_CC4DE   %1 12 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM4-DIER_CC3DE   %1 11 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM4-DIER_CC2DE   %1 10 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM4-DIER_CC1DE   %1 9 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM4-DIER_UDE   %1 8 lshift TIM4-DIER bis! ;  \ TIM4-DIER_UDE    Update DMA request enable
: TIM4-DIER_TIE   %1 6 lshift TIM4-DIER bis! ;  \ TIM4-DIER_TIE    Trigger interrupt enable
: TIM4-DIER_CC4IE   %1 4 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM4-DIER_CC3IE   %1 3 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM4-DIER_CC2IE   %1 2 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM4-DIER_CC1IE   %1 1 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM4-DIER_UIE   %1 0 lshift TIM4-DIER bis! ;  \ TIM4-DIER_UIE    Update interrupt enable

\ TIM4-SR (read-write)
: TIM4-SR_CC4OF   %1 12 lshift TIM4-SR bis! ;  \ TIM4-SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM4-SR_CC3OF   %1 11 lshift TIM4-SR bis! ;  \ TIM4-SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM4-SR_CC2OF   %1 10 lshift TIM4-SR bis! ;  \ TIM4-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM4-SR_CC1OF   %1 9 lshift TIM4-SR bis! ;  \ TIM4-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM4-SR_TIF   %1 6 lshift TIM4-SR bis! ;  \ TIM4-SR_TIF    Trigger interrupt flag
: TIM4-SR_CC4IF   %1 4 lshift TIM4-SR bis! ;  \ TIM4-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM4-SR_CC3IF   %1 3 lshift TIM4-SR bis! ;  \ TIM4-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM4-SR_CC2IF   %1 2 lshift TIM4-SR bis! ;  \ TIM4-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM4-SR_CC1IF   %1 1 lshift TIM4-SR bis! ;  \ TIM4-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM4-SR_UIF   %1 0 lshift TIM4-SR bis! ;  \ TIM4-SR_UIF    Update interrupt flag

\ TIM4-EGR (write-only)
: TIM4-EGR_TG   %1 6 lshift TIM4-EGR bis! ;  \ TIM4-EGR_TG    Trigger generation
: TIM4-EGR_CC4G   %1 4 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC4G    Capture/compare 4  generation
: TIM4-EGR_CC3G   %1 3 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC3G    Capture/compare 3  generation
: TIM4-EGR_CC2G   %1 2 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC2G    Capture/compare 2  generation
: TIM4-EGR_CC1G   %1 1 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC1G    Capture/compare 1  generation
: TIM4-EGR_UG   %1 0 lshift TIM4-EGR bis! ;  \ TIM4-EGR_UG    Update generation

\ TIM4-CCMR1_Output (read-write)
: TIM4-CCMR1_Output_OC2CE   %1 15 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM4-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2M    Output compare 2 mode
: TIM4-CCMR1_Output_OC2PE   %1 11 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM4-CCMR1_Output_OC2FE   %1 10 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM4-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM4-CCMR1_Output_OC1CE   %1 7 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM4-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1M    Output compare 1 mode
: TIM4-CCMR1_Output_OC1PE   %1 3 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM4-CCMR1_Output_OC1FE   %1 2 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM4-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM4-CCMR1_Input (read-write)
: TIM4-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC2F    Input capture 2 filter
: TIM4-CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM4-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_CC2S    Capture/compare 2  selection
: TIM4-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC1F    Input capture 1 filter
: TIM4-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM4-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM4-CCMR2_Output (read-write)
: TIM4-CCMR2_Output_O24CE   %1 15 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_O24CE    Output compare 4 clear  enable
: TIM4-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4M    Output compare 4 mode
: TIM4-CCMR2_Output_OC4PE   %1 11 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM4-CCMR2_Output_OC4FE   %1 10 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM4-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM4-CCMR2_Output_OC3CE   %1 7 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM4-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3M    Output compare 3 mode
: TIM4-CCMR2_Output_OC3PE   %1 3 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM4-CCMR2_Output_OC3FE   %1 2 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM4-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM4-CCMR2_Input (read-write)
: TIM4-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC4F    Input capture 4 filter
: TIM4-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM4-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM4-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC3F    Input capture 3 filter
: TIM4-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM4-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_CC3S    Capture/Compare 3  selection

\ TIM4-CCER (read-write)
: TIM4-CCER_CC4P   %1 13 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM4-CCER_CC4E   %1 12 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4E    Capture/Compare 4 output  enable
: TIM4-CCER_CC3P   %1 9 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM4-CCER_CC3E   %1 8 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3E    Capture/Compare 3 output  enable
: TIM4-CCER_CC2P   %1 5 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM4-CCER_CC2E   %1 4 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2E    Capture/Compare 2 output  enable
: TIM4-CCER_CC1P   %1 1 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM4-CCER_CC1E   %1 0 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM4-CNT (read-write)
: TIM4-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CNT bis! ;  \ TIM4-CNT_CNT    counter value

\ TIM4-PSC (read-write)
: TIM4-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-PSC bis! ;  \ TIM4-PSC_PSC    Prescaler value

\ TIM4-ARR (read-write)
: TIM4-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-ARR bis! ;  \ TIM4-ARR_ARR    Auto-reload value

\ TIM4-CCR1 (read-write)
: TIM4-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR1 bis! ;  \ TIM4-CCR1_CCR1    Capture/Compare 1 value

\ TIM4-CCR2 (read-write)
: TIM4-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR2 bis! ;  \ TIM4-CCR2_CCR2    Capture/Compare 2 value

\ TIM4-CCR3 (read-write)
: TIM4-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR3 bis! ;  \ TIM4-CCR3_CCR3    Capture/Compare value

\ TIM4-CCR4 (read-write)
: TIM4-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR4 bis! ;  \ TIM4-CCR4_CCR4    Capture/Compare value

\ TIM4-DCR (read-write)
: TIM4-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM4-DCR bis! ;  \ TIM4-DCR_DBL    DMA burst length
: TIM4-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM4-DCR bis! ;  \ TIM4-DCR_DBA    DMA base address

\ TIM4-DMAR (read-write)
: TIM4-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-DMAR bis! ;  \ TIM4-DMAR_DMAB    DMA register for burst  accesses

\ TIM5-CR1 (read-write)
: TIM5-CR1_CKD   ( %XX -- ) 8 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CKD    Clock division
: TIM5-CR1_ARPE   %1 7 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_ARPE    Auto-reload preload enable
: TIM5-CR1_CMS   ( %XX -- ) 5 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CMS    Center-aligned mode  selection
: TIM5-CR1_DIR   %1 4 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_DIR    Direction
: TIM5-CR1_OPM   %1 3 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_OPM    One-pulse mode
: TIM5-CR1_URS   %1 2 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_URS    Update request source
: TIM5-CR1_UDIS   %1 1 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_UDIS    Update disable
: TIM5-CR1_CEN   %1 0 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CEN    Counter enable

\ TIM5-CR2 (read-write)
: TIM5-CR2_TI1S   %1 7 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_TI1S    TI1 selection
: TIM5-CR2_MMS   ( %XXX -- ) 4 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_MMS    Master mode selection
: TIM5-CR2_CCDS   %1 3 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_CCDS    Capture/compare DMA  selection

\ TIM5-SMCR (read-write)
: TIM5-SMCR_ETP   %1 15 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETP    External trigger polarity
: TIM5-SMCR_ECE   %1 14 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ECE    External clock enable
: TIM5-SMCR_ETPS   ( %XX -- ) 12 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETPS    External trigger prescaler
: TIM5-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETF    External trigger filter
: TIM5-SMCR_MSM   %1 7 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_MSM    Master/Slave mode
: TIM5-SMCR_TS   ( %XXX -- ) 4 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_TS    Trigger selection
: TIM5-SMCR_SMS   ( %XXX -- ) 0 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_SMS    Slave mode selection

\ TIM5-DIER (read-write)
: TIM5-DIER_TDE   %1 14 lshift TIM5-DIER bis! ;  \ TIM5-DIER_TDE    Trigger DMA request enable
: TIM5-DIER_CC4DE   %1 12 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM5-DIER_CC3DE   %1 11 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM5-DIER_CC2DE   %1 10 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM5-DIER_CC1DE   %1 9 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM5-DIER_UDE   %1 8 lshift TIM5-DIER bis! ;  \ TIM5-DIER_UDE    Update DMA request enable
: TIM5-DIER_TIE   %1 6 lshift TIM5-DIER bis! ;  \ TIM5-DIER_TIE    Trigger interrupt enable
: TIM5-DIER_CC4IE   %1 4 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM5-DIER_CC3IE   %1 3 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM5-DIER_CC2IE   %1 2 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM5-DIER_CC1IE   %1 1 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM5-DIER_UIE   %1 0 lshift TIM5-DIER bis! ;  \ TIM5-DIER_UIE    Update interrupt enable

\ TIM5-SR (read-write)
: TIM5-SR_CC4OF   %1 12 lshift TIM5-SR bis! ;  \ TIM5-SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM5-SR_CC3OF   %1 11 lshift TIM5-SR bis! ;  \ TIM5-SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM5-SR_CC2OF   %1 10 lshift TIM5-SR bis! ;  \ TIM5-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM5-SR_CC1OF   %1 9 lshift TIM5-SR bis! ;  \ TIM5-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM5-SR_TIF   %1 6 lshift TIM5-SR bis! ;  \ TIM5-SR_TIF    Trigger interrupt flag
: TIM5-SR_CC4IF   %1 4 lshift TIM5-SR bis! ;  \ TIM5-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM5-SR_CC3IF   %1 3 lshift TIM5-SR bis! ;  \ TIM5-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM5-SR_CC2IF   %1 2 lshift TIM5-SR bis! ;  \ TIM5-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM5-SR_CC1IF   %1 1 lshift TIM5-SR bis! ;  \ TIM5-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM5-SR_UIF   %1 0 lshift TIM5-SR bis! ;  \ TIM5-SR_UIF    Update interrupt flag

\ TIM5-EGR (write-only)
: TIM5-EGR_TG   %1 6 lshift TIM5-EGR bis! ;  \ TIM5-EGR_TG    Trigger generation
: TIM5-EGR_CC4G   %1 4 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC4G    Capture/compare 4  generation
: TIM5-EGR_CC3G   %1 3 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC3G    Capture/compare 3  generation
: TIM5-EGR_CC2G   %1 2 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC2G    Capture/compare 2  generation
: TIM5-EGR_CC1G   %1 1 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC1G    Capture/compare 1  generation
: TIM5-EGR_UG   %1 0 lshift TIM5-EGR bis! ;  \ TIM5-EGR_UG    Update generation

\ TIM5-CCMR1_Output (read-write)
: TIM5-CCMR1_Output_OC2CE   %1 15 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM5-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2M    Output compare 2 mode
: TIM5-CCMR1_Output_OC2PE   %1 11 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM5-CCMR1_Output_OC2FE   %1 10 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM5-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM5-CCMR1_Output_OC1CE   %1 7 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM5-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1M    Output compare 1 mode
: TIM5-CCMR1_Output_OC1PE   %1 3 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM5-CCMR1_Output_OC1FE   %1 2 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM5-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM5-CCMR1_Input (read-write)
: TIM5-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC2F    Input capture 2 filter
: TIM5-CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM5-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_CC2S    Capture/compare 2  selection
: TIM5-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC1F    Input capture 1 filter
: TIM5-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM5-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM5-CCMR2_Output (read-write)
: TIM5-CCMR2_Output_O24CE   %1 15 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_O24CE    Output compare 4 clear  enable
: TIM5-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4M    Output compare 4 mode
: TIM5-CCMR2_Output_OC4PE   %1 11 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM5-CCMR2_Output_OC4FE   %1 10 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM5-CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM5-CCMR2_Output_OC3CE   %1 7 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM5-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3M    Output compare 3 mode
: TIM5-CCMR2_Output_OC3PE   %1 3 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM5-CCMR2_Output_OC3FE   %1 2 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM5-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM5-CCMR2_Input (read-write)
: TIM5-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC4F    Input capture 4 filter
: TIM5-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM5-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM5-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC3F    Input capture 3 filter
: TIM5-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM5-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_CC3S    Capture/Compare 3  selection

\ TIM5-CCER (read-write)
: TIM5-CCER_CC4P   %1 13 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM5-CCER_CC4E   %1 12 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4E    Capture/Compare 4 output  enable
: TIM5-CCER_CC3P   %1 9 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM5-CCER_CC3E   %1 8 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3E    Capture/Compare 3 output  enable
: TIM5-CCER_CC2P   %1 5 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM5-CCER_CC2E   %1 4 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2E    Capture/Compare 2 output  enable
: TIM5-CCER_CC1P   %1 1 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM5-CCER_CC1E   %1 0 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM5-CNT (read-write)
: TIM5-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CNT bis! ;  \ TIM5-CNT_CNT    counter value

\ TIM5-PSC (read-write)
: TIM5-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-PSC bis! ;  \ TIM5-PSC_PSC    Prescaler value

\ TIM5-ARR (read-write)
: TIM5-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-ARR bis! ;  \ TIM5-ARR_ARR    Auto-reload value

\ TIM5-CCR1 (read-write)
: TIM5-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR1 bis! ;  \ TIM5-CCR1_CCR1    Capture/Compare 1 value

\ TIM5-CCR2 (read-write)
: TIM5-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR2 bis! ;  \ TIM5-CCR2_CCR2    Capture/Compare 2 value

\ TIM5-CCR3 (read-write)
: TIM5-CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR3 bis! ;  \ TIM5-CCR3_CCR3    Capture/Compare value

\ TIM5-CCR4 (read-write)
: TIM5-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR4 bis! ;  \ TIM5-CCR4_CCR4    Capture/Compare value

\ TIM5-DCR (read-write)
: TIM5-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM5-DCR bis! ;  \ TIM5-DCR_DBL    DMA burst length
: TIM5-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM5-DCR bis! ;  \ TIM5-DCR_DBA    DMA base address

\ TIM5-DMAR (read-write)
: TIM5-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-DMAR bis! ;  \ TIM5-DMAR_DMAB    DMA register for burst  accesses

\ TIM9-CR1 (read-write)
: TIM9-CR1_CKD   ( %XX -- ) 8 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_CKD    Clock division
: TIM9-CR1_ARPE   %1 7 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_ARPE    Auto-reload preload enable
: TIM9-CR1_OPM   %1 3 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_OPM    One-pulse mode
: TIM9-CR1_URS   %1 2 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_URS    Update request source
: TIM9-CR1_UDIS   %1 1 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_UDIS    Update disable
: TIM9-CR1_CEN   %1 0 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_CEN    Counter enable

\ TIM9-CR2 (read-write)
: TIM9-CR2_MMS   ( %XXX -- ) 4 lshift TIM9-CR2 bis! ;  \ TIM9-CR2_MMS    Master mode selection

\ TIM9-SMCR (read-write)
: TIM9-SMCR_MSM   %1 7 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_MSM    Master/Slave mode
: TIM9-SMCR_TS   ( %XXX -- ) 4 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_TS    Trigger selection
: TIM9-SMCR_SMS   ( %XXX -- ) 0 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_SMS    Slave mode selection

\ TIM9-DIER (read-write)
: TIM9-DIER_TIE   %1 6 lshift TIM9-DIER bis! ;  \ TIM9-DIER_TIE    Trigger interrupt enable
: TIM9-DIER_CC2IE   %1 2 lshift TIM9-DIER bis! ;  \ TIM9-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM9-DIER_CC1IE   %1 1 lshift TIM9-DIER bis! ;  \ TIM9-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM9-DIER_UIE   %1 0 lshift TIM9-DIER bis! ;  \ TIM9-DIER_UIE    Update interrupt enable

\ TIM9-SR (read-write)
: TIM9-SR_CC2OF   %1 10 lshift TIM9-SR bis! ;  \ TIM9-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM9-SR_CC1OF   %1 9 lshift TIM9-SR bis! ;  \ TIM9-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM9-SR_TIF   %1 6 lshift TIM9-SR bis! ;  \ TIM9-SR_TIF    Trigger interrupt flag
: TIM9-SR_CC2IF   %1 2 lshift TIM9-SR bis! ;  \ TIM9-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM9-SR_CC1IF   %1 1 lshift TIM9-SR bis! ;  \ TIM9-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM9-SR_UIF   %1 0 lshift TIM9-SR bis! ;  \ TIM9-SR_UIF    Update interrupt flag

\ TIM9-EGR (write-only)
: TIM9-EGR_TG   %1 6 lshift TIM9-EGR bis! ;  \ TIM9-EGR_TG    Trigger generation
: TIM9-EGR_CC2G   %1 2 lshift TIM9-EGR bis! ;  \ TIM9-EGR_CC2G    Capture/compare 2  generation
: TIM9-EGR_CC1G   %1 1 lshift TIM9-EGR bis! ;  \ TIM9-EGR_CC1G    Capture/compare 1  generation
: TIM9-EGR_UG   %1 0 lshift TIM9-EGR bis! ;  \ TIM9-EGR_UG    Update generation

\ TIM9-CCMR1_Output (read-write)
: TIM9-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2M    Output Compare 2 mode
: TIM9-CCMR1_Output_OC2PE   %1 11 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2PE    Output Compare 2 preload  enable
: TIM9-CCMR1_Output_OC2FE   %1 10 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2FE    Output Compare 2 fast  enable
: TIM9-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM9-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM9-CCMR1_Output_OC1PE   %1 3 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM9-CCMR1_Output_OC1FE   %1 2 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM9-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM9-CCMR1_Input (read-write)
: TIM9-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC2F    Input capture 2 filter
: TIM9-CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM9-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM9-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC1F    Input capture 1 filter
: TIM9-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM9-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM9-CCER (read-write)
: TIM9-CCER_CC2NP   %1 7 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM9-CCER_CC2P   %1 5 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM9-CCER_CC2E   %1 4 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC2E    Capture/Compare 2 output  enable
: TIM9-CCER_CC1NP   %1 3 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM9-CCER_CC1P   %1 1 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM9-CCER_CC1E   %1 0 lshift TIM9-CCER bis! ;  \ TIM9-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM9-CNT (read-write)
: TIM9-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CNT bis! ;  \ TIM9-CNT_CNT    counter value

\ TIM9-PSC (read-write)
: TIM9-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-PSC bis! ;  \ TIM9-PSC_PSC    Prescaler value

\ TIM9-ARR (read-write)
: TIM9-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-ARR bis! ;  \ TIM9-ARR_ARR    Auto-reload value

\ TIM9-CCR1 (read-write)
: TIM9-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CCR1 bis! ;  \ TIM9-CCR1_CCR1    Capture/Compare 1 value

\ TIM9-CCR2 (read-write)
: TIM9-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CCR2 bis! ;  \ TIM9-CCR2_CCR2    Capture/Compare 2 value

\ TIM12-CR1 (read-write)
: TIM12-CR1_CKD   ( %XX -- ) 8 lshift TIM12-CR1 bis! ;  \ TIM12-CR1_CKD    Clock division
: TIM12-CR1_ARPE   %1 7 lshift TIM12-CR1 bis! ;  \ TIM12-CR1_ARPE    Auto-reload preload enable
: TIM12-CR1_OPM   %1 3 lshift TIM12-CR1 bis! ;  \ TIM12-CR1_OPM    One-pulse mode
: TIM12-CR1_URS   %1 2 lshift TIM12-CR1 bis! ;  \ TIM12-CR1_URS    Update request source
: TIM12-CR1_UDIS   %1 1 lshift TIM12-CR1 bis! ;  \ TIM12-CR1_UDIS    Update disable
: TIM12-CR1_CEN   %1 0 lshift TIM12-CR1 bis! ;  \ TIM12-CR1_CEN    Counter enable

\ TIM12-CR2 (read-write)
: TIM12-CR2_MMS   ( %XXX -- ) 4 lshift TIM12-CR2 bis! ;  \ TIM12-CR2_MMS    Master mode selection

\ TIM12-SMCR (read-write)
: TIM12-SMCR_MSM   %1 7 lshift TIM12-SMCR bis! ;  \ TIM12-SMCR_MSM    Master/Slave mode
: TIM12-SMCR_TS   ( %XXX -- ) 4 lshift TIM12-SMCR bis! ;  \ TIM12-SMCR_TS    Trigger selection
: TIM12-SMCR_SMS   ( %XXX -- ) 0 lshift TIM12-SMCR bis! ;  \ TIM12-SMCR_SMS    Slave mode selection

\ TIM12-DIER (read-write)
: TIM12-DIER_TIE   %1 6 lshift TIM12-DIER bis! ;  \ TIM12-DIER_TIE    Trigger interrupt enable
: TIM12-DIER_CC2IE   %1 2 lshift TIM12-DIER bis! ;  \ TIM12-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM12-DIER_CC1IE   %1 1 lshift TIM12-DIER bis! ;  \ TIM12-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM12-DIER_UIE   %1 0 lshift TIM12-DIER bis! ;  \ TIM12-DIER_UIE    Update interrupt enable

\ TIM12-SR (read-write)
: TIM12-SR_CC2OF   %1 10 lshift TIM12-SR bis! ;  \ TIM12-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM12-SR_CC1OF   %1 9 lshift TIM12-SR bis! ;  \ TIM12-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM12-SR_TIF   %1 6 lshift TIM12-SR bis! ;  \ TIM12-SR_TIF    Trigger interrupt flag
: TIM12-SR_CC2IF   %1 2 lshift TIM12-SR bis! ;  \ TIM12-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM12-SR_CC1IF   %1 1 lshift TIM12-SR bis! ;  \ TIM12-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM12-SR_UIF   %1 0 lshift TIM12-SR bis! ;  \ TIM12-SR_UIF    Update interrupt flag

\ TIM12-EGR (write-only)
: TIM12-EGR_TG   %1 6 lshift TIM12-EGR bis! ;  \ TIM12-EGR_TG    Trigger generation
: TIM12-EGR_CC2G   %1 2 lshift TIM12-EGR bis! ;  \ TIM12-EGR_CC2G    Capture/compare 2  generation
: TIM12-EGR_CC1G   %1 1 lshift TIM12-EGR bis! ;  \ TIM12-EGR_CC1G    Capture/compare 1  generation
: TIM12-EGR_UG   %1 0 lshift TIM12-EGR bis! ;  \ TIM12-EGR_UG    Update generation

\ TIM12-CCMR1_Output (read-write)
: TIM12-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_OC2M    Output Compare 2 mode
: TIM12-CCMR1_Output_OC2PE   %1 11 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_OC2PE    Output Compare 2 preload  enable
: TIM12-CCMR1_Output_OC2FE   %1 10 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_OC2FE    Output Compare 2 fast  enable
: TIM12-CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM12-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM12-CCMR1_Output_OC1PE   %1 3 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM12-CCMR1_Output_OC1FE   %1 2 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM12-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM12-CCMR1_Output bis! ;  \ TIM12-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM12-CCMR1_Input (read-write)
: TIM12-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM12-CCMR1_Input bis! ;  \ TIM12-CCMR1_Input_IC2F    Input capture 2 filter
: TIM12-CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM12-CCMR1_Input bis! ;  \ TIM12-CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM12-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM12-CCMR1_Input bis! ;  \ TIM12-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM12-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM12-CCMR1_Input bis! ;  \ TIM12-CCMR1_Input_IC1F    Input capture 1 filter
: TIM12-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM12-CCMR1_Input bis! ;  \ TIM12-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM12-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM12-CCMR1_Input bis! ;  \ TIM12-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM12-CCER (read-write)
: TIM12-CCER_CC2NP   %1 7 lshift TIM12-CCER bis! ;  \ TIM12-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM12-CCER_CC2P   %1 5 lshift TIM12-CCER bis! ;  \ TIM12-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM12-CCER_CC2E   %1 4 lshift TIM12-CCER bis! ;  \ TIM12-CCER_CC2E    Capture/Compare 2 output  enable
: TIM12-CCER_CC1NP   %1 3 lshift TIM12-CCER bis! ;  \ TIM12-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM12-CCER_CC1P   %1 1 lshift TIM12-CCER bis! ;  \ TIM12-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM12-CCER_CC1E   %1 0 lshift TIM12-CCER bis! ;  \ TIM12-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM12-CNT (read-write)
: TIM12-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM12-CNT bis! ;  \ TIM12-CNT_CNT    counter value

\ TIM12-PSC (read-write)
: TIM12-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM12-PSC bis! ;  \ TIM12-PSC_PSC    Prescaler value

\ TIM12-ARR (read-write)
: TIM12-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM12-ARR bis! ;  \ TIM12-ARR_ARR    Auto-reload value

\ TIM12-CCR1 (read-write)
: TIM12-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM12-CCR1 bis! ;  \ TIM12-CCR1_CCR1    Capture/Compare 1 value

\ TIM12-CCR2 (read-write)
: TIM12-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM12-CCR2 bis! ;  \ TIM12-CCR2_CCR2    Capture/Compare 2 value

\ TIM10-CR1 (read-write)
: TIM10-CR1_CKD   ( %XX -- ) 8 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_CKD    Clock division
: TIM10-CR1_ARPE   %1 7 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_ARPE    Auto-reload preload enable
: TIM10-CR1_URS   %1 2 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_URS    Update request source
: TIM10-CR1_UDIS   %1 1 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_UDIS    Update disable
: TIM10-CR1_CEN   %1 0 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_CEN    Counter enable

\ TIM10-CR2 (read-write)
: TIM10-CR2_MMS   ( %XXX -- ) 4 lshift TIM10-CR2 bis! ;  \ TIM10-CR2_MMS    Master mode selection

\ TIM10-DIER (read-write)
: TIM10-DIER_CC1IE   %1 1 lshift TIM10-DIER bis! ;  \ TIM10-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM10-DIER_UIE   %1 0 lshift TIM10-DIER bis! ;  \ TIM10-DIER_UIE    Update interrupt enable

\ TIM10-SR (read-write)
: TIM10-SR_CC1OF   %1 9 lshift TIM10-SR bis! ;  \ TIM10-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM10-SR_CC1IF   %1 1 lshift TIM10-SR bis! ;  \ TIM10-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM10-SR_UIF   %1 0 lshift TIM10-SR bis! ;  \ TIM10-SR_UIF    Update interrupt flag

\ TIM10-EGR (write-only)
: TIM10-EGR_CC1G   %1 1 lshift TIM10-EGR bis! ;  \ TIM10-EGR_CC1G    Capture/compare 1  generation
: TIM10-EGR_UG   %1 0 lshift TIM10-EGR bis! ;  \ TIM10-EGR_UG    Update generation

\ TIM10-CCMR1_Output (read-write)
: TIM10-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM10-CCMR1_Output_OC1PE   %1 3 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM10-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM10-CCMR1_Input (read-write)
: TIM10-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_IC1F    Input capture 1 filter
: TIM10-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM10-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM10-CCER (read-write)
: TIM10-CCER_CC1NP   %1 3 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM10-CCER_CC1P   %1 1 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM10-CCER_CC1E   %1 0 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM10-CNT (read-write)
: TIM10-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-CNT bis! ;  \ TIM10-CNT_CNT    counter value

\ TIM10-PSC (read-write)
: TIM10-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-PSC bis! ;  \ TIM10-PSC_PSC    Prescaler value

\ TIM10-ARR (read-write)
: TIM10-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-ARR bis! ;  \ TIM10-ARR_ARR    Auto-reload value

\ TIM10-CCR1 (read-write)
: TIM10-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-CCR1 bis! ;  \ TIM10-CCR1_CCR1    Capture/Compare 1 value

\ TIM11-CR1 (read-write)
: TIM11-CR1_CKD   ( %XX -- ) 8 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_CKD    Clock division
: TIM11-CR1_ARPE   %1 7 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_ARPE    Auto-reload preload enable
: TIM11-CR1_URS   %1 2 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_URS    Update request source
: TIM11-CR1_UDIS   %1 1 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_UDIS    Update disable
: TIM11-CR1_CEN   %1 0 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_CEN    Counter enable

\ TIM11-CR2 (read-write)
: TIM11-CR2_MMS   ( %XXX -- ) 4 lshift TIM11-CR2 bis! ;  \ TIM11-CR2_MMS    Master mode selection

\ TIM11-DIER (read-write)
: TIM11-DIER_CC1IE   %1 1 lshift TIM11-DIER bis! ;  \ TIM11-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM11-DIER_UIE   %1 0 lshift TIM11-DIER bis! ;  \ TIM11-DIER_UIE    Update interrupt enable

\ TIM11-SR (read-write)
: TIM11-SR_CC1OF   %1 9 lshift TIM11-SR bis! ;  \ TIM11-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM11-SR_CC1IF   %1 1 lshift TIM11-SR bis! ;  \ TIM11-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM11-SR_UIF   %1 0 lshift TIM11-SR bis! ;  \ TIM11-SR_UIF    Update interrupt flag

\ TIM11-EGR (write-only)
: TIM11-EGR_CC1G   %1 1 lshift TIM11-EGR bis! ;  \ TIM11-EGR_CC1G    Capture/compare 1  generation
: TIM11-EGR_UG   %1 0 lshift TIM11-EGR bis! ;  \ TIM11-EGR_UG    Update generation

\ TIM11-CCMR1_Output (read-write)
: TIM11-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM11-CCMR1_Output_OC1PE   %1 3 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM11-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM11-CCMR1_Input (read-write)
: TIM11-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_IC1F    Input capture 1 filter
: TIM11-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM11-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM11-CCER (read-write)
: TIM11-CCER_CC1NP   %1 3 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM11-CCER_CC1P   %1 1 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM11-CCER_CC1E   %1 0 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM11-CNT (read-write)
: TIM11-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-CNT bis! ;  \ TIM11-CNT_CNT    counter value

\ TIM11-PSC (read-write)
: TIM11-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-PSC bis! ;  \ TIM11-PSC_PSC    Prescaler value

\ TIM11-ARR (read-write)
: TIM11-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-ARR bis! ;  \ TIM11-ARR_ARR    Auto-reload value

\ TIM11-CCR1 (read-write)
: TIM11-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-CCR1 bis! ;  \ TIM11-CCR1_CCR1    Capture/Compare 1 value

\ TIM13-CR1 (read-write)
: TIM13-CR1_CKD   ( %XX -- ) 8 lshift TIM13-CR1 bis! ;  \ TIM13-CR1_CKD    Clock division
: TIM13-CR1_ARPE   %1 7 lshift TIM13-CR1 bis! ;  \ TIM13-CR1_ARPE    Auto-reload preload enable
: TIM13-CR1_URS   %1 2 lshift TIM13-CR1 bis! ;  \ TIM13-CR1_URS    Update request source
: TIM13-CR1_UDIS   %1 1 lshift TIM13-CR1 bis! ;  \ TIM13-CR1_UDIS    Update disable
: TIM13-CR1_CEN   %1 0 lshift TIM13-CR1 bis! ;  \ TIM13-CR1_CEN    Counter enable

\ TIM13-CR2 (read-write)
: TIM13-CR2_MMS   ( %XXX -- ) 4 lshift TIM13-CR2 bis! ;  \ TIM13-CR2_MMS    Master mode selection

\ TIM13-DIER (read-write)
: TIM13-DIER_CC1IE   %1 1 lshift TIM13-DIER bis! ;  \ TIM13-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM13-DIER_UIE   %1 0 lshift TIM13-DIER bis! ;  \ TIM13-DIER_UIE    Update interrupt enable

\ TIM13-SR (read-write)
: TIM13-SR_CC1OF   %1 9 lshift TIM13-SR bis! ;  \ TIM13-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM13-SR_CC1IF   %1 1 lshift TIM13-SR bis! ;  \ TIM13-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM13-SR_UIF   %1 0 lshift TIM13-SR bis! ;  \ TIM13-SR_UIF    Update interrupt flag

\ TIM13-EGR (write-only)
: TIM13-EGR_CC1G   %1 1 lshift TIM13-EGR bis! ;  \ TIM13-EGR_CC1G    Capture/compare 1  generation
: TIM13-EGR_UG   %1 0 lshift TIM13-EGR bis! ;  \ TIM13-EGR_UG    Update generation

\ TIM13-CCMR1_Output (read-write)
: TIM13-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM13-CCMR1_Output bis! ;  \ TIM13-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM13-CCMR1_Output_OC1PE   %1 3 lshift TIM13-CCMR1_Output bis! ;  \ TIM13-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM13-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM13-CCMR1_Output bis! ;  \ TIM13-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM13-CCMR1_Input (read-write)
: TIM13-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM13-CCMR1_Input bis! ;  \ TIM13-CCMR1_Input_IC1F    Input capture 1 filter
: TIM13-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM13-CCMR1_Input bis! ;  \ TIM13-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM13-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM13-CCMR1_Input bis! ;  \ TIM13-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM13-CCER (read-write)
: TIM13-CCER_CC1NP   %1 3 lshift TIM13-CCER bis! ;  \ TIM13-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM13-CCER_CC1P   %1 1 lshift TIM13-CCER bis! ;  \ TIM13-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM13-CCER_CC1E   %1 0 lshift TIM13-CCER bis! ;  \ TIM13-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM13-CNT (read-write)
: TIM13-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM13-CNT bis! ;  \ TIM13-CNT_CNT    counter value

\ TIM13-PSC (read-write)
: TIM13-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM13-PSC bis! ;  \ TIM13-PSC_PSC    Prescaler value

\ TIM13-ARR (read-write)
: TIM13-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM13-ARR bis! ;  \ TIM13-ARR_ARR    Auto-reload value

\ TIM13-CCR1 (read-write)
: TIM13-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM13-CCR1 bis! ;  \ TIM13-CCR1_CCR1    Capture/Compare 1 value

\ TIM14-CR1 (read-write)
: TIM14-CR1_CKD   ( %XX -- ) 8 lshift TIM14-CR1 bis! ;  \ TIM14-CR1_CKD    Clock division
: TIM14-CR1_ARPE   %1 7 lshift TIM14-CR1 bis! ;  \ TIM14-CR1_ARPE    Auto-reload preload enable
: TIM14-CR1_URS   %1 2 lshift TIM14-CR1 bis! ;  \ TIM14-CR1_URS    Update request source
: TIM14-CR1_UDIS   %1 1 lshift TIM14-CR1 bis! ;  \ TIM14-CR1_UDIS    Update disable
: TIM14-CR1_CEN   %1 0 lshift TIM14-CR1 bis! ;  \ TIM14-CR1_CEN    Counter enable

\ TIM14-CR2 (read-write)
: TIM14-CR2_MMS   ( %XXX -- ) 4 lshift TIM14-CR2 bis! ;  \ TIM14-CR2_MMS    Master mode selection

\ TIM14-DIER (read-write)
: TIM14-DIER_CC1IE   %1 1 lshift TIM14-DIER bis! ;  \ TIM14-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM14-DIER_UIE   %1 0 lshift TIM14-DIER bis! ;  \ TIM14-DIER_UIE    Update interrupt enable

\ TIM14-SR (read-write)
: TIM14-SR_CC1OF   %1 9 lshift TIM14-SR bis! ;  \ TIM14-SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM14-SR_CC1IF   %1 1 lshift TIM14-SR bis! ;  \ TIM14-SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM14-SR_UIF   %1 0 lshift TIM14-SR bis! ;  \ TIM14-SR_UIF    Update interrupt flag

\ TIM14-EGR (write-only)
: TIM14-EGR_CC1G   %1 1 lshift TIM14-EGR bis! ;  \ TIM14-EGR_CC1G    Capture/compare 1  generation
: TIM14-EGR_UG   %1 0 lshift TIM14-EGR bis! ;  \ TIM14-EGR_UG    Update generation

\ TIM14-CCMR1_Output (read-write)
: TIM14-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM14-CCMR1_Output bis! ;  \ TIM14-CCMR1_Output_OC1M    Output Compare 1 mode
: TIM14-CCMR1_Output_OC1PE   %1 3 lshift TIM14-CCMR1_Output bis! ;  \ TIM14-CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM14-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM14-CCMR1_Output bis! ;  \ TIM14-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM14-CCMR1_Input (read-write)
: TIM14-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM14-CCMR1_Input bis! ;  \ TIM14-CCMR1_Input_IC1F    Input capture 1 filter
: TIM14-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM14-CCMR1_Input bis! ;  \ TIM14-CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM14-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM14-CCMR1_Input bis! ;  \ TIM14-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM14-CCER (read-write)
: TIM14-CCER_CC1NP   %1 3 lshift TIM14-CCER bis! ;  \ TIM14-CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM14-CCER_CC1P   %1 1 lshift TIM14-CCER bis! ;  \ TIM14-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM14-CCER_CC1E   %1 0 lshift TIM14-CCER bis! ;  \ TIM14-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM14-CNT (read-write)
: TIM14-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14-CNT bis! ;  \ TIM14-CNT_CNT    counter value

\ TIM14-PSC (read-write)
: TIM14-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14-PSC bis! ;  \ TIM14-PSC_PSC    Prescaler value

\ TIM14-ARR (read-write)
: TIM14-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14-ARR bis! ;  \ TIM14-ARR_ARR    Auto-reload value

\ TIM14-CCR1 (read-write)
: TIM14-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14-CCR1 bis! ;  \ TIM14-CCR1_CCR1    Capture/Compare 1 value

\ TIM6-CR1 (read-write)
: TIM6-CR1_ARPE   %1 7 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_ARPE    Auto-reload preload enable
: TIM6-CR1_OPM   %1 3 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_OPM    One-pulse mode
: TIM6-CR1_URS   %1 2 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_URS    Update request source
: TIM6-CR1_UDIS   %1 1 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_UDIS    Update disable
: TIM6-CR1_CEN   %1 0 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_CEN    Counter enable

\ TIM6-CR2 (read-write)
: TIM6-CR2_MMS   ( %XXX -- ) 4 lshift TIM6-CR2 bis! ;  \ TIM6-CR2_MMS    Master mode selection

\ TIM6-DIER (read-write)
: TIM6-DIER_UDE   %1 8 lshift TIM6-DIER bis! ;  \ TIM6-DIER_UDE    Update DMA request enable
: TIM6-DIER_UIE   %1 0 lshift TIM6-DIER bis! ;  \ TIM6-DIER_UIE    Update interrupt enable

\ TIM6-SR (read-write)
: TIM6-SR_UIF   %1 0 lshift TIM6-SR bis! ;  \ TIM6-SR_UIF    Update interrupt flag

\ TIM6-EGR (write-only)
: TIM6-EGR_UG   %1 0 lshift TIM6-EGR bis! ;  \ TIM6-EGR_UG    Update generation

\ TIM6-CNT (read-write)
: TIM6-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6-CNT bis! ;  \ TIM6-CNT_CNT    Low counter value

\ TIM6-PSC (read-write)
: TIM6-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6-PSC bis! ;  \ TIM6-PSC_PSC    Prescaler value

\ TIM6-ARR (read-write)
: TIM6-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6-ARR bis! ;  \ TIM6-ARR_ARR    Low Auto-reload value

\ TIM7-CR1 (read-write)
: TIM7-CR1_ARPE   %1 7 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_ARPE    Auto-reload preload enable
: TIM7-CR1_OPM   %1 3 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_OPM    One-pulse mode
: TIM7-CR1_URS   %1 2 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_URS    Update request source
: TIM7-CR1_UDIS   %1 1 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_UDIS    Update disable
: TIM7-CR1_CEN   %1 0 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_CEN    Counter enable

\ TIM7-CR2 (read-write)
: TIM7-CR2_MMS   ( %XXX -- ) 4 lshift TIM7-CR2 bis! ;  \ TIM7-CR2_MMS    Master mode selection

\ TIM7-DIER (read-write)
: TIM7-DIER_UDE   %1 8 lshift TIM7-DIER bis! ;  \ TIM7-DIER_UDE    Update DMA request enable
: TIM7-DIER_UIE   %1 0 lshift TIM7-DIER bis! ;  \ TIM7-DIER_UIE    Update interrupt enable

\ TIM7-SR (read-write)
: TIM7-SR_UIF   %1 0 lshift TIM7-SR bis! ;  \ TIM7-SR_UIF    Update interrupt flag

\ TIM7-EGR (write-only)
: TIM7-EGR_UG   %1 0 lshift TIM7-EGR bis! ;  \ TIM7-EGR_UG    Update generation

\ TIM7-CNT (read-write)
: TIM7-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM7-CNT bis! ;  \ TIM7-CNT_CNT    Low counter value

\ TIM7-PSC (read-write)
: TIM7-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM7-PSC bis! ;  \ TIM7-PSC_PSC    Prescaler value

\ TIM7-ARR (read-write)
: TIM7-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM7-ARR bis! ;  \ TIM7-ARR_ARR    Low Auto-reload value

\ I2C1-CR1 (read-write)
: I2C1-CR1_SWRST   %1 15 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SWRST    Software reset
: I2C1-CR1_ALERT   %1 13 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ALERT    SMBus alert
: I2C1-CR1_PEC   %1 12 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_PEC    Packet error checking
: I2C1-CR1_POS   %1 11 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_POS    Acknowledge/PEC Position for data  reception
: I2C1-CR1_ACK   %1 10 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ACK    Acknowledge enable
: I2C1-CR1_STOP   %1 9 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_STOP    Stop generation
: I2C1-CR1_START   %1 8 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_START    Start generation
: I2C1-CR1_NOSTRETCH   %1 7 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_NOSTRETCH    Clock stretching disable Slave  mode
: I2C1-CR1_ENGC   %1 6 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENGC    General call enable
: I2C1-CR1_ENPEC   %1 5 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENPEC    PEC enable
: I2C1-CR1_ENARP   %1 4 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENARP    ARP enable
: I2C1-CR1_SMBTYPE   %1 3 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SMBTYPE    SMBus type
: I2C1-CR1_SMBUS   %1 1 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SMBUS    SMBus mode
: I2C1-CR1_PE   %1 0 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_PE    Peripheral enable

\ I2C1-CR2 (read-write)
: I2C1-CR2_LAST   %1 12 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_LAST    DMA last transfer
: I2C1-CR2_DMAEN   %1 11 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_DMAEN    DMA requests enable
: I2C1-CR2_ITBUFEN   %1 10 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITBUFEN    Buffer interrupt enable
: I2C1-CR2_ITEVTEN   %1 9 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITEVTEN    Event interrupt enable
: I2C1-CR2_ITERREN   %1 8 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITERREN    Error interrupt enable
: I2C1-CR2_FREQ   ( %XXXXXX -- ) 0 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_FREQ    Peripheral clock frequency

\ I2C1-OAR1 (read-write)
: I2C1-OAR1_ADDMODE   %1 15 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADDMODE    Addressing mode slave  mode
: I2C1-OAR1_ADD10   ( %XX -- ) 8 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD10    Interface address
: I2C1-OAR1_ADD7   ( %XXXXXXX -- ) 1 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD7    Interface address
: I2C1-OAR1_ADD0   %1 0 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD0    Interface address

\ I2C1-OAR2 (read-write)
: I2C1-OAR2_ADD2   ( %XXXXXXX -- ) 1 lshift I2C1-OAR2 bis! ;  \ I2C1-OAR2_ADD2    Interface address
: I2C1-OAR2_ENDUAL   %1 0 lshift I2C1-OAR2 bis! ;  \ I2C1-OAR2_ENDUAL    Dual addressing mode  enable

\ I2C1-DR (read-write)
: I2C1-DR_DR   ( %XXXXXXXX -- ) 0 lshift I2C1-DR bis! ;  \ I2C1-DR_DR    8-bit data register

\ I2C1-SR1 ()
: I2C1-SR1_SMBALERT   %1 15 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_SMBALERT    SMBus alert
: I2C1-SR1_TIMEOUT   %1 14 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_TIMEOUT    Timeout or Tlow error
: I2C1-SR1_PECERR   %1 12 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_PECERR    PEC Error in reception
: I2C1-SR1_OVR   %1 11 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_OVR    Overrun/Underrun
: I2C1-SR1_AF   %1 10 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_AF    Acknowledge failure
: I2C1-SR1_ARLO   %1 9 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ARLO    Arbitration lost master  mode
: I2C1-SR1_BERR   %1 8 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_BERR    Bus error
: I2C1-SR1_TxE   %1 7 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_TxE    Data register empty  transmitters
: I2C1-SR1_RxNE   %1 6 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_RxNE    Data register not empty  receivers
: I2C1-SR1_STOPF   %1 4 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_STOPF    Stop detection slave  mode
: I2C1-SR1_ADD10   %1 3 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ADD10    10-bit header sent Master  mode
: I2C1-SR1_BTF   %1 2 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_BTF    Byte transfer finished
: I2C1-SR1_ADDR   %1 1 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ADDR    Address sent master mode/matched  slave mode
: I2C1-SR1_SB   %1 0 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_SB    Start bit Master mode

\ I2C1-SR2 (read-only)
: I2C1-SR2_PEC   ( %XXXXXXXX -- ) 8 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_PEC    acket error checking  register
: I2C1-SR2_DUALF   %1 7 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_DUALF    Dual flag Slave mode
: I2C1-SR2_SMBHOST   %1 6 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_SMBHOST    SMBus host header Slave  mode
: I2C1-SR2_SMBDEFAULT   %1 5 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_SMBDEFAULT    SMBus device default address Slave  mode
: I2C1-SR2_GENCALL   %1 4 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_GENCALL    General call address Slave  mode
: I2C1-SR2_TRA   %1 2 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_TRA    Transmitter/receiver
: I2C1-SR2_BUSY   %1 1 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_BUSY    Bus busy
: I2C1-SR2_MSL   %1 0 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_MSL    Master/slave

\ I2C1-CCR (read-write)
: I2C1-CCR_F_S   %1 15 lshift I2C1-CCR bis! ;  \ I2C1-CCR_F_S    I2C master mode selection
: I2C1-CCR_DUTY   %1 14 lshift I2C1-CCR bis! ;  \ I2C1-CCR_DUTY    Fast mode duty cycle
: I2C1-CCR_CCR   ( %XXXXXXXXXXX -- ) 0 lshift I2C1-CCR bis! ;  \ I2C1-CCR_CCR    Clock control register in Fast/Standard  mode Master mode

\ I2C1-TRISE (read-write)
: I2C1-TRISE_TRISE   ( %XXXXXX -- ) 0 lshift I2C1-TRISE bis! ;  \ I2C1-TRISE_TRISE    Maximum rise time in Fast/Standard mode  Master mode

\ I2C2-CR1 (read-write)
: I2C2-CR1_SWRST   %1 15 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SWRST    Software reset
: I2C2-CR1_ALERT   %1 13 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ALERT    SMBus alert
: I2C2-CR1_PEC   %1 12 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PEC    Packet error checking
: I2C2-CR1_POS   %1 11 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_POS    Acknowledge/PEC Position for data  reception
: I2C2-CR1_ACK   %1 10 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ACK    Acknowledge enable
: I2C2-CR1_STOP   %1 9 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_STOP    Stop generation
: I2C2-CR1_START   %1 8 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_START    Start generation
: I2C2-CR1_NOSTRETCH   %1 7 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_NOSTRETCH    Clock stretching disable Slave  mode
: I2C2-CR1_ENGC   %1 6 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENGC    General call enable
: I2C2-CR1_ENPEC   %1 5 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENPEC    PEC enable
: I2C2-CR1_ENARP   %1 4 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENARP    ARP enable
: I2C2-CR1_SMBTYPE   %1 3 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBTYPE    SMBus type
: I2C2-CR1_SMBUS   %1 1 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBUS    SMBus mode
: I2C2-CR1_PE   %1 0 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PE    Peripheral enable

\ I2C2-CR2 (read-write)
: I2C2-CR2_LAST   %1 12 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_LAST    DMA last transfer
: I2C2-CR2_DMAEN   %1 11 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_DMAEN    DMA requests enable
: I2C2-CR2_ITBUFEN   %1 10 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITBUFEN    Buffer interrupt enable
: I2C2-CR2_ITEVTEN   %1 9 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITEVTEN    Event interrupt enable
: I2C2-CR2_ITERREN   %1 8 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITERREN    Error interrupt enable
: I2C2-CR2_FREQ   ( %XXXXXX -- ) 0 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_FREQ    Peripheral clock frequency

\ I2C2-OAR1 (read-write)
: I2C2-OAR1_ADDMODE   %1 15 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADDMODE    Addressing mode slave  mode
: I2C2-OAR1_ADD10   ( %XX -- ) 8 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD10    Interface address
: I2C2-OAR1_ADD7   ( %XXXXXXX -- ) 1 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD7    Interface address
: I2C2-OAR1_ADD0   %1 0 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD0    Interface address

\ I2C2-OAR2 (read-write)
: I2C2-OAR2_ADD2   ( %XXXXXXX -- ) 1 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_ADD2    Interface address
: I2C2-OAR2_ENDUAL   %1 0 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_ENDUAL    Dual addressing mode  enable

\ I2C2-DR (read-write)
: I2C2-DR_DR   ( %XXXXXXXX -- ) 0 lshift I2C2-DR bis! ;  \ I2C2-DR_DR    8-bit data register

\ I2C2-SR1 ()
: I2C2-SR1_SMBALERT   %1 15 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_SMBALERT    SMBus alert
: I2C2-SR1_TIMEOUT   %1 14 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_TIMEOUT    Timeout or Tlow error
: I2C2-SR1_PECERR   %1 12 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_PECERR    PEC Error in reception
: I2C2-SR1_OVR   %1 11 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_OVR    Overrun/Underrun
: I2C2-SR1_AF   %1 10 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_AF    Acknowledge failure
: I2C2-SR1_ARLO   %1 9 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ARLO    Arbitration lost master  mode
: I2C2-SR1_BERR   %1 8 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_BERR    Bus error
: I2C2-SR1_TxE   %1 7 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_TxE    Data register empty  transmitters
: I2C2-SR1_RxNE   %1 6 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_RxNE    Data register not empty  receivers
: I2C2-SR1_STOPF   %1 4 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_STOPF    Stop detection slave  mode
: I2C2-SR1_ADD10   %1 3 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ADD10    10-bit header sent Master  mode
: I2C2-SR1_BTF   %1 2 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_BTF    Byte transfer finished
: I2C2-SR1_ADDR   %1 1 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ADDR    Address sent master mode/matched  slave mode
: I2C2-SR1_SB   %1 0 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_SB    Start bit Master mode

\ I2C2-SR2 (read-only)
: I2C2-SR2_PEC   ( %XXXXXXXX -- ) 8 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_PEC    acket error checking  register
: I2C2-SR2_DUALF   %1 7 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_DUALF    Dual flag Slave mode
: I2C2-SR2_SMBHOST   %1 6 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_SMBHOST    SMBus host header Slave  mode
: I2C2-SR2_SMBDEFAULT   %1 5 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_SMBDEFAULT    SMBus device default address Slave  mode
: I2C2-SR2_GENCALL   %1 4 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_GENCALL    General call address Slave  mode
: I2C2-SR2_TRA   %1 2 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_TRA    Transmitter/receiver
: I2C2-SR2_BUSY   %1 1 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_BUSY    Bus busy
: I2C2-SR2_MSL   %1 0 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_MSL    Master/slave

\ I2C2-CCR (read-write)
: I2C2-CCR_F_S   %1 15 lshift I2C2-CCR bis! ;  \ I2C2-CCR_F_S    I2C master mode selection
: I2C2-CCR_DUTY   %1 14 lshift I2C2-CCR bis! ;  \ I2C2-CCR_DUTY    Fast mode duty cycle
: I2C2-CCR_CCR   ( %XXXXXXXXXXX -- ) 0 lshift I2C2-CCR bis! ;  \ I2C2-CCR_CCR    Clock control register in Fast/Standard  mode Master mode

\ I2C2-TRISE (read-write)
: I2C2-TRISE_TRISE   ( %XXXXXX -- ) 0 lshift I2C2-TRISE bis! ;  \ I2C2-TRISE_TRISE    Maximum rise time in Fast/Standard mode  Master mode

\ SPI1-CR1 (read-write)
: SPI1-CR1_BIDIMODE   %1 15 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIMODE    Bidirectional data mode  enable
: SPI1-CR1_BIDIOE   %1 14 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIOE    Output enable in bidirectional  mode
: SPI1-CR1_CRCEN   %1 13 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCEN    Hardware CRC calculation  enable
: SPI1-CR1_CRCNEXT   %1 12 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCNEXT    CRC transfer next
: SPI1-CR1_DFF   %1 11 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_DFF    Data frame format
: SPI1-CR1_RXONLY   %1 10 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_RXONLY    Receive only
: SPI1-CR1_SSM   %1 9 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSM    Software slave management
: SPI1-CR1_SSI   %1 8 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSI    Internal slave select
: SPI1-CR1_LSBFIRST   %1 7 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_LSBFIRST    Frame format
: SPI1-CR1_SPE   %1 6 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SPE    SPI enable
: SPI1-CR1_BR   ( %XXX -- ) 3 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BR    Baud rate control
: SPI1-CR1_MSTR   %1 2 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_MSTR    Master selection
: SPI1-CR1_CPOL   %1 1 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPOL    Clock polarity
: SPI1-CR1_CPHA   %1 0 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPHA    Clock phase

\ SPI1-CR2 (read-write)
: SPI1-CR2_TXEIE   %1 7 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI1-CR2_RXNEIE   %1 6 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI1-CR2_ERRIE   %1 5 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_ERRIE    Error interrupt enable
: SPI1-CR2_SSOE   %1 2 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_SSOE    SS output enable
: SPI1-CR2_TXDMAEN   %1 1 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXDMAEN    Tx buffer DMA enable
: SPI1-CR2_RXDMAEN   %1 0 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI1-SR ()
: SPI1-SR_BSY   %1 7 lshift SPI1-SR bis! ;  \ SPI1-SR_BSY    Busy flag
: SPI1-SR_OVR   %1 6 lshift SPI1-SR bis! ;  \ SPI1-SR_OVR    Overrun flag
: SPI1-SR_MODF   %1 5 lshift SPI1-SR bis! ;  \ SPI1-SR_MODF    Mode fault
: SPI1-SR_CRCERR   %1 4 lshift SPI1-SR bis! ;  \ SPI1-SR_CRCERR    CRC error flag
: SPI1-SR_UDR   %1 3 lshift SPI1-SR bis! ;  \ SPI1-SR_UDR    Underrun flag
: SPI1-SR_CHSIDE   %1 2 lshift SPI1-SR bis! ;  \ SPI1-SR_CHSIDE    Channel side
: SPI1-SR_TXE   %1 1 lshift SPI1-SR bis! ;  \ SPI1-SR_TXE    Transmit buffer empty
: SPI1-SR_RXNE   %1 0 lshift SPI1-SR bis! ;  \ SPI1-SR_RXNE    Receive buffer not empty

\ SPI1-DR (read-write)
: SPI1-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-DR bis! ;  \ SPI1-DR_DR    Data register

\ SPI1-CRCPR (read-write)
: SPI1-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-CRCPR bis! ;  \ SPI1-CRCPR_CRCPOLY    CRC polynomial register

\ SPI1-RXCRCR (read-only)
: SPI1-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-RXCRCR bis! ;  \ SPI1-RXCRCR_RxCRC    Rx CRC register

\ SPI1-TXCRCR (read-only)
: SPI1-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-TXCRCR bis! ;  \ SPI1-TXCRCR_TxCRC    Tx CRC register

\ SPI1-I2SCFGR (read-write)
: SPI1-I2SCFGR_I2SMOD   %1 11 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SMOD    I2S mode selection
: SPI1-I2SCFGR_I2SE   %1 10 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SE    I2S Enable
: SPI1-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SCFG    I2S configuration mode
: SPI1-I2SCFGR_PCMSYNC   %1 7 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI1-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SSTD    I2S standard selection
: SPI1-I2SCFGR_CKPOL   %1 3 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CKPOL    Steady state clock  polarity
: SPI1-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_DATLEN    Data length to be  transferred
: SPI1-I2SCFGR_CHLEN   %1 0 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI1-I2SPR (read-write)
: SPI1-I2SPR_MCKOE   %1 9 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_MCKOE    Master clock output enable
: SPI1-I2SPR_ODD   %1 8 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_ODD    Odd factor for the  prescaler
: SPI1-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI2-CR1 (read-write)
: SPI2-CR1_BIDIMODE   %1 15 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BIDIMODE    Bidirectional data mode  enable
: SPI2-CR1_BIDIOE   %1 14 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BIDIOE    Output enable in bidirectional  mode
: SPI2-CR1_CRCEN   %1 13 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CRCEN    Hardware CRC calculation  enable
: SPI2-CR1_CRCNEXT   %1 12 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CRCNEXT    CRC transfer next
: SPI2-CR1_DFF   %1 11 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_DFF    Data frame format
: SPI2-CR1_RXONLY   %1 10 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_RXONLY    Receive only
: SPI2-CR1_SSM   %1 9 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SSM    Software slave management
: SPI2-CR1_SSI   %1 8 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SSI    Internal slave select
: SPI2-CR1_LSBFIRST   %1 7 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_LSBFIRST    Frame format
: SPI2-CR1_SPE   %1 6 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SPE    SPI enable
: SPI2-CR1_BR   ( %XXX -- ) 3 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BR    Baud rate control
: SPI2-CR1_MSTR   %1 2 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_MSTR    Master selection
: SPI2-CR1_CPOL   %1 1 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CPOL    Clock polarity
: SPI2-CR1_CPHA   %1 0 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CPHA    Clock phase

\ SPI2-CR2 (read-write)
: SPI2-CR2_TXEIE   %1 7 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI2-CR2_RXNEIE   %1 6 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI2-CR2_ERRIE   %1 5 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_ERRIE    Error interrupt enable
: SPI2-CR2_SSOE   %1 2 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_SSOE    SS output enable
: SPI2-CR2_TXDMAEN   %1 1 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_TXDMAEN    Tx buffer DMA enable
: SPI2-CR2_RXDMAEN   %1 0 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI2-SR ()
: SPI2-SR_BSY   %1 7 lshift SPI2-SR bis! ;  \ SPI2-SR_BSY    Busy flag
: SPI2-SR_OVR   %1 6 lshift SPI2-SR bis! ;  \ SPI2-SR_OVR    Overrun flag
: SPI2-SR_MODF   %1 5 lshift SPI2-SR bis! ;  \ SPI2-SR_MODF    Mode fault
: SPI2-SR_CRCERR   %1 4 lshift SPI2-SR bis! ;  \ SPI2-SR_CRCERR    CRC error flag
: SPI2-SR_UDR   %1 3 lshift SPI2-SR bis! ;  \ SPI2-SR_UDR    Underrun flag
: SPI2-SR_CHSIDE   %1 2 lshift SPI2-SR bis! ;  \ SPI2-SR_CHSIDE    Channel side
: SPI2-SR_TXE   %1 1 lshift SPI2-SR bis! ;  \ SPI2-SR_TXE    Transmit buffer empty
: SPI2-SR_RXNE   %1 0 lshift SPI2-SR bis! ;  \ SPI2-SR_RXNE    Receive buffer not empty

\ SPI2-DR (read-write)
: SPI2-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-DR bis! ;  \ SPI2-DR_DR    Data register

\ SPI2-CRCPR (read-write)
: SPI2-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-CRCPR bis! ;  \ SPI2-CRCPR_CRCPOLY    CRC polynomial register

\ SPI2-RXCRCR (read-only)
: SPI2-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-RXCRCR bis! ;  \ SPI2-RXCRCR_RxCRC    Rx CRC register

\ SPI2-TXCRCR (read-only)
: SPI2-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-TXCRCR bis! ;  \ SPI2-TXCRCR_TxCRC    Tx CRC register

\ SPI2-I2SCFGR (read-write)
: SPI2-I2SCFGR_I2SMOD   %1 11 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SMOD    I2S mode selection
: SPI2-I2SCFGR_I2SE   %1 10 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SE    I2S Enable
: SPI2-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SCFG    I2S configuration mode
: SPI2-I2SCFGR_PCMSYNC   %1 7 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI2-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SSTD    I2S standard selection
: SPI2-I2SCFGR_CKPOL   %1 3 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_CKPOL    Steady state clock  polarity
: SPI2-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_DATLEN    Data length to be  transferred
: SPI2-I2SCFGR_CHLEN   %1 0 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI2-I2SPR (read-write)
: SPI2-I2SPR_MCKOE   %1 9 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_MCKOE    Master clock output enable
: SPI2-I2SPR_ODD   %1 8 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_ODD    Odd factor for the  prescaler
: SPI2-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI3-CR1 (read-write)
: SPI3-CR1_BIDIMODE   %1 15 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BIDIMODE    Bidirectional data mode  enable
: SPI3-CR1_BIDIOE   %1 14 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BIDIOE    Output enable in bidirectional  mode
: SPI3-CR1_CRCEN   %1 13 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CRCEN    Hardware CRC calculation  enable
: SPI3-CR1_CRCNEXT   %1 12 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CRCNEXT    CRC transfer next
: SPI3-CR1_DFF   %1 11 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_DFF    Data frame format
: SPI3-CR1_RXONLY   %1 10 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_RXONLY    Receive only
: SPI3-CR1_SSM   %1 9 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SSM    Software slave management
: SPI3-CR1_SSI   %1 8 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SSI    Internal slave select
: SPI3-CR1_LSBFIRST   %1 7 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_LSBFIRST    Frame format
: SPI3-CR1_SPE   %1 6 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SPE    SPI enable
: SPI3-CR1_BR   ( %XXX -- ) 3 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BR    Baud rate control
: SPI3-CR1_MSTR   %1 2 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_MSTR    Master selection
: SPI3-CR1_CPOL   %1 1 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CPOL    Clock polarity
: SPI3-CR1_CPHA   %1 0 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CPHA    Clock phase

\ SPI3-CR2 (read-write)
: SPI3-CR2_TXEIE   %1 7 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI3-CR2_RXNEIE   %1 6 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI3-CR2_ERRIE   %1 5 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_ERRIE    Error interrupt enable
: SPI3-CR2_SSOE   %1 2 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_SSOE    SS output enable
: SPI3-CR2_TXDMAEN   %1 1 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_TXDMAEN    Tx buffer DMA enable
: SPI3-CR2_RXDMAEN   %1 0 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI3-SR ()
: SPI3-SR_BSY   %1 7 lshift SPI3-SR bis! ;  \ SPI3-SR_BSY    Busy flag
: SPI3-SR_OVR   %1 6 lshift SPI3-SR bis! ;  \ SPI3-SR_OVR    Overrun flag
: SPI3-SR_MODF   %1 5 lshift SPI3-SR bis! ;  \ SPI3-SR_MODF    Mode fault
: SPI3-SR_CRCERR   %1 4 lshift SPI3-SR bis! ;  \ SPI3-SR_CRCERR    CRC error flag
: SPI3-SR_UDR   %1 3 lshift SPI3-SR bis! ;  \ SPI3-SR_UDR    Underrun flag
: SPI3-SR_CHSIDE   %1 2 lshift SPI3-SR bis! ;  \ SPI3-SR_CHSIDE    Channel side
: SPI3-SR_TXE   %1 1 lshift SPI3-SR bis! ;  \ SPI3-SR_TXE    Transmit buffer empty
: SPI3-SR_RXNE   %1 0 lshift SPI3-SR bis! ;  \ SPI3-SR_RXNE    Receive buffer not empty

\ SPI3-DR (read-write)
: SPI3-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-DR bis! ;  \ SPI3-DR_DR    Data register

\ SPI3-CRCPR (read-write)
: SPI3-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-CRCPR bis! ;  \ SPI3-CRCPR_CRCPOLY    CRC polynomial register

\ SPI3-RXCRCR (read-only)
: SPI3-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-RXCRCR bis! ;  \ SPI3-RXCRCR_RxCRC    Rx CRC register

\ SPI3-TXCRCR (read-only)
: SPI3-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-TXCRCR bis! ;  \ SPI3-TXCRCR_TxCRC    Tx CRC register

\ SPI3-I2SCFGR (read-write)
: SPI3-I2SCFGR_I2SMOD   %1 11 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SMOD    I2S mode selection
: SPI3-I2SCFGR_I2SE   %1 10 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SE    I2S Enable
: SPI3-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SCFG    I2S configuration mode
: SPI3-I2SCFGR_PCMSYNC   %1 7 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI3-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SSTD    I2S standard selection
: SPI3-I2SCFGR_CKPOL   %1 3 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_CKPOL    Steady state clock  polarity
: SPI3-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_DATLEN    Data length to be  transferred
: SPI3-I2SCFGR_CHLEN   %1 0 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI3-I2SPR (read-write)
: SPI3-I2SPR_MCKOE   %1 9 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_MCKOE    Master clock output enable
: SPI3-I2SPR_ODD   %1 8 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_ODD    Odd factor for the  prescaler
: SPI3-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_I2SDIV    I2S Linear prescaler

\ USART1-SR ()
: USART1-SR_CTS   %1 9 lshift USART1-SR bis! ;  \ USART1-SR_CTS    CTS flag
: USART1-SR_LBD   %1 8 lshift USART1-SR bis! ;  \ USART1-SR_LBD    LIN break detection flag
: USART1-SR_TXE   %1 7 lshift USART1-SR bis! ;  \ USART1-SR_TXE    Transmit data register  empty
: USART1-SR_TC   %1 6 lshift USART1-SR bis! ;  \ USART1-SR_TC    Transmission complete
: USART1-SR_RXNE   %1 5 lshift USART1-SR bis! ;  \ USART1-SR_RXNE    Read data register not  empty
: USART1-SR_IDLE   %1 4 lshift USART1-SR bis! ;  \ USART1-SR_IDLE    IDLE line detected
: USART1-SR_ORE   %1 3 lshift USART1-SR bis! ;  \ USART1-SR_ORE    Overrun error
: USART1-SR_NE   %1 2 lshift USART1-SR bis! ;  \ USART1-SR_NE    Noise error flag
: USART1-SR_FE   %1 1 lshift USART1-SR bis! ;  \ USART1-SR_FE    Framing error
: USART1-SR_PE   %1 0 lshift USART1-SR bis! ;  \ USART1-SR_PE    Parity error

\ USART1-DR (read-write)
: USART1-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART1-DR bis! ;  \ USART1-DR_DR    Data value

\ USART1-BRR (read-write)
: USART1-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART1-BRR bis! ;  \ USART1-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART1-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART1-BRR bis! ;  \ USART1-BRR_DIV_Fraction    fraction of USARTDIV

\ USART1-CR1 (read-write)
: USART1-CR1_UE   %1 13 lshift USART1-CR1 bis! ;  \ USART1-CR1_UE    USART enable
: USART1-CR1_M   %1 12 lshift USART1-CR1 bis! ;  \ USART1-CR1_M    Word length
: USART1-CR1_WAKE   %1 11 lshift USART1-CR1 bis! ;  \ USART1-CR1_WAKE    Wakeup method
: USART1-CR1_PCE   %1 10 lshift USART1-CR1 bis! ;  \ USART1-CR1_PCE    Parity control enable
: USART1-CR1_PS   %1 9 lshift USART1-CR1 bis! ;  \ USART1-CR1_PS    Parity selection
: USART1-CR1_PEIE   %1 8 lshift USART1-CR1 bis! ;  \ USART1-CR1_PEIE    PE interrupt enable
: USART1-CR1_TXEIE   %1 7 lshift USART1-CR1 bis! ;  \ USART1-CR1_TXEIE    TXE interrupt enable
: USART1-CR1_TCIE   %1 6 lshift USART1-CR1 bis! ;  \ USART1-CR1_TCIE    Transmission complete interrupt  enable
: USART1-CR1_RXNEIE   %1 5 lshift USART1-CR1 bis! ;  \ USART1-CR1_RXNEIE    RXNE interrupt enable
: USART1-CR1_IDLEIE   %1 4 lshift USART1-CR1 bis! ;  \ USART1-CR1_IDLEIE    IDLE interrupt enable
: USART1-CR1_TE   %1 3 lshift USART1-CR1 bis! ;  \ USART1-CR1_TE    Transmitter enable
: USART1-CR1_RE   %1 2 lshift USART1-CR1 bis! ;  \ USART1-CR1_RE    Receiver enable
: USART1-CR1_RWU   %1 1 lshift USART1-CR1 bis! ;  \ USART1-CR1_RWU    Receiver wakeup
: USART1-CR1_SBK   %1 0 lshift USART1-CR1 bis! ;  \ USART1-CR1_SBK    Send break

\ USART1-CR2 (read-write)
: USART1-CR2_LINEN   %1 14 lshift USART1-CR2 bis! ;  \ USART1-CR2_LINEN    LIN mode enable
: USART1-CR2_STOP   ( %XX -- ) 12 lshift USART1-CR2 bis! ;  \ USART1-CR2_STOP    STOP bits
: USART1-CR2_CLKEN   %1 11 lshift USART1-CR2 bis! ;  \ USART1-CR2_CLKEN    Clock enable
: USART1-CR2_CPOL   %1 10 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPOL    Clock polarity
: USART1-CR2_CPHA   %1 9 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPHA    Clock phase
: USART1-CR2_LBCL   %1 8 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBCL    Last bit clock pulse
: USART1-CR2_LBDIE   %1 6 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDIE    LIN break detection interrupt  enable
: USART1-CR2_LBDL   %1 5 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDL    lin break detection length
: USART1-CR2_ADD   ( %XXXX -- ) 0 lshift USART1-CR2 bis! ;  \ USART1-CR2_ADD    Address of the USART node

\ USART1-CR3 (read-write)
: USART1-CR3_CTSIE   %1 10 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSIE    CTS interrupt enable
: USART1-CR3_CTSE   %1 9 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSE    CTS enable
: USART1-CR3_RTSE   %1 8 lshift USART1-CR3 bis! ;  \ USART1-CR3_RTSE    RTS enable
: USART1-CR3_DMAT   %1 7 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAT    DMA enable transmitter
: USART1-CR3_DMAR   %1 6 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAR    DMA enable receiver
: USART1-CR3_SCEN   %1 5 lshift USART1-CR3 bis! ;  \ USART1-CR3_SCEN    Smartcard mode enable
: USART1-CR3_NACK   %1 4 lshift USART1-CR3 bis! ;  \ USART1-CR3_NACK    Smartcard NACK enable
: USART1-CR3_HDSEL   %1 3 lshift USART1-CR3 bis! ;  \ USART1-CR3_HDSEL    Half-duplex selection
: USART1-CR3_IRLP   %1 2 lshift USART1-CR3 bis! ;  \ USART1-CR3_IRLP    IrDA low-power
: USART1-CR3_IREN   %1 1 lshift USART1-CR3 bis! ;  \ USART1-CR3_IREN    IrDA mode enable
: USART1-CR3_EIE   %1 0 lshift USART1-CR3 bis! ;  \ USART1-CR3_EIE    Error interrupt enable

\ USART1-GTPR (read-write)
: USART1-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART1-GTPR bis! ;  \ USART1-GTPR_GT    Guard time value
: USART1-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART1-GTPR bis! ;  \ USART1-GTPR_PSC    Prescaler value

\ USART2-SR ()
: USART2-SR_CTS   %1 9 lshift USART2-SR bis! ;  \ USART2-SR_CTS    CTS flag
: USART2-SR_LBD   %1 8 lshift USART2-SR bis! ;  \ USART2-SR_LBD    LIN break detection flag
: USART2-SR_TXE   %1 7 lshift USART2-SR bis! ;  \ USART2-SR_TXE    Transmit data register  empty
: USART2-SR_TC   %1 6 lshift USART2-SR bis! ;  \ USART2-SR_TC    Transmission complete
: USART2-SR_RXNE   %1 5 lshift USART2-SR bis! ;  \ USART2-SR_RXNE    Read data register not  empty
: USART2-SR_IDLE   %1 4 lshift USART2-SR bis! ;  \ USART2-SR_IDLE    IDLE line detected
: USART2-SR_ORE   %1 3 lshift USART2-SR bis! ;  \ USART2-SR_ORE    Overrun error
: USART2-SR_NE   %1 2 lshift USART2-SR bis! ;  \ USART2-SR_NE    Noise error flag
: USART2-SR_FE   %1 1 lshift USART2-SR bis! ;  \ USART2-SR_FE    Framing error
: USART2-SR_PE   %1 0 lshift USART2-SR bis! ;  \ USART2-SR_PE    Parity error

\ USART2-DR (read-write)
: USART2-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART2-DR bis! ;  \ USART2-DR_DR    Data value

\ USART2-BRR (read-write)
: USART2-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART2-BRR bis! ;  \ USART2-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART2-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART2-BRR bis! ;  \ USART2-BRR_DIV_Fraction    fraction of USARTDIV

\ USART2-CR1 (read-write)
: USART2-CR1_UE   %1 13 lshift USART2-CR1 bis! ;  \ USART2-CR1_UE    USART enable
: USART2-CR1_M   %1 12 lshift USART2-CR1 bis! ;  \ USART2-CR1_M    Word length
: USART2-CR1_WAKE   %1 11 lshift USART2-CR1 bis! ;  \ USART2-CR1_WAKE    Wakeup method
: USART2-CR1_PCE   %1 10 lshift USART2-CR1 bis! ;  \ USART2-CR1_PCE    Parity control enable
: USART2-CR1_PS   %1 9 lshift USART2-CR1 bis! ;  \ USART2-CR1_PS    Parity selection
: USART2-CR1_PEIE   %1 8 lshift USART2-CR1 bis! ;  \ USART2-CR1_PEIE    PE interrupt enable
: USART2-CR1_TXEIE   %1 7 lshift USART2-CR1 bis! ;  \ USART2-CR1_TXEIE    TXE interrupt enable
: USART2-CR1_TCIE   %1 6 lshift USART2-CR1 bis! ;  \ USART2-CR1_TCIE    Transmission complete interrupt  enable
: USART2-CR1_RXNEIE   %1 5 lshift USART2-CR1 bis! ;  \ USART2-CR1_RXNEIE    RXNE interrupt enable
: USART2-CR1_IDLEIE   %1 4 lshift USART2-CR1 bis! ;  \ USART2-CR1_IDLEIE    IDLE interrupt enable
: USART2-CR1_TE   %1 3 lshift USART2-CR1 bis! ;  \ USART2-CR1_TE    Transmitter enable
: USART2-CR1_RE   %1 2 lshift USART2-CR1 bis! ;  \ USART2-CR1_RE    Receiver enable
: USART2-CR1_RWU   %1 1 lshift USART2-CR1 bis! ;  \ USART2-CR1_RWU    Receiver wakeup
: USART2-CR1_SBK   %1 0 lshift USART2-CR1 bis! ;  \ USART2-CR1_SBK    Send break

\ USART2-CR2 (read-write)
: USART2-CR2_LINEN   %1 14 lshift USART2-CR2 bis! ;  \ USART2-CR2_LINEN    LIN mode enable
: USART2-CR2_STOP   ( %XX -- ) 12 lshift USART2-CR2 bis! ;  \ USART2-CR2_STOP    STOP bits
: USART2-CR2_CLKEN   %1 11 lshift USART2-CR2 bis! ;  \ USART2-CR2_CLKEN    Clock enable
: USART2-CR2_CPOL   %1 10 lshift USART2-CR2 bis! ;  \ USART2-CR2_CPOL    Clock polarity
: USART2-CR2_CPHA   %1 9 lshift USART2-CR2 bis! ;  \ USART2-CR2_CPHA    Clock phase
: USART2-CR2_LBCL   %1 8 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBCL    Last bit clock pulse
: USART2-CR2_LBDIE   %1 6 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBDIE    LIN break detection interrupt  enable
: USART2-CR2_LBDL   %1 5 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBDL    lin break detection length
: USART2-CR2_ADD   ( %XXXX -- ) 0 lshift USART2-CR2 bis! ;  \ USART2-CR2_ADD    Address of the USART node

\ USART2-CR3 (read-write)
: USART2-CR3_CTSIE   %1 10 lshift USART2-CR3 bis! ;  \ USART2-CR3_CTSIE    CTS interrupt enable
: USART2-CR3_CTSE   %1 9 lshift USART2-CR3 bis! ;  \ USART2-CR3_CTSE    CTS enable
: USART2-CR3_RTSE   %1 8 lshift USART2-CR3 bis! ;  \ USART2-CR3_RTSE    RTS enable
: USART2-CR3_DMAT   %1 7 lshift USART2-CR3 bis! ;  \ USART2-CR3_DMAT    DMA enable transmitter
: USART2-CR3_DMAR   %1 6 lshift USART2-CR3 bis! ;  \ USART2-CR3_DMAR    DMA enable receiver
: USART2-CR3_SCEN   %1 5 lshift USART2-CR3 bis! ;  \ USART2-CR3_SCEN    Smartcard mode enable
: USART2-CR3_NACK   %1 4 lshift USART2-CR3 bis! ;  \ USART2-CR3_NACK    Smartcard NACK enable
: USART2-CR3_HDSEL   %1 3 lshift USART2-CR3 bis! ;  \ USART2-CR3_HDSEL    Half-duplex selection
: USART2-CR3_IRLP   %1 2 lshift USART2-CR3 bis! ;  \ USART2-CR3_IRLP    IrDA low-power
: USART2-CR3_IREN   %1 1 lshift USART2-CR3 bis! ;  \ USART2-CR3_IREN    IrDA mode enable
: USART2-CR3_EIE   %1 0 lshift USART2-CR3 bis! ;  \ USART2-CR3_EIE    Error interrupt enable

\ USART2-GTPR (read-write)
: USART2-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART2-GTPR bis! ;  \ USART2-GTPR_GT    Guard time value
: USART2-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART2-GTPR bis! ;  \ USART2-GTPR_PSC    Prescaler value

\ USART3-SR ()
: USART3-SR_CTS   %1 9 lshift USART3-SR bis! ;  \ USART3-SR_CTS    CTS flag
: USART3-SR_LBD   %1 8 lshift USART3-SR bis! ;  \ USART3-SR_LBD    LIN break detection flag
: USART3-SR_TXE   %1 7 lshift USART3-SR bis! ;  \ USART3-SR_TXE    Transmit data register  empty
: USART3-SR_TC   %1 6 lshift USART3-SR bis! ;  \ USART3-SR_TC    Transmission complete
: USART3-SR_RXNE   %1 5 lshift USART3-SR bis! ;  \ USART3-SR_RXNE    Read data register not  empty
: USART3-SR_IDLE   %1 4 lshift USART3-SR bis! ;  \ USART3-SR_IDLE    IDLE line detected
: USART3-SR_ORE   %1 3 lshift USART3-SR bis! ;  \ USART3-SR_ORE    Overrun error
: USART3-SR_NE   %1 2 lshift USART3-SR bis! ;  \ USART3-SR_NE    Noise error flag
: USART3-SR_FE   %1 1 lshift USART3-SR bis! ;  \ USART3-SR_FE    Framing error
: USART3-SR_PE   %1 0 lshift USART3-SR bis! ;  \ USART3-SR_PE    Parity error

\ USART3-DR (read-write)
: USART3-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART3-DR bis! ;  \ USART3-DR_DR    Data value

\ USART3-BRR (read-write)
: USART3-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART3-BRR bis! ;  \ USART3-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART3-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART3-BRR bis! ;  \ USART3-BRR_DIV_Fraction    fraction of USARTDIV

\ USART3-CR1 (read-write)
: USART3-CR1_UE   %1 13 lshift USART3-CR1 bis! ;  \ USART3-CR1_UE    USART enable
: USART3-CR1_M   %1 12 lshift USART3-CR1 bis! ;  \ USART3-CR1_M    Word length
: USART3-CR1_WAKE   %1 11 lshift USART3-CR1 bis! ;  \ USART3-CR1_WAKE    Wakeup method
: USART3-CR1_PCE   %1 10 lshift USART3-CR1 bis! ;  \ USART3-CR1_PCE    Parity control enable
: USART3-CR1_PS   %1 9 lshift USART3-CR1 bis! ;  \ USART3-CR1_PS    Parity selection
: USART3-CR1_PEIE   %1 8 lshift USART3-CR1 bis! ;  \ USART3-CR1_PEIE    PE interrupt enable
: USART3-CR1_TXEIE   %1 7 lshift USART3-CR1 bis! ;  \ USART3-CR1_TXEIE    TXE interrupt enable
: USART3-CR1_TCIE   %1 6 lshift USART3-CR1 bis! ;  \ USART3-CR1_TCIE    Transmission complete interrupt  enable
: USART3-CR1_RXNEIE   %1 5 lshift USART3-CR1 bis! ;  \ USART3-CR1_RXNEIE    RXNE interrupt enable
: USART3-CR1_IDLEIE   %1 4 lshift USART3-CR1 bis! ;  \ USART3-CR1_IDLEIE    IDLE interrupt enable
: USART3-CR1_TE   %1 3 lshift USART3-CR1 bis! ;  \ USART3-CR1_TE    Transmitter enable
: USART3-CR1_RE   %1 2 lshift USART3-CR1 bis! ;  \ USART3-CR1_RE    Receiver enable
: USART3-CR1_RWU   %1 1 lshift USART3-CR1 bis! ;  \ USART3-CR1_RWU    Receiver wakeup
: USART3-CR1_SBK   %1 0 lshift USART3-CR1 bis! ;  \ USART3-CR1_SBK    Send break

\ USART3-CR2 (read-write)
: USART3-CR2_LINEN   %1 14 lshift USART3-CR2 bis! ;  \ USART3-CR2_LINEN    LIN mode enable
: USART3-CR2_STOP   ( %XX -- ) 12 lshift USART3-CR2 bis! ;  \ USART3-CR2_STOP    STOP bits
: USART3-CR2_CLKEN   %1 11 lshift USART3-CR2 bis! ;  \ USART3-CR2_CLKEN    Clock enable
: USART3-CR2_CPOL   %1 10 lshift USART3-CR2 bis! ;  \ USART3-CR2_CPOL    Clock polarity
: USART3-CR2_CPHA   %1 9 lshift USART3-CR2 bis! ;  \ USART3-CR2_CPHA    Clock phase
: USART3-CR2_LBCL   %1 8 lshift USART3-CR2 bis! ;  \ USART3-CR2_LBCL    Last bit clock pulse
: USART3-CR2_LBDIE   %1 6 lshift USART3-CR2 bis! ;  \ USART3-CR2_LBDIE    LIN break detection interrupt  enable
: USART3-CR2_LBDL   %1 5 lshift USART3-CR2 bis! ;  \ USART3-CR2_LBDL    lin break detection length
: USART3-CR2_ADD   ( %XXXX -- ) 0 lshift USART3-CR2 bis! ;  \ USART3-CR2_ADD    Address of the USART node

\ USART3-CR3 (read-write)
: USART3-CR3_CTSIE   %1 10 lshift USART3-CR3 bis! ;  \ USART3-CR3_CTSIE    CTS interrupt enable
: USART3-CR3_CTSE   %1 9 lshift USART3-CR3 bis! ;  \ USART3-CR3_CTSE    CTS enable
: USART3-CR3_RTSE   %1 8 lshift USART3-CR3 bis! ;  \ USART3-CR3_RTSE    RTS enable
: USART3-CR3_DMAT   %1 7 lshift USART3-CR3 bis! ;  \ USART3-CR3_DMAT    DMA enable transmitter
: USART3-CR3_DMAR   %1 6 lshift USART3-CR3 bis! ;  \ USART3-CR3_DMAR    DMA enable receiver
: USART3-CR3_SCEN   %1 5 lshift USART3-CR3 bis! ;  \ USART3-CR3_SCEN    Smartcard mode enable
: USART3-CR3_NACK   %1 4 lshift USART3-CR3 bis! ;  \ USART3-CR3_NACK    Smartcard NACK enable
: USART3-CR3_HDSEL   %1 3 lshift USART3-CR3 bis! ;  \ USART3-CR3_HDSEL    Half-duplex selection
: USART3-CR3_IRLP   %1 2 lshift USART3-CR3 bis! ;  \ USART3-CR3_IRLP    IrDA low-power
: USART3-CR3_IREN   %1 1 lshift USART3-CR3 bis! ;  \ USART3-CR3_IREN    IrDA mode enable
: USART3-CR3_EIE   %1 0 lshift USART3-CR3 bis! ;  \ USART3-CR3_EIE    Error interrupt enable

\ USART3-GTPR (read-write)
: USART3-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART3-GTPR bis! ;  \ USART3-GTPR_GT    Guard time value
: USART3-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART3-GTPR bis! ;  \ USART3-GTPR_PSC    Prescaler value

\ ADC1-SR (read-write)
: ADC1-SR_STRT   %1 4 lshift ADC1-SR bis! ;  \ ADC1-SR_STRT    Regular channel start flag
: ADC1-SR_JSTRT   %1 3 lshift ADC1-SR bis! ;  \ ADC1-SR_JSTRT    Injected channel start  flag
: ADC1-SR_JEOC   %1 2 lshift ADC1-SR bis! ;  \ ADC1-SR_JEOC    Injected channel end of  conversion
: ADC1-SR_EOC   %1 1 lshift ADC1-SR bis! ;  \ ADC1-SR_EOC    Regular channel end of  conversion
: ADC1-SR_AWD   %1 0 lshift ADC1-SR bis! ;  \ ADC1-SR_AWD    Analog watchdog flag

\ ADC1-CR1 (read-write)
: ADC1-CR1_AWDEN   %1 23 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDEN    Analog watchdog enable on regular  channels
: ADC1-CR1_JAWDEN   %1 22 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JAWDEN    Analog watchdog enable on injected  channels
: ADC1-CR1_DUALMOD   ( %XXXX -- ) 16 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_DUALMOD    Dual mode selection
: ADC1-CR1_DISCNUM   ( %XXX -- ) 13 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_DISCNUM    Discontinuous mode channel  count
: ADC1-CR1_JDISCEN   %1 12 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JDISCEN    Discontinuous mode on injected  channels
: ADC1-CR1_DISCEN   %1 11 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_DISCEN    Discontinuous mode on regular  channels
: ADC1-CR1_JAUTO   %1 10 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JAUTO    Automatic injected group  conversion
: ADC1-CR1_AWDSGL   %1 9 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDSGL    Enable the watchdog on a single channel  in scan mode
: ADC1-CR1_SCAN   %1 8 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_SCAN    Scan mode
: ADC1-CR1_JEOCIE   %1 7 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_JEOCIE    Interrupt enable for injected  channels
: ADC1-CR1_AWDIE   %1 6 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDIE    Analog watchdog interrupt  enable
: ADC1-CR1_EOCIE   %1 5 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_EOCIE    Interrupt enable for EOC
: ADC1-CR1_AWDCH   ( %XXXXX -- ) 0 lshift ADC1-CR1 bis! ;  \ ADC1-CR1_AWDCH    Analog watchdog channel select  bits

\ ADC1-CR2 (read-write)
: ADC1-CR2_TSVREFE   %1 23 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_TSVREFE    Temperature sensor and VREFINT  enable
: ADC1-CR2_SWSTART   %1 22 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_SWSTART    Start conversion of regular  channels
: ADC1-CR2_JSWSTART   %1 21 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_JSWSTART    Start conversion of injected  channels
: ADC1-CR2_EXTTRIG   %1 20 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_EXTTRIG    External trigger conversion mode for  regular channels
: ADC1-CR2_EXTSEL   ( %XXX -- ) 17 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_EXTSEL    External event select for regular  group
: ADC1-CR2_JEXTTRIG   %1 15 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_JEXTTRIG    External trigger conversion mode for  injected channels
: ADC1-CR2_JEXTSEL   ( %XXX -- ) 12 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_JEXTSEL    External event select for injected  group
: ADC1-CR2_ALIGN   %1 11 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_ALIGN    Data alignment
: ADC1-CR2_DMA   %1 8 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_DMA    Direct memory access mode
: ADC1-CR2_RSTCAL   %1 3 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_RSTCAL    Reset calibration
: ADC1-CR2_CAL   %1 2 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_CAL    A/D calibration
: ADC1-CR2_CONT   %1 1 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_CONT    Continuous conversion
: ADC1-CR2_ADON   %1 0 lshift ADC1-CR2 bis! ;  \ ADC1-CR2_ADON    A/D converter ON / OFF

\ ADC1-SMPR1 (read-write)
: ADC1-SMPR1_SMP10   ( %XXX -- ) 0 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP10    Channel 10 sample time  selection
: ADC1-SMPR1_SMP11   ( %XXX -- ) 3 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP11    Channel 11 sample time  selection
: ADC1-SMPR1_SMP12   ( %XXX -- ) 6 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP12    Channel 12 sample time  selection
: ADC1-SMPR1_SMP13   ( %XXX -- ) 9 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP13    Channel 13 sample time  selection
: ADC1-SMPR1_SMP14   ( %XXX -- ) 12 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP14    Channel 14 sample time  selection
: ADC1-SMPR1_SMP15   ( %XXX -- ) 15 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP15    Channel 15 sample time  selection
: ADC1-SMPR1_SMP16   ( %XXX -- ) 18 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP16    Channel 16 sample time  selection
: ADC1-SMPR1_SMP17   ( %XXX -- ) 21 lshift ADC1-SMPR1 bis! ;  \ ADC1-SMPR1_SMP17    Channel 17 sample time  selection

\ ADC1-SMPR2 (read-write)
: ADC1-SMPR2_SMP0   ( %XXX -- ) 0 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP0    Channel 0 sample time  selection
: ADC1-SMPR2_SMP1   ( %XXX -- ) 3 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP1    Channel 1 sample time  selection
: ADC1-SMPR2_SMP2   ( %XXX -- ) 6 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP2    Channel 2 sample time  selection
: ADC1-SMPR2_SMP3   ( %XXX -- ) 9 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP3    Channel 3 sample time  selection
: ADC1-SMPR2_SMP4   ( %XXX -- ) 12 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP4    Channel 4 sample time  selection
: ADC1-SMPR2_SMP5   ( %XXX -- ) 15 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP5    Channel 5 sample time  selection
: ADC1-SMPR2_SMP6   ( %XXX -- ) 18 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP6    Channel 6 sample time  selection
: ADC1-SMPR2_SMP7   ( %XXX -- ) 21 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP7    Channel 7 sample time  selection
: ADC1-SMPR2_SMP8   ( %XXX -- ) 24 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP8    Channel 8 sample time  selection
: ADC1-SMPR2_SMP9   ( %XXX -- ) 27 lshift ADC1-SMPR2 bis! ;  \ ADC1-SMPR2_SMP9    Channel 9 sample time  selection

\ ADC1-JOFR1 (read-write)
: ADC1-JOFR1_JOFFSET1   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR1 bis! ;  \ ADC1-JOFR1_JOFFSET1    Data offset for injected channel  x

\ ADC1-JOFR2 (read-write)
: ADC1-JOFR2_JOFFSET2   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR2 bis! ;  \ ADC1-JOFR2_JOFFSET2    Data offset for injected channel  x

\ ADC1-JOFR3 (read-write)
: ADC1-JOFR3_JOFFSET3   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR3 bis! ;  \ ADC1-JOFR3_JOFFSET3    Data offset for injected channel  x

\ ADC1-JOFR4 (read-write)
: ADC1-JOFR4_JOFFSET4   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-JOFR4 bis! ;  \ ADC1-JOFR4_JOFFSET4    Data offset for injected channel  x

\ ADC1-HTR (read-write)
: ADC1-HTR_HT   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-HTR bis! ;  \ ADC1-HTR_HT    Analog watchdog higher  threshold

\ ADC1-LTR (read-write)
: ADC1-LTR_LT   ( %XXXXXXXXXXX -- ) 0 lshift ADC1-LTR bis! ;  \ ADC1-LTR_LT    Analog watchdog lower  threshold

\ ADC1-SQR1 (read-write)
: ADC1-SQR1_L   ( %XXXX -- ) 20 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_L    Regular channel sequence  length
: ADC1-SQR1_SQ16   ( %XXXXX -- ) 15 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ16    16th conversion in regular  sequence
: ADC1-SQR1_SQ15   ( %XXXXX -- ) 10 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ15    15th conversion in regular  sequence
: ADC1-SQR1_SQ14   ( %XXXXX -- ) 5 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ14    14th conversion in regular  sequence
: ADC1-SQR1_SQ13   ( %XXXXX -- ) 0 lshift ADC1-SQR1 bis! ;  \ ADC1-SQR1_SQ13    13th conversion in regular  sequence

\ ADC1-SQR2 (read-write)
: ADC1-SQR2_SQ12   ( %XXXXX -- ) 25 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ12    12th conversion in regular  sequence
: ADC1-SQR2_SQ11   ( %XXXXX -- ) 20 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ11    11th conversion in regular  sequence
: ADC1-SQR2_SQ10   ( %XXXXX -- ) 15 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ10    10th conversion in regular  sequence
: ADC1-SQR2_SQ9   ( %XXXXX -- ) 10 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ9    9th conversion in regular  sequence
: ADC1-SQR2_SQ8   ( %XXXXX -- ) 5 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ8    8th conversion in regular  sequence
: ADC1-SQR2_SQ7   ( %XXXXX -- ) 0 lshift ADC1-SQR2 bis! ;  \ ADC1-SQR2_SQ7    7th conversion in regular  sequence

\ ADC1-SQR3 (read-write)
: ADC1-SQR3_SQ6   ( %XXXXX -- ) 25 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ6    6th conversion in regular  sequence
: ADC1-SQR3_SQ5   ( %XXXXX -- ) 20 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ5    5th conversion in regular  sequence
: ADC1-SQR3_SQ4   ( %XXXXX -- ) 15 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ4    4th conversion in regular  sequence
: ADC1-SQR3_SQ3   ( %XXXXX -- ) 10 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ3    3rd conversion in regular  sequence
: ADC1-SQR3_SQ2   ( %XXXXX -- ) 5 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ2    2nd conversion in regular  sequence
: ADC1-SQR3_SQ1   ( %XXXXX -- ) 0 lshift ADC1-SQR3 bis! ;  \ ADC1-SQR3_SQ1    1st conversion in regular  sequence

\ ADC1-JSQR (read-write)
: ADC1-JSQR_JL   ( %XX -- ) 20 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JL    Injected sequence length
: ADC1-JSQR_JSQ4   ( %XXXXX -- ) 15 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ4    4th conversion in injected  sequence
: ADC1-JSQR_JSQ3   ( %XXXXX -- ) 10 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ3    3rd conversion in injected  sequence
: ADC1-JSQR_JSQ2   ( %XXXXX -- ) 5 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ2    2nd conversion in injected  sequence
: ADC1-JSQR_JSQ1   ( %XXXXX -- ) 0 lshift ADC1-JSQR bis! ;  \ ADC1-JSQR_JSQ1    1st conversion in injected  sequence

\ ADC1-JDR1 (read-only)
: ADC1-JDR1_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR1 bis! ;  \ ADC1-JDR1_JDATA    Injected data

\ ADC1-JDR2 (read-only)
: ADC1-JDR2_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR2 bis! ;  \ ADC1-JDR2_JDATA    Injected data

\ ADC1-JDR3 (read-only)
: ADC1-JDR3_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR3 bis! ;  \ ADC1-JDR3_JDATA    Injected data

\ ADC1-JDR4 (read-only)
: ADC1-JDR4_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-JDR4 bis! ;  \ ADC1-JDR4_JDATA    Injected data

\ ADC1-DR (read-only)
: ADC1-DR_DATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC1-DR bis! ;  \ ADC1-DR_DATA    Regular data
: ADC1-DR_ADC2DATA   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift ADC1-DR bis! ;  \ ADC1-DR_ADC2DATA    ADC2 data

\ ADC2-SR (read-write)
: ADC2-SR_STRT   %1 4 lshift ADC2-SR bis! ;  \ ADC2-SR_STRT    Regular channel start flag
: ADC2-SR_JSTRT   %1 3 lshift ADC2-SR bis! ;  \ ADC2-SR_JSTRT    Injected channel start  flag
: ADC2-SR_JEOC   %1 2 lshift ADC2-SR bis! ;  \ ADC2-SR_JEOC    Injected channel end of  conversion
: ADC2-SR_EOC   %1 1 lshift ADC2-SR bis! ;  \ ADC2-SR_EOC    Regular channel end of  conversion
: ADC2-SR_AWD   %1 0 lshift ADC2-SR bis! ;  \ ADC2-SR_AWD    Analog watchdog flag

\ ADC2-CR1 (read-write)
: ADC2-CR1_AWDEN   %1 23 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_AWDEN    Analog watchdog enable on regular  channels
: ADC2-CR1_JAWDEN   %1 22 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_JAWDEN    Analog watchdog enable on injected  channels
: ADC2-CR1_DISCNUM   ( %XXX -- ) 13 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_DISCNUM    Discontinuous mode channel  count
: ADC2-CR1_JDISCEN   %1 12 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_JDISCEN    Discontinuous mode on injected  channels
: ADC2-CR1_DISCEN   %1 11 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_DISCEN    Discontinuous mode on regular  channels
: ADC2-CR1_JAUTO   %1 10 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_JAUTO    Automatic injected group  conversion
: ADC2-CR1_AWDSGL   %1 9 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_AWDSGL    Enable the watchdog on a single channel  in scan mode
: ADC2-CR1_SCAN   %1 8 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_SCAN    Scan mode
: ADC2-CR1_JEOCIE   %1 7 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_JEOCIE    Interrupt enable for injected  channels
: ADC2-CR1_AWDIE   %1 6 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_AWDIE    Analog watchdog interrupt  enable
: ADC2-CR1_EOCIE   %1 5 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_EOCIE    Interrupt enable for EOC
: ADC2-CR1_AWDCH   ( %XXXXX -- ) 0 lshift ADC2-CR1 bis! ;  \ ADC2-CR1_AWDCH    Analog watchdog channel select  bits

\ ADC2-CR2 (read-write)
: ADC2-CR2_TSVREFE   %1 23 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_TSVREFE    Temperature sensor and VREFINT  enable
: ADC2-CR2_SWSTART   %1 22 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_SWSTART    Start conversion of regular  channels
: ADC2-CR2_JSWSTART   %1 21 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_JSWSTART    Start conversion of injected  channels
: ADC2-CR2_EXTTRIG   %1 20 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_EXTTRIG    External trigger conversion mode for  regular channels
: ADC2-CR2_EXTSEL   ( %XXX -- ) 17 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_EXTSEL    External event select for regular  group
: ADC2-CR2_JEXTTRIG   %1 15 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_JEXTTRIG    External trigger conversion mode for  injected channels
: ADC2-CR2_JEXTSEL   ( %XXX -- ) 12 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_JEXTSEL    External event select for injected  group
: ADC2-CR2_ALIGN   %1 11 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_ALIGN    Data alignment
: ADC2-CR2_DMA   %1 8 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_DMA    Direct memory access mode
: ADC2-CR2_RSTCAL   %1 3 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_RSTCAL    Reset calibration
: ADC2-CR2_CAL   %1 2 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_CAL    A/D calibration
: ADC2-CR2_CONT   %1 1 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_CONT    Continuous conversion
: ADC2-CR2_ADON   %1 0 lshift ADC2-CR2 bis! ;  \ ADC2-CR2_ADON    A/D converter ON / OFF

\ ADC2-SMPR1 (read-write)
: ADC2-SMPR1_SMP10   ( %XXX -- ) 0 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP10    Channel 10 sample time  selection
: ADC2-SMPR1_SMP11   ( %XXX -- ) 3 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP11    Channel 11 sample time  selection
: ADC2-SMPR1_SMP12   ( %XXX -- ) 6 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP12    Channel 12 sample time  selection
: ADC2-SMPR1_SMP13   ( %XXX -- ) 9 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP13    Channel 13 sample time  selection
: ADC2-SMPR1_SMP14   ( %XXX -- ) 12 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP14    Channel 14 sample time  selection
: ADC2-SMPR1_SMP15   ( %XXX -- ) 15 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP15    Channel 15 sample time  selection
: ADC2-SMPR1_SMP16   ( %XXX -- ) 18 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP16    Channel 16 sample time  selection
: ADC2-SMPR1_SMP17   ( %XXX -- ) 21 lshift ADC2-SMPR1 bis! ;  \ ADC2-SMPR1_SMP17    Channel 17 sample time  selection

\ ADC2-SMPR2 (read-write)
: ADC2-SMPR2_SMP0   ( %XXX -- ) 0 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP0    Channel 0 sample time  selection
: ADC2-SMPR2_SMP1   ( %XXX -- ) 3 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP1    Channel 1 sample time  selection
: ADC2-SMPR2_SMP2   ( %XXX -- ) 6 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP2    Channel 2 sample time  selection
: ADC2-SMPR2_SMP3   ( %XXX -- ) 9 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP3    Channel 3 sample time  selection
: ADC2-SMPR2_SMP4   ( %XXX -- ) 12 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP4    Channel 4 sample time  selection
: ADC2-SMPR2_SMP5   ( %XXX -- ) 15 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP5    Channel 5 sample time  selection
: ADC2-SMPR2_SMP6   ( %XXX -- ) 18 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP6    Channel 6 sample time  selection
: ADC2-SMPR2_SMP7   ( %XXX -- ) 21 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP7    Channel 7 sample time  selection
: ADC2-SMPR2_SMP8   ( %XXX -- ) 24 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP8    Channel 8 sample time  selection
: ADC2-SMPR2_SMP9   ( %XXX -- ) 27 lshift ADC2-SMPR2 bis! ;  \ ADC2-SMPR2_SMP9    Channel 9 sample time  selection

\ ADC2-JOFR1 (read-write)
: ADC2-JOFR1_JOFFSET1   ( %XXXXXXXXXXX -- ) 0 lshift ADC2-JOFR1 bis! ;  \ ADC2-JOFR1_JOFFSET1    Data offset for injected channel  x

\ ADC2-JOFR2 (read-write)
: ADC2-JOFR2_JOFFSET2   ( %XXXXXXXXXXX -- ) 0 lshift ADC2-JOFR2 bis! ;  \ ADC2-JOFR2_JOFFSET2    Data offset for injected channel  x

\ ADC2-JOFR3 (read-write)
: ADC2-JOFR3_JOFFSET3   ( %XXXXXXXXXXX -- ) 0 lshift ADC2-JOFR3 bis! ;  \ ADC2-JOFR3_JOFFSET3    Data offset for injected channel  x

\ ADC2-JOFR4 (read-write)
: ADC2-JOFR4_JOFFSET4   ( %XXXXXXXXXXX -- ) 0 lshift ADC2-JOFR4 bis! ;  \ ADC2-JOFR4_JOFFSET4    Data offset for injected channel  x

\ ADC2-HTR (read-write)
: ADC2-HTR_HT   ( %XXXXXXXXXXX -- ) 0 lshift ADC2-HTR bis! ;  \ ADC2-HTR_HT    Analog watchdog higher  threshold

\ ADC2-LTR (read-write)
: ADC2-LTR_LT   ( %XXXXXXXXXXX -- ) 0 lshift ADC2-LTR bis! ;  \ ADC2-LTR_LT    Analog watchdog lower  threshold

\ ADC2-SQR1 (read-write)
: ADC2-SQR1_L   ( %XXXX -- ) 20 lshift ADC2-SQR1 bis! ;  \ ADC2-SQR1_L    Regular channel sequence  length
: ADC2-SQR1_SQ16   ( %XXXXX -- ) 15 lshift ADC2-SQR1 bis! ;  \ ADC2-SQR1_SQ16    16th conversion in regular  sequence
: ADC2-SQR1_SQ15   ( %XXXXX -- ) 10 lshift ADC2-SQR1 bis! ;  \ ADC2-SQR1_SQ15    15th conversion in regular  sequence
: ADC2-SQR1_SQ14   ( %XXXXX -- ) 5 lshift ADC2-SQR1 bis! ;  \ ADC2-SQR1_SQ14    14th conversion in regular  sequence
: ADC2-SQR1_SQ13   ( %XXXXX -- ) 0 lshift ADC2-SQR1 bis! ;  \ ADC2-SQR1_SQ13    13th conversion in regular  sequence

\ ADC2-SQR2 (read-write)
: ADC2-SQR2_SQ12   ( %XXXXX -- ) 25 lshift ADC2-SQR2 bis! ;  \ ADC2-SQR2_SQ12    12th conversion in regular  sequence
: ADC2-SQR2_SQ11   ( %XXXXX -- ) 20 lshift ADC2-SQR2 bis! ;  \ ADC2-SQR2_SQ11    11th conversion in regular  sequence
: ADC2-SQR2_SQ10   ( %XXXXX -- ) 15 lshift ADC2-SQR2 bis! ;  \ ADC2-SQR2_SQ10    10th conversion in regular  sequence
: ADC2-SQR2_SQ9   ( %XXXXX -- ) 10 lshift ADC2-SQR2 bis! ;  \ ADC2-SQR2_SQ9    9th conversion in regular  sequence
: ADC2-SQR2_SQ8   ( %XXXXX -- ) 5 lshift ADC2-SQR2 bis! ;  \ ADC2-SQR2_SQ8    8th conversion in regular  sequence
: ADC2-SQR2_SQ7   ( %XXXXX -- ) 0 lshift ADC2-SQR2 bis! ;  \ ADC2-SQR2_SQ7    7th conversion in regular  sequence

\ ADC2-SQR3 (read-write)
: ADC2-SQR3_SQ6   ( %XXXXX -- ) 25 lshift ADC2-SQR3 bis! ;  \ ADC2-SQR3_SQ6    6th conversion in regular  sequence
: ADC2-SQR3_SQ5   ( %XXXXX -- ) 20 lshift ADC2-SQR3 bis! ;  \ ADC2-SQR3_SQ5    5th conversion in regular  sequence
: ADC2-SQR3_SQ4   ( %XXXXX -- ) 15 lshift ADC2-SQR3 bis! ;  \ ADC2-SQR3_SQ4    4th conversion in regular  sequence
: ADC2-SQR3_SQ3   ( %XXXXX -- ) 10 lshift ADC2-SQR3 bis! ;  \ ADC2-SQR3_SQ3    3rd conversion in regular  sequence
: ADC2-SQR3_SQ2   ( %XXXXX -- ) 5 lshift ADC2-SQR3 bis! ;  \ ADC2-SQR3_SQ2    2nd conversion in regular  sequence
: ADC2-SQR3_SQ1   ( %XXXXX -- ) 0 lshift ADC2-SQR3 bis! ;  \ ADC2-SQR3_SQ1    1st conversion in regular  sequence

\ ADC2-JSQR (read-write)
: ADC2-JSQR_JL   ( %XX -- ) 20 lshift ADC2-JSQR bis! ;  \ ADC2-JSQR_JL    Injected sequence length
: ADC2-JSQR_JSQ4   ( %XXXXX -- ) 15 lshift ADC2-JSQR bis! ;  \ ADC2-JSQR_JSQ4    4th conversion in injected  sequence
: ADC2-JSQR_JSQ3   ( %XXXXX -- ) 10 lshift ADC2-JSQR bis! ;  \ ADC2-JSQR_JSQ3    3rd conversion in injected  sequence
: ADC2-JSQR_JSQ2   ( %XXXXX -- ) 5 lshift ADC2-JSQR bis! ;  \ ADC2-JSQR_JSQ2    2nd conversion in injected  sequence
: ADC2-JSQR_JSQ1   ( %XXXXX -- ) 0 lshift ADC2-JSQR bis! ;  \ ADC2-JSQR_JSQ1    1st conversion in injected  sequence

\ ADC2-JDR1 (read-only)
: ADC2-JDR1_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC2-JDR1 bis! ;  \ ADC2-JDR1_JDATA    Injected data

\ ADC2-JDR2 (read-only)
: ADC2-JDR2_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC2-JDR2 bis! ;  \ ADC2-JDR2_JDATA    Injected data

\ ADC2-JDR3 (read-only)
: ADC2-JDR3_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC2-JDR3 bis! ;  \ ADC2-JDR3_JDATA    Injected data

\ ADC2-JDR4 (read-only)
: ADC2-JDR4_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC2-JDR4 bis! ;  \ ADC2-JDR4_JDATA    Injected data

\ ADC2-DR (read-only)
: ADC2-DR_DATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC2-DR bis! ;  \ ADC2-DR_DATA    Regular data

\ ADC3-SR (read-write)
: ADC3-SR_STRT   %1 4 lshift ADC3-SR bis! ;  \ ADC3-SR_STRT    Regular channel start flag
: ADC3-SR_JSTRT   %1 3 lshift ADC3-SR bis! ;  \ ADC3-SR_JSTRT    Injected channel start  flag
: ADC3-SR_JEOC   %1 2 lshift ADC3-SR bis! ;  \ ADC3-SR_JEOC    Injected channel end of  conversion
: ADC3-SR_EOC   %1 1 lshift ADC3-SR bis! ;  \ ADC3-SR_EOC    Regular channel end of  conversion
: ADC3-SR_AWD   %1 0 lshift ADC3-SR bis! ;  \ ADC3-SR_AWD    Analog watchdog flag

\ ADC3-CR1 (read-write)
: ADC3-CR1_AWDEN   %1 23 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_AWDEN    Analog watchdog enable on regular  channels
: ADC3-CR1_JAWDEN   %1 22 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_JAWDEN    Analog watchdog enable on injected  channels
: ADC3-CR1_DISCNUM   ( %XXX -- ) 13 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_DISCNUM    Discontinuous mode channel  count
: ADC3-CR1_JDISCEN   %1 12 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_JDISCEN    Discontinuous mode on injected  channels
: ADC3-CR1_DISCEN   %1 11 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_DISCEN    Discontinuous mode on regular  channels
: ADC3-CR1_JAUTO   %1 10 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_JAUTO    Automatic injected group  conversion
: ADC3-CR1_AWDSGL   %1 9 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_AWDSGL    Enable the watchdog on a single channel  in scan mode
: ADC3-CR1_SCAN   %1 8 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_SCAN    Scan mode
: ADC3-CR1_JEOCIE   %1 7 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_JEOCIE    Interrupt enable for injected  channels
: ADC3-CR1_AWDIE   %1 6 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_AWDIE    Analog watchdog interrupt  enable
: ADC3-CR1_EOCIE   %1 5 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_EOCIE    Interrupt enable for EOC
: ADC3-CR1_AWDCH   ( %XXXXX -- ) 0 lshift ADC3-CR1 bis! ;  \ ADC3-CR1_AWDCH    Analog watchdog channel select  bits

\ ADC3-CR2 (read-write)
: ADC3-CR2_TSVREFE   %1 23 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_TSVREFE    Temperature sensor and VREFINT  enable
: ADC3-CR2_SWSTART   %1 22 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_SWSTART    Start conversion of regular  channels
: ADC3-CR2_JSWSTART   %1 21 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_JSWSTART    Start conversion of injected  channels
: ADC3-CR2_EXTTRIG   %1 20 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_EXTTRIG    External trigger conversion mode for  regular channels
: ADC3-CR2_EXTSEL   ( %XXX -- ) 17 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_EXTSEL    External event select for regular  group
: ADC3-CR2_JEXTTRIG   %1 15 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_JEXTTRIG    External trigger conversion mode for  injected channels
: ADC3-CR2_JEXTSEL   ( %XXX -- ) 12 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_JEXTSEL    External event select for injected  group
: ADC3-CR2_ALIGN   %1 11 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_ALIGN    Data alignment
: ADC3-CR2_DMA   %1 8 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_DMA    Direct memory access mode
: ADC3-CR2_RSTCAL   %1 3 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_RSTCAL    Reset calibration
: ADC3-CR2_CAL   %1 2 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_CAL    A/D calibration
: ADC3-CR2_CONT   %1 1 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_CONT    Continuous conversion
: ADC3-CR2_ADON   %1 0 lshift ADC3-CR2 bis! ;  \ ADC3-CR2_ADON    A/D converter ON / OFF

\ ADC3-SMPR1 (read-write)
: ADC3-SMPR1_SMP10   ( %XXX -- ) 0 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP10    Channel 10 sample time  selection
: ADC3-SMPR1_SMP11   ( %XXX -- ) 3 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP11    Channel 11 sample time  selection
: ADC3-SMPR1_SMP12   ( %XXX -- ) 6 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP12    Channel 12 sample time  selection
: ADC3-SMPR1_SMP13   ( %XXX -- ) 9 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP13    Channel 13 sample time  selection
: ADC3-SMPR1_SMP14   ( %XXX -- ) 12 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP14    Channel 14 sample time  selection
: ADC3-SMPR1_SMP15   ( %XXX -- ) 15 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP15    Channel 15 sample time  selection
: ADC3-SMPR1_SMP16   ( %XXX -- ) 18 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP16    Channel 16 sample time  selection
: ADC3-SMPR1_SMP17   ( %XXX -- ) 21 lshift ADC3-SMPR1 bis! ;  \ ADC3-SMPR1_SMP17    Channel 17 sample time  selection

\ ADC3-SMPR2 (read-write)
: ADC3-SMPR2_SMP0   ( %XXX -- ) 0 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP0    Channel 0 sample time  selection
: ADC3-SMPR2_SMP1   ( %XXX -- ) 3 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP1    Channel 1 sample time  selection
: ADC3-SMPR2_SMP2   ( %XXX -- ) 6 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP2    Channel 2 sample time  selection
: ADC3-SMPR2_SMP3   ( %XXX -- ) 9 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP3    Channel 3 sample time  selection
: ADC3-SMPR2_SMP4   ( %XXX -- ) 12 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP4    Channel 4 sample time  selection
: ADC3-SMPR2_SMP5   ( %XXX -- ) 15 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP5    Channel 5 sample time  selection
: ADC3-SMPR2_SMP6   ( %XXX -- ) 18 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP6    Channel 6 sample time  selection
: ADC3-SMPR2_SMP7   ( %XXX -- ) 21 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP7    Channel 7 sample time  selection
: ADC3-SMPR2_SMP8   ( %XXX -- ) 24 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP8    Channel 8 sample time  selection
: ADC3-SMPR2_SMP9   ( %XXX -- ) 27 lshift ADC3-SMPR2 bis! ;  \ ADC3-SMPR2_SMP9    Channel 9 sample time  selection

\ ADC3-JOFR1 (read-write)
: ADC3-JOFR1_JOFFSET1   ( %XXXXXXXXXXX -- ) 0 lshift ADC3-JOFR1 bis! ;  \ ADC3-JOFR1_JOFFSET1    Data offset for injected channel  x

\ ADC3-JOFR2 (read-write)
: ADC3-JOFR2_JOFFSET2   ( %XXXXXXXXXXX -- ) 0 lshift ADC3-JOFR2 bis! ;  \ ADC3-JOFR2_JOFFSET2    Data offset for injected channel  x

\ ADC3-JOFR3 (read-write)
: ADC3-JOFR3_JOFFSET3   ( %XXXXXXXXXXX -- ) 0 lshift ADC3-JOFR3 bis! ;  \ ADC3-JOFR3_JOFFSET3    Data offset for injected channel  x

\ ADC3-JOFR4 (read-write)
: ADC3-JOFR4_JOFFSET4   ( %XXXXXXXXXXX -- ) 0 lshift ADC3-JOFR4 bis! ;  \ ADC3-JOFR4_JOFFSET4    Data offset for injected channel  x

\ ADC3-HTR (read-write)
: ADC3-HTR_HT   ( %XXXXXXXXXXX -- ) 0 lshift ADC3-HTR bis! ;  \ ADC3-HTR_HT    Analog watchdog higher  threshold

\ ADC3-LTR (read-write)
: ADC3-LTR_LT   ( %XXXXXXXXXXX -- ) 0 lshift ADC3-LTR bis! ;  \ ADC3-LTR_LT    Analog watchdog lower  threshold

\ ADC3-SQR1 (read-write)
: ADC3-SQR1_L   ( %XXXX -- ) 20 lshift ADC3-SQR1 bis! ;  \ ADC3-SQR1_L    Regular channel sequence  length
: ADC3-SQR1_SQ16   ( %XXXXX -- ) 15 lshift ADC3-SQR1 bis! ;  \ ADC3-SQR1_SQ16    16th conversion in regular  sequence
: ADC3-SQR1_SQ15   ( %XXXXX -- ) 10 lshift ADC3-SQR1 bis! ;  \ ADC3-SQR1_SQ15    15th conversion in regular  sequence
: ADC3-SQR1_SQ14   ( %XXXXX -- ) 5 lshift ADC3-SQR1 bis! ;  \ ADC3-SQR1_SQ14    14th conversion in regular  sequence
: ADC3-SQR1_SQ13   ( %XXXXX -- ) 0 lshift ADC3-SQR1 bis! ;  \ ADC3-SQR1_SQ13    13th conversion in regular  sequence

\ ADC3-SQR2 (read-write)
: ADC3-SQR2_SQ12   ( %XXXXX -- ) 25 lshift ADC3-SQR2 bis! ;  \ ADC3-SQR2_SQ12    12th conversion in regular  sequence
: ADC3-SQR2_SQ11   ( %XXXXX -- ) 20 lshift ADC3-SQR2 bis! ;  \ ADC3-SQR2_SQ11    11th conversion in regular  sequence
: ADC3-SQR2_SQ10   ( %XXXXX -- ) 15 lshift ADC3-SQR2 bis! ;  \ ADC3-SQR2_SQ10    10th conversion in regular  sequence
: ADC3-SQR2_SQ9   ( %XXXXX -- ) 10 lshift ADC3-SQR2 bis! ;  \ ADC3-SQR2_SQ9    9th conversion in regular  sequence
: ADC3-SQR2_SQ8   ( %XXXXX -- ) 5 lshift ADC3-SQR2 bis! ;  \ ADC3-SQR2_SQ8    8th conversion in regular  sequence
: ADC3-SQR2_SQ7   ( %XXXXX -- ) 0 lshift ADC3-SQR2 bis! ;  \ ADC3-SQR2_SQ7    7th conversion in regular  sequence

\ ADC3-SQR3 (read-write)
: ADC3-SQR3_SQ6   ( %XXXXX -- ) 25 lshift ADC3-SQR3 bis! ;  \ ADC3-SQR3_SQ6    6th conversion in regular  sequence
: ADC3-SQR3_SQ5   ( %XXXXX -- ) 20 lshift ADC3-SQR3 bis! ;  \ ADC3-SQR3_SQ5    5th conversion in regular  sequence
: ADC3-SQR3_SQ4   ( %XXXXX -- ) 15 lshift ADC3-SQR3 bis! ;  \ ADC3-SQR3_SQ4    4th conversion in regular  sequence
: ADC3-SQR3_SQ3   ( %XXXXX -- ) 10 lshift ADC3-SQR3 bis! ;  \ ADC3-SQR3_SQ3    3rd conversion in regular  sequence
: ADC3-SQR3_SQ2   ( %XXXXX -- ) 5 lshift ADC3-SQR3 bis! ;  \ ADC3-SQR3_SQ2    2nd conversion in regular  sequence
: ADC3-SQR3_SQ1   ( %XXXXX -- ) 0 lshift ADC3-SQR3 bis! ;  \ ADC3-SQR3_SQ1    1st conversion in regular  sequence

\ ADC3-JSQR (read-write)
: ADC3-JSQR_JL   ( %XX -- ) 20 lshift ADC3-JSQR bis! ;  \ ADC3-JSQR_JL    Injected sequence length
: ADC3-JSQR_JSQ4   ( %XXXXX -- ) 15 lshift ADC3-JSQR bis! ;  \ ADC3-JSQR_JSQ4    4th conversion in injected  sequence
: ADC3-JSQR_JSQ3   ( %XXXXX -- ) 10 lshift ADC3-JSQR bis! ;  \ ADC3-JSQR_JSQ3    3rd conversion in injected  sequence
: ADC3-JSQR_JSQ2   ( %XXXXX -- ) 5 lshift ADC3-JSQR bis! ;  \ ADC3-JSQR_JSQ2    2nd conversion in injected  sequence
: ADC3-JSQR_JSQ1   ( %XXXXX -- ) 0 lshift ADC3-JSQR bis! ;  \ ADC3-JSQR_JSQ1    1st conversion in injected  sequence

\ ADC3-JDR1 (read-only)
: ADC3-JDR1_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC3-JDR1 bis! ;  \ ADC3-JDR1_JDATA    Injected data

\ ADC3-JDR2 (read-only)
: ADC3-JDR2_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC3-JDR2 bis! ;  \ ADC3-JDR2_JDATA    Injected data

\ ADC3-JDR3 (read-only)
: ADC3-JDR3_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC3-JDR3 bis! ;  \ ADC3-JDR3_JDATA    Injected data

\ ADC3-JDR4 (read-only)
: ADC3-JDR4_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC3-JDR4 bis! ;  \ ADC3-JDR4_JDATA    Injected data

\ ADC3-DR (read-only)
: ADC3-DR_DATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC3-DR bis! ;  \ ADC3-DR_DATA    Regular data

\ CAN-CAN_MCR (read-write)
: CAN-CAN_MCR_DBF   %1 16 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_DBF    DBF
: CAN-CAN_MCR_RESET   %1 15 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_RESET    RESET
: CAN-CAN_MCR_TTCM   %1 7 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_TTCM    TTCM
: CAN-CAN_MCR_ABOM   %1 6 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_ABOM    ABOM
: CAN-CAN_MCR_AWUM   %1 5 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_AWUM    AWUM
: CAN-CAN_MCR_NART   %1 4 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_NART    NART
: CAN-CAN_MCR_RFLM   %1 3 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_RFLM    RFLM
: CAN-CAN_MCR_TXFP   %1 2 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_TXFP    TXFP
: CAN-CAN_MCR_SLEEP   %1 1 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_SLEEP    SLEEP
: CAN-CAN_MCR_INRQ   %1 0 lshift CAN-CAN_MCR bis! ;  \ CAN-CAN_MCR_INRQ    INRQ

\ CAN-CAN_MSR ()
: CAN-CAN_MSR_RX   %1 11 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_RX    RX
: CAN-CAN_MSR_SAMP   %1 10 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_SAMP    SAMP
: CAN-CAN_MSR_RXM   %1 9 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_RXM    RXM
: CAN-CAN_MSR_TXM   %1 8 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_TXM    TXM
: CAN-CAN_MSR_SLAKI   %1 4 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_SLAKI    SLAKI
: CAN-CAN_MSR_WKUI   %1 3 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_WKUI    WKUI
: CAN-CAN_MSR_ERRI   %1 2 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_ERRI    ERRI
: CAN-CAN_MSR_SLAK   %1 1 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_SLAK    SLAK
: CAN-CAN_MSR_INAK   %1 0 lshift CAN-CAN_MSR bis! ;  \ CAN-CAN_MSR_INAK    INAK

\ CAN-CAN_TSR ()
: CAN-CAN_TSR_LOW2   %1 31 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_LOW2    Lowest priority flag for mailbox  2
: CAN-CAN_TSR_LOW1   %1 30 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_LOW1    Lowest priority flag for mailbox  1
: CAN-CAN_TSR_LOW0   %1 29 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_LOW0    Lowest priority flag for mailbox  0
: CAN-CAN_TSR_TME2   %1 28 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TME2    Lowest priority flag for mailbox  2
: CAN-CAN_TSR_TME1   %1 27 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TME1    Lowest priority flag for mailbox  1
: CAN-CAN_TSR_TME0   %1 26 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TME0    Lowest priority flag for mailbox  0
: CAN-CAN_TSR_CODE   ( %XX -- ) 24 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_CODE    CODE
: CAN-CAN_TSR_ABRQ2   %1 23 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_ABRQ2    ABRQ2
: CAN-CAN_TSR_TERR2   %1 19 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TERR2    TERR2
: CAN-CAN_TSR_ALST2   %1 18 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_ALST2    ALST2
: CAN-CAN_TSR_TXOK2   %1 17 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TXOK2    TXOK2
: CAN-CAN_TSR_RQCP2   %1 16 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_RQCP2    RQCP2
: CAN-CAN_TSR_ABRQ1   %1 15 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_ABRQ1    ABRQ1
: CAN-CAN_TSR_TERR1   %1 11 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TERR1    TERR1
: CAN-CAN_TSR_ALST1   %1 10 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_ALST1    ALST1
: CAN-CAN_TSR_TXOK1   %1 9 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TXOK1    TXOK1
: CAN-CAN_TSR_RQCP1   %1 8 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_RQCP1    RQCP1
: CAN-CAN_TSR_ABRQ0   %1 7 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_ABRQ0    ABRQ0
: CAN-CAN_TSR_TERR0   %1 3 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TERR0    TERR0
: CAN-CAN_TSR_ALST0   %1 2 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_ALST0    ALST0
: CAN-CAN_TSR_TXOK0   %1 1 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_TXOK0    TXOK0
: CAN-CAN_TSR_RQCP0   %1 0 lshift CAN-CAN_TSR bis! ;  \ CAN-CAN_TSR_RQCP0    RQCP0

\ CAN-CAN_RF0R ()
: CAN-CAN_RF0R_RFOM0   %1 5 lshift CAN-CAN_RF0R bis! ;  \ CAN-CAN_RF0R_RFOM0    RFOM0
: CAN-CAN_RF0R_FOVR0   %1 4 lshift CAN-CAN_RF0R bis! ;  \ CAN-CAN_RF0R_FOVR0    FOVR0
: CAN-CAN_RF0R_FULL0   %1 3 lshift CAN-CAN_RF0R bis! ;  \ CAN-CAN_RF0R_FULL0    FULL0
: CAN-CAN_RF0R_FMP0   ( %XX -- ) 0 lshift CAN-CAN_RF0R bis! ;  \ CAN-CAN_RF0R_FMP0    FMP0

\ CAN-CAN_RF1R ()
: CAN-CAN_RF1R_RFOM1   %1 5 lshift CAN-CAN_RF1R bis! ;  \ CAN-CAN_RF1R_RFOM1    RFOM1
: CAN-CAN_RF1R_FOVR1   %1 4 lshift CAN-CAN_RF1R bis! ;  \ CAN-CAN_RF1R_FOVR1    FOVR1
: CAN-CAN_RF1R_FULL1   %1 3 lshift CAN-CAN_RF1R bis! ;  \ CAN-CAN_RF1R_FULL1    FULL1
: CAN-CAN_RF1R_FMP1   ( %XX -- ) 0 lshift CAN-CAN_RF1R bis! ;  \ CAN-CAN_RF1R_FMP1    FMP1

\ CAN-CAN_IER (read-write)
: CAN-CAN_IER_SLKIE   %1 17 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_SLKIE    SLKIE
: CAN-CAN_IER_WKUIE   %1 16 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_WKUIE    WKUIE
: CAN-CAN_IER_ERRIE   %1 15 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_ERRIE    ERRIE
: CAN-CAN_IER_LECIE   %1 11 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_LECIE    LECIE
: CAN-CAN_IER_BOFIE   %1 10 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_BOFIE    BOFIE
: CAN-CAN_IER_EPVIE   %1 9 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_EPVIE    EPVIE
: CAN-CAN_IER_EWGIE   %1 8 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_EWGIE    EWGIE
: CAN-CAN_IER_FOVIE1   %1 6 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_FOVIE1    FOVIE1
: CAN-CAN_IER_FFIE1   %1 5 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_FFIE1    FFIE1
: CAN-CAN_IER_FMPIE1   %1 4 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_FMPIE1    FMPIE1
: CAN-CAN_IER_FOVIE0   %1 3 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_FOVIE0    FOVIE0
: CAN-CAN_IER_FFIE0   %1 2 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_FFIE0    FFIE0
: CAN-CAN_IER_FMPIE0   %1 1 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_FMPIE0    FMPIE0
: CAN-CAN_IER_TMEIE   %1 0 lshift CAN-CAN_IER bis! ;  \ CAN-CAN_IER_TMEIE    TMEIE

\ CAN-CAN_ESR ()
: CAN-CAN_ESR_REC   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_ESR bis! ;  \ CAN-CAN_ESR_REC    REC
: CAN-CAN_ESR_TEC   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_ESR bis! ;  \ CAN-CAN_ESR_TEC    TEC
: CAN-CAN_ESR_LEC   ( %XXX -- ) 4 lshift CAN-CAN_ESR bis! ;  \ CAN-CAN_ESR_LEC    LEC
: CAN-CAN_ESR_BOFF   %1 2 lshift CAN-CAN_ESR bis! ;  \ CAN-CAN_ESR_BOFF    BOFF
: CAN-CAN_ESR_EPVF   %1 1 lshift CAN-CAN_ESR bis! ;  \ CAN-CAN_ESR_EPVF    EPVF
: CAN-CAN_ESR_EWGF   %1 0 lshift CAN-CAN_ESR bis! ;  \ CAN-CAN_ESR_EWGF    EWGF

\ CAN-CAN_BTR (read-write)
: CAN-CAN_BTR_SILM   %1 31 lshift CAN-CAN_BTR bis! ;  \ CAN-CAN_BTR_SILM    SILM
: CAN-CAN_BTR_LBKM   %1 30 lshift CAN-CAN_BTR bis! ;  \ CAN-CAN_BTR_LBKM    LBKM
: CAN-CAN_BTR_SJW   ( %XX -- ) 24 lshift CAN-CAN_BTR bis! ;  \ CAN-CAN_BTR_SJW    SJW
: CAN-CAN_BTR_TS2   ( %XXX -- ) 20 lshift CAN-CAN_BTR bis! ;  \ CAN-CAN_BTR_TS2    TS2
: CAN-CAN_BTR_TS1   ( %XXXX -- ) 16 lshift CAN-CAN_BTR bis! ;  \ CAN-CAN_BTR_TS1    TS1
: CAN-CAN_BTR_BRP  0 lshift CAN-CAN_BTR bis! ;  \ CAN-CAN_BTR_BRP    BRP

\ CAN-CAN_TI0R (read-write)
: CAN-CAN_TI0R_STID  21 lshift CAN-CAN_TI0R bis! ;  \ CAN-CAN_TI0R_STID    STID
: CAN-CAN_TI0R_EXID  3 lshift CAN-CAN_TI0R bis! ;  \ CAN-CAN_TI0R_EXID    EXID
: CAN-CAN_TI0R_IDE   %1 2 lshift CAN-CAN_TI0R bis! ;  \ CAN-CAN_TI0R_IDE    IDE
: CAN-CAN_TI0R_RTR   %1 1 lshift CAN-CAN_TI0R bis! ;  \ CAN-CAN_TI0R_RTR    RTR
: CAN-CAN_TI0R_TXRQ   %1 0 lshift CAN-CAN_TI0R bis! ;  \ CAN-CAN_TI0R_TXRQ    TXRQ

\ CAN-CAN_TDT0R (read-write)
: CAN-CAN_TDT0R_TIME   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift CAN-CAN_TDT0R bis! ;  \ CAN-CAN_TDT0R_TIME    TIME
: CAN-CAN_TDT0R_TGT   %1 8 lshift CAN-CAN_TDT0R bis! ;  \ CAN-CAN_TDT0R_TGT    TGT
: CAN-CAN_TDT0R_DLC   ( %XXXX -- ) 0 lshift CAN-CAN_TDT0R bis! ;  \ CAN-CAN_TDT0R_DLC    DLC

\ CAN-CAN_TDL0R (read-write)
: CAN-CAN_TDL0R_DATA3   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_TDL0R bis! ;  \ CAN-CAN_TDL0R_DATA3    DATA3
: CAN-CAN_TDL0R_DATA2   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_TDL0R bis! ;  \ CAN-CAN_TDL0R_DATA2    DATA2
: CAN-CAN_TDL0R_DATA1   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_TDL0R bis! ;  \ CAN-CAN_TDL0R_DATA1    DATA1
: CAN-CAN_TDL0R_DATA0   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_TDL0R bis! ;  \ CAN-CAN_TDL0R_DATA0    DATA0

\ CAN-CAN_TDH0R (read-write)
: CAN-CAN_TDH0R_DATA7   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_TDH0R bis! ;  \ CAN-CAN_TDH0R_DATA7    DATA7
: CAN-CAN_TDH0R_DATA6   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_TDH0R bis! ;  \ CAN-CAN_TDH0R_DATA6    DATA6
: CAN-CAN_TDH0R_DATA5   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_TDH0R bis! ;  \ CAN-CAN_TDH0R_DATA5    DATA5
: CAN-CAN_TDH0R_DATA4   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_TDH0R bis! ;  \ CAN-CAN_TDH0R_DATA4    DATA4

\ CAN-CAN_TI1R (read-write)
: CAN-CAN_TI1R_STID  21 lshift CAN-CAN_TI1R bis! ;  \ CAN-CAN_TI1R_STID    STID
: CAN-CAN_TI1R_EXID  3 lshift CAN-CAN_TI1R bis! ;  \ CAN-CAN_TI1R_EXID    EXID
: CAN-CAN_TI1R_IDE   %1 2 lshift CAN-CAN_TI1R bis! ;  \ CAN-CAN_TI1R_IDE    IDE
: CAN-CAN_TI1R_RTR   %1 1 lshift CAN-CAN_TI1R bis! ;  \ CAN-CAN_TI1R_RTR    RTR
: CAN-CAN_TI1R_TXRQ   %1 0 lshift CAN-CAN_TI1R bis! ;  \ CAN-CAN_TI1R_TXRQ    TXRQ

\ CAN-CAN_TDT1R (read-write)
: CAN-CAN_TDT1R_TIME   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift CAN-CAN_TDT1R bis! ;  \ CAN-CAN_TDT1R_TIME    TIME
: CAN-CAN_TDT1R_TGT   %1 8 lshift CAN-CAN_TDT1R bis! ;  \ CAN-CAN_TDT1R_TGT    TGT
: CAN-CAN_TDT1R_DLC   ( %XXXX -- ) 0 lshift CAN-CAN_TDT1R bis! ;  \ CAN-CAN_TDT1R_DLC    DLC

\ CAN-CAN_TDL1R (read-write)
: CAN-CAN_TDL1R_DATA3   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_TDL1R bis! ;  \ CAN-CAN_TDL1R_DATA3    DATA3
: CAN-CAN_TDL1R_DATA2   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_TDL1R bis! ;  \ CAN-CAN_TDL1R_DATA2    DATA2
: CAN-CAN_TDL1R_DATA1   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_TDL1R bis! ;  \ CAN-CAN_TDL1R_DATA1    DATA1
: CAN-CAN_TDL1R_DATA0   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_TDL1R bis! ;  \ CAN-CAN_TDL1R_DATA0    DATA0

\ CAN-CAN_TDH1R (read-write)
: CAN-CAN_TDH1R_DATA7   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_TDH1R bis! ;  \ CAN-CAN_TDH1R_DATA7    DATA7
: CAN-CAN_TDH1R_DATA6   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_TDH1R bis! ;  \ CAN-CAN_TDH1R_DATA6    DATA6
: CAN-CAN_TDH1R_DATA5   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_TDH1R bis! ;  \ CAN-CAN_TDH1R_DATA5    DATA5
: CAN-CAN_TDH1R_DATA4   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_TDH1R bis! ;  \ CAN-CAN_TDH1R_DATA4    DATA4

\ CAN-CAN_TI2R (read-write)
: CAN-CAN_TI2R_STID  21 lshift CAN-CAN_TI2R bis! ;  \ CAN-CAN_TI2R_STID    STID
: CAN-CAN_TI2R_EXID  3 lshift CAN-CAN_TI2R bis! ;  \ CAN-CAN_TI2R_EXID    EXID
: CAN-CAN_TI2R_IDE   %1 2 lshift CAN-CAN_TI2R bis! ;  \ CAN-CAN_TI2R_IDE    IDE
: CAN-CAN_TI2R_RTR   %1 1 lshift CAN-CAN_TI2R bis! ;  \ CAN-CAN_TI2R_RTR    RTR
: CAN-CAN_TI2R_TXRQ   %1 0 lshift CAN-CAN_TI2R bis! ;  \ CAN-CAN_TI2R_TXRQ    TXRQ

\ CAN-CAN_TDT2R (read-write)
: CAN-CAN_TDT2R_TIME   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift CAN-CAN_TDT2R bis! ;  \ CAN-CAN_TDT2R_TIME    TIME
: CAN-CAN_TDT2R_TGT   %1 8 lshift CAN-CAN_TDT2R bis! ;  \ CAN-CAN_TDT2R_TGT    TGT
: CAN-CAN_TDT2R_DLC   ( %XXXX -- ) 0 lshift CAN-CAN_TDT2R bis! ;  \ CAN-CAN_TDT2R_DLC    DLC

\ CAN-CAN_TDL2R (read-write)
: CAN-CAN_TDL2R_DATA3   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_TDL2R bis! ;  \ CAN-CAN_TDL2R_DATA3    DATA3
: CAN-CAN_TDL2R_DATA2   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_TDL2R bis! ;  \ CAN-CAN_TDL2R_DATA2    DATA2
: CAN-CAN_TDL2R_DATA1   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_TDL2R bis! ;  \ CAN-CAN_TDL2R_DATA1    DATA1
: CAN-CAN_TDL2R_DATA0   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_TDL2R bis! ;  \ CAN-CAN_TDL2R_DATA0    DATA0

\ CAN-CAN_TDH2R (read-write)
: CAN-CAN_TDH2R_DATA7   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_TDH2R bis! ;  \ CAN-CAN_TDH2R_DATA7    DATA7
: CAN-CAN_TDH2R_DATA6   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_TDH2R bis! ;  \ CAN-CAN_TDH2R_DATA6    DATA6
: CAN-CAN_TDH2R_DATA5   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_TDH2R bis! ;  \ CAN-CAN_TDH2R_DATA5    DATA5
: CAN-CAN_TDH2R_DATA4   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_TDH2R bis! ;  \ CAN-CAN_TDH2R_DATA4    DATA4

\ CAN-CAN_RI0R (read-only)
: CAN-CAN_RI0R_STID  21 lshift CAN-CAN_RI0R bis! ;  \ CAN-CAN_RI0R_STID    STID
: CAN-CAN_RI0R_EXID  3 lshift CAN-CAN_RI0R bis! ;  \ CAN-CAN_RI0R_EXID    EXID
: CAN-CAN_RI0R_IDE   %1 2 lshift CAN-CAN_RI0R bis! ;  \ CAN-CAN_RI0R_IDE    IDE
: CAN-CAN_RI0R_RTR   %1 1 lshift CAN-CAN_RI0R bis! ;  \ CAN-CAN_RI0R_RTR    RTR

\ CAN-CAN_RDT0R (read-only)
: CAN-CAN_RDT0R_TIME   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift CAN-CAN_RDT0R bis! ;  \ CAN-CAN_RDT0R_TIME    TIME
: CAN-CAN_RDT0R_FMI   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_RDT0R bis! ;  \ CAN-CAN_RDT0R_FMI    FMI
: CAN-CAN_RDT0R_DLC   ( %XXXX -- ) 0 lshift CAN-CAN_RDT0R bis! ;  \ CAN-CAN_RDT0R_DLC    DLC

\ CAN-CAN_RDL0R (read-only)
: CAN-CAN_RDL0R_DATA3   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_RDL0R bis! ;  \ CAN-CAN_RDL0R_DATA3    DATA3
: CAN-CAN_RDL0R_DATA2   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_RDL0R bis! ;  \ CAN-CAN_RDL0R_DATA2    DATA2
: CAN-CAN_RDL0R_DATA1   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_RDL0R bis! ;  \ CAN-CAN_RDL0R_DATA1    DATA1
: CAN-CAN_RDL0R_DATA0   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_RDL0R bis! ;  \ CAN-CAN_RDL0R_DATA0    DATA0

\ CAN-CAN_RDH0R (read-only)
: CAN-CAN_RDH0R_DATA7   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_RDH0R bis! ;  \ CAN-CAN_RDH0R_DATA7    DATA7
: CAN-CAN_RDH0R_DATA6   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_RDH0R bis! ;  \ CAN-CAN_RDH0R_DATA6    DATA6
: CAN-CAN_RDH0R_DATA5   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_RDH0R bis! ;  \ CAN-CAN_RDH0R_DATA5    DATA5
: CAN-CAN_RDH0R_DATA4   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_RDH0R bis! ;  \ CAN-CAN_RDH0R_DATA4    DATA4

\ CAN-CAN_RI1R (read-only)
: CAN-CAN_RI1R_STID  21 lshift CAN-CAN_RI1R bis! ;  \ CAN-CAN_RI1R_STID    STID
: CAN-CAN_RI1R_EXID  3 lshift CAN-CAN_RI1R bis! ;  \ CAN-CAN_RI1R_EXID    EXID
: CAN-CAN_RI1R_IDE   %1 2 lshift CAN-CAN_RI1R bis! ;  \ CAN-CAN_RI1R_IDE    IDE
: CAN-CAN_RI1R_RTR   %1 1 lshift CAN-CAN_RI1R bis! ;  \ CAN-CAN_RI1R_RTR    RTR

\ CAN-CAN_RDT1R (read-only)
: CAN-CAN_RDT1R_TIME   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift CAN-CAN_RDT1R bis! ;  \ CAN-CAN_RDT1R_TIME    TIME
: CAN-CAN_RDT1R_FMI   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_RDT1R bis! ;  \ CAN-CAN_RDT1R_FMI    FMI
: CAN-CAN_RDT1R_DLC   ( %XXXX -- ) 0 lshift CAN-CAN_RDT1R bis! ;  \ CAN-CAN_RDT1R_DLC    DLC

\ CAN-CAN_RDL1R (read-only)
: CAN-CAN_RDL1R_DATA3   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_RDL1R bis! ;  \ CAN-CAN_RDL1R_DATA3    DATA3
: CAN-CAN_RDL1R_DATA2   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_RDL1R bis! ;  \ CAN-CAN_RDL1R_DATA2    DATA2
: CAN-CAN_RDL1R_DATA1   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_RDL1R bis! ;  \ CAN-CAN_RDL1R_DATA1    DATA1
: CAN-CAN_RDL1R_DATA0   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_RDL1R bis! ;  \ CAN-CAN_RDL1R_DATA0    DATA0

\ CAN-CAN_RDH1R (read-only)
: CAN-CAN_RDH1R_DATA7   ( %XXXXXXXX -- ) 24 lshift CAN-CAN_RDH1R bis! ;  \ CAN-CAN_RDH1R_DATA7    DATA7
: CAN-CAN_RDH1R_DATA6   ( %XXXXXXXX -- ) 16 lshift CAN-CAN_RDH1R bis! ;  \ CAN-CAN_RDH1R_DATA6    DATA6
: CAN-CAN_RDH1R_DATA5   ( %XXXXXXXX -- ) 8 lshift CAN-CAN_RDH1R bis! ;  \ CAN-CAN_RDH1R_DATA5    DATA5
: CAN-CAN_RDH1R_DATA4   ( %XXXXXXXX -- ) 0 lshift CAN-CAN_RDH1R bis! ;  \ CAN-CAN_RDH1R_DATA4    DATA4

\ CAN-CAN_FMR (read-write)
: CAN-CAN_FMR_FINIT   %1 0 lshift CAN-CAN_FMR bis! ;  \ CAN-CAN_FMR_FINIT    FINIT

\ CAN-CAN_FM1R (read-write)
: CAN-CAN_FM1R_FBM0   %1 0 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM0    Filter mode
: CAN-CAN_FM1R_FBM1   %1 1 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM1    Filter mode
: CAN-CAN_FM1R_FBM2   %1 2 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM2    Filter mode
: CAN-CAN_FM1R_FBM3   %1 3 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM3    Filter mode
: CAN-CAN_FM1R_FBM4   %1 4 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM4    Filter mode
: CAN-CAN_FM1R_FBM5   %1 5 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM5    Filter mode
: CAN-CAN_FM1R_FBM6   %1 6 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM6    Filter mode
: CAN-CAN_FM1R_FBM7   %1 7 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM7    Filter mode
: CAN-CAN_FM1R_FBM8   %1 8 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM8    Filter mode
: CAN-CAN_FM1R_FBM9   %1 9 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM9    Filter mode
: CAN-CAN_FM1R_FBM10   %1 10 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM10    Filter mode
: CAN-CAN_FM1R_FBM11   %1 11 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM11    Filter mode
: CAN-CAN_FM1R_FBM12   %1 12 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM12    Filter mode
: CAN-CAN_FM1R_FBM13   %1 13 lshift CAN-CAN_FM1R bis! ;  \ CAN-CAN_FM1R_FBM13    Filter mode

\ CAN-CAN_FS1R (read-write)
: CAN-CAN_FS1R_FSC0   %1 0 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC0    Filter scale configuration
: CAN-CAN_FS1R_FSC1   %1 1 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC1    Filter scale configuration
: CAN-CAN_FS1R_FSC2   %1 2 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC2    Filter scale configuration
: CAN-CAN_FS1R_FSC3   %1 3 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC3    Filter scale configuration
: CAN-CAN_FS1R_FSC4   %1 4 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC4    Filter scale configuration
: CAN-CAN_FS1R_FSC5   %1 5 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC5    Filter scale configuration
: CAN-CAN_FS1R_FSC6   %1 6 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC6    Filter scale configuration
: CAN-CAN_FS1R_FSC7   %1 7 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC7    Filter scale configuration
: CAN-CAN_FS1R_FSC8   %1 8 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC8    Filter scale configuration
: CAN-CAN_FS1R_FSC9   %1 9 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC9    Filter scale configuration
: CAN-CAN_FS1R_FSC10   %1 10 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC10    Filter scale configuration
: CAN-CAN_FS1R_FSC11   %1 11 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC11    Filter scale configuration
: CAN-CAN_FS1R_FSC12   %1 12 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC12    Filter scale configuration
: CAN-CAN_FS1R_FSC13   %1 13 lshift CAN-CAN_FS1R bis! ;  \ CAN-CAN_FS1R_FSC13    Filter scale configuration

\ CAN-CAN_FFA1R (read-write)
: CAN-CAN_FFA1R_FFA0   %1 0 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA0    Filter FIFO assignment for filter  0
: CAN-CAN_FFA1R_FFA1   %1 1 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA1    Filter FIFO assignment for filter  1
: CAN-CAN_FFA1R_FFA2   %1 2 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA2    Filter FIFO assignment for filter  2
: CAN-CAN_FFA1R_FFA3   %1 3 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA3    Filter FIFO assignment for filter  3
: CAN-CAN_FFA1R_FFA4   %1 4 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA4    Filter FIFO assignment for filter  4
: CAN-CAN_FFA1R_FFA5   %1 5 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA5    Filter FIFO assignment for filter  5
: CAN-CAN_FFA1R_FFA6   %1 6 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA6    Filter FIFO assignment for filter  6
: CAN-CAN_FFA1R_FFA7   %1 7 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA7    Filter FIFO assignment for filter  7
: CAN-CAN_FFA1R_FFA8   %1 8 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA8    Filter FIFO assignment for filter  8
: CAN-CAN_FFA1R_FFA9   %1 9 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA9    Filter FIFO assignment for filter  9
: CAN-CAN_FFA1R_FFA10   %1 10 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA10    Filter FIFO assignment for filter  10
: CAN-CAN_FFA1R_FFA11   %1 11 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA11    Filter FIFO assignment for filter  11
: CAN-CAN_FFA1R_FFA12   %1 12 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA12    Filter FIFO assignment for filter  12
: CAN-CAN_FFA1R_FFA13   %1 13 lshift CAN-CAN_FFA1R bis! ;  \ CAN-CAN_FFA1R_FFA13    Filter FIFO assignment for filter  13

\ CAN-CAN_FA1R (read-write)
: CAN-CAN_FA1R_FACT0   %1 0 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT0    Filter active
: CAN-CAN_FA1R_FACT1   %1 1 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT1    Filter active
: CAN-CAN_FA1R_FACT2   %1 2 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT2    Filter active
: CAN-CAN_FA1R_FACT3   %1 3 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT3    Filter active
: CAN-CAN_FA1R_FACT4   %1 4 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT4    Filter active
: CAN-CAN_FA1R_FACT5   %1 5 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT5    Filter active
: CAN-CAN_FA1R_FACT6   %1 6 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT6    Filter active
: CAN-CAN_FA1R_FACT7   %1 7 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT7    Filter active
: CAN-CAN_FA1R_FACT8   %1 8 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT8    Filter active
: CAN-CAN_FA1R_FACT9   %1 9 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT9    Filter active
: CAN-CAN_FA1R_FACT10   %1 10 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT10    Filter active
: CAN-CAN_FA1R_FACT11   %1 11 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT11    Filter active
: CAN-CAN_FA1R_FACT12   %1 12 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT12    Filter active
: CAN-CAN_FA1R_FACT13   %1 13 lshift CAN-CAN_FA1R bis! ;  \ CAN-CAN_FA1R_FACT13    Filter active

\ CAN-F0R1 (read-write)
: CAN-F0R1_FB0   %1 0 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB0    Filter bits
: CAN-F0R1_FB1   %1 1 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB1    Filter bits
: CAN-F0R1_FB2   %1 2 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB2    Filter bits
: CAN-F0R1_FB3   %1 3 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB3    Filter bits
: CAN-F0R1_FB4   %1 4 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB4    Filter bits
: CAN-F0R1_FB5   %1 5 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB5    Filter bits
: CAN-F0R1_FB6   %1 6 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB6    Filter bits
: CAN-F0R1_FB7   %1 7 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB7    Filter bits
: CAN-F0R1_FB8   %1 8 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB8    Filter bits
: CAN-F0R1_FB9   %1 9 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB9    Filter bits
: CAN-F0R1_FB10   %1 10 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB10    Filter bits
: CAN-F0R1_FB11   %1 11 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB11    Filter bits
: CAN-F0R1_FB12   %1 12 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB12    Filter bits
: CAN-F0R1_FB13   %1 13 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB13    Filter bits
: CAN-F0R1_FB14   %1 14 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB14    Filter bits
: CAN-F0R1_FB15   %1 15 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB15    Filter bits
: CAN-F0R1_FB16   %1 16 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB16    Filter bits
: CAN-F0R1_FB17   %1 17 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB17    Filter bits
: CAN-F0R1_FB18   %1 18 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB18    Filter bits
: CAN-F0R1_FB19   %1 19 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB19    Filter bits
: CAN-F0R1_FB20   %1 20 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB20    Filter bits
: CAN-F0R1_FB21   %1 21 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB21    Filter bits
: CAN-F0R1_FB22   %1 22 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB22    Filter bits
: CAN-F0R1_FB23   %1 23 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB23    Filter bits
: CAN-F0R1_FB24   %1 24 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB24    Filter bits
: CAN-F0R1_FB25   %1 25 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB25    Filter bits
: CAN-F0R1_FB26   %1 26 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB26    Filter bits
: CAN-F0R1_FB27   %1 27 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB27    Filter bits
: CAN-F0R1_FB28   %1 28 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB28    Filter bits
: CAN-F0R1_FB29   %1 29 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB29    Filter bits
: CAN-F0R1_FB30   %1 30 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB30    Filter bits
: CAN-F0R1_FB31   %1 31 lshift CAN-F0R1 bis! ;  \ CAN-F0R1_FB31    Filter bits

\ CAN-F0R2 (read-write)
: CAN-F0R2_FB0   %1 0 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB0    Filter bits
: CAN-F0R2_FB1   %1 1 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB1    Filter bits
: CAN-F0R2_FB2   %1 2 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB2    Filter bits
: CAN-F0R2_FB3   %1 3 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB3    Filter bits
: CAN-F0R2_FB4   %1 4 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB4    Filter bits
: CAN-F0R2_FB5   %1 5 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB5    Filter bits
: CAN-F0R2_FB6   %1 6 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB6    Filter bits
: CAN-F0R2_FB7   %1 7 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB7    Filter bits
: CAN-F0R2_FB8   %1 8 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB8    Filter bits
: CAN-F0R2_FB9   %1 9 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB9    Filter bits
: CAN-F0R2_FB10   %1 10 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB10    Filter bits
: CAN-F0R2_FB11   %1 11 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB11    Filter bits
: CAN-F0R2_FB12   %1 12 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB12    Filter bits
: CAN-F0R2_FB13   %1 13 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB13    Filter bits
: CAN-F0R2_FB14   %1 14 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB14    Filter bits
: CAN-F0R2_FB15   %1 15 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB15    Filter bits
: CAN-F0R2_FB16   %1 16 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB16    Filter bits
: CAN-F0R2_FB17   %1 17 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB17    Filter bits
: CAN-F0R2_FB18   %1 18 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB18    Filter bits
: CAN-F0R2_FB19   %1 19 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB19    Filter bits
: CAN-F0R2_FB20   %1 20 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB20    Filter bits
: CAN-F0R2_FB21   %1 21 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB21    Filter bits
: CAN-F0R2_FB22   %1 22 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB22    Filter bits
: CAN-F0R2_FB23   %1 23 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB23    Filter bits
: CAN-F0R2_FB24   %1 24 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB24    Filter bits
: CAN-F0R2_FB25   %1 25 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB25    Filter bits
: CAN-F0R2_FB26   %1 26 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB26    Filter bits
: CAN-F0R2_FB27   %1 27 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB27    Filter bits
: CAN-F0R2_FB28   %1 28 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB28    Filter bits
: CAN-F0R2_FB29   %1 29 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB29    Filter bits
: CAN-F0R2_FB30   %1 30 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB30    Filter bits
: CAN-F0R2_FB31   %1 31 lshift CAN-F0R2 bis! ;  \ CAN-F0R2_FB31    Filter bits

\ CAN-F1R1 (read-write)
: CAN-F1R1_FB0   %1 0 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB0    Filter bits
: CAN-F1R1_FB1   %1 1 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB1    Filter bits
: CAN-F1R1_FB2   %1 2 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB2    Filter bits
: CAN-F1R1_FB3   %1 3 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB3    Filter bits
: CAN-F1R1_FB4   %1 4 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB4    Filter bits
: CAN-F1R1_FB5   %1 5 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB5    Filter bits
: CAN-F1R1_FB6   %1 6 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB6    Filter bits
: CAN-F1R1_FB7   %1 7 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB7    Filter bits
: CAN-F1R1_FB8   %1 8 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB8    Filter bits
: CAN-F1R1_FB9   %1 9 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB9    Filter bits
: CAN-F1R1_FB10   %1 10 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB10    Filter bits
: CAN-F1R1_FB11   %1 11 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB11    Filter bits
: CAN-F1R1_FB12   %1 12 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB12    Filter bits
: CAN-F1R1_FB13   %1 13 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB13    Filter bits
: CAN-F1R1_FB14   %1 14 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB14    Filter bits
: CAN-F1R1_FB15   %1 15 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB15    Filter bits
: CAN-F1R1_FB16   %1 16 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB16    Filter bits
: CAN-F1R1_FB17   %1 17 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB17    Filter bits
: CAN-F1R1_FB18   %1 18 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB18    Filter bits
: CAN-F1R1_FB19   %1 19 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB19    Filter bits
: CAN-F1R1_FB20   %1 20 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB20    Filter bits
: CAN-F1R1_FB21   %1 21 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB21    Filter bits
: CAN-F1R1_FB22   %1 22 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB22    Filter bits
: CAN-F1R1_FB23   %1 23 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB23    Filter bits
: CAN-F1R1_FB24   %1 24 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB24    Filter bits
: CAN-F1R1_FB25   %1 25 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB25    Filter bits
: CAN-F1R1_FB26   %1 26 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB26    Filter bits
: CAN-F1R1_FB27   %1 27 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB27    Filter bits
: CAN-F1R1_FB28   %1 28 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB28    Filter bits
: CAN-F1R1_FB29   %1 29 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB29    Filter bits
: CAN-F1R1_FB30   %1 30 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB30    Filter bits
: CAN-F1R1_FB31   %1 31 lshift CAN-F1R1 bis! ;  \ CAN-F1R1_FB31    Filter bits

\ CAN-F1R2 (read-write)
: CAN-F1R2_FB0   %1 0 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB0    Filter bits
: CAN-F1R2_FB1   %1 1 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB1    Filter bits
: CAN-F1R2_FB2   %1 2 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB2    Filter bits
: CAN-F1R2_FB3   %1 3 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB3    Filter bits
: CAN-F1R2_FB4   %1 4 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB4    Filter bits
: CAN-F1R2_FB5   %1 5 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB5    Filter bits
: CAN-F1R2_FB6   %1 6 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB6    Filter bits
: CAN-F1R2_FB7   %1 7 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB7    Filter bits
: CAN-F1R2_FB8   %1 8 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB8    Filter bits
: CAN-F1R2_FB9   %1 9 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB9    Filter bits
: CAN-F1R2_FB10   %1 10 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB10    Filter bits
: CAN-F1R2_FB11   %1 11 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB11    Filter bits
: CAN-F1R2_FB12   %1 12 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB12    Filter bits
: CAN-F1R2_FB13   %1 13 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB13    Filter bits
: CAN-F1R2_FB14   %1 14 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB14    Filter bits
: CAN-F1R2_FB15   %1 15 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB15    Filter bits
: CAN-F1R2_FB16   %1 16 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB16    Filter bits
: CAN-F1R2_FB17   %1 17 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB17    Filter bits
: CAN-F1R2_FB18   %1 18 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB18    Filter bits
: CAN-F1R2_FB19   %1 19 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB19    Filter bits
: CAN-F1R2_FB20   %1 20 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB20    Filter bits
: CAN-F1R2_FB21   %1 21 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB21    Filter bits
: CAN-F1R2_FB22   %1 22 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB22    Filter bits
: CAN-F1R2_FB23   %1 23 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB23    Filter bits
: CAN-F1R2_FB24   %1 24 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB24    Filter bits
: CAN-F1R2_FB25   %1 25 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB25    Filter bits
: CAN-F1R2_FB26   %1 26 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB26    Filter bits
: CAN-F1R2_FB27   %1 27 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB27    Filter bits
: CAN-F1R2_FB28   %1 28 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB28    Filter bits
: CAN-F1R2_FB29   %1 29 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB29    Filter bits
: CAN-F1R2_FB30   %1 30 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB30    Filter bits
: CAN-F1R2_FB31   %1 31 lshift CAN-F1R2 bis! ;  \ CAN-F1R2_FB31    Filter bits

\ CAN-F2R1 (read-write)
: CAN-F2R1_FB0   %1 0 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB0    Filter bits
: CAN-F2R1_FB1   %1 1 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB1    Filter bits
: CAN-F2R1_FB2   %1 2 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB2    Filter bits
: CAN-F2R1_FB3   %1 3 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB3    Filter bits
: CAN-F2R1_FB4   %1 4 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB4    Filter bits
: CAN-F2R1_FB5   %1 5 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB5    Filter bits
: CAN-F2R1_FB6   %1 6 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB6    Filter bits
: CAN-F2R1_FB7   %1 7 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB7    Filter bits
: CAN-F2R1_FB8   %1 8 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB8    Filter bits
: CAN-F2R1_FB9   %1 9 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB9    Filter bits
: CAN-F2R1_FB10   %1 10 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB10    Filter bits
: CAN-F2R1_FB11   %1 11 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB11    Filter bits
: CAN-F2R1_FB12   %1 12 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB12    Filter bits
: CAN-F2R1_FB13   %1 13 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB13    Filter bits
: CAN-F2R1_FB14   %1 14 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB14    Filter bits
: CAN-F2R1_FB15   %1 15 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB15    Filter bits
: CAN-F2R1_FB16   %1 16 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB16    Filter bits
: CAN-F2R1_FB17   %1 17 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB17    Filter bits
: CAN-F2R1_FB18   %1 18 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB18    Filter bits
: CAN-F2R1_FB19   %1 19 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB19    Filter bits
: CAN-F2R1_FB20   %1 20 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB20    Filter bits
: CAN-F2R1_FB21   %1 21 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB21    Filter bits
: CAN-F2R1_FB22   %1 22 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB22    Filter bits
: CAN-F2R1_FB23   %1 23 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB23    Filter bits
: CAN-F2R1_FB24   %1 24 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB24    Filter bits
: CAN-F2R1_FB25   %1 25 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB25    Filter bits
: CAN-F2R1_FB26   %1 26 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB26    Filter bits
: CAN-F2R1_FB27   %1 27 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB27    Filter bits
: CAN-F2R1_FB28   %1 28 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB28    Filter bits
: CAN-F2R1_FB29   %1 29 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB29    Filter bits
: CAN-F2R1_FB30   %1 30 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB30    Filter bits
: CAN-F2R1_FB31   %1 31 lshift CAN-F2R1 bis! ;  \ CAN-F2R1_FB31    Filter bits

\ CAN-F2R2 (read-write)
: CAN-F2R2_FB0   %1 0 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB0    Filter bits
: CAN-F2R2_FB1   %1 1 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB1    Filter bits
: CAN-F2R2_FB2   %1 2 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB2    Filter bits
: CAN-F2R2_FB3   %1 3 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB3    Filter bits
: CAN-F2R2_FB4   %1 4 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB4    Filter bits
: CAN-F2R2_FB5   %1 5 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB5    Filter bits
: CAN-F2R2_FB6   %1 6 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB6    Filter bits
: CAN-F2R2_FB7   %1 7 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB7    Filter bits
: CAN-F2R2_FB8   %1 8 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB8    Filter bits
: CAN-F2R2_FB9   %1 9 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB9    Filter bits
: CAN-F2R2_FB10   %1 10 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB10    Filter bits
: CAN-F2R2_FB11   %1 11 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB11    Filter bits
: CAN-F2R2_FB12   %1 12 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB12    Filter bits
: CAN-F2R2_FB13   %1 13 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB13    Filter bits
: CAN-F2R2_FB14   %1 14 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB14    Filter bits
: CAN-F2R2_FB15   %1 15 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB15    Filter bits
: CAN-F2R2_FB16   %1 16 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB16    Filter bits
: CAN-F2R2_FB17   %1 17 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB17    Filter bits
: CAN-F2R2_FB18   %1 18 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB18    Filter bits
: CAN-F2R2_FB19   %1 19 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB19    Filter bits
: CAN-F2R2_FB20   %1 20 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB20    Filter bits
: CAN-F2R2_FB21   %1 21 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB21    Filter bits
: CAN-F2R2_FB22   %1 22 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB22    Filter bits
: CAN-F2R2_FB23   %1 23 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB23    Filter bits
: CAN-F2R2_FB24   %1 24 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB24    Filter bits
: CAN-F2R2_FB25   %1 25 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB25    Filter bits
: CAN-F2R2_FB26   %1 26 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB26    Filter bits
: CAN-F2R2_FB27   %1 27 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB27    Filter bits
: CAN-F2R2_FB28   %1 28 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB28    Filter bits
: CAN-F2R2_FB29   %1 29 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB29    Filter bits
: CAN-F2R2_FB30   %1 30 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB30    Filter bits
: CAN-F2R2_FB31   %1 31 lshift CAN-F2R2 bis! ;  \ CAN-F2R2_FB31    Filter bits

\ CAN-F3R1 (read-write)
: CAN-F3R1_FB0   %1 0 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB0    Filter bits
: CAN-F3R1_FB1   %1 1 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB1    Filter bits
: CAN-F3R1_FB2   %1 2 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB2    Filter bits
: CAN-F3R1_FB3   %1 3 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB3    Filter bits
: CAN-F3R1_FB4   %1 4 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB4    Filter bits
: CAN-F3R1_FB5   %1 5 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB5    Filter bits
: CAN-F3R1_FB6   %1 6 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB6    Filter bits
: CAN-F3R1_FB7   %1 7 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB7    Filter bits
: CAN-F3R1_FB8   %1 8 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB8    Filter bits
: CAN-F3R1_FB9   %1 9 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB9    Filter bits
: CAN-F3R1_FB10   %1 10 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB10    Filter bits
: CAN-F3R1_FB11   %1 11 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB11    Filter bits
: CAN-F3R1_FB12   %1 12 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB12    Filter bits
: CAN-F3R1_FB13   %1 13 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB13    Filter bits
: CAN-F3R1_FB14   %1 14 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB14    Filter bits
: CAN-F3R1_FB15   %1 15 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB15    Filter bits
: CAN-F3R1_FB16   %1 16 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB16    Filter bits
: CAN-F3R1_FB17   %1 17 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB17    Filter bits
: CAN-F3R1_FB18   %1 18 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB18    Filter bits
: CAN-F3R1_FB19   %1 19 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB19    Filter bits
: CAN-F3R1_FB20   %1 20 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB20    Filter bits
: CAN-F3R1_FB21   %1 21 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB21    Filter bits
: CAN-F3R1_FB22   %1 22 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB22    Filter bits
: CAN-F3R1_FB23   %1 23 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB23    Filter bits
: CAN-F3R1_FB24   %1 24 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB24    Filter bits
: CAN-F3R1_FB25   %1 25 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB25    Filter bits
: CAN-F3R1_FB26   %1 26 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB26    Filter bits
: CAN-F3R1_FB27   %1 27 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB27    Filter bits
: CAN-F3R1_FB28   %1 28 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB28    Filter bits
: CAN-F3R1_FB29   %1 29 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB29    Filter bits
: CAN-F3R1_FB30   %1 30 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB30    Filter bits
: CAN-F3R1_FB31   %1 31 lshift CAN-F3R1 bis! ;  \ CAN-F3R1_FB31    Filter bits

\ CAN-F3R2 (read-write)
: CAN-F3R2_FB0   %1 0 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB0    Filter bits
: CAN-F3R2_FB1   %1 1 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB1    Filter bits
: CAN-F3R2_FB2   %1 2 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB2    Filter bits
: CAN-F3R2_FB3   %1 3 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB3    Filter bits
: CAN-F3R2_FB4   %1 4 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB4    Filter bits
: CAN-F3R2_FB5   %1 5 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB5    Filter bits
: CAN-F3R2_FB6   %1 6 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB6    Filter bits
: CAN-F3R2_FB7   %1 7 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB7    Filter bits
: CAN-F3R2_FB8   %1 8 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB8    Filter bits
: CAN-F3R2_FB9   %1 9 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB9    Filter bits
: CAN-F3R2_FB10   %1 10 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB10    Filter bits
: CAN-F3R2_FB11   %1 11 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB11    Filter bits
: CAN-F3R2_FB12   %1 12 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB12    Filter bits
: CAN-F3R2_FB13   %1 13 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB13    Filter bits
: CAN-F3R2_FB14   %1 14 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB14    Filter bits
: CAN-F3R2_FB15   %1 15 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB15    Filter bits
: CAN-F3R2_FB16   %1 16 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB16    Filter bits
: CAN-F3R2_FB17   %1 17 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB17    Filter bits
: CAN-F3R2_FB18   %1 18 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB18    Filter bits
: CAN-F3R2_FB19   %1 19 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB19    Filter bits
: CAN-F3R2_FB20   %1 20 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB20    Filter bits
: CAN-F3R2_FB21   %1 21 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB21    Filter bits
: CAN-F3R2_FB22   %1 22 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB22    Filter bits
: CAN-F3R2_FB23   %1 23 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB23    Filter bits
: CAN-F3R2_FB24   %1 24 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB24    Filter bits
: CAN-F3R2_FB25   %1 25 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB25    Filter bits
: CAN-F3R2_FB26   %1 26 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB26    Filter bits
: CAN-F3R2_FB27   %1 27 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB27    Filter bits
: CAN-F3R2_FB28   %1 28 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB28    Filter bits
: CAN-F3R2_FB29   %1 29 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB29    Filter bits
: CAN-F3R2_FB30   %1 30 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB30    Filter bits
: CAN-F3R2_FB31   %1 31 lshift CAN-F3R2 bis! ;  \ CAN-F3R2_FB31    Filter bits

\ CAN-F4R1 (read-write)
: CAN-F4R1_FB0   %1 0 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB0    Filter bits
: CAN-F4R1_FB1   %1 1 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB1    Filter bits
: CAN-F4R1_FB2   %1 2 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB2    Filter bits
: CAN-F4R1_FB3   %1 3 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB3    Filter bits
: CAN-F4R1_FB4   %1 4 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB4    Filter bits
: CAN-F4R1_FB5   %1 5 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB5    Filter bits
: CAN-F4R1_FB6   %1 6 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB6    Filter bits
: CAN-F4R1_FB7   %1 7 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB7    Filter bits
: CAN-F4R1_FB8   %1 8 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB8    Filter bits
: CAN-F4R1_FB9   %1 9 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB9    Filter bits
: CAN-F4R1_FB10   %1 10 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB10    Filter bits
: CAN-F4R1_FB11   %1 11 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB11    Filter bits
: CAN-F4R1_FB12   %1 12 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB12    Filter bits
: CAN-F4R1_FB13   %1 13 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB13    Filter bits
: CAN-F4R1_FB14   %1 14 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB14    Filter bits
: CAN-F4R1_FB15   %1 15 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB15    Filter bits
: CAN-F4R1_FB16   %1 16 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB16    Filter bits
: CAN-F4R1_FB17   %1 17 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB17    Filter bits
: CAN-F4R1_FB18   %1 18 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB18    Filter bits
: CAN-F4R1_FB19   %1 19 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB19    Filter bits
: CAN-F4R1_FB20   %1 20 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB20    Filter bits
: CAN-F4R1_FB21   %1 21 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB21    Filter bits
: CAN-F4R1_FB22   %1 22 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB22    Filter bits
: CAN-F4R1_FB23   %1 23 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB23    Filter bits
: CAN-F4R1_FB24   %1 24 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB24    Filter bits
: CAN-F4R1_FB25   %1 25 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB25    Filter bits
: CAN-F4R1_FB26   %1 26 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB26    Filter bits
: CAN-F4R1_FB27   %1 27 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB27    Filter bits
: CAN-F4R1_FB28   %1 28 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB28    Filter bits
: CAN-F4R1_FB29   %1 29 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB29    Filter bits
: CAN-F4R1_FB30   %1 30 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB30    Filter bits
: CAN-F4R1_FB31   %1 31 lshift CAN-F4R1 bis! ;  \ CAN-F4R1_FB31    Filter bits

\ CAN-F4R2 (read-write)
: CAN-F4R2_FB0   %1 0 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB0    Filter bits
: CAN-F4R2_FB1   %1 1 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB1    Filter bits
: CAN-F4R2_FB2   %1 2 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB2    Filter bits
: CAN-F4R2_FB3   %1 3 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB3    Filter bits
: CAN-F4R2_FB4   %1 4 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB4    Filter bits
: CAN-F4R2_FB5   %1 5 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB5    Filter bits
: CAN-F4R2_FB6   %1 6 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB6    Filter bits
: CAN-F4R2_FB7   %1 7 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB7    Filter bits
: CAN-F4R2_FB8   %1 8 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB8    Filter bits
: CAN-F4R2_FB9   %1 9 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB9    Filter bits
: CAN-F4R2_FB10   %1 10 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB10    Filter bits
: CAN-F4R2_FB11   %1 11 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB11    Filter bits
: CAN-F4R2_FB12   %1 12 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB12    Filter bits
: CAN-F4R2_FB13   %1 13 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB13    Filter bits
: CAN-F4R2_FB14   %1 14 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB14    Filter bits
: CAN-F4R2_FB15   %1 15 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB15    Filter bits
: CAN-F4R2_FB16   %1 16 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB16    Filter bits
: CAN-F4R2_FB17   %1 17 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB17    Filter bits
: CAN-F4R2_FB18   %1 18 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB18    Filter bits
: CAN-F4R2_FB19   %1 19 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB19    Filter bits
: CAN-F4R2_FB20   %1 20 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB20    Filter bits
: CAN-F4R2_FB21   %1 21 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB21    Filter bits
: CAN-F4R2_FB22   %1 22 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB22    Filter bits
: CAN-F4R2_FB23   %1 23 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB23    Filter bits
: CAN-F4R2_FB24   %1 24 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB24    Filter bits
: CAN-F4R2_FB25   %1 25 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB25    Filter bits
: CAN-F4R2_FB26   %1 26 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB26    Filter bits
: CAN-F4R2_FB27   %1 27 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB27    Filter bits
: CAN-F4R2_FB28   %1 28 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB28    Filter bits
: CAN-F4R2_FB29   %1 29 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB29    Filter bits
: CAN-F4R2_FB30   %1 30 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB30    Filter bits
: CAN-F4R2_FB31   %1 31 lshift CAN-F4R2 bis! ;  \ CAN-F4R2_FB31    Filter bits

\ CAN-F5R1 (read-write)
: CAN-F5R1_FB0   %1 0 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB0    Filter bits
: CAN-F5R1_FB1   %1 1 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB1    Filter bits
: CAN-F5R1_FB2   %1 2 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB2    Filter bits
: CAN-F5R1_FB3   %1 3 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB3    Filter bits
: CAN-F5R1_FB4   %1 4 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB4    Filter bits
: CAN-F5R1_FB5   %1 5 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB5    Filter bits
: CAN-F5R1_FB6   %1 6 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB6    Filter bits
: CAN-F5R1_FB7   %1 7 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB7    Filter bits
: CAN-F5R1_FB8   %1 8 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB8    Filter bits
: CAN-F5R1_FB9   %1 9 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB9    Filter bits
: CAN-F5R1_FB10   %1 10 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB10    Filter bits
: CAN-F5R1_FB11   %1 11 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB11    Filter bits
: CAN-F5R1_FB12   %1 12 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB12    Filter bits
: CAN-F5R1_FB13   %1 13 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB13    Filter bits
: CAN-F5R1_FB14   %1 14 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB14    Filter bits
: CAN-F5R1_FB15   %1 15 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB15    Filter bits
: CAN-F5R1_FB16   %1 16 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB16    Filter bits
: CAN-F5R1_FB17   %1 17 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB17    Filter bits
: CAN-F5R1_FB18   %1 18 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB18    Filter bits
: CAN-F5R1_FB19   %1 19 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB19    Filter bits
: CAN-F5R1_FB20   %1 20 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB20    Filter bits
: CAN-F5R1_FB21   %1 21 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB21    Filter bits
: CAN-F5R1_FB22   %1 22 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB22    Filter bits
: CAN-F5R1_FB23   %1 23 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB23    Filter bits
: CAN-F5R1_FB24   %1 24 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB24    Filter bits
: CAN-F5R1_FB25   %1 25 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB25    Filter bits
: CAN-F5R1_FB26   %1 26 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB26    Filter bits
: CAN-F5R1_FB27   %1 27 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB27    Filter bits
: CAN-F5R1_FB28   %1 28 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB28    Filter bits
: CAN-F5R1_FB29   %1 29 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB29    Filter bits
: CAN-F5R1_FB30   %1 30 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB30    Filter bits
: CAN-F5R1_FB31   %1 31 lshift CAN-F5R1 bis! ;  \ CAN-F5R1_FB31    Filter bits

\ CAN-F5R2 (read-write)
: CAN-F5R2_FB0   %1 0 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB0    Filter bits
: CAN-F5R2_FB1   %1 1 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB1    Filter bits
: CAN-F5R2_FB2   %1 2 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB2    Filter bits
: CAN-F5R2_FB3   %1 3 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB3    Filter bits
: CAN-F5R2_FB4   %1 4 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB4    Filter bits
: CAN-F5R2_FB5   %1 5 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB5    Filter bits
: CAN-F5R2_FB6   %1 6 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB6    Filter bits
: CAN-F5R2_FB7   %1 7 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB7    Filter bits
: CAN-F5R2_FB8   %1 8 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB8    Filter bits
: CAN-F5R2_FB9   %1 9 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB9    Filter bits
: CAN-F5R2_FB10   %1 10 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB10    Filter bits
: CAN-F5R2_FB11   %1 11 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB11    Filter bits
: CAN-F5R2_FB12   %1 12 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB12    Filter bits
: CAN-F5R2_FB13   %1 13 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB13    Filter bits
: CAN-F5R2_FB14   %1 14 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB14    Filter bits
: CAN-F5R2_FB15   %1 15 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB15    Filter bits
: CAN-F5R2_FB16   %1 16 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB16    Filter bits
: CAN-F5R2_FB17   %1 17 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB17    Filter bits
: CAN-F5R2_FB18   %1 18 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB18    Filter bits
: CAN-F5R2_FB19   %1 19 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB19    Filter bits
: CAN-F5R2_FB20   %1 20 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB20    Filter bits
: CAN-F5R2_FB21   %1 21 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB21    Filter bits
: CAN-F5R2_FB22   %1 22 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB22    Filter bits
: CAN-F5R2_FB23   %1 23 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB23    Filter bits
: CAN-F5R2_FB24   %1 24 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB24    Filter bits
: CAN-F5R2_FB25   %1 25 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB25    Filter bits
: CAN-F5R2_FB26   %1 26 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB26    Filter bits
: CAN-F5R2_FB27   %1 27 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB27    Filter bits
: CAN-F5R2_FB28   %1 28 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB28    Filter bits
: CAN-F5R2_FB29   %1 29 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB29    Filter bits
: CAN-F5R2_FB30   %1 30 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB30    Filter bits
: CAN-F5R2_FB31   %1 31 lshift CAN-F5R2 bis! ;  \ CAN-F5R2_FB31    Filter bits

\ CAN-F6R1 (read-write)
: CAN-F6R1_FB0   %1 0 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB0    Filter bits
: CAN-F6R1_FB1   %1 1 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB1    Filter bits
: CAN-F6R1_FB2   %1 2 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB2    Filter bits
: CAN-F6R1_FB3   %1 3 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB3    Filter bits
: CAN-F6R1_FB4   %1 4 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB4    Filter bits
: CAN-F6R1_FB5   %1 5 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB5    Filter bits
: CAN-F6R1_FB6   %1 6 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB6    Filter bits
: CAN-F6R1_FB7   %1 7 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB7    Filter bits
: CAN-F6R1_FB8   %1 8 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB8    Filter bits
: CAN-F6R1_FB9   %1 9 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB9    Filter bits
: CAN-F6R1_FB10   %1 10 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB10    Filter bits
: CAN-F6R1_FB11   %1 11 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB11    Filter bits
: CAN-F6R1_FB12   %1 12 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB12    Filter bits
: CAN-F6R1_FB13   %1 13 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB13    Filter bits
: CAN-F6R1_FB14   %1 14 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB14    Filter bits
: CAN-F6R1_FB15   %1 15 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB15    Filter bits
: CAN-F6R1_FB16   %1 16 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB16    Filter bits
: CAN-F6R1_FB17   %1 17 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB17    Filter bits
: CAN-F6R1_FB18   %1 18 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB18    Filter bits
: CAN-F6R1_FB19   %1 19 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB19    Filter bits
: CAN-F6R1_FB20   %1 20 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB20    Filter bits
: CAN-F6R1_FB21   %1 21 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB21    Filter bits
: CAN-F6R1_FB22   %1 22 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB22    Filter bits
: CAN-F6R1_FB23   %1 23 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB23    Filter bits
: CAN-F6R1_FB24   %1 24 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB24    Filter bits
: CAN-F6R1_FB25   %1 25 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB25    Filter bits
: CAN-F6R1_FB26   %1 26 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB26    Filter bits
: CAN-F6R1_FB27   %1 27 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB27    Filter bits
: CAN-F6R1_FB28   %1 28 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB28    Filter bits
: CAN-F6R1_FB29   %1 29 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB29    Filter bits
: CAN-F6R1_FB30   %1 30 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB30    Filter bits
: CAN-F6R1_FB31   %1 31 lshift CAN-F6R1 bis! ;  \ CAN-F6R1_FB31    Filter bits

\ CAN-F6R2 (read-write)
: CAN-F6R2_FB0   %1 0 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB0    Filter bits
: CAN-F6R2_FB1   %1 1 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB1    Filter bits
: CAN-F6R2_FB2   %1 2 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB2    Filter bits
: CAN-F6R2_FB3   %1 3 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB3    Filter bits
: CAN-F6R2_FB4   %1 4 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB4    Filter bits
: CAN-F6R2_FB5   %1 5 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB5    Filter bits
: CAN-F6R2_FB6   %1 6 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB6    Filter bits
: CAN-F6R2_FB7   %1 7 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB7    Filter bits
: CAN-F6R2_FB8   %1 8 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB8    Filter bits
: CAN-F6R2_FB9   %1 9 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB9    Filter bits
: CAN-F6R2_FB10   %1 10 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB10    Filter bits
: CAN-F6R2_FB11   %1 11 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB11    Filter bits
: CAN-F6R2_FB12   %1 12 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB12    Filter bits
: CAN-F6R2_FB13   %1 13 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB13    Filter bits
: CAN-F6R2_FB14   %1 14 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB14    Filter bits
: CAN-F6R2_FB15   %1 15 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB15    Filter bits
: CAN-F6R2_FB16   %1 16 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB16    Filter bits
: CAN-F6R2_FB17   %1 17 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB17    Filter bits
: CAN-F6R2_FB18   %1 18 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB18    Filter bits
: CAN-F6R2_FB19   %1 19 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB19    Filter bits
: CAN-F6R2_FB20   %1 20 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB20    Filter bits
: CAN-F6R2_FB21   %1 21 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB21    Filter bits
: CAN-F6R2_FB22   %1 22 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB22    Filter bits
: CAN-F6R2_FB23   %1 23 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB23    Filter bits
: CAN-F6R2_FB24   %1 24 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB24    Filter bits
: CAN-F6R2_FB25   %1 25 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB25    Filter bits
: CAN-F6R2_FB26   %1 26 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB26    Filter bits
: CAN-F6R2_FB27   %1 27 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB27    Filter bits
: CAN-F6R2_FB28   %1 28 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB28    Filter bits
: CAN-F6R2_FB29   %1 29 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB29    Filter bits
: CAN-F6R2_FB30   %1 30 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB30    Filter bits
: CAN-F6R2_FB31   %1 31 lshift CAN-F6R2 bis! ;  \ CAN-F6R2_FB31    Filter bits

\ CAN-F7R1 (read-write)
: CAN-F7R1_FB0   %1 0 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB0    Filter bits
: CAN-F7R1_FB1   %1 1 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB1    Filter bits
: CAN-F7R1_FB2   %1 2 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB2    Filter bits
: CAN-F7R1_FB3   %1 3 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB3    Filter bits
: CAN-F7R1_FB4   %1 4 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB4    Filter bits
: CAN-F7R1_FB5   %1 5 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB5    Filter bits
: CAN-F7R1_FB6   %1 6 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB6    Filter bits
: CAN-F7R1_FB7   %1 7 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB7    Filter bits
: CAN-F7R1_FB8   %1 8 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB8    Filter bits
: CAN-F7R1_FB9   %1 9 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB9    Filter bits
: CAN-F7R1_FB10   %1 10 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB10    Filter bits
: CAN-F7R1_FB11   %1 11 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB11    Filter bits
: CAN-F7R1_FB12   %1 12 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB12    Filter bits
: CAN-F7R1_FB13   %1 13 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB13    Filter bits
: CAN-F7R1_FB14   %1 14 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB14    Filter bits
: CAN-F7R1_FB15   %1 15 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB15    Filter bits
: CAN-F7R1_FB16   %1 16 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB16    Filter bits
: CAN-F7R1_FB17   %1 17 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB17    Filter bits
: CAN-F7R1_FB18   %1 18 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB18    Filter bits
: CAN-F7R1_FB19   %1 19 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB19    Filter bits
: CAN-F7R1_FB20   %1 20 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB20    Filter bits
: CAN-F7R1_FB21   %1 21 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB21    Filter bits
: CAN-F7R1_FB22   %1 22 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB22    Filter bits
: CAN-F7R1_FB23   %1 23 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB23    Filter bits
: CAN-F7R1_FB24   %1 24 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB24    Filter bits
: CAN-F7R1_FB25   %1 25 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB25    Filter bits
: CAN-F7R1_FB26   %1 26 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB26    Filter bits
: CAN-F7R1_FB27   %1 27 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB27    Filter bits
: CAN-F7R1_FB28   %1 28 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB28    Filter bits
: CAN-F7R1_FB29   %1 29 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB29    Filter bits
: CAN-F7R1_FB30   %1 30 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB30    Filter bits
: CAN-F7R1_FB31   %1 31 lshift CAN-F7R1 bis! ;  \ CAN-F7R1_FB31    Filter bits

\ CAN-F7R2 (read-write)
: CAN-F7R2_FB0   %1 0 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB0    Filter bits
: CAN-F7R2_FB1   %1 1 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB1    Filter bits
: CAN-F7R2_FB2   %1 2 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB2    Filter bits
: CAN-F7R2_FB3   %1 3 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB3    Filter bits
: CAN-F7R2_FB4   %1 4 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB4    Filter bits
: CAN-F7R2_FB5   %1 5 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB5    Filter bits
: CAN-F7R2_FB6   %1 6 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB6    Filter bits
: CAN-F7R2_FB7   %1 7 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB7    Filter bits
: CAN-F7R2_FB8   %1 8 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB8    Filter bits
: CAN-F7R2_FB9   %1 9 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB9    Filter bits
: CAN-F7R2_FB10   %1 10 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB10    Filter bits
: CAN-F7R2_FB11   %1 11 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB11    Filter bits
: CAN-F7R2_FB12   %1 12 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB12    Filter bits
: CAN-F7R2_FB13   %1 13 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB13    Filter bits
: CAN-F7R2_FB14   %1 14 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB14    Filter bits
: CAN-F7R2_FB15   %1 15 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB15    Filter bits
: CAN-F7R2_FB16   %1 16 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB16    Filter bits
: CAN-F7R2_FB17   %1 17 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB17    Filter bits
: CAN-F7R2_FB18   %1 18 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB18    Filter bits
: CAN-F7R2_FB19   %1 19 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB19    Filter bits
: CAN-F7R2_FB20   %1 20 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB20    Filter bits
: CAN-F7R2_FB21   %1 21 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB21    Filter bits
: CAN-F7R2_FB22   %1 22 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB22    Filter bits
: CAN-F7R2_FB23   %1 23 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB23    Filter bits
: CAN-F7R2_FB24   %1 24 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB24    Filter bits
: CAN-F7R2_FB25   %1 25 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB25    Filter bits
: CAN-F7R2_FB26   %1 26 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB26    Filter bits
: CAN-F7R2_FB27   %1 27 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB27    Filter bits
: CAN-F7R2_FB28   %1 28 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB28    Filter bits
: CAN-F7R2_FB29   %1 29 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB29    Filter bits
: CAN-F7R2_FB30   %1 30 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB30    Filter bits
: CAN-F7R2_FB31   %1 31 lshift CAN-F7R2 bis! ;  \ CAN-F7R2_FB31    Filter bits

\ CAN-F8R1 (read-write)
: CAN-F8R1_FB0   %1 0 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB0    Filter bits
: CAN-F8R1_FB1   %1 1 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB1    Filter bits
: CAN-F8R1_FB2   %1 2 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB2    Filter bits
: CAN-F8R1_FB3   %1 3 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB3    Filter bits
: CAN-F8R1_FB4   %1 4 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB4    Filter bits
: CAN-F8R1_FB5   %1 5 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB5    Filter bits
: CAN-F8R1_FB6   %1 6 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB6    Filter bits
: CAN-F8R1_FB7   %1 7 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB7    Filter bits
: CAN-F8R1_FB8   %1 8 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB8    Filter bits
: CAN-F8R1_FB9   %1 9 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB9    Filter bits
: CAN-F8R1_FB10   %1 10 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB10    Filter bits
: CAN-F8R1_FB11   %1 11 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB11    Filter bits
: CAN-F8R1_FB12   %1 12 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB12    Filter bits
: CAN-F8R1_FB13   %1 13 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB13    Filter bits
: CAN-F8R1_FB14   %1 14 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB14    Filter bits
: CAN-F8R1_FB15   %1 15 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB15    Filter bits
: CAN-F8R1_FB16   %1 16 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB16    Filter bits
: CAN-F8R1_FB17   %1 17 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB17    Filter bits
: CAN-F8R1_FB18   %1 18 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB18    Filter bits
: CAN-F8R1_FB19   %1 19 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB19    Filter bits
: CAN-F8R1_FB20   %1 20 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB20    Filter bits
: CAN-F8R1_FB21   %1 21 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB21    Filter bits
: CAN-F8R1_FB22   %1 22 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB22    Filter bits
: CAN-F8R1_FB23   %1 23 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB23    Filter bits
: CAN-F8R1_FB24   %1 24 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB24    Filter bits
: CAN-F8R1_FB25   %1 25 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB25    Filter bits
: CAN-F8R1_FB26   %1 26 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB26    Filter bits
: CAN-F8R1_FB27   %1 27 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB27    Filter bits
: CAN-F8R1_FB28   %1 28 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB28    Filter bits
: CAN-F8R1_FB29   %1 29 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB29    Filter bits
: CAN-F8R1_FB30   %1 30 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB30    Filter bits
: CAN-F8R1_FB31   %1 31 lshift CAN-F8R1 bis! ;  \ CAN-F8R1_FB31    Filter bits

\ CAN-F8R2 (read-write)
: CAN-F8R2_FB0   %1 0 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB0    Filter bits
: CAN-F8R2_FB1   %1 1 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB1    Filter bits
: CAN-F8R2_FB2   %1 2 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB2    Filter bits
: CAN-F8R2_FB3   %1 3 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB3    Filter bits
: CAN-F8R2_FB4   %1 4 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB4    Filter bits
: CAN-F8R2_FB5   %1 5 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB5    Filter bits
: CAN-F8R2_FB6   %1 6 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB6    Filter bits
: CAN-F8R2_FB7   %1 7 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB7    Filter bits
: CAN-F8R2_FB8   %1 8 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB8    Filter bits
: CAN-F8R2_FB9   %1 9 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB9    Filter bits
: CAN-F8R2_FB10   %1 10 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB10    Filter bits
: CAN-F8R2_FB11   %1 11 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB11    Filter bits
: CAN-F8R2_FB12   %1 12 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB12    Filter bits
: CAN-F8R2_FB13   %1 13 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB13    Filter bits
: CAN-F8R2_FB14   %1 14 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB14    Filter bits
: CAN-F8R2_FB15   %1 15 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB15    Filter bits
: CAN-F8R2_FB16   %1 16 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB16    Filter bits
: CAN-F8R2_FB17   %1 17 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB17    Filter bits
: CAN-F8R2_FB18   %1 18 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB18    Filter bits
: CAN-F8R2_FB19   %1 19 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB19    Filter bits
: CAN-F8R2_FB20   %1 20 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB20    Filter bits
: CAN-F8R2_FB21   %1 21 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB21    Filter bits
: CAN-F8R2_FB22   %1 22 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB22    Filter bits
: CAN-F8R2_FB23   %1 23 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB23    Filter bits
: CAN-F8R2_FB24   %1 24 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB24    Filter bits
: CAN-F8R2_FB25   %1 25 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB25    Filter bits
: CAN-F8R2_FB26   %1 26 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB26    Filter bits
: CAN-F8R2_FB27   %1 27 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB27    Filter bits
: CAN-F8R2_FB28   %1 28 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB28    Filter bits
: CAN-F8R2_FB29   %1 29 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB29    Filter bits
: CAN-F8R2_FB30   %1 30 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB30    Filter bits
: CAN-F8R2_FB31   %1 31 lshift CAN-F8R2 bis! ;  \ CAN-F8R2_FB31    Filter bits

\ CAN-F9R1 (read-write)
: CAN-F9R1_FB0   %1 0 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB0    Filter bits
: CAN-F9R1_FB1   %1 1 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB1    Filter bits
: CAN-F9R1_FB2   %1 2 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB2    Filter bits
: CAN-F9R1_FB3   %1 3 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB3    Filter bits
: CAN-F9R1_FB4   %1 4 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB4    Filter bits
: CAN-F9R1_FB5   %1 5 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB5    Filter bits
: CAN-F9R1_FB6   %1 6 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB6    Filter bits
: CAN-F9R1_FB7   %1 7 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB7    Filter bits
: CAN-F9R1_FB8   %1 8 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB8    Filter bits
: CAN-F9R1_FB9   %1 9 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB9    Filter bits
: CAN-F9R1_FB10   %1 10 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB10    Filter bits
: CAN-F9R1_FB11   %1 11 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB11    Filter bits
: CAN-F9R1_FB12   %1 12 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB12    Filter bits
: CAN-F9R1_FB13   %1 13 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB13    Filter bits
: CAN-F9R1_FB14   %1 14 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB14    Filter bits
: CAN-F9R1_FB15   %1 15 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB15    Filter bits
: CAN-F9R1_FB16   %1 16 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB16    Filter bits
: CAN-F9R1_FB17   %1 17 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB17    Filter bits
: CAN-F9R1_FB18   %1 18 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB18    Filter bits
: CAN-F9R1_FB19   %1 19 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB19    Filter bits
: CAN-F9R1_FB20   %1 20 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB20    Filter bits
: CAN-F9R1_FB21   %1 21 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB21    Filter bits
: CAN-F9R1_FB22   %1 22 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB22    Filter bits
: CAN-F9R1_FB23   %1 23 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB23    Filter bits
: CAN-F9R1_FB24   %1 24 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB24    Filter bits
: CAN-F9R1_FB25   %1 25 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB25    Filter bits
: CAN-F9R1_FB26   %1 26 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB26    Filter bits
: CAN-F9R1_FB27   %1 27 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB27    Filter bits
: CAN-F9R1_FB28   %1 28 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB28    Filter bits
: CAN-F9R1_FB29   %1 29 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB29    Filter bits
: CAN-F9R1_FB30   %1 30 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB30    Filter bits
: CAN-F9R1_FB31   %1 31 lshift CAN-F9R1 bis! ;  \ CAN-F9R1_FB31    Filter bits

\ CAN-F9R2 (read-write)
: CAN-F9R2_FB0   %1 0 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB0    Filter bits
: CAN-F9R2_FB1   %1 1 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB1    Filter bits
: CAN-F9R2_FB2   %1 2 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB2    Filter bits
: CAN-F9R2_FB3   %1 3 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB3    Filter bits
: CAN-F9R2_FB4   %1 4 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB4    Filter bits
: CAN-F9R2_FB5   %1 5 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB5    Filter bits
: CAN-F9R2_FB6   %1 6 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB6    Filter bits
: CAN-F9R2_FB7   %1 7 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB7    Filter bits
: CAN-F9R2_FB8   %1 8 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB8    Filter bits
: CAN-F9R2_FB9   %1 9 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB9    Filter bits
: CAN-F9R2_FB10   %1 10 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB10    Filter bits
: CAN-F9R2_FB11   %1 11 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB11    Filter bits
: CAN-F9R2_FB12   %1 12 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB12    Filter bits
: CAN-F9R2_FB13   %1 13 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB13    Filter bits
: CAN-F9R2_FB14   %1 14 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB14    Filter bits
: CAN-F9R2_FB15   %1 15 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB15    Filter bits
: CAN-F9R2_FB16   %1 16 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB16    Filter bits
: CAN-F9R2_FB17   %1 17 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB17    Filter bits
: CAN-F9R2_FB18   %1 18 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB18    Filter bits
: CAN-F9R2_FB19   %1 19 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB19    Filter bits
: CAN-F9R2_FB20   %1 20 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB20    Filter bits
: CAN-F9R2_FB21   %1 21 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB21    Filter bits
: CAN-F9R2_FB22   %1 22 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB22    Filter bits
: CAN-F9R2_FB23   %1 23 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB23    Filter bits
: CAN-F9R2_FB24   %1 24 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB24    Filter bits
: CAN-F9R2_FB25   %1 25 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB25    Filter bits
: CAN-F9R2_FB26   %1 26 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB26    Filter bits
: CAN-F9R2_FB27   %1 27 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB27    Filter bits
: CAN-F9R2_FB28   %1 28 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB28    Filter bits
: CAN-F9R2_FB29   %1 29 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB29    Filter bits
: CAN-F9R2_FB30   %1 30 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB30    Filter bits
: CAN-F9R2_FB31   %1 31 lshift CAN-F9R2 bis! ;  \ CAN-F9R2_FB31    Filter bits

\ CAN-F10R1 (read-write)
: CAN-F10R1_FB0   %1 0 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB0    Filter bits
: CAN-F10R1_FB1   %1 1 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB1    Filter bits
: CAN-F10R1_FB2   %1 2 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB2    Filter bits
: CAN-F10R1_FB3   %1 3 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB3    Filter bits
: CAN-F10R1_FB4   %1 4 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB4    Filter bits
: CAN-F10R1_FB5   %1 5 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB5    Filter bits
: CAN-F10R1_FB6   %1 6 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB6    Filter bits
: CAN-F10R1_FB7   %1 7 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB7    Filter bits
: CAN-F10R1_FB8   %1 8 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB8    Filter bits
: CAN-F10R1_FB9   %1 9 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB9    Filter bits
: CAN-F10R1_FB10   %1 10 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB10    Filter bits
: CAN-F10R1_FB11   %1 11 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB11    Filter bits
: CAN-F10R1_FB12   %1 12 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB12    Filter bits
: CAN-F10R1_FB13   %1 13 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB13    Filter bits
: CAN-F10R1_FB14   %1 14 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB14    Filter bits
: CAN-F10R1_FB15   %1 15 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB15    Filter bits
: CAN-F10R1_FB16   %1 16 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB16    Filter bits
: CAN-F10R1_FB17   %1 17 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB17    Filter bits
: CAN-F10R1_FB18   %1 18 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB18    Filter bits
: CAN-F10R1_FB19   %1 19 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB19    Filter bits
: CAN-F10R1_FB20   %1 20 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB20    Filter bits
: CAN-F10R1_FB21   %1 21 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB21    Filter bits
: CAN-F10R1_FB22   %1 22 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB22    Filter bits
: CAN-F10R1_FB23   %1 23 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB23    Filter bits
: CAN-F10R1_FB24   %1 24 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB24    Filter bits
: CAN-F10R1_FB25   %1 25 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB25    Filter bits
: CAN-F10R1_FB26   %1 26 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB26    Filter bits
: CAN-F10R1_FB27   %1 27 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB27    Filter bits
: CAN-F10R1_FB28   %1 28 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB28    Filter bits
: CAN-F10R1_FB29   %1 29 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB29    Filter bits
: CAN-F10R1_FB30   %1 30 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB30    Filter bits
: CAN-F10R1_FB31   %1 31 lshift CAN-F10R1 bis! ;  \ CAN-F10R1_FB31    Filter bits

\ CAN-F10R2 (read-write)
: CAN-F10R2_FB0   %1 0 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB0    Filter bits
: CAN-F10R2_FB1   %1 1 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB1    Filter bits
: CAN-F10R2_FB2   %1 2 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB2    Filter bits
: CAN-F10R2_FB3   %1 3 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB3    Filter bits
: CAN-F10R2_FB4   %1 4 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB4    Filter bits
: CAN-F10R2_FB5   %1 5 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB5    Filter bits
: CAN-F10R2_FB6   %1 6 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB6    Filter bits
: CAN-F10R2_FB7   %1 7 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB7    Filter bits
: CAN-F10R2_FB8   %1 8 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB8    Filter bits
: CAN-F10R2_FB9   %1 9 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB9    Filter bits
: CAN-F10R2_FB10   %1 10 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB10    Filter bits
: CAN-F10R2_FB11   %1 11 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB11    Filter bits
: CAN-F10R2_FB12   %1 12 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB12    Filter bits
: CAN-F10R2_FB13   %1 13 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB13    Filter bits
: CAN-F10R2_FB14   %1 14 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB14    Filter bits
: CAN-F10R2_FB15   %1 15 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB15    Filter bits
: CAN-F10R2_FB16   %1 16 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB16    Filter bits
: CAN-F10R2_FB17   %1 17 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB17    Filter bits
: CAN-F10R2_FB18   %1 18 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB18    Filter bits
: CAN-F10R2_FB19   %1 19 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB19    Filter bits
: CAN-F10R2_FB20   %1 20 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB20    Filter bits
: CAN-F10R2_FB21   %1 21 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB21    Filter bits
: CAN-F10R2_FB22   %1 22 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB22    Filter bits
: CAN-F10R2_FB23   %1 23 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB23    Filter bits
: CAN-F10R2_FB24   %1 24 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB24    Filter bits
: CAN-F10R2_FB25   %1 25 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB25    Filter bits
: CAN-F10R2_FB26   %1 26 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB26    Filter bits
: CAN-F10R2_FB27   %1 27 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB27    Filter bits
: CAN-F10R2_FB28   %1 28 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB28    Filter bits
: CAN-F10R2_FB29   %1 29 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB29    Filter bits
: CAN-F10R2_FB30   %1 30 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB30    Filter bits
: CAN-F10R2_FB31   %1 31 lshift CAN-F10R2 bis! ;  \ CAN-F10R2_FB31    Filter bits

\ CAN-F11R1 (read-write)
: CAN-F11R1_FB0   %1 0 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB0    Filter bits
: CAN-F11R1_FB1   %1 1 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB1    Filter bits
: CAN-F11R1_FB2   %1 2 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB2    Filter bits
: CAN-F11R1_FB3   %1 3 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB3    Filter bits
: CAN-F11R1_FB4   %1 4 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB4    Filter bits
: CAN-F11R1_FB5   %1 5 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB5    Filter bits
: CAN-F11R1_FB6   %1 6 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB6    Filter bits
: CAN-F11R1_FB7   %1 7 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB7    Filter bits
: CAN-F11R1_FB8   %1 8 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB8    Filter bits
: CAN-F11R1_FB9   %1 9 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB9    Filter bits
: CAN-F11R1_FB10   %1 10 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB10    Filter bits
: CAN-F11R1_FB11   %1 11 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB11    Filter bits
: CAN-F11R1_FB12   %1 12 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB12    Filter bits
: CAN-F11R1_FB13   %1 13 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB13    Filter bits
: CAN-F11R1_FB14   %1 14 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB14    Filter bits
: CAN-F11R1_FB15   %1 15 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB15    Filter bits
: CAN-F11R1_FB16   %1 16 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB16    Filter bits
: CAN-F11R1_FB17   %1 17 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB17    Filter bits
: CAN-F11R1_FB18   %1 18 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB18    Filter bits
: CAN-F11R1_FB19   %1 19 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB19    Filter bits
: CAN-F11R1_FB20   %1 20 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB20    Filter bits
: CAN-F11R1_FB21   %1 21 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB21    Filter bits
: CAN-F11R1_FB22   %1 22 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB22    Filter bits
: CAN-F11R1_FB23   %1 23 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB23    Filter bits
: CAN-F11R1_FB24   %1 24 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB24    Filter bits
: CAN-F11R1_FB25   %1 25 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB25    Filter bits
: CAN-F11R1_FB26   %1 26 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB26    Filter bits
: CAN-F11R1_FB27   %1 27 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB27    Filter bits
: CAN-F11R1_FB28   %1 28 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB28    Filter bits
: CAN-F11R1_FB29   %1 29 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB29    Filter bits
: CAN-F11R1_FB30   %1 30 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB30    Filter bits
: CAN-F11R1_FB31   %1 31 lshift CAN-F11R1 bis! ;  \ CAN-F11R1_FB31    Filter bits

\ CAN-F11R2 (read-write)
: CAN-F11R2_FB0   %1 0 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB0    Filter bits
: CAN-F11R2_FB1   %1 1 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB1    Filter bits
: CAN-F11R2_FB2   %1 2 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB2    Filter bits
: CAN-F11R2_FB3   %1 3 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB3    Filter bits
: CAN-F11R2_FB4   %1 4 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB4    Filter bits
: CAN-F11R2_FB5   %1 5 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB5    Filter bits
: CAN-F11R2_FB6   %1 6 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB6    Filter bits
: CAN-F11R2_FB7   %1 7 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB7    Filter bits
: CAN-F11R2_FB8   %1 8 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB8    Filter bits
: CAN-F11R2_FB9   %1 9 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB9    Filter bits
: CAN-F11R2_FB10   %1 10 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB10    Filter bits
: CAN-F11R2_FB11   %1 11 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB11    Filter bits
: CAN-F11R2_FB12   %1 12 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB12    Filter bits
: CAN-F11R2_FB13   %1 13 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB13    Filter bits
: CAN-F11R2_FB14   %1 14 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB14    Filter bits
: CAN-F11R2_FB15   %1 15 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB15    Filter bits
: CAN-F11R2_FB16   %1 16 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB16    Filter bits
: CAN-F11R2_FB17   %1 17 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB17    Filter bits
: CAN-F11R2_FB18   %1 18 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB18    Filter bits
: CAN-F11R2_FB19   %1 19 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB19    Filter bits
: CAN-F11R2_FB20   %1 20 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB20    Filter bits
: CAN-F11R2_FB21   %1 21 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB21    Filter bits
: CAN-F11R2_FB22   %1 22 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB22    Filter bits
: CAN-F11R2_FB23   %1 23 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB23    Filter bits
: CAN-F11R2_FB24   %1 24 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB24    Filter bits
: CAN-F11R2_FB25   %1 25 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB25    Filter bits
: CAN-F11R2_FB26   %1 26 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB26    Filter bits
: CAN-F11R2_FB27   %1 27 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB27    Filter bits
: CAN-F11R2_FB28   %1 28 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB28    Filter bits
: CAN-F11R2_FB29   %1 29 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB29    Filter bits
: CAN-F11R2_FB30   %1 30 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB30    Filter bits
: CAN-F11R2_FB31   %1 31 lshift CAN-F11R2 bis! ;  \ CAN-F11R2_FB31    Filter bits

\ CAN-F12R1 (read-write)
: CAN-F12R1_FB0   %1 0 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB0    Filter bits
: CAN-F12R1_FB1   %1 1 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB1    Filter bits
: CAN-F12R1_FB2   %1 2 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB2    Filter bits
: CAN-F12R1_FB3   %1 3 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB3    Filter bits
: CAN-F12R1_FB4   %1 4 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB4    Filter bits
: CAN-F12R1_FB5   %1 5 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB5    Filter bits
: CAN-F12R1_FB6   %1 6 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB6    Filter bits
: CAN-F12R1_FB7   %1 7 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB7    Filter bits
: CAN-F12R1_FB8   %1 8 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB8    Filter bits
: CAN-F12R1_FB9   %1 9 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB9    Filter bits
: CAN-F12R1_FB10   %1 10 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB10    Filter bits
: CAN-F12R1_FB11   %1 11 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB11    Filter bits
: CAN-F12R1_FB12   %1 12 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB12    Filter bits
: CAN-F12R1_FB13   %1 13 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB13    Filter bits
: CAN-F12R1_FB14   %1 14 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB14    Filter bits
: CAN-F12R1_FB15   %1 15 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB15    Filter bits
: CAN-F12R1_FB16   %1 16 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB16    Filter bits
: CAN-F12R1_FB17   %1 17 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB17    Filter bits
: CAN-F12R1_FB18   %1 18 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB18    Filter bits
: CAN-F12R1_FB19   %1 19 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB19    Filter bits
: CAN-F12R1_FB20   %1 20 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB20    Filter bits
: CAN-F12R1_FB21   %1 21 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB21    Filter bits
: CAN-F12R1_FB22   %1 22 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB22    Filter bits
: CAN-F12R1_FB23   %1 23 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB23    Filter bits
: CAN-F12R1_FB24   %1 24 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB24    Filter bits
: CAN-F12R1_FB25   %1 25 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB25    Filter bits
: CAN-F12R1_FB26   %1 26 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB26    Filter bits
: CAN-F12R1_FB27   %1 27 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB27    Filter bits
: CAN-F12R1_FB28   %1 28 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB28    Filter bits
: CAN-F12R1_FB29   %1 29 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB29    Filter bits
: CAN-F12R1_FB30   %1 30 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB30    Filter bits
: CAN-F12R1_FB31   %1 31 lshift CAN-F12R1 bis! ;  \ CAN-F12R1_FB31    Filter bits

\ CAN-F12R2 (read-write)
: CAN-F12R2_FB0   %1 0 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB0    Filter bits
: CAN-F12R2_FB1   %1 1 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB1    Filter bits
: CAN-F12R2_FB2   %1 2 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB2    Filter bits
: CAN-F12R2_FB3   %1 3 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB3    Filter bits
: CAN-F12R2_FB4   %1 4 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB4    Filter bits
: CAN-F12R2_FB5   %1 5 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB5    Filter bits
: CAN-F12R2_FB6   %1 6 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB6    Filter bits
: CAN-F12R2_FB7   %1 7 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB7    Filter bits
: CAN-F12R2_FB8   %1 8 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB8    Filter bits
: CAN-F12R2_FB9   %1 9 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB9    Filter bits
: CAN-F12R2_FB10   %1 10 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB10    Filter bits
: CAN-F12R2_FB11   %1 11 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB11    Filter bits
: CAN-F12R2_FB12   %1 12 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB12    Filter bits
: CAN-F12R2_FB13   %1 13 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB13    Filter bits
: CAN-F12R2_FB14   %1 14 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB14    Filter bits
: CAN-F12R2_FB15   %1 15 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB15    Filter bits
: CAN-F12R2_FB16   %1 16 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB16    Filter bits
: CAN-F12R2_FB17   %1 17 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB17    Filter bits
: CAN-F12R2_FB18   %1 18 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB18    Filter bits
: CAN-F12R2_FB19   %1 19 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB19    Filter bits
: CAN-F12R2_FB20   %1 20 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB20    Filter bits
: CAN-F12R2_FB21   %1 21 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB21    Filter bits
: CAN-F12R2_FB22   %1 22 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB22    Filter bits
: CAN-F12R2_FB23   %1 23 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB23    Filter bits
: CAN-F12R2_FB24   %1 24 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB24    Filter bits
: CAN-F12R2_FB25   %1 25 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB25    Filter bits
: CAN-F12R2_FB26   %1 26 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB26    Filter bits
: CAN-F12R2_FB27   %1 27 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB27    Filter bits
: CAN-F12R2_FB28   %1 28 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB28    Filter bits
: CAN-F12R2_FB29   %1 29 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB29    Filter bits
: CAN-F12R2_FB30   %1 30 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB30    Filter bits
: CAN-F12R2_FB31   %1 31 lshift CAN-F12R2 bis! ;  \ CAN-F12R2_FB31    Filter bits

\ CAN-F13R1 (read-write)
: CAN-F13R1_FB0   %1 0 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB0    Filter bits
: CAN-F13R1_FB1   %1 1 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB1    Filter bits
: CAN-F13R1_FB2   %1 2 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB2    Filter bits
: CAN-F13R1_FB3   %1 3 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB3    Filter bits
: CAN-F13R1_FB4   %1 4 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB4    Filter bits
: CAN-F13R1_FB5   %1 5 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB5    Filter bits
: CAN-F13R1_FB6   %1 6 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB6    Filter bits
: CAN-F13R1_FB7   %1 7 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB7    Filter bits
: CAN-F13R1_FB8   %1 8 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB8    Filter bits
: CAN-F13R1_FB9   %1 9 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB9    Filter bits
: CAN-F13R1_FB10   %1 10 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB10    Filter bits
: CAN-F13R1_FB11   %1 11 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB11    Filter bits
: CAN-F13R1_FB12   %1 12 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB12    Filter bits
: CAN-F13R1_FB13   %1 13 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB13    Filter bits
: CAN-F13R1_FB14   %1 14 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB14    Filter bits
: CAN-F13R1_FB15   %1 15 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB15    Filter bits
: CAN-F13R1_FB16   %1 16 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB16    Filter bits
: CAN-F13R1_FB17   %1 17 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB17    Filter bits
: CAN-F13R1_FB18   %1 18 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB18    Filter bits
: CAN-F13R1_FB19   %1 19 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB19    Filter bits
: CAN-F13R1_FB20   %1 20 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB20    Filter bits
: CAN-F13R1_FB21   %1 21 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB21    Filter bits
: CAN-F13R1_FB22   %1 22 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB22    Filter bits
: CAN-F13R1_FB23   %1 23 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB23    Filter bits
: CAN-F13R1_FB24   %1 24 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB24    Filter bits
: CAN-F13R1_FB25   %1 25 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB25    Filter bits
: CAN-F13R1_FB26   %1 26 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB26    Filter bits
: CAN-F13R1_FB27   %1 27 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB27    Filter bits
: CAN-F13R1_FB28   %1 28 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB28    Filter bits
: CAN-F13R1_FB29   %1 29 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB29    Filter bits
: CAN-F13R1_FB30   %1 30 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB30    Filter bits
: CAN-F13R1_FB31   %1 31 lshift CAN-F13R1 bis! ;  \ CAN-F13R1_FB31    Filter bits

\ CAN-F13R2 (read-write)
: CAN-F13R2_FB0   %1 0 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB0    Filter bits
: CAN-F13R2_FB1   %1 1 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB1    Filter bits
: CAN-F13R2_FB2   %1 2 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB2    Filter bits
: CAN-F13R2_FB3   %1 3 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB3    Filter bits
: CAN-F13R2_FB4   %1 4 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB4    Filter bits
: CAN-F13R2_FB5   %1 5 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB5    Filter bits
: CAN-F13R2_FB6   %1 6 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB6    Filter bits
: CAN-F13R2_FB7   %1 7 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB7    Filter bits
: CAN-F13R2_FB8   %1 8 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB8    Filter bits
: CAN-F13R2_FB9   %1 9 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB9    Filter bits
: CAN-F13R2_FB10   %1 10 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB10    Filter bits
: CAN-F13R2_FB11   %1 11 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB11    Filter bits
: CAN-F13R2_FB12   %1 12 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB12    Filter bits
: CAN-F13R2_FB13   %1 13 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB13    Filter bits
: CAN-F13R2_FB14   %1 14 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB14    Filter bits
: CAN-F13R2_FB15   %1 15 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB15    Filter bits
: CAN-F13R2_FB16   %1 16 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB16    Filter bits
: CAN-F13R2_FB17   %1 17 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB17    Filter bits
: CAN-F13R2_FB18   %1 18 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB18    Filter bits
: CAN-F13R2_FB19   %1 19 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB19    Filter bits
: CAN-F13R2_FB20   %1 20 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB20    Filter bits
: CAN-F13R2_FB21   %1 21 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB21    Filter bits
: CAN-F13R2_FB22   %1 22 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB22    Filter bits
: CAN-F13R2_FB23   %1 23 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB23    Filter bits
: CAN-F13R2_FB24   %1 24 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB24    Filter bits
: CAN-F13R2_FB25   %1 25 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB25    Filter bits
: CAN-F13R2_FB26   %1 26 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB26    Filter bits
: CAN-F13R2_FB27   %1 27 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB27    Filter bits
: CAN-F13R2_FB28   %1 28 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB28    Filter bits
: CAN-F13R2_FB29   %1 29 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB29    Filter bits
: CAN-F13R2_FB30   %1 30 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB30    Filter bits
: CAN-F13R2_FB31   %1 31 lshift CAN-F13R2 bis! ;  \ CAN-F13R2_FB31    Filter bits

\ DAC-CR (read-write)
: DAC-CR_EN1   %1 0 lshift DAC-CR bis! ;  \ DAC-CR_EN1    DAC channel1 enable
: DAC-CR_BOFF1   %1 1 lshift DAC-CR bis! ;  \ DAC-CR_BOFF1    DAC channel1 output buffer  disable
: DAC-CR_TEN1   %1 2 lshift DAC-CR bis! ;  \ DAC-CR_TEN1    DAC channel1 trigger  enable
: DAC-CR_TSEL1   ( %XXX -- ) 3 lshift DAC-CR bis! ;  \ DAC-CR_TSEL1    DAC channel1 trigger  selection
: DAC-CR_WAVE1   ( %XX -- ) 6 lshift DAC-CR bis! ;  \ DAC-CR_WAVE1    DAC channel1 noise/triangle wave  generation enable
: DAC-CR_MAMP1   ( %XXXX -- ) 8 lshift DAC-CR bis! ;  \ DAC-CR_MAMP1    DAC channel1 mask/amplitude  selector
: DAC-CR_DMAEN1   %1 12 lshift DAC-CR bis! ;  \ DAC-CR_DMAEN1    DAC channel1 DMA enable
: DAC-CR_EN2   %1 16 lshift DAC-CR bis! ;  \ DAC-CR_EN2    DAC channel2 enable
: DAC-CR_BOFF2   %1 17 lshift DAC-CR bis! ;  \ DAC-CR_BOFF2    DAC channel2 output buffer  disable
: DAC-CR_TEN2   %1 18 lshift DAC-CR bis! ;  \ DAC-CR_TEN2    DAC channel2 trigger  enable
: DAC-CR_TSEL2   ( %XXX -- ) 19 lshift DAC-CR bis! ;  \ DAC-CR_TSEL2    DAC channel2 trigger  selection
: DAC-CR_WAVE2   ( %XX -- ) 22 lshift DAC-CR bis! ;  \ DAC-CR_WAVE2    DAC channel2 noise/triangle wave  generation enable
: DAC-CR_MAMP2   ( %XXXX -- ) 24 lshift DAC-CR bis! ;  \ DAC-CR_MAMP2    DAC channel2 mask/amplitude  selector
: DAC-CR_DMAEN2   %1 28 lshift DAC-CR bis! ;  \ DAC-CR_DMAEN2    DAC channel2 DMA enable

\ DAC-SWTRIGR (write-only)
: DAC-SWTRIGR_SWTRIG1   %1 0 lshift DAC-SWTRIGR bis! ;  \ DAC-SWTRIGR_SWTRIG1    DAC channel1 software  trigger
: DAC-SWTRIGR_SWTRIG2   %1 1 lshift DAC-SWTRIGR bis! ;  \ DAC-SWTRIGR_SWTRIG2    DAC channel2 software  trigger

\ DAC-DHR12R1 (read-write)
: DAC-DHR12R1_DACC1DHR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DHR12R1 bis! ;  \ DAC-DHR12R1_DACC1DHR    DAC channel1 12-bit right-aligned  data

\ DAC-DHR12L1 (read-write)
: DAC-DHR12L1_DACC1DHR   ( %XXXXXXXXXXX -- ) 4 lshift DAC-DHR12L1 bis! ;  \ DAC-DHR12L1_DACC1DHR    DAC channel1 12-bit left-aligned  data

\ DAC-DHR8R1 (read-write)
: DAC-DHR8R1_DACC1DHR   ( %XXXXXXXX -- ) 0 lshift DAC-DHR8R1 bis! ;  \ DAC-DHR8R1_DACC1DHR    DAC channel1 8-bit right-aligned  data

\ DAC-DHR12R2 (read-write)
: DAC-DHR12R2_DACC2DHR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DHR12R2 bis! ;  \ DAC-DHR12R2_DACC2DHR    DAC channel2 12-bit right-aligned  data

\ DAC-DHR12L2 (read-write)
: DAC-DHR12L2_DACC2DHR   ( %XXXXXXXXXXX -- ) 4 lshift DAC-DHR12L2 bis! ;  \ DAC-DHR12L2_DACC2DHR    DAC channel2 12-bit left-aligned  data

\ DAC-DHR8R2 (read-write)
: DAC-DHR8R2_DACC2DHR   ( %XXXXXXXX -- ) 0 lshift DAC-DHR8R2 bis! ;  \ DAC-DHR8R2_DACC2DHR    DAC channel2 8-bit right-aligned  data

\ DAC-DHR12RD (read-write)
: DAC-DHR12RD_DACC1DHR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DHR12RD bis! ;  \ DAC-DHR12RD_DACC1DHR    DAC channel1 12-bit right-aligned  data
: DAC-DHR12RD_DACC2DHR   ( %XXXXXXXXXXX -- ) 16 lshift DAC-DHR12RD bis! ;  \ DAC-DHR12RD_DACC2DHR    DAC channel2 12-bit right-aligned  data

\ DAC-DHR12LD (read-write)
: DAC-DHR12LD_DACC1DHR   ( %XXXXXXXXXXX -- ) 4 lshift DAC-DHR12LD bis! ;  \ DAC-DHR12LD_DACC1DHR    DAC channel1 12-bit left-aligned  data
: DAC-DHR12LD_DACC2DHR   ( %XXXXXXXXXXX -- ) 20 lshift DAC-DHR12LD bis! ;  \ DAC-DHR12LD_DACC2DHR    DAC channel2 12-bit right-aligned  data

\ DAC-DHR8RD (read-write)
: DAC-DHR8RD_DACC1DHR   ( %XXXXXXXX -- ) 0 lshift DAC-DHR8RD bis! ;  \ DAC-DHR8RD_DACC1DHR    DAC channel1 8-bit right-aligned  data
: DAC-DHR8RD_DACC2DHR   ( %XXXXXXXX -- ) 8 lshift DAC-DHR8RD bis! ;  \ DAC-DHR8RD_DACC2DHR    DAC channel2 8-bit right-aligned  data

\ DAC-DOR1 (read-only)
: DAC-DOR1_DACC1DOR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DOR1 bis! ;  \ DAC-DOR1_DACC1DOR    DAC channel1 data output

\ DAC-DOR2 (read-only)
: DAC-DOR2_DACC2DOR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DOR2 bis! ;  \ DAC-DOR2_DACC2DOR    DAC channel2 data output

\ DBG-IDCODE (read-only)
: DBG-IDCODE_DEV_ID   ( %XXXXXXXXXXX -- ) 0 lshift DBG-IDCODE bis! ;  \ DBG-IDCODE_DEV_ID    DEV_ID
: DBG-IDCODE_REV_ID   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift DBG-IDCODE bis! ;  \ DBG-IDCODE_REV_ID    REV_ID

\ DBG-CR (read-write)
: DBG-CR_DBG_SLEEP   %1 0 lshift DBG-CR bis! ;  \ DBG-CR_DBG_SLEEP    DBG_SLEEP
: DBG-CR_DBG_STOP   %1 1 lshift DBG-CR bis! ;  \ DBG-CR_DBG_STOP    DBG_STOP
: DBG-CR_DBG_STANDBY   %1 2 lshift DBG-CR bis! ;  \ DBG-CR_DBG_STANDBY    DBG_STANDBY
: DBG-CR_TRACE_IOEN   %1 5 lshift DBG-CR bis! ;  \ DBG-CR_TRACE_IOEN    TRACE_IOEN
: DBG-CR_TRACE_MODE   ( %XX -- ) 6 lshift DBG-CR bis! ;  \ DBG-CR_TRACE_MODE    TRACE_MODE
: DBG-CR_DBG_IWDG_STOP   %1 8 lshift DBG-CR bis! ;  \ DBG-CR_DBG_IWDG_STOP    DBG_IWDG_STOP
: DBG-CR_DBG_WWDG_STOP   %1 9 lshift DBG-CR bis! ;  \ DBG-CR_DBG_WWDG_STOP    DBG_WWDG_STOP
: DBG-CR_DBG_TIM1_STOP   %1 10 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM1_STOP    DBG_TIM1_STOP
: DBG-CR_DBG_TIM2_STOP   %1 11 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM2_STOP    DBG_TIM2_STOP
: DBG-CR_DBG_TIM3_STOP   %1 12 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM3_STOP    DBG_TIM3_STOP
: DBG-CR_DBG_TIM4_STOP   %1 13 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM4_STOP    DBG_TIM4_STOP
: DBG-CR_DBG_CAN1_STOP   %1 14 lshift DBG-CR bis! ;  \ DBG-CR_DBG_CAN1_STOP    DBG_CAN1_STOP
: DBG-CR_DBG_I2C1_SMBUS_TIMEOUT   %1 15 lshift DBG-CR bis! ;  \ DBG-CR_DBG_I2C1_SMBUS_TIMEOUT    DBG_I2C1_SMBUS_TIMEOUT
: DBG-CR_DBG_I2C2_SMBUS_TIMEOUT   %1 16 lshift DBG-CR bis! ;  \ DBG-CR_DBG_I2C2_SMBUS_TIMEOUT    DBG_I2C2_SMBUS_TIMEOUT
: DBG-CR_DBG_TIM8_STOP   %1 17 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM8_STOP    DBG_TIM8_STOP
: DBG-CR_DBG_TIM5_STOP   %1 18 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM5_STOP    DBG_TIM5_STOP
: DBG-CR_DBG_TIM6_STOP   %1 19 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM6_STOP    DBG_TIM6_STOP
: DBG-CR_DBG_TIM7_STOP   %1 20 lshift DBG-CR bis! ;  \ DBG-CR_DBG_TIM7_STOP    DBG_TIM7_STOP
: DBG-CR_DBG_CAN2_STOP   %1 21 lshift DBG-CR bis! ;  \ DBG-CR_DBG_CAN2_STOP    DBG_CAN2_STOP

\ UART4-SR ()
: UART4-SR_PE   %1 0 lshift UART4-SR bis! ;  \ UART4-SR_PE    Parity error
: UART4-SR_FE   %1 1 lshift UART4-SR bis! ;  \ UART4-SR_FE    Framing error
: UART4-SR_NE   %1 2 lshift UART4-SR bis! ;  \ UART4-SR_NE    Noise error flag
: UART4-SR_ORE   %1 3 lshift UART4-SR bis! ;  \ UART4-SR_ORE    Overrun error
: UART4-SR_IDLE   %1 4 lshift UART4-SR bis! ;  \ UART4-SR_IDLE    IDLE line detected
: UART4-SR_RXNE   %1 5 lshift UART4-SR bis! ;  \ UART4-SR_RXNE    Read data register not  empty
: UART4-SR_TC   %1 6 lshift UART4-SR bis! ;  \ UART4-SR_TC    Transmission complete
: UART4-SR_TXE   %1 7 lshift UART4-SR bis! ;  \ UART4-SR_TXE    Transmit data register  empty
: UART4-SR_LBD   %1 8 lshift UART4-SR bis! ;  \ UART4-SR_LBD    LIN break detection flag

\ UART4-DR (read-write)
: UART4-DR_DR   ( %XXXXXXXXX -- ) 0 lshift UART4-DR bis! ;  \ UART4-DR_DR    DR

\ UART4-BRR (read-write)
: UART4-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift UART4-BRR bis! ;  \ UART4-BRR_DIV_Fraction    DIV_Fraction
: UART4-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift UART4-BRR bis! ;  \ UART4-BRR_DIV_Mantissa    DIV_Mantissa

\ UART4-CR1 (read-write)
: UART4-CR1_SBK   %1 0 lshift UART4-CR1 bis! ;  \ UART4-CR1_SBK    Send break
: UART4-CR1_RWU   %1 1 lshift UART4-CR1 bis! ;  \ UART4-CR1_RWU    Receiver wakeup
: UART4-CR1_RE   %1 2 lshift UART4-CR1 bis! ;  \ UART4-CR1_RE    Receiver enable
: UART4-CR1_TE   %1 3 lshift UART4-CR1 bis! ;  \ UART4-CR1_TE    Transmitter enable
: UART4-CR1_IDLEIE   %1 4 lshift UART4-CR1 bis! ;  \ UART4-CR1_IDLEIE    IDLE interrupt enable
: UART4-CR1_RXNEIE   %1 5 lshift UART4-CR1 bis! ;  \ UART4-CR1_RXNEIE    RXNE interrupt enable
: UART4-CR1_TCIE   %1 6 lshift UART4-CR1 bis! ;  \ UART4-CR1_TCIE    Transmission complete interrupt  enable
: UART4-CR1_TXEIE   %1 7 lshift UART4-CR1 bis! ;  \ UART4-CR1_TXEIE    TXE interrupt enable
: UART4-CR1_PEIE   %1 8 lshift UART4-CR1 bis! ;  \ UART4-CR1_PEIE    PE interrupt enable
: UART4-CR1_PS   %1 9 lshift UART4-CR1 bis! ;  \ UART4-CR1_PS    Parity selection
: UART4-CR1_PCE   %1 10 lshift UART4-CR1 bis! ;  \ UART4-CR1_PCE    Parity control enable
: UART4-CR1_WAKE   %1 11 lshift UART4-CR1 bis! ;  \ UART4-CR1_WAKE    Wakeup method
: UART4-CR1_M   %1 12 lshift UART4-CR1 bis! ;  \ UART4-CR1_M    Word length
: UART4-CR1_UE   %1 13 lshift UART4-CR1 bis! ;  \ UART4-CR1_UE    USART enable

\ UART4-CR2 (read-write)
: UART4-CR2_ADD   ( %XXXX -- ) 0 lshift UART4-CR2 bis! ;  \ UART4-CR2_ADD    Address of the USART node
: UART4-CR2_LBDL   %1 5 lshift UART4-CR2 bis! ;  \ UART4-CR2_LBDL    lin break detection length
: UART4-CR2_LBDIE   %1 6 lshift UART4-CR2 bis! ;  \ UART4-CR2_LBDIE    LIN break detection interrupt  enable
: UART4-CR2_STOP   ( %XX -- ) 12 lshift UART4-CR2 bis! ;  \ UART4-CR2_STOP    STOP bits
: UART4-CR2_LINEN   %1 14 lshift UART4-CR2 bis! ;  \ UART4-CR2_LINEN    LIN mode enable

\ UART4-CR3 (read-write)
: UART4-CR3_EIE   %1 0 lshift UART4-CR3 bis! ;  \ UART4-CR3_EIE    Error interrupt enable
: UART4-CR3_IREN   %1 1 lshift UART4-CR3 bis! ;  \ UART4-CR3_IREN    IrDA mode enable
: UART4-CR3_IRLP   %1 2 lshift UART4-CR3 bis! ;  \ UART4-CR3_IRLP    IrDA low-power
: UART4-CR3_HDSEL   %1 3 lshift UART4-CR3 bis! ;  \ UART4-CR3_HDSEL    Half-duplex selection
: UART4-CR3_DMAR   %1 6 lshift UART4-CR3 bis! ;  \ UART4-CR3_DMAR    DMA enable receiver
: UART4-CR3_DMAT   %1 7 lshift UART4-CR3 bis! ;  \ UART4-CR3_DMAT    DMA enable transmitter

\ UART5-SR ()
: UART5-SR_PE   %1 0 lshift UART5-SR bis! ;  \ UART5-SR_PE    PE
: UART5-SR_FE   %1 1 lshift UART5-SR bis! ;  \ UART5-SR_FE    FE
: UART5-SR_NE   %1 2 lshift UART5-SR bis! ;  \ UART5-SR_NE    NE
: UART5-SR_ORE   %1 3 lshift UART5-SR bis! ;  \ UART5-SR_ORE    ORE
: UART5-SR_IDLE   %1 4 lshift UART5-SR bis! ;  \ UART5-SR_IDLE    IDLE
: UART5-SR_RXNE   %1 5 lshift UART5-SR bis! ;  \ UART5-SR_RXNE    RXNE
: UART5-SR_TC   %1 6 lshift UART5-SR bis! ;  \ UART5-SR_TC    TC
: UART5-SR_TXE   %1 7 lshift UART5-SR bis! ;  \ UART5-SR_TXE    TXE
: UART5-SR_LBD   %1 8 lshift UART5-SR bis! ;  \ UART5-SR_LBD    LBD

\ UART5-DR (read-write)
: UART5-DR_DR   ( %XXXXXXXXX -- ) 0 lshift UART5-DR bis! ;  \ UART5-DR_DR    DR

\ UART5-BRR (read-write)
: UART5-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift UART5-BRR bis! ;  \ UART5-BRR_DIV_Fraction    DIV_Fraction
: UART5-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift UART5-BRR bis! ;  \ UART5-BRR_DIV_Mantissa    DIV_Mantissa

\ UART5-CR1 (read-write)
: UART5-CR1_SBK   %1 0 lshift UART5-CR1 bis! ;  \ UART5-CR1_SBK    SBK
: UART5-CR1_RWU   %1 1 lshift UART5-CR1 bis! ;  \ UART5-CR1_RWU    RWU
: UART5-CR1_RE   %1 2 lshift UART5-CR1 bis! ;  \ UART5-CR1_RE    RE
: UART5-CR1_TE   %1 3 lshift UART5-CR1 bis! ;  \ UART5-CR1_TE    TE
: UART5-CR1_IDLEIE   %1 4 lshift UART5-CR1 bis! ;  \ UART5-CR1_IDLEIE    IDLEIE
: UART5-CR1_RXNEIE   %1 5 lshift UART5-CR1 bis! ;  \ UART5-CR1_RXNEIE    RXNEIE
: UART5-CR1_TCIE   %1 6 lshift UART5-CR1 bis! ;  \ UART5-CR1_TCIE    TCIE
: UART5-CR1_TXEIE   %1 7 lshift UART5-CR1 bis! ;  \ UART5-CR1_TXEIE    TXEIE
: UART5-CR1_PEIE   %1 8 lshift UART5-CR1 bis! ;  \ UART5-CR1_PEIE    PEIE
: UART5-CR1_PS   %1 9 lshift UART5-CR1 bis! ;  \ UART5-CR1_PS    PS
: UART5-CR1_PCE   %1 10 lshift UART5-CR1 bis! ;  \ UART5-CR1_PCE    PCE
: UART5-CR1_WAKE   %1 11 lshift UART5-CR1 bis! ;  \ UART5-CR1_WAKE    WAKE
: UART5-CR1_M   %1 12 lshift UART5-CR1 bis! ;  \ UART5-CR1_M    M
: UART5-CR1_UE   %1 13 lshift UART5-CR1 bis! ;  \ UART5-CR1_UE    UE

\ UART5-CR2 (read-write)
: UART5-CR2_ADD   ( %XXXX -- ) 0 lshift UART5-CR2 bis! ;  \ UART5-CR2_ADD    ADD
: UART5-CR2_LBDL   %1 5 lshift UART5-CR2 bis! ;  \ UART5-CR2_LBDL    LBDL
: UART5-CR2_LBDIE   %1 6 lshift UART5-CR2 bis! ;  \ UART5-CR2_LBDIE    LBDIE
: UART5-CR2_STOP   ( %XX -- ) 12 lshift UART5-CR2 bis! ;  \ UART5-CR2_STOP    STOP
: UART5-CR2_LINEN   %1 14 lshift UART5-CR2 bis! ;  \ UART5-CR2_LINEN    LINEN

\ UART5-CR3 (read-write)
: UART5-CR3_EIE   %1 0 lshift UART5-CR3 bis! ;  \ UART5-CR3_EIE    Error interrupt enable
: UART5-CR3_IREN   %1 1 lshift UART5-CR3 bis! ;  \ UART5-CR3_IREN    IrDA mode enable
: UART5-CR3_IRLP   %1 2 lshift UART5-CR3 bis! ;  \ UART5-CR3_IRLP    IrDA low-power
: UART5-CR3_HDSEL   %1 3 lshift UART5-CR3 bis! ;  \ UART5-CR3_HDSEL    Half-duplex selection
: UART5-CR3_DMAT   %1 7 lshift UART5-CR3 bis! ;  \ UART5-CR3_DMAT    DMA enable transmitter

\ CRC-DR (read-write)
: CRC-DR_DR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC-DR bis! ;  \ CRC-DR_DR    Data Register

\ CRC-IDR (read-write)
: CRC-IDR_IDR   ( %XXXXXXXX -- ) 0 lshift CRC-IDR bis! ;  \ CRC-IDR_IDR    Independent Data register

\ CRC-CR (write-only)
: CRC-CR_RESET   %1 0 lshift CRC-CR bis! ;  \ CRC-CR_RESET    Reset bit

\ FLASH-ACR ()
: FLASH-ACR_LATENCY   ( %XXX -- ) 0 lshift FLASH-ACR bis! ;  \ FLASH-ACR_LATENCY    Latency
: FLASH-ACR_HLFCYA   %1 3 lshift FLASH-ACR bis! ;  \ FLASH-ACR_HLFCYA    Flash half cycle access  enable
: FLASH-ACR_PRFTBE   %1 4 lshift FLASH-ACR bis! ;  \ FLASH-ACR_PRFTBE    Prefetch buffer enable
: FLASH-ACR_PRFTBS   %1 5 lshift FLASH-ACR bis! ;  \ FLASH-ACR_PRFTBS    Prefetch buffer status

\ FLASH-KEYR (write-only)
: FLASH-KEYR_KEY   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FLASH-KEYR bis! ;  \ FLASH-KEYR_KEY    FPEC key

\ FLASH-OPTKEYR (write-only)
: FLASH-OPTKEYR_OPTKEY   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FLASH-OPTKEYR bis! ;  \ FLASH-OPTKEYR_OPTKEY    Option byte key

\ FLASH-SR ()
: FLASH-SR_EOP   %1 5 lshift FLASH-SR bis! ;  \ FLASH-SR_EOP    End of operation
: FLASH-SR_WRPRTERR   %1 4 lshift FLASH-SR bis! ;  \ FLASH-SR_WRPRTERR    Write protection error
: FLASH-SR_PGERR   %1 2 lshift FLASH-SR bis! ;  \ FLASH-SR_PGERR    Programming error
: FLASH-SR_BSY   %1 0 lshift FLASH-SR bis! ;  \ FLASH-SR_BSY    Busy

\ FLASH-CR (read-write)
: FLASH-CR_PG   %1 0 lshift FLASH-CR bis! ;  \ FLASH-CR_PG    Programming
: FLASH-CR_PER   %1 1 lshift FLASH-CR bis! ;  \ FLASH-CR_PER    Page Erase
: FLASH-CR_MER   %1 2 lshift FLASH-CR bis! ;  \ FLASH-CR_MER    Mass Erase
: FLASH-CR_OPTPG   %1 4 lshift FLASH-CR bis! ;  \ FLASH-CR_OPTPG    Option byte programming
: FLASH-CR_OPTER   %1 5 lshift FLASH-CR bis! ;  \ FLASH-CR_OPTER    Option byte erase
: FLASH-CR_STRT   %1 6 lshift FLASH-CR bis! ;  \ FLASH-CR_STRT    Start
: FLASH-CR_LOCK   %1 7 lshift FLASH-CR bis! ;  \ FLASH-CR_LOCK    Lock
: FLASH-CR_OPTWRE   %1 9 lshift FLASH-CR bis! ;  \ FLASH-CR_OPTWRE    Option bytes write enable
: FLASH-CR_ERRIE   %1 10 lshift FLASH-CR bis! ;  \ FLASH-CR_ERRIE    Error interrupt enable
: FLASH-CR_EOPIE   %1 12 lshift FLASH-CR bis! ;  \ FLASH-CR_EOPIE    End of operation interrupt  enable

\ FLASH-AR (write-only)
: FLASH-AR_FAR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FLASH-AR bis! ;  \ FLASH-AR_FAR    Flash Address

\ FLASH-OBR (read-only)
: FLASH-OBR_OPTERR   %1 0 lshift FLASH-OBR bis! ;  \ FLASH-OBR_OPTERR    Option byte error
: FLASH-OBR_RDPRT   %1 1 lshift FLASH-OBR bis! ;  \ FLASH-OBR_RDPRT    Read protection
: FLASH-OBR_WDG_SW   %1 2 lshift FLASH-OBR bis! ;  \ FLASH-OBR_WDG_SW    WDG_SW
: FLASH-OBR_nRST_STOP   %1 3 lshift FLASH-OBR bis! ;  \ FLASH-OBR_nRST_STOP    nRST_STOP
: FLASH-OBR_nRST_STDBY   %1 4 lshift FLASH-OBR bis! ;  \ FLASH-OBR_nRST_STDBY    nRST_STDBY
: FLASH-OBR_Data0   ( %XXXXXXXX -- ) 10 lshift FLASH-OBR bis! ;  \ FLASH-OBR_Data0    Data0
: FLASH-OBR_Data1   ( %XXXXXXXX -- ) 18 lshift FLASH-OBR bis! ;  \ FLASH-OBR_Data1    Data1

\ FLASH-WRPR (read-only)
: FLASH-WRPR_WRP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift FLASH-WRPR bis! ;  \ FLASH-WRPR_WRP    Write protect

\ NVIC-ICTR (read-only)
: NVIC-ICTR_INTLINESNUM   ( %XXXX -- ) 0 lshift NVIC-ICTR bis! ;  \ NVIC-ICTR_INTLINESNUM    Total number of interrupt lines in  groups

\ NVIC-STIR (write-only)
: NVIC-STIR_INTID   ( %XXXXXXXXX -- ) 0 lshift NVIC-STIR bis! ;  \ NVIC-STIR_INTID    interrupt to be triggered

\ NVIC-ISER0 (read-write)
: NVIC-ISER0_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER0 bis! ;  \ NVIC-ISER0_SETENA    SETENA

\ NVIC-ISER1 (read-write)
: NVIC-ISER1_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER1 bis! ;  \ NVIC-ISER1_SETENA    SETENA

\ NVIC-ICER0 (read-write)
: NVIC-ICER0_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER0 bis! ;  \ NVIC-ICER0_CLRENA    CLRENA

\ NVIC-ICER1 (read-write)
: NVIC-ICER1_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER1 bis! ;  \ NVIC-ICER1_CLRENA    CLRENA

\ NVIC-ISPR0 (read-write)
: NVIC-ISPR0_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR0 bis! ;  \ NVIC-ISPR0_SETPEND    SETPEND

\ NVIC-ISPR1 (read-write)
: NVIC-ISPR1_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR1 bis! ;  \ NVIC-ISPR1_SETPEND    SETPEND

\ NVIC-ICPR0 (read-write)
: NVIC-ICPR0_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR0 bis! ;  \ NVIC-ICPR0_CLRPEND    CLRPEND

\ NVIC-ICPR1 (read-write)
: NVIC-ICPR1_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR1 bis! ;  \ NVIC-ICPR1_CLRPEND    CLRPEND

\ NVIC-IABR0 (read-only)
: NVIC-IABR0_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR0 bis! ;  \ NVIC-IABR0_ACTIVE    ACTIVE

\ NVIC-IABR1 (read-only)
: NVIC-IABR1_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR1 bis! ;  \ NVIC-IABR1_ACTIVE    ACTIVE

\ NVIC-IPR0 (read-write)
: NVIC-IPR0_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N0    IPR_N0
: NVIC-IPR0_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N1    IPR_N1
: NVIC-IPR0_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N2    IPR_N2
: NVIC-IPR0_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N3    IPR_N3

\ NVIC-IPR1 (read-write)
: NVIC-IPR1_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N0    IPR_N0
: NVIC-IPR1_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N1    IPR_N1
: NVIC-IPR1_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N2    IPR_N2
: NVIC-IPR1_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N3    IPR_N3

\ NVIC-IPR2 (read-write)
: NVIC-IPR2_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N0    IPR_N0
: NVIC-IPR2_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N1    IPR_N1
: NVIC-IPR2_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N2    IPR_N2
: NVIC-IPR2_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N3    IPR_N3

\ NVIC-IPR3 (read-write)
: NVIC-IPR3_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N0    IPR_N0
: NVIC-IPR3_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N1    IPR_N1
: NVIC-IPR3_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N2    IPR_N2
: NVIC-IPR3_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N3    IPR_N3

\ NVIC-IPR4 (read-write)
: NVIC-IPR4_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N0    IPR_N0
: NVIC-IPR4_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N1    IPR_N1
: NVIC-IPR4_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N2    IPR_N2
: NVIC-IPR4_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N3    IPR_N3

\ NVIC-IPR5 (read-write)
: NVIC-IPR5_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N0    IPR_N0
: NVIC-IPR5_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N1    IPR_N1
: NVIC-IPR5_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N2    IPR_N2
: NVIC-IPR5_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N3    IPR_N3

\ NVIC-IPR6 (read-write)
: NVIC-IPR6_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N0    IPR_N0
: NVIC-IPR6_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N1    IPR_N1
: NVIC-IPR6_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N2    IPR_N2
: NVIC-IPR6_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N3    IPR_N3

\ NVIC-IPR7 (read-write)
: NVIC-IPR7_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N0    IPR_N0
: NVIC-IPR7_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N1    IPR_N1
: NVIC-IPR7_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N2    IPR_N2
: NVIC-IPR7_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N3    IPR_N3

\ NVIC-IPR8 (read-write)
: NVIC-IPR8_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N0    IPR_N0
: NVIC-IPR8_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N1    IPR_N1
: NVIC-IPR8_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N2    IPR_N2
: NVIC-IPR8_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N3    IPR_N3

\ NVIC-IPR9 (read-write)
: NVIC-IPR9_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N0    IPR_N0
: NVIC-IPR9_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N1    IPR_N1
: NVIC-IPR9_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N2    IPR_N2
: NVIC-IPR9_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N3    IPR_N3

\ NVIC-IPR10 (read-write)
: NVIC-IPR10_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N0    IPR_N0
: NVIC-IPR10_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N1    IPR_N1
: NVIC-IPR10_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N2    IPR_N2
: NVIC-IPR10_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N3    IPR_N3

\ NVIC-IPR11 (read-write)
: NVIC-IPR11_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N0    IPR_N0
: NVIC-IPR11_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N1    IPR_N1
: NVIC-IPR11_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N2    IPR_N2
: NVIC-IPR11_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N3    IPR_N3

\ NVIC-IPR12 (read-write)
: NVIC-IPR12_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N0    IPR_N0
: NVIC-IPR12_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N1    IPR_N1
: NVIC-IPR12_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N2    IPR_N2
: NVIC-IPR12_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N3    IPR_N3

\ NVIC-IPR13 (read-write)
: NVIC-IPR13_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N0    IPR_N0
: NVIC-IPR13_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N1    IPR_N1
: NVIC-IPR13_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N2    IPR_N2
: NVIC-IPR13_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N3    IPR_N3

\ NVIC-IPR14 (read-write)
: NVIC-IPR14_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N0    IPR_N0
: NVIC-IPR14_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N1    IPR_N1
: NVIC-IPR14_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N2    IPR_N2
: NVIC-IPR14_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N3    IPR_N3

\ USB-EP0R (read-write)
: USB-EP0R_EA   ( %XXXX -- ) 0 lshift USB-EP0R bis! ;  \ USB-EP0R_EA    Endpoint address
: USB-EP0R_STAT_TX   ( %XX -- ) 4 lshift USB-EP0R bis! ;  \ USB-EP0R_STAT_TX    Status bits, for transmission  transfers
: USB-EP0R_DTOG_TX   %1 6 lshift USB-EP0R bis! ;  \ USB-EP0R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP0R_CTR_TX   %1 7 lshift USB-EP0R bis! ;  \ USB-EP0R_CTR_TX    Correct Transfer for  transmission
: USB-EP0R_EP_KIND   %1 8 lshift USB-EP0R bis! ;  \ USB-EP0R_EP_KIND    Endpoint kind
: USB-EP0R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP0R bis! ;  \ USB-EP0R_EP_TYPE    Endpoint type
: USB-EP0R_SETUP   %1 11 lshift USB-EP0R bis! ;  \ USB-EP0R_SETUP    Setup transaction  completed
: USB-EP0R_STAT_RX   ( %XX -- ) 12 lshift USB-EP0R bis! ;  \ USB-EP0R_STAT_RX    Status bits, for reception  transfers
: USB-EP0R_DTOG_RX   %1 14 lshift USB-EP0R bis! ;  \ USB-EP0R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP0R_CTR_RX   %1 15 lshift USB-EP0R bis! ;  \ USB-EP0R_CTR_RX    Correct transfer for  reception

\ USB-EP1R (read-write)
: USB-EP1R_EA   ( %XXXX -- ) 0 lshift USB-EP1R bis! ;  \ USB-EP1R_EA    Endpoint address
: USB-EP1R_STAT_TX   ( %XX -- ) 4 lshift USB-EP1R bis! ;  \ USB-EP1R_STAT_TX    Status bits, for transmission  transfers
: USB-EP1R_DTOG_TX   %1 6 lshift USB-EP1R bis! ;  \ USB-EP1R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP1R_CTR_TX   %1 7 lshift USB-EP1R bis! ;  \ USB-EP1R_CTR_TX    Correct Transfer for  transmission
: USB-EP1R_EP_KIND   %1 8 lshift USB-EP1R bis! ;  \ USB-EP1R_EP_KIND    Endpoint kind
: USB-EP1R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP1R bis! ;  \ USB-EP1R_EP_TYPE    Endpoint type
: USB-EP1R_SETUP   %1 11 lshift USB-EP1R bis! ;  \ USB-EP1R_SETUP    Setup transaction  completed
: USB-EP1R_STAT_RX   ( %XX -- ) 12 lshift USB-EP1R bis! ;  \ USB-EP1R_STAT_RX    Status bits, for reception  transfers
: USB-EP1R_DTOG_RX   %1 14 lshift USB-EP1R bis! ;  \ USB-EP1R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP1R_CTR_RX   %1 15 lshift USB-EP1R bis! ;  \ USB-EP1R_CTR_RX    Correct transfer for  reception

\ USB-EP2R (read-write)
: USB-EP2R_EA   ( %XXXX -- ) 0 lshift USB-EP2R bis! ;  \ USB-EP2R_EA    Endpoint address
: USB-EP2R_STAT_TX   ( %XX -- ) 4 lshift USB-EP2R bis! ;  \ USB-EP2R_STAT_TX    Status bits, for transmission  transfers
: USB-EP2R_DTOG_TX   %1 6 lshift USB-EP2R bis! ;  \ USB-EP2R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP2R_CTR_TX   %1 7 lshift USB-EP2R bis! ;  \ USB-EP2R_CTR_TX    Correct Transfer for  transmission
: USB-EP2R_EP_KIND   %1 8 lshift USB-EP2R bis! ;  \ USB-EP2R_EP_KIND    Endpoint kind
: USB-EP2R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP2R bis! ;  \ USB-EP2R_EP_TYPE    Endpoint type
: USB-EP2R_SETUP   %1 11 lshift USB-EP2R bis! ;  \ USB-EP2R_SETUP    Setup transaction  completed
: USB-EP2R_STAT_RX   ( %XX -- ) 12 lshift USB-EP2R bis! ;  \ USB-EP2R_STAT_RX    Status bits, for reception  transfers
: USB-EP2R_DTOG_RX   %1 14 lshift USB-EP2R bis! ;  \ USB-EP2R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP2R_CTR_RX   %1 15 lshift USB-EP2R bis! ;  \ USB-EP2R_CTR_RX    Correct transfer for  reception

\ USB-EP3R (read-write)
: USB-EP3R_EA   ( %XXXX -- ) 0 lshift USB-EP3R bis! ;  \ USB-EP3R_EA    Endpoint address
: USB-EP3R_STAT_TX   ( %XX -- ) 4 lshift USB-EP3R bis! ;  \ USB-EP3R_STAT_TX    Status bits, for transmission  transfers
: USB-EP3R_DTOG_TX   %1 6 lshift USB-EP3R bis! ;  \ USB-EP3R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP3R_CTR_TX   %1 7 lshift USB-EP3R bis! ;  \ USB-EP3R_CTR_TX    Correct Transfer for  transmission
: USB-EP3R_EP_KIND   %1 8 lshift USB-EP3R bis! ;  \ USB-EP3R_EP_KIND    Endpoint kind
: USB-EP3R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP3R bis! ;  \ USB-EP3R_EP_TYPE    Endpoint type
: USB-EP3R_SETUP   %1 11 lshift USB-EP3R bis! ;  \ USB-EP3R_SETUP    Setup transaction  completed
: USB-EP3R_STAT_RX   ( %XX -- ) 12 lshift USB-EP3R bis! ;  \ USB-EP3R_STAT_RX    Status bits, for reception  transfers
: USB-EP3R_DTOG_RX   %1 14 lshift USB-EP3R bis! ;  \ USB-EP3R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP3R_CTR_RX   %1 15 lshift USB-EP3R bis! ;  \ USB-EP3R_CTR_RX    Correct transfer for  reception

\ USB-EP4R (read-write)
: USB-EP4R_EA   ( %XXXX -- ) 0 lshift USB-EP4R bis! ;  \ USB-EP4R_EA    Endpoint address
: USB-EP4R_STAT_TX   ( %XX -- ) 4 lshift USB-EP4R bis! ;  \ USB-EP4R_STAT_TX    Status bits, for transmission  transfers
: USB-EP4R_DTOG_TX   %1 6 lshift USB-EP4R bis! ;  \ USB-EP4R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP4R_CTR_TX   %1 7 lshift USB-EP4R bis! ;  \ USB-EP4R_CTR_TX    Correct Transfer for  transmission
: USB-EP4R_EP_KIND   %1 8 lshift USB-EP4R bis! ;  \ USB-EP4R_EP_KIND    Endpoint kind
: USB-EP4R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP4R bis! ;  \ USB-EP4R_EP_TYPE    Endpoint type
: USB-EP4R_SETUP   %1 11 lshift USB-EP4R bis! ;  \ USB-EP4R_SETUP    Setup transaction  completed
: USB-EP4R_STAT_RX   ( %XX -- ) 12 lshift USB-EP4R bis! ;  \ USB-EP4R_STAT_RX    Status bits, for reception  transfers
: USB-EP4R_DTOG_RX   %1 14 lshift USB-EP4R bis! ;  \ USB-EP4R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP4R_CTR_RX   %1 15 lshift USB-EP4R bis! ;  \ USB-EP4R_CTR_RX    Correct transfer for  reception

\ USB-EP5R (read-write)
: USB-EP5R_EA   ( %XXXX -- ) 0 lshift USB-EP5R bis! ;  \ USB-EP5R_EA    Endpoint address
: USB-EP5R_STAT_TX   ( %XX -- ) 4 lshift USB-EP5R bis! ;  \ USB-EP5R_STAT_TX    Status bits, for transmission  transfers
: USB-EP5R_DTOG_TX   %1 6 lshift USB-EP5R bis! ;  \ USB-EP5R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP5R_CTR_TX   %1 7 lshift USB-EP5R bis! ;  \ USB-EP5R_CTR_TX    Correct Transfer for  transmission
: USB-EP5R_EP_KIND   %1 8 lshift USB-EP5R bis! ;  \ USB-EP5R_EP_KIND    Endpoint kind
: USB-EP5R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP5R bis! ;  \ USB-EP5R_EP_TYPE    Endpoint type
: USB-EP5R_SETUP   %1 11 lshift USB-EP5R bis! ;  \ USB-EP5R_SETUP    Setup transaction  completed
: USB-EP5R_STAT_RX   ( %XX -- ) 12 lshift USB-EP5R bis! ;  \ USB-EP5R_STAT_RX    Status bits, for reception  transfers
: USB-EP5R_DTOG_RX   %1 14 lshift USB-EP5R bis! ;  \ USB-EP5R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP5R_CTR_RX   %1 15 lshift USB-EP5R bis! ;  \ USB-EP5R_CTR_RX    Correct transfer for  reception

\ USB-EP6R (read-write)
: USB-EP6R_EA   ( %XXXX -- ) 0 lshift USB-EP6R bis! ;  \ USB-EP6R_EA    Endpoint address
: USB-EP6R_STAT_TX   ( %XX -- ) 4 lshift USB-EP6R bis! ;  \ USB-EP6R_STAT_TX    Status bits, for transmission  transfers
: USB-EP6R_DTOG_TX   %1 6 lshift USB-EP6R bis! ;  \ USB-EP6R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP6R_CTR_TX   %1 7 lshift USB-EP6R bis! ;  \ USB-EP6R_CTR_TX    Correct Transfer for  transmission
: USB-EP6R_EP_KIND   %1 8 lshift USB-EP6R bis! ;  \ USB-EP6R_EP_KIND    Endpoint kind
: USB-EP6R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP6R bis! ;  \ USB-EP6R_EP_TYPE    Endpoint type
: USB-EP6R_SETUP   %1 11 lshift USB-EP6R bis! ;  \ USB-EP6R_SETUP    Setup transaction  completed
: USB-EP6R_STAT_RX   ( %XX -- ) 12 lshift USB-EP6R bis! ;  \ USB-EP6R_STAT_RX    Status bits, for reception  transfers
: USB-EP6R_DTOG_RX   %1 14 lshift USB-EP6R bis! ;  \ USB-EP6R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP6R_CTR_RX   %1 15 lshift USB-EP6R bis! ;  \ USB-EP6R_CTR_RX    Correct transfer for  reception

\ USB-EP7R (read-write)
: USB-EP7R_EA   ( %XXXX -- ) 0 lshift USB-EP7R bis! ;  \ USB-EP7R_EA    Endpoint address
: USB-EP7R_STAT_TX   ( %XX -- ) 4 lshift USB-EP7R bis! ;  \ USB-EP7R_STAT_TX    Status bits, for transmission  transfers
: USB-EP7R_DTOG_TX   %1 6 lshift USB-EP7R bis! ;  \ USB-EP7R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-EP7R_CTR_TX   %1 7 lshift USB-EP7R bis! ;  \ USB-EP7R_CTR_TX    Correct Transfer for  transmission
: USB-EP7R_EP_KIND   %1 8 lshift USB-EP7R bis! ;  \ USB-EP7R_EP_KIND    Endpoint kind
: USB-EP7R_EP_TYPE   ( %XX -- ) 9 lshift USB-EP7R bis! ;  \ USB-EP7R_EP_TYPE    Endpoint type
: USB-EP7R_SETUP   %1 11 lshift USB-EP7R bis! ;  \ USB-EP7R_SETUP    Setup transaction  completed
: USB-EP7R_STAT_RX   ( %XX -- ) 12 lshift USB-EP7R bis! ;  \ USB-EP7R_STAT_RX    Status bits, for reception  transfers
: USB-EP7R_DTOG_RX   %1 14 lshift USB-EP7R bis! ;  \ USB-EP7R_DTOG_RX    Data Toggle, for reception  transfers
: USB-EP7R_CTR_RX   %1 15 lshift USB-EP7R bis! ;  \ USB-EP7R_CTR_RX    Correct transfer for  reception

\ USB-CNTR (read-write)
: USB-CNTR_FRES   %1 0 lshift USB-CNTR bis! ;  \ USB-CNTR_FRES    Force USB Reset
: USB-CNTR_PDWN   %1 1 lshift USB-CNTR bis! ;  \ USB-CNTR_PDWN    Power down
: USB-CNTR_LPMODE   %1 2 lshift USB-CNTR bis! ;  \ USB-CNTR_LPMODE    Low-power mode
: USB-CNTR_FSUSP   %1 3 lshift USB-CNTR bis! ;  \ USB-CNTR_FSUSP    Force suspend
: USB-CNTR_RESUME   %1 4 lshift USB-CNTR bis! ;  \ USB-CNTR_RESUME    Resume request
: USB-CNTR_ESOFM   %1 8 lshift USB-CNTR bis! ;  \ USB-CNTR_ESOFM    Expected start of frame interrupt  mask
: USB-CNTR_SOFM   %1 9 lshift USB-CNTR bis! ;  \ USB-CNTR_SOFM    Start of frame interrupt  mask
: USB-CNTR_RESETM   %1 10 lshift USB-CNTR bis! ;  \ USB-CNTR_RESETM    USB reset interrupt mask
: USB-CNTR_SUSPM   %1 11 lshift USB-CNTR bis! ;  \ USB-CNTR_SUSPM    Suspend mode interrupt  mask
: USB-CNTR_WKUPM   %1 12 lshift USB-CNTR bis! ;  \ USB-CNTR_WKUPM    Wakeup interrupt mask
: USB-CNTR_ERRM   %1 13 lshift USB-CNTR bis! ;  \ USB-CNTR_ERRM    Error interrupt mask
: USB-CNTR_PMAOVRM   %1 14 lshift USB-CNTR bis! ;  \ USB-CNTR_PMAOVRM    Packet memory area over / underrun  interrupt mask
: USB-CNTR_CTRM   %1 15 lshift USB-CNTR bis! ;  \ USB-CNTR_CTRM    Correct transfer interrupt  mask

\ USB-ISTR (read-write)
: USB-ISTR_EP_ID   ( %XXXX -- ) 0 lshift USB-ISTR bis! ;  \ USB-ISTR_EP_ID    Endpoint Identifier
: USB-ISTR_DIR   %1 4 lshift USB-ISTR bis! ;  \ USB-ISTR_DIR    Direction of transaction
: USB-ISTR_ESOF   %1 8 lshift USB-ISTR bis! ;  \ USB-ISTR_ESOF    Expected start frame
: USB-ISTR_SOF   %1 9 lshift USB-ISTR bis! ;  \ USB-ISTR_SOF    start of frame
: USB-ISTR_RESET   %1 10 lshift USB-ISTR bis! ;  \ USB-ISTR_RESET    reset request
: USB-ISTR_SUSP   %1 11 lshift USB-ISTR bis! ;  \ USB-ISTR_SUSP    Suspend mode request
: USB-ISTR_WKUP   %1 12 lshift USB-ISTR bis! ;  \ USB-ISTR_WKUP    Wakeup
: USB-ISTR_ERR   %1 13 lshift USB-ISTR bis! ;  \ USB-ISTR_ERR    Error
: USB-ISTR_PMAOVR   %1 14 lshift USB-ISTR bis! ;  \ USB-ISTR_PMAOVR    Packet memory area over /  underrun
: USB-ISTR_CTR   %1 15 lshift USB-ISTR bis! ;  \ USB-ISTR_CTR    Correct transfer

\ USB-FNR (read-only)
: USB-FNR_FN  0 lshift USB-FNR bis! ;  \ USB-FNR_FN    Frame number
: USB-FNR_LSOF   ( %XX -- ) 11 lshift USB-FNR bis! ;  \ USB-FNR_LSOF    Lost SOF
: USB-FNR_LCK   %1 13 lshift USB-FNR bis! ;  \ USB-FNR_LCK    Locked
: USB-FNR_RXDM   %1 14 lshift USB-FNR bis! ;  \ USB-FNR_RXDM    Receive data - line status
: USB-FNR_RXDP   %1 15 lshift USB-FNR bis! ;  \ USB-FNR_RXDP    Receive data + line status

\ USB-DADDR (read-write)
: USB-DADDR_ADD   ( %XXXXXXX -- ) 0 lshift USB-DADDR bis! ;  \ USB-DADDR_ADD    Device address
: USB-DADDR_EF   %1 7 lshift USB-DADDR bis! ;  \ USB-DADDR_EF    Enable function

\ USB-BTABLE (read-write)
: USB-BTABLE_BTABLE  3 lshift USB-BTABLE bis! ;  \ USB-BTABLE_BTABLE    Buffer table
