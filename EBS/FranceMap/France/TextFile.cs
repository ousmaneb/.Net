using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace France
{
  class TextFile
  {

    private int s_size;
    private String [] lines;

    public TextFile(String s)
    {
      try
      {
        using (StreamReader sr = new StreamReader(s))
        {
          ArrayList arraylist = new ArrayList();
          String s1;
          while ((s1 = sr.ReadLine()) != null)
            arraylist.Add(s1);
          s_size = arraylist.Count;
          lines = (string[])arraylist.ToArray(new String[0].GetType());
          sr.Close();
        }

      }
      catch (Exception ex)
      {
        Console.WriteLine("Error to read the file"+ex);
        Application.Exit();
      }
    }

    public String GetLine(int i)
    {
      return lines[i];
    }

    public int GetSize()
    {
      return s_size;
    }

  }
}
