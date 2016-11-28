using System;

namespace PMCLibrary.BAL.Model
{
  public sealed class ClaimModel
  {


    public int ClaimId { get; set; }
    public int MemberId { get; set; }
    public DateTime ClaimDate { get; set; }
    public DateTime DueDate { get; set; }
    public double ClaimAmount { get; set; }
    public MemberModel Member { get; set; }

    public ClaimModel()
    {
      ClaimDate = DateTime.Today;
      DueDate = DateTime.Today;
      Member = new MemberModel();
    }


    public ClaimModel(int memid, DateTime claimdate, DateTime duedate, double claimamount)
    {
      MemberId = memid;
      ClaimDate = claimdate;
      DueDate = duedate;
      ClaimAmount = claimamount;
    }

 
  }
}