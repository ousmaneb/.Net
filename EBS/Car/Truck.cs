using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
  class Truck : Car
  {
    public int Weight { get; set; }

    public new double GetSalePrice()
    {
      if (Weight > 2000)
        return RegularPrice - RegularPrice * 0.1;
      else
        return RegularPrice - RegularPrice * 0.2;
    }
  }
}
