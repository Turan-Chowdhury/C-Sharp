using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelperDataAnnotation.Models
{
    public class Course
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public double Credit { set; get; }
    }
}