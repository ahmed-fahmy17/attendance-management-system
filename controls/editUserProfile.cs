using System.Xml;

namespace attendance_management_system.controls
{
    //name:esraa
    //pass:12345678
    public partial class editUserProfile : UserControl
    {

        XmlDocument xmlDocument;
        XmlNode passwordNode;
        XmlNode nameNode;
        XmlNode userName;
        public editUserProfile()
        {
            InitializeComponent();
            loadCurrentUser();
           // EditProfile();
        }
       
        private void canceBtn_Click(object sender, EventArgs e)
        {
            Parent.Hide();
        }
        public void loadCurrentUser()
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\users.xml");
            XmlElement root = xmlDocument.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
              nameNode  = node.SelectSingleNode("id");
                if (nameNode != null && nameNode.InnerText == "1")
                {
                    passwordNode = node.SelectSingleNode("password");
                    userName = node.SelectSingleNode("name");
                    string password = passwordNode?.InnerText;
                    string name = nameNode?.InnerText;
                    // Display loaded user information in the textboxes
                    userNameTxt.Text = userName.InnerText;
                    userPasswordTxt.Text = password;

                    // Exit the loop after finding the user
                    break;
                }
            }
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTxt.Text) && !string.IsNullOrEmpty(userPasswordTxt.Text))
            {
                nameErrorLabel.Text = "";
                userName.InnerText = userNameTxt.Text;
                passwordErrorLabel.Text = "";
                passwordNode.InnerText = userPasswordTxt.Text;
                xmlDocument.Save("C:\\Users\\USER\\Desktop\\c#proj4\\attendance-management-system\\xml\\users.xml");

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

            
           
            MessageBox.Show("Edited Successfully");
        }
    }
}