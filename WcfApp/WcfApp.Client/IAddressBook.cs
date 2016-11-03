using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfApp.Client.Models;

namespace WcfApp.Client
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIAddressBook" in both code and config file together.
  [ServiceContract]
  public interface IAddressBook
  {

    [OperationContract]
    bool AddContact(ContactDTO contact);

    [OperationContract]
    bool UpdateContact(ContactDTO contact);

    [OperationContract]
    ContactDTO GetContact(int id);

    [OperationContract]
    void DeleteContactById(int id);


    [OperationContract]
    //[OperationBehavior()]
    void DeleteContactByContact(ContactDTO contact);
  }
}
