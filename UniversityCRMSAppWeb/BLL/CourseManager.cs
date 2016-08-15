using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCRMSApp.DAL;
using UniversityCRMSApp.Models;
using UniversityCRMSAppWeb.Models;

namespace UniversityCRMSApp.BLL
{
    class CourseManager
    {
        CourseGateway courseGateway=new CourseGateway();
        public int SaveCourse(CourseModel course)
        {
            return courseGateway.SaveCourse(course);
        }
        public List<DepartmentModel> GetAllDepartment() //load depertment to department dropdown list
        {
            return courseGateway.GetAllDepartment();
        }

        public List<SemesterModel> GetAllSemester() //load semeter to semester dropdown list
        {
            return courseGateway.GetAllSemester();
        }


    }
}
