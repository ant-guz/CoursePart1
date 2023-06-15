using System.Linq;

namespace HW.ADD
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("------> Additional HomeWork <-----");
            Console.WriteLine();
            Console.WriteLine("1. implement IComparable interface");
            Console.WriteLine();
             
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
            Course FrenchAdditionalLanguage = new Course
            {
                CourseName = "French for beginners",
                TeacherName = "Luiza",
                CourseDuration = 11,
            };

            Course EnglishAdditionalLanguage = new Course
            {
                CourseName = "English for beginners",
                TeacherName = "Bill",
                CourseDuration = 10,
            };
            List<Course> AllCourses = new List<Course> {GermanLanguage, 
                EnglishLanguage,FrenchAdditionalLanguage,FrenchLanguage,EnglishAdditionalLanguage };
            Console.WriteLine("Courses before sorting:");
            Console.WriteLine("Courses name : course duration");
            AllCourses.ForEach(x => Console.WriteLine($"{x.CourseName} : {x.CourseDuration}"));
            AllCourses.Sort((x, y) => x.CompareTo(y));
            Console.WriteLine();
            Console.WriteLine("Courses after sorting:");
            Console.WriteLine("Courses name : course duration");
            AllCourses.ForEach(x => Console.WriteLine($"{x.CourseName} : {x.CourseDuration}"));

            Console.WriteLine();
            Console.WriteLine("2. Write a program in C# Sharp to display the list of items in the array according" +
                " to the length of the string then by name in ascending order. ");
            Console.WriteLine();
            List<string> unsortedCities = new List<string>
            { "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"};

            Console.WriteLine("List before sort:");
            unsortedCities.ForEach(el => Console.WriteLine(el));

            Console.WriteLine();
            List<string> sortedCities = SortCitiesByLengthThenByName(unsortedCities);
            Console.WriteLine("List after sort:");
            sortedCities.ForEach(el => Console.WriteLine(el));

            Console.WriteLine();
            Console.WriteLine("3. Write a program in C# Sharp to arrange the distinct elements in the list in " +
                "ascending order.");
            Console.WriteLine();

            List<string> unsortedSweets = new List<string>
            { "Biscuit", "Honey", "Butter", "Brade", "Honey", "Biscuit"};
            Console.WriteLine("List before sort:");
            unsortedSweets.ForEach(el => Console.WriteLine(el));
            List<string> sortedSweets = SortUniqueSweetsByName(unsortedSweets);
            Console.WriteLine();
            Console.WriteLine("List after sort:");
            sortedSweets.ForEach(el => Console.WriteLine(el));

            Console.WriteLine();
            Console.WriteLine("4. Write a program in C# Sharp to find the strings for a specific minimum length. ");
            Console.WriteLine();

            List<string> words = new List<string>
            { "Welcome", "to", "https://classroom.google"};
            Console.WriteLine("Words before sort:");
            words.ForEach(el => Console.WriteLine(el));
            Console.WriteLine();
            List<string> wordsMinLength = FindStringsForSpecificMinLength(words, 10);
            Console.WriteLine("Words after sort:");
            wordsMinLength.ForEach(el => Console.WriteLine(el));



        }




        private static List<string> SortCitiesByLengthThenByName(List<string> unsorted)
        {
            return unsorted.OrderBy(x => x.Length).ThenBy(y => y).ToList();
        }

        private static List<string> SortUniqueSweetsByName(List<string> unsorted)
        {
            return unsorted.Distinct().OrderBy(x => x).ToList();
        }

        private static List<string> FindStringsForSpecificMinLength(List<string> list, int minLength)
        {
            return list.Where(x => x.Length >= minLength).OrderBy(x => x).ToList();
        }
    }


    class Course : IComparable
    {
        private string courseName;
        private string teacherName;
        private int courseDuration;

        public string CourseName { get { return this.courseName; } set { this.courseName = value; } }
        public string TeacherName { get { return this.teacherName; } set { this.teacherName = value; } }
        public int CourseDuration { get { return this.courseDuration; } set { this.courseDuration = value; } }

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

        public int CompareTo(object obj)
        {
            Course c = obj as Course;

            if (c != null)
            {
                int result = this.CourseName.CompareTo(c.CourseName);
                if (result == 0)
                {
                    result = this.CourseDuration.CompareTo(c.CourseDuration);
                }
                return result;
            }
            else
                throw new Exception("It is impossible to compare two objects");

        }
    }
}