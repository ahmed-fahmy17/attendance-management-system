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
using System.Xml.Linq;
using System.Xml.Xsl;

namespace attendance_management_system.controls
{
    public partial class StudentAttendanceUserControl : UserControl
    {

        System.Data.DataTable dataTable;
        public StudentAttendanceUserControl()
        {
            InitializeComponent();
            LoadStudentClasses();
            BuildAttendanceTable();
            studentClassesComboBox.SelectedIndex = 0;


        }

        private void studentClassesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildAttendanceTable();
        }
        private void LoadStudentClasses()
        {
            XmlDocument xmlDocument = new XmlDocument();
            string userId = login.myDictionary["userId"];
            var CurrentUserId = userId;
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\final\\attendance-management-system\\xml\\attendance.xml");
            bool exists = false;
            XmlElement root = xmlDocument.DocumentElement;//classes
            foreach (XmlNode node in root.ChildNodes)//class
            {
                XmlNode? nameNode = node.SelectSingleNode("classId");
                XmlNode? studentId = node.SelectSingleNode("std_id");
                if (studentId != null)
                {
                    string itemName = nameNode.InnerText;
                    foreach (var item in studentClassesComboBox.Items)
                    {
                        if (item.ToString() == itemName)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (exists == false)
                    {
                        if (studentId.InnerText == CurrentUserId)
                        {
                            // Add the item to the ComboBox
                            studentClassesComboBox.Items.Add(itemName);


                        }
                    }
                }
            }

        }
        public void BuildAttendanceTable()
        {
            // Load XML file
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"C:\Users\USER\Desktop\final\attendance-management-system\xml\attendance.xml");

            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Student ID", typeof(string));
            dataTable.Columns.Add("Class", typeof(string));
            dataTable.Columns.Add("Attendance");
            dataTable.Columns.Add("Date");

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 13);
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Height = 700;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Check if an item is selected in the studentClassesComboBox
            if (studentClassesComboBox.SelectedItem != null)
            {
                string selectedClass = studentClassesComboBox.SelectedItem.ToString();

                foreach (XmlNode classNode in xmlDocument.SelectNodes("/attendance/record"))
                {
                    string classId = classNode.SelectSingleNode("classId").InnerText;
                    if (selectedClass == classId)
                    {
                        string stdid = classNode.SelectSingleNode("std_id").InnerText;
                        string status = classNode.SelectSingleNode("attendance_status").InnerText;
                        string date = classNode.SelectSingleNode("date").InnerText;
                        dataTable.Rows.Add(stdid, classId, status, date);
                    }
                }

                dataGridView1.DataSource = dataTable;
            }
            else
            {
                // Handle the case where no item is selected in the ComboBox
                MessageBox.Show("Please select a class.", "No Class Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string userId = login.myDictionary["userId"];
            try
            {

                string xmlFilePath = @"C:\Users\USER\Desktop\final\attendance-management-system\xml\attendance.xml";
                string xsltFilePath = @"C:\Users\USER\Desktop\final\attendance-management-system\xml\filteringDependingOnStudent.xslt";
                string outputFilePath = @"C:\Reports\TransformedAttendanceStudent.html";
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlFilePath);
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(xsltFilePath);
                XsltArgumentList xsltArgs = new XsltArgumentList();
                xsltArgs.AddParam("studentId", "", userId);
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
