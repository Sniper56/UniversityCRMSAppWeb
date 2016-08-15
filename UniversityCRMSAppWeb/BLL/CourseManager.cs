using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCRMSApp.DAL;
using UniversityCRMSApp.Models;

namespace UniversityCRMSApp.BLL
{
    class CourseManager
    {
        CourseGateway courseGateway=new CourseGateway();
        public int SaveCourse(CourseModel course)
        {
            return courseGateway.SaveCourse(course);
        }

    }
}
