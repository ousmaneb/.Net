using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  /// <summary>
  /// define a person object.
  /// </summary>
  public partial class Person
  {
    private string _FirstName = string.Empty;
    private string _LastName = string.Empty;
    private string _PhoneNumber = string.Empty;

    /// <summary> 
    /// 
    /// </summary>
    /// <param name="container"></param>
    /// <param name="value"></param>
    partial void ValidateNameString(ref string container, string value);

    /// <summary>
    /// 
    /// </summary>
    public string FirstName
    {
      get
      {
        return _FirstName;
      }

      set
      {
        
        ValidateNameStringUsingOut(value, out _FirstName);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public string LastName
    {
      get
      {
        return _LastName;
      }

      set
      {
        ValidateNameString(ref _LastName, value);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public string PhoneNumber
    {
      get
      {
        return _PhoneNumber;
      }

      set
      {
        _PhoneNumber = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public Location Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Person()
    {
      Initialize(address: new Location());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="phoneNumber"></param>
    public Person(string firstName, string lastName)
    {
      Initialize(firstName: firstName, lastName: lastName, address: new Location());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="phoneNumber"></param>
    public Person(string firstName, string lastName, string phoneNumber)
    {
      Initialize(firstName: firstName, lastName: lastName, phoneNumber: phoneNumber, address: new Location());
    }
  }
}