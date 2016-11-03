using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsPractice
{
    public class EvenOdd
    {
        //private object Console;

            public void check()
            {
                int i;
                Console.Write("Enter a number: ");
                i = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                    Console.Write(i + " is an Even Number");
                else
                    Console.Write(i + " is an Odd Number");
  
            }
        
    }
}
