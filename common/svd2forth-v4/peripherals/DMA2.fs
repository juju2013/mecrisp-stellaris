\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40020400 constant DMA2 ( DMA controller ) 
DMA2 $0 + constant DMA2-ISR ( DMA interrupt status register  DMA_ISR ) 
DMA2 $4 + constant DMA2-IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA2 $8 + constant DMA2-CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $C + constant DMA2-CNDTR1 ( DMA channel 1 number of data  register ) 
DMA2 $10 + constant DMA2-CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA2 $14 + constant DMA2-CMAR1 ( DMA channel 1 memory address  register ) 
DMA2 $1C + constant DMA2-CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $20 + constant DMA2-CNDTR2 ( DMA channel 2 number of data  register ) 
DMA2 $24 + constant DMA2-CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA2 $28 + constant DMA2-CMAR2 ( DMA channel 2 memory address  register ) 
DMA2 $30 + constant DMA2-CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $34 + constant DMA2-CNDTR3 ( DMA channel 3 number of data  register ) 
DMA2 $38 + constant DMA2-CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA2 $3C + constant DMA2-CMAR3 ( DMA channel 3 memory address  register ) 
DMA2 $44 + constant DMA2-CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $48 + constant DMA2-CNDTR4 ( DMA channel 4 number of data  register ) 
DMA2 $4C + constant DMA2-CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA2 $50 + constant DMA2-CMAR4 ( DMA channel 4 memory address  register ) 
DMA2 $58 + constant DMA2-CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $5C + constant DMA2-CNDTR5 ( DMA channel 5 number of data  register ) 
DMA2 $60 + constant DMA2-CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA2 $64 + constant DMA2-CMAR5 ( DMA channel 5 memory address  register ) 
DMA2 $6C + constant DMA2-CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $70 + constant DMA2-CNDTR6 ( DMA channel 6 number of data  register ) 
DMA2 $74 + constant DMA2-CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA2 $78 + constant DMA2-CMAR6 ( DMA channel 6 memory address  register ) 
DMA2 $80 + constant DMA2-CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA2 $84 + constant DMA2-CNDTR7 ( DMA channel 7 number of data  register ) 
DMA2 $88 + constant DMA2-CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA2 $8C + constant DMA2-CMAR7 ( DMA channel 7 memory address  register ) 
