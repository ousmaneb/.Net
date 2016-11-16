using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PMCLibrary.BAL.Model
{
  public class PlanModel
  {
    public int PlanId { get; set; }
    public string PlanName { get; set; }
    public string Descr { get; set; }

    public double DetuctibleValue { get; set; }

    public PlanModel()
    {
      PlanName = string.Empty;
      Descr = string.Empty;
    }
  }
}
