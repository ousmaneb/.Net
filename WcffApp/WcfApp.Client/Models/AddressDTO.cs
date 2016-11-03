using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfApp.Client.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class AddressDTO
  {
    public string StreetName { get; set; }
    public string CityName { get; set; }
    public StateCodeDTO State { get; set; }
    public string ZipCode { get; set; }
  }
}
