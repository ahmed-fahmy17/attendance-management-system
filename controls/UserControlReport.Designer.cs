namespace attendance_management_system.controls
{
    partial class UserControlReport
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
            label1 = new Label();
            Class = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(41, 14);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 0;
            label1.Text = "Report:-";
            // 
            // Class
            // 
            Class.AutoSize = true;
            Class.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Class.ForeColor = Color.IndianRed;
            Class.Location = new Point(60, 83);
            Class.Name = "Class";
            Class.Size = new Size(52, 25);
            Class.TabIndex = 1;
            Class.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(290, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Class";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(290, 124);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, ClassName, Column3, Column4 });
            dataGridView1.Location = new Point(41, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 303);
            dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Student Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // ClassName
            // 
            ClassName.HeaderText = "Class";
            ClassName.MinimumWidth = 6;
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // UserControlReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(Class);
            Controls.Add(label1);
            Name = "UserControlReport";
            Size = new Size(872, 504);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Class;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
