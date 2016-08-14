using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace UniversityCRMSApp.Models
{
    class TeacherModel
    {
        public int TeacherId { get; set; }
        public string TacherName { get; set; }
        public string Address { get; set; }

        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                string pattern = null;
                pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(value,pattern) )
                {
                    Email = value;
                }
            }
        }

        public string ContactNo
        {
            get
            {
                return ContactNo;        
            }
            set
            {
                string pattern = null;
                //pattern = @"^([01]|\+88)?\d{11}";
                pattern = @"^(?:\+?88)?01\d{8}$";
                if (Regex.IsMatch(value, pattern))
                {
                    ContactNo = value;
                }
            }
        }
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }
        public int CreditToBeTaken { get; set; }
    }
}
