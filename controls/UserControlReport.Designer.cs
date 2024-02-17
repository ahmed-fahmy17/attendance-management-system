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
            StartDateComboBox = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            EndDateComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            Class.Size = new Size(99, 25);
            Class.TabIndex = 1;
            Class.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(494, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Class";
            // 
            // StartDateComboBox
            // 
            StartDateComboBox.FormattingEnabled = true;
            StartDateComboBox.Location = new Point(41, 124);
            StartDateComboBox.Name = "StartDateComboBox";
            StartDateComboBox.Size = new Size(151, 28);
            StartDateComboBox.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(494, 124);
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
            dataGridView1.Size = new Size(761, 303);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_save_64;
            pictureBox1.Location = new Point(724, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(262, 83);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 9;
            label3.Text = "End Date";
            // 
            // EndDateComboBox
            // 
            EndDateComboBox.FormattingEnabled = true;
            EndDateComboBox.Location = new Point(262, 124);
            EndDateComboBox.Name = "EndDateComboBox";
            EndDateComboBox.Size = new Size(151, 28);
            EndDateComboBox.TabIndex = 10;
            // 
            // UserControlReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(EndDateComboBox);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(StartDateComboBox);
            Controls.Add(label2);
            Controls.Add(Class);
            Controls.Add(label1);
            Name = "UserControlReport";
            Size = new Size(873, 547);
            Load += UserControlReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Class;
        private Label label2;
        private ComboBox StartDateComboBox;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox EndDateComboBox;
    }
}
