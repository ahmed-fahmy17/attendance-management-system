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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace attendance_management_system.controls
{
    public partial class UserControlAttendance : UserControl
    {
        System.Data.DataTable dataTable;
        public UserControlAttendance()
        {
            InitializeComponent();
        }
        DataGridViewCheckBoxColumn checkBoxColumn;
        DateTimePicker dateTimePicker1;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            loadTeacherClasses();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Location = new System.Drawing.Point(100, 100);
            this.Controls.Add(dateTimePicker1);
            dateTimePicker1.Format = DateTimePickerFormat.Short; // Set the display format
            dateTimePicker1.MinDate = new DateTime(2023, 1, 1); // Set the minimum date
            dateTimePicker1.MaxDate = new DateTime(2025, 12, 31); // Set the maximum date
            dateTimePicker1.Value = DateTime.Today;
            teacherClasses.SelectedIndex = 0;
          
            
          
        }
        public void print()
        {
            Console.WriteLine("hello");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Load XML file
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\users.xml");
            dataTable = new System.Data.DataTable();
            //add headers of 2 cols
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("name");
           
            // Create checkbox column if it's not already added
         if (dataGridView1.Columns["checkBoxColumn"] == null)
           {
                checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Attendance Status";
                checkBoxColumn.Name = "checkBoxColumn";
                
                
                dataGridView1.Columns.Insert(0, checkBoxColumn);
                
           }
           
            // Clear existing data in the DataTable
           // dataTable.Rows.Clear();

            // Get the selected item from comboBox2
            string selectedClass = teacherClasses.SelectedItem.ToString();
            string userId = "";
            string name = "";

            //traverse through my xml file
            foreach (XmlNode userNode in xmlDocument.SelectNodes("/users/user"))
            {
                string role = userNode.SelectSingleNode("role").InnerText;
                //make sure the retreived data is of student
                if (role == "student")
                {
                    XmlNodeList classIdNodes = userNode.SelectNodes("classes/classID");
                    foreach (XmlNode classIdNode in classIdNodes)
                    {
                        //insure that the displayed users have the same class 
                        if (selectedClass == classIdNode.InnerText)
                        {
                            userId = userNode.SelectSingleNode("id").InnerText;
                            name = userNode.SelectSingleNode("name").InnerText;
                            dataTable.Rows.Add(new string[] { userId, name });
                            break;
                        }
                    }

                }
            }
            dataGridView1.DataSource = dataTable;





        }
        // maths,physics =>assuming theses are the classes of  current teacher.
        private void loadTeacherClasses()
        {
            //first load xml file.
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\users.xml");
            bool exists = false;
            XmlElement root = xmlDocument.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                XmlNode nameNode = node.SelectSingleNode("classes/classID");
                if (nameNode != null)
                {
                    string itemName = nameNode.InnerText;
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
                        if ((itemName == "Maths" || itemName == "physics"))
                        {
                            // Add the item to the ComboBox
                            teacherClasses.Items.Add(itemName);
                        }
                    }
                }
            }

        }

        public void trackCheckBoc()
        {
            XmlDocument xmlDocument2 = new XmlDocument();
            xmlDocument2.Load("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\attendance.xml");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    // Create new record element
                    XmlNode recordNode = xmlDocument2.CreateElement("record");

                    // Create child elements for record
                    XmlNode stdIdNode = xmlDocument2.CreateElement("std_id");
                    stdIdNode.InnerText = row.Cells["Student ID"].Value.ToString();

                    XmlNode dateNode = xmlDocument2.CreateElement("date");
                    dateNode.InnerText = dateTimePicker1.Value.ToString("yyyy-MM-dd");


                    XmlNode attendanceStatusNode = xmlDocument2.CreateElement("attendance_status");
                    attendanceStatusNode.InnerText = "present";

                    // Append child nodes to record element
                    recordNode.AppendChild(stdIdNode);
                    recordNode.AppendChild(dateNode);
                    recordNode.AppendChild(attendanceStatusNode);

                    // Append record element to the root of xmlDocument2
                    xmlDocument2.DocumentElement.AppendChild(recordNode);
                    // Save changes to attendance.xml
                   // xmlDocument2.Save("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\attendance.xml");
                }
            xmlDocument2.Save("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\attendance.xml");
            }

            
            MessageBox.Show("saved");
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            trackCheckBoc();
        }
    }

}
