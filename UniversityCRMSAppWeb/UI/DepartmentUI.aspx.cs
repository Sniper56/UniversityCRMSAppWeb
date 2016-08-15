using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityCRMSApp.BLL;
using UniversityCRMSApp.Models;

namespace UniversityCRMSAppWeb.UI
{
    public partial class DepartmentUI : System.Web.UI.Page
    {
        DepartmentManager departmentManager=new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            DepartmentModel department=new DepartmentModel();
            department.DepartmentCode = codeTextBox.Text;
            department.DepartmentName = nameTextBox.Text;

            if (departmentManager.IsDepartmentTestExists(department) == true)
            {
                Response.Write("Department Code alrady exist!");
            }
            else
            {
                departmentManager.SaveDepartment(department);
                Response.Write("Department save successful.");
            }

          
            ClearAll();
        }

        private void ClearAll()
        {
            codeTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
        }
    }
}