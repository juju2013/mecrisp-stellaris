\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

0xE000E000 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC 0x4 + constant NVIC-ICTR ( Interrupt Controller Type  Register ) 
NVIC 0xF00 + constant NVIC-STIR ( Software Triggered Interrupt  Register ) 
NVIC 0x100 + constant NVIC-ISER0 ( Interrupt Set-Enable Register ) 
NVIC 0x104 + constant NVIC-ISER1 ( Interrupt Set-Enable Register ) 
NVIC 0x180 + constant NVIC-ICER0 ( Interrupt Clear-Enable  Register ) 
NVIC 0x184 + constant NVIC-ICER1 ( Interrupt Clear-Enable  Register ) 
NVIC 0x200 + constant NVIC-ISPR0 ( Interrupt Set-Pending Register ) 
NVIC 0x204 + constant NVIC-ISPR1 ( Interrupt Set-Pending Register ) 
NVIC 0x280 + constant NVIC-ICPR0 ( Interrupt Clear-Pending  Register ) 
NVIC 0x284 + constant NVIC-ICPR1 ( Interrupt Clear-Pending  Register ) 
NVIC 0x300 + constant NVIC-IABR0 ( Interrupt Active Bit Register ) 
NVIC 0x304 + constant NVIC-IABR1 ( Interrupt Active Bit Register ) 
NVIC 0x400 + constant NVIC-IPR0 ( Interrupt Priority Register ) 
NVIC 0x404 + constant NVIC-IPR1 ( Interrupt Priority Register ) 
NVIC 0x408 + constant NVIC-IPR2 ( Interrupt Priority Register ) 
NVIC 0x40C + constant NVIC-IPR3 ( Interrupt Priority Register ) 
NVIC 0x410 + constant NVIC-IPR4 ( Interrupt Priority Register ) 
NVIC 0x414 + constant NVIC-IPR5 ( Interrupt Priority Register ) 
NVIC 0x418 + constant NVIC-IPR6 ( Interrupt Priority Register ) 
NVIC 0x41C + constant NVIC-IPR7 ( Interrupt Priority Register ) 
NVIC 0x420 + constant NVIC-IPR8 ( Interrupt Priority Register ) 
NVIC 0x424 + constant NVIC-IPR9 ( Interrupt Priority Register ) 
NVIC 0x428 + constant NVIC-IPR10 ( Interrupt Priority Register ) 
NVIC 0x42C + constant NVIC-IPR11 ( Interrupt Priority Register ) 
NVIC 0x430 + constant NVIC-IPR12 ( Interrupt Priority Register ) 
NVIC 0x434 + constant NVIC-IPR13 ( Interrupt Priority Register ) 
NVIC 0x438 + constant NVIC-IPR14 ( Interrupt Priority Register ) 
