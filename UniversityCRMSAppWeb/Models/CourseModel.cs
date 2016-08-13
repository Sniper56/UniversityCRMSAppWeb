using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCRMSApp.Models
{
    class CourseModel
    {
        public int CourseId { get; set; }

        public string CourseCode
        {
            get
            {
                return CourseCode;
            }
            set
            {
                if (value.Length >= 2 || value.Length <= 7)
                {
                    CourseCode = value;
                }
            } 
        }
        public string CourseName { get; set; }
        public float Credit
        {
            get
            {
                return Credit;
            }
            set
            {
                if (value.ToString().Length >= 0.5 || value.ToString().Length <= 5)
                {
                    Credit = value;
                }
            }
        }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }
    }
}
