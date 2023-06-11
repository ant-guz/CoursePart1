using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW7
{
    public class Teacher : Human
    {
        private string[] subjects;

        private List<Student> students;

        private List<Course> courses;

        public List<Student> Students { get { return this.students; } set { this.students = value; } }  

        public string[] Subjects { get { return this.subjects; } set { this.subjects = value; } }


        public List<Course> Courses { get { return this.courses; } set { this.courses = value; } }

        public Teacher()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Teacher(string _name) : this()
        {
            Name = _name;

        }
        public Teacher(string _name, string _lastName, int _age, string[] _subjects) : this(_name)
        {
            LastName = _lastName;
            Age = _age;
            Subjects = _subjects;

        }

        public override void DescribeYourself()
        {
            string result = $"Hello, I'm Teacher class. My name is {Name}, " +
                $"last name {LastName}, my age is {Age}. I teach: ";
            foreach (var subject in Subjects)
            {
                result += " " + subject;
            }
            Console.WriteLine(result);
        }
    }


}
