using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  public struct Point
  {
    public static Person p = new Person();

    /// <summary>
    /// 
    /// </summary>
    public int XCoord { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int YCoord { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public Point(int x, int y)
    {
      XCoord = x;
      YCoord = y;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double Distance()
    {
      return Math.Sqrt(Math.Pow(XCoord, 2) + Math.Pow(YCoord, 2));
    }

  }
}