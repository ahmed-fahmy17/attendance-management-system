using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance_management_system
{
    internal class Class
    {
        public Class(string _ClassId = "",string _ClassName = "",string _ClassTeacherId = "") {
            StudentsId = new List<string>();
            ClassId = _ClassId;
            ClassName = _ClassName;
            ClassTeacherId = _ClassTeacherId;
        }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassTeacherId { get; set; }
        public List<string> StudentsId { get; set; }
    }
}
