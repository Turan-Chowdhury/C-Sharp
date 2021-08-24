using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropdownASP.NET.Models
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int DepartmentId { set; get; }
    }
}