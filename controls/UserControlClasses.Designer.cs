namespace attendance_management_system.controls
{
    partial class UserControlClasses
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClassesTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ClassUsersTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxClassID = new TextBox();
            textBoxClassName = new TextBox();
            textBoxTeacherID = new TextBox();
            buttonAddClass = new Button();
            buttonUpdateClass = new Button();
            buttonDeleteClass = new Button();
            textBoxStudentId = new TextBox();
            label4 = new Label();
            AddStudentToClassBTN = new Button();
            RemoveStudentFromClassBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)ClassesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassUsersTable).BeginInit();
            SuspendLayout();
            // 
            // ClassesTable
            // 
            ClassesTable.AllowUserToAddRows = false;
            ClassesTable.AllowUserToDeleteRows = false;
            ClassesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassesTable.BackgroundColor = Color.Gray;
            ClassesTable.BorderStyle = BorderStyle.None;
            ClassesTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ClassesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassesTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2 });
            ClassesTable.Location = new Point(0, 21);
            ClassesTable.Name = "ClassesTable";
            ClassesTable.ReadOnly = true;
            ClassesTable.RowHeadersWidth = 51;
            ClassesTable.Size = new Size(446, 259);
            ClassesTable.TabIndex = 1;
            ClassesTable.SelectionChanged += ClassesTable_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Class ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Class Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Class Teacher";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // ClassUsersTable
            // 
            ClassUsersTable.AllowUserToAddRows = false;
            ClassUsersTable.AllowUserToDeleteRows = false;
            ClassUsersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassUsersTable.BackgroundColor = Color.Gray;
            ClassUsersTable.BorderStyle = BorderStyle.None;
            ClassUsersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ClassUsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassUsersTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            ClassUsersTable.Location = new Point(467, 21);
            ClassUsersTable.Name = "ClassUsersTable";
            ClassUsersTable.ReadOnly = true;
            ClassUsersTable.RowHeadersWidth = 51;
            ClassUsersTable.Size = new Size(475, 259);
            ClassUsersTable.TabIndex = 2;
            ClassUsersTable.SelectionChanged += ClassUsersTable_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Student ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Student age";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 318);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Class ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 366);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Class Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 423);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Class Teacher ID";
            // 
            // textBoxClassID
            // 
            textBoxClassID.Location = new Point(154, 315);
            textBoxClassID.Name = "textBoxClassID";
            textBoxClassID.Size = new Size(125, 27);
            textBoxClassID.TabIndex = 11;
            // 
            // textBoxClassName
            // 
            textBoxClassName.Location = new Point(154, 366);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(125, 27);
            textBoxClassName.TabIndex = 12;
            // 
            // textBoxTeacherID
            // 
            textBoxTeacherID.Location = new Point(154, 423);
            textBoxTeacherID.Name = "textBoxTeacherID";
            textBoxTeacherID.Size = new Size(125, 27);
            textBoxTeacherID.TabIndex = 13;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Location = new Point(330, 314);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(116, 29);
            buttonAddClass.TabIndex = 16;
            buttonAddClass.Text = "Add Class";
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += buttonAddClass_Click;
            // 
            // buttonUpdateClass
            // 
            buttonUpdateClass.Location = new Point(330, 366);
            buttonUpdateClass.Name = "buttonUpdateClass";
            buttonUpdateClass.Size = new Size(116, 29);
            buttonUpdateClass.TabIndex = 17;
            buttonUpdateClass.Text = "Update Class";
            buttonUpdateClass.UseVisualStyleBackColor = true;
            buttonUpdateClass.Click += buttonUpdateClass_Click;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.Location = new Point(330, 423);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(116, 29);
            buttonDeleteClass.TabIndex = 18;
            buttonDeleteClass.Text = "Delete Class";
            buttonDeleteClass.UseVisualStyleBackColor = true;
            buttonDeleteClass.Click += buttonDeleteClass_Click;
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Location = new Point(719, 318);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(125, 27);
            textBoxStudentId.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 318);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 20;
            label4.Text = "Student ID";
            // 
            // AddStudentToClassBTN
            // 
            AddStudentToClassBTN.Location = new Point(556, 397);
            AddStudentToClassBTN.Name = "AddStudentToClassBTN";
            AddStudentToClassBTN.Size = new Size(116, 29);
            AddStudentToClassBTN.TabIndex = 21;
            AddStudentToClassBTN.Text = "Add Student";
            AddStudentToClassBTN.UseVisualStyleBackColor = true;
            AddStudentToClassBTN.Click += AddStudentToClassBTN_Click;
            // 
            // RemoveStudentFromClassBTN
            // 
            RemoveStudentFromClassBTN.Location = new Point(769, 397);
            RemoveStudentFromClassBTN.Name = "RemoveStudentFromClassBTN";
            RemoveStudentFromClassBTN.Size = new Size(116, 29);
            RemoveStudentFromClassBTN.TabIndex = 22;
            RemoveStudentFromClassBTN.Text = "Remove Student";
            RemoveStudentFromClassBTN.UseVisualStyleBackColor = true;
            RemoveStudentFromClassBTN.Click += RemoveStudentFromClassBTN_Click;
            // 
            // UserControlClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(RemoveStudentFromClassBTN);
            Controls.Add(AddStudentToClassBTN);
            Controls.Add(label4);
            Controls.Add(textBoxStudentId);
            Controls.Add(buttonDeleteClass);
            Controls.Add(buttonUpdateClass);
            Controls.Add(buttonAddClass);
            Controls.Add(textBoxTeacherID);
            Controls.Add(textBoxClassName);
            Controls.Add(textBoxClassID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClassUsersTable);
            Controls.Add(ClassesTable);
            Name = "UserControlClasses";
            Size = new Size(942, 501);
            ((System.ComponentModel.ISupportInitialize)ClassesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassUsersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ClassesTable;
        private DataGridView ClassUsersTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxClassID;
        private TextBox textBoxClassName;
        private TextBox textBoxTeacherID;
        private Button buttonAddClass;
        private Button buttonUpdateClass;
        private Button buttonDeleteClass;
        private TextBox textBoxStudentId;
        private Label label4;
        private Button AddStudentToClassBTN;
        private Button RemoveStudentFromClassBTN;
    }
}
