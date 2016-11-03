/*
Objective: 
Write a function w
FizzBizz
Restrictions:
Cannot use Distinct method
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
			
			Console.WriteLine("Enter number : ");
			int number = Convert.ToInt32(Console.ReadLine());
			

			for (int i=1; i<=number; i++)
			{
				if ((i%5 == 0) & (i%3 == 0))
					Console.Write("FizzBizz"+" ");

				else if (i%3 == 0)
					Console.Write("Fizz"+" ");
				else if (i%5 == 0)
					Console.Write("Bizz"+" ");
				
				else
					Console.Write(i+" ");
			}

			Console.WriteLine();

		}
	}
