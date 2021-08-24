using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetBasicInformation();

            Department department = new Department();
            department.GetBasicInformation();

            Course course = new Course();
            course.GetBasicInformation();

            IInformation information = student; // Interface can not have object. It can only have reference.            
            IPrinter printer = student; // Interface can not have object. It can only have reference.

        }
    }
}
