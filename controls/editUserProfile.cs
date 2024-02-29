using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace attendance_management_system.controls
{
    public partial class editUserProfile : UserControl
    {
        XmlDocument xmlDocument;
        XmlNode passwordNode;
        XmlNode nameNode;
        XmlNode userName;

        public editUserProfile()
        {
            InitializeComponent();
            LoadCurrentUser();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Parent.Hide();
        }

        public void LoadCurrentUser()
        {
            string userId;


            userId = login.myDictionary["userId"];



            List<User> users = XmlManipulation.GetUserData();

            foreach (User user in users)
            {
                if (user.Id == userId)
                {
                    userNameTxt.Text = user.Name;
                    userPasswordTxt.Text = user.Password;
                    break;
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTxt.Text) &&
              !string.IsNullOrEmpty(userPasswordTxt.Text) &&
              (userNameTxt.Text).Length >= 3 && (userPasswordTxt.Text).Length >= 6)
            {
                User user = XmlManipulation.GetSingleUserByID(login.myDictionary["userId"]);
                nameErrorLabel.Text = "";
                user.Name = userNameTxt.Text;
                passwordErrorLabel.Text = "";
                user.Password = userPasswordTxt.Text;
                XmlManipulation.RemoveUser(login.myDictionary["userId"]);
                XmlManipulation.AddUser(user);
            }
            else
            {
                nameErrorLabel.Text = "Username must be at least 3 character";
                passwordErrorLabel.Text = "Password must be at least 6 character";
                return;
            }
            if (string.IsNullOrEmpty(userNameTxt.Text))
            {
                nameErrorLabel.Text = "Username cannot be empty";
                nameErrorLabel.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(userPasswordTxt.Text))
            {
                passwordErrorLabel.Text = "Password cannot be empty"; // Corrected error message
                passwordErrorLabel.ForeColor = Color.Red;
                return;
            }


            userNameTxt.Text = "";
            userPasswordTxt.Text = "";
            this.Parent.Hide();
            MessageBox.Show("Edited Successfully");
        }

        private void canceBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }
    }
}