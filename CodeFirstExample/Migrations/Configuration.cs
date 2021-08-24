namespace CodeFirstExample.Migrations
{
    using CodeFirstExample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstExample.Models.ProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstExample.Models.ProjectDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Employees.AddOrUpdate(
            //    new Employee { Id=1, Name="Turan", Address="ctg", Department="Hhuman Resource", Email="turan@gmail.com", Password="12345", ConfirmPassword="12345"}
            //);
        }
    }
}
