
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace attendance_management_system
{
    public partial class login : Form
    {
        public static Dictionary<string, string> myDictionary = new Dictionary<string, string>();
       public static bool isLoggedIn = false;
        public login()
        {
            InitializeComponent();
          
        }
        public class CurrentUser
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
        }
       
        public void button1_Click_1(object sender, EventArgs e)
        {
           
           
           
            var email = EmailTextBox.Text;
            var password = PasswordTextBox.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\USER\\Desktop\\final\\attendance-management-system\\xml\\users.xml");
            XmlElement root = doc.DocumentElement;//users
          
            foreach (XmlNode node in root.ChildNodes)
            {
                var xmlEmail = node.SelectSingleNode("email");
                var xmlPassword = node.SelectSingleNode("password");
                var xmlRole = node.SelectSingleNode("role")?.InnerText;
                var xmlName=node.SelectSingleNode("name")?.InnerText;
                var xmlId=node.SelectSingleNode("id")?.InnerText;   

                if (xmlEmail != null && xmlPassword != null && xmlRole != null)
                {
                    if (xmlEmail.InnerText == email.ToString() && xmlPassword.InnerText == password.ToString())
                    {
                        MessageBox.Show("Welcome, user!");
                        switch (xmlRole)
                        {
                            case "admin":
                                FormAdmin admin;
                                admin = new FormAdmin();
                                isLoggedIn = true;
                                MessageBox.Show("Welcome, admin!");
                                admin.Show();
                                break;
                            case "teacher":
                                isLoggedIn = true;
                                myDictionary.Add("userId",xmlId);
                                myDictionary.Add("userName", xmlName);
                                myDictionary.Add("password", xmlPassword.InnerText);
                                MessageBox.Show("Welcome, teacher!");
                                TeacherForm teacherForm;
                                teacherForm = new TeacherForm();
                                teacherForm.Show();
                                break;
                            case "student":
                                StudentForm studentForm;
                                studentForm = new StudentForm();
                                isLoggedIn =true;
                                MessageBox.Show("Welcome, student!");
                                studentForm.Show();
                                break;
                            default:
                                MessageBox.Show("email or password incorrect!");
                                break;
                        }
                    }
                }
            }

        }

    }
}

