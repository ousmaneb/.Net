using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  /// <summary>
  /// 
  /// </summary>
  public class CollectionBonanza
  {
    /// <summary>
    /// 
    /// </summary>
    public void ArrayCollection()
    {
      // 1-dimension
      int[] a1 = new int[5];
      int[] a2 = { 1, 2, 3, 4 };

      a2[3] = 10;
      var x1 = a2[0];

      // x-dimension
      int[,] a3 = new int[2, 3]; //2-dimension
      int[,,] a4 = new int[2, 3, 4]; //3-dimension

      int[,] a5 =
      {
        { 1, 2, 3 },
        { 4, 5, 6 }
      };
      int[,,] a6 =
      {
        {
          { 1, 2, 3, 4 },
          { 1, 2, 3, 4 },
          { 1, 2, 3, 4 }
        },
        {
          { 10, 20, 30, 40 },
          { 1, 2, 3, 4 },
          { 1, 2, 3, 4 }
        }
      };

      var x2 = a5[1, 1]; //5
      var x3 = a6[1, 0, 2]; //30

      // jagged arrays
      int[][] a7 = new int[3][];
      int[][] a8 =
      {
        new int[3],
        new int[] {1,2,3,4,5 },
        new int[25]
      };

      int[][,] a9 = new int[3][,];
    }

    /// <summary>
    /// 
    /// </summary>
    public void ListCollection()
    {
      List<int> c1 = new List<int>();
      List<int> c2 = new List<int> { 1, 2, 3, 4, 3 };

      c2.Add(5);
      c2.Remove(3);

      c2[10] = 5;
      c2.RemoveAll(i => i == 3);
      c2.RemoveRange(0, 2);
      c2.RemoveAt(10);
      c2.ElementAt(7);

      c2.Where((x) => x > 1 && x < 10);
    }

    /// <summary>
    /// 
    /// </summary>
    public void DictionaryCollection()
    {
      Dictionary<string, string> d1 = new Dictionary<string, string>();
      Dictionary<string, string> d2 = new Dictionary<string, string>
      {
        {"fred", "trainer" },
        {"rami", "associate" }
      };

      d2["skyler"] = "associate"; // overwrite current value.

      if (!d2.ContainsKey("skyler"))
      {
        d2.Add("skyler", "associate");
      }

      try
      {
        d2.Add("skyler", "associate");
      }
      catch (ArgumentException ex)
      {
        d2["skyler"] = "associate";
      }
      catch (Exception ex)
      {
        throw new Exception("something happened, call me later", ex);
      }
      finally
      {
        GC.Collect();
      }
    }
  }
}