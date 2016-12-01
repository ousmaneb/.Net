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


      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      Application.Run(new France_Index());


      //MessageBox.Show(World.tCity.Length.ToString());



      //public static void Main(string[] arg)
      //{
      //  //World map = new World();
      //  //City [] t = map.Load("C:/Users/Barry/Documents/GitHub/DotNet Workspace/EBS/FranceMap/France/Files/city.txt");
      //  //for (var i = 0; i < t.Length; i++)
      //  //  Console.WriteLine(t[i]);
      //  //Console.ReadKey();


      //  World w = new World();
      //  var t = w.LoadCities("C:/Users/Barry/Documents/GitHub/DotNet Workspace/EBS/FranceMap/France/Files/city.txt");

      //  for (var i = 0; i < t.Count; i++)
      //    Console.WriteLine(t[i]);
      // Console.ReadKey();

      //}
  
    }
  }
}
