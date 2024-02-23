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
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout;

namespace attendance_management_system.controls
{
    public partial class FilterByClass : UserControl
    {
        UserControlReport controlReport;
        public FilterByClass()
        {
            InitializeComponent();
        }

        private void FilterByClass_Load(object sender, EventArgs e)
        {
            UserControlAttendance userControlAttendance = new UserControlAttendance();
            List<string> teacherClasses = userControlAttendance.retreiveTeacherClasses();
            foreach (string teacherClass in teacherClasses)
            {
                classComboBox.Items.Add(teacherClass);
            }
              classComboBox.SelectedIndex = 0;
            controlReport = new UserControlReport();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (classComboBox.SelectedItem == null)
            {
                MessageBox.Show("please choose a class firstly!");
            }
            else
            {
                saveClassAttendance();
            }
        }
        public void saveClassAttendance()
        {
            string selectedClass = classComboBox.SelectedItem.ToString();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"C:\Users\USER\Desktop\c#Proj4\attendance-management-system\xml\attendance.xml");
            XmlDocument xmlDocument2 = new XmlDocument();
            xmlDocument2.Load(@"C:\Users\USER\Desktop\c#Proj4\attendance-management-system\xml\users.xml");
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(@"C:\Users\USER\Desktop\c#Proj4\attendance-management-system\xml\FilteringDependingOnClass.xslt");
            XsltArgumentList xsltArgs = new XsltArgumentList();
            xsltArgs.AddParam("SubjectId", "", selectedClass);
            xsltArgs.AddParam("externalDoc", "", xmlDocument);

            using (XmlWriter writer = XmlWriter.Create(@"C:\Reports\TransformedAttendance.html"))
            {
                transform.Transform(xmlDocument2, xsltArgs, writer);
            }
         
            MessageBox.Show("XSLT transformation completed. Transformed XML saved to file.", "Transformation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}