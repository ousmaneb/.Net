using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCLibrary.BAL.Model
{
  public sealed class ClaimModel
  {
    public int ClaimId { get; set; }
    public int MemberId { get; set; }
    public string ClaimDate { get; set; }
    public string DueDate { get; set; }
    public double ClaimAmount { get; set; }
    public MemberModel Member { get; set; }
   

    int _classProperty;
    public int ClassProperty
    {
      get { return _classProperty; }
      private set
      {
        if (value > 0)
        { _classProperty = value; }

      }
    }

    public ClaimModel()
    {
      ClaimDate = string.Empty;
      DueDate = string.Empty;
      ClaimAmount = 0.00;
      Member = new MemberModel();
    }


    public ClaimModel(int memid, string claimdate, string duedate, double claimamount)
    {
      MemberId = memid;
      ClaimDate = claimdate;
      DueDate = duedate;
      ClaimAmount = claimamount;

    }




  }
}
