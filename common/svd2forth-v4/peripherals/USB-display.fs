\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: USB-EP0R. ." USB-EP0R (read-write) $" USB-EP0R @ hex. USB-EP0R 1b. ;
: USB-EP1R. ." USB-EP1R (read-write) $" USB-EP1R @ hex. USB-EP1R 1b. ;
: USB-EP2R. ." USB-EP2R (read-write) $" USB-EP2R @ hex. USB-EP2R 1b. ;
: USB-EP3R. ." USB-EP3R (read-write) $" USB-EP3R @ hex. USB-EP3R 1b. ;
: USB-EP4R. ." USB-EP4R (read-write) $" USB-EP4R @ hex. USB-EP4R 1b. ;
: USB-EP5R. ." USB-EP5R (read-write) $" USB-EP5R @ hex. USB-EP5R 1b. ;
: USB-EP6R. ." USB-EP6R (read-write) $" USB-EP6R @ hex. USB-EP6R 1b. ;
: USB-EP7R. ." USB-EP7R (read-write) $" USB-EP7R @ hex. USB-EP7R 1b. ;
: USB-CNTR. ." USB-CNTR (read-write) $" USB-CNTR @ hex. USB-CNTR 1b. ;
: USB-ISTR. ." USB-ISTR (read-write) $" USB-ISTR @ hex. USB-ISTR 1b. ;
: USB-FNR. ." USB-FNR (read-only) $" USB-FNR @ hex. USB-FNR 1b. ;
: USB-DADDR. ." USB-DADDR (read-write) $" USB-DADDR @ hex. USB-DADDR 1b. ;
: USB-BTABLE. ." USB-BTABLE (read-write) $" USB-BTABLE @ hex. USB-BTABLE 1b. ;
: USB.
USB-EP0R.
USB-EP1R.
USB-EP2R.
USB-EP3R.
USB-EP4R.
USB-EP5R.
USB-EP6R.
USB-EP7R.
USB-CNTR.
USB-ISTR.
USB-FNR.
USB-DADDR.
USB-BTABLE.
;

