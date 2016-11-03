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
			
			Console.WriteLine(); 

			Console.Write("What is your year of birth: ");
			int y= Convert.ToInt32(Console.ReadLine());
			

			Console.Write("What is your month of birth: ");
			int m= Convert.ToInt32(Console.ReadLine());
			

			Console.Write("What is your day of birth: ");
			int d= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			BirthDay(y, m, d);
			Console.WriteLine();
			

		}

		public static void BirthDay(int year, int month, int day)
		{
	   		DateTime date1 = new DateTime(year, month, day);
	   		DateTime birth = date1.Date;

	   		DateTime thisDay = DateTime.Today;
	   		

	   		Console.WriteLine("Your BirthDay is: " + birth.ToString("d"));
	   		Console.WriteLine("Today date is: "+ thisDay.ToString("d"));

	   		TimeSpan diff = thisDay - birth;

	   		Console.WriteLine("Your age is: "+diff);

	  	}

	}
