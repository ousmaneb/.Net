using System.Collections.Generic;

namespace PMCLibrary.BAL.Model
{
    public sealed class PlanModel
    {
        public PlanModel()
        {
            PlanName = string.Empty;
            Descr = string.Empty;
            Member = new List<MemberModel>();
        }

        public ICollection<MemberModel> Member { get; set; }

        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public string Descr { get; set; }

        public double DetuctibleValue { get; set; }
    }
}