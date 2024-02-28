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
            panel1 = new Panel();
            label1 = new Label();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 103, 158);
            panel1.Location = new Point(926, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 720);
            panel1.TabIndex = 0;
            
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 64, 125);
            label1.Location = new Point(55, 34);
            label1.Name = "label1";
            label1.Size = new Size(281, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome Again!";
          
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(73, 119);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Email";
            EmailTextBox.Size = new Size(355, 27);
            EmailTextBox.TabIndex = 2;
          
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PasswordTextBox.Location = new Point(73, 180);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(355, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(27, 60, 115);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(168, 235);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(EmailTextBox);
            panel2.Controls.Add(PasswordTextBox);
            panel2.Location = new Point(221, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 364);
            panel2.TabIndex = 5;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1402, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Button button1;
        private Panel panel2;
    }
}