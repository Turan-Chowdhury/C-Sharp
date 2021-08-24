using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementSystem.Manager;
using UniversityManagementSystem.Model;

namespace UniversityManagementSystem
{
    public partial class StudentEntryUI : Form
    {
        private StudentManager aStudentManager = new StudentManager();
        private DepartmentManager aDepartmentManager = new DepartmentManager();
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(departmentComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("Please select a department");
                return;
            }
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.RegNO = regNoTextBox.Text;
            aStudent.PhoneNO = phoneNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentComboBox.SelectedValue);
            
            if(saveButton.Text == "Save")
            {
                string message = aStudentManager.SaveStudent(aStudent);
                MessageBox.Show(message);
            }
            else
            {
                aStudent.Id = Convert.ToInt32(hiddenIdLabel.Text);
                string message = aStudentManager.UpdateStudent(aStudent);
                MessageBox.Show(message);
            }

            PopulateStudentListView();
        }

        private void StudentEntryUI_Load(object sender, EventArgs e)
        {
            Department defaultDepartment = new Department();
            defaultDepartment.Id = -1;
            defaultDepartment.Name = "--Select--";
            List<Department> departments = aDepartmentManager.GetAllDepartments();
            departments.Insert(0, defaultDepartment);
            departmentComboBox.DataSource = departments;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";
            PopulateStudentListView();
        }

        private void PopulateStudentListView()
        {
            studentListView.Items.Clear();
            List<StudentWithDept> students = aStudentManager.getAllStudents();
            foreach (StudentWithDept student in students)
            {
                ListViewItem item = new ListViewItem();
                item.Text = student.StudentName;
                item.SubItems.Add(student.RegNO);
                item.SubItems.Add(student.PhoneNO);
                item.SubItems.Add(student.Email);
                item.SubItems.Add(student.Code);
                item.Tag = student;

                studentListView.Items.Add(item);
            }
        }

        private void studentListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = studentListView.SelectedItems[0];
            StudentWithDept student = selectedItem.Tag as StudentWithDept;  // (Student) selectedItem.Tag;

            if(student != null)
            {
                nameTextBox.Text = student.StudentName;
                regNoTextBox.Text = student.RegNO;
                phoneNoTextBox.Text = student.PhoneNO;
                emailTextBox.Text = student.Email;
                departmentComboBox.SelectedValue = student.DeptId;
                hiddenIdLabel.Text = student.StudentId.ToString();

                saveButton.Text = "Update";
                removeButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            nameTextBox.Clear();
            regNoTextBox.Clear();
            phoneNoTextBox.Clear();
            emailTextBox.Clear();
            departmentComboBox.SelectedValue = -1;
            hiddenIdLabel.Text = String.Empty;

            saveButton.Text = "Save";
            removeButton.Enabled = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(hiddenIdLabel.Text);
            string message = aStudentManager.DeleteStudent(id);
            MessageBox.Show(message);

            Reset();
            PopulateStudentListView();
        }
    }
}
