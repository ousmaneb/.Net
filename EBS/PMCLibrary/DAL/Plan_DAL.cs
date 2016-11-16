using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMCLibrary.BAL.Model;
using PMCLibrary.Helper;

namespace PMCLibrary.DAL
{
  class Plan_DAL
  {
    public static bool Insert(PlanModel o)
    {
      bool result = false;
      string conStr = DbHelper.GetConnectionString();
      string query = "usp_Plan_Insert";
      SqlConnection conn = new SqlConnection(conStr);
      SqlCommand cmd = new SqlCommand(query, conn);
      cmd.Parameters.AddWithValue("Name", o.PlanName);
      cmd.Parameters.AddWithValue("Descr", o.Descr);
      cmd.Parameters.AddWithValue("DectutibleValue", o.DetuctibleValue);
      cmd.CommandType = System.Data.CommandType.StoredProcedure;
      conn.Open();
      result = cmd.ExecuteNonQuery() > 0 ? true : false;
      conn.Close();
      return result;

    }
  }
}
