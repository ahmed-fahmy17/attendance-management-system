<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" version="1.0" encoding="UTF-8"/>
    <xsl:param name="ClassId" select="'Math'"/>
    <xsl:param name="externalDoc" select="document('attendance.xml')"/>
    
    <xsl:template match="/">
        <root>
            <html>
                <head>
                    <style type="text/css">
                        body {
                            font-family: Arial, sans-serif;
                        }
                        table {
                            border-collapse: collapse;
                            width: 100%;
                        }
                        th, td {
                            border: 1px solid #dddddd;
                            text-align: left;
                            padding: 8px;
                        }
                        th {
                            background-color: #f2f2f2;
                        }
                    </style>
                </head>
                <body>
                    <table>
                        <tr>
                           <th>Id</th>
                            <th>Date</th>
                            <th>Attendance</th>
                        </tr>
                        <xsl:for-each select="//class[classId=$ClassId]/students/studentId">
                            <xsl:variable name="studentId" select="."/>
                            <tr>
                                <td>
                                    <xsl:value-of select="$externalDoc//record[std_id=$studentId]/std_id"/>
                                </td>
                                <xsl:apply-templates select="$externalDoc//record[std_id = $studentId]"/>
                            </tr>
                        </xsl:for-each>
                    </table>
                </body>
            </html>
        </root>
    </xsl:template>
    
    <xsl:template match="record">
        <td>
            <xsl:value-of select="date"/>
        </td>
        <td>
            <xsl:value-of select="attendance_status"/>
        </td>
    </xsl:template>
</xsl:stylesheet>
