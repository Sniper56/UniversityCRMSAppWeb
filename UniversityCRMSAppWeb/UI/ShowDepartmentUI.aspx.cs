using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityCRMSApp.BLL;
using UniversityCRMSApp.Models;

namespace UniversityCRMSAppWeb.UI
{
    public partial class ShowDepartmentUI : System.Web.UI.Page
    {
        DepartmentManager departmentManager=new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DepartmentModel> department = departmentManager.GetDepartment();
            showDepGridView.DataSource = department;
            showDepGridView.DataBind();
        }
    }
}