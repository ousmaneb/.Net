using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
  class Account
  {

    //attributes

    public const double DEFAULT_BALANCE = 100.00;

    //construct

    public Account(int id, string name, double balance)
    {
     ID = id;
      Name = name;
    
      Balance = balance;
      if (balance == 0)
      {
        balance = DEFAULT_BALANCE;
      }
      else
      {
        Balance = balance;
      }
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }




    public double CheckBalance()
    {
      return Balance;
    }

    public void deposit(double amount)
    {
      Balance += amount;
    }



    public void withdraw(double amount)
    {
      if (Balance >= amount)
      {
        Balance -= amount;
      }
      else
      {
        Console.WriteLine("You can't withdraw money, Check your balance");
      
      }
    }



  }
}
