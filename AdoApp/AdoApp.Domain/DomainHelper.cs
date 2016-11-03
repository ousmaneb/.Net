using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoApp.Data;

namespace AdoApp.Domain
{
  /// <summary>
  /// 
  /// </summary>
  public static class DomainHelper
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="p"></param>
    public static void AddPerson(PersonDTO p)
    {
      var person = new PersonDAO(p.FirtsName, p.LastName);
      DataHelper.AddPerson(person);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    public static void AddAddress(AddressDTO a)
    {
      var address = new AddressDAO(a.Street, a.City, a.State, a.Zipcode);
      DataHelper.AddAddress(address);
    }
  }
}