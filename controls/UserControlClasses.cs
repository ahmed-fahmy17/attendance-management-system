using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
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
            labelErrorClass.Visible = false;
            labelErrorStudent.Visible = false;
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
        private bool ValidateEnteredClassData(Class _class)
        {
            if(!Class.isValidClassId(_class.ClassId))
            {
                labelErrorClass.Text = "class id must be at least 3 characters";
                labelErrorClass.Visible = true;
                return false;
            }
            if(!Class.isValidClassName(_class.ClassName))
            {
                labelErrorClass.Text = "class name must be at least 3 characters";
                labelErrorClass.Visible = true;
                return false;
            }
            if(!User.IsValidId(_class.ClassTeacherId))
            {
                labelErrorClass.Text = "Teacher id must be 14 numbers";
                labelErrorClass.Visible = true;
                return false;
            }
            if(!User.isValidTeacherId(_class.ClassTeacherId))
            {
                labelErrorClass.Text = "No teacher with this id";
                labelErrorClass.Visible = true;
                return false;
            }
            return true;
        }
        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            Class _class = new Class(textBoxClassID.Text, textBoxClassName.Text, textBoxTeacherID.Text);
            if (!ValidateEnteredClassData(_class))
                return;
            if (!Class.IsUniqueClassId(_class.ClassId))
            {
                labelErrorClass.Text = "class id must be unique";
                labelErrorClass.Visible = true;
                return;
            }
            XmlManipulation.AddClass(_class);
            ClassesTable.Rows.Add(_class.ClassId, _class.ClassName, _class.ClassTeacherId);
            MessageBox.Show("New class were added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void buttonUpdateClass_Click(object sender, EventArgs e)
        {
            if (ClassesTable.SelectedRows.Count == 0)
            {
                labelErrorClass.Text = "please select a class from the table first";
                labelErrorClass.Visible = true;
                return;
            }
            Class _class = new Class(textBoxClassID.Text, textBoxClassName.Text, textBoxTeacherID.Text);
            if (!ValidateEnteredClassData(_class))
                return;
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
            if (ClassesTable.SelectedRows.Count == 0)
            {
                labelErrorClass.Text = "please select a class from the table first";
                labelErrorClass.Visible = true;
                return;
            }
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
            if (!User.IsValidId(StId))
            {
                labelErrorStudent.Text = "Student id must be 14 numbers";
                labelErrorStudent.Visible = true;
                return;
            }
            if(!User.isValidStudentId(StId))
            {
                labelErrorStudent.Text = "No student with this id";
                labelErrorStudent.Visible = true;
                return;
            }
            if(Class.IsUniqueClassId(ClassId))
            {
                labelErrorStudent.Text = "Class id doesn't exist";
                labelErrorStudent.Visible = true;
                return;
            }
            if(Class.IsExistUserInClass(StId, ClassId))
            {
                labelErrorStudent.Text = "this student is already in this class";
                labelErrorStudent.Visible = true;
                return;
            }
            XmlManipulation.AddStudentToClass(StId, ClassId);
            User user = XmlManipulation.GetSingleUserByID(StId);
            ClassUsersTable.Rows.Add(user.Id, user.Name, user.Age);
            MessageBox.Show("Student added to the class", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelErrorStudent.Visible = false;
        }

        private void RemoveStudentFromClassBTN_Click(object sender, EventArgs e)
        {
            if (ClassUsersTable.SelectedRows.Count == 0)
            {
                labelErrorStudent.Text = "please select a student to delete first";
                labelErrorStudent.Visible = true;
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete this student from the class ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string StId = textBoxStudentId.Text;
                string ClassId = textBoxClassID.Text;
                XmlManipulation.RemoveStudentFromClass(StId, ClassId);
                int selectedIndex = ClassUsersTable.SelectedRows[0].Index;
                ClassUsersTable.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("student deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
