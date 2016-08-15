using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using UniversityCRMSApp.Models;
using UniversityCRMSAppWeb.Models;

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
        public List<DepartmentModel> GetAllDepartment()
        {
            SqlConnection con = new SqlConnection(connectinDB);
            string query = "SELECT DepartmentId,Name FROM Depatment";
            SqlCommand cmd = new SqlCommand(query, con);
            List<DepartmentModel> departmentsList = new List<DepartmentModel>();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DepartmentModel department = new DepartmentModel();
                    department.DepartmentId = int.Parse(reader["DepartmentId"].ToString());
                    department.DepartmentName = reader["Name"].ToString();
                    departmentsList.Add(department);
                }
                reader.Close();
            }
            con.Close();
            return departmentsList;
        }
        public List<SemesterModel> GetAllSemester()
        {
            SqlConnection con = new SqlConnection(connectinDB);
            string query = "SELECT SemesterId,SemisterName FROM Semester";
            SqlCommand cmd = new SqlCommand(query, con);
            List<SemesterModel> semesterlList = new List<SemesterModel>();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SemesterModel semester = new SemesterModel();
                    semester.Id = int.Parse(reader["SemesterId"].ToString());
                    semester.Semester = reader["SemisterName"].ToString();
                    semesterlList.Add(semester);
                }
                reader.Close();
            }
            con.Close();
            return semesterlList;
        }
    }
}
