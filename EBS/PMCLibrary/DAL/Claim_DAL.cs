﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMCLibrary.BAL.Model;
using PMCLibrary.Helper;

namespace PMCLibrary.DAL
{
  class Claim_DAL
  {
    public static bool Insert(ClaimModel obj)
    {
      bool result = false;
      SqlConnection conn = null;
      try
      {
        string conStr = DbHelper.GetConnectionString();
        string query = "usp_Claim_Insert";
        conn = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("Mem_id", obj.MemberId);
        cmd.Parameters.AddWithValue("Claim_Date", obj.ClaimDate);
        cmd.Parameters.AddWithValue("Due_Date", obj.DueDate);
        cmd.Parameters.AddWithValue("Claim_Amount", obj.ClaimAmount);
     
      

        cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        
        public static bool Update(ClaimModel obj)
        {
            bool result = false;
            SqlConnection conn = null;
            try
            {
                string conStr = DbHelper.GetConnectionString();
                string query = "usp_Claim_Update";
                conn = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Claim_Date", obj.ClaimDate);
                cmd.Parameters.AddWithValue("@Due_Date", obj.DueDate);
                cmd.Parameters.AddWithValue("@Claim_Amount", obj.ClaimAmount);
                cmd.Parameters.AddWithValue("@Claim_id", obj.ClaimId);
                cmd.Parameters.AddWithValue("@Mem_id", obj.MemberId);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                result = cmd.ExecuteNonQuery() > 0 ? true : false;
                conn.Close();
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
        

        public static ICollection<ClaimModel> GetAll()
    {
      ICollection<ClaimModel> results = new List<ClaimModel>();
      string conStr = DbHelper.GetConnectionString();
      string query = "usp_Claim_Retrieve";
      using (SqlConnection conn = new SqlConnection(conStr))
      {
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        SqlDataReader dr = null;
        conn.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
         ClaimModel obj = new ClaimModel();
          obj.ClaimId = Convert.ToInt32(dr["Claim_id"]);
          obj.MemberId = Convert.ToInt32(dr["Mem_id"]);
          obj.ClaimDate = dr["Claim_Date"].ToString();
          obj.DueDate = dr["Due_Date"].ToString();
          obj.ClaimAmount = Convert.ToDouble(dr["Claim_Amount"]);
          obj.Member.FirstName = dr["FName"].ToString();
          obj.Member.Lastname = dr["LName"].ToString();

          results.Add(obj);
        }
      }

      return results;

    }
  }
}