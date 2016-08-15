using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using UniversityCRMSApp.Models;
using UniversityCRMSAppWeb.Models;

namespace UniversityCRMSApp.DAL
{
    class TeacherGateway
    {
        string connectinDB = WebConfigurationManager.ConnectionStrings["UniversityCRMS"].ConnectionString;
        public int SaveTeacher(TeacherModel teacher)
        {
            int rowAffected;
            SqlConnection con = new SqlConnection(connectinDB);
            string query = @"INSERT INTO Teacher (DesignationId,DepartmentId,TeacherName,Address,Email,ContactNo,CreditToBeTaken,InsertDate)
                            VALUES ('" + teacher.DesignationId + "','" + teacher.DepartmentId + "','" + teacher.TacherName + "','" + teacher.Address + "','" + teacher.Email + "','" + teacher.ContactNo + "','" + teacher.CreditToBeTaken + "',GETDATE())";
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

        public List<DesignationModel> GetAllDesignation()
        {
            SqlConnection con = new SqlConnection(connectinDB);
            string query = "SELECT DesignationId,DesignationName FROM Teacher.Designaion";
            SqlCommand cmd = new SqlCommand(query, con);
            List<DesignationModel> designationlList= new List<DesignationModel>();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DesignationModel designation = new DesignationModel();
                    designation.Id = int.Parse(reader["DesignationId"].ToString());
                    designation.Desognation = reader["DesignationName"].ToString();
                    designationlList.Add(designation);
                }
                reader.Close();
            }
            con.Close();
            return designationlList;
        }
    }
}
