using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
  class Program
  {
    static void Main(string[] args)
    {


      Account acc = new Account(1, "Ousmane", 0);

      Console.WriteLine("The balance is: " + acc.CheckBalance());

      acc.deposit(400);

      Console.WriteLine("The new balance is: " + acc.CheckBalance());

      acc.withdraw(20);

      Console.WriteLine("The new balance after I withdraw is :"+ acc.CheckBalance());

      Console.ReadKey();



    }
  }
}
