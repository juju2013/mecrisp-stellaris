@
@    Mecrisp-Stellaris - A native code Forth implementation for ARM-Cortex M microcontrollers
@    Copyright (C) 2013  Matthias Koch
@    Copyright (C) 2021  juju2013@github
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

@ Writing and erasing the flash memory in the RP2040

@ Write and Erase Flash in rp2040.
@ Porting: Rewrite this ! You need hflash! and - as far as possible - cflash!

    .equ CONFIG0    ,0x00300000  @ USER CONFIG0
    .equ CONFIG1    ,CONFIG0+4   @ USER CONFIG0
    .equ FMC_BA     ,0x5000C000  @ Base FMC address
    .equ ISPCON     ,FMC_BA+0x00 @ R/W ISP Control Register 0x0000_0000 
    .equ ISPADR     ,FMC_BA+0x04 @ R/W ISP Address Register 0x0000_0000 
    .equ ISPDAT     ,FMC_BA+0x08 @ R/W ISP Data Register 0x0000_0000 
    .equ ISPCMD     ,FMC_BA+0x0C @ R/W ISP Command Register 0x0000_0000 
    .equ ISPTRG     ,FMC_BA+0x10 @ R/W ISP Trigger Register 0x0000_0000 
    .equ DFBADR     ,FMC_BA+0x14 @ R Data Flash Start Address (DFVSEN = 1) 0x0001_F000 
    .equ DFBADR     ,FMC_BA+0x14 @ R Data Flash Start Address (DFVSEN = 0) CONFIG1 
    .equ FATCON     ,FMC_BA+0x18 @ R/W Flash Access Window Control Register 0x0000_0000 
    .equ ISPSTA     ,FMC_BA+0x40 @ R ISP Status Register 0x0000_0000

    .equ ISPCMD_ERASE   ,0x22    
    .equ ISPCMD_WRITE   ,0x21
    .equ ISPCMD_READ    ,0
    .equ ISPCMD_COMID   ,0x0b   @ Company ID
    .equ ISPCMD_UID     ,0x04   @ UNIQ ID    
    .equ ISPCMD_VMAP    ,0x2e   @ Vector map
    
    .equ PAGE_ADR_MASK  ,~(512-1)  @bitmask for page addressc

@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "hflash!" @ ( x Addr -- )
  @ Schreibt an die auf 2 gerade Adresse in den Flash.
  @ Write a halfword to the flash.
h_flashkomma:
@ -----------------------------------------------------------------------------
  push {lr}
  
  popda r0 @ Adresse
  popda r1 @ Inhalt / content

@XXX TBD

4:pop {pc}
5:Fehler_Quit "Wrong address or data for writing flash !"


@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "flashpageerase" @ ( Addr -- ) any address, will start at 512 boundery
  @ Deletes a 512 bytes Flash page
flashpageerase:
@ -----------------------------------------------------------------------------
  push    {lr}
  popda   r0 @ Adresse of page to erase

@XXX TBD

2:pop {pc}

@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "eraseflash" @ ( -- )
  @ Löscht den gesamten Inhalt des Flashdictionaries.
  @ Clears the entire contents of the Flash dictionary.
@ -----------------------------------------------------------------------------
  ldr r0,   =FlashDictionaryAnfang
eraseflash_intern:
  cpsid     i
  ldr       r1, =FlashDictionaryEnde

@XXX TBD
  bl        Restart

@ -----------------------------------------------------------------------------
  Wortbirne Flag_visible, "eraseflashfrom" @ ( Addr -- )
  @ Beginnt an der angegebenen Adresse mit dem Löschen des Dictionaries.
@ -----------------------------------------------------------------------------
flasherasefrom:
  push    {lr}
  popda r0
  bx lr
