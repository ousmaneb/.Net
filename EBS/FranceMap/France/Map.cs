using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France
{
  public class Map
  {
  
    private City citySelected;
    private City [] t;
    public Map(World france)
    {
     
      var t = france.LoadCities("C:/Users/Barry/Documents/GitHub/DotNet Workspace/EBS/FranceMap/France/Files/city.txt");
    }

    public void paint(Graphics g)
    {
      paint(g);
      Font f = new Font("Time New Roman", 12);
      g.DrawString(null, new Font("Time New Roman", 12), Brushes.Black,10,25);
      if ( citySelected!= null)
      {
        for (int i = 0; i < t.Length; i++)
        {
          if (string.Equals(t[i].Name.ToLower(),citySelected.Name.ToLower()))
          {
           
            g.DrawString(t[i].Name, new Font("Time New Roman", 12), Brushes.Red, t[i].Longitude, t[i].Latitude);
            //g.FillRectangles(Brushes.Black,);
          }
          else
          {
            g.DrawString(t[i].Name, new Font("Time New Roman", 12), Brushes.Black, t[i].Longitude-25, t[i].Latitude-2);
            //g.FillRectangle(t[i].Longitude, t[i].Latitude, 2, 2);
          }
        }
      }
      else
      {
        for (int i = 0; i < t.Length; i++)
        {
          g.DrawString(t[i].Name, new Font("Time New Roman", 12), Brushes.Red, t[i].Longitude-25, t[i].Latitude);
          //g.FillRectangle(t[i].Longitude, t[i].Latitude, 2, 2);
        }
      }


    }

    public void update(Graphics g)
    {
      update(g);
      paint(g);
    }
    public City getCitySelected()
    {
      return citySelected;
    }

    public void setCitySelected(City cityselected)
    {
      citySelected = cityselected;
    }
  }
}

