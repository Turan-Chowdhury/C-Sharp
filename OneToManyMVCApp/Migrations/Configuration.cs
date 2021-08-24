namespace OneToManyMVCApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OneToManyMVCApp.Models.UniversityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OneToManyMVCApp.Models.UniversityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Departments.AddOrUpdate(
                new Models.Department() { Code="CSE", Name="Computer Science & Engineering" },
                new Models.Department() { Code="PHY", Name="Physics" },
                new Models.Department() { Code="MATH", Name="Mathematics" }
            );
        }
    }
}
