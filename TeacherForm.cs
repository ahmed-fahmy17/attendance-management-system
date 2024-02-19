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

    public partial class TeacherForm : Form
    {
        System.Timers.Timer timer;
        private TabControl tabControl1;
        private TabControl tabControl2;
        private TabPage tabPage1;
        public TeacherForm()
        {
            InitializeComponent();

            //Timer
            timer = new System.Timers.Timer();
            timer.Interval = 1000;//milliseconds(1 second)
            timer.Elapsed += labelTime_Click;//update the value of the time label
            timer.Start();

            attendanceBtn.Click += attendanceBtn_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            //hide expanded banel on form load
           
            //display date 
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");


        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            //in windows form ui elements can be only updated from the main ui thread
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { labelTime.Text = DateTime.Now.ToString("h:mm:ss tt"); });
            }
            else
            {
                //current thread is the main UI thread
                labelTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //confirmation message
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Log out!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            if (userControl11 != null && userControlReport1 != null)
            {
                userControl11.Visible = true;
                userControlReport1.Visible = false;
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (userControl11 != null && userControlReport1 != null)
            {
                userControl11.Visible = false;
                userControlReport1.Visible = true;
            }
        }
        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
