using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfApp.Data;

namespace EfApp.Domain
{
  public static class DomainHelper
  {
    public static void AddPerson(PersonDTO p)
    {
      var person = new Person();

      person.FirstName = p.FirstName;
      person.LastName = p.LastName;

      DataHelper.AddPerson(person);
    }

    public static void AddAddress(AddressDTO a)
    {

    }
  }
}