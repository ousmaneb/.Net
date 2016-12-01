using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace France
{
  public class World
  {
    private string Name;
    public int nb=1;
    private int Code, Longitude, Latitude;
    public static City[] tCity;
    private City city;
    // private Route[] routes;





    public List<City> LoadCities(string file)
    {
      List<City> cityCollection = new List<City>();

      //int nb = 0; 
      
     

      using (var f = new StreamReader(file))
      {
        string line = string.Empty;
        while ((line = f.ReadLine()) != null)
        {
          var st = line.Split(';');
          cityCollection.Add(new City(Convert.ToString(st[0]), Convert.ToInt32(st[1]), Convert.ToInt32(st[2]), Convert.ToInt32(st[3])));
          
        }
      }
      Console.WriteLine("The number of cities is: " + cityCollection.Count);
      Console.WriteLine("Loading Finished! ");
      Console.WriteLine();
      Console.WriteLine();
      return cityCollection;
    }

    //public City[] Load(String file)
    //{
    //  TextFile tf = new TextFile(file);
    //  int nb = tf.GetSize();

    //  Console.WriteLine("Number of the cities in the file city.txt: " + nb);
    //  City [] tCity = new City[nb];

    //  for (int i = 0; i < nb; i++)
    //  {
    //    using (var f = new StreamReader(file))
    //    {
    //      string line = string.Empty;
    //      while ((line = f.ReadLine()) != null)
    //      {
    //        var st = line.Split(';');
    //        Name = Convert.ToString(st[0]);
    //        Code = Convert.ToInt32(st[1]);
    //        Longitude = Convert.ToInt32(st[2]);
    //          Latitude = Convert.ToInt32(st[3]);
            
    //      }
    //    }
    //    tCity[i] = new City(Name, Code, Longitude, Latitude);

    //  }

    // Console.WriteLine("Loading Finished! ");
    //  return tCity;
    //}

    public void LoadRoute(string file)
    {
      TextFile tf = new TextFile(file);
      Route [] routes = new Route[tf.GetSize()];
      //int r = 0;

      for (int i = 0; i < tf.GetSize(); i++)
      {
        String readline = tf.GetLine(i);
        var st = readline.Split(';');
        int cityA = Convert.ToInt32(st[0]);
        int cityB = Convert.ToInt32(st[1]);
        int distance = Convert.ToInt32(st[2]);
        Console.WriteLine((1 + i) + "/" + tf.GetSize());
        City citA = null;
        City citB = null;
        int j = 0;
        while ((citA == null || citB == null) && j < tCity.Length)
        {
          if (tCity[j].Code== cityA)
          {
            citA = tCity[j];
          }
          else if (tCity[j].Code == cityB)
          {
            citB = tCity[j];
          }
          j++;
        }
      }

    }


    public City GetCityByName(string cityname)
    {
      int i = 0;
      bool find = false;
      while (!find && i < nb)
      {
        if (string.Equals(tCity[i].Name.ToLower(),cityname.ToLower()))
          city = new City(tCity[i].Name, tCity[i].Code, tCity[i].Longitude, tCity[i].Latitude);
        else
          i++;
      }
      return city;
    }


    public City GetCityByPosition(int x, int y)
    {
      for (int i = 0; i < tCity.Length; i++)
      {
        Rectangle rec = new Rectangle(tCity[i].Latitude, tCity[i].Longitude, 4, 4);
        if (rec.Contains(new Point(x, y)))
          return tCity[i];
      }
      return null;
    }




  }
}
