using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using UniversityCRMSApp.Models;

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
    }
}
