<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" version="1.0" encoding="UTF-8"/>
	<xsl:param name="studentId" select="'15'"/>
	<xsl:template match="/">
		<xsl:text>date    attendance_status&#10;</xsl:text>
		<xsl:for-each select="//record[std_id=$studentId]">
					<xsl:value-of select="concat(date, '    ', attendance_status,'    ', '&#10;')"/>
		</xsl:for-each>
	</xsl:template>
</xsl:stylesheet>
