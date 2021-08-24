using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Model
{
    public class StudentWithDept
    {
        public int StudentId { set; get; }
        public string StudentName { set; get; }
        public string RegNO { set; get; }
        public string PhoneNO { set; get; }
        public string Email { set; get; }
        public int DeptId { set; get; }
        public string Code { set; get; }
        public string DeptName { set; get; }
    }
}
