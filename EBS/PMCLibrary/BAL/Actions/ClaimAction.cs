using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMCLibrary.BAL.Actions.Interface;
using PMCLibrary.BAL.Model;
using PMCLibrary.DAL;


namespace PMCLibrary.BAL.Actions
{
  public class ClaimAction : IAction<ClaimModel>, IClaim
  {
    public bool Insert(ClaimModel o)
    {
      return Claim_DAL.Insert(o);
    }

    public bool Delete(int id)
    {
      return Claim_DAL.Delete(id);
    }

    public bool Update(ClaimModel o)
    {
        return Claim_DAL.Update(o);
    }

    public IEnumerable<ClaimModel> Get()
    {
      return PMCLibrary.DAL.Claim_DAL.GetAll();
    }

   
        public IEnumerable<ClaimModel> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
