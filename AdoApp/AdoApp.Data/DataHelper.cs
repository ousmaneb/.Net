using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoApp.Data
{
  /// <summary>
  /// 
  /// </summary>
  public static class DataHelper
  {
    private static string db = ConfigurationManager.ConnectionStrings["persondb"].ConnectionString;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="p"></param>
    public static void AddPerson(PersonDAO p)
    {
      SqlCommand command = new SqlCommand("insert into addressbook.person(firstname, lastname) values(@first, @last)");

      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        command.Parameters.Add(new SqlParameter("first", p.FirtsName));
        command.Parameters.Add(new SqlParameter("last", p.LastName));
        command.ExecuteNonQuery();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    public static void AddAddress(AddressDAO a)
    {
      SqlCommand command = new SqlCommand("insert into addressbook.address(street, city, state, zipcode) values(@s, @c, @st, @z)");

      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        command.Parameters.Add(new SqlParameter("s", a.Street));
        command.Parameters.Add(new SqlParameter("c", a.City));
        command.Parameters.Add(new SqlParameter("st", a.State));
        command.Parameters.Add(new SqlParameter("z", a.Zipcode));
        command.ExecuteNonQuery();
      }
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static List<PersonDAO> GetAllPeopleAdapter()
    {
      var people = new List<PersonDAO>();
      var command = new SqlCommand("select * from addressbook.person;");
      var da = new SqlDataAdapter();
      var ds = new DataSet();

      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        da.SelectCommand = command;
        da.Fill(ds);
      }

      foreach (DataRow row in ds.Tables[0].Rows)
      {
        people.Add(new PersonDAO(row["firstname"].ToString(), row["lastname"].ToString()));
      }

      return people;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static List<PersonDAO> GetAllPeopleReader()
    {
      var people = new List<PersonDAO>();
      var command = new SqlCommand("select * from addressbook.person;");
      SqlDataReader dr;

      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        dr = command.ExecuteReader();
      }

      while (dr.Read())
      {
        people.Add(new PersonDAO(dr["firstname"].ToString(), dr["lastname"].ToString()));
      }
      dr.Close();
      return people;
    }
  }
}