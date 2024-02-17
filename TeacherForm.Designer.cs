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
            expandedBanel = new Panel();
            panel6 = new Panel();
            closeExpandedPanelBtn = new Button();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            labelTime = new Label();
            pictureBox2 = new PictureBox();
            expandPanelBtn = new PictureBox();
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
            expandedBanel.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expandPanelBtn).BeginInit();
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
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 626);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.report;
            pictureBox5.Location = new Point(25, 255);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // reportBtn
            // 
            reportBtn.Cursor = Cursors.Hand;
            reportBtn.FlatAppearance.BorderColor = Color.Gray;
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.ForeColor = SystemColors.ButtonHighlight;
            reportBtn.Location = new Point(25, 248);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(179, 36);
            reportBtn.TabIndex = 4;
            reportBtn.Text = "Report";
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.attendant_list;
            pictureBox4.Location = new Point(25, 200);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // attendanceBtn
            // 
            attendanceBtn.Cursor = Cursors.Hand;
            attendanceBtn.FlatAppearance.BorderColor = Color.Gray;
            attendanceBtn.FlatAppearance.BorderSize = 0;
            attendanceBtn.FlatStyle = FlatStyle.Flat;
            attendanceBtn.ForeColor = SystemColors.ButtonHighlight;
            attendanceBtn.Location = new Point(25, 200);
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.Size = new Size(192, 36);
            attendanceBtn.TabIndex = 2;
            attendanceBtn.Text = "Attendance";
            attendanceBtn.UseVisualStyleBackColor = true;
            attendanceBtn.Click += attendanceBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 176);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 112);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 1;
            label1.Text = "Attendance System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.immigration;
            pictureBox1.Location = new Point(73, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(expandedBanel);
            panel3.Controls.Add(labelTime);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(expandPanelBtn);
            panel3.Controls.Add(dateLabel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(280, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1049, 169);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(585, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 135);
            panel4.TabIndex = 8;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.languages;
            pictureBox7.Location = new Point(201, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(195, 22);
            label3.TabIndex = 7;
            label3.Text = "choose the language";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Arabic", "English" });
            comboBox1.Location = new Point(12, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 30);
            comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 5;
            label2.Text = "Welcome :";
            // 
            // expandedBanel
            // 
            expandedBanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            expandedBanel.BackColor = Color.RosyBrown;
            expandedBanel.BorderStyle = BorderStyle.FixedSingle;
            expandedBanel.Controls.Add(panel6);
            expandedBanel.Controls.Add(pictureBox3);
            expandedBanel.Controls.Add(button1);
            expandedBanel.Location = new Point(879, 65);
            expandedBanel.Name = "expandedBanel";
            expandedBanel.Size = new Size(167, 93);
            expandedBanel.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(closeExpandedPanelBtn);
            panel6.Controls.Add(pictureBox6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(165, 47);
            panel6.TabIndex = 0;
            // 
            // closeExpandedPanelBtn
            // 
            closeExpandedPanelBtn.Cursor = Cursors.Hand;
            closeExpandedPanelBtn.FlatAppearance.BorderSize = 0;
            closeExpandedPanelBtn.FlatStyle = FlatStyle.Flat;
            closeExpandedPanelBtn.ForeColor = Color.WhiteSmoke;
            closeExpandedPanelBtn.Location = new Point(4, 4);
            closeExpandedPanelBtn.Name = "closeExpandedPanelBtn";
            closeExpandedPanelBtn.Size = new Size(152, 40);
            closeExpandedPanelBtn.TabIndex = 1;
            closeExpandedPanelBtn.Text = "close";
            closeExpandedPanelBtn.UseVisualStyleBackColor = true;
            closeExpandedPanelBtn.Click += closeExpandedPanelBtn_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.close;
            pictureBox6.Location = new Point(0, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.RosyBrown;
            pictureBox3.Image = Properties.Resources.logout;
            pictureBox3.Location = new Point(4, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(-1, 50);
            button1.Name = "button1";
            button1.Size = new Size(156, 39);
            button1.TabIndex = 0;
            button1.Text = "logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(275, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(73, 22);
            labelTime.TabIndex = 4;
            labelTime.Text = "{time}";
            labelTime.Click += labelTime_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.man;
            pictureBox2.Location = new Point(862, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // expandPanelBtn
            // 
            expandPanelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            expandPanelBtn.Cursor = Cursors.Hand;
            expandPanelBtn.Image = Properties.Resources.down;
            expandPanelBtn.Location = new Point(949, 44);
            expandPanelBtn.Name = "expandPanelBtn";
            expandPanelBtn.Size = new Size(24, 20);
            expandPanelBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            expandPanelBtn.TabIndex = 2;
            expandPanelBtn.TabStop = false;
            expandPanelBtn.Click += expandPanelBtn_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(3, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(72, 22);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "{date}";
            dateLabel.Click += label2_Click;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.Gainsboro;
            userControl11.Location = new Point(290, 173);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(1035, 486);
            userControl11.TabIndex = 2;
            // 
            // userControlReport1
            // 
            userControlReport1.BackColor = SystemColors.ControlLight;
            userControlReport1.Dock = DockStyle.Top;
            userControlReport1.Location = new Point(280, 169);
            userControlReport1.Margin = new Padding(4, 3, 4, 3);
            userControlReport1.Name = "userControlReport1";
            userControlReport1.Size = new Size(1049, 467);
            userControlReport1.TabIndex = 3;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 626);
            Controls.Add(userControlReport1);
            Controls.Add(userControl11);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Teacher";
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
            expandedBanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)expandPanelBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Label dateLabel;
        private PictureBox pictureBox2;
        private PictureBox expandPanelBtn;
        private Panel expandedBanel;
        private Panel panel6;
        private Button button1;
        private Button attendanceBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button reportBtn;
        private Button closeExpandedPanelBtn;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        public controls.UserControlAttendance userControl11;
        private Label label2;
        public controls.UserControlReport userControlReport1;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox7;
    }
}