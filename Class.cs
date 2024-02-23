using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance_management_system
{
    internal class Class
    {
        public Class() {
            StudentsId = new List<string>();
        }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassTeacherId { get; set; }
        public List<string> StudentsId { get; set; }
    }
}
