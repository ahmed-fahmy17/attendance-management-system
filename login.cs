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
            labelErrorLogin.Visible = false;
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
                    if (user.Role == "student")
                    {
                        myDictionary.Add("userId", user.Id);
                        myDictionary.Add("userName", user.Name);
                        myDictionary.Add("password", user.Password);
                        StudentForm studentForm = new StudentForm();
                        this.Hide();
                        studentForm.Show();
                        return;
                    }
                    else
                    {
                        myDictionary.Add("userId", user.Id);
                        myDictionary.Add("userName", user.Name);
                        myDictionary.Add("password", user.Password);
                        TeacherForm teacherForm = new TeacherForm();
                        this.Hide();
                        teacherForm.Show();
                        return;
                    }
                }
            }
            labelErrorLogin.Visible = true;
        }

        private void English_CheckedChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            label1.Text = "Welcome again";
            button1.Text = "login";
            labelErrorLogin.Text = "Wrong credentials";
            label1.RightToLeft = RightToLeft.No;
            button1.RightToLeft = RightToLeft.No;
            labelErrorLogin.RightToLeft = RightToLeft.No;
            Program.isArabic = false;
        }

        private void Arabic_CheckedChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-EG");
            label1.Text = "اهلا بك مجددا";
            button1.Text = "تسجيل الدخول";
            labelErrorLogin.Text = "تسجيل دخول غير صالح";
            label1.RightToLeft = RightToLeft.Yes;
            button1.RightToLeft = RightToLeft.Yes;
            labelErrorLogin.RightToLeft = RightToLeft.Yes;
            Program.isArabic = true;
        }
    }
}