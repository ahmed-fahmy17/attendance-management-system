namespace attendance_management_system.controls
{
    partial class editUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editUserProfile));
            userNameTxt = new TextBox();
            userPasswordTxt = new TextBox();
            label1 = new Label();
            editBtn = new Button();
            canceBtn = new Button();
            nameErrorLabel = new Label();
            passwordErrorLabel = new Label();
            SuspendLayout();
            // 
            // userNameTxt
            // 
            resources.ApplyResources(userNameTxt, "userNameTxt");
            userNameTxt.Name = "userNameTxt";
            // 
            // userPasswordTxt
            // 
            resources.ApplyResources(userPasswordTxt, "userPasswordTxt");
            userPasswordTxt.Name = "userPasswordTxt";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(71, 79, 122);
            label1.Name = "label1";
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(71, 79, 122);
            editBtn.Cursor = Cursors.Hand;
            resources.ApplyResources(editBtn, "editBtn");
            editBtn.ForeColor = Color.White;
            editBtn.Name = "editBtn";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click_1;
            // 
            // canceBtn
            // 
            canceBtn.BackColor = Color.FromArgb(71, 79, 122);
            canceBtn.Cursor = Cursors.Hand;
            resources.ApplyResources(canceBtn, "canceBtn");
            canceBtn.ForeColor = Color.White;
            canceBtn.Name = "canceBtn";
            canceBtn.UseVisualStyleBackColor = false;
            // 
            // nameErrorLabel
            // 
            resources.ApplyResources(nameErrorLabel, "nameErrorLabel");
            nameErrorLabel.Name = "nameErrorLabel";
            // 
            // passwordErrorLabel
            // 
            resources.ApplyResources(passwordErrorLabel, "passwordErrorLabel");
            passwordErrorLabel.Name = "passwordErrorLabel";
            // 
            // editUserProfile
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 208, 236);
            Controls.Add(passwordErrorLabel);
            Controls.Add(nameErrorLabel);
            Controls.Add(canceBtn);
            Controls.Add(editBtn);
            Controls.Add(label1);
            Controls.Add(userPasswordTxt);
            Controls.Add(userNameTxt);
            Name = "editUserProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTxt;
        private TextBox userPasswordTxt;
        private Label label1;
        private Button editBtn;
        private Button canceBtn;
        private Label nameErrorLabel;
        private Label passwordErrorLabel;
    }
}
