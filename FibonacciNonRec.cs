/*
Objective:
Write a non-recursive function to compute the nth Fibonacci number (Fib(n) = Fib(n – 1) + Fib(n – 2), Fib(0) = 0, Fib(1) = 1).

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

			Fibonacci(number);
			Console.WriteLine();

		}

		public static int Fibonacci(int input)
		{
			int first=0;
			int second=1;

			for (int i =0; i<input; i++)
			{
				Console.Write(first+" ");
				int temp =first;
				first=second;
				second=temp+second;
			}

			return first;
		}
	}