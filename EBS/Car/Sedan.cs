using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
  class Sedan : Car
  {
      public int Length;

      public new double GetSalaryPrice()
      {
            if (Length > 2000)
                return RegularPrice - RegularPrice * 0.1;
            else
                return RegularPrice - RegularPrice * 0.2;
        }
  }
}
