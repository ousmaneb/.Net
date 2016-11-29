using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace France
{
  static class Program
  {
    //  /// <summary>
    //  /// The main entry point for the application.
    //  /// </summary>
    [STAThread]
    static void Main()
    {
      World w = new World();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Application.Run(new France_Index());

      //MessageBox.Show(World.tCity.Length.ToString());

      Console.WriteLine(w.Load("city.txt"));
     

      //for (int i = 0; i < World.tCity.Length; i++)
      //{
      //  MessageBox.Show(World.tCity[i].ToString());
      //}
      
      //Console.ReadLine();




    }
  }


  //class Program
  //{
  //  static void Main()
  //  {
  //    World w = new World();

  //    Console.WriteLine(w.Load("city.txt"));
  //    Console.ReadLine();
  //  }
  }
