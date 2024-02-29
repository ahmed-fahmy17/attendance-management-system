using Org.BouncyCastle.Asn1.Ocsp;
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

        public login()
        {
            InitializeComponent();

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            Admin adminData = XmlManipulation.GetAdminData();
            if (adminData.Email == email && adminData.Password == password)
            {
                FormAdmin admin = new FormAdmin();
                this.Hide();
                admin.Show();
                return;
            }
            List<User> usersData = XmlManipulation.GetUserData();
            foreach (User user in usersData)
            {
                if (user.Email == email && user.Password == password)
                {
                    myDictionary.Add("userId", user.Id);
                    myDictionary.Add("userName", user.Name);
                    myDictionary.Add("password", user.Password);
                    if (user.Role == "student")
                    {
                        StudentForm studentForm = new StudentForm();
                        this.Hide();
                        studentForm.Show();
                        return;
                    }
                    else
                    {
                        TeacherForm teacherForm = new TeacherForm();
                        this.Hide();
                        teacherForm.Show();
                        return;
                    }
                }
            }
        }

    }
}