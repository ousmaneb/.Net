using System;

using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace EmployeeTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void EmployeeT()
        {
      //Arrange
      Employee obj1 = new Employee("Ousmane", "Barry", 250);

      //Act
      bool result = Employee.GetMonthly(obj1);

      //Assert
      Assert.Equals(true, result);
    }
    }
}
