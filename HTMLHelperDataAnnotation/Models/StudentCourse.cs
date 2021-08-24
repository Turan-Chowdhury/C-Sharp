using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HTMLHelperDataAnnotation.Models
{
    public class StudentCourse
    {
        public int Id { set; get; }
        public int StudentId { set; get; }
        public int CourseId { set; get; }
        [DisplayName("Enroll Date")]
        public DateTime EnrollDate { set; get; }
    }
}