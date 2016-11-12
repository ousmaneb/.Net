using PCOLibrary.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibrary.BAL.Actions
{
  public class ProductAction
  {
    public static bool Insert(ProductModel obj)
    {
      bool result = false;
      //todo insert logic.
      return result;
    }


    public static IEnumerable<ProductModel>GetAllProducts()
    {
      IEnumerable<ProductModel> result = null;

      //todo get logic
      return result;
    }

    public int UpdateProduct(ProductModel obj)
    {
      int result = 0;

      //todo update logic
      return result;
    }


    public int DeleteProduct(int id)
    {
      int result = 0;

      //todo delete logic
      return result;
    }


  }
}
