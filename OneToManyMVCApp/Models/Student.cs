using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneToManyMVCApp.Models
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; } 
        public string RegNo { set; get; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }
    }
}