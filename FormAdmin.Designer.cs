namespace attendance_management_system
{
    partial class FormAdmin
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
            BTNUpdateAdminData = new Button();
            BTNReport = new Button();
            BTNStudents = new Button();
            BTNClasses = new Button();
            panel3 = new Panel();
            panelSide = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            labelTime = new Label();
            panelBack = new Panel();
            BTNLogout = new Button();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            userControlUsers1 = new controls.UserControlUsers();
            userControlUpdateAdminData1 = new controls.UserControlUpdateAdminData();
            userControlClasses1 = new controls.UserControlClasses();
            buttonBackUp = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(buttonBackUp);
            panel1.Controls.Add(BTNUpdateAdminData);
            panel1.Controls.Add(BTNReport);
            panel1.Controls.Add(BTNStudents);
            panel1.Controls.Add(BTNClasses);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 587);
            panel1.TabIndex = 0;
            // 
            // BTNUpdateAdminData
            // 
            BTNUpdateAdminData.Dock = DockStyle.Top;
            BTNUpdateAdminData.FlatAppearance.BorderSize = 0;
            BTNUpdateAdminData.FlatStyle = FlatStyle.Flat;
            BTNUpdateAdminData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNUpdateAdminData.ForeColor = Color.White;
            BTNUpdateAdminData.Location = new Point(8, 293);
            BTNUpdateAdminData.Name = "BTNUpdateAdminData";
            BTNUpdateAdminData.Size = new Size(248, 47);
            BTNUpdateAdminData.TabIndex = 4;
            BTNUpdateAdminData.Text = "update your data";
            BTNUpdateAdminData.TextAlign = ContentAlignment.MiddleLeft;
            BTNUpdateAdminData.UseVisualStyleBackColor = true;
            BTNUpdateAdminData.Click += BTNUpdateAdminData_Click;
            // 
            // BTNReport
            // 
            BTNReport.Dock = DockStyle.Top;
            BTNReport.FlatAppearance.BorderSize = 0;
            BTNReport.FlatStyle = FlatStyle.Flat;
            BTNReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNReport.ForeColor = Color.White;
            BTNReport.Location = new Point(8, 246);
            BTNReport.Name = "BTNReport";
            BTNReport.Size = new Size(248, 47);
            BTNReport.TabIndex = 3;
            BTNReport.Text = "Report";
            BTNReport.TextAlign = ContentAlignment.MiddleLeft;
            BTNReport.UseVisualStyleBackColor = true;
            BTNReport.Click += BTNReport_Click;
            // 
            // BTNStudents
            // 
            BTNStudents.Dock = DockStyle.Top;
            BTNStudents.FlatAppearance.BorderSize = 0;
            BTNStudents.FlatStyle = FlatStyle.Flat;
            BTNStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNStudents.ForeColor = Color.White;
            BTNStudents.Location = new Point(8, 199);
            BTNStudents.Name = "BTNStudents";
            BTNStudents.Size = new Size(248, 47);
            BTNStudents.TabIndex = 2;
            BTNStudents.Text = "Students";
            BTNStudents.TextAlign = ContentAlignment.MiddleLeft;
            BTNStudents.UseVisualStyleBackColor = true;
            BTNStudents.Click += BTNStudents_Click;
            // 
            // BTNClasses
            // 
            BTNClasses.Dock = DockStyle.Top;
            BTNClasses.FlatAppearance.BorderSize = 0;
            BTNClasses.FlatStyle = FlatStyle.Flat;
            BTNClasses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BTNClasses.ForeColor = Color.White;
            BTNClasses.Location = new Point(8, 152);
            BTNClasses.Name = "BTNClasses";
            BTNClasses.Size = new Size(248, 47);
            BTNClasses.TabIndex = 1;
            BTNClasses.Text = "Classes";
            BTNClasses.TextAlign = ContentAlignment.MiddleLeft;
            BTNClasses.UseVisualStyleBackColor = true;
            BTNClasses.Click += BTNClasses_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panelSide);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 435);
            panel3.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(8, 47);
            panelSide.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 152);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 1;
            label1.Text = "attendance management system";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.man2;
            pictureBox1.Location = new Point(81, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(129, 62);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 4;
            label4.Text = "admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(25, 62);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Welcome : ";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(25, 19);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(26, 20);
            labelTime.TabIndex = 2;
            labelTime.Text = "{?}";
            // 
            // panelBack
            // 
            panelBack.BackColor = SystemColors.MenuHighlight;
            panelBack.Controls.Add(BTNLogout);
            panelBack.Controls.Add(label4);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(label3);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(256, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(940, 91);
            panelBack.TabIndex = 1;
            // 
            // BTNLogout
            // 
            BTNLogout.Anchor = AnchorStyles.Right;
            BTNLogout.Location = new Point(834, 28);
            BTNLogout.Name = "BTNLogout";
            BTNLogout.Size = new Size(94, 29);
            BTNLogout.TabIndex = 5;
            BTNLogout.Text = "logout";
            BTNLogout.UseVisualStyleBackColor = true;
            BTNLogout.Click += BTNLogout_Click;
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // userControlUsers1
            // 
            userControlUsers1.BackColor = Color.White;
            userControlUsers1.Location = new Point(256, 95);
            userControlUsers1.Name = "userControlUsers1";
            userControlUsers1.Size = new Size(940, 492);
            userControlUsers1.TabIndex = 2;
            // 
            // userControlUpdateAdminData1
            // 
            userControlUpdateAdminData1.BackColor = Color.White;
            userControlUpdateAdminData1.Location = new Point(256, 93);
            userControlUpdateAdminData1.Name = "userControlUpdateAdminData1";
            userControlUpdateAdminData1.Size = new Size(940, 492);
            userControlUpdateAdminData1.TabIndex = 3;
            // 
            // userControlClasses1
            // 
            userControlClasses1.BackColor = Color.White;
            userControlClasses1.Location = new Point(256, 96);
            userControlClasses1.Name = "userControlClasses1";
            userControlClasses1.Size = new Size(940, 494);
            userControlClasses1.TabIndex = 4;
            // 
            // buttonBackUp
            // 
            buttonBackUp.BackColor = Color.Green;
            buttonBackUp.ForeColor = Color.White;
            buttonBackUp.Location = new Point(80, 388);
            buttonBackUp.Name = "buttonBackUp";
            buttonBackUp.Size = new Size(94, 29);
            buttonBackUp.TabIndex = 5;
            buttonBackUp.Text = "Backup data";
            buttonBackUp.UseVisualStyleBackColor = false;
            buttonBackUp.Click += buttonBackUp_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 587);
            Controls.Add(userControlClasses1);
            Controls.Add(userControlUpdateAdminData1);
            Controls.Add(userControlUsers1);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance management system";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label labelTime;
        private Panel panelBack;
        private Panel panel3;
        private Panel panelSide;
        private Button BTNDashboard;
        private Button BTNReport;
        private Button BTNStudents;
        private Button BTNClasses;
        private Button BTNUpdateAdminData;
        private Button BTNLogout;
        private System.Windows.Forms.Timer timerDateAndTime;
        private controls.UserControlUsers userControlUsers1;
        private controls.UserControlUpdateAdminData userControlUpdateAdminData1;
        private controls.UserControlClasses userControlClasses1;
        private Button buttonBackUp;
    }
}