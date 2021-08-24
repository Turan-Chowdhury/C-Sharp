using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationApp
{
    class Employee
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string getFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}
