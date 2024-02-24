using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace attendance_management_system.controls
{
    public partial class UserControlAttendance : UserControl
    {
        System.Data.DataTable dataTable;
        XmlDocument xmlDocument = new XmlDocument();
        public UserControlAttendance()
        {
            InitializeComponent();
        }
        DataGridViewCheckBoxColumn checkBoxColumn;
        DateTimePicker dateTimePicker1;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            loadTeacherClasses();//to be removed to xml manipulation
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Location = new System.Drawing.Point(100, 100);
            this.Controls.Add(dateTimePicker1);
            dateTimePicker1.Format = DateTimePickerFormat.Short; // Set the display format
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1); // Set the minimum date
            dateTimePicker1.MaxDate = new DateTime(2024, 3, 1); // Set the maximum date
            dateTimePicker1.Value = DateTime.Today;

            teacherClasses.SelectedIndex = 0;
            BuildAttendanceTable();

        }
        public void print()
        {
            Console.WriteLine("hello");
        }
        public void CheckBoxUpdate1()
        {
            XmlDocument xmlDocument2 = new XmlDocument();
            xmlDocument2.Load("C:\\Users\\USER\\Desktop\\c#project4\\attendance-management-system\\xml\\attendance.xml");

            string currentDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            // Check if a record with the current date already exists
            XmlNode existingRecordNode = xmlDocument2.SelectSingleNode($"//record[date='{currentDate}']");

            if (existingRecordNode != null)
            {
                // If a record with the current date exists, update its attendance status
                foreach (DataGridViewRow row in attendanceTable.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Attendance Status"] as DataGridViewCheckBoxCell;

                    string stdId = row.Cells["Student ID"].Value.ToString();

                    XmlNode stdIdNode = existingRecordNode.SelectSingleNode($"std_id[text()='{stdId}']");

                    if (stdIdNode != null)
                    {
                        // Update the attendance status
                        XmlNode attendanceStatusNode = stdIdNode.ParentNode.SelectSingleNode("attendance_status");
                        if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                        {
                            attendanceStatusNode.InnerText = "present";
                        }
                        else
                        {
                            attendanceStatusNode.InnerText = "absent";
                        }
                    }
                    else
                    {
                        // If the student ID doesn't exist in the existing record, add it
                        XmlNode newStdIdNode = xmlDocument2.CreateElement("std_id");
                        XmlNode newStdIdClass = xmlDocument2.CreateElement("classId");
                        newStdIdNode.InnerText = stdId;

                        XmlNode attendanceStatusNode = xmlDocument2.CreateElement("attendance_status");

                        if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                        {
                            attendanceStatusNode.InnerText = "present";
                        }
                        else
                        {
                            attendanceStatusNode.InnerText = "absent";
                        }

                        XmlNode recordNode = existingRecordNode.ParentNode;

                        recordNode.AppendChild(newStdIdNode);
                        recordNode.AppendChild(attendanceStatusNode);
                        recordNode.AppendChild(newStdIdClass);
                    }
                }
            }
            else
            {
                // If no record with the current date exists, add new records
                foreach (DataGridViewRow row in attendanceTable.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Attendance Status"] as DataGridViewCheckBoxCell;
                    XmlNode newStdIdClass = xmlDocument2.CreateElement("classId");
                    XmlNode recordNode = xmlDocument2.CreateElement("record");
                    XmlNode stdIdNode = xmlDocument2.CreateElement("std_id");
                    stdIdNode.InnerText = row.Cells["Student ID"].Value.ToString();
                    newStdIdClass.InnerText = row.Cells["class"].Value.ToString();
                    XmlNode dateNode = xmlDocument2.CreateElement("date");
                    dateNode.InnerText = currentDate;

                    XmlNode attendanceStatusNode = xmlDocument2.CreateElement("attendance_status");
                    if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                    {
                        attendanceStatusNode.InnerText = "present";
                    }
                    else
                    {
                        attendanceStatusNode.InnerText = "absent";
                    }

                    recordNode.AppendChild(stdIdNode);
                    recordNode.AppendChild(dateNode);
                    recordNode.AppendChild(attendanceStatusNode);
                    recordNode.AppendChild(newStdIdClass);

                    // Append record element to the root of xmlDocument2
                    xmlDocument2.DocumentElement.AppendChild(recordNode);
                }
            }

            // Save the updated XML file
            xmlDocument2.Save("C:\\Users\\USER\\Desktop\\c#project4\\attendance-management-system\\xml\\attendance.xml");

            MessageBox.Show("Attendance saved Successfully");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildAttendanceTable();
        }
        // maths,physics =>assuming theses are the classes of  current teacher.
        private void loadTeacherClasses()
        {
            var CurrentUserId = "11111111111111";
            //first load xml file.
            //I should search for teacher classes
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\c#project4\\attendance-management-system\\xml\\classes.xml");
            bool exists = false;
            XmlElement root = xmlDocument.DocumentElement;//classes
            foreach (XmlNode node in root.ChildNodes)//class
            {
                XmlNode? nameNode = node.SelectSingleNode("classId");
                XmlNode? teacherId = node.SelectSingleNode("teacherId");
                if (teacherId != null)
                {
                    string itemName = nameNode.InnerText;//
                    //to remove all duplicate classes 
                    foreach (var item in teacherClasses.Items)
                    {
                        if (item.ToString() == itemName)
                        {
                            exists = true;
                            break;

                        }
                    }
                    if (exists == false)
                    {
                        if (teacherId.InnerText == CurrentUserId)
                        {
                            // Add the item to the ComboBox
                            teacherClasses.Items.Add(itemName);


                        }
                    }
                }
            }

        }
        public void BuildAttendanceTable()
        {
            // Load XML file
            xmlDocument.Load(@"C:\Users\USER\Desktop\c#project4\attendance-management-system\xml\classes.xml");
            dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("Student ID", typeof(string));
            dataTable.Columns.Add("Class", typeof(string));
            dataTable.Columns.Add("Attendance Status", typeof(bool));
            attendanceTable.DefaultCellStyle.Font = new Font("Arial", 12);
            attendanceTable.RowTemplate.Height = 45;
            attendanceTable.Height = 700;
            attendanceTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            string selectedClass = teacherClasses.SelectedItem.ToString();

            foreach (XmlNode classNode in xmlDocument.SelectNodes("/classes/class"))
            {
                string classId = classNode.SelectSingleNode("classId").InnerText;
                if (selectedClass == classId)
                {
                    string stdClass = classNode.SelectSingleNode("className").InnerText;

                    foreach (XmlNode std in classNode.SelectNodes("students/studentId"))
                    {
                        string userId = std.InnerText;
                        dataTable.Rows.Add(userId, stdClass, false);
                    }

                    break;
                }
            }
            attendanceTable.DataSource = dataTable;
        }

        public List<Tuple<string, string, string>> RetrieveStudentsWithTeacher()
        {
            XmlDocument xmlDocument = new XmlDocument();
            List<Tuple<string, string, string>> studentRecords = new List<Tuple<string, string, string>>();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\attendance.xml");

            foreach (XmlNode userNode in xmlDocument.SelectNodes("/users/user"))
            {
                string role = userNode.SelectSingleNode("role").InnerText;

                // Check if the retrieved data is of a student
                if (role == "student")
                {
                    // Get the student's ID and name
                    string studentId = userNode.SelectSingleNode("id").InnerText;
                    string studentName = userNode.SelectSingleNode("name").InnerText;
                    string age = userNode.SelectSingleNode("age").InnerText;

                    // Add the student's ID, name, and associated teacher's name to the list
                    studentRecords.Add(new Tuple<string, string, string>(studentId, studentName, age));
                }
            }

            return studentRecords;
        }
        public List<string> retreiveTeacherClasses()
        {
          List<string> strings = new List<string>();
            var CurrentUserId = "11111111111111";
            //first load xml file.
            //I should search for teacher classes
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\c#project4\\attendance-management-system\\xml\\classes.xml");
            bool exists = false;
            XmlElement root = xmlDocument.DocumentElement;//classes
            foreach (XmlNode node in root.ChildNodes)//class
            {
                XmlNode? nameNode = node.SelectSingleNode("classId");
                XmlNode? teacherId = node.SelectSingleNode("teacherId");
                if (teacherId != null)
                {
                    string itemName = nameNode.InnerText;//
                    //to remove all duplicate classes 
                    foreach (var item in teacherClasses.Items)
                    {
                        if (item.ToString() == itemName)
                        {
                            exists = true;
                            break;

                        }
                    }
                    if (exists == false)
                    {
                        if (teacherId.InnerText == CurrentUserId)
                        {
                            strings.Add(itemName);

                        }
                    }
                }
            }
            return strings;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            CheckBoxUpdate1();
        }
    }


}
