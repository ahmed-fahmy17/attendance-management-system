using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace attendance_management_system.controls
{
    public partial class UserControlUsers : UserControl
    {
        List<User> UserData = new List<User>();
        public UserControlUsers()
        {
            InitializeComponent();
            labelErrorUserData.Visible = false;
            UserData = XmlManipulation.GetUserData();
            LoadData();
        }
        public void LoadData()
        {
            foreach (User user in UserData)
            {
                UsersTable.Rows.Add(user.Id, user.Name, user.Email, user.Age, user.Phone, user.Password, user.Role);
            }
        }
        private bool ValidateEnteredUserData(ref User user)
        {
            if (User.IsValidId(textBoxID.Text))
                user.Id = textBoxID.Text;
            else
            {
                labelErrorUserData.Text = "User id must be 14 numbers";
                labelErrorUserData.Visible = true;
                return false;
            }
            if (User.isValidName(textBoxName.Text))
                user.Name = textBoxName.Text;
            else
            {
                labelErrorUserData.Text = "User name must be at least 3 characters with no numbers";
                labelErrorUserData.Visible = true;
                //MessageBox.Show("User name must be at least 3 characters with no numbers", "Wrong user Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.isValidEmail(textBoxEmail.Text))
                user.Email = textBoxEmail.Text;
            else
            {
                labelErrorUserData.Text = "Wrong email format";
                labelErrorUserData.Visible = true;
                //MessageBox.Show("Wrong email format", "Wrong Email format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.isValidAge(int.Parse(textBoxAge.Text)))
                user.Age = int.Parse(textBoxAge.Text);
            else
            {
                labelErrorUserData.Text = "Age must be number greater than 3";
                labelErrorUserData.Visible = true;
                //MessageBox.Show("Age must be greater than 3", "Wrong Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.isValidPhone(textBoxPhone.Text))
                user.Phone = textBoxPhone.Text;
            else
            {
                labelErrorUserData.Text = "Wrong phone format";
                labelErrorUserData.Visible = true;
                //MessageBox.Show("Wrong phone format", "Wrong phone format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.isValidPassword(textBoxPassword.Text))
                user.Password = textBoxPassword.Text;
            else
            {
                labelErrorUserData.Text = "Password must be at least 8 characters with numbers and special characters";
                labelErrorUserData.Visible = true;
                //MessageBox.Show("Password must be at least 8 characters with numbers and special characters", "Wrong password format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.isValidRole(textBoxRole.Text))
                user.Role = textBoxRole.Text;
            else
            {
                labelErrorUserData.Text = "Role is either student or teacher";
                labelErrorUserData.Visible = true;
                //MessageBox.Show("Role is either student or teacher", "Wrong Role format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ClearTextBoxes()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxAge.Text = "";
            textBoxPhone.Text = "";
            textBoxPassword.Text = "";
            textBoxRole.Text = "";
        }

        private void UsersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (UsersTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = UsersTable.SelectedRows[0];
                textBoxID.Text = selectedRow.Cells[0].Value.ToString();
                textBoxName.Text = selectedRow.Cells[1].Value.ToString();
                textBoxEmail.Text = selectedRow.Cells[2].Value.ToString();
                textBoxAge.Text = selectedRow.Cells[3].Value.ToString();
                textBoxPhone.Text = selectedRow.Cells[4].Value.ToString();
                textBoxPassword.Text = selectedRow.Cells[5].Value.ToString();
                textBoxRole.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (!ValidateEnteredUserData(ref user))
                return;
            if(!User.IsUniqueId(user.Id))
            {
                labelErrorUserData.Text = "User id must be unique";
                labelErrorUserData.Visible = true;
                return;
            }
            if(!User.isUniqueEmail(user.Email))
            {
                labelErrorUserData.Text = "User Email must be unique";
                labelErrorUserData.Visible = true;
                return;
            }
            XmlManipulation.AddUser(user);
            UsersTable.Rows.Add(user.Id, user.Name, user.Email, user.Age, user.Phone, user.Password, user.Role);
            MessageBox.Show("New user were added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelErrorUserData.Visible = false;
            ClearTextBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (UsersTable.SelectedRows.Count > 0)
            {
                int selectedIndex = UsersTable.SelectedRows[0].Index;
                string userId = UsersTable.Rows[selectedIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to delete this user ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    XmlManipulation.RemoveUser(userId);
                    UsersTable.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("User deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (!ValidateEnteredUserData(ref user))
                return;
            DataGridViewRow selectedRow = UsersTable.SelectedRows[0];
            string oldUserId = selectedRow.Cells[0].Value.ToString();
            XmlManipulation.RemoveUser(oldUserId);
            XmlManipulation.AddUser(user);
            selectedRow.Cells[0].Value = user.Id;
            selectedRow.Cells[1].Value = user.Name;
            selectedRow.Cells[2].Value = user.Email;
            selectedRow.Cells[3].Value = user.Age;
            selectedRow.Cells[4].Value = user.Phone;
            selectedRow.Cells[5].Value = user.Password;
            selectedRow.Cells[6].Value = user.Role;
            MessageBox.Show("User updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelErrorUserData.Visible = false;
            ClearTextBoxes();
        }
    }
}
