using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    if(studentIdNode.SelectSingleNode("studentId") != null)
                        _class.StudentsId.Add(studentIdNode.SelectSingleNode("studentId").InnerText);
                }
                Data.Add(_class);
            }
            return Data;
        }
        public static List<User> GetClassStudents(string classId)
        {
            List<User> Data = new List<User> ();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlNodeList studentIdNodes = xmlDoc.SelectNodes($"/classes/class[classId='{classId}']/students/studentId");
            foreach (XmlNode studentIdNode in studentIdNodes)
            {
                User user = new User();
                string StId = studentIdNode.InnerText;
                XmlDocument xmlDoc2 = new XmlDocument();
                xmlDoc2.Load(UserDataPath);
                XmlNode userNode = xmlDoc2.SelectSingleNode($"/users/user[id='{StId}']");
                if (userNode != null)
                {
                    user.Id = userNode.SelectSingleNode("id").InnerText;
                    user.Name = userNode.SelectSingleNode("name").InnerText;
                    user.Email = userNode.SelectSingleNode("email").InnerText;
                    user.Age = int.Parse(userNode.SelectSingleNode("age").InnerText);
                    user.Phone = userNode.SelectSingleNode("phone").InnerText;
                    user.Password = userNode.SelectSingleNode("password").InnerText;
                    user.Role = userNode.SelectSingleNode("role").InnerText;
                    Data.Add(user);
                }
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
            XmlNode userNode = xmlDoc.SelectSingleNode($"/users/user[id='{userId}']");
            if(userNode != null )
            {
                userNode.ParentNode.RemoveChild(userNode);
                xmlDoc.Save(UserDataPath);
            }
            return true;
        }

        public static bool AddClass(Class _class)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlElement xmlClass = xmlDoc.CreateElement("class");
            xmlDoc.DocumentElement.AppendChild(xmlClass);

            XmlElement xmlCLassId = xmlDoc.CreateElement("classId");
            xmlCLassId.InnerText = _class.ClassId;
            xmlClass.AppendChild(xmlCLassId);

            XmlElement xmlCLassName = xmlDoc.CreateElement("className");
            xmlCLassName.InnerText = _class.ClassName;
            xmlClass.AppendChild(xmlCLassName);

            XmlElement xmlCLassTeacherId = xmlDoc.CreateElement("teacherId");
            xmlCLassTeacherId.InnerText = _class.ClassTeacherId;
            xmlClass.AppendChild(xmlCLassTeacherId);

            XmlElement xmlStudents = xmlDoc.CreateElement("students");
            xmlClass.AppendChild(xmlStudents);

            xmlDoc.Save(ClassDataPath);
            return true;
        }
        public static bool UpdateClass(string oldClassId,Class _class)
        {
            if (_class == null) { return false; }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlNode classNode = xmlDoc.SelectSingleNode($"/classes/class[classId='{oldClassId}']");
            classNode.ChildNodes[0].InnerText= _class.ClassId;
            classNode.ChildNodes[1].InnerText= _class.ClassName;
            classNode.ChildNodes[2].InnerText= _class.ClassTeacherId;
            xmlDoc.Save(ClassDataPath);
            return true;
        }
        public static bool RemoveClass(string classId)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlNode classNode = xmlDoc.SelectSingleNode($"/classes/class[classId='{classId}']");
            if (classNode != null)
            {
                classNode.ParentNode.RemoveChild(classNode);
                xmlDoc.Save(ClassDataPath);
            }
            return true;
        }
        public static User GetSingleUserByID(string userId)
        {
            User user = new User();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlNode UserNode = xmlDoc.SelectSingleNode($"/users/user[id='{userId}']");
            user.Id = UserNode.SelectSingleNode("id").InnerText;
            user.Name = UserNode.SelectSingleNode("name").InnerText;
            user.Email = UserNode.SelectSingleNode("email").InnerText;
            user.Age = int.Parse(UserNode.SelectSingleNode("age").InnerText);
            user.Phone = UserNode.SelectSingleNode("phone").InnerText;
            user.Password = UserNode.SelectSingleNode("password").InnerText;
            user.Role = UserNode.SelectSingleNode("role").InnerText;
            return user;
        }

        public static void AddStudentToClass(string studentId,string classId)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlNode classStudentsNode = xmlDoc.SelectSingleNode($"/classes/class[classId='{classId}']/students");

            XmlElement xmlStudentId = xmlDoc.CreateElement("studentId");
            xmlStudentId.InnerText = studentId;
            classStudentsNode.AppendChild(xmlStudentId);
            xmlDoc.Save(ClassDataPath);
        }

        public static void RemoveStudentFromClass(string studentId, string classId)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlNode classStudentsNode = xmlDoc.SelectSingleNode($"/classes/class[classId='{classId}']/students/studentId[text()='{studentId}']");
            if (classStudentsNode != null)
            {
                classStudentsNode.ParentNode.RemoveChild(classStudentsNode);
                xmlDoc.Save(ClassDataPath);
            }
        }
        public static List<string> GetAllUserIds()
        {
            List<string> users = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlNodeList idNodes = xmlDoc.SelectNodes("//id");
            foreach (XmlNode idNode in idNodes)
            {
                users.Add(idNode.InnerText);
            }
            return users;
        }
        public static List<string> GetAllUserEmails()
        {
            List<string> usersEmail = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(UserDataPath);
            XmlNodeList emailNodes = xmlDoc.SelectNodes("//email");
            foreach (XmlNode emailNode in emailNodes)
            {
                usersEmail.Add(emailNode.InnerText);
            }
            return usersEmail;
        }
        public static List<string> GetAllClassIds()
        {
            List<string> ClassIds = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ClassDataPath);
            XmlNodeList classIdNodes = xmlDoc.SelectNodes("//classId");
            foreach (XmlNode classIdNode in classIdNodes)
            {
                ClassIds.Add(classIdNode.InnerText);
            }
            return ClassIds;
        }
    }
}
