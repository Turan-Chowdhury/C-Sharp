using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstExample.Models
{
    public class Employee
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        public string Address { set; get; }
        [Required]
        public string Department { set; get; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Email { set; get; }
        [Required]
        [Column(TypeName = "varchar")]
        public string Password { set; get; }
        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { set; get; }
    }
}