using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OneToManyMVCApp.Models
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Student> Students { set; get; }
        public DbSet<Department> Departments { set; get; }
    }
}