using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfApp.Client.Models;

namespace WcfApp.Client
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IAddressBook" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select IAddressBook.svc or IAddressBook.svc.cs at the Solution Explorer and start debugging.
  public class AddressBook : IAddressBook
  {
    //public void DoWork()
    //{
    //}

    public void AddContact(ContactDTO contact, AddressDTO address)
    {
      throw new NotImplementedException();
    }

    public void UpdateContact()
    {
      throw new NotImplementedException();
    }

    public void GetContact()
    {
      throw new NotImplementedException();
    }

    public void DeleteContact()
    {
      throw new NotImplementedException();
    }





    public bool AddContact(ContactDTO contact)
    {
      throw new NotImplementedException();
    }

    public bool UpdateContact(ContactDTO contact)
    {
      throw new NotImplementedException();
    }

    public ContactDTO GetContact(int id)
    {
      return new ContactDTO();
    }

    public bool DeleteContactById(int id)
    {
      return true;
    }

    public bool DeleteContactByContact(ContactDTO contact)
    {
      return true;
    }

    void IAddressBook.DeleteContactById(int id)
    {
      throw new NotImplementedException();
    }

    void IAddressBook.DeleteContactByContact(ContactDTO contact)
    {
      throw new NotImplementedException();
    }
  }
}
