namespace attendance_management_system.controls
{
    partial class FilterByClass
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
            classComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(31, 37, 68);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 46);
            label1.TabIndex = 0;
            label1.Text = "Class Report";
            // 
            // classComboBox
            // 
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(29, 83);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(213, 28);
            classComboBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_save_641;
            pictureBox1.Location = new Point(320, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 67);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FilterByClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(classComboBox);
            Controls.Add(label1);
            Name = "FilterByClass";
            Size = new Size(603, 307);
            Load += FilterByClass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox classComboBox;
        private PictureBox pictureBox1;
    }
}
