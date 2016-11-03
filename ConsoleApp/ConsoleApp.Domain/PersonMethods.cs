using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  /// <summary>
  /// 
  /// </summary>
  public partial class Person
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="container"></param>
    /// <param name="value"></param>
    partial void ValidateNameString(ref string container, string value)
    {
      if (Regex.IsMatch(value, @"[a-zA-Z\s]+"))
      {
        container = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="container"></param>
    private void ValidateNameStringUsingOut(string value, out string container)
    {
      container = string.Empty;

      if (Regex.IsMatch(value, @"[a-zA-Z\s]+"))
      {
        container = value;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="phoneNumber"></param>
    /// <param name="address"></param>
    private void Initialize(string firstName = null, string lastName = null, string phoneNumber = null, Location address = null)
    {
      FirstName = firstName;
      LastName = lastName;
      PhoneNumber = phoneNumber;
      Address = address;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
      var p = obj as Person; // if false, returns null.
      var p1 = (Person)obj; // if false, throws exception.

      return p != null
        ? FirstName == p.FirstName && LastName == p.LastName && PhoneNumber == p.PhoneNumber
        : false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return string.Format
        (
          "{0} {1}\n{2}\n{3}\n{4}\n{5}, {6}",
          FirstName,
          LastName,
          PhoneNumber,
          Address.Street,
          Address.City,
          Address.State,
          Address.Zipcode
        );
    }
  }
}