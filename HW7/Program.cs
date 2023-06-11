namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student alexStudent = new Student
            { 
                Name = "Alex",
                LastName = "Belov",
                Age = 33,
                City = "Lviv"
            };
            Student yanaStudent = new Student
            { 
                Name = "Yana",
                LastName = "Stus",
                Age = 28,
                City = "Kiev"
            };
            Student olesStudent = new Student
            { 
                Name = "Oles",
                LastName = "Kvitka",
                Age = 37,
                City = "Lutsk" 
            };
            Student annaStudent = new Student
            { 
                Name = "Anna",
                LastName = "Kotova",
                Age = 23,
                City = "Rovno"
            };
           // Course EnglishIntermediaCourse = new Course("English_Intermedia", "Carol", 6);
            Course course1 = new Course
            { 
                CourseName = "German_Intermedia",
                TeacherName = "Arnold",
                CourseDuration = 5,
                Students =  new List<Student>
                { 
                    alexStudent,
                    yanaStudent,
                    annaStudent,
                }
                
            };
            List<Student> existingStudents = course1.Students;
            for (int i = 0; i < existingStudents.Count; i++) {
                Console.WriteLine($"Index = {i}, student = {existingStudents[i].Name}");
            }
            int index1 = course1.Find(olesStudent);
            Console.WriteLine($"Index Olex is {index1}");
            int index2 = course1.Find(yanaStudent);
            Console.WriteLine($"Index Yana is {index2}");

            course1.AddStudent(yanaStudent);
            course1.AddStudent(olesStudent);
            Console.WriteLine("-----------------------");

            course1.RemoveStudent(yanaStudent);
            course1.RemoveStudent(yanaStudent);
            Console.WriteLine("-----------------------");
            course1.RemoveStudent(olesStudent);
            course1.RemoveStudent(alexStudent);
            course1.RemoveStudent(annaStudent);
            course1.RemoveStudent(annaStudent);
        }
    }
}