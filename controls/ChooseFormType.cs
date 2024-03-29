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
        private StudentReport studentReport;
        public ChooseFormType()
        {
            InitializeComponent();
            SetLabelText(typeofreportlabel.Text);

            userControlReport = new UserControlReport();
            byClass = new FilterByClass();
            studentReport = new StudentReport();
           
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
        public void SetLabelText(string text)
        {
            typeofreportlabel.Text = text;
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

