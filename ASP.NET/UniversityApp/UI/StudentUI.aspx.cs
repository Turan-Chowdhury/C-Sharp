using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.Manager;
using UniversityApp.Models;

namespace UniversityApp
{
    public partial class StudentUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();            
        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = nameTextBox.Text;
            student.RegNo = regNoTextBox.Text;
            student.Email = emailTextBox.Text;
            student.Address = addressTextBox.Text;
            student.Department = departmentTextBox.Text;
            
            string message = studentManager.SaveStudent(student);
            LoadData();
            messageLabel.Text = message;
        }

        private void LoadData()
        {
            StudentGridView.DataSource = null;
            StudentGridView.DataSource = studentManager.GetAllStudents();
            StudentGridView.DataBind();


            if (!IsPostBack)
            {
                studentDropDownList.DataSource = studentManager.GetAllStudents();
                studentDropDownList.DataTextField = "Name";
                studentDropDownList.DataValueField = "RegNO";
                studentDropDownList.DataBind();
            }
        }
    }
}