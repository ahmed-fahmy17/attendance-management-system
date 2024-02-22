using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using OfficeOpenXml;
using System.IO;

namespace attendance_management_system.controls
{

    public partial class UserControlReport : UserControl
    {
        private GenerateReport reportGenerator;
        public UserControlReport()
        {
            InitializeComponent();
            reportGenerator = new GenerateReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            object startDate1 = StartDateComboBox.SelectedItem;
            object endDate1 = EndDateComboBox.SelectedItem;
            object fileType=formatComboBox.SelectedItem;

            // Check if both start and end dates are selected
            if (startDate1 == null || endDate1 == null || fileType==null)
            {
                MessageBox.Show("Please choose the start, end dates and file type !", "Filtered Attendance Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string startDate = startDate1.ToString();
            string endDate = endDate1.ToString();

            // Load XML attendance file
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\c#Proj4\\attendance-management-system\\xml\\attendance.xml");

            // Create XSLT transformation object
            XslCompiledTransform transform = new XslCompiledTransform();

            // Load XSLT stylesheet from file
            transform.Load("C:\\Users\\USER\\Desktop\\c#Proj4\\attendance-management-system\\xml\\FilteringDependingOnStartAndEndDate.xslt");

            XsltArgumentList xsltArgs = new XsltArgumentList();
            xsltArgs.AddParam("startDate", "", startDate);
            xsltArgs.AddParam("endDate", "", endDate);

            // Perform the XSLT transformation and save the result
            using (StringWriter sw = new StringWriter())
            {
                transform.Transform(xmlDocument, xsltArgs, sw);
                string resultXml = sw.ToString();

              
                DataTable attendanceData = ConvertXmlToDataTable(resultXml);

              
                string exportFilePath = @"C:\Reports\AttendanceReport.xlsx";
                string filepath = @"C:\Reports\myRepo.pdf";

                if (attendanceData != null && !string.IsNullOrEmpty(exportFilePath))
                {
                   
                    GenerateReport report = new GenerateReport();

                    
                    if (formatComboBox.SelectedIndex == 0)
                    {
                        report.GenerateExcelReport(attendanceData, exportFilePath);
                    }
                    else if(formatComboBox.SelectedIndex == 1) 
                    {  
                        report.GeneratePdfReport(attendanceData, filepath);
                    }
                }
                else
                {
                   
                    MessageBox.Show("Attendance data or export file path is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


              
                MessageBox.Show("Attendance data filtered based on selected dates has been exported .", "Filtered Attendance Data", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        // Method to convert XML string to DataTable
        public DataTable ConvertXmlToDataTable(string xml)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(new StringReader(xml));
            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : null;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlReport_Load(object sender, EventArgs e)
        {
            loadData();
            string xmlFilePath = "C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\attendance.xml";

            if (File.Exists(xmlFilePath))
            {
                // Load XML document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                // Get the root element
                XmlElement root = xmlDoc.DocumentElement;

                // HashSet to store unique date values(اكتشاااااااااف)
                HashSet<string> uniqueDates = new HashSet<string>();

                // Iterate through each child node
                foreach (XmlNode node in root.ChildNodes)
                {
                    // Extract data from XML
                    XmlNode nameNode = node.SelectSingleNode("date");
                    if (nameNode != null)
                    {
                        string itemName = nameNode.InnerText.Trim(); // Trim whitespace
                        uniqueDates.Add(itemName); // Add to HashSet
                    }
                }

                // Add unique dates to ComboBoxes
                foreach (string date in uniqueDates)
                {
                    StartDateComboBox.Items.Add(date);
                    EndDateComboBox.Items.Add(date);
                }
            }
            else
            {
                MessageBox.Show("XML file not found.");
            }
        }

        private void StartDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string userId = "";
        string name = "";
        System.Data.DataTable dataTable;
        string stdId;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {



        }
        public void loadData()
        {
            //first load xml file.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\attendance.xml");
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Attendance Status");

            // Read XML data and populate DataTable
            foreach (XmlNode node in xmlDoc.SelectNodes("//record"))
            {
                stdId = node.SelectSingleNode("std_id").InnerText;
                string date = node.SelectSingleNode("date").InnerText;
                string status = node.SelectSingleNode("attendance_status").InnerText;
                dataTable.Rows.Add(new string[] { stdId, date, status });
            }
            // Bind DataTable to DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            string searchData = searchtxt.Text.Trim();

            if (!string.IsNullOrEmpty(searchData))
            {
                // Filter the DataTable to find the matching row
                DataRow[] foundRows = dataTable.Select($"[Student ID] = '{searchData}'");

                if (foundRows.Length > 0)
                {

                    DataTable foundDataTable = dataTable.Clone();


                    foreach (DataRow row in foundRows)
                    {
                        foundDataTable.ImportRow(row);
                    }


                    dataGridView1.DataSource = foundDataTable;
                }

            }
            else
            {

                dataGridView1.DataSource = dataTable;
            }
        }
    }

    public enum ReportFormat
    {
        PDF,
        Excel
    }
    public class GenerateReport
    {
        //a function to generate report depending on format
        public void GenerateAttendanceReport(DataTable dataTable, string ReportPath, ReportFormat reportFormat)
        {
            switch (reportFormat)
            {
                case ReportFormat.PDF:
                    GeneratePdfReport(dataTable, ReportPath);
                    break;
                case ReportFormat.Excel:
                    GenerateExcelReport(dataTable, ReportPath);
                    break;
                default:
                    throw new ArgumentException("Unsupported report format");
            }
        }
        //function for pdf
        public void GeneratePdfReport(DataTable attendanceData, string exportFilePath)
        {
          
            PdfWriter writer = new PdfWriter(exportFilePath);
            PdfDocument pdf = new PdfDocument(writer);
            iText.Layout.Document document = new iText.Layout.Document(pdf);

            // Add table to the document
            Table table = new Table(attendanceData.Columns.Count);
            foreach (DataColumn column in attendanceData.Columns)
            {
                Cell cell = new Cell().Add(new Paragraph(column.ColumnName));
                table.AddCell(cell);
            }
            foreach (DataRow row in attendanceData.Rows)
            {
                foreach (object item in row.ItemArray)
                {
                    Cell cell = new Cell().Add(new Paragraph(item.ToString()));
                    table.AddCell(cell);
                }
            }
            document.Add(table);

            document.Close();

        }

        //for excell format
        public void GenerateExcelReport(DataTable attendanceData, string exportFilePath)

        {
           
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // or LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Add a new worksheet to the Excel package
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Attendance Report");

                // Ensure worksheet is not null
                if (worksheet != null)
                {
                    // Populate the header row with column names
                    for (int col = 1; col <= attendanceData.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col].Value = attendanceData.Columns[col - 1].ColumnName;
                    }

                    // Populate the data rows
                    for (int row = 0; row < attendanceData.Rows.Count; row++)
                    {
                        for (int col = 0; col < attendanceData.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = attendanceData.Rows[row][col];
                        }
                    }

                    // Save the Excel package to a file
                    FileInfo excelFile = new FileInfo(exportFilePath);
                    package.SaveAs(excelFile);
                }
                else
                {
                    // Handle the case where worksheet is null
                    throw new Exception("Worksheet is null. Unable to generate Excel report.");
                }
            }
        }
    }
}

