using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
  public class Dates
  {
    public Dates(int month, int day, int year)
    {
      Month = month;
      Day = day;
      Year = year;
    }
    

    public int Month { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }

    public string DateDisplay(int m, int d, int y)
    {
      string disp = m+"/"+d+"/"+y;

      return disp;
    }


  }
}
