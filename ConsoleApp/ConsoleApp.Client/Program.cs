using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp.Domain;

namespace ConsoleApp.Client
{
  /*
  * access modifiers: 
  * public, internal (default + works only for class), protected, private (default for methods).
  */

  /*
  * extended modifiers: 
  * abstract, override, virtual, static, readonly, const, partial, sealed.
  */

  /// <summary>
  /// start of the program.
  /// </summary>
  internal class Program
  {
    /// <summary>
    /// fire the console.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
      //CreatePerson();
      //AddPerson();

      PlayWithShape();

      Console.ReadKey();
    }

    /// <summary>
    /// 
    /// </summary>
    public static void CreatePerson()
    {
      Person p = new Person();
      var p1 = new Person("!@#$$%^&*1234", "belotte", "8675309");

      p.FirstName = "fred";
      p.LastName = "belotte";
      p.PhoneNumber = "2025694976";

      p.Address = new Location()
      {
        Street = "sunset hills",
        City = "reston",
        State = "va",
        Zipcode = "12345"
      };

      Console.WriteLine(p1.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    public static void AddPerson()
    {
      var p = new Person();

      Console.Write("enter your first name: ");
      p.FirstName = Console.ReadLine(); //InputField(@"\w+");

      Console.WriteLine();

      Console.Write("enter your last name: ");
      p.LastName = Console.ReadLine(); //InputField(@"\w+");

      Console.WriteLine();
      Console.WriteLine(p);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="regex"></param>
    /// <returns></returns>
    private static string InputField(string regex)
    {
      ConsoleKey key;
      var input = string.Empty;

      do
      {
        key = Console.ReadKey().Key;

        if (key != ConsoleKey.Enter)
        {
          if (Regex.IsMatch(key.ToString(), regex))
          {
            input += key.ToString();
          }
          else
          {
            key = ConsoleKey.Clear;
          }
        }
      } while (key != ConsoleKey.Enter);

      return input;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="shape"></param>
    public static IForm CreateShape(string shape)
    {
      switch (shape)
      {
        case "square":
          return new Square();
        case "cube":
          return new Cube();
        default:
          return new Rectangle();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static void PlayWithShape()
    {
      var s = CreateShape("cube");

      Console.WriteLine(s);
    }
  }
}