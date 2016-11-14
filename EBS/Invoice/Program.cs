using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
  class Program
  {
    static void Main(string[] args)
    {

      ///////Invoice

      Invoice inv = new Invoice("203", "Chair", -1, 200.0);

      Console.WriteLine("The invoice is: "+inv.GetInvoice(200));
      Console.ReadKey();
    }
  }
}
