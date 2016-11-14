using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{
  class Program
  {
    static void Main(string[] args)
    {

      Saving saver1 = new Saving(2000.00, 0.04);
      Saving saver2 = new Saving(3000.00, 0.04);

      Console.WriteLine("The new balance of saver1 is :"+saver1.calculateMonthlyInterest());
      Console.WriteLine("The new balance of saver2 is :"+ saver2.calculateMonthlyInterest());

      Console.WriteLine("After changing the interest ");

      Saving saver3 = new Saving(2000.00,0.05);
      Saving saver4 = new Saving(3000.00, 0.05);

      Console.WriteLine("The new balance of saver1 is :" + saver3.calculateMonthlyInterest());
      Console.WriteLine("The new balance of saver2 is :" + saver4.calculateMonthlyInterest());


      Console.ReadKey();
    }
  }
}
