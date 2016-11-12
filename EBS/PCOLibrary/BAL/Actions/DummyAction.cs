using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Actions
{
  public class DummyAction : IAction
  {
    public bool Delete(object o)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<object> Get()
    {
      throw new NotImplementedException();
    }

    public object Get(int id)
    {
      throw new NotImplementedException();
    }

    public bool Insert(object o)
    {
      throw new NotImplementedException();
    }

    public bool Update(object o)
    {
      throw new NotImplementedException();
    }
  }
}
