using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
  class Car
  {
    public int Speed { get; set; }
    public double RegularPrice { get; set; }
    public string Color { get; set; }

    public double GetSalePrice()
    {
      return RegularPrice;
    }

  }
}
