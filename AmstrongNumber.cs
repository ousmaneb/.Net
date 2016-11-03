using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c#_programming
{
	class Program
	{
		static void Main(string [] args)
		{
			Console.WriteLine("Enter a number to check if it's an Amstrong Number: ");
			int input = int.Parse(Console.ReadLine());

			CheckAmstrongNumb(input);

		}

		static void CheckAmstrongNumb(int number)
		{
            int remainder, sum=0;
            
			for (int i=number; i>0; i=i/10)
			{
				remainder = i%10;
				sum = sum + (int)Math.Pow(remainder,3);
			}

			Console.WriteLine(number == sum ? number + " is Amstrong Number" : number + " is not Amstrong Number" );
		}
	}
}