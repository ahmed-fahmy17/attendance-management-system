using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_management_system.controls
{
    public partial class UserControlUpdateAdminData : UserControl
    {
        Admin admin = new Admin();
        public UserControlUpdateAdminData()
        {
            InitializeComponent();
            admin = XmlManipulation.GetAdminData();
            textBoxAdminEmail.Text = admin.Email;
            textBoxAdminOldPassword.Text = admin.Password;
            labelErrorAdminData.Visible = false;
        }

        private void UpdateAdminBTN_Click(object sender, EventArgs e)
        {
            Admin TmpAdmin = new Admin();
            TmpAdmin.Email = textBoxAdminEmail.Text;
            TmpAdmin.Password = textBoxAdminNewPassword.Text;
            if(!User.isValidEmail(TmpAdmin.Email))
            {
                labelErrorAdminData.Text = "wrong Email format!";
                labelErrorAdminData.Visible = true;
                return;
            }
            if(!User.isValidPassword(TmpAdmin.Password))
            {
                labelErrorAdminData.Text = "Weak password. it must be 8 characters at least with special characters,numbers and letters";
                labelErrorAdminData.Visible = true;
                return;
            }
            labelErrorAdminData.Visible = false;
            XmlManipulation.UpdateAdmin(TmpAdmin);
            MessageBox.Show("Data updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxAdminEmail.Text = TmpAdmin.Email;
            textBoxAdminOldPassword.Text = TmpAdmin.Password;
            textBoxAdminNewPassword.Text = "";
        }
    }
}
