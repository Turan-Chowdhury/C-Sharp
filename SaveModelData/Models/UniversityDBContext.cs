using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SaveModelData.Models
{
    public class UniversityDBContext : DbContext
    {
        public DbSet<Student> Students { set; get; }
    }
}