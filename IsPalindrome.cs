/*
Objective:
Write a function with the following signature that will take a string and return whether it is a palindrome (spelled the same forward and backward).

Restrictions:
Cannot use Reverse method
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	public class Program
	{
		public static void Main(string[] args)
		{
			string s;

			Console.WriteLine("Enter a string: ");
			s = Console.ReadLine();

			if (IsPalindrome(s))
				Console.WriteLine(s + " is a palindrome");
			else
				Console.WriteLine(s + " is not a palindrome");

		}

		public static bool IsPalindrome(string input)
		{
	      var succcess = true;
	      
	      input = input.Replace(" ", "");

	      if (input.Length == 0) 
	        succcess = false;
	      else
	        for (var i = 0; i < input.Length/2 + 1; i++)
	        {
	          if (input[i] != input[input.Length - i - 1])
	          {
	            //doesn't not succeed if it's not palindrome
	            succcess = false;
	            break;
	          }
	        }
	      //Return palindrome if it's true
	      return succcess;
	  	}

	}