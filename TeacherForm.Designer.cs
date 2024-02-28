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
            MyLabell = new Label();
            qwert = new Label();
            panel4 = new Panel();
            chooseLanglabel = new Label();
            pictureBox7 = new PictureBox();
            LanguageComboBox = new ComboBox();
            welcomeLabel = new Label();
            labelTime = new Label();
            dateLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            SysLabel = new Label();
            pictureBox1 = new PictureBox();
            attendanceBtn = new Button();
            reportBtn = new Button();
            logoutBtn = new Button();
            panel1 = new Panel();
            ProfileButton = new Button();
            chooseFormType2 = new controls.ChooseFormType();
            userControlAttendance1 = new controls.UserControlAttendance();
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
            panel3.Controls.Add(MyLabell);
            panel3.Controls.Add(qwert);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(welcomeLabel);
            panel3.Controls.Add(labelTime);
            panel3.Controls.Add(dateLabel);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // MyLabell
            // 
            resources.ApplyResources(MyLabell, "MyLabell");
            MyLabell.Name = "MyLabell";
            // 
            // qwert
            // 
            resources.ApplyResources(qwert, "qwert");
            qwert.Name = "qwert";
            // 
            // panel4
            // 
            panel4.Controls.Add(chooseLanglabel);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(LanguageComboBox);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // chooseLanglabel
            // 
            resources.ApplyResources(chooseLanglabel, "chooseLanglabel");
            chooseLanglabel.Name = "chooseLanglabel";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.languages;
            resources.ApplyResources(pictureBox7, "pictureBox7");
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            // 
            // LanguageComboBox
            // 
            resources.ApplyResources(LanguageComboBox, "LanguageComboBox");
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Items.AddRange(new object[] { resources.GetString("LanguageComboBox.Items"), resources.GetString("LanguageComboBox.Items1") });
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(welcomeLabel, "welcomeLabel");
            welcomeLabel.ForeColor = Color.FromArgb(255, 64, 125);
            welcomeLabel.Name = "welcomeLabel";
            // 
            // labelTime
            // 
            resources.ApplyResources(labelTime, "labelTime");
            labelTime.ForeColor = Color.FromArgb(255, 64, 125);
            labelTime.Name = "labelTime";
            labelTime.Click += labelTime_Click;
            // 
            // dateLabel
            // 
            resources.ApplyResources(dateLabel, "dateLabel");
            dateLabel.ForeColor = Color.FromArgb(255, 64, 125);
            dateLabel.Name = "dateLabel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 37, 68);
            panel2.Controls.Add(SysLabel);
            panel2.Controls.Add(pictureBox1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // SysLabel
            // 
            resources.ApplyResources(SysLabel, "SysLabel");
            SysLabel.ForeColor = SystemColors.ButtonHighlight;
            SysLabel.Name = "SysLabel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.work_attendance_4;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // attendanceBtn
            // 
            attendanceBtn.BackColor = Color.FromArgb(31, 37, 68);
            resources.ApplyResources(attendanceBtn, "attendanceBtn");
            attendanceBtn.Cursor = Cursors.Hand;
            attendanceBtn.FlatAppearance.BorderColor = Color.DimGray;
            attendanceBtn.FlatAppearance.BorderSize = 2;
            attendanceBtn.ForeColor = Color.White;
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.UseVisualStyleBackColor = false;
            attendanceBtn.Click += attendanceBtn_Click;
            // 
            // reportBtn
            // 
            reportBtn.BackColor = Color.FromArgb(31, 37, 68);
            reportBtn.Cursor = Cursors.Hand;
            reportBtn.FlatAppearance.BorderColor = Color.DimGray;
            reportBtn.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(reportBtn, "reportBtn");
            reportBtn.ForeColor = Color.White;
            reportBtn.Name = "reportBtn";
            reportBtn.UseVisualStyleBackColor = false;
            reportBtn.Click += reportBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(31, 37, 68);
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.FlatAppearance.BorderColor = Color.DimGray;
            logoutBtn.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(logoutBtn, "logoutBtn");
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Name = "logoutBtn";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 37, 68);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ProfileButton);
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(reportBtn);
            panel1.Controls.Add(attendanceBtn);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.FromArgb(31, 37, 68);
            ProfileButton.Cursor = Cursors.Hand;
            ProfileButton.FlatAppearance.BorderColor = Color.DimGray;
            ProfileButton.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(ProfileButton, "ProfileButton");
            ProfileButton.ForeColor = Color.White;
            ProfileButton.Name = "ProfileButton";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click_1;
            // 
            // chooseFormType2
            // 
            resources.ApplyResources(chooseFormType2, "chooseFormType2");
            chooseFormType2.Name = "chooseFormType2";
            // 
            // userControlAttendance1
            // 
            userControlAttendance1.BackColor = Color.White;
            resources.ApplyResources(userControlAttendance1, "userControlAttendance1");
            userControlAttendance1.Name = "userControlAttendance1";
            // 
            // TeacherForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(userControlAttendance1);
            Controls.Add(chooseFormType2);
            Name = "TeacherForm";
            WindowState = FormWindowState.Maximized;
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
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
        private Label welcomeLabel;
        public controls.UserControlReport userControlReport1;
        private ComboBox LanguageComboBox;
        private Label chooseLanglabel;
        private Panel panel4;
        private PictureBox pictureBox7;
        private Panel panel2;
        private Label SysLabel;
        private PictureBox pictureBox1;
        private Button attendanceBtn;
        private Button reportBtn;
        private Button logoutBtn;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private controls.ChooseFormType chooseFormType1;
        private controls.FilterByClass filterByClass1;
        private Button ProfileButton;
        private controls.StudentReport stusentReport1;
        private Label qwert;
        private Label MyLabell;
        private controls.ChooseFormType chooseFormType2;
        private controls.UserControlAttendance userControlAttendance1;
    }
}