using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.AddressBookServiceReference;
using WebApp.Domain.Mappers;
using WebApp.Domain.Models;

namespace WebApp.Domain
{
  /// <summary>
  /// 
  /// </summary>
  public class DomainHelper
  {
    private static AddressBookClient client = new AddressBookClient();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<bool> AddContactAsync(Contact contact)
    {
      var c = ObjectMapper.MapContactToContactDTO(contact);
      
      return await Task.Run(() => client.AddContactTask(c));
    }

    /// <summary>
    /// 
    /// </summary>
    public void DeleteContact()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public void GetContact()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public void UpdateContact()
    {

    }
  }
}
