using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Domain
{
    public class ScheduleClassDTO

    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual CourseDTO Course { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual List<StudentDTO> Students { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ScheduleClassDTO()
        {
            Students = new List<StudentDTO>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public void addStudent(StudentDTO s)
        {
            //4.each course can only hold 20 students.
            if (Students.Count >= 20)
                throw new Exception("The class is full");

            //2.a student can sign up for 6 hours of course at most.
            if (s.CreditHours + Course.CourseDuration > new TimeSpan(6, 0, 0))
                throw new Exception("The student  doesn't have a free time for this course");

            //or same courses at different times.
            if (s.ScheduledClasses.Any(course=>course.Course.CourseID==Course.CourseID))
                throw new Exception("The student is already enrolled in this course");

           
            //3.a student cannot sign up for 2 courses in the same timespan (Overlap time)
            foreach (var schedClass in s.ScheduledClasses)
            {
                if (schedClass.StartTime >= StartTime && schedClass.StartTime < StartTime.Add(Course.CourseDuration))
                    throw new Exception("The student can't sign up at this time--Conflict Time");

                if (StartTime >= schedClass.StartTime && StartTime < schedClass.StartTime.Add(schedClass.Course.CourseDuration))
                    throw new Exception("The student can't sign up at this time--Conflict Time");
            }
            Students.Add(s);
            s.ScheduledClasses.Add(this);
        }

    }
}
