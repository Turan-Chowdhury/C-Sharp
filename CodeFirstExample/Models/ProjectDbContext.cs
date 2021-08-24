using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstExample.Models
{
    public class ProjectDbContext : DbContext
    {
        //public ProjectDbContext() : base("ConnectionStringNameWillBeHere")      // when connection string name is different from class name
        //{
        //    //
        //}
        public DbSet<Employee> Employees { set; get; }
    }
}