using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Model
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string RegNO { set; get; }
        public string PhoneNO { set; get; }
        public string Email { set; get; }
        public int DepartmentId { set; get; }
    }
}
