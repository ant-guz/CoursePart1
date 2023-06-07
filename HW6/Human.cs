using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Human
    {
        private string _name;
        private string _lastName;
        private int _age;

        public string Name { get => _name; set => _name = value; } 

        public string LastName { get => _lastName; set => _lastName = value; } 
        public int Age { get => _age;  set => _age = value; } 

        public virtual void DescribeYourself()
        {
            Console.WriteLine($"Hello, I'm Human class. My name is {Name}, " +
                $"last name {LastName}, my age is {Age}");
        }
    }
}
