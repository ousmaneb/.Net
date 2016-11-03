using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfApp.Data.Models;

namespace WcfApp.Data
{
  public static class DataHelper
  {
    private static February2016Entities db = new February2016Entities();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="contact"></param>
    /// <returns></returns>
    public static bool AddContact(ContactDAO contact)
    {
      var p = new PersonAddress() { Person = contact.Person, Address = contact.Address };

      db.PersonAddresses.Add(p);

      return db.SaveChanges() == 3;
    }
  }
}
