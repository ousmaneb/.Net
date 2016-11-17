using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMCLibrary.BAL.Actions.Interface;
using PMCLibrary.BAL.Model;


namespace PMCLibrary.BAL.Actions
{
  public class ClaimAction : IAction<ClaimModel>, IClaim
  {
    public bool Insert(ClaimModel o)
    {
      throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
      throw new NotImplementedException();
    }

    public bool Update(ClaimModel o)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<ClaimModel> Get()
    {
      throw new NotImplementedException();
    }

    public ClaimModel Get(int id)
    {
      throw new NotImplementedException();
    }

        IEnumerable<ClaimModel> IAction<ClaimModel>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
