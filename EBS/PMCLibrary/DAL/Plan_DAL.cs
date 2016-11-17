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
            string conStr = DbHelper.GetConnectionString();
            string query = "usp_Plan_GetAll";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = null;
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PlanModel obj = new PlanModel();
                    obj.PlanId = Convert.ToInt32(dr["Plan_id"]);
                    obj.PlanName = dr["Plan_Name"].ToString();
                    obj.Descr = dr["Plan_Descr"].ToString();
                    results.Add(obj);
                }
            }

            return results;

        }
    }
}