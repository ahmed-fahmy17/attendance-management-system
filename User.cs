using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public override string ToString()
        {
            return String.Format("id={0} , name={1} , Email={2} , age={3}",Id,Name,Email,Age);
        }

    }
}
