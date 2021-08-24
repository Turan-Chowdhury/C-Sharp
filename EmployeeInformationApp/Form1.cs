using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class EmployeeInformationUI : Form
    {
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();

            anEmployee.firstName = firstNameTextBox.Text;
            anEmployee.middleName = middleNameTextBox.Text;
            anEmployee.lastName = lastNameTextBox.Text;

            employees.Add(anEmployee);

            MessageBox.Show("Information Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            employeeListView.Items.Clear();

            foreach(Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();

                item.Text = employee.firstName;
                item.SubItems.Add(employee.middleName);
                item.SubItems.Add(employee.lastName);
                item.SubItems.Add(employee.getFullName());

                employeeListView.Items.Add(item);
            }
        }
    }
}
