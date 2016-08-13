﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCRMSApp.DAL;
using UniversityCRMSApp.Models;

namespace UniversityCRMSApp.BLL
{
    class DepartmentManager
    {
        DepartmentGateway departmentGateway=new DepartmentGateway();
        public int SaveDepartment(DepartmentModel department)
        {
          return  departmentGateway.SaveDepartment(department);
        }

        public List<DepartmentModel> GetDepartment()
        {
            return departmentGateway.GetDepartment();
        }

    }
}
