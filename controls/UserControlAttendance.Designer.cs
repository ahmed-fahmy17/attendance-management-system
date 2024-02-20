namespace attendance_management_system.controls
{
    partial class UserControlAttendance
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
            dataGridView1 = new DataGridView();
            AttendanceLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            teacherClasses = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CausesValidation = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(26, 171);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(995, 440);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AttendanceLabel
            // 
            AttendanceLabel.AutoSize = true;
            AttendanceLabel.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttendanceLabel.ForeColor = Color.Brown;
            AttendanceLabel.Location = new Point(26, 10);
            AttendanceLabel.Name = "AttendanceLabel";
            AttendanceLabel.Size = new Size(205, 31);
            AttendanceLabel.TabIndex = 1;
            AttendanceLabel.Text = "Mark Attendance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(478, 58);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 2;
            label1.Text = "Class name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(26, 58);
            label2.Name = "label2";
            label2.Size = new Size(66, 31);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // teacherClasses
            // 
            teacherClasses.FormattingEnabled = true;
            teacherClasses.Location = new Point(478, 100);
            teacherClasses.Name = "teacherClasses";
            teacherClasses.Size = new Size(151, 28);
            teacherClasses.TabIndex = 5;
            teacherClasses.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // UserControlAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(teacherClasses);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AttendanceLabel);
            Name = "UserControlAttendance";
            Size = new Size(1092, 629);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AttendanceLabel;
        private Label label1;
        private Label label2;
        private ComboBox teacherClasses;
        private DataGridView dataGridView1;
    }
}
