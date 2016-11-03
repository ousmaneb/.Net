using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoApp.Data
{
  public class PersonDAO
  {

    public string FirtsName{ get; set; }
    public string LastName { get; set; }
    //public string MiddleName { get; set; }

    public PersonDAO(string first, string last)
    {
      FirtsName = first;
      LastName = last;
    }
  }
}
