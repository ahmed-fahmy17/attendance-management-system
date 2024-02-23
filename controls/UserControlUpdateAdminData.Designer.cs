namespace attendance_management_system.controls
{
    partial class UserControlUpdateAdminData
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAdminEmail = new TextBox();
            textBoxAdminOldPassword = new TextBox();
            textBoxAdminNewPassword = new TextBox();
            UpdateAdminBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 129);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 195);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "old password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 268);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "new password";
            // 
            // textBoxAdminEmail
            // 
            textBoxAdminEmail.Location = new Point(418, 122);
            textBoxAdminEmail.Name = "textBoxAdminEmail";
            textBoxAdminEmail.Size = new Size(188, 27);
            textBoxAdminEmail.TabIndex = 3;
            // 
            // textBoxAdminOldPassword
            // 
            textBoxAdminOldPassword.Enabled = false;
            textBoxAdminOldPassword.Location = new Point(418, 195);
            textBoxAdminOldPassword.Name = "textBoxAdminOldPassword";
            textBoxAdminOldPassword.ReadOnly = true;
            textBoxAdminOldPassword.Size = new Size(188, 27);
            textBoxAdminOldPassword.TabIndex = 4;
            // 
            // textBoxAdminNewPassword
            // 
            textBoxAdminNewPassword.Location = new Point(418, 268);
            textBoxAdminNewPassword.Name = "textBoxAdminNewPassword";
            textBoxAdminNewPassword.Size = new Size(188, 27);
            textBoxAdminNewPassword.TabIndex = 5;
            // 
            // UpdateAdminBTN
            // 
            UpdateAdminBTN.Location = new Point(765, 195);
            UpdateAdminBTN.Name = "UpdateAdminBTN";
            UpdateAdminBTN.Size = new Size(94, 29);
            UpdateAdminBTN.TabIndex = 6;
            UpdateAdminBTN.Text = "Update";
            UpdateAdminBTN.UseVisualStyleBackColor = true;
            UpdateAdminBTN.Click += UpdateAdminBTN_Click;
            // 
            // UserControlUpdateAdminData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(UpdateAdminBTN);
            Controls.Add(textBoxAdminNewPassword);
            Controls.Add(textBoxAdminOldPassword);
            Controls.Add(textBoxAdminEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(0, 41);
            Name = "UserControlUpdateAdminData";
            Size = new Size(1009, 487);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAdminEmail;
        private TextBox textBoxAdminOldPassword;
        private TextBox textBoxAdminNewPassword;
        private Button UpdateAdminBTN;
    }
}
