using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Department : IInformation
    {
        public Department()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
        public string Code { set; get; }
        public string Name { set; get; }
        public List<Student> Students { set; get; }
        public List<Course> Courses { set; get; }

        public string GetBasicInformation()
        {
            return "Code: " + Code + " Name: " + Name + " Total Students: " + Students.Count;
        }
    }
}
