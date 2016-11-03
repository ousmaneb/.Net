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
  public partial class Location
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="street"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    /// <param name="zipcode"></param>
    partial void Initialize(string street = null, string city = null, string state = null, string zipcode = null)
    {
      Street = street;
      City = city;
      State = state;
      Zipcode = zipcode;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return string.Format("{0}\n{1}, {2} {3}", Street, City, State, Zipcode);
    }
  }
}