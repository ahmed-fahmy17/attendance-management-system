namespace attendance_management_system.controls
{
    partial class StusentReport
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
            studentsComboBox = new ComboBox();
            studentReportPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)studentReportPic).BeginInit();
            SuspendLayout();
            // 
            // studentsComboBox
            // 
            studentsComboBox.FormattingEnabled = true;
            studentsComboBox.Location = new Point(21, 69);
            studentsComboBox.Name = "studentsComboBox";
            studentsComboBox.Size = new Size(227, 28);
            studentsComboBox.TabIndex = 0;
            // 
            // studentReportPic
            // 
            studentReportPic.Cursor = Cursors.Hand;
            studentReportPic.Image = Properties.Resources.icons8_save_642;
            studentReportPic.Location = new Point(271, 46);
            studentReportPic.Name = "studentReportPic";
            studentReportPic.Size = new Size(73, 68);
            studentReportPic.TabIndex = 1;
            studentReportPic.TabStop = false;
            studentReportPic.Click += studentReportPic_Click;
            // 
            // StusentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(studentReportPic);
            Controls.Add(studentsComboBox);
            Name = "StusentReport";
            Size = new Size(446, 295);
            ((System.ComponentModel.ISupportInitialize)studentReportPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox studentsComboBox;
        private PictureBox studentReportPic;
    }
}
