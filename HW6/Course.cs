using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }

        public Student[] Students { get; set; }

        public Course() {
            this.CourseName = "Unknown";
            this.TeacherName = "Unknown";
        }

        public Course(string courseName) : this() {
            
            this.CourseName = courseName;
        }

        public Course(string courseName, string teacherName) : this(courseName) {
            this.TeacherName = teacherName;
        }

        public Course(string courseName, string teacherName, int courseDuration) : this(courseName, teacherName)
        {
            this.CourseDuration = courseDuration;
        }

        public void Print()

        {
            string result = $"Course name = {this.CourseName}, teacher name = {this.TeacherName}," +
                $" course duration = {this.CourseDuration}. ";
            Student[] existedStudents = this.Students;
            if (existedStudents != null)
            {
                result += "\n" + "List of students: ";
                foreach (Student student in existedStudents)
                {

                    result += "\n" + student.Name;
                }
                    
            }
            Console.WriteLine(result);
            Console.WriteLine();

        }

        public void AddStudent(Student newStudent)
        {
            Student[] existedStudents = this.Students;
            if (existedStudents != null)
            {
                Student[] newStudents = new Student[existedStudents.Length + 1];
                for (int i = 0; i < existedStudents.Length; i++)
                {
                    newStudents[i] = existedStudents[i];
                }
                newStudents[newStudents.Length - 1] = newStudent;
                this.Students = newStudents;
            }
            else
            {
                Student[] newCourses = new Student[] { newStudent };
                this.Students = newCourses;
            }
        }
    }
}
