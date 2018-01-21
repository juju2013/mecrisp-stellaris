.syntax unified 
.cpu cortex-m0
.text
  .thumb

  .thumb_func
  .global test
test:
  ldr   r0, =0x100
  adds  r1, r0, #4
  bx lr
