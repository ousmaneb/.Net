using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  public class Cube : IForm, IDimension
  {
    public int Edges
    {
      get
      {
        throw new NotImplementedException();
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public int Faces
    {
      get
      {
        throw new NotImplementedException();
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public double Perimeter()
    {
      throw new NotImplementedException();
    }

    public double Surface()
    {
      throw new NotImplementedException();
    }

    public double Volume()
    {
      throw new NotImplementedException();
    }
  }
}