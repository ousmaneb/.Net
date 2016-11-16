using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCLibrary.BAL.Model
{
  public class MemberModel
  {
    public int MemberId { get; set; }
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public string Dob{ get; set; }
    public string Gender { get; set; }
    public string Username { get; set; }
    public int PlanId { get; set; }
  }
}
