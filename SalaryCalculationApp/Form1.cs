using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationApp
{
    public partial class SalaryCalculationUI : Form
    {
        public SalaryCalculationUI()
        {
            InitializeComponent();
        }

        private void calculateTotalSalaryButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();

            aSalary.basicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
            aSalary.houseRentPercentage = Convert.ToDouble(HouseRentTextBox.Text);
            aSalary.medicalAllowancePercentage = Convert.ToDouble(medicalAllowanceTextBox.Text);

            totalSalaryTextBox.Text = aSalary.CalculateTotalSalary().ToString();
        }
    }
}
