using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCOLibraryTest.Types
{
  [TestClass]
  public class ReferenceTypeTests
  {

    [TestMethod]
    public void StringComparison()
    {
      string name1 = "Scott";
      string name2 = "scott";
      bool result = String.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
      Assert.IsTrue(result);

    }


    [TestMethod]
    public void IntVariablesHoldAValue()
    {
      int x1 = 100;
      int x2 = x1;

      x1 = 4;
      Assert.AreEqual(x1, x2);
    }

    [TestMethod]
    public void VariablesHoldAReference()
    {
      GradeBook g1 = new GradeBook();
      GradeBook g2 = g1;

      g1.Name = "Ousmane Barry's Book";
      Assert.AreEqual(g1.Name, g2.Name);
    }
  }
}
