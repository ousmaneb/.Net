using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.AddressBookServiceReference;
using WebApp.Domain.Models;

namespace WebApp.Domain.Mappers
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
    public static ContactDTO MapContactToContactDTO(Contact contact)
    {
      var c = new ContactDTO();
      var a = contact.Address.Split(',');

      c.FirstName = contact.First;
      c.LastName = contact.Last;
      c.Address = new AddressDTO()
      {
        StreetName = a[0],
        CityName = a[1],
        State = (StateCodeDTO)Enum.Parse(typeof(StateCodeDTO), a[2]),
        ZipCode = a[3]
      };

      return c;
    }
  }
}
