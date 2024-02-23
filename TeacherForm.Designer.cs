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
            splitContainer1 = new SplitContainer();
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
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            attendanceBtn = new Button();
            reportBtn = new Button();
            logoutBtn = new Button();
            panel1 = new Panel();
            ProfileButton = new Button();
            chooseFormType1 = new controls.ChooseFormType();
            filterByClass1 = new controls.FilterByClass();
            stusentReport1 = new controls.StusentReport();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(labelTime);
            panel3.Controls.Add(dateLabel);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(comboBox1);
            resources.ApplyResources(panel4, "panel4");
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
            label2.ForeColor = Color.FromArgb(71, 79, 122);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 37, 68);
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
            // attendanceBtn
            // 
            resources.ApplyResources(attendanceBtn, "attendanceBtn");
            attendanceBtn.Cursor = Cursors.Hand;
            attendanceBtn.FlatAppearance.BorderColor = Color.DimGray;
            attendanceBtn.FlatAppearance.BorderSize = 2;
            attendanceBtn.ForeColor = SystemColors.ButtonHighlight;
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.UseVisualStyleBackColor = true;
            attendanceBtn.Click += attendanceBtn_Click;
            // 
            // reportBtn
            // 
            reportBtn.Cursor = Cursors.Hand;
            reportBtn.FlatAppearance.BorderColor = Color.DimGray;
            reportBtn.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(reportBtn, "reportBtn");
            reportBtn.ForeColor = SystemColors.ButtonHighlight;
            reportBtn.Name = "reportBtn";
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.FlatAppearance.BorderColor = Color.DimGray;
            logoutBtn.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(logoutBtn, "logoutBtn");
            logoutBtn.ForeColor = SystemColors.ButtonHighlight;
            logoutBtn.Name = "logoutBtn";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 37, 68);
            panel1.Controls.Add(ProfileButton);
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(reportBtn);
            panel1.Controls.Add(attendanceBtn);
            panel1.Controls.Add(panel2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // ProfileButton
            // 
            ProfileButton.Cursor = Cursors.Hand;
            ProfileButton.FlatAppearance.BorderColor = Color.DimGray;
            ProfileButton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(ProfileButton, "ProfileButton");
            ProfileButton.ForeColor = SystemColors.ButtonHighlight;
            ProfileButton.Name = "ProfileButton";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click_1;
            // 
            // chooseFormType1
            // 
            resources.ApplyResources(chooseFormType1, "chooseFormType1");
            chooseFormType1.Name = "chooseFormType1";
            // 
            // filterByClass1
            // 
            resources.ApplyResources(filterByClass1, "filterByClass1");
            filterByClass1.Name = "filterByClass1";
            filterByClass1.Load += filterByClass1_Load;
            // 
            // stusentReport1
            // 
            resources.ApplyResources(stusentReport1, "stusentReport1");
            stusentReport1.Name = "stusentReport1";
            // 
            // TeacherForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(stusentReport1);
            Controls.Add(filterByClass1);
            Controls.Add(chooseFormType1);
            Controls.Add(userControlReport1);
            Controls.Add(userControl11);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "TeacherForm";
            WindowState = FormWindowState.Maximized;
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label dateLabel;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        public controls.UserControlAttendance userControl11;
        private Label label2;
        public controls.UserControlReport userControlReport1;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox7;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button attendanceBtn;
        private Button reportBtn;
        private Button logoutBtn;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private controls.ChooseFormType chooseFormType1;
        private controls.FilterByClass filterByClass1;
        private Button ProfileButton;
        private controls.StusentReport stusentReport1;
    }
}