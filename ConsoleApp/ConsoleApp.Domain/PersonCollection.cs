using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class PersonCollection<T> where T : Person
  {
    private List<T> book = new List<T>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="person"></param>
    public void AddPerson(T person)
    {
      book.Add(person);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="person"></param>
    public void RemovePerson(T person)
    {
      book.RemoveAll(p => p.Equals(person));
    }
  }
}