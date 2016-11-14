using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
  public class Employees
  {
    public Employees(string firstname, string lastname, double monthly)
    {
      FirstName = firstname;
      LastName = lastname;
      Monthly = monthly;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Monthly { get; set; }

    public double GetMonthly(double amount)
    {
      //if (Monthly < 0)
        //amount= 0;

      return amount;
    }

    public double GetMonthlyRaise(double amount)
    {
      if (Monthly < 0)
       amount = 0;

      return (amount * 0.1+amount);
    }

  }
}
