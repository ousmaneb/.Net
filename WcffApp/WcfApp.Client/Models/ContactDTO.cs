using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfApp.Client.Models
{
  public class ContactDTO
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public AddressDTO Address { get; set; }
  }
}
