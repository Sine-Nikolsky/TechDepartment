namespace TechDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10072019 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coworkers", "UserType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coworkers", "UserType");
        }
    }
}
