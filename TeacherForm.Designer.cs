namespace attendance_management_system
{
    partial class TeacherForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            reportBtn = new Button();
            pictureBox4 = new PictureBox();
            attendanceBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox7 = new PictureBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            labelTime = new Label();
            dateLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            userControl11 = new controls.UserControlAttendance();
            userControlReport1 = new controls.UserControlReport();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(reportBtn);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(attendanceBtn);
            panel1.Controls.Add(panel2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.report;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // reportBtn
            // 
            reportBtn.Cursor = Cursors.Hand;
            reportBtn.FlatAppearance.BorderColor = Color.Gray;
            reportBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(reportBtn, "reportBtn");
            reportBtn.ForeColor = SystemColors.ButtonHighlight;
            reportBtn.Name = "reportBtn";
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.attendant_list;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // attendanceBtn
            // 
            attendanceBtn.Cursor = Cursors.Hand;
            attendanceBtn.FlatAppearance.BorderColor = Color.Gray;
            attendanceBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(attendanceBtn, "attendanceBtn");
            attendanceBtn.ForeColor = SystemColors.ButtonHighlight;
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.UseVisualStyleBackColor = true;
            attendanceBtn.Click += attendanceBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.immigration;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(labelTime);
            panel3.Controls.Add(dateLabel);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(comboBox1);
            panel4.Name = "panel4";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.languages;
            resources.ApplyResources(pictureBox7, "pictureBox7");
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1") });
            comboBox1.Name = "comboBox1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.IndianRed;
            label2.Name = "label2";
            // 
            // labelTime
            // 
            resources.ApplyResources(labelTime, "labelTime");
            labelTime.Name = "labelTime";
            labelTime.Click += labelTime_Click;
            // 
            // dateLabel
            // 
            resources.ApplyResources(dateLabel, "dateLabel");
            dateLabel.Name = "dateLabel";
            dateLabel.Click += label2_Click;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.White;
            resources.ApplyResources(userControl11, "userControl11");
            userControl11.Name = "userControl11";
            // 
            // userControlReport1
            // 
            userControlReport1.BackColor = Color.White;
            resources.ApplyResources(userControlReport1, "userControlReport1");
            userControlReport1.Name = "userControlReport1";
            // 
            // TeacherForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(userControlReport1);
            Controls.Add(userControl11);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "TeacherForm";
            WindowState = FormWindowState.Maximized;
            Load += TeacherForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Label dateLabel;
        private Button attendanceBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button reportBtn;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        public controls.UserControlAttendance userControl11;
        private Label label2;
        public controls.UserControlReport userControlReport1;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox7;
    }
}