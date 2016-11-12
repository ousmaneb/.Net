using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Actions
{
  public abstract class Actions
  {
    public abstract bool Insert(Object o);
    public abstract bool Delete(Object o);
    public abstract bool Update(Object o);
    public abstract IEnumerable<Object> Get();
    public abstract object Get(int id);

    public virtual int GetCount(IEnumerable<Object> o)
    {
      return o.Count();
    }




  }
}
