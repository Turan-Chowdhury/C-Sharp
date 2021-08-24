using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipDemo
{
    class Department
    {
        public string ShortName { set; get; }
        public string FullName { set; get; }
        public List<Student> Students { set; get; } // One To Many Association Relationship

        public Department()
        {
            Students = new List<Student>();
        }
    }
}
