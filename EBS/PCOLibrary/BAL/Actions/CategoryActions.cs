using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Actions
{
  class CategoryActions : Actions
  {
    public override bool Delete(object o)
    {
      throw new NotImplementedException();
    }

    public override IEnumerable<object> Get()
    {
      throw new NotImplementedException();
    }

    public override object Get(int id)
    {
      throw new NotImplementedException();
    }

    public override bool Insert(object o)
    {
      throw new NotImplementedException();
    }

    public override bool Update(object o)
    {
      throw new NotImplementedException();
    }

    public override int GetCount(IEnumerable<object> o)
    {
      return o.Count() + 10;
    }


  }
}
