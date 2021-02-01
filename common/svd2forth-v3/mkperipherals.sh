#! /bin/sh

PROCESSOR=xsltproc
TEMPLATE=template.xml
TEMPALTE_CUT=template_cutter.xml
OUT=peripherals
SVDCUTTER1_STY=svdcutter1.xsl  	# temp.xml is hardcoded here
SVDCUTTER2_STY=svdcutter2.xsl  	# temp.xml is hardcoded here
FOLDED_SVD=STM32F103xx.svd
CLEANED_SVD=${FOLDED_SVD}-cleaned.svd
UNFOLDED_SVD=${CLEANED_SVD}.uf.svd

echo "\ load register variables" > ${OUT}/loader.fs
mkdir -p ${OUT}
for p in $(${PROCESSOR} ${TEMPALTE_CUT} ${TEMPLATE} | tail -n +3 | head -n -1); do
  cat > tmp.xml <<EOTMP
<?xml version="1.0" encoding="UTF-8"?>
<peripherals>
  <name xmlns:xs="http://www.w3.org/2001/XMLSchema-instance">${p}</name>
</peripherals>
EOTMP
  ${PROCESSOR} -o ${OUT}/${p}.fs ${SVDCUTTER1_STY} ${UNFOLDED_SVD}
  ${PROCESSOR} -o ${OUT}/${p}-display.fs ${SVDCUTTER2_STY} ${UNFOLDED_SVD}
  echo "include ${OUT}/${p}.fs" >> ${OUT}/loader.fs
done
rm tmp.xml
