using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityCRMSApp.BLL;
using UniversityCRMSApp.DAL;
using UniversityCRMSApp.Models;
using UniversityCRMSAppWeb.Models;

namespace UniversityCRMSAppWeb.UI
{
    public partial class CourseUI : System.Web.UI.Page
    {
        CourseManager   courseManager=new CourseManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDepartmentDropdownList();
            LoadSemesterDropdownList();

        }

        private void LoadDepartmentDropdownList()
        {
            List<DepartmentModel> departmentlList = courseManager.GetAllDepartment();
            departmentDropDownList.DataSource = departmentlList;
            departmentDropDownList.DataTextField = "DepartmentName";
            departmentDropDownList.DataValueField = "DepartmentId";
            departmentDropDownList.DataBind();
            departmentDropDownList.Items.Insert(0, "----Select----");
        }

        private void LoadSemesterDropdownList()
        {
            List<SemesterModel> semesterlList = courseManager.GetAllSemester();
            semesterDropDownList.DataSource = semesterlList;
            semesterDropDownList.DataTextField = "Semester";
            semesterDropDownList.DataValueField = "Id";
            semesterDropDownList.DataBind();
            semesterDropDownList.Items.Insert(0,"----Select----");
        }
    }
}