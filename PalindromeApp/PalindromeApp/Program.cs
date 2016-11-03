using PalindromeApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeApp
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Ask the user to input a string
            Console.Write("Enter a String to check if it's a palindrome: ");

            //Take the string a store it in s variable
            string s = Console.ReadLine();

            //Create an object palindrome w
            Palindrome w = new Palindrome();

            //check if it's a palindrome 
            if (w.IsPalindrome(s) == true)

                Console.WriteLine(s + " is a palindrome");
            else
                Console.WriteLine(s + " is not a palindrome");

            Console.ReadKey();

        }
    }
}
