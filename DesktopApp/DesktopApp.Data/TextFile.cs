using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class TextFile
    {


      private string path = @"c:\eintern\person.txt";

      public void SaveText(string[] content)
      {
        File.WriteAllLines(path, content);
      }

      public string[] ReadText()
      {
      if (File.Exists(path))
        {
        return File.ReadAllLines(path);
      }
        return new string[] { };

      }
    }
}
