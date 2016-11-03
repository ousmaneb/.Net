using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoApp.Domain
{
  public class PersonDTO
  {
    public string FirtsName { get; set; }
    public string LastName { get; set; }
    //public string MiddleName { get; set; }

    public PersonDTO(string first, string last)
    {
      FirtsName = first;
      LastName = last;
    }
  }
}
