using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  /// <summary>
  /// a shape with 4 sides and 4 90deg angles.
  /// </summary>
  public class Rectangle : Shape
  {
    /// <summary>
    /// 
    /// </summary>
    public double Length { get; set; }
    

    /// <summary>
    /// 
    /// </summary>
    public virtual double Width { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Rectangle() : base(4)
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override double Perimeter()
    {
      return 2 * (Length + Width);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override double Surface()
    {
      return Length * Width;
    }
  }
}