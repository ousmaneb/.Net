using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationApp.Data;

namespace RegistrationApp.Domain
{
  public static class DomainHelper
  {
    public static void  AddStudent(StudentDTO s)
    {
      var student = new StudentDAO(s.FirstName, s.LastName);
      DataHelper.AddStudent(student);

    }

    public static void AddCourse(CourseDTO c)
    {
      var course = new CourseDAO(c.CourseID, c.CourseName);
      DataHelper.AddCourse(course);
    }

    public static void AddScheduleClass(ScheduleClassDTO sc)
    {
      var schedulec = new ScheduleClassDAO();
      DataHelper.AddScheduleClass(schedulec);
    }

    public static void AddScheduleStudent(StudentDTO s, ScheduleClassDTO sc)
 
    {
      
    }



  }
}
