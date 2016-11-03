using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RegistrationApp.Domain;

namespace RegistrationApp.Data
{
  public class DataHelper
  {
    private static string db = ConfigurationManager.ConnectionStrings["RegistrationApp"].ConnectionString;

    public static void AddStudent(StudentDAO s)
    {
      SqlCommand command = new SqlCommand(
          "insert into Registration.Student (FirstName,LastName) values (@fn, @ln);");
      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        command.Parameters.Add(new SqlParameter("fn", s.FirstName));
        command.Parameters.Add(new SqlParameter("ln", s.LastName));
        command.ExecuteNonQuery();

        conn.Close();
      }
    }


    public static void AddCourse(CourseDAO c)
    {
      SqlCommand command = new SqlCommand(
          "insert into Registration.Course(CourseName,CourseDuration) values (@cn, @cd);");
      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        command.Parameters.Add(new SqlParameter("cn", c.CourseName));
        command.Parameters.Add(new SqlParameter("cd", c.CourseDuration));
        command.ExecuteNonQuery();

        conn.Close();
      }
    }

    public static void AddScheduleClass(ScheduleClassDAO c)
    {
      SqlCommand command = new SqlCommand(
          "insert into Registration.ScheduleClass(StartTime,CourseId) values (@st, @ci);");
      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        command.Parameters.Add(new SqlParameter("st", c.StartTime));
       command.Parameters.Add(new SqlParameter("ci", c.Course.CourseID));
        command.ExecuteNonQuery();

        conn.Close();
      }
    }

  
  
    public static void AddStudentSchedule(StudentScheduleDAO c)
    {
      SqlCommand command = new SqlCommand(
          "insert into Registration.StudentSchedule(StudentId,ScheduleClassId) values (@si, @sci);");
      using (var conn = new SqlConnection(db))
      {
        conn.Open();

        command.Connection = conn;
        command.Parameters.Add(new SqlParameter("si", c.StudentId));
        command.Parameters.Add(new SqlParameter("sci", c.CourseId));
        command.ExecuteNonQuery();

        conn.Close();
      }
    }


    public static List<StudentDAO> FindStudents(int? studentID = null, string fName = null, string lName=null)
    {
      var students = new List<StudentDAO>();
      var sql = string.Format("select * from Registration.Student where 1=1 {0} {1} {2};",
        studentID==null?"":"and studentID = "+studentID,
        fName==null?"":"and FirstName = "+fName,
        lName==null?"":"and LastName = "+lName
        );
      var command = new SqlCommand(sql);
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
        students.Add(new StudentDAO(row["FirstName"].ToString(), row["LastName"].ToString()));
      }

      return students;
    }


    public static List<CourseDAO> FindCourses(int? courseID = null, string cName = null)
    {
      var courses = new List<CourseDAO>();
      var sql = string.Format("select * from Registration.Course where 1=1 {0} {1};",
      courseID == null ? "" : "and courseID = " + courseID,
      cName == null ? "" : "and CourseName = " + cName
       );

      var command = new SqlCommand(sql);
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
        courses.Add(new CourseDAO((int) row["CourseId"], row["CourseName"].ToString()));
      }

      return courses;
    }



  }
}
