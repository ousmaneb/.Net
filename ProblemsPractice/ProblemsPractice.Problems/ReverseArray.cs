using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsPractice
{
    public class ReverseArray
    {
        public void reverseA(int [] array)
        {
            Console.WriteLine("Original Array: ");
            foreach (int a in array)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();

            Array.Reverse(array);

            Console.WriteLine("Reverse Array: ");
            foreach (int value in array)
            {
                Console.Write(value+" ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
