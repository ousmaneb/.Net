using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfApp.Client.Models
{
  public class AddressDTO
  {
    public string StreetName { get; set; }
    public string CityName { get; set; }
    public StateCodeDTO State { get; set; }
    public int ZipCode { get; set; }
  }
}