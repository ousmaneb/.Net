using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfApp.Client.Models;

namespace WcfApp.Client
{
  /// <summary>
  /// 
  /// </summary>
  [ServiceContract]
  public interface IAddressBook
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    [OperationContract]
    bool AddContact(ContactDTO contact);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    [OperationContract(AsyncPattern = true)]
    Task<bool> AddContactTask(ContactDTO contact);

    /// <summary>
    /// 
    /// </summary>
    [OperationContract]
    bool UpdateContact(ContactDTO contact);

    /// <summary>
    /// 
    /// </summary>
    [OperationContract(AsyncPattern = true)]
    Task<bool> UpdateContactTask(ContactDTO contact);

    /// <summary>
    /// 
    /// </summary>
    [OperationContract]
    ContactDTO GetContact(int id);

    /// <summary>
    /// 
    /// </summary>
    [OperationContract(AsyncPattern = true)]
    Task<ContactDTO> GetContactTask(int id);

    /// <summary>
    /// 
    /// </summary>
    [OperationContract]
    bool DeleteContactById(int id);

    /// <summary>
    /// 
    /// </summary>
    [OperationContract(AsyncPattern = true)]
    Task<bool> DeleteContactByIdTask(int id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    [OperationContract]
    bool DeleteContact(ContactDTO contact);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    [OperationContract(AsyncPattern = true)]
    Task<bool> DeleteContactTask(ContactDTO contact);
  }
}
