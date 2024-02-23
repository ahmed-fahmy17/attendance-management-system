﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance_management_system.controls
{
    public partial class ChooseFormType : UserControl
    {
        private UserControlReport userControlReport;
        private FilterByClass byClass;
        private StusentReport studentReport;
        public ChooseFormType()
        {
            InitializeComponent();
            userControlReport = new UserControlReport();
            byClass = new FilterByClass();
            studentReport = new StusentReport();
        }


        private void dateRangeBtn_Click(object sender, EventArgs e)
        {
            Form reportForm = new Form();


            reportForm.Text = "Attendance Report";


            reportForm.ClientSize = userControlReport.Size;


            reportForm.Controls.Add(userControlReport);

            // Show the form
            reportForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form reportForm = new Form();

            reportForm.ClientSize = byClass.Size;
            reportForm.Controls.Add(byClass);
            reportForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            Form reportForm = new Form();

            reportForm.ClientSize = studentReport.Size;
            reportForm.Text = "Student Report";
            reportForm.Controls.Add(studentReport);
            reportForm.ShowDialog();
        }

    }
}

