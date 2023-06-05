using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Course[] CoursesAttended { get; set; }
        public Student() 
        {
            this.Name = "Unknown";
            this.Age = 0;
        }

        public Student(string name) : this()
        {
            this.Name = name;

        }
        public Student(string name, string lastName, int age, string city):this(name)
        {
            this.LastName = lastName;
            this.Age = age;
            this.City = city;

        }
        public Student(string name, string lastName, int age, string city, Course[] coursesAttended) : this(name, lastName, age, city)
        {
            this.CoursesAttended = coursesAttended;

        }

        public void Print()

        {
            string result = $"Student name = {this.Name}, last name = {this.LastName}, age = {this.Age}. ";
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