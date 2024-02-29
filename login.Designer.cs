namespace attendance_management_system
{
  public  partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label1 = new Label();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            labelErrorLogin = new Label();
            Arabic = new RadioButton();
            English = new RadioButton();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(64, 103, 158);
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(255, 64, 125);
            label1.Name = "label1";
            // 
            // EmailTextBox
            // 
            resources.ApplyResources(EmailTextBox, "EmailTextBox");
            EmailTextBox.Name = "EmailTextBox";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.Name = "PasswordTextBox";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.FromArgb(27, 60, 115);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(labelErrorLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(EmailTextBox);
            panel2.Controls.Add(PasswordTextBox);
            panel2.Name = "panel2";
            // 
            // labelErrorLogin
            // 
            resources.ApplyResources(labelErrorLogin, "labelErrorLogin");
            labelErrorLogin.ForeColor = Color.Red;
            labelErrorLogin.Name = "labelErrorLogin";
            labelErrorLogin.Text = "Wrong credentials";
            // 
            // Arabic
            // 
            resources.ApplyResources(Arabic, "Arabic");
            Arabic.Name = "Arabic";
            Arabic.Text = "Arabic";
            Arabic.UseVisualStyleBackColor = true;
            Arabic.CheckedChanged += Arabic_CheckedChanged;
            // 
            // English
            // 
            resources.ApplyResources(English, "English");
            English.Checked = true;
            English.Name = "English";
            English.Text = "English";
            English.UseVisualStyleBackColor = true;
            English.CheckedChanged += English_CheckedChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Text = "Language";
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(English);
            Controls.Add(Arabic);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "login";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Button button1;
        private Panel panel2;
        private Label labelErrorLogin;
        private RadioButton Arabic;
        private RadioButton English;
        private Label label2;
    }
}