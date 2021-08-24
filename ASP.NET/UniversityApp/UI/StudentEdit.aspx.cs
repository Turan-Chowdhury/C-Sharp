using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityApp.Manager;
using UniversityApp.Models;

namespace UniversityApp.UI
{
    public partial class StudentEdit : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNO = regNoTextBox.Text;
            Student student = studentManager.SearchStudentByRegNo(regNO);
            nameTextBox.Text = student.Name;
            emailTextBox.Text = student.Email;
            addressTextBox.Text = student.Address;
            departmentTextBox.Text = student.Department;
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextBox.Text;
            string message = studentManager.DeleteStudent(regNo);
            messageLabel.Text = message;
            ClearAllTextBoxes();
        }        

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.RegNo = regNoTextBox.Text;
            student.Name = nameTextBox.Text;            
            student.Email = emailTextBox.Text;
            student.Address = addressTextBox.Text;
            student.Department = departmentTextBox.Text;
            string message = studentManager.UpdateStudent(student);
            messageLabel.Text = message;
            ClearAllTextBoxes();
        }

        private void ClearAllTextBoxes()
        {
            regNoTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            departmentTextBox.Text = "";
        }
    }
}