using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Data
{
  public class ScheduleClassDAO
  {
    /// <summary>
    /// 
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public virtual CourseDAO Course { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public virtual List<StudentDAO> Students { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ScheduleClassDAO()
    {
      Students = new List<StudentDAO>();
    }
  }
}
