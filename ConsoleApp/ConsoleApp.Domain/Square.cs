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
  public class Square : Rectangle
  {
    /// <summary>
    /// 
    /// </summary>
    public override double Width
    {
      get
      {
        return Length;
      }

      set
      {
        Length = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public Square()
    {
      
    }
  }
}