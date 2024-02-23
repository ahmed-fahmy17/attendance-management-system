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
            attendanceTable = new DataGridView();
            AttendanceLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            teacherClasses = new ComboBox();
            savebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)attendanceTable).BeginInit();
            SuspendLayout();
            // 
            // attendanceTable
            // 
            attendanceTable.AllowUserToAddRows = false;
            attendanceTable.AllowUserToDeleteRows = false;
            attendanceTable.AllowUserToOrderColumns = true;
            attendanceTable.AllowUserToResizeColumns = false;
            attendanceTable.AllowUserToResizeRows = false;
            attendanceTable.BackgroundColor = Color.White;
            attendanceTable.BorderStyle = BorderStyle.None;
            attendanceTable.CausesValidation = false;
            attendanceTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            attendanceTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            attendanceTable.ColumnHeadersHeight = 29;
            attendanceTable.EditMode = DataGridViewEditMode.EditOnEnter;
            attendanceTable.EnableHeadersVisualStyles = false;
            attendanceTable.Location = new Point(26, 171);
            attendanceTable.Margin = new Padding(4);
            attendanceTable.Name = "attendanceTable";
            attendanceTable.RowHeadersWidth = 51;
            attendanceTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            attendanceTable.ShowCellToolTips = false;
            attendanceTable.ShowEditingIcon = false;
            attendanceTable.Size = new Size(1217, 738);
            attendanceTable.TabIndex = 6;
            // 
            // AttendanceLabel
            // 
            AttendanceLabel.AutoSize = true;
            AttendanceLabel.Dock = DockStyle.Left;
            AttendanceLabel.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttendanceLabel.ForeColor = Color.FromArgb(31, 37, 68);
            AttendanceLabel.Location = new Point(0, 0);
            AttendanceLabel.Name = "AttendanceLabel";
            AttendanceLabel.Size = new Size(205, 31);
            AttendanceLabel.TabIndex = 1;
            AttendanceLabel.Text = "Mark Attendance";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(71, 79, 122);
            label1.Location = new Point(396, 41);
            label1.Name = "label1";
            label1.Size = new Size(196, 46);
            label1.TabIndex = 2;
            label1.Text = "Class name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(71, 79, 122);
            label2.Location = new Point(83, 41);
            label2.Name = "label2";
            label2.Size = new Size(95, 46);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // teacherClasses
            // 
            teacherClasses.FormattingEnabled = true;
            teacherClasses.Location = new Point(412, 107);
            teacherClasses.Name = "teacherClasses";
            teacherClasses.Size = new Size(226, 28);
            teacherClasses.TabIndex = 5;
            teacherClasses.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // savebtn
            // 
            savebtn.BackColor = Color.FromArgb(71, 79, 122);
            savebtn.Cursor = Cursors.Hand;
            savebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savebtn.ForeColor = Color.White;
            savebtn.Location = new Point(793, 82);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(124, 53);
            savebtn.TabIndex = 7;
            savebtn.Text = "save";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += savebtn_Click;
            // 
            // UserControlAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(savebtn);
            Controls.Add(attendanceTable);
            Controls.Add(teacherClasses);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AttendanceLabel);
            Name = "UserControlAttendance";
            Size = new Size(1342, 684);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)attendanceTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AttendanceLabel;
        private Label label1;
        private Label label2;
        private ComboBox teacherClasses;
        private DataGridView attendanceTable;
        private Button savebtn;
    }
}
