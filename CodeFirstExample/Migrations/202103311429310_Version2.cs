namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
