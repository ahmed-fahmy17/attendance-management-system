namespace attendance_management_system.controls
{
    partial class StudentAttendanceUserControl
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
            label1 = new Label();
            studentClassesComboBox = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(937, 396);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 64, 125);
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(199, 41);
            label1.TabIndex = 1;
            label1.Text = "Attendance";
            // 
            // studentClassesComboBox
            // 
            studentClassesComboBox.FormattingEnabled = true;
            studentClassesComboBox.Location = new Point(721, 80);
            studentClassesComboBox.Name = "studentClassesComboBox";
            studentClassesComboBox.Size = new Size(189, 28);
            studentClassesComboBox.TabIndex = 3;
            studentClassesComboBox.SelectedIndexChanged += studentClassesComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(31, 37, 68);
            label2.Location = new Point(745, 40);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 4;
            label2.Text = "Your Classes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_save_641;
            pictureBox1.Location = new Point(989, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 65);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // StudentAttendanceUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(studentClassesComboBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "StudentAttendanceUserControl";
            Size = new Size(1214, 636);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox studentClassesComboBox;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
