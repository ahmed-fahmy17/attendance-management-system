using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace attendance_management_system.controls
{
    public partial class UserControlClasses : UserControl
    {
        List<Class> ClassData = new List<Class>();
        public UserControlClasses()
        {
            InitializeComponent();
            ClassData = XmlManipulation.GetClassData();
            LoadData();
        }
        public void LoadData()
        {
            foreach (Class _class in ClassData)
            {
                ClassesTable.Rows.Add(_class.ClassId, _class.ClassName, _class.ClassTeacherId);
            }
        }

        private void ClassesTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ClassesTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ClassesTable.SelectedRows[0];
                textBoxClassID.Text = selectedRow.Cells[0].Value.ToString();
                textBoxClassName.Text = selectedRow.Cells[1].Value.ToString();
                textBoxTeacherID.Text = selectedRow.Cells[2].Value.ToString();
                ClassUsersTable.Rows.Clear();
                textBoxStudentId.Text = "";
                List<User> curStudents = XmlManipulation.GetClassStudents(textBoxClassID.Text);
                foreach (User curStudent in curStudents)
                {
                    ClassUsersTable.Rows.Add(curStudent.Id, curStudent.Name, curStudent.Age);
                }
            }
        }
        public void ClearTextBoxes()
        {
            textBoxClassID.Text = "";
            textBoxClassName.Text = "";
            textBoxTeacherID.Text = "";
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            Class _class = new Class(textBoxClassID.Text, textBoxClassName.Text, textBoxTeacherID.Text);
            XmlManipulation.AddClass(_class);
            ClassesTable.Rows.Add(_class.ClassId, _class.ClassName, _class.ClassTeacherId);
            MessageBox.Show("New class were added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void buttonUpdateClass_Click(object sender, EventArgs e)
        {
            Class _class = new Class(textBoxClassID.Text, textBoxClassName.Text, textBoxTeacherID.Text);
            DataGridViewRow selectedRow = ClassesTable.SelectedRows[0];
            string oldClassId = selectedRow.Cells[0].Value.ToString();
            XmlManipulation.UpdateClass(oldClassId, _class);
            selectedRow.Cells[0].Value = _class.ClassId;
            selectedRow.Cells[1].Value = _class.ClassName;
            selectedRow.Cells[2].Value = _class.ClassTeacherId;
            MessageBox.Show("Class updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {
            if (ClassesTable.SelectedRows.Count > 0)
            {
                int selectedIndex = ClassesTable.SelectedRows[0].Index;
                string classId = ClassesTable.Rows[selectedIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to delete this class ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    XmlManipulation.RemoveClass(classId);
                    ClassesTable.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("Class deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }
            }
        }

        private void ClassUsersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ClassUsersTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ClassUsersTable.SelectedRows[0];
                textBoxStudentId.Text = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void AddStudentToClassBTN_Click(object sender, EventArgs e)
        {
            string StId = textBoxStudentId.Text;
            string ClassId = textBoxClassID.Text;
            XmlManipulation.AddStudentToClass(StId, ClassId);
            User user = XmlManipulation.GetSingleUserByID(StId);
            ClassUsersTable.Rows.Add(user.Id, user.Name, user.Age);
        }

        private void RemoveStudentFromClassBTN_Click(object sender, EventArgs e)
        {
            string StId = textBoxStudentId.Text;
            string ClassId = textBoxClassID.Text;
            XmlManipulation.RemoveStudentFromClass(StId, ClassId);
            int selectedIndex = ClassUsersTable.SelectedRows[0].Index;
            ClassUsersTable.Rows.RemoveAt(selectedIndex);
        }
    }
}
