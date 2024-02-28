using attendance_management_system.controls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static attendance_management_system.login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace attendance_management_system
{

    public partial class TeacherForm : Form
    {
        public Dictionary<string, string> MyDictionary { get; set; }

        login loginForm;
        System.Timers.Timer timer;
        private TabControl tabControl1;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private editUserProfile editUserProfile;
        private StudentReport studentRepo;
        private ChooseFormType chooseFormType;
        public TeacherForm()
        {
            InitializeComponent();
            //Timer
            timer = new System.Timers.Timer();
            timer.Interval = 1000;//milliseconds(1 second)
            timer.Elapsed += labelTime_Click;//update the value of the time label
            timer.Start();
            attendanceBtn.Click += attendanceBtn_Click;
            loginForm = new login();
            userControl11.Visible = false;
            userControlReport1.Visible = false;
            filterByClass1.Visible = false;
            stusentReport1.Visible = false;
            editUserProfile = new editUserProfile();
            chooseFormType = new ChooseFormType();
          
               
              



        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            //hide expanded banel on form load

            //display date 
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            LanguageComboBox.SelectedIndex = 1;
            qwert.Text = MyDictionary["userName"];
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
                chooseFormType1.Visible = false;
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (userControl11 != null && userControlReport1 != null)
            {
                userControl11.Visible = false;
                userControlReport1.Visible = false;
                chooseFormType1.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "LOG OUT!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                loginForm.Show();
                TeacherForm form = new TeacherForm();
                form.Dispose();
                form.Close();
            }
            else
            {

            }
        }
        private void ProfileButton_Click_1(object sender, EventArgs e)
        {
            Form edit = new Form();
            edit.Text = "Edit profile";
            edit.ClientSize = editUserProfile.Size;
            edit.Controls.Add(editUserProfile);
            edit.ShowDialog();
        }
        private void UpdateUIWithLanguage()
        {
            try
            {
                // Load the XML file containing language preferences
                XmlDocument doc = new XmlDocument();
                doc.Load("C:\\Users\\USER\\Desktop\\c#project4\\attendance-management-system\\xml\\Language.xml"); // Adjust the path as needed
              
                // Find the language node with the selected attribute set to true
                string selected = LanguageComboBox.SelectedItem?.ToString(); // Ensure selected item is not null
                if (selected != null)
                {
                    XmlNode? selectedLanguageNode = doc.SelectSingleNode($"Languages/language[code='{selected}']");

                    if (selectedLanguageNode != null)
                    {
                        // Get the translation node for "Attendance"
                        XmlNode? attendanceTranslationNode = selectedLanguageNode.SelectSingleNode("translation/Attendance");
                        XmlNode? reportTranslationNode = selectedLanguageNode.SelectSingleNode("translation/Report");
                        XmlNode? logouTranslationNode = selectedLanguageNode.SelectSingleNode("translation/LogOut");
                        XmlNode? editProfileTranslation = selectedLanguageNode.SelectSingleNode("translation/EditProfile");
                        XmlNode? welcomeTranslation = selectedLanguageNode.SelectSingleNode("translation/Welcome");
                        XmlNode? SystemAttendanceTranslation = selectedLanguageNode.SelectSingleNode("translation/AttendanceSystem");
                        XmlNode? langlabeltranslation = selectedLanguageNode.SelectSingleNode("translation/choosethelanhuage");
                        XmlNode?  typeofreporttranslation = selectedLanguageNode.SelectSingleNode("translation/choosethetypetypeofreport");

                        if (attendanceTranslationNode != null && reportTranslationNode != null)
                        {
                            // Update the text of the buttons with the translated text
                            attendanceBtn.Text = attendanceTranslationNode.InnerText;
                            reportBtn.Text = reportTranslationNode.InnerText;
                            logoutBtn.Text = logouTranslationNode?.InnerText;
                            ProfileButton.Text = editProfileTranslation?.InnerText;
                            welcomeLabel.Text = welcomeTranslation?.InnerText;
                            SysLabel.Text = SystemAttendanceTranslation?.InnerText;
                            chooseLanglabel.Text=langlabeltranslation?.InnerText;
                           
                            chooseFormType.SetLabelText(typeofreporttranslation?.InnerText);


                        }
                        else
                        {
                            Console.WriteLine("Translation for 'Attendance' or 'Report' not found in XML.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Selected language node not found in XML.");
                    }
                }
                else
                {
                    Console.WriteLine("No language selected in the combo box.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading language preference: {ex.Message}");
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUIWithLanguage();
        }

    }
}
