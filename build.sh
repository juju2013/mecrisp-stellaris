#! /bin/bash

ROOT=$(pwd)
BOARD=stm32f103
TARGET=/data/bluepill/tachometer
PERIPHERALS=$ROOT/common/svd2forth-v4/peripherals

rm tmp.bin 2>&1 > /dev/null
cd $ROOT/mecrisp-stellaris-source/$BOARD
make clean && make && cp *.bin $ROOT/tmp.bin
mkdir -p $TARGET/peripherals
cp $PERIPHERALS/* $TARGET/peripherals/


cd $ROOT
set -e
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/hexdump.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/io.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/pins48.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/disassembler-m3.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/svd.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin

# mandatory 
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/FSMC.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/PWR.fs    $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/RCC.fs    $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin

# optional
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $PERIPHERALS/../1b.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/GPIOA.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/GPIOB.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/GPIOC.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/GPIOD.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/GPIOE.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/GPIOF.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/GPIOG.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/AFIO.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/EXTI.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/DMA1.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/DMA2.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/SDIO.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/RTC.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/BKP.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/IWDG.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/WWDG.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM1.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM8.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM2.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM3.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM4.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM5.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM9.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM12.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM10.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM11.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM13.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM14.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM6.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/TIM7.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/I2C1.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/I2C2.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/SPI1.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/SPI2.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/SPI3.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/USART1.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/USART2.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/USART3.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/ADC1.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/ADC2.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/ADC3.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/CAN.fs    $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/DAC.fs    $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/DBG.fs    $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/UART4.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/UART5.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/CRC.fs    $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/FLASH.fs  $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
 thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/NVIC.fs   $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
# thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/peripherals/USB.fs    $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin

thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/misc.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/interrupt.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/multi.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/usb.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/timer.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
#thumbulator/buildcore thumbulator/thumbulator-stm32f103 $ROOT/tmp.bin $TARGET/adc.fs $ROOT/tmp2.bin && mv -f $ROOT/tmp2.bin $ROOT/tmp.bin
cp $ROOT/tmp.bin $TARGET/firmware.bin
