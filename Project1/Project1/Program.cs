using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
  class Program
  {
    static void Main(string[] args)
    {

      //Exercise 1
      Console.WriteLine("-----------------exercise 1--------------");

      int [] a  = { 6, 2, 3, 4, 6 };
      int[] b = { 7, 2, 3, 4, 6 };
      int[] c = { 7, 2, 3, 4, 8};

      Array1 test1 = new Array1();

      Console.WriteLine(test1.array_6(a));
      Console.WriteLine(test1.array_6(b));
      Console.WriteLine(test1.array_6(c));

      //Exercise 2
      Console.WriteLine("-----------------exercise 2--------------");

      Array1 test2 = new Array1();
      int[] a2 = { 6, 2, 3, 4, 6 };
      int[] b2 = { 7, 2, 3, 4, 6 };
      int[] c2 = { };

      Console.WriteLine(test1.array_check(a2));
      Console.WriteLine(test1.array_check(b2));
      Console.WriteLine(test1.array_check(c2));

      //Exercise 3
      Console.WriteLine("-----------------exercise 3--------------");

      Array1 test3 = new Array1();
      int[] a3 = { 6, 2, 3, 4, 6 };
      int[] b3 = { 7, 2, 3, 4, 6 };
      int[] c3 = { };

      Console.WriteLine(test3.array_check2(a3, b3));
      
      //Exercise 4
      Console.WriteLine("-----------------exercise 4--------------");

      Array1 test4 = new Array1();
      int[] a4 = { 6, 2, 3, 4, 6 };
      int[] b4 = { 7, 4, 6 };
      int[] c4 = { };

      Console.WriteLine(test4.sum_array(a4));
      Console.WriteLine(test4.sum_array(b4));
      Console.WriteLine(test4.sum_array(c4));
      //Exercise 5
      Console.WriteLine("-----------------exercise 5--------------");

      Array1 test5 = new Array1();
      int[] a5 = { 1,2,3 };
      int[] b5 = { 7, 2, 3, 4, 6 };
      int[] c5 = { };

 

      int[] z = test5.array_rotate(a5);

      for (int i = 0; i <= z.Length - 1; i++)
      {
        Console.WriteLine(z[i]);
      }

      //Exercise 6
      Console.WriteLine("-----------------exercise 6--------------");

      Array1 test6 = new Array1();
      int[] a6 = { 6, 2, 3, 4, 1 };
      int[] b6 = { 7, 2, 3, 4, 6 };
      int[] c6 = {2,3,4,2 };



      int[] y = test5.array_change(a6);
      int[] y1 = test5.array_change(b6);
      int[] y2 = test5.array_change(c6);
      //int[] y2 = test5.array_change(a5);
      //int[] y3 = test5.array_change(a5);

      for (int i = 0; i <= y.Length - 1; i++)
      {
        Console.Write(y[i]+" ");
      
      }
      Console.WriteLine();

      for (int i = 0; i <= y.Length - 1; i++)
      {
        Console.Write(y1[i] + " ");
      
      }
      Console.WriteLine();

      for (int i = 0; i <= y2.Length - 1; i++)
      {
        Console.Write(y2[i] + " ");
     
   
      }
      Console.WriteLine();


      //Exercise 7
      Console.WriteLine("-----------------exercise 7--------------");

      Array1 test7 = new Array1();
      int[] a7 = { 6, 2, 3, 4, 6 };
      int[] b7 = { 7, 3};
      int[] c7 = { };

      Console.WriteLine(test1.array_sum(a7));
      Console.WriteLine(test1.array_sum(b7));
      Console.WriteLine(test1.array_sum(c7));


      //Exercise 8
      Console.WriteLine("-----------------exercise 8--------------");

      Array1 test8 = new Array1();
      int[] a8 = { 1,2,3 };
      int[] b8 = { 7, 2, 3, 4, 6 };
      int[] c8 = { };

      int[] x = test5.array_double(a8);

      for (int i=0; i<=x.Length-1; i++)
      {
        Console.WriteLine(x[i]);
      }

      //Exercise 9
      Console.WriteLine("-----------------exercise 9--------------");

      Array1 test9 = new Array1();
      int[] a9 = { 1, 3, 7, 4, 6 };
      int[] b9 = { 7, 2, 4, 1, 3 };
      int[] c9 = { 2, 4, 5, 1, 3, 5, 6, 7, 4 };

      Console.WriteLine(test1.array_unlucky(a9));
      Console.WriteLine(test1.array_unlucky(b9));
      Console.WriteLine(test1.array_unlucky(c9));

      //Exercise 10
      Console.WriteLine("-----------------exercise 10--------------");

      Array1 test10 = new Array1();
      int[] a10 = { 1, 3, 7, 4, 6 };
      int[] b10 = { 7, 2, 4, 1, 3 };
      int[] c10 = {2,4,5,1,3,5,6,7,4 };

      Console.WriteLine(test1.array_unlucky(a10));
      Console.WriteLine(test1.array_unlucky(b10));
      Console.WriteLine(test1.array_unlucky(c10));

      //Console.WriteLine(test5.array_rotate(b5));
      //Console.WriteLine(test5.array_rotate(c5));


      //Exercise 10
      Console.WriteLine("-----------------exercise 11--------------");

      Array1 test11 = new Array1();
      int[] a11 = { 1, 3, 7, 4, 6 };
      int[] b11 = { 7, 2, 4, 22, 3 };
      int[] c11 = { 1,5,9,15 };

      Console.WriteLine(test1.array_even(a11));
      Console.WriteLine(test1.array_even(b11));
      Console.WriteLine(test1.array_even(c11));


      Console.WriteLine("-----------------exercise 12--------------");

      Array1 test12 = new Array1();
      int[] a12 = { 2, 3, 7, 4, 6};
  

      Console.WriteLine(test12.array_diff(a12));


      Console.WriteLine("-----------------exercise 13--------------");

      Array1 test13 = new Array1();
      int[] a13 = { 2, 3, 7, 5, 6 };


      Console.WriteLine(test12.array_centered(a13));


      Console.WriteLine("-----------------exercise 14--------------");

      Array1 test14 = new Array1();
      int[] a14 = { 2, 3, 7, 5, 6 };
      int[] b14 = { 2, 2, 7, 2, 6, 2, 9 };
      int[] c14 = { 2, 2, 7, 2, 6, 2, 9,2 };


      Console.WriteLine(test12.array_sum2(a14));
      Console.WriteLine(test12.array_sum2(b14));
      Console.WriteLine(test12.array_sum2(c14));



      Console.WriteLine("-----------------exercise 15--------------");

      Array1 test15 = new Array1();
      int[] a15 = { 2, 3, 7, 5, 6 };
      int[] b15 = { 2, 2, 7, 2, 6, 2, 9 };
      int[] c15 = { 2, 2, 7, 2, 6, 2, 9, 2 };


      Console.WriteLine(test12.array_next2(a15));
      Console.WriteLine(test12.array_next2(b15));
      Console.WriteLine(test12.array_next2(c15));


      Console.WriteLine("-----------------exercise 16--------------");

      Array1 test16 = new Array1();
      int[] a16 = { 2, 3, 7, 5, 6 };
      int[] b16 = { 2, 2, 7, 7, 6, 2, 9 };
      int[] c16 = { 2, 2, 7, 2, 7, 2, 9, 2 };


      Console.WriteLine(test12.array_next7(a16));
      Console.WriteLine(test12.array_next7(b16));
      Console.WriteLine(test12.array_next7(c16));

      Console.WriteLine("-----------------exercise 17--------------");
      Array1 test17 = new Array1();
      int[] a17 = {1, 2, 3, 4, 5, 6};
      //int[] b5 = { 7, 2, 3, 4, 6 };
   
      int[] z17 = test5.array_rotateleft(a17);

      for (int i = 0; i <= z17.Length - 1; i++)
      {
        Console.WriteLine(z17[i]);
      }


      Console.WriteLine("-----------------exercise 18--------------");
      Array1 test18 = new Array1();
      int[] a18 = { 1, 2, 10, 4, 5, 6 };
      //int[] b5 = { 7, 2, 3, 4, 6 };

      int[] z18 = test5.array_multiple10(a18);

      for (int i = 0; i <= z18.Length - 1; i++)
      {
        Console.WriteLine(z17[i]+" ");
      }

      Console.WriteLine("-----------------exercise 18--------------");

      Console.WriteLine("-----------------exercise 20--------------");
      string s1 = "";
      string s2 = "He";
      string s3 = "Hello";

      Array1 test20 = new Array1();


      Console.WriteLine(test20.string_yield(s1));
      Console.WriteLine(test20.string_yield(s2));
      Console.WriteLine(test20.string_yield(s3));


      Console.WriteLine("-----------------exercise 21--------------");
      string s21 = "";
      string s22 = "He";
      string s23 = "WooHoo";

      Array1 test21 = new Array1();


      Console.WriteLine(test20.string_evenL(s21));
      Console.WriteLine(test20.string_evenL(s22));
      Console.WriteLine(test20.string_evenL(s23));


      Console.WriteLine("-----------------exercise 22--------------");
      //string s24 = "";
      string s25 = "Hello";
      //string s26 = "wo";

      Array1 test22 = new Array1();


  //    Console.WriteLine(test22.string_fl(s25));
      Console.WriteLine(test22.string_fl(s25));
     // Console.WriteLine(test22.string_fl(s26));



      Console.WriteLine("-----------------exercise 23--------------");
      string s27 = "Hello";
      string s28 = "World";
    

      Array1 test23 = new Array1();


      Console.WriteLine(test23.string_conc(s27, s28));



      Console.WriteLine("-----------------exercise 24--------------");
      string s30 = "Hello";
      Array1 test24 = new Array1();

      Console.WriteLine(test22.string_leftRot(s30));


      Console.WriteLine("-----------------exercise 25--------------");
      string s31 = "Hello";
      Array1 test25 = new Array1();

      Console.WriteLine(test25.string_righttRot(s31));


      Console.WriteLine("-----------------exercise 26--------------");
      string s32 = "Hellohi";
      Array1 test26 = new Array1();

      Console.WriteLine(test25.string_nbOcc(s32));

      Console.ReadKey();


    }
  }
}
