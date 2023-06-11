using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7Test
{
    [TestClass]
    public class TeacherTest
    {
        private Teacher languageTeacher;
        private Course germanBegginerCourse;
        private Course englishIntermediateCourse;

        [TestInitialize]
        public void TeacherTestInitialize() 
        {
            languageTeacher = new Teacher 
            { 
                Name = "Jon",
                LastName = "Dou",
                Age = 37,
            };

            germanBegginerCourse = new Course
            {
                CourseName = "Course: German for Begginers",
                CourseDuration = 5
            };
            englishIntermediateCourse = new Course
            {
                CourseName = "Course: Intermediate English",
                CourseDuration = 5
            };
        }


        [TestMethod]
        public void Teacher_CountCourses()
        {
            int expectedCoursesCount = 0;
            int realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
            expectedCoursesCount = 1;
            languageTeacher.AddCourse(germanBegginerCourse);
            realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
        }
        [TestMethod]
        public void Teacher_AddNewCourse()
        {
            int expectedCoursesCount = 1;
            languageTeacher.AddCourse(germanBegginerCourse);
            int realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
        }

        public void Teacher_AddExistingCourse()
        {
            int expectedCoursesCount = 1;
            languageTeacher.AddCourse(germanBegginerCourse);
            languageTeacher.AddCourse(germanBegginerCourse);
            int realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
        }

        public void Teacher_RemoveExistingCourse()
        {
            int expectedCoursesCount = 2;
            languageTeacher.AddCourse(germanBegginerCourse);
            languageTeacher.AddCourse(englishIntermediateCourse);
            int realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
            expectedCoursesCount = 1;
            languageTeacher.RemoveCourse(germanBegginerCourse);
            realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
        }

        public void Teacher_RemoveNonexistingCourse()
        {
            int expectedCoursesCount = 1;
            languageTeacher.AddCourse(germanBegginerCourse);
            int realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
            expectedCoursesCount = 1;
            languageTeacher.RemoveCourse(englishIntermediateCourse);
            realCoursesCount = languageTeacher.GetCoursesCount();
            Assert.AreEqual(expectedCoursesCount, realCoursesCount);
        }
    }
}
