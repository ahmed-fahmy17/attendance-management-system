using attendance_management_system.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

            if(Program.isArabic)
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-EG");
                BTNClasses.Text = "الفصول";
                BTNStudents.Text = "المستخدمين";
                BTNReport.Text = "تقارير";
                BTNUpdateAdminData.Text = "تحديث بياناتك";
                label3.Text = "اهلا";
                BTNLogout.Text = "تسجيل الخروج";
                buttonBackUp.Text = "حفظ البيانات";
                label1.Text = "نظام اداره الغياب";

                BTNClasses.RightToLeft = RightToLeft.Yes;
                BTNStudents.RightToLeft = RightToLeft.Yes;
                BTNReport.RightToLeft = RightToLeft.Yes;
                BTNUpdateAdminData.RightToLeft = RightToLeft.Yes;
                label3.RightToLeft = RightToLeft.Yes;
                BTNLogout.RightToLeft = RightToLeft.Yes;
                buttonBackUp.RightToLeft = RightToLeft.Yes;
                label1.RightToLeft = RightToLeft.Yes;
            }
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
            userControlUpdateAdminData1.Visible = true;
            userControlUsers1.Visible = false;
            userControlClasses1.Visible = false;
        }

        private void BTNClasses_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNClasses);
            userControlClasses1.Visible = true;
            userControlUpdateAdminData1.Visible = false;
            userControlUsers1.Visible = false;
        }

        private void BTNStudents_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNStudents);
            userControlUsers1.Visible = true;
            userControlUpdateAdminData1.Visible = false;
            userControlClasses1.Visible = false;
        }

        private void BTNReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BTNReport);
            userControlUpdateAdminData1.Visible = false;
            userControlUsers1.Visible = false;
            userControlClasses1.Visible = false;
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout ?", "logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
        }

        private void buttonBackUp_Click(object sender, EventArgs e)
        {
            XmlManipulation.BackUpData();
            MessageBox.Show("Data backedup successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
