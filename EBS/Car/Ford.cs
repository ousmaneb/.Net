using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
  class Ford : Car
  {
      public int Year { get; set; }
      public int ManufaturerDiscount { get; set; }

      public new double  GetSalePrice()
      {
          return (RegularPrice - ManufaturerDiscount);

      }
  }
}
