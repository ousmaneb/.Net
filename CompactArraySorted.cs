/*
Objective: 
Write a function with the given signature 
that will take a sorted array of integers 
and return the array compacted. That is, 
given an array containing: 1, 2, 6, 8, 8, 8, 9, 10, 10, 
when the function returns, the contents of the array 
should be: 1, 2, 6, 8, 9, 10.

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
			

			Console.WriteLine("Enter number of the array items: ");
			int number = Convert.ToInt32(Console.ReadLine());
			

			int [] arrItems = new int[number];
			int [] CompactarrItems = new int[number];

			for(int i=0; i<number; i++)
			{
				Console.Write("Enter the "+(i+1)+" number of the array: ");
				int n= Convert.ToInt32(Console.ReadLine());
				arrItems[i]=n;
			}

			Console.WriteLine("Unsorted Compacted array is: ");
            foreach(int i in arrItems)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine();

			CompactarrItems = CompactArray(arrItems);
            
            Console.WriteLine("sorted Compacted array is: ");
            foreach(int j in CompactarrItems)
                Console.Write(j+ " ");
            Console.WriteLine();

		}

	public static int[] CompactArray(int[] input){
	    int inputLength = input.Length;
	    int[] solution = null;
	    int[] CArray = new int[inputLength];
	    
	       if (input != null && inputLength > 0)
	        {
	                CArray[0] = input[0];
	                int j = 1;
	                for (int i = 1; i < inputLength; ++i)
	                {
	                    if (input[i] != input[i - 1])
	                    {
	                        CArray[j] = input[i];
	                        ++j;
	                    }
	                }
	                solution = new int[j];
	                for (int i = 0; i < j; ++i)
	                {
	                    solution[i] = CArray[i];
	                }
	            }
	            return solution;
	        }

	}
