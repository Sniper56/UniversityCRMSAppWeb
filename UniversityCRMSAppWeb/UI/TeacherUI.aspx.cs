using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityCRMSApp.BLL;
using UniversityCRMSApp.Models;
using UniversityCRMSAppWeb.Models;

namespace UniversityCRMSAppWeb.UI
{
    public partial class TeacherUI : System.Web.UI.Page
    {
       TeacherManager teacherManager=new TeacherManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDepartmentDropdownList();
                LoadDesignationDropdownList();
            }
        }
        private void LoadDepartmentDropdownList()
        {
            List<DepartmentModel> departmentlList = teacherManager.GetAllDepartment();
            departmentrDropDownList.DataSource = departmentlList;
            departmentrDropDownList.DataTextField = "DepartmentName";
            departmentrDropDownList.DataValueField = "DepartmentId";
            departmentrDropDownList.DataBind();
            departmentrDropDownList.Items.Insert(0, "----Select----");
        }
        private void LoadDesignationDropdownList()
        {
            List<DesignationModel> designationlList = teacherManager.GetTeacherDesignation();
            designationDropDownList.DataSource = designationlList;
            designationDropDownList.DataTextField = "Designation";
            designationDropDownList.DataValueField = "Id";
            designationDropDownList.DataBind();
            designationDropDownList.Items.Insert(0, "----Select----");
        }



    }
}