using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EvenOdd eo = new EvenOdd();
            //eo.check();
            //Console.ReadLine();

            ReverseArray ra = new ReverseArray();
            int[] a = { 1, 2, 3, 4, 5 };
            ra.reverseA(a);
        }
    }
}
