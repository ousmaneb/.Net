using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France
{
  public class Route
  {
    public int CodeD { get; set; }
    public int CodeA { get; set; }
    public int Dist { get; set; }

    public Route(int coded, int codea, int dist)
    {
      CodeD = coded;
      CodeA = codea;
      Dist = dist;

    }
  }
}
