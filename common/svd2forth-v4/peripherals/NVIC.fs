\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$E000E000 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $4 + constant NVIC-ICTR ( Interrupt Controller Type  Register ) 
NVIC $F00 + constant NVIC-STIR ( Software Triggered Interrupt  Register ) 
NVIC $100 + constant NVIC-ISER0 ( Interrupt Set-Enable Register ) 
NVIC $104 + constant NVIC-ISER1 ( Interrupt Set-Enable Register ) 
NVIC $180 + constant NVIC-ICER0 ( Interrupt Clear-Enable  Register ) 
NVIC $184 + constant NVIC-ICER1 ( Interrupt Clear-Enable  Register ) 
NVIC $200 + constant NVIC-ISPR0 ( Interrupt Set-Pending Register ) 
NVIC $204 + constant NVIC-ISPR1 ( Interrupt Set-Pending Register ) 
NVIC $280 + constant NVIC-ICPR0 ( Interrupt Clear-Pending  Register ) 
NVIC $284 + constant NVIC-ICPR1 ( Interrupt Clear-Pending  Register ) 
NVIC $300 + constant NVIC-IABR0 ( Interrupt Active Bit Register ) 
NVIC $304 + constant NVIC-IABR1 ( Interrupt Active Bit Register ) 
NVIC $400 + constant NVIC-IPR0 ( Interrupt Priority Register ) 
NVIC $404 + constant NVIC-IPR1 ( Interrupt Priority Register ) 
NVIC $408 + constant NVIC-IPR2 ( Interrupt Priority Register ) 
NVIC $40C + constant NVIC-IPR3 ( Interrupt Priority Register ) 
NVIC $410 + constant NVIC-IPR4 ( Interrupt Priority Register ) 
NVIC $414 + constant NVIC-IPR5 ( Interrupt Priority Register ) 
NVIC $418 + constant NVIC-IPR6 ( Interrupt Priority Register ) 
NVIC $41C + constant NVIC-IPR7 ( Interrupt Priority Register ) 
NVIC $420 + constant NVIC-IPR8 ( Interrupt Priority Register ) 
NVIC $424 + constant NVIC-IPR9 ( Interrupt Priority Register ) 
NVIC $428 + constant NVIC-IPR10 ( Interrupt Priority Register ) 
NVIC $42C + constant NVIC-IPR11 ( Interrupt Priority Register ) 
NVIC $430 + constant NVIC-IPR12 ( Interrupt Priority Register ) 
NVIC $434 + constant NVIC-IPR13 ( Interrupt Priority Register ) 
NVIC $438 + constant NVIC-IPR14 ( Interrupt Priority Register ) 
