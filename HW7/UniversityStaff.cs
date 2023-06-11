using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public abstract class UniversityStaff
    {
        private string name;
        private string lastName;
        private int age;
        private List<Course> courses = new List<Course>();

        public string Name { get => name; set => name = value; }

        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public List<Course> Courses { get { return this.courses; } set { this.courses = value; } }

        public virtual void DescribeYourself()
        {
            Console.WriteLine($"Hello, I'm Human class. My name is {Name}, " +
                $"last name {LastName}, my age is {Age}");
        }

        public void AddCourse(Course course)
        {
            if (CheckCourseAtList(course))
            {
                Console.WriteLine($"The course {course.CourseName} already exist in the list.");
            }
            else
            {
                Console.WriteLine($"Successfully added course {course.CourseName} to the list.");
                courses.Add(course);
            }
        }

        public void RemoveCourse(Course course) {
            if (CheckCourseAtList(course))
            {
                Console.WriteLine($"Successfully removed course {course.CourseName} from the list.");
                courses.Remove(course);
            }
            else
            {
                Console.WriteLine($"Successfully added course {course.CourseName} to the list.");
                Console.WriteLine($"The course {course.CourseName} is not in the list. Nothing to remove");
            }

        }

        public bool CheckCourseAtList(Course course)
        {
            return (courses.Contains(course) ? true : false);
        }
        public int GetCoursesCount()
        {
            int result = Courses.Count;
            if (result != 0)
            {
                Console.WriteLine($"There are {result} courses. ");
            }
            else
            {
                Console.WriteLine($"There aren't courses. ");
            }
            return result;
        }

        public int GetStudentsCount()
        {
            return Courses.Count;
        }
    }
}
