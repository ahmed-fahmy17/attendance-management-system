using System;
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
    public partial class UserControlClasses : UserControl
    {
        List<Class> ClassData = new List<Class>();
        public UserControlClasses()
        {
            InitializeComponent();
            ClassData = XmlManipulation.GetClassData();
            LoadData();
        }
        public void LoadData()
        {
            foreach (Class _class in ClassData)
            {
                ClassesTable.Rows.Add(_class.ClassId,_class.ClassName,_class.ClassTeacherId);
            }
        }
    }
}
