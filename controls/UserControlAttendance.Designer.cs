namespace attendance_management_system.controls
{
    partial class UserControlAttendance
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
            dataGridView1 = new DataGridView();
            studentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            studentEmail = new DataGridViewTextBoxColumn();
            studentStaus = new DataGridViewTextBoxColumn();
            AttendanceLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentId, StudentName, studentEmail, studentStaus });
            dataGridView1.Location = new Point(26, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(766, 262);
            dataGridView1.TabIndex = 0;
            // 
            // studentId
            // 
            studentId.HeaderText = "Id";
            studentId.MinimumWidth = 6;
            studentId.Name = "studentId";
            studentId.ReadOnly = true;
            studentId.Resizable = DataGridViewTriState.False;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // studentEmail
            // 
            studentEmail.HeaderText = "Email";
            studentEmail.MinimumWidth = 6;
            studentEmail.Name = "studentEmail";
            studentEmail.ReadOnly = true;
            studentEmail.Resizable = DataGridViewTriState.False;
            // 
            // studentStaus
            // 
            studentStaus.HeaderText = "status";
            studentStaus.MinimumWidth = 6;
            studentStaus.Name = "studentStaus";
            studentStaus.ReadOnly = true;
            // 
            // AttendanceLabel
            // 
            AttendanceLabel.AutoSize = true;
            AttendanceLabel.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttendanceLabel.ForeColor = Color.Brown;
            AttendanceLabel.Location = new Point(26, 10);
            AttendanceLabel.Name = "AttendanceLabel";
            AttendanceLabel.Size = new Size(205, 31);
            AttendanceLabel.TabIndex = 1;
            AttendanceLabel.Text = "Mark Attendance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(478, 58);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 2;
            label1.Text = "Class name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(26, 58);
            label2.Name = "label2";
            label2.Size = new Size(66, 31);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "pick date" });
            comboBox1.Location = new Point(26, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(478, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // UserControlAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AttendanceLabel);
            Controls.Add(dataGridView1);
            Name = "UserControlAttendance";
            Size = new Size(809, 548);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label AttendanceLabel;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn studentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn studentEmail;
        private DataGridViewTextBoxColumn studentStaus;
    }
}
