using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RegistrationApp.Domain;

namespace RegistrationApp.Data
{
  public class CourseDAO
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
    public virtual List<ScheduleClassDAO> Schedule { get; set; }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="courseID"></param>
    /// <param name="courseName"></param>
    /// <param name="courseDuration"></param>
    public CourseDAO(int courseID, string courseName)
    {
      CourseID = courseID;
      CourseName = courseName;
      //CourseDuration = courseDuration;
      Schedule = new List<ScheduleClassDAO>();
    }
  }
}
