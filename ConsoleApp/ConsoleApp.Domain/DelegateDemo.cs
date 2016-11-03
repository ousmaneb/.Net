using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  //Delegate are public by default, its function and action that can be decide based on the signature
  public class DelegateDemo
  {
    public delegate void SayYourName(); //action type, action has no return type

    public delegate string SayYourNameAgain(string name); // Func<string, string>


    public void NameCaller()
    {
      Console.WriteLine("I said something");
    }

    public static void NameCaller2()
    {
      Console.WriteLine("I said something again");
    }

    public void NameInvoke(SayYourName name)
    {
      name();
    }
  }
}
