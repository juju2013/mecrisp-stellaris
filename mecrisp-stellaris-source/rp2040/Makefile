
ARMGNU?=arm-none-eabi

# debug build
COPS = -Wall  -Os -nostdlib -nostartfiles -ffreestanding -save-temps
AOPS = --warn --fatal-warnings
all : mecrisp-stellaris-rp2040.bin crc32

crc32 : crc32.c
	gcc -o crc32 crc32.c

mecrisp-stellaris-rp2040.o : mecrisp-stellaris-rp2040.s
	$(ARMGNU)-as ${AOPS} mecrisp-stellaris-rp2040.s -g -o mecrisp-stellaris-rp2040.o

temp.bin : mecrisp-stellaris-rp2040.o crc32
	$(ARMGNU)-ld --defsym=FLASHCRC32=0 -o mecrisp-stellaris-rp2040.elf -T memmap mecrisp-stellaris-rp2040.o
	$(ARMGNU)-objcopy mecrisp-stellaris-rp2040.o temp.bin -O binary 

mecrisp-stellaris-rp2040.bin : memmap temp.bin crc32 mecrisp-stellaris-rp2040.o
	$(ARMGNU)-ld --defsym=FLASHCRC32='$(shell ./crc32 temp.bin)' -o mecrisp-stellaris-rp2040.elf -T memmap mecrisp-stellaris-rp2040.o
	$(ARMGNU)-objdump -S -D mecrisp-stellaris-rp2040.elf > mecrisp-stellaris-rp2040.list
	$(ARMGNU)-objcopy mecrisp-stellaris-rp2040.elf mecrisp-stellaris-rp2040.bin -O binary
	$(ARMGNU)-objcopy mecrisp-stellaris-rp2040.elf mecrisp-stellaris-rp2040.hex -O ihex

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
	rm -f *.hex
	rm -f crc32
