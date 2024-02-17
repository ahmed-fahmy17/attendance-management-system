<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="text" version="1.0" encoding="UTF-8"/>
	<xsl:param name="SubjectId" select="''"/>
	<xsl:template match="/">
		<xsl:text>date    attendance_status&#10;</xsl:text>
		<!--initial try!-->
		<xsl:for-each select="//subject[id=SubjectId]">
			<xsl:value-of select="concat(name, '    ', teacherName, '      ',studentCount,'&#10;')"/>
		</xsl:for-each>
	</xsl:template>
</xsl:stylesheet>
