\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0x40005C00 constant USB ( Universal serial bus full-speed device  interface ) 
USB 0x0 + constant USB-EP0R ( endpoint 0 register ) 
USB 0x4 + constant USB-EP1R ( endpoint 1 register ) 
USB 0x8 + constant USB-EP2R ( endpoint 2 register ) 
USB 0xC + constant USB-EP3R ( endpoint 3 register ) 
USB 0x10 + constant USB-EP4R ( endpoint 4 register ) 
USB 0x14 + constant USB-EP5R ( endpoint 5 register ) 
USB 0x18 + constant USB-EP6R ( endpoint 6 register ) 
USB 0x1C + constant USB-EP7R ( endpoint 7 register ) 
USB 0x40 + constant USB-CNTR ( control register ) 
USB 0x44 + constant USB-ISTR ( interrupt status register ) 
USB 0x48 + constant USB-FNR ( frame number register ) 
USB 0x4C + constant USB-DADDR ( device address ) 
USB 0x50 + constant USB-BTABLE ( Buffer table address ) 
