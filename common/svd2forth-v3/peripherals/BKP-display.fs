\ TEMPLATE FILE for STM32F103xx
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\   Modified by juju2013@github - 2020

: BKP-DR1. ." BKP-DR1 (read-write) $" BKP-DR1 @ hex. BKP-DR1 1b. ;
: BKP-DR2. ." BKP-DR2 (read-write) $" BKP-DR2 @ hex. BKP-DR2 1b. ;
: BKP-DR3. ." BKP-DR3 (read-write) $" BKP-DR3 @ hex. BKP-DR3 1b. ;
: BKP-DR4. ." BKP-DR4 (read-write) $" BKP-DR4 @ hex. BKP-DR4 1b. ;
: BKP-DR5. ." BKP-DR5 (read-write) $" BKP-DR5 @ hex. BKP-DR5 1b. ;
: BKP-DR6. ." BKP-DR6 (read-write) $" BKP-DR6 @ hex. BKP-DR6 1b. ;
: BKP-DR7. ." BKP-DR7 (read-write) $" BKP-DR7 @ hex. BKP-DR7 1b. ;
: BKP-DR8. ." BKP-DR8 (read-write) $" BKP-DR8 @ hex. BKP-DR8 1b. ;
: BKP-DR9. ." BKP-DR9 (read-write) $" BKP-DR9 @ hex. BKP-DR9 1b. ;
: BKP-DR10. ." BKP-DR10 (read-write) $" BKP-DR10 @ hex. BKP-DR10 1b. ;
: BKP-DR11. ." BKP-DR11 (read-write) $" BKP-DR11 @ hex. BKP-DR11 1b. ;
: BKP-DR12. ." BKP-DR12 (read-write) $" BKP-DR12 @ hex. BKP-DR12 1b. ;
: BKP-DR13. ." BKP-DR13 (read-write) $" BKP-DR13 @ hex. BKP-DR13 1b. ;
: BKP-DR14. ." BKP-DR14 (read-write) $" BKP-DR14 @ hex. BKP-DR14 1b. ;
: BKP-DR15. ." BKP-DR15 (read-write) $" BKP-DR15 @ hex. BKP-DR15 1b. ;
: BKP-DR16. ." BKP-DR16 (read-write) $" BKP-DR16 @ hex. BKP-DR16 1b. ;
: BKP-DR17. ." BKP-DR17 (read-write) $" BKP-DR17 @ hex. BKP-DR17 1b. ;
: BKP-DR18. ." BKP-DR18 (read-write) $" BKP-DR18 @ hex. BKP-DR18 1b. ;
: BKP-DR19. ." BKP-DR19 (read-write) $" BKP-DR19 @ hex. BKP-DR19 1b. ;
: BKP-DR20. ." BKP-DR20 (read-write) $" BKP-DR20 @ hex. BKP-DR20 1b. ;
: BKP-DR21. ." BKP-DR21 (read-write) $" BKP-DR21 @ hex. BKP-DR21 1b. ;
: BKP-DR22. ." BKP-DR22 (read-write) $" BKP-DR22 @ hex. BKP-DR22 1b. ;
: BKP-DR23. ." BKP-DR23 (read-write) $" BKP-DR23 @ hex. BKP-DR23 1b. ;
: BKP-DR24. ." BKP-DR24 (read-write) $" BKP-DR24 @ hex. BKP-DR24 1b. ;
: BKP-DR25. ." BKP-DR25 (read-write) $" BKP-DR25 @ hex. BKP-DR25 1b. ;
: BKP-DR26. ." BKP-DR26 (read-write) $" BKP-DR26 @ hex. BKP-DR26 1b. ;
: BKP-DR27. ." BKP-DR27 (read-write) $" BKP-DR27 @ hex. BKP-DR27 1b. ;
: BKP-DR28. ." BKP-DR28 (read-write) $" BKP-DR28 @ hex. BKP-DR28 1b. ;
: BKP-DR29. ." BKP-DR29 (read-write) $" BKP-DR29 @ hex. BKP-DR29 1b. ;
: BKP-DR30. ." BKP-DR30 (read-write) $" BKP-DR30 @ hex. BKP-DR30 1b. ;
: BKP-DR31. ." BKP-DR31 (read-write) $" BKP-DR31 @ hex. BKP-DR31 1b. ;
: BKP-DR32. ." BKP-DR32 (read-write) $" BKP-DR32 @ hex. BKP-DR32 1b. ;
: BKP-DR33. ." BKP-DR33 (read-write) $" BKP-DR33 @ hex. BKP-DR33 1b. ;
: BKP-DR34. ." BKP-DR34 (read-write) $" BKP-DR34 @ hex. BKP-DR34 1b. ;
: BKP-DR35. ." BKP-DR35 (read-write) $" BKP-DR35 @ hex. BKP-DR35 1b. ;
: BKP-DR36. ." BKP-DR36 (read-write) $" BKP-DR36 @ hex. BKP-DR36 1b. ;
: BKP-DR37. ." BKP-DR37 (read-write) $" BKP-DR37 @ hex. BKP-DR37 1b. ;
: BKP-DR38. ." BKP-DR38 (read-write) $" BKP-DR38 @ hex. BKP-DR38 1b. ;
: BKP-DR39. ." BKP-DR39 (read-write) $" BKP-DR39 @ hex. BKP-DR39 1b. ;
: BKP-DR40. ." BKP-DR40 (read-write) $" BKP-DR40 @ hex. BKP-DR40 1b. ;
: BKP-DR41. ." BKP-DR41 (read-write) $" BKP-DR41 @ hex. BKP-DR41 1b. ;
: BKP-DR42. ." BKP-DR42 (read-write) $" BKP-DR42 @ hex. BKP-DR42 1b. ;
: BKP-RTCCR. ." BKP-RTCCR (read-write) $" BKP-RTCCR @ hex. BKP-RTCCR 1b. ;
: BKP-CR. ." BKP-CR (read-write) $" BKP-CR @ hex. BKP-CR 1b. ;
: BKP-CSR. ." BKP-CSR () $" BKP-CSR @ hex. BKP-CSR 1b. ;
: BKP.
BKP-DR1.
BKP-DR2.
BKP-DR3.
BKP-DR4.
BKP-DR5.
BKP-DR6.
BKP-DR7.
BKP-DR8.
BKP-DR9.
BKP-DR10.
BKP-DR11.
BKP-DR12.
BKP-DR13.
BKP-DR14.
BKP-DR15.
BKP-DR16.
BKP-DR17.
BKP-DR18.
BKP-DR19.
BKP-DR20.
BKP-DR21.
BKP-DR22.
BKP-DR23.
BKP-DR24.
BKP-DR25.
BKP-DR26.
BKP-DR27.
BKP-DR28.
BKP-DR29.
BKP-DR30.
BKP-DR31.
BKP-DR32.
BKP-DR33.
BKP-DR34.
BKP-DR35.
BKP-DR36.
BKP-DR37.
BKP-DR38.
BKP-DR39.
BKP-DR40.
BKP-DR41.
BKP-DR42.
BKP-RTCCR.
BKP-CR.
BKP-CSR.
;

