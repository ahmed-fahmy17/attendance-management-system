using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace attendance_management_system
{
    public class AttendanceData
    {
        public void loadUsersXmlFiles()
        {
            string relativePath = "..\\xml\\users.xml";
            string absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(absolutePath);

        }
    }
}
