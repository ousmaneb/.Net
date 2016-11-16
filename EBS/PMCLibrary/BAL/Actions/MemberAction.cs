using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMCLibrary.BAL.Actions.Interface;
using PMCLibrary.BAL.Model;

namespace PMCLibrary.BAL.Actions
{
  public class MemberAction : IAction<MemberModel>
  {
    public bool Insert(MemberModel o)
    {
      throw new NotImplementedException();
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
      throw new NotImplementedException();
    }

    public MemberModel Get(int id)
    {
      throw new NotImplementedException();
    }
  }
}
