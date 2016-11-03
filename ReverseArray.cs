/*
Reverse array
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
			Console.WriteLine("Enter number of the array items: ");
			int number = Convert.ToInt32(Console.ReadLine());
			

			int [] arrItems = new int[number];
			int [] RevArray = new int[number];

			for(int i=0; i<number; i++)
			{
				Console.Write("Enter the "+(i+1)+" number of the array: ");
				int n= Convert.ToInt32(Console.ReadLine());
				arrItems[i]=n;
			}

			Console.WriteLine("The elements array is: ");
            foreach(int i in arrItems)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine();

			RevArray = ReverseArray(arrItems);
            
            Console.WriteLine("The reverse array is: ");
            foreach(int j in RevArray)
                Console.Write(j+ " ");
            Console.WriteLine();


		}

		public static int[] ReverseArray(int[] input)
		{
	   		for (int i=0; i<input.Length/2; i++)
	   		{
	   			int j=input[i];
	   			input[i] = input[input.Length-i-1];
	   			input[input.Length-i-1] = j;
	   		}

	   		return input;
	  	}

	}
