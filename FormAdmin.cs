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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString();
        }

        private void MoveSidePanel(Button btn)
        {
            panelSide.Location = new Point(0, btn.Location.Y - 152);
        }

        private void BTNUpdateAdminData_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNUpdateAdminData);
        }

        private void BTNDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNDashboard);
        }

        private void BTNClasses_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNClasses);
        }

        private void BTNStudents_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNStudents);
        }

        private void BTNReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNReport);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout ?","logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
        }
    }
}
