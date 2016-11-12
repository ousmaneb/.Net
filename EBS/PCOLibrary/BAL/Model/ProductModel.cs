using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Model
{
  public class ProductModel
  {
    /// <summary>
    /// 
    /// </summary>
    public int ProductId { get; set; }


    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int Qty { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double UnitPrice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Descr { get; set; }


    /// <summary>
    /// 
    /// </summary>
    public int CategoryID { get; set; }

    public ProductModel()
    {
      Name = string.Empty;
      Descr = string.Empty;
    }

    public ProductModel(int catgId, string name, string descr, double price)
    {
      CategoryID = catgId;
      Name = name;
      Descr = descr;
      UnitPrice = price;
    }

  }

}
