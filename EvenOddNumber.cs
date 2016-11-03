using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace c#_Programming
//{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			int num = int.Parse(Console.ReadLine());

			EvenOdd(num);
		}


		static void EvenOdd(int number)
		{
			Console.WriteLine(number%2 == 0 ? number+" is even number": number+" is odd number");
		}

	}
//}
