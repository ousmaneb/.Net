using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPractices
{
  class Program
  {
    static void Main(string[] args)
    {
      Palindrome p = new Palindrome();

      Console.WriteLine("Enter a word to check if is a Palindrome: ");
      string w = Console.ReadLine();

      Console.WriteLine(p.IsPalindrome(w));
      Console.ReadKey();
    }
  }
}
