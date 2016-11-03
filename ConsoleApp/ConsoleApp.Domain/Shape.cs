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
  public abstract class Shape : IForm
  {
    /// <summary>
    /// 
    /// </summary>
    public int NumberOfSides { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sides"></param>
    public Shape(int sides)
    {
      NumberOfSides = sides;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public abstract double Perimeter();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public abstract double Surface();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double Volume()
    {
      return 0;
    }
  }
}