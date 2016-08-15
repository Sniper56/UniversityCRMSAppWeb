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
