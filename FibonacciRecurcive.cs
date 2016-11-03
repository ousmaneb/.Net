/*
Objective:
Write a recursive function to compute the nth Fibonacci number (Fib(n) = Fib(n – 1) + Fib(n – 2), Fib(0) = 0, Fib(1) = 1).

Restrictions:
None

Signature:
public static int Fibonacci(int input)
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
			Console.WriteLine("Enter a limit number to find the Fibonacci: ");
			int number = Convert.ToInt32(Console.ReadLine());

			Fibonacci(0, 1, 1, number);
			Console.WriteLine();

		}

		public static void Fibonacci(int first, int second, int counter, int number)
		{
			Console.Write(first+" ");
			if (counter < number)
				Fibonacci(second, first + second, counter + 1, number);

				
		}
	}