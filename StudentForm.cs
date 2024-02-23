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
        public StudentForm()
        {
            InitializeComponent();
            studentAttendanceUserControl1.Visible = false;
            loginForm = new login();
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
}
