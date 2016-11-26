using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PMCLibrary.BAL.Model;
using PMCLibrary.Helper;

namespace PMCLibrary.DAL
{
  public class Plan_DAL
  {
    public static bool Insert(PlanModel o)
    {
      var result = false;
      SqlConnection conn = null;
      try
      {
        var conStr = DbHelper.GetConnectionString();
        var query = "usp_Plan_Insert";

        conn = new SqlConnection(conStr);
        var cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("Plan_Name", o.PlanName);
        cmd.Parameters.AddWithValue("Plan_Descr", o.Descr);
        cmd.Parameters.AddWithValue("Plan_DectValue", o.DetuctibleValue);

        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();

        result = cmd.ExecuteNonQuery() > 0 ? true : false;
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


    public static bool Update(PlanModel obj)
    {
      var result = false;
      SqlConnection conn = null;
      try
      {
        var conStr = DbHelper.GetConnectionString();
        var query = "usp_Plan_Update";
        conn = new SqlConnection(conStr);
        var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Plan_id", obj.PlanId);
        cmd.Parameters.AddWithValue("@Plan_Name", obj.PlanName);
        cmd.Parameters.AddWithValue("@Plan_Descr", obj.Descr);
        cmd.Parameters.AddWithValue("@Plan_DectValue", obj.DetuctibleValue);

        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        result = cmd.ExecuteNonQuery() > 0 ? true : false;
        conn.Close();
      }

      catch (Exception ex)
      {
        Console.WriteLine("An error occurred to update: '{0}'", ex);
      }
      finally
      {
        if (conn != null)
          conn.Close();
      }
      return result;
    }




    public static bool Delete(int id)
    {
      var result = false;
      SqlConnection conn = null;
      try
      {
        var conStr = DbHelper.GetConnectionString();
        var query = "usp_Plan_Delete";
        conn = new SqlConnection(conStr);
        var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Plan_id", id);
        cmd.Parameters.AddWithValue("@Plan_Name", id);
        cmd.Parameters.AddWithValue("@Plan_Descr", id);
        cmd.Parameters.AddWithValue("@Plan_DectValue", id);

        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        result = cmd.ExecuteNonQuery() > 0 ? true : false;
        conn.Close();
      }

      catch (Exception ex)
      {
        Console.WriteLine("An error occurred to delete: '{0}'", ex);
      }
      finally
      {
        if (conn != null)
          conn.Close();
      }
      return result;
    }





    public static ICollection<PlanModel> GetAll()
    {
      ICollection<PlanModel> results = new List<PlanModel>();
      var conStr = DbHelper.GetConnectionString();
      var query = "usp_Plan_GetAll";
      using (var conn = new SqlConnection(conStr))
      {
        var cmd = new SqlCommand(query, conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = null;
        conn.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
          var obj = new PlanModel();
          obj.PlanId = Convert.ToInt32(dr["Plan_id"]);
          obj.PlanName = dr["Plan_Name"].ToString();
          obj.Descr = dr["Plan_Descr"].ToString();
          obj.DetuctibleValue = Convert.ToDouble(dr["Plan_DectValue"]);
          results.Add(obj);
        }
      }

      return results;
    }
  }
}