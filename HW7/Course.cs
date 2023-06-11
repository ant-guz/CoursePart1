using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }

        //public Student[] Students { get; set; }

        private List<Student> students;

        public List<Student> Students { get { return this.students; } set { this.students = value; } }

        public void AddStudent(Student student) {
           
            if (Students != null && Students.Count != 0)
            {
                if (Students.Contains(student)) 
                {
                    Console.WriteLine($"The student {student.Name} already exist in the list.");
                }
                else
                {
                    Console.WriteLine($"Successfully add student {student.Name} to the list.");
                    students.Add(student);
                }
            }
            else 
            {
                Console.WriteLine($"Successfully add student {student.Name} to the list.");
                Students.Add(student);
            }
        }

        public void RemoveStudent(Student student) {
            if (Students != null && Students.Count != 0)
            {
                if (Students.Contains(student))
                {
                    Console.WriteLine($"Successfully remove student {student.Name} from the list.");
                    Students.Remove(student);
                }
                else 
                {
                    Console.WriteLine($"The student {student.Name} not on the list of students. Nothing to remove.");
                }
                
            } 
            else
            {
                Console.WriteLine($"Can't remove student {student.Name}. The list of students is empty.");
            }
        }

        public int GetNumberElements(Student student) {
            int result = -1;
            if (Students != null && Students.Count != 0)
            {
                if (Students.Contains(student))
                {
                   
                }
                Students.Add(student);
                Console.WriteLine($"The student {student.Name} not on the list of students. Nothing to return.");
            }
            else
            {
                Console.WriteLine($"Can't find student {student.Name}. The list of students is empty.");
            }

            return result;
        }

        public int Find(Student student)
        {
            return Students.IndexOf(student);
            
        }

        public Course() 
        {
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

        //public void AddStudent(Student newStudent)
        //{
        //    Student[] existedStudents = this.Students;
        //    if (existedStudents != null)
        //    {
        //        Student[] newStudents = new Student[existedStudents.Length + 1];
        //        for (int i = 0; i < existedStudents.Length; i++)
        //        {
        //            newStudents[i] = existedStudents[i];
        //        }
        //        newStudents[newStudents.Length - 1] = newStudent;
        //        this.Students = newStudents;
        //    }
        //    else
        //    {
        //        Student[] newCourses = new Student[] { newStudent };
        //        this.Students = newCourses;
        //    }
        //}
    }
}
