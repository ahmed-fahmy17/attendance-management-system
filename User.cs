﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public static bool IsValidId(string _Id)
        {
            if (_Id.Length != 14)
                return false;
            foreach (char ch in _Id)
            {
                if(!(ch >= '0' && ch <= '9'))
                    return false;
            }
            List<string> Users = XmlManipulation.GetAllUserIds();
            foreach (string userId in Users)
            {
                if (userId == _Id)
                    return false;
            }
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
