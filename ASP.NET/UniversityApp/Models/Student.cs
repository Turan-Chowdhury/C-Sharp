using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityApp.Models
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string RegNo { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Department { set; get; }
    }
}