using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  public class Triangle : Shape
  {
    /// <summary>
    /// 
    /// </summary>
    public double SideA { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double SideB { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double SideC { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Triangle() : base(3)
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override double Perimeter()
    {
      return SideA + SideB + SideC;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double Surface(double height, double tBase)
    {
      return 0.5 * height * tBase;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override double Surface()
    {
      throw new NotImplementedException();
    }
  }
}