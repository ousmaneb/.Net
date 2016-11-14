using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{

  class Saving
  {
    public static double AnnualInterest = 0.02;
    private double savingBalance;

    public Saving( double sb, double anInt){
      savingBalance = sb;
      AnnualInterest = anInt;
    }
    public int SavingBalance { get; set; }

    public double calculateMonthlyInterest()
    {
      double am = (savingBalance*AnnualInterest)/ 12;
      savingBalance += am;

      return savingBalance;
    }

    public static double modifyInterestRate(double intrest)
    {
      return AnnualInterest = intrest;
    }

  }
}
