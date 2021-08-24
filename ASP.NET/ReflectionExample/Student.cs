using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string RegNo { set; get; }
        private string Address { set; get; }

        public string GetInfo()
        {
            return "Id:" + Id + "  Name:" + Name;
        }
    }
}
