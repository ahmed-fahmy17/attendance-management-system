using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace attendance_management_system.controls
{
    public partial class StudentReport : UserControl
    {
        public StudentReport()
        {
            InitializeComponent();
            loadStudents();
            studentsComboBox.SelectedIndex = 0;
        }
        string std_id;
        string std_class;
        public void loadStudents()
        {
            HashSet<string> strings = new HashSet<string>();
            XmlDocument xmlDocument2 = new XmlDocument();
            xmlDocument2.Load("C:\\Users\\USER\\Desktop\\c#project4\\attendance-management-system\\xml\\attendance.xml");
            foreach (XmlNode node in xmlDocument2.SelectNodes("//record"))
            {
                std_class = node.SelectSingleNode("classId").InnerText;
                if (std_class == "Maths" || std_class == "physics")
                {
                    std_id = node.SelectSingleNode("std_id").InnerText;
                    strings.Add(std_id);

                }

            }
            foreach (string s in strings)
            {
                studentsComboBox.Items.Add(s);
            }

        }

        private void studentReportPic_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedClass = studentsComboBox.SelectedItem.ToString();
                string xmlFilePath = @"C:\Users\USER\Desktop\c#Project4\attendance-management-system\xml\attendance.xml";
                string xsltFilePath = @"C:\Users\USER\Desktop\c#Project4\attendance-management-system\xml\filteringDependingOnStudent.xslt";
                string outputFilePath = @"C:\Reports\TransformedAttendanceStudent.html";

                // Load XML document and XSLT stylesheet
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlFilePath);

                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(xsltFilePath);

                // Set XSLT parameters
                XsltArgumentList xsltArgs = new XsltArgumentList();
                xsltArgs.AddParam("studentId", "", selectedClass);

                // Perform XSLT transformation and save the output to HTML file
                using (XmlWriter writer = XmlWriter.Create(outputFilePath))
                {
                    transform.Transform(xmlDocument, xsltArgs, writer);
                }

                MessageBox.Show("XSLT transformation completed. Transformed XML saved to file.", "Transformation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

