using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;

namespace PCOLibraryTest
{
  [TestClass]
  public class PCOProductActionTest
  {


    /*


[TestMethod]
public void ProductCreate_Test()
{
  //Arrange
  ProductModel obj2 = new ProductModel(1, "KitKat", "Snacks", 10);

  //Act
  bool result = ProductAction.Insert(obj2);

  //Assert
  Assert.Equals(true, result);

}

[TestMethod]
public void Arrange()
{

  ProductModel obj = new ProductModel();

  int sum = obj.ProductId + 1;
  int name = obj.Name.Length;

  ProductModel obj2 = new ProductModel(1, "KitKat", "Snacks", 10);

  //obj.Name = "KitKat"; //set
  //obj.Name = obj.Name; //get
  Assert.Equals(0, 0);
  //return obj;
}


[TestMethod]
public void CategoryGetCount_Test()
{
  //Arrange
  CustomerAction obj = new CustomerAction();
  IEnumerable<CustomerModel> categorymodel = new List<CustomerModel>();

  int count = obj.GetCount(categorymodel);

  Assert.AreEqual(0, count);
}

[TestMethod]
public void CustomerGetCount_Test()
{
  //Arrange
  CustomerAction obj = new CustomerAction();
  IEnumerable<CustomerModel> customermodel = new List<CustomerModel>();

  int count = obj.GetCount(customermodel);
  Assert.AreEqual(0, count);

}

[TestMethod]
public void CustomerActionAbstract_Test()
{
  Actions obj = new CustomerAction();
 Type t = obj.GetType();
}

[TestMethod]
public void CustomerActionInterface_Test()
{
  IAction obj = new OrderAction();
  Type t = obj.GetType();
  Assert.AreEqual(new OrderAction().GetType(), t);
 obj = new DummyAction();
  t = obj.GetType();
  Assert.AreEqual(new DummyAction().GetType(), t);

}


*/








[TestMethod]
public void ComputeHighestGrade()
{
  GradeBook book = new GradeBook();
  book.AddGrade(10);
  book.AddGrade(90);


  GradeStatistics result = book.ComputeStatistics();
  Assert.AreEqual(90, result.HighestGrade);
}


[TestMethod]
public void ComputeLowestGrade()
{
  GradeBook book = new GradeBook();
  book.AddGrade(10);
  book.AddGrade(90);


  GradeStatistics result = book.ComputeStatistics();
  Assert.AreEqual(10, result.LowestGrade);
}



[TestMethod]
public void ComputeAverageGrade()
{
  GradeBook book = new GradeBook();
  book.AddGrade(10);
  book.AddGrade(90);


  GradeStatistics result = book.ComputeStatistics();
  Assert.AreEqual(50, result.AverageGrade);
}





  }
}
