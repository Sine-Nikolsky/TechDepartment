namespace TechDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ActStatus", "EditDate", c => c.DateTime());
            AlterColumn("dbo.AnotherTasks", "EditDate", c => c.DateTime());
            AlterColumn("dbo.Coworkers", "EditDate", c => c.DateTime());
            AlterColumn("dbo.UserTypes", "EditDate", c => c.DateTime());
            AlterColumn("dbo.Machines", "EditDate", c => c.DateTime());
            AlterColumn("dbo.ProgramJournals", "ActDate", c => c.DateTime());
            AlterColumn("dbo.ProgramJournals", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TPStatus", "EditDate", c => c.DateTime());
            AlterColumn("dbo.ProgrammerReports", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TaskTypes", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TechnologistReports", "EditDate", c => c.DateTime());
            DropColumn("dbo.Coworkers", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coworkers", "Position", c => c.String());
            AlterColumn("dbo.TechnologistReports", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TaskTypes", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProgrammerReports", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TPStatus", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProgramJournals", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProgramJournals", "ActDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Machines", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserTypes", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Coworkers", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AnotherTasks", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ActStatus", "EditDate", c => c.DateTime(nullable: false));
        }
    }
}
