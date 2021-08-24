using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationApp
{
    class Salary
    {
        public double basicSalary;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public double CalculateTotalSalary()
        {
            double totalSalary = basicSalary + basicSalary * houseRentPercentage / 100 + basicSalary * medicalAllowancePercentage / 100 ;
            return totalSalary;
        }
    }
}
