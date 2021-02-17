
ARMGNU?=arm-none-eabi

# debug build
COPS = -Wall  -Os -nostdlib -nostartfiles -ffreestanding -save-temps
AOPS = --warn --fatal-warnings
all : mecrisp-stellaris-rp2040.bin crc32 mecrisp-stellaris-rp2040.uf2 mecrisp-stellaris-rp2040.elf

crc32 : crc32.c
	gcc -o crc32 crc32.c

mecrisp-stellaris-rp2040.o : mecrisp-stellaris-rp2040.s
	$(ARMGNU)-as ${AOPS} mecrisp-stellaris-rp2040.s -g -o mecrisp-stellaris-rp2040.o

stage2.bin : mecrisp-stellaris-rp2040.o crc32
	$(ARMGNU)-ld --defsym=FLASHCRC32=0 -o stage2.elf -T memmap mecrisp-stellaris-rp2040.o
	$(ARMGNU)-objcopy stage2.elf stage2.bin -O binary 

mecrisp-stellaris-rp2040.bin : memmap stage2.bin crc32 mecrisp-stellaris-rp2040.o
	$(ARMGNU)-ld --defsym=FLASHCRC32='$(shell ./crc32 stage2.bin)' -o mecrisp-stellaris-rp2040.elf -T memmap mecrisp-stellaris-rp2040.o
	$(ARMGNU)-objdump -S -D mecrisp-stellaris-rp2040.elf > mecrisp-stellaris-rp2040.list
	$(ARMGNU)-objcopy mecrisp-stellaris-rp2040.elf mecrisp-stellaris-rp2040.bin -O binary
	$(ARMGNU)-objcopy mecrisp-stellaris-rp2040.elf mecrisp-stellaris-rp2040.hex -O ihex

mecrisp-stellaris-rp2040.uf2 : mecrisp-stellaris-rp2040.elf
	elf2uf2 mecrisp-stellaris-rp2040.elf mecrisp-stellaris-rp2040.uf2

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
	rm -f *.hex
	rm -f *.uf2
	rm -f crc32
