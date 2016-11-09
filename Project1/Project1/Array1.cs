using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
  class Array1
  {

    //Exercise 1
    public bool array_6(int [] arr)
    {
      int l = arr.Length;

        for (int i = 0; i <= l - 1; i++)
        {
          if (l>=1 && arr[0] == 6 || arr[l - 1] == 6)
            return true;
        }
     
      return false;
    }


    //Exercise 2

    public bool array_check(int [] arr)
    {
      int l = arr.Length;
        if ( l>=1 && arr[0]== arr[l - 1])
          return true;
      return false;

    }

    //Exercise 3

    public bool array_check2(int [] a, int [] b)
    {
      int l1 = a.Length;
      int l2 = b.Length;

      if (l1 >= 1 && l2 >= 1 && a[0] == b[0] || a[l1 - 1] == b[l2 - 1])
        return true;
      return false;
    }


    //Exercise 4

    public int sum_array(int [] arr)
    {
      int l = arr.Length;
      int sum = 0;

      for (int i=0; i<=l-1; i++)
      {
        sum += arr[i];
      }
      return sum;
    }


    //Exercise 5
    public int[] array_rotate(int[] arr)
    {

      int l = arr.Length;
      int[] arr1 = new int[l];


      for (int i = 1; i < l; i++)
      {
        arr1[i - 1] = arr[i];
      }

      arr1[l - 1] = arr[0];

      return arr1;
    }

    //Exercise 6

    public int [] array_change(int [] arr)
    {
      int l = arr.Length;

      for (int j = 0; j <= l - 1; j++)
      {
        if (arr[0] > arr[l - 1])
        {
          for (int i = 0; i <= l - 1; i++)
          {
            arr[i] = arr[0];
          }
          return arr;
        }
        arr[j] = arr[l - 1];
      }
      return arr;

    }



    //Exercise 7
    public int array_sum(int [] arr)
    {
      int l = arr.Length;
      int sum = 0;

      if (l == 0)
        return sum;

      else if (l <= 2 && l > 0)
      {
        for (int i = 0; i <= l - 1; i++)
        {
          sum += arr[i];
        }
        return sum;
      }

      else
      {
        for (int i = 0; i <=1; i++)
        {
          sum += arr[i];
        }
        return sum;
      }   
    }


    //Exercise 8

    public int [] array_double(int [] arr1)
    {
      int l = arr1.Length;
      int d = 2 * l;

      int[] arr2 = new int[d];
      int l2 = arr2.Length;

      for (int i = 0; i<=l-1; i++)
      {
        arr2[d-1] = arr1[i];
      }
      return arr2;
    } 

    //exercise 9

    public bool array_unlucky(int [] arr)
    {
      int l = arr.Length;
      for (int i = 0; i <= l - 1; i++)
      {
        if(i<=1 || i>=l-2)
        {
          if (arr[i] == 1 && arr[i + 1] == 3)
            return true;
        }
      }
      return false;
    }


    //exercise 10

    public bool array_unlucky1(int[] arr)
    {
      int l = arr.Length;
      for (int i = 0; i <= l - 1; i++)
      {
        if (i <= 1 || i >= l - 2)
        {
          if (arr[i] == 1 && arr[i + 1] == 3)
            return true;
        }
      }
      return false;
    }


    //Exercise 11

    public int array_even(int [] arr)
    {
      int l = arr.Length;
      int j = 0;
      for (int i=0; i<=l-1; i++)
      {
        if (arr[i] % 2 == 0)
          j++;
      }
      return j;
    }

    //Exercise 12
    public int array_diff(int [] arr)
    {
      int l = arr.Length;
      // smallest = arr[0];
      //int largest = arr[0];

      /*
      for (int i = 0; i < l; i++)
      {
        if (arr[i] < smallest)
        {
          int tmp = smallest;
          smallest = arr[i];
          arr[i] = smallest;
        }

        if (arr[i] > largest)
        {
          int tmp = largest;
          largest = arr[i];
          arr[i] = largest;
        }
      }
      */

      int largest = arr.Max();
      int smallest = arr.Min();
     
      int diff = largest - smallest;
      return diff;

    }


    //Exercise 13
    public int array_centered(int[] arr)
    {
      int l = arr.Length;
      int largest = arr.Max();
      int smallest = arr.Min();
    
      int sum = 0;

      for (int i = 0; i < l; i++)
      {
        sum += arr[i];
      }

      int avg = (sum - smallest - largest) / l;
      return avg;
    }


    //exercise 14

    public bool array_sum2(int [] arr)
    {
      int l = arr.Length;
      int sum = 0;
      for (int i = 0; i < l; i++)
      {
        if (arr[i] == 2)
          sum += arr[i];
      }

      if (sum == 8)
        return true;
      else
        return false;
    }


    //exercise 15

    public bool array_next2(int[] arr)
    {
      int l = arr.Length;

      for (int i = 0; i < l; i++)
      {
        if (arr[i] == 2 && arr[i + 1] == 2)
          return true; 
      }

      return false;
    }


    //exercise 16

    public bool array_next7(int[] arr)
    {
      int l = arr.Length;

      for (int i = 0; i < l; i++)
      {
        if ((arr[i] == 7 && arr[i + 1] == 7)|| (arr[i] == 7 && arr[i + 2] == 7))
          return true;
      }

      return false;
    }

    //exercise 17
    public int[] array_rotateleft(int[] arr)
    {

      int l = arr.Length;
      int[] arr1 = new int[l];


      for (int i = 1; i < l; i++)
      {
        arr1[i-1] = arr[i];
      }

      arr1[l - 1] = arr[0];

      return arr1;
    }


    //Exercise 18
    public int[] array_multiple10(int [] arr)
    {
      int l = arr.Length;
      for (int i = 1; i < l; i++)
      {
        while(arr[i]%10==0)
        {
          arr[i] = arr[i + 1];
          i++;
        }
      }

      return arr;
    }


    //Exercise 19


    //Exercise 20
    public string string_yield(string s)
    {
     if (String.IsNullOrEmpty(s))
        return "yields the empty string";
      else
      return s.Substring(0, 2);
    }


    //Exercise 21

    public string string_evenL(string s)
    {
      int l = s.Length / 2;

      if (s.Length % 2 == 0)
      {
        return s.Substring(0, l);
      }

      return s;
    }

    //Exercise 22
    public string string_fl(string s)
    {
      int l = s.Length;
      return s.Substring(1,  l- 2);
    }

    //Exercise 23
    public string string_conc(string s1, string s2)
    {
      if (s1.Length >= 1 && s2.Length >= 1)
      {
        //return string.Concat(s.Remove(0, 1), wl);
        return s1.Remove(0, 1)+" "+s2.Remove(0, 1);
      }
      return s1+s2;
    }


    //Exercise 24
   public string string_leftRot(string s)
   {
      return (s.Substring(2) + s.Substring(0, 2));

    }

    //Exercise 25
    public string string_righttRot(string s)
    {
      int l = s.Length - 2;
      return (s.Substring(l) + s.Substring(0, l));

    }

    //Exercise 26
    public int string_nbOcc(string s)
    {
      s = s.ToLower();
      int count = 0;
      int l = s.Length;
      
      for (int i=0; i<l; i++)
      {
        if (s == "hi")
        {
          count++;
        }

      }
      return count;
    }




  }
}
