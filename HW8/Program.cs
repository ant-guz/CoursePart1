namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------> Home work 8 <-------");
            List<Student> AllStudents = new List<Student>();
            List<Course> AllCourses = new List<Course>();
            List<Teacher> AllTeachers = new List<Teacher>();

            Course GermanLanguage = new Course
            {
                CourseName = "German for beginners",
                TeacherName = "Olaf",
                CourseDuration = 6,
            };
            Course EnglishLanguage = new Course
            {
                CourseName = "English for beginners",
                TeacherName = "Bill",
                CourseDuration = 5,
            };
            Course FrenchLanguage = new Course
            {
                CourseName = "French for beginners",
                TeacherName = "Lui",
                CourseDuration = 9,
            };
            Student Alex = new Student
            {
                Name = "Alex",
                LastName = "Belov",
                Age = 33,
                City = "Lviv",
                Courses = {
                EnglishLanguage, FrenchLanguage
                }
            };
            Student Yana = new Student
            {
                Name = "Yana",
                LastName = "Stus",
                Age = 28,
                City = "Kiev",
                Courses = { GermanLanguage, EnglishLanguage }

            };
            Student Anna = new Student
            {
                Name = "Anna",
                LastName = "Kotova",
                Age = 23,
                City = "Rivno",
                //Courses = { FrenchLanguage, GermanLanguage }
            };

            
            Teacher EnglishTeacher = new Teacher
            {
                Name = "Bill",
                LastName = "Snow",
                Age = 54,
                Gender = 1,
                Courses = { EnglishLanguage, GermanLanguage },

            };

            Teacher GermanTeacher = new Teacher
            {
                Name = "Olaf",
                LastName = "Scholz",
                Age = 65,
                Gender= 1,
                //Courses = { GermanLanguage, EnglishLanguage },

            };

            Teacher FrenchTeacher = new Teacher
            {
                Name = "Emma ",
                LastName = "Moreau",
                Age = 45,
                Gender = 0,
                Courses = { FrenchLanguage, EnglishLanguage },

            };
            GermanLanguage.Students.Add(Anna);
            GermanLanguage.Students.Add(Yana);

            FrenchLanguage.Students.Add(Alex);
            FrenchLanguage.Students.Add(Anna);

            //EnglishLanguage.Students.Add(Alex);
            //EnglishLanguage.Students.Add(Yana);


            AllStudents.Add(Alex);
            AllStudents.Add(Yana);
            AllStudents.Add(Anna);

            AllCourses.Add(EnglishLanguage);
            AllCourses.Add(GermanLanguage);
            AllCourses.Add(FrenchLanguage);

            AllTeachers.Add(FrenchTeacher);
            AllTeachers.Add(GermanTeacher);
            AllTeachers.Add(EnglishTeacher);

            //print
            Console.WriteLine("-------- Students ---------");
            foreach (var student in AllStudents)
            {
                student.Print();
            }
            Console.WriteLine("-------- Teachers ---------");
            foreach (var teacher in AllTeachers) 
            {
                teacher.Print();
            }
            Console.WriteLine("-------- Courses ---------");
            foreach (var course in AllCourses)
            { 
                course.Print();
            }
        }
    }
}