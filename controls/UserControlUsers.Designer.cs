namespace attendance_management_system.controls
{
    partial class UserControlUsers
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
            UsersTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxID = new TextBox();
            textBoxRole = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAge = new TextBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            label5 = new Label();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UsersTable).BeginInit();
            SuspendLayout();
            // 
            // UsersTable
            // 
            UsersTable.AllowUserToAddRows = false;
            UsersTable.AllowUserToDeleteRows = false;
            UsersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersTable.BackgroundColor = Color.Gray;
            UsersTable.BorderStyle = BorderStyle.None;
            UsersTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            UsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column5, Column6, Column2, Column8, Column3 });
            UsersTable.Location = new Point(0, 41);
            UsersTable.Name = "UsersTable";
            UsersTable.ReadOnly = true;
            UsersTable.RowHeadersWidth = 51;
            UsersTable.Size = new Size(939, 271);
            UsersTable.TabIndex = 0;
            UsersTable.SelectionChanged += UsersTable_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Age";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Phone";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Password";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Role";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 326);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 326);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 326);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 375);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 4;
            label4.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 433);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 6;
            label6.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 375);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "Phone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(531, 323);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(300, 323);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 9;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(75, 323);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 10;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(75, 426);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(125, 27);
            textBoxRole.TabIndex = 11;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(300, 372);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 12;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(75, 372);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(125, 27);
            textBoxAge.TabIndex = 13;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(732, 326);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(732, 375);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(732, 430);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 372);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(531, 369);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 14;
            // 
            // UserControlUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxID);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsersTable);
            Name = "UserControlUsers";
            Size = new Size(942, 501);
            ((System.ComponentModel.ISupportInitialize)UsersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UsersTable;
        private DataGridViewTextBoxColumn Column7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private TextBox textBoxRole;
        private TextBox textBoxPhone;
        private TextBox textBoxAge;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column3;
        private Label label5;
        private TextBox textBoxPassword;
    }
}
