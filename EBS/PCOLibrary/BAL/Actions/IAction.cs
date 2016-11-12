using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Actions
{
  public  interface IAction
  {

   bool Insert(Object o);
   bool Delete(Object o);
   bool Update(Object o);
   IEnumerable<Object> Get();
   object Get(int id);
  }
}
