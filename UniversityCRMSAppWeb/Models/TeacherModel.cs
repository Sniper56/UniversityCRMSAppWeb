using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCRMSApp.Models
{
    class TeacherModel
    {
        public int TeacherId { get; set; }
        public string TacherName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }
        public int CreditToBeTaken { get; set; }
    }
}
