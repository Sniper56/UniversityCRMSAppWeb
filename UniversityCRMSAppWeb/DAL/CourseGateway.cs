using System.Data.SqlClient;
using System.Web.Configuration;
using UniversityCRMSApp.Models;

namespace UniversityCRMSApp.DAL
{
    class CourseGateway
    {
        string connectinDB = WebConfigurationManager.ConnectionStrings["UniversityCRMS"].ConnectionString;
        public int SaveCourse(CourseModel course)
        {
            int rowAffected;
            SqlConnection con = new SqlConnection(connectinDB);
            string query = @"INSERT INTO Course (DepartmentId,SemesterId,CourseCode,CourseName,Credit,Description,InsertDate)
                            VALUES ('" + course.DepartmentId + "','" + course.SemesterId + "','" + course.CourseCode + "','" +course.CourseName + "','" + course.Credit + "','" +course.Description + "',GETDATE())";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowAffected;
        }
    }
}
