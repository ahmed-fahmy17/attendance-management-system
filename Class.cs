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
        public static bool isValidClassId(string _ClassId)
        {
            return _ClassId.Length > 3;
        }
        public static bool IsUniqueClassId(string _classId)
        {
            List<string> classIds = XmlManipulation.GetAllClassIds();
            foreach (string classId in classIds)
            {
                if (classId == _classId)
                    return false;
            }
            return true;
        }

        public static bool isValidClassName(string _ClassName)
        {
            return _ClassName.Length > 3;
        }
        public static bool IsExistUserInClass(string userId,string classId)
        {
            List <User> students = XmlManipulation.GetClassStudents(classId);
            foreach (User student in students)
            {
                if(student.Id == userId) return true;
            }
            return false;
        }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassTeacherId { get; set; }
        public List<string> StudentsId { get; set; }
    }
}
