using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCLibrary.BAL.Model
{
  public class ClaimModel
  {
    public int ClaimId { get; set; }
    public int MemberId { get; set; }
    public string ClaimDate { get; set; }
    public string DueDate { get; set; }
    public double ClaimAmount { get; set; }

  }
}
