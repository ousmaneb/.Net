using System;
using Employee;
using Date;
using Books;
using SavingAccount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeTest1
{
  [TestClass]
  public class UnitTest1
  {

    /*
    [TestMethod]
    public void Employee_test()
    {
      //Arrange
      //Employees obj = new Employees();
      Employees obj1 = new Employees("Ousmane", "Barry", 250.00);
      Employees obj2 = new Employees("Sow", "Alpha", 350.00);

      //Act
      double exp1_salary = 250.00;
      double exp2_salary = 350.00;

      double act1_salary = obj1.Monthly;
      double act2_salary = obj2.Monthly;

      //Assert
      Assert.AreEqual(exp1_salary, act1_salary);
      Assert.AreEqual(exp2_salary, act2_salary);
      ////////////////////////////////////////////////////////
      double exp3_salary = 275.00;
      double exp4_salary = 385.00;

      double act3_salary = obj1.GetMonthlyRaise(250);
      double act4_salary = obj2.GetMonthlyRaise(350);

      Assert.AreEqual(exp3_salary, act3_salary);
      Assert.AreEqual(exp4_salary, act4_salary);
    }
 

    [TestMethod]
    public void Date_test()
    {
      Dates d1 = new Dates(11, 14, 2016);

      string s = "11/14/2016";
      string s1 = d1.DateDisplay(11, 14, 2016);

      Assert.AreEqual(s1, s);
    }
    */

    [TestMethod]
    public void Book_test()
    {

      Book bk = new Book(1, "C#", "Hello", "World");

      int isb = bk.ISBN;
      string b = bk.BookName;
      string a = bk.AuthorName;
      string p = bk.Publisher;


      int isb_exp = 1;

      Assert.AreEqual(isb, isb_exp);

    }
    
  }
}
