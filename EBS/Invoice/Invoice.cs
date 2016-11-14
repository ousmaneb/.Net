using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
  class Invoice
  {
    //attributes
    //public string PartNo;
    //public string PartDesc;
    //public int Quantity;
   // public double Price;



    public Invoice(string partno, string partdesc, int quantity, double price)
    {
      PartNo = partno;
      PartDesc = partdesc;
      Quantity = quantity;
      Price = price;
    }

    public string PartNo{ get; set; }

    public string PartDesc { get; set; }

    public int Quantity { get; set; }

    public double Price { get;
      set ; }


    public double GetInvoice( double amount)
    {
      if (Quantity < 0)
        Quantity = 0;

      if (Price < 0)
        Price = 0;

      return Quantity * amount;
    }


  }
}
