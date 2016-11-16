using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Actions
{
  public  interface IAction<T> where T:class
  {

   bool Insert(T o);
   bool Delete(int id);
   bool Update(T o);
   IEnumerable<T> Get();
   T Get(int id);
  }
}
