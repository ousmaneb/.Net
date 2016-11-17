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
    class Member_DAL
    {
        public static bool Insert(MemberModel obj)
        {
            bool result = false;
            SqlConnection conn = null;
            try
            {
                string conStr = DbHelper.GetConnectionString();
                string query = "usp_Member_Insert";
                conn = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("FName", obj.FirstName);
                cmd.Parameters.AddWithValue("LName", obj.FirstName);
                cmd.Parameters.AddWithValue("DOB", obj.Dob);
                cmd.Parameters.AddWithValue("Gender", obj.Gender);
                cmd.Parameters.AddWithValue("UserName", obj.Username);
                cmd.Parameters.AddWithValue("Plan_id", obj.PlanId);

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

        public static ICollection<MemberModel> GetAll()
        {
            ICollection<MemberModel> results = new List<MemberModel>();
            string conStr = DbHelper.GetConnectionString();
            string query = "usp_Member_Retrieve";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = null;
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MemberModel obj = new MemberModel();
                    obj.MemberId = Convert.ToInt32(dr["Mem_id"]);
                    obj.FirstName = dr["FName"].ToString();
                    obj.Lastname = dr["LName"].ToString();
                    obj.Dob = dr["DOB"].ToString();
                    obj.Gender = dr["Gender"].ToString();
                    obj.PlanId = Convert.ToInt32(dr["Plan_id"]);
                    results.Add(obj);
                }
            }

            return results;

        }

    }
}
