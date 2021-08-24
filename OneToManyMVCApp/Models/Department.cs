using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneToManyMVCApp.Models
{
    public class Department
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Code { set; get; }
        public virtual List<Student> Students { set; get; }
    }
}