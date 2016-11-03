using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  abstract class Class1
  {
    public int i;
    public virtual string BobsName()
    {
      return "Bob";
    }

    public abstract string JohnsName();
  }
  abstract class Class2
  {
    public int i;
    public virtual string BobsName()
    {
      return "Bob";
    }

    public abstract string JohnsName();
  }
 

  interface IIterface
  {
    //int i; Feilds not allowed in Interfaces
    string BobsName();
  }

  interface IIterface2
  {
    //int i; Feilds not allowed in Interfaces
    string Bob4sName();
  }
  interface IIterface3
  {
    //int i; Feilds not allowed in Interfaces
    string Bo3bsName();
  }
  interface IIterface4
  {
    //int i; Feilds not allowed in Interfaces
    string B2obsName();
  }

  class Alex : Class1, IIterface, IIterface2, IIterface3, IIterface4
  {
    public string B2obsName()
    {
      throw new NotImplementedException();
    }

    public string Bo3bsName()
    {
      throw new NotImplementedException();
    }

    public string Bob4sName()
    {
      throw new NotImplementedException();
    }

    public override string JohnsName()
    {
      throw new NotImplementedException();
    }
  }
}
