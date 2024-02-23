namespace attendance_management_system.controls
{
    partial class ChooseFormType
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
            dateRangeBtn = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dateRangeBtn
            // 
            dateRangeBtn.BackColor = Color.FromArgb(255, 208, 236);
            dateRangeBtn.Cursor = Cursors.Hand;
            dateRangeBtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateRangeBtn.ForeColor = Color.FromArgb(31, 37, 68);
            dateRangeBtn.Location = new Point(75, 131);
            dateRangeBtn.Name = "dateRangeBtn";
            dateRangeBtn.Size = new Size(332, 200);
            dateRangeBtn.TabIndex = 5;
            dateRangeBtn.Text = "Date Range";
            dateRangeBtn.UseVisualStyleBackColor = false;
            dateRangeBtn.Click += dateRangeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(129, 104, 157);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(527, 62);
            label1.TabIndex = 6;
            label1.Text = "Choose the type of your report";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 208, 236);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(31, 37, 68);
            button1.Location = new Point(687, 131);
            button1.Name = "button1";
            button1.Size = new Size(344, 203);
            button1.TabIndex = 7;
            button1.Text = "Class Name";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 208, 236);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(31, 37, 68);
            button2.Location = new Point(383, 403);
            button2.Name = "button2";
            button2.Size = new Size(367, 203);
            button2.TabIndex = 8;
            button2.Text = "Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ChooseFormType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dateRangeBtn);
            Name = "ChooseFormType";
            Size = new Size(1354, 748);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dateRangeBtn;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
