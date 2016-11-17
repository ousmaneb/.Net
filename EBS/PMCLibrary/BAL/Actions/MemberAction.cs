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
  public class MemberAction : IAction<MemberModel>, IMember
  {
    public bool Insert(MemberModel o)
    {
        return Member_DAL.Insert(o);
    }

    public bool Delete(int id)
    {
      throw new NotImplementedException();
    }

    public bool Update(MemberModel o)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<MemberModel> Get()
    {
        return PMCLibrary.DAL.Member_DAL.GetAll();
    }

    public IEnumerable<MemberModel> Get(int id)
    {
      throw new NotImplementedException();
    }

      public IEnumerable<object> GetPlanWithId()
      {
          throw new NotImplementedException();
      }
  }
}
