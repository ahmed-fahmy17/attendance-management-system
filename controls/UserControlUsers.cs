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
            if(User.IsValidId(textBoxID.Text))
                user.Id = textBoxID.Text;
            else
            {
                MessageBox.Show("User id must be 14 numbers and unique", "Wrong user ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.Name = textBoxName.Text;
            user.Email = textBoxEmail.Text;
            user.Age = int.Parse(textBoxAge.Text);
            user.Phone = textBoxPhone.Text;
            user.Password = textBoxPassword.Text;
            user.Role = textBoxRole.Text;
            XmlManipulation.AddUser(user);
            UsersTable.Rows.Add(user.Id, user.Name, user.Email, user.Age, user.Phone, user.Password, user.Role);
            MessageBox.Show("New user were added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            user.Id = textBoxID.Text;
            user.Name = textBoxName.Text;
            user.Email = textBoxEmail.Text;
            user.Age = int.Parse(textBoxAge.Text);
            user.Phone = textBoxPhone.Text;
            user.Password = textBoxPassword.Text;
            user.Role = textBoxRole.Text;
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
            ClearTextBoxes();
        }
    }
}
