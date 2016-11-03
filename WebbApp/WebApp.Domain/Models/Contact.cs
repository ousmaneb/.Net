using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Models
{
  public class Contact
  {
    public string First { get; set; }
    public string Last { get; set; }
    public string Address { get; set; }

    public Contact(string first, string last, string address)
    {
      First = first;
      Last = last;
      Address = address;
    }
  }
}
