using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCRMSApp.Models
{
    class DepartmentModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }        
        //public String DepartmentCode
        //{
        //    get
        //    {
        //        return DepartmentCode;
        //    }
        //    set
        //    {
        //        if (value.Length >= 2 || value.Length <= 7)
        //        {
        //            DepartmentCode = value;
        //        }
        //    }
        //}
        public String DepartmentName { get; set; }
    }
}
