using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Student : UniversityStaff
    {
        private string _city = "Unknown";
        public string City { get => _city;  set => _city = value; }

        public Student() 
        {
            this.Name = "Unknown";
            this.Age = 0;
        }

        public Student(string _name) : this()
        {
            Name = _name;

        }
        public Student(string _name, string _lastName, int _age, string _city):this(_name)
        {
            LastName = _lastName;
            Age = _age;
            City = _city;

        }
        public Student(string _name, string _lastName, int _age, string _city,
            List<Course> _coursesAttended) : this(_name, _lastName, _age, _city)
        {
            this.Courses = _coursesAttended;

        }

        public override void DescribeYourself()
        {
            Console.WriteLine($"Hello, I'm Student class. My name is {Name}," +
                $" last name {LastName}, my age is {Age}. I live in {City}.");
        }

        public void Print()

        {
            string result = $"Student name = {this.Name}, last name = {this.LastName}, " +
                $"age = {this.Age}. ";
            if (GetCoursesCount() > 0)
            {
                result += "\n" + "List of the attended courses: ";
                foreach (Course course in Courses)
                {
                    result += "\n" +course.CourseName;
                }
            }

                Console.WriteLine(result);
            Console.WriteLine(  );

        }
    }
}