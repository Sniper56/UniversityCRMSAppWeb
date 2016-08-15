using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCRMSApp.DAL;
using UniversityCRMSApp.Models;

namespace UniversityCRMSApp.BLL
{
    class TeacherManager
    {
        TeacherGateway teacherGateway =new TeacherGateway();
        public int SaveTeacher(TeacherModel teacher)
        {
            return teacherGateway.SaveTeacher(teacher);
        }
    }
}
