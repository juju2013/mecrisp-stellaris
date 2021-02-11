/*
@    Mecrisp-Stellaris - A native code Forth implementation for ARM-Cortex M microcontrollers
@    Copyright (C) 2021  juju2013@github, and rcgldr@stackoverflow
@
@    This program is free software: you can redistribute it and/or modify
@    it under the terms of the GNU General Public License as published by
@    the Free Software Foundation, either version 3 of the License, or
@    (at your option) any later version.
@
@    This program is distributed in the hope that it will be useful,
@    but WITHOUT ANY WARRANTY; without even the implied warranty of
@    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
@    GNU General Public License for more details.
@
@    You should have received a copy of the GNU General Public License
@    along with this program.  If not, see <http://www.gnu.org/licenses/>.
@

Helper program to produce the correct crc32 from the first 252 bytes 
shamelessly copied from https://stackoverflow.com/questions/54339800/how-to-modify-crc-32-to-crc-32-mpeg-2/54351365#54351365
*/

#include <stdio.h>
#include <stdlib.h>

#define MAXSIZE 252

unsigned int crc32b(unsigned char *message, size_t l)
{
   size_t i, j;
   unsigned int crc, msb;

   crc = 0xFFFFFFFF;
   for(i = 0; i < l; i++) {
      // xor next byte to upper bits of crc
      crc ^= (((unsigned int)message[i])<<24);
      for (j = 0; j < 8; j++) {    // Do eight times.
            msb = crc>>31;
            crc <<= 1;
            crc ^= (0 - msb) & 0x04C11DB7;
      }
   }
   return crc;         // don't complement crc on output
}


unsigned char input_buffer[MAXSIZE+4+4];
int main(int argc, char *argv[]) {
  if ( argc != 2 ) {
    printf("Usage : %s input_file\n", argv[0]);
    return 1;
  }
  
  FILE *f = fopen(argv[1], "rb");
  if (f == NULL) {
    printf("Error reading '%s'\n", argv[1]);
    return 1;
  }
  
  fread(input_buffer, MAXSIZE, 1, f);
  fclose(f);
  unsigned int crc32;
  crc32 = crc32b(input_buffer, MAXSIZE);
  printf("%#08x\n", crc32);
  return 0;
}
