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
            ClassUsersTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxID = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonAddClass = new Button();
            buttonUpdateClass = new Button();
            buttonDeleteClass = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)ClassesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassUsersTable).BeginInit();
            SuspendLayout();
            // 
            // ClassesTable
            // 
            ClassesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassesTable.BackgroundColor = Color.White;
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
            // 
            // ClassUsersTable
            // 
            ClassUsersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassUsersTable.BackgroundColor = Color.White;
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
            // textBoxID
            // 
            textBoxID.Location = new Point(154, 315);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 366);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 423);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Location = new Point(330, 314);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(116, 29);
            buttonAddClass.TabIndex = 16;
            buttonAddClass.Text = "Add Class";
            buttonAddClass.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateClass
            // 
            buttonUpdateClass.Location = new Point(330, 366);
            buttonUpdateClass.Name = "buttonUpdateClass";
            buttonUpdateClass.Size = new Size(116, 29);
            buttonUpdateClass.TabIndex = 17;
            buttonUpdateClass.Text = "Update Class";
            buttonUpdateClass.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.Location = new Point(330, 423);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(116, 29);
            buttonDeleteClass.TabIndex = 18;
            buttonDeleteClass.Text = "Delete Class";
            buttonDeleteClass.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(719, 318);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 19;
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
            // button1
            // 
            button1.Location = new Point(556, 397);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 21;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(769, 397);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 22;
            button2.Text = "Remove Student";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserControlClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(buttonDeleteClass);
            Controls.Add(buttonUpdateClass);
            Controls.Add(buttonAddClass);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxID);
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
        private TextBox textBoxID;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAddClass;
        private Button buttonUpdateClass;
        private Button buttonDeleteClass;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}
