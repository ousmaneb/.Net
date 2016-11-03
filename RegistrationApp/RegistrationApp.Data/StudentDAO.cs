using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RegistrationApp.Domain;

namespace RegistrationApp.Data
{
  public class StudentDAO
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
    public virtual List<ScheduleClassDAO> ScheduledClasses { get; set; }

    /// <summary>
    /// Constructor that has student name and list of schedule classes
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    public StudentDAO(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
      ScheduledClasses = new List<ScheduleClassDAO>();

    }
  }
}
