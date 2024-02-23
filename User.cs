using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance_management_system
{
    internal class User
    {
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public List<int> Classes { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return String.Format("id={0} , name={1} , Email={2} , age={3}",Id,Name,Email,Age);
        }

    }
}
