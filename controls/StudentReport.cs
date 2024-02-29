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
            if(studentsComboBox.Items.Count>0)
                studentsComboBox.SelectedIndex = 0;
        }
        string std_id;
        string std_class;
        public void loadStudents()
        {
            HashSet<string> studentIds = new HashSet<string>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("D:\\iti\\projects\\c# and XML project\\attendance-management-system\\xml\\attendance.xml");

            foreach (XmlNode node in xmlDocument.SelectNodes("//record"))
            {
                string std_id = node.SelectSingleNode("std_id")?.InnerText;
                string cl= node.SelectSingleNode("classId")?.InnerText;
                UserControlAttendance userControlAttendance = new UserControlAttendance();
                List<string> teacherClasses = userControlAttendance.retreiveTeacherClasses();
                foreach (string teacherClass in teacherClasses)
                {
                    studentIds.Add(std_id);
                }
            }
            foreach (string studentId in studentIds)
            {
                studentsComboBox.Items.Add(studentId);
            }
        }
        private void studentReportPic_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedClass = studentsComboBox.SelectedItem.ToString();
                string xmlFilePath = @"D:\iti\projects\c# and XML project\attendance-management-system\xml\attendance.xml";
                string xsltFilePath = @"D:\iti\projects\c# and XML project\attendance-management-system\xml\filteringDependingOnStudent.xslt";
                string outputFilePath = @"D:\iti\projects\c# and XML project\attendance-management-system\reports\TransformedAttendanceStudent.html";

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

