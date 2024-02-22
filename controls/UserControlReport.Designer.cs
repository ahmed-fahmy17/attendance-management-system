namespace attendance_management_system.controls
{
    partial class UserControlReport
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
            Class = new Label();
            StartDateComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            EndDateComboBox = new ComboBox();
            formatComboBox = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            searchtxt = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(41, 14);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 0;
            label1.Text = "Report:-";
            // 
            // Class
            // 
            Class.AutoSize = true;
            Class.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Class.ForeColor = Color.IndianRed;
            Class.Location = new Point(60, 83);
            Class.Name = "Class";
            Class.Size = new Size(99, 25);
            Class.TabIndex = 1;
            Class.Text = "Start Date";
            // 
            // StartDateComboBox
            // 
            StartDateComboBox.FormattingEnabled = true;
            StartDateComboBox.Location = new Point(41, 124);
            StartDateComboBox.Name = "StartDateComboBox";
            StartDateComboBox.Size = new Size(151, 28);
            StartDateComboBox.TabIndex = 5;
            StartDateComboBox.SelectedIndexChanged += StartDateComboBox_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_save_64;
            pictureBox1.Location = new Point(767, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 67);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(262, 83);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 9;
            label3.Text = "End Date";
            // 
            // EndDateComboBox
            // 
            EndDateComboBox.FormattingEnabled = true;
            EndDateComboBox.Location = new Point(262, 124);
            EndDateComboBox.Name = "EndDateComboBox";
            EndDateComboBox.Size = new Size(151, 28);
            EndDateComboBox.TabIndex = 10;
            // 
            // formatComboBox
            // 
            formatComboBox.FormattingEnabled = true;
            formatComboBox.Items.AddRange(new object[] { "Excel", "pdf" });
            formatComboBox.Location = new Point(474, 124);
            formatComboBox.Name = "formatComboBox";
            formatComboBox.Size = new Size(151, 28);
            formatComboBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(474, 80);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 12;
            label2.Text = "choose format";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 346);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // searchtxt
            // 
            searchtxt.Location = new Point(654, 121);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(185, 27);
            searchtxt.TabIndex = 14;
            searchtxt.TextChanged += searchtxt_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_search;
            pictureBox2.Location = new Point(819, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // UserControlReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox2);
            Controls.Add(searchtxt);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(formatComboBox);
            Controls.Add(EndDateComboBox);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(StartDateComboBox);
            Controls.Add(Class);
            Controls.Add(label1);
            Name = "UserControlReport";
            Size = new Size(874, 579);
            Load += UserControlReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Class;
        private ComboBox StartDateComboBox;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox EndDateComboBox;
        private ComboBox formatComboBox;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox searchtxt;
        private PictureBox pictureBox2;
    }
}
