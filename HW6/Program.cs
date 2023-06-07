using System.Diagnostics;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Create not empty instances of class Student --");
            Student Alex = new Student("Alex", "Belov", 33, "Lviv");
            Student Yana = new Student("Yana", "Stus", 28, "Kiev");
            Console.WriteLine("Print all students");
            Alex.DescribeYourself();
            Yana.DescribeYourself();

            Console.WriteLine("-- Create not empty instances of class Teacher --");
            string[] physicsTeacherSubjects = {"math", "physics" };
            string[] laborTeacherSubjects = { "work safety", "physical education" };
            Teacher PhysicsTeacher = new Teacher("Anna", "Krishova", 55, physicsTeacherSubjects);
            Teacher LaborTeacher = new Teacher("Leonid", "Bezpaluy", 62, laborTeacherSubjects);
            PhysicsTeacher.DescribeYourself();
            LaborTeacher.DescribeYourself();


        }
    }
}