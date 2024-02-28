namespace attendance_management_system
{
    partial class StudentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            StudentLogOutbutton = new Button();
            StudentProfileButton = new Button();
            StudentAttendanceButton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            syslabel = new Label();
            studentAttendanceUserControl1 = new controls.StudentAttendanceUserControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 37, 68);
            panel1.Controls.Add(StudentLogOutbutton);
            panel1.Controls.Add(StudentProfileButton);
            panel1.Controls.Add(StudentAttendanceButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 741);
            panel1.TabIndex = 0;
            // 
            // StudentLogOutbutton
            // 
            StudentLogOutbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StudentLogOutbutton.BackColor = Color.FromArgb(255, 208, 236);
            StudentLogOutbutton.Cursor = Cursors.Hand;
            StudentLogOutbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentLogOutbutton.ForeColor = Color.FromArgb(31, 37, 68);
            StudentLogOutbutton.Location = new Point(22, 358);
            StudentLogOutbutton.Name = "StudentLogOutbutton";
            StudentLogOutbutton.Size = new Size(193, 42);
            StudentLogOutbutton.TabIndex = 3;
            StudentLogOutbutton.Text = "Log Out";
            StudentLogOutbutton.UseVisualStyleBackColor = false;
            StudentLogOutbutton.Click += StudentLogOutbutton_Click;
            // 
            // StudentProfileButton
            // 
            StudentProfileButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StudentProfileButton.BackColor = Color.FromArgb(255, 208, 236);
            StudentProfileButton.Cursor = Cursors.Hand;
            StudentProfileButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentProfileButton.ForeColor = Color.FromArgb(31, 37, 68);
            StudentProfileButton.Location = new Point(22, 282);
            StudentProfileButton.Name = "StudentProfileButton";
            StudentProfileButton.Size = new Size(193, 42);
            StudentProfileButton.TabIndex = 2;
            StudentProfileButton.Text = "Edit Profile\r\n";
            StudentProfileButton.UseVisualStyleBackColor = false;
            StudentProfileButton.Click += StudentProfileButton_Click;
            // 
            // StudentAttendanceButton
            // 
            StudentAttendanceButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StudentAttendanceButton.BackColor = Color.FromArgb(255, 208, 236);
            StudentAttendanceButton.Cursor = Cursors.Hand;
            StudentAttendanceButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentAttendanceButton.ForeColor = Color.FromArgb(31, 37, 68);
            StudentAttendanceButton.Location = new Point(22, 208);
            StudentAttendanceButton.Name = "StudentAttendanceButton";
            StudentAttendanceButton.Size = new Size(193, 42);
            StudentAttendanceButton.TabIndex = 1;
            StudentAttendanceButton.Text = "My Attendendance";
            StudentAttendanceButton.UseVisualStyleBackColor = false;
            StudentAttendanceButton.Click += StudentAttendanceButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(syslabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 164);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.work_attendance_4;
            pictureBox1.Location = new Point(58, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // syslabel
            // 
            syslabel.AutoSize = true;
            syslabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            syslabel.ForeColor = Color.FromArgb(255, 208, 236);
            syslabel.Location = new Point(22, 115);
            syslabel.Name = "syslabel";
            syslabel.Size = new Size(209, 31);
            syslabel.TabIndex = 0;
            syslabel.Text = "Attendance system";
            // 
            // studentAttendanceUserControl1
            // 
            studentAttendanceUserControl1.BackColor = Color.White;
            studentAttendanceUserControl1.Location = new Point(258, 0);
            studentAttendanceUserControl1.Name = "studentAttendanceUserControl1";
            studentAttendanceUserControl1.Size = new Size(1249, 748);
            studentAttendanceUserControl1.TabIndex = 1;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1534, 741);
            Controls.Add(studentAttendanceUserControl1);
            Controls.Add(panel1);
            Name = "StudentForm";
            Text = "StudentForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label syslabel;
        private Button StudentLogOutbutton;
        private Button StudentProfileButton;
        private Button StudentAttendanceButton;
        private controls.StudentAttendanceUserControl studentAttendanceUserControl1;
    }
}