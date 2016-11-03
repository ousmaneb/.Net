using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Domain
{
    public class CourseDTO
    {

        /// <summary>
        /// 
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan CourseDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual  List<ScheduleClassDTO> Schedule { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseID"></param>
        /// <param name="courseName"></param>
        /// <param name="courseDuration"></param>
        public CourseDTO(int courseID, string courseName, TimeSpan courseDuration)
        {
            CourseID = courseID;
            CourseName = courseName;
            CourseDuration = courseDuration;
            Schedule = new List<ScheduleClassDTO>();
        }

    }
}
