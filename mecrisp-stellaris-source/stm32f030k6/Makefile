
ARMGNU?=arm-none-eabi

COPS = -Wall  -Os -nostdlib -nostartfiles -ffreestanding -save-temps
AOPS = --warn --fatal-warnings

all : mecrisp-stellaris-stm32f030k6.bin 

mecrisp-stellaris-stm32f030k6.o : mecrisp-stellaris-stm32f030k6.s
	$(ARMGNU)-as mecrisp-stellaris-stm32f030k6.s -o mecrisp-stellaris-stm32f030k6.o

mecrisp-stellaris-stm32f030k6.bin : memmap mecrisp-stellaris-stm32f030k6.o
	$(ARMGNU)-ld -o mecrisp-stellaris-stm32f030k6.elf -T memmap mecrisp-stellaris-stm32f030k6.o
	$(ARMGNU)-objdump -D mecrisp-stellaris-stm32f030k6.elf > mecrisp-stellaris-stm32f030k6.list
	$(ARMGNU)-objcopy mecrisp-stellaris-stm32f030k6.elf mecrisp-stellaris-stm32f030k6.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
