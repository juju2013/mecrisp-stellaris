<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<!-- Peripheral Lister by Terry Porter "terry@tjporter.com.au" -->
<!-- <xsl:param name="parameters" select=" 'file:///parameters.txt' " /> -->

<!-- <xsl:param name="file" select="document('referenced.xml')"/> -->
<xsl:variable name="fileA" select="document('tmp.xml')"/>
<xsl:output method="text"/>
<!-- <xsl:output method="text" omit-xml-declaration="yes" indent="no"/> -->
<!-- <xsl:output method="xml" encoding="UTF-8" indent="yes"/> -->

<xsl:template match="/device">
<xsl:text>\ TEMPLATE FILE for </xsl:text>
<xsl:value-of select="name"/>
<xsl:text>
</xsl:text>
<xsl:text>\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch</xsl:text>
<xsl:text>
</xsl:text>
<xsl:text>\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input </xsl:text>
<xsl:text>
</xsl:text>
<xsl:text>\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence</xsl:text>
<xsl:text>
</xsl:text>
<xsl:text>\   Modified by juju2013@github - 2020</xsl:text>
<xsl:text>

</xsl:text>


<xsl:for-each select="peripherals/peripheral">
<!-- <xsl:value-of select="name"></xsl:value-of> -->
<xsl:choose>
<xsl:when test=" name = $fileA/peripherals/name">

<xsl:variable name="device" select="name" />
<xsl:value-of select="baseAddress" /> constant <xsl:value-of select="$device" /> 
<xsl:text> ( </xsl:text>
<xsl:value-of select="description"/>
<xsl:text> ) </xsl:text>
<xsl:text>
</xsl:text>

<!-- Register Constants Start -->
<xsl:for-each select="registers/register" >
<xsl:value-of select="$device"/>
<xsl:text> </xsl:text>
<xsl:value-of select="addressOffset" />
<xsl:text> </xsl:text>
<xsl:text>+</xsl:text>
<xsl:text> </xsl:text>
<xsl:text>constant</xsl:text>
<xsl:text> </xsl:text>
<xsl:value-of select="$device"/><xsl:text>-</xsl:text><xsl:value-of select="name" />
<xsl:text> ( </xsl:text>
<xsl:value-of select="description"/>
<xsl:text> ) </xsl:text>
<xsl:text>
</xsl:text>
</xsl:for-each>
<!-- Register Constants Finish -->

</xsl:when>
</xsl:choose>
</xsl:for-each>

</xsl:template>
</xsl:stylesheet>
