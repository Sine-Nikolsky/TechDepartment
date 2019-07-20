namespace TechDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Coworkers", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Coworkers", new[] { "UserType_Id" });
            AddColumn("dbo.Coworkers", "Login", c => c.String());
            AddColumn("dbo.Coworkers", "Password", c => c.String());
            AddColumn("dbo.Coworkers", "PersonalNumber", c => c.String());
            DropColumn("dbo.Coworkers", "UserType_Id");
            DropTable("dbo.UserTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Coworkers", "UserType_Id", c => c.Guid());
            DropColumn("dbo.Coworkers", "PersonalNumber");
            DropColumn("dbo.Coworkers", "Password");
            DropColumn("dbo.Coworkers", "Login");
            CreateIndex("dbo.Coworkers", "UserType_Id");
            AddForeignKey("dbo.Coworkers", "UserType_Id", "dbo.UserTypes", "Id");
        }
    }
}
