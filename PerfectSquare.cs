/*
Objective:
Write an efficient function to determine whether a given number is a perfect square (1, 4, 9, 16, 25…).

Restrictions:
Cannot use the System.Math namespace

Signature:
public static bool PerfectSquare(int input)
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
			Console.WriteLine("Enter a number to check PerfectSquare: ");
			int number = Convert.ToInt32(Console.ReadLine());

			PerfectSquare(number);
			
			if (PerfectSquare(number))
				Console.WriteLine(number+" is a Perfect Square");
			else
				Console.WriteLine(number+" is not a Perfect Square");
		}

		public static bool PerfectSquare(int input)
		{
			for (int i = 1; i <= input; i++) 
        		if ( input == i * i )
           			return true;
    		return false;	
		}

	}