using System.Collections.Generic;
using UniversityCRMSApp.DAL;
using UniversityCRMSApp.Models;
using UniversityCRMSAppWeb.Models;

namespace UniversityCRMSApp.BLL
{
    class TeacherManager
    {
        TeacherGateway teacherGateway =new TeacherGateway();
        public int SaveTeacher(TeacherModel teacher)
        {
            return teacherGateway.SaveTeacher(teacher);
        }

        public List<DepartmentModel> GetAllDepartment()//load department to department dropdown list
        {
            return teacherGateway.GetAllDepartment();
        }

        public List<DesignationModel> GetTeacherDesignation()//load teacher designation to designatin dropdown list
        {
            return teacherGateway.GetTeacherDesignation();
        }
    }
}
