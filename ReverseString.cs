/*
Reverse string
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
			
			

			Console.Write("Enter a string to reverse: ");
			string s = Console.ReadLine();
		

			Console.Write("The string is: "+s);

			Console.WriteLine();

			string rs = ReverseString(s);
			Console.Write("The reverse string is: "+rs);

			Console.WriteLine();
			Console.WriteLine();

		}

		public static string ReverseString(string input)
		{
	   		char [] charArray = input.ToCharArray();
	   		string reverse = string.Empty;

	   		for (int i = charArray.Length - 1; i > -1; i--)
	   		{
	   			reverse += charArray[i]; 
	   		}

	   		return reverse;
	  	}

	}
