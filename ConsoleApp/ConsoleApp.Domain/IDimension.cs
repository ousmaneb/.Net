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
  public interface IDimension
  {
    /// <summary>
    /// 
    /// </summary>
    int Edges { get; set; }

    /// <summary>
    /// 
    /// </summary>
    int Faces { get; set; }
  }
}