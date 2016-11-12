using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Model
{
  public class Category
  {
    /// <summary>
    /// 
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string CatgName { get; set; }



    /// <summary>
    /// 
    /// </summary>
    public string Descr { get; set; }


    public void ProductModel() {
      CatgName = string.Empty;
      Descr = string.Empty;
  }
  }
}
