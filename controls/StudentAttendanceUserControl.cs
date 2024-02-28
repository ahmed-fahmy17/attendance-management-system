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

namespace attendance_management_system.controls
{
    public partial class StudentAttendanceUserControl : UserControl
    {
      
        System.Data.DataTable dataTable;
        public StudentAttendanceUserControl()
        {
            InitializeComponent();
            LoadStudentClasses();
            studentClassesComboBox.SelectedIndex = 0;
            BuildAttendanceTable();


        }

        private void studentClassesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildAttendanceTable();
        }
        private void LoadStudentClasses()
        {
            XmlDocument xmlDocument = new XmlDocument();
            var CurrentUserId = "1";
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
                    //to remove all duplicate classes 
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
            XmlDocument xmlDocument = new XmlDocument();
            //std_id,classId,attendance_status,date
            // Load XML file
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

            string selectedClass = studentClassesComboBox.SelectedItem.ToString();

            foreach (XmlNode classNode in xmlDocument.SelectNodes("/attendance/record"))
            {
                string classId = classNode.SelectSingleNode("classId").InnerText;
                if (selectedClass == classId)
                {
                    string stdid = classNode.SelectSingleNode("std_id").InnerText;
                    string status = classNode.SelectSingleNode("attendance_status").InnerText;
                    string date = classNode.SelectSingleNode("date").InnerText;
                        dataTable.Rows.Add(stdid, classId,status,date);
                   

                    break;
                }
            }
            dataGridView1.DataSource = dataTable;
        }
    }
}
