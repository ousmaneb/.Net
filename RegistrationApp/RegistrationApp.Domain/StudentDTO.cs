using System;
using System.Collections.Generic;

namespace RegistrationApp.Domain
{
    public class StudentDTO
    {
        /// <summary>
        /// First Name of the Student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the student
        /// </summary>
        public string LastName { get; set; }


        /// <summary>
        /// List of schedule classes
        /// </summary>
        public virtual List<ScheduleClassDTO> ScheduledClasses { get; set; }

        /// <summary>
        /// Constructor that has student name and list of schedule classes
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public StudentDTO(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            ScheduledClasses = new List<ScheduleClassDTO>();

        }

        /// <summary>
        /// Calculate total of credit hours
        /// </summary>
        public TimeSpan CreditHours
        {
            get
            {
                TimeSpan duree = new TimeSpan();
                foreach (var sheduledClass in ScheduledClasses)
                {
                    duree += sheduledClass.Course.CourseDuration;
                }
                return duree;
            }
        }


        /// <summary>
        /// Return the status of the student either fulltime of parttime
        /// </summary>
        public StudentStatus Status
        {
            get
            {
                //5.a student is considered ‘fulltime’ if he/she has more than 3 hours of coursework.
                if (CreditHours.Hours > 3)
                    return StudentStatus.FullTime;

                //6.a student is considered ‘halftime’ if he/she has 3 hours or less of coursework.
                else
                    return StudentStatus.PartTime;
            }
        }


    }
}
