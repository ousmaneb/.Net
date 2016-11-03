using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfApp.Client.Models;
using WcfApp.Data;
using WcfApp.Data.Models;

namespace WcfApp.Client
{
  /// <summary>
  /// 
  /// </summary>
  internal static class ObjectMapper
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    public static ContactDAO MapToContactDAO(ContactDTO contact)
    {
      var c = new ContactDAO();

      c.Person = new Person()
      {
        FirstName = contact.FirstName,
        LastName = contact.LastName
      };

      c.Address = new Address()
      {
        Street = contact.Address.StreetName,
        City = contact.Address.CityName,
        State = contact.Address.State.ToString(),
        Zipcode = contact.Address.ZipCode
      };

      return c;
    }
  }
}
