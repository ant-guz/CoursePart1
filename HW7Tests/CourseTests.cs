using HW7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW7Test
{
    [TestClass]
    public class CourseTests
    {
        private Course germanIntermediaCourse;
        private Student alexStudent;
        private Student yanaStudent;

       [TestInitialize]
        public void CourseTestInitialize()
        {
            alexStudent = new Student
            {
                Name = "Alex",
                LastName = "Belov",
                Age = 33,
                City = "Lviv"
            };
            yanaStudent = new Student
            {
                Name = "Yana",
                LastName = "Stus",
                Age = 28,
                City = "Kiev"
            };
         
            germanIntermediaCourse = new Course
            {
                CourseName = "German_Intermedia",
                TeacherName = "Arnold",
                CourseDuration = 5,
            };
        }

        [TestMethod]
        public void Course_GetStudentsCount_WhenEmpty() 
        {
            int realStudentsCount = germanIntermediaCourse.Students.Count;
            int expectedStudentsCount = 0;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);

        }

        [TestMethod]
        public void Course_GetStudentsCount_WhenOneAdded()
        {
            germanIntermediaCourse.AddStudent(alexStudent);
            int realStudentsCount = germanIntermediaCourse.Students.Count;
            int expectedStudentsCount = 1;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);

        }


        [TestMethod]
        public void Course_AddNewStudentToCourse()
        {
            germanIntermediaCourse.AddStudent(alexStudent);
            int realStudentsCount = germanIntermediaCourse.Students.Count;
            int expectedStudentsCount = 1;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);
            
        }

        [TestMethod]
        public void Course_AddExistingStudent() 
        {
            germanIntermediaCourse.AddStudent(alexStudent);
            germanIntermediaCourse.AddStudent(yanaStudent);
            germanIntermediaCourse.AddStudent(alexStudent);
            int realStudentsCount = germanIntermediaCourse.Students.Count;
            int expectedStudentsCount = 2;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);
        }

        [TestMethod]
        public void Course_RemoveExistingStudentFromCourse()
        {
            germanIntermediaCourse.AddStudent(alexStudent);
            int realStudentsCount = germanIntermediaCourse.Students.Count;
            int expectedStudentsCount = 1;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);
            germanIntermediaCourse.RemoveStudent(alexStudent);
            realStudentsCount = germanIntermediaCourse.Students.Count;
            expectedStudentsCount = 0;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);
        }

        public void Course_RemoveNonxistingStudentFromCourse()
        {
            germanIntermediaCourse.AddStudent(alexStudent);
            int realStudentsCount = germanIntermediaCourse.Students.Count;
            int expectedStudentsCount = 1;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);
            germanIntermediaCourse.RemoveStudent(yanaStudent);
            realStudentsCount = germanIntermediaCourse.Students.Count;
            expectedStudentsCount = 1;
            Assert.AreEqual(expectedStudentsCount, realStudentsCount);
        }
    }
}