using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoApp.Data
{
  public class AddressDAO
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zipcode { get; set; }

    public AddressDAO(string s, string c, string st, string z)
    {
      Street = s;
      City = c;
      State = st.Substring(0, 2);
      Zipcode = z;
    }
  }
}