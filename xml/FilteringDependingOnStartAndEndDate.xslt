<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>
	
	<!-- the params which will be passed by the user from c# form-->
	<xsl:param name="startDate" select="''"/>
	<xsl:param name="endDate" select="''"/>
	
	<!--the root element -->
	<xsl:template match="/attendance">
	
		<!-- 1-remove ' - ' from date and then convert it to number to simplify comparison -->
		<xsl:apply-templates select="record[number(translate(date, '-', '')) &gt;= number(translate($startDate, '-', '')) and number(translate(date, '-', '')) &lt;= number(translate($endDate, '-', ''))]"/>
	</xsl:template>
	
	<!-- Template to match records within the date range -->
	<xsl:template match="record">
		<xsl:copy-of select="."/>
	</xsl:template>
</xsl:stylesheet>
