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
    public string Street { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Zipcode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="street"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    /// <param name="Zipcode"></param>
    partial void Initialize(string street = null, string city = null, string state = null, string zipcode = null);

    /// <summary>
    /// 
    /// </summary>
    public Location()
    {
      Initialize();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="city"></param>
    /// <param name="state"></param>
    public Location(string city, string state)
    {
      Initialize(city: city, state: state);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="street"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    public Location(string street, string city, string state)
    {
      Initialize(street: street, city: city, state: state);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="street"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    /// <param name="zipcode"></param>
    public Location(string street, string city, string state, string zipcode)
    {
      Initialize(street: street, city: city, state: state, zipcode: zipcode);
    }
  }
}