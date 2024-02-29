using attendance_management_system.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_management_system
{
    public partial class StudentForm : Form
    {
        login loginForm;
        private editUserProfile editUserProfile;
        public StudentForm()
        {
            InitializeComponent();
          studentAttendanceUserControl1.Visible = false;
            loginForm = new login();
            editUserProfile = new editUserProfile();
            if(Program.isArabic)
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-EG");
                StudentAttendanceButton.Text = "حضوري";
                StudentProfileButton.Text = "تعديل صفحتك الشخصيه";
                StudentLogOutbutton.Text = "تسجيل الخروج";

                StudentAttendanceButton.RightToLeft = RightToLeft.Yes;
                StudentProfileButton.RightToLeft = RightToLeft.Yes;
                StudentLogOutbutton.RightToLeft = RightToLeft.Yes;
            }
        }
        private void StudentAttendanceButton_Click(object sender, EventArgs e)
        {
            if (studentAttendanceUserControl1 != null)
            {
                studentAttendanceUserControl1.Visible = true;
            }
        }
        private void StudentLogOutbutton_Click(object sender, EventArgs e)
        {
            if(Program.isArabic)
            {
                DialogResult result = MessageBox.Show(
                           "هل أنت متأكد أنك تريد تسجيل الخروج؟",
                                             "تسجيل خروج!",
                            MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    StudentForm studentForm = new StudentForm();

                    loginForm.Show();
                    Close();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                           "Are you sure you want to logout?",
                                             "LOG OUT!",
                            MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    StudentForm studentForm = new StudentForm();

                    loginForm.Show();
                    Close();
                }
            }
            

        }
        private void StudentProfileButton_Click(object sender, EventArgs e)
        {
            Form edit = new Form();
            edit.Text = "Edit profile";
            edit.ClientSize = editUserProfile.Size;
            edit.Controls.Add(editUserProfile);
            edit.ShowDialog();
        }
    }
}
