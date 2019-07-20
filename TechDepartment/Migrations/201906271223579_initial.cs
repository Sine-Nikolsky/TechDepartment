namespace TechDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Status = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AnotherTasks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TaskDate = c.DateTime(nullable: false),
                        Task = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        Coworker_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coworkers", t => t.Coworker_Id)
                .Index(t => t.Coworker_Id);
            
            CreateTable(
                "dbo.Coworkers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Position = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        UserType_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.UserType_Id);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Notes = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramJournals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Product = c.String(),
                        Code = c.String(),
                        Name = c.String(),
                        ProgramTime = c.Double(nullable: false),
                        ActNumber = c.String(),
                        ActDate = c.DateTime(nullable: false),
                        SetupCard = c.Boolean(nullable: false),
                        Project = c.Boolean(nullable: false),
                        Program = c.Boolean(nullable: false),
                        PathToAct = c.String(),
                        Notes = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        ActStatus_Id = c.Guid(),
                        Machine_Id = c.Guid(),
                        Programmer_Id = c.Guid(),
                        TPStatus_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActStatus", t => t.ActStatus_Id)
                .ForeignKey("dbo.Machines", t => t.Machine_Id)
                .ForeignKey("dbo.Coworkers", t => t.Programmer_Id)
                .ForeignKey("dbo.TPStatus", t => t.TPStatus_Id)
                .Index(t => t.ActStatus_Id)
                .Index(t => t.Machine_Id)
                .Index(t => t.Programmer_Id)
                .Index(t => t.TPStatus_Id);
            
            CreateTable(
                "dbo.TPStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Status = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgrammerReports",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TaskDate = c.DateTime(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Act = c.Boolean(nullable: false),
                        SetupCard = c.Boolean(nullable: false),
                        Project = c.Boolean(nullable: false),
                        HasManufactured = c.Boolean(nullable: false),
                        ProgramTime = c.Double(nullable: false),
                        AdjustingTime = c.Double(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        Coworker_Id = c.Guid(),
                        TaskType_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coworkers", t => t.Coworker_Id)
                .ForeignKey("dbo.TaskTypes", t => t.TaskType_Id)
                .Index(t => t.Coworker_Id)
                .Index(t => t.TaskType_Id);
            
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        TypeCoworker = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TechnologistReports",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TaskDate = c.DateTime(nullable: false),
                        Code = c.String(),
                        Notes = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        Coworker_Id = c.Guid(),
                        TaskType_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coworkers", t => t.Coworker_Id)
                .ForeignKey("dbo.TaskTypes", t => t.TaskType_Id)
                .Index(t => t.Coworker_Id)
                .Index(t => t.TaskType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnologistReports", "TaskType_Id", "dbo.TaskTypes");
            DropForeignKey("dbo.TechnologistReports", "Coworker_Id", "dbo.Coworkers");
            DropForeignKey("dbo.ProgrammerReports", "TaskType_Id", "dbo.TaskTypes");
            DropForeignKey("dbo.ProgrammerReports", "Coworker_Id", "dbo.Coworkers");
            DropForeignKey("dbo.ProgramJournals", "TPStatus_Id", "dbo.TPStatus");
            DropForeignKey("dbo.ProgramJournals", "Programmer_Id", "dbo.Coworkers");
            DropForeignKey("dbo.ProgramJournals", "Machine_Id", "dbo.Machines");
            DropForeignKey("dbo.ProgramJournals", "ActStatus_Id", "dbo.ActStatus");
            DropForeignKey("dbo.AnotherTasks", "Coworker_Id", "dbo.Coworkers");
            DropForeignKey("dbo.Coworkers", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.TechnologistReports", new[] { "TaskType_Id" });
            DropIndex("dbo.TechnologistReports", new[] { "Coworker_Id" });
            DropIndex("dbo.ProgrammerReports", new[] { "TaskType_Id" });
            DropIndex("dbo.ProgrammerReports", new[] { "Coworker_Id" });
            DropIndex("dbo.ProgramJournals", new[] { "TPStatus_Id" });
            DropIndex("dbo.ProgramJournals", new[] { "Programmer_Id" });
            DropIndex("dbo.ProgramJournals", new[] { "Machine_Id" });
            DropIndex("dbo.ProgramJournals", new[] { "ActStatus_Id" });
            DropIndex("dbo.Coworkers", new[] { "UserType_Id" });
            DropIndex("dbo.AnotherTasks", new[] { "Coworker_Id" });
            DropTable("dbo.TechnologistReports");
            DropTable("dbo.TaskTypes");
            DropTable("dbo.ProgrammerReports");
            DropTable("dbo.TPStatus");
            DropTable("dbo.ProgramJournals");
            DropTable("dbo.Machines");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Coworkers");
            DropTable("dbo.AnotherTasks");
            DropTable("dbo.ActStatus");
        }
    }
}
