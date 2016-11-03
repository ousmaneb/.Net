using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  /// <summary>
  ///  A function is a method stored in a variable
  /// </summary>
  public class Functions
  {

    //Method Signature | Variable name | Method Stored in Variable.
    //Func<string>     |  SayYourName  | () => { return "fred"; };
    // In a func the last type listed in the <> is the return type.
    Func<string> SayYourName = () => { return "fred"; };
    Func<int, string> SayYourAge = (x) => { return x.ToString(); };

    // In an Action everything in the <> us a parameter of the method
    Action<string> SayYourName2 = (n) => { Console.WriteLine(n); };
    Action<int, string> SayYourAge2 = (i, n) => { Console.WriteLine(n + i); };

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private string SayNameAgain()
    {
      return "belotte";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    private string SayAgeAgain(int x)
    {
      return x.ToString();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="f1"></param>
    private void SaySeries(Func<string> f1)
    {
      Console.WriteLine(f1());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="f1"></param>
    private void SaySeries(Func<int, string> f1, int num)
    {
      f1(num);
    }

    /// <summary>
    /// 
    /// </summary>
    public void TryFunctions()
    {
      SaySeries(SayYourName);
      SaySeries(SayNameAgain);
    }
  }
}