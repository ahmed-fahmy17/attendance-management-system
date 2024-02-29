﻿using System;
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



            xmlDocument = new XmlDocument();
            xmlDocument.Load("C:\\Users\\USER\\Desktop\\final\\attendance-management-system\\xml\\users.xml");
            XmlElement root = xmlDocument.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                nameNode = node.SelectSingleNode("id");
                if (nameNode.InnerText == userId)
                {
                    passwordNode = node.SelectSingleNode("password");
                    userName = node.SelectSingleNode("name");
                    string password = passwordNode?.InnerText;
                    string name = nameNode?.InnerText;
                    userNameTxt.Text = userName.InnerText;
                    userPasswordTxt.Text = password;
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
                nameErrorLabel.Text = "";
                userName.InnerText = userNameTxt.Text;
                passwordErrorLabel.Text = "";
                passwordNode.InnerText = userPasswordTxt.Text;
                xmlDocument.Save("C:\\Users\\USER\\Desktop\\final\\attendance-management-system\\xml\\users.xml");

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
    }
}