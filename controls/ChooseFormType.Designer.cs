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
            typeofreportlabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dateRangeBtn
            // 
            dateRangeBtn.AutoEllipsis = true;
            dateRangeBtn.BackColor = Color.FromArgb(230, 185, 222);
            dateRangeBtn.Cursor = Cursors.Hand;
            dateRangeBtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateRangeBtn.ForeColor = Color.FromArgb(31, 37, 68);
            dateRangeBtn.Location = new Point(75, 131);
            dateRangeBtn.Name = "dateRangeBtn";
            dateRangeBtn.Size = new Size(400, 245);
            dateRangeBtn.TabIndex = 5;
            dateRangeBtn.Text = "Date Range";
            dateRangeBtn.UseVisualStyleBackColor = true;
            dateRangeBtn.Click += dateRangeBtn_Click;
            // 
            // typeofreportlabel
            // 
            typeofreportlabel.AutoSize = true;
            typeofreportlabel.Font = new Font("Simplified Arabic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeofreportlabel.ForeColor = Color.FromArgb(255, 64, 125);
            typeofreportlabel.Location = new Point(20, 14);
            typeofreportlabel.Name = "typeofreportlabel";
            typeofreportlabel.Size = new Size(565, 62);
            typeofreportlabel.TabIndex = 6;
            typeofreportlabel.Text = "Choose The Type Of Your Report";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 185, 222);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(31, 37, 68);
            button1.Location = new Point(889, 131);
            button1.Name = "button1";
            button1.Size = new Size(390, 245);
            button1.TabIndex = 7;
            button1.Text = "Class Name";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.FromArgb(230, 185, 222);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(31, 37, 68);
            button2.Location = new Point(479, 439);
            button2.Name = "button2";
            button2.Size = new Size(403, 245);
            button2.TabIndex = 8;
            button2.Text = "Student";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChooseFormType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(typeofreportlabel);
            Controls.Add(dateRangeBtn);
            Name = "ChooseFormType";
            Size = new Size(1485, 748);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dateRangeBtn;
        private Label typeofreportlabel;
        private Button button1;
        private Button button2;
    }
}
