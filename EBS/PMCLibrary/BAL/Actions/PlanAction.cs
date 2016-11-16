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
  public class PlanAction : IAction<PlanModel>, IPlan
  {
    public bool Insert(PlanModel o)
    {
      bool result = false;
      if (o == null)
        return result;
      else
      {
        //todo Apply my business logic if any or call DAL.
        if (string.IsNullOrEmpty(o.PlanName) || o.PlanName.Length <= 1)
          return result;
        else

          return result = Plan_DAL.Insert(o);
      }
    }

    public bool Delete(int id)
    {
      throw new NotImplementedException();
    }

    public bool Update(PlanModel o)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<PlanModel> Get()
    {
      throw new NotImplementedException();
    }

    public PlanModel Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<object> GetMemberWithPlanIdCount()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<object> GetMemberWithNoPlanIdCount()
    {
      throw new NotImplementedException();
    }
  }
}
