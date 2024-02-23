using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace attendance_management_system
{
    internal class XmlManipulation
    {
        private static string UserDataPath = "D:\\iti\\projects\\c# and XML project\\attendance-management-system\\xml\\users.xml";
        private static string ClassDataPath = "D:\\iti\\projects\\c# and XML project\\attendance-management-system\\xml\\classes.xml";
        public static List<User> GetUserData()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlNodeList nodes = xmlDoc.SelectNodes("//user");
            List<User> Data = new List<User>();
            foreach (XmlNode node in nodes)
            {
                User user = new User();
                user.Id = node.SelectSingleNode("id").InnerText;
                user.Name = node.SelectSingleNode("name").InnerText;
                user.Email = node.SelectSingleNode("email").InnerText;
                user.Age = int.Parse(node.SelectSingleNode("age").InnerText);
                user.Phone = node.SelectSingleNode("phone").InnerText;
                user.Password = node.SelectSingleNode("password").InnerText;
                user.Role = node.SelectSingleNode("role").InnerText;
                Data.Add(user);
            }
            return Data;
        }
        public static List<Class> GetClassData()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlNodeList nodes = xmlDoc.SelectNodes("//class");
            List<Class> Data = new List<Class>();
            foreach (XmlNode node in nodes)
            {
                Class _class = new Class();
                _class.ClassId = node.SelectSingleNode("classId").InnerText;
                _class.ClassName = node.SelectSingleNode("className").InnerText;
                _class.ClassTeacherId = node.SelectSingleNode("teacherId").InnerText;
                XmlNodeList studentIdNodes = xmlDoc.SelectNodes("//class/students");
                foreach (XmlNode studentIdNode in studentIdNodes)
                {
                    _class.StudentsId.Add(studentIdNode.SelectSingleNode("studentId").InnerText);
                }
                Data.Add(_class);
            }
            return Data;
        }
        public static Admin GetAdminData()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlNodeList nodes = xmlDoc.SelectNodes("//admin");
            Admin admin = new Admin();
            admin.Email = nodes[0].SelectSingleNode("email").InnerText;
            admin.Password = nodes[0].SelectSingleNode("password").InnerText;
            return admin;
        }
        public static void UpdateAdmin(Admin admin)
        {
            if (admin == null) { return; }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlNodeList nodes = xmlDoc.SelectNodes("//admin");
            nodes[0].SelectSingleNode("email").InnerText = admin.Email;
            nodes[0].SelectSingleNode("password").InnerText = admin.Password;
            xmlDoc.Save(UserDataPath);
        }
        public static bool AddUser(User user)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlElement xmlUser = xmlDoc.CreateElement("user");
            xmlDoc.DocumentElement.AppendChild(xmlUser);

            XmlElement xmlId = xmlDoc.CreateElement("id");
            xmlId.InnerText = user.Id;
            xmlUser.AppendChild(xmlId);

            XmlElement xmlName = xmlDoc.CreateElement("name");
            xmlName.InnerText = user.Name;
            xmlUser.AppendChild(xmlName);

            XmlElement xmlEmail = xmlDoc.CreateElement("email");
            xmlEmail.InnerText = user.Email;
            xmlUser.AppendChild(xmlEmail);

            XmlElement xmlAge = xmlDoc.CreateElement("age");
            xmlAge.InnerText = user.Age.ToString();
            xmlUser.AppendChild(xmlAge);

            XmlElement xmlPhone = xmlDoc.CreateElement("phone");
            xmlPhone.InnerText = user.Phone;
            xmlUser.AppendChild(xmlPhone);

            XmlElement xmlPassword = xmlDoc.CreateElement("password");
            xmlPassword.InnerText = user.Password;
            xmlUser.AppendChild(xmlPassword);

            XmlElement xmlRole = xmlDoc.CreateElement("role");
            xmlRole.InnerText = user.Role;
            xmlUser.AppendChild(xmlRole);

            xmlDoc.Save(UserDataPath);
            return true;
        }
        public static bool RemoveUser(string userId)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlNode userNode = xmlDoc.SelectSingleNode(String.Format("/users/user[id='{0}']",userId));
            if(userNode != null )
            {
                userNode.ParentNode.RemoveChild(userNode);
                xmlDoc.Save(UserDataPath);
            }
            return true;
        }
    }
}
