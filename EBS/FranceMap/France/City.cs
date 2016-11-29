using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France
{
  public class City
  {
   
    private int  NCities;
    private City [] Cities;
    private int[] Distances;


    public City(string name, int code, int longitude, int latitue)
    {
      Name = name;
      Code = code;
      Longitude = longitude;
      Latitude = latitue;
      NCities = 0;
      Cities = new City[10];
      Distances = new int[10];
    }

    public string Name { get; set; }
    public int Code { get; set; }
    public int Longitude { get; set; }
    public int Latitude { get; set; }


    public void AddRoute(int distance, City city)
    {
      Distances[NCities] = distance;
      Cities[NCities] = city;
      NCities++;
    }
  }
}
