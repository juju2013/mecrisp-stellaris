\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020


compiletoflash
$40020000 constant DMA1 ( DMA controller ) 
DMA1 $0 + constant DMA1-ISR ( DMA interrupt status register  DMA_ISR ) 
DMA1 $4 + constant DMA1-IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA1 $8 + constant DMA1-CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $C + constant DMA1-CNDTR1 ( DMA channel 1 number of data  register ) 
DMA1 $10 + constant DMA1-CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA1 $14 + constant DMA1-CMAR1 ( DMA channel 1 memory address  register ) 
DMA1 $1C + constant DMA1-CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $20 + constant DMA1-CNDTR2 ( DMA channel 2 number of data  register ) 
DMA1 $24 + constant DMA1-CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA1 $28 + constant DMA1-CMAR2 ( DMA channel 2 memory address  register ) 
DMA1 $30 + constant DMA1-CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $34 + constant DMA1-CNDTR3 ( DMA channel 3 number of data  register ) 
DMA1 $38 + constant DMA1-CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA1 $3C + constant DMA1-CMAR3 ( DMA channel 3 memory address  register ) 
DMA1 $44 + constant DMA1-CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $48 + constant DMA1-CNDTR4 ( DMA channel 4 number of data  register ) 
DMA1 $4C + constant DMA1-CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA1 $50 + constant DMA1-CMAR4 ( DMA channel 4 memory address  register ) 
DMA1 $58 + constant DMA1-CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $5C + constant DMA1-CNDTR5 ( DMA channel 5 number of data  register ) 
DMA1 $60 + constant DMA1-CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA1 $64 + constant DMA1-CMAR5 ( DMA channel 5 memory address  register ) 
DMA1 $6C + constant DMA1-CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $70 + constant DMA1-CNDTR6 ( DMA channel 6 number of data  register ) 
DMA1 $74 + constant DMA1-CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA1 $78 + constant DMA1-CMAR6 ( DMA channel 6 memory address  register ) 
DMA1 $80 + constant DMA1-CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA1 $84 + constant DMA1-CNDTR7 ( DMA channel 7 number of data  register ) 
DMA1 $88 + constant DMA1-CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA1 $8C + constant DMA1-CMAR7 ( DMA channel 7 memory address  register ) 
