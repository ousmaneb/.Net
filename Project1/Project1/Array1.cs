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
      int n = -1;
      for (int i = 0; i < l; i++)
      {
        if (arr[i] % 10 == 0)
          n = arr[i];
        else if (n != -1)
          arr[i] = n;
      }

      return arr;
    }


    //Exercise 19
    public int[] array_alone(int[] s, int n)
    {
      for (int i = 1; i < s.Length - 1; i++)
      {
        if (s[i] == n)
        {
          if (s[i - 1] != n && s[i + 1] != n)
            s[i] = (s[i - 1] > s[i + 1]) ? s[i - 1] : s[i + 1];
        }
      }
      return s;
    }

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
      
      if (s.Length == 1 && s[0]=='h')
      {
        count = 0;
      }
      else
      {
        for (int i = 0; i < l; i++)
        {
          if (s[i] == 'h' && s[i+1]=='i')
          {
            count++;
          }
        }
      }
  
      return count;
    }


    //Exercise 27

    
  public int string_nbCode(string s)
  {
      int count = 0;
      int i = 0;
      int l = s.Length - 3;

      while (i < l)
      {
        if (s[i] == 'c' && s[i + 1] == 'o' && s[i + 3] == 'e')
        {
          count++;
          i += 4;
        }
        else
          i++;
      }

      return count;
    }



      //Exercise 28
    public bool string_appear(String s1, String s2)
    {
      int l1 = s1.Length;
      int l2 = s2.Length;
      String end;
      String temp;
      s1 = s1.ToLower();
      s2 = s2.ToLower();
      if (l1 >= l2)
      {
        end = s1.Substring(l1 - l2);
        temp = s2;
      }
      else
      {
        end = s2.Substring(l2 - l1);
        temp = s1;
      }
      return (end.Equals(temp));
    }

    //Exercise 29
    public bool string_xyz(String s)
    {
      int l = s.Length;
      int mid;


      if (l < 3)
        return false;

      mid = l / 2;
      if (l % 2 == 0)
      {
        if (s[mid] == 'y')
          return (s[mid - 1] == 'x' && s[mid + 1] == 'z');

        if (s[mid - 1] == 'y')
          return (s[mid - 2] == 'x' && s[mid] == 'z');

        return false;
      }
      // len%2 != 0
      else if (s[mid] == 'y')
        return (s[mid - 1] == 'x' && s[mid + 1] == 'z');
      return false;
    }

    //Exercise 30
    public String string_zipZap(String s)
    {
      int l = s.Length;
      int l1 = l - 2;
      int i = 0;
      char ch;
      StringBuilder sb = new StringBuilder(l);
      while (i < l)
      {
        ch = s[i];
        if (ch == 'z' && i < l1 && s[i + 2] == 'p')
        {
          sb.Append("zp");
          i += 3;
        }
        else
        {
          sb.Append(ch);
          i++;
        }
      }
      return sb.ToString();
    }

    //Exercise 31
    public int count_yz(String s)
    {
      int count = 0;
      int limit = s.Length - 1;
      char ch;
      s = s.ToLower();
      ch = s[0];


      for (int i = 1; i <= limit; i++)
      {
        if (ch == 'y' || ch == 'z')
        {
          ch = s[i];
          if (!Char.IsLetter(ch))
            count++;
        }
        else
          ch = s[i];
      }


      if (ch == 'y' || ch == 'z')
        count++;
      return count;
    }




    //Excercise 32
    public string ReverseString(string input)
    {
      char[] charArray = input.ToCharArray();
      string reverse = string.Empty;

      for (int i = charArray.Length - 1; i > -1; i--)
      {
        reverse += charArray[i];
      }

      return reverse;
    }



    //Exercise 33
    public bool IsPalindrome(string input)
    {
      var succcess = true;

      input = input.Replace(" ", "");

      if (input.Length == 0)
        succcess = false;
      else
        for (var i = 0; i < input.Length / 2 + 1; i++)
        {
          if (input[i] != input[input.Length - i - 1])
          {
            //doesn't not succeed if it's not palindrome
            succcess = false;
            break;
          }
        }
      //Return palindrome if it's true
      return succcess;
    }

    //Exercise 34
    public int vowel_count(string s)
    {
      int l = s.Length;
      int count = 0;
      s = s.ToLower();
      for (int i = 0; i <l; i++)
      {
        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'o' || s[i] == 'u' || s[i] == 'i')
          count++;
      }
      return count;
    }

    //Exercise 35
    public string string_app(string s)
    {

      int n = s.IndexOf("is");
      int count;
      while (n != -1)
      {
        count = 0;
        if (n > 0)
        {
          if (!char.IsLetter(s[n - 1]))
            count++;
        }
        else
          count++;


        if (n < s.Length - 2)
        {
          if (!char.IsLetter(s[n + 2]))
            count++;
        }
        else
          count++;


        if (count == 2)
          s = s.Substring(0, n) + "is not" + s.Substring(n + 2);

        n = s.IndexOf("is", n + 2);
      }

      return s;
    }




  }
}
