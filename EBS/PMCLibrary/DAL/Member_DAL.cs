using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PMCLibrary.BAL.Model;
using PMCLibrary.Helper;

namespace PMCLibrary.DAL
{
  internal class Member_DAL
  {
    public static bool Insert(MemberModel obj)
    {
      var result = false;
      SqlConnection conn = null;
      try
      {
        var conStr = DbHelper.GetConnectionString();
        var query = "usp_Member_Insert";
        conn = new SqlConnection(conStr);
        var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("FName", obj.FirstName);
        cmd.Parameters.AddWithValue("LName", obj.Lastname);
        cmd.Parameters.AddWithValue("DOB", obj.Dob);
        cmd.Parameters.AddWithValue("Gender", obj.Gender);
        cmd.Parameters.AddWithValue("UserName", obj.Username);
        cmd.Parameters.AddWithValue("Plan_id", obj.PlanId);

        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        result = cmd.ExecuteNonQuery() > 0 ? true : false;
        conn.Close();
      }

      catch (Exception ex)
      {
        Console.WriteLine("An error occurred to insert: '{0}'", ex);
      }
      finally
      {
        if (conn != null)
          conn.Close();
      }
      return result;
    }

    public static ICollection<MemberModel> GetAll()
    {
      ICollection<MemberModel> results = new List<MemberModel>();
      var conStr = DbHelper.GetConnectionString();
      var query = "usp_Member_Retrieve";
      using (var conn = new SqlConnection(conStr))
      {
        var cmd = new SqlCommand(query, conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = null;
        conn.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
          var obj = new MemberModel();
          obj.MemberId = Convert.ToInt32(dr["Mem_id"]);
          obj.FirstName = dr["FName"].ToString();
          obj.Lastname = dr["LName"].ToString();
          obj.Dob = dr["DOB"].ToString();
          obj.Gender = dr["Gender"].ToString();
          obj.Username = dr["UserName"].ToString();
          obj.Plan.PlanName = dr["Plan_Name"].ToString();
          results.Add(obj);
        }
      }

      return results;
    }
  }
}