using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Create empty instance of class Student --");
            Student emptyStudent = new Student();
            emptyStudent.Print();
            Console.WriteLine("-- Create empty instance of class Course --");
            Course emptyCourse = new Course();
            emptyCourse.Print();

            Console.WriteLine("-- Create not empty instances of class Student --");
            Student Alex = new Student("Alex", "Belov", 33, "Lviv");
            Student Yana = new Student("Yana", "Stus", 28, "Kiev");
            Student Viktor = new Student("Viktor", "Jook", 42, "Kiev");
            Student Anna = new Student("Anna", "Greem", 36, "Rovno");
            Console.WriteLine("Print all students");
            Alex.Print();
            Yana.Print();
            Viktor.Print();
            Anna.Print();

            Console.WriteLine("-- Create not empty instances of class Course --");
            Course GermanIntermediaCourse = new Course("German_Intermedia", "Arnold", 6);
            Course EnglishIntermediaCourse = new Course("English_Intermedia", "Carol", 6);
            Course EnglishUpperIntermediaCourse = new Course("English_Upper-Intermedia", "Jon", 5);

            Console.WriteLine("-- Print all courses --");
            GermanIntermediaCourse.Print();
            EnglishIntermediaCourse.Print();
            EnglishUpperIntermediaCourse.Print();

            Console.WriteLine("-- Add students to the courses --");
            GermanIntermediaCourse.AddStudent(Alex);
            GermanIntermediaCourse.AddStudent(Anna);
            EnglishIntermediaCourse.AddStudent(Viktor);
            EnglishIntermediaCourse.AddStudent(Yana);
            EnglishUpperIntermediaCourse.AddStudent(Alex);
            EnglishUpperIntermediaCourse.AddStudent(Anna);

            Console.WriteLine("-- Print all courses after adding students --");
            GermanIntermediaCourse.Print();
            EnglishIntermediaCourse.Print();
            EnglishUpperIntermediaCourse.Print();

            Anna.Print();
            Console.WriteLine("-- Add courses to the students --");
            Alex.AddCourse(EnglishUpperIntermediaCourse);
            Alex.AddCourse(GermanIntermediaCourse);
            Alex.Print();
            Console.WriteLine("-- EnglishUpperIntermediaCourse add to Anna --");
            Anna.AddCourse(EnglishUpperIntermediaCourse);
            Anna.Print();
            Console.WriteLine("-- GermanIntermediaCourse add to Anna --");
            Anna.AddCourse(GermanIntermediaCourse);
            Anna.Print();
            Console.WriteLine("-- EnglishUpperIntermediaCourse remove from Anna --");
            Anna.RemoveCourse(EnglishUpperIntermediaCourse);
            Anna.Print();



        }
    }
}