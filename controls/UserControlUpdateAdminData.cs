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
        }

        private void UpdateAdminBTN_Click(object sender, EventArgs e)
        {
            Admin TmpAdmin = new Admin();
            TmpAdmin.Email = textBoxAdminEmail.Text;
            TmpAdmin.Password = textBoxAdminNewPassword.Text;
            XmlManipulation.UpdateAdmin(TmpAdmin);
            MessageBox.Show("Data updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxAdminEmail.Text = TmpAdmin.Email;
            textBoxAdminOldPassword.Text = TmpAdmin.Password;
            textBoxAdminNewPassword.Text = "";
        }
    }
}
