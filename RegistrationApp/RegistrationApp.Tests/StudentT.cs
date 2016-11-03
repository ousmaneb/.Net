using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistrationApp.Domain;
using System.Linq;


namespace RegistrationApp.Tests
{
    [TestClass]
    public class StudentT
    {
        [TestMethod]
        public void TestAddStudent()
        {
            StudentDTO s = new StudentDTO("Ousmane", "Barry");
            CourseDTO c = new CourseDTO(0, "Test 101", new TimeSpan(2, 0, 0));
            
            ScheduleClassDTO sc = new ScheduleClassDTO(); 
            
            sc.addStudent(s);

            Assert.IsTrue(sc.Students.Contains(s));
            
        }

        [TestMethod]
        public void TestDuplicateClass()
        {
            StudentDTO s = new StudentDTO("Ousmane", "Barry");
            CourseDTO c = new CourseDTO(0, "Test 101", new TimeSpan(2, 0, 0));

            ScheduleClassDTO sc = new ScheduleClassDTO(); 

            var succeed = Program.ScheduleClass(sc, s);

            Assert.IsTrue(succeed);
            Assert.IsTrue(sc.Students.Contains(s));

            succeed = Program.ScheduleClass(sc, s);

            Assert.IsFalse(succeed);
            Assert.IsTrue(sc.Students.Where(student => student == s).Count() == 1);

        }

        [TestMethod]
        public void TestNumberStudent()
        {
            StudentDTO s = new StudentDTO("Ousmane", "Barry");
            CourseDTO c = new CourseDTO(0, "Test 101", new TimeSpan(2, 0, 0));
            ScheduleClassDTO sc = new ScheduleClassDTO(); 
            
            for (int number=1; number<=20; number++)
            {
                Assert.IsTrue(Program.ScheduleClass(sc, new StudentDTO(number + "name", "blah")));
            }

            Assert.IsFalse(Program.ScheduleClass(sc, s));
        }

     // public CourseDTO Course { get; set; }


      [TestMethod]
        public void SignUpHours()
        {
            StudentDTO s = new StudentDTO("Ousmane", "Barry");

            CourseDTO c = new CourseDTO(0, "Test 101", new TimeSpan(2, 0, 0));
            CourseDTO c2 = new CourseDTO(2, "Test 102", new TimeSpan(2, 0, 0));
            CourseDTO c3 = new CourseDTO(3, "Test 103", new TimeSpan(2, 0, 0));
            CourseDTO c4 = new CourseDTO(1, "Test 104", new TimeSpan(2, 0, 0));

            ScheduleClassDTO sc = new ScheduleClassDTO { Course = c, StartTime = new DateTime(2000,1,1,8,0,0)};
      ScheduleClassDTO sc2 = new ScheduleClassDTO { Course = c2, StartTime = new DateTime(2000, 1, 1, 10, 0, 0) };
      ScheduleClassDTO sc3 = new ScheduleClassDTO { Course = c3, StartTime = new DateTime(2000, 1, 1, 12, 0, 0) };
      ScheduleClassDTO sc4 = new ScheduleClassDTO { Course = c4, StartTime = new DateTime(2000, 1, 1, 14, 0, 0) };

            Assert.IsTrue(Program.ScheduleClass(sc, s));
            Assert.IsTrue(Program.ScheduleClass(sc2, s));
            Assert.IsTrue(Program.ScheduleClass(sc3, s));
            Assert.IsFalse(Program.ScheduleClass(sc4, s));

        }

        [TestMethod]
        public void OverLapTime()
        {
            StudentDTO s = new StudentDTO("Ousmane", "Barry");

            CourseDTO c = new CourseDTO(0, "Test 101", new TimeSpan(2, 0, 0));
            CourseDTO c2 = new CourseDTO(2, "Test 102", new TimeSpan(2, 0, 0));
            CourseDTO c3 = new CourseDTO(3, "Test 103", new TimeSpan(2, 0, 0));
            CourseDTO c4 = new CourseDTO(1, "Test 104", new TimeSpan(2, 0, 0));

      ScheduleClassDTO sc = new ScheduleClassDTO { Course = c, StartTime = new DateTime(2000, 1, 1, 8, 0, 0) };
      ScheduleClassDTO sc2 = new ScheduleClassDTO { Course = c2, StartTime = new DateTime(2000, 1, 1, 7, 0, 0) };
      ScheduleClassDTO sc3 = new ScheduleClassDTO { Course = c3, StartTime = new DateTime(2000, 1, 1, 8, 0, 0) };
      ScheduleClassDTO sc4 = new ScheduleClassDTO { Course = c4, StartTime = new DateTime(2000, 1, 1, 9, 0, 0) };
      ScheduleClassDTO sc5 = new ScheduleClassDTO { Course = c4, StartTime = new DateTime(2000, 1, 1, 10, 0, 0) };

            Assert.IsTrue(Program.ScheduleClass(sc, s));
            Assert.IsFalse(Program.ScheduleClass(sc2, s));
            Assert.IsFalse(Program.ScheduleClass(sc3, s));
            Assert.IsFalse(Program.ScheduleClass(sc4, s));
            Assert.IsTrue(Program.ScheduleClass(sc5, s));

        }

        [TestMethod]
        public void SameCourseDiffTime()
        {
            StudentDTO s = new StudentDTO("Ousmane", "Barry");

            CourseDTO c = new CourseDTO(0, "Test 101", new TimeSpan(2, 0, 0));
      //Course c2 = new Course(0, "Test 101", new TimeSpan(2, 0, 0));

      ScheduleClassDTO sc = new ScheduleClassDTO { Course = c, StartTime = new DateTime(2000, 1, 1, 8, 0, 0) };
      ScheduleClassDTO sc2 = new ScheduleClassDTO { Course = c, StartTime = new DateTime(2000, 1, 1, 10, 0, 0) };

            Assert.IsTrue(Program.ScheduleClass(sc, s));
            Assert.IsFalse(Program.ScheduleClass(sc2, s));
        }


        [TestMethod]
        public void FullPartTime()
        {
            StudentDTO s = new StudentDTO("Ousmane", "Barry");

            CourseDTO c = new CourseDTO(0, "Test 101", new TimeSpan(2, 0, 0));
            CourseDTO c2 = new CourseDTO(2, "Test 102", new TimeSpan(1, 0, 0));
            CourseDTO c3 = new CourseDTO(3, "Test 103", new TimeSpan(2, 0, 0));
            CourseDTO c4 = new CourseDTO(1, "Test 104", new TimeSpan(1, 0, 0));

            ScheduleClassDTO sc = new ScheduleClassDTO { Course = c, StartTime = new DateTime(2000, 1, 1, 8, 0, 0) };
      ScheduleClassDTO sc2 = new ScheduleClassDTO { Course = c2, StartTime = new DateTime(2000, 1, 1, 10, 0, 0) };
      ScheduleClassDTO sc3 = new ScheduleClassDTO { Course = c3, StartTime = new DateTime(2000, 1, 1, 11, 0, 0) };
      ScheduleClassDTO sc4 = new ScheduleClassDTO { Course = c4, StartTime = new DateTime(2000, 1, 1, 13, 0, 0) };

            // no hours
            Assert.IsTrue(s.Status == StudentStatus.PartTime);
            Assert.IsFalse(s.Status == StudentStatus.FullTime);


            Assert.IsTrue(Program.ScheduleClass(sc, s)); // 2hrs of classes
            Assert.IsTrue(s.Status == StudentStatus.PartTime);
            Assert.IsFalse(s.Status == StudentStatus.FullTime);

            Assert.IsTrue(Program.ScheduleClass(sc2, s)); // 3hrs
            Assert.IsTrue(s.Status == StudentStatus.PartTime);
            Assert.IsFalse(s.Status == StudentStatus.FullTime);

            // after this student should be full time
            Assert.IsTrue(Program.ScheduleClass(sc4, s)); // 4 hrs
            Assert.IsTrue(s.Status == StudentStatus.FullTime);
            Assert.IsFalse(s.Status == StudentStatus.PartTime);

            Assert.IsTrue(Program.ScheduleClass(sc3, s));// 6hrs
            Assert.IsTrue(s.Status == StudentStatus.FullTime);
            Assert.IsFalse(s.Status == StudentStatus.PartTime);
        }



    }

}
