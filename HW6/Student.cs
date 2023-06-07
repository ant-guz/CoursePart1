using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Student : Human
    {
        private string _city = "Unknown";
        public string City { get => _city;  set => _city = value; } 

        public Course[] CoursesAttended { get; set; }
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
            Course[] coursesAttended) : this(_name, _lastName, _age, _city)
        {
            this.CoursesAttended = coursesAttended;

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
            Course[] existedCourse = this.CoursesAttended;
            if (existedCourse != null)
            {
                result += "\n" + "List of the attended courses: ";
                foreach (Course course in existedCourse)
                {
                    result += "\n" +course.CourseName;
                }
            }

                Console.WriteLine(result);
            Console.WriteLine(  );

        }

        public void AddCourse(Course newCourse)
        {
            Course[] existedCourse = this.CoursesAttended;
            if (existedCourse != null)
            {
                Course[] newCourses = new Course[existedCourse.Length + 1];
                for (int i = 0; i < existedCourse.Length; i++)
                {
                    newCourses[i] = existedCourse[i];
                }
                newCourses[newCourses.Length - 1] = newCourse;
                this.CoursesAttended = newCourses;
            }
            else
            {
                Course[] newCourses = new Course[] { newCourse };
                this.CoursesAttended = newCourses;
            }
        }
        public void RemoveCourse(Course course)
        {
            Course[] existedCourse = this.CoursesAttended;
            if (existedCourse != null)
            {
                Course[] newCourses = new Course[existedCourse.Length - 1];
                for (int i = 0; i < existedCourse.Length; i++)
                {
                    for (int j = 0; j < newCourses.Length; j++) {
                        if (!existedCourse[i].Equals(course)) {
                            newCourses[j] = existedCourse[i];
                        }
                    
                    }
                }
                this.CoursesAttended = newCourses;
            }
            else {
                Console.WriteLine($"Course with name {course.CourseName} didn't find.");
            }
        }
    }
}