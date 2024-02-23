<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" version="1.0" encoding="UTF-8"/>
    <xsl:param name="studentId" select="'1'"/>

    <xsl:template match="/">
        <attendance>
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
                            <th>Date</th>
                            <th>Status</th>
                        </tr>
                        <xsl:for-each select="//record[std_id=$studentId]">
                            <tr>
                                <td><xsl:value-of select="date"/></td>
                                <td><xsl:value-of select="attendance_status"/></td>
                            </tr>
                        </xsl:for-each>
                    </table>
                </body>
            </html>
        </attendance>
    </xsl:template>
</xsl:stylesheet>
