using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HTMLHelperDataAnnotation.Models
{
    public class Student
    {
        [Key]
        public int Id { set; get; }
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(10, MinimumLength =6, ErrorMessage ="Your name should be 6-10 characters long")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Please enter your email")]
        [StringLength(50)]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Please Enter a valid email")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Please enter your gender")]
        public string Gender { set; get; }
        [Required(ErrorMessage = "Please enter your department")]
        [DisplayName("Department")]
        public int DepartmentId { set; get; }
        [Required(ErrorMessage = "Please enter your address")]
        public string Address { set; get; }
        [Required(ErrorMessage = "Please enter your password")]
        [StringLength(8, MinimumLength =5)]
        public string Password { set; get; }
        [Required(ErrorMessage = "Please re-enter your password")]
        [StringLength(8, MinimumLength = 5)]
        [Compare("Password")]
        public string ConfirmPassword { set; get; }
    }
}