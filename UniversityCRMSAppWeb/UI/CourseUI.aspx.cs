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
            if (!IsPostBack)
            {
                LoadDepartmentDropdownList();
                LoadSemesterDropdownList();
            }
            ClearAll();
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

        protected void saveButton_Click(object sender, EventArgs e)
        {
            CourseModel course=new CourseModel();
            course.CourseCode = codeTextBox.Text;
            course.CourseName = nameTextBox.Text;
            course.Credit =float.Parse( creditTextBox.Text);
            course.Description = DescriptionTextBox.Text;
            course.DepartmentId = departmentDropDownList.SelectedIndex;
            course.SemesterId = semesterDropDownList.SelectedIndex;

            int rowAffected;
                rowAffected= courseManager.SaveCourse(course);
            if (rowAffected > 0)
            {
                Response.Write("Course Save succcessful.");

            }
            else
            {
                Response.Write("Course save failed!");
            }
        }

        private void ClearAll()
        {
            codeTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            creditTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            departmentDropDownList.SelectedIndex = 0;
            semesterDropDownList.SelectedIndex = 0;
        }
    }
}