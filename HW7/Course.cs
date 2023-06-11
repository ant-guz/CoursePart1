using System;
using System.Collections.Generic;

namespace HW7
{
    public class Course
    {
        // properties
        private string courseName;
        private string teacherName;
        private int courseDuration;

        private List<Student> students = new List<Student>();

        // getters and setters
        public string CourseName { get { return this.courseName; } set { this.courseName = value; } }
        public string TeacherName { get { return this.teacherName; } set { this.teacherName = value; } }
        public int CourseDuration { get { return this.courseDuration; } set { this.courseDuration = value; } }

        public List<Student> Students { get { return this.students; } set { this.students = value; } }

        //constructors
        public Course()
        {
            this.CourseName = "Unknown";
            this.TeacherName = "Unknown";
        }

        public Course(string courseName) : this()
        {
            this.CourseName = courseName;
        }

        public Course(string courseName, string teacherName) : this(courseName)
        {
            this.TeacherName = teacherName;
        }

        public Course(string courseName, string teacherName, int courseDuration) : this(courseName, teacherName)
        {
            this.CourseDuration = courseDuration;
        }
        // utils methods
        public void AddStudent(Student student)
        {
            if (CheckStudentAtList(student))
            {
                Console.WriteLine($"The student {student.Name} already exist in the list.");
            }
            else
            {
                Console.WriteLine($"Successfully add student {student.Name} to the list.");
                students.Add(student);
            }
        }

        public void RemoveStudent(Student student)
        {

            if (CheckStudentAtList(student))
            {
                Console.WriteLine($"Successfully remove student {student.Name} from the list.");
                Students.Remove(student);
            }
            else
            {
                Console.WriteLine($"The student {student.Name} not on the list of students. Nothing to remove.");
            }

        }

        public bool CheckStudentAtList(Student student)
        {
            bool result = false;

            if (Students.Count > 0)
            {
                if (Students.Contains(student))
                {
                    Console.WriteLine($"The student {student.Name} is at the list.");
                    result = true;
                }
                else
                {
                    Console.WriteLine($"The student {student.Name} is not at the list.");
                    result = false;
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Метод вертає порядковий номер студента у списку.
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Порядковий номер студента, або '-1', якщо студента немає у списку</returns>
        public int GerStudentNumber(Student student)
        {
            int result = -1;
            int index = GetStudentIndex(student);
            if (index >= 0)
            {
                result = index++;
                Console.WriteLine($"There are {result} students enrolled in the course. ");
            }
            Console.WriteLine($"There aren't students enrolled in the course. ");
            return result;
        }
        /// <summary>
        /// Метод вертає індекс номер студента у списку.
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Порядковий індекс студента, або '-1', якщо студента немає у списку</returns>

        public int GetStudentIndex(Student student)
        {
            int index = Students.IndexOf(student);
            if (index >= 0)
            {
                Console.WriteLine($"Index of the student {student.Name} is {index}.");
            }
            Console.WriteLine($"The student {student.Name} is not found.");
            return Students.IndexOf(student);
        }

        public int GetStudentsCount()
        {
            int result = Students.Count;
            if (result != 0)
            {
                Console.WriteLine($"There are {result} students enrolled in the course. ");
            }
            else
            {
                Console.WriteLine($"There aren't students enrolled in the course. ");
            }
            return result;
        }


        public void Print()

        {
            string result = $"Course name = {this.CourseName}, teacher name = {this.TeacherName}," +
                $" course duration = {this.CourseDuration}. ";
            List<Student> existedStudents = this.Students;
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
    }
}
