using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfApp.Domain
{
  public class PersonDTO
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public PersonDTO(string f, string l)
    {
      FirstName = f;
      LastName = l;
    }
  }
}