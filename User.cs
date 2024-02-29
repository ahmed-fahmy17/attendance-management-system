using attendance_management_system.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace attendance_management_system
{
    internal class User
    {
        public User(string _Id="",string _Name="",string _Email="",int _Age=0,string _Phone="",string _Password="",string _Role="") {
            Id = _Id;
            Name = _Name;
            Email = _Email;
            Age = _Age;
            Phone = _Phone;
            Password = _Password;
            Role = _Role;
        }
        public static bool IsUniqueId(string _Id)
        {
            List<string> Users = XmlManipulation.GetAllUserIds();
            foreach (string userId in Users)
            {
                if (userId == _Id)
                    return false;
            }
            return true;
        }
        public static bool IsValidId(string _Id)
        {
            if (_Id.Length != 14)
                return false;
            foreach (char ch in _Id)
            {
                if(!(ch >= '0' && ch <= '9'))
                    return false;
            }
            return true;
        }

        public static bool isValidName(string  _Name)
        {
            if (_Name.Length <3)
                return false;
            foreach (char ch in _Name)
            {
                if (ch >= '0' && ch <= '9')
                    return false;
            }
            return true;
        }
        public static bool isUniqueEmail(string _Email)
        {
            List<string> Users = XmlManipulation.GetAllUserEmails();
            foreach (string userEmail in Users)
            {
                if (userEmail == _Email)
                    return false;
            }
            return true;
        }
        public static bool isValidEmail(string _Email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(_Email, emailPattern);
        }
        public static bool isValidAge(int _Age)
        {
            return _Age > 2;
        }
        public static bool isValidPhone(string _Phone)
        {
            if (_Phone.Length != 11)
                return false;
            if(!_Phone.StartsWith("010") && !_Phone.StartsWith("011") && !_Phone.StartsWith("012") && !_Phone.StartsWith("015"))
                return false;
            return true;
        }
        public static bool isValidPassword(string _Password)
        {
            if(_Password.Length <8)
                return false;
            string specialCharacterPattern = @"[!@#$%^&*(),.?\:{ }|<>]";
            string numberPattern = @"\d";
            string letterPattern = @"[a-zA-Z]";

            return Regex.IsMatch(_Password, specialCharacterPattern) &&
               Regex.IsMatch(_Password, numberPattern) &&
               Regex.IsMatch(_Password, letterPattern);
        }
        public static bool isValidRole(string _Role)
        {
            if(_Role!="student" &&  _Role!="teacher")
                return false;
            return true;
        }
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public override string ToString()
        {
            return $"id={Id} , name={Name} , Email={Email} , age={Age}";
        }

    }
}
