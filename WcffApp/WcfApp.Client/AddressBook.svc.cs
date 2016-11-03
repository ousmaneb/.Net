using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfApp.Client.Models;
using WcfApp.Data;

namespace WcfApp.Client
{
  /// <summary>
  /// 
  /// </summary>
  public class AddressBook : IAddressBook
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    public bool AddContact(ContactDTO contact)
    {
      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    public async Task<bool> AddContactTask(ContactDTO contact)
    {
      var c = ObjectMapper.MapToContactDAO(contact);

      return await Task.Run(() => { return DataHelper.AddContact(c); });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    public bool DeleteContact(ContactDTO contact)
    {
      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    public async Task<bool> DeleteContactTask(ContactDTO contact)
    {
      return await Task.Run(() => { return true; });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    public bool DeleteContactById(int id)
    {
      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteContactByIdTask(int id)
    {
      return await Task.Run(() => { return true; });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ContactDTO GetContact(int id)
    {
      return new ContactDTO();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<ContactDTO> GetContactTask(int id)
    {
      return await Task.Run(() => { return new ContactDTO(); });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    public bool UpdateContact(ContactDTO contact)
    {
      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    public async Task<bool> UpdateContactTask(ContactDTO contact)
    {
      return await Task.Run(() => { return true; });
    }
  }
}
