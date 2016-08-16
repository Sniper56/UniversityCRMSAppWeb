using System;
using System.Collections.Generic;
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
            ClearAll();
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

        private void ClearAll()
        {
            nameTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            contactNoTextBox.Text = string.Empty;
            designationDropDownList.SelectedIndex = 0;
            departmentrDropDownList.SelectedIndex = 0;
        }

    }
}