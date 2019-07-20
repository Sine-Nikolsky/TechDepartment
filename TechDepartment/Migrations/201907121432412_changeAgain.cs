namespace TechDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAgain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProgramJournals", "ActStatus_Id", "dbo.ActStatus");
            DropForeignKey("dbo.ProgramJournals", "TPStatus_Id", "dbo.TPStatus");
            DropIndex("dbo.ProgramJournals", new[] { "ActStatus_Id" });
            DropIndex("dbo.ProgramJournals", new[] { "TPStatus_Id" });
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(maxLength: 50),
                        Name = c.String(maxLength: 100),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AnotherTasks", "ModifyDate", c => c.DateTime());
            AddColumn("dbo.Coworkers", "ModifyDate", c => c.DateTime());
            AddColumn("dbo.Machines", "ModifyDate", c => c.DateTime());
            AddColumn("dbo.ProgramJournals", "WhatsDone", c => c.String(maxLength: 100));
            AddColumn("dbo.ProgramJournals", "ActStatus", c => c.Int(nullable: false));
            AddColumn("dbo.ProgramJournals", "TPStatus", c => c.Int(nullable: false));
            AddColumn("dbo.ProgramJournals", "Annuled", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProgramJournals", "ModifyDate", c => c.DateTime());
            AddColumn("dbo.ProgramJournals", "Detail_Id", c => c.Guid());
            AddColumn("dbo.ProgrammerReports", "ModifyDate", c => c.DateTime());
            AddColumn("dbo.ProgrammerReports", "Detail_Id", c => c.Guid());
            AddColumn("dbo.TaskTypes", "ModifyDate", c => c.DateTime());
            AddColumn("dbo.TechnologistReports", "ModifyDate", c => c.DateTime());
            AlterColumn("dbo.Coworkers", "Login", c => c.String(maxLength: 50));
            AlterColumn("dbo.Coworkers", "Password", c => c.String(maxLength: 50));
            AlterColumn("dbo.Coworkers", "LastName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Coworkers", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Coworkers", "MiddleName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Coworkers", "PersonalNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Machines", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Machines", "Notes", c => c.String(maxLength: 150));
            AlterColumn("dbo.ProgramJournals", "ActNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.ProgramJournals", "Notes", c => c.String(maxLength: 150));
            CreateIndex("dbo.ProgramJournals", "Detail_Id");
            CreateIndex("dbo.ProgrammerReports", "Detail_Id");
            AddForeignKey("dbo.ProgramJournals", "Detail_Id", "dbo.Details", "Id");
            AddForeignKey("dbo.ProgrammerReports", "Detail_Id", "dbo.Details", "Id");
            DropColumn("dbo.AnotherTasks", "EditDate");
            DropColumn("dbo.Coworkers", "EditDate");
            DropColumn("dbo.Machines", "EditDate");
            DropColumn("dbo.ProgramJournals", "Product");
            DropColumn("dbo.ProgramJournals", "Code");
            DropColumn("dbo.ProgramJournals", "Name");
            DropColumn("dbo.ProgramJournals", "EditDate");
            DropColumn("dbo.ProgramJournals", "ActStatus_Id");
            DropColumn("dbo.ProgramJournals", "TPStatus_Id");
            DropColumn("dbo.ProgrammerReports", "Code");
            DropColumn("dbo.ProgrammerReports", "Name");
            DropColumn("dbo.ProgrammerReports", "EditDate");
            DropColumn("dbo.TaskTypes", "EditDate");
            DropColumn("dbo.TechnologistReports", "EditDate");
            DropTable("dbo.ActStatus");
            DropTable("dbo.TPStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TPStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Status = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ActStatus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Status = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TechnologistReports", "EditDate", c => c.DateTime());
            AddColumn("dbo.TaskTypes", "EditDate", c => c.DateTime());
            AddColumn("dbo.ProgrammerReports", "EditDate", c => c.DateTime());
            AddColumn("dbo.ProgrammerReports", "Name", c => c.String());
            AddColumn("dbo.ProgrammerReports", "Code", c => c.String());
            AddColumn("dbo.ProgramJournals", "TPStatus_Id", c => c.Guid());
            AddColumn("dbo.ProgramJournals", "ActStatus_Id", c => c.Guid());
            AddColumn("dbo.ProgramJournals", "EditDate", c => c.DateTime());
            AddColumn("dbo.ProgramJournals", "Name", c => c.String());
            AddColumn("dbo.ProgramJournals", "Code", c => c.String());
            AddColumn("dbo.ProgramJournals", "Product", c => c.String());
            AddColumn("dbo.Machines", "EditDate", c => c.DateTime());
            AddColumn("dbo.Coworkers", "EditDate", c => c.DateTime());
            AddColumn("dbo.AnotherTasks", "EditDate", c => c.DateTime());
            DropForeignKey("dbo.ProgrammerReports", "Detail_Id", "dbo.Details");
            DropForeignKey("dbo.ProgramJournals", "Detail_Id", "dbo.Details");
            DropIndex("dbo.ProgrammerReports", new[] { "Detail_Id" });
            DropIndex("dbo.ProgramJournals", new[] { "Detail_Id" });
            AlterColumn("dbo.ProgramJournals", "Notes", c => c.String());
            AlterColumn("dbo.ProgramJournals", "ActNumber", c => c.String());
            AlterColumn("dbo.Machines", "Notes", c => c.String());
            AlterColumn("dbo.Machines", "Name", c => c.String());
            AlterColumn("dbo.Coworkers", "PersonalNumber", c => c.String());
            AlterColumn("dbo.Coworkers", "MiddleName", c => c.String());
            AlterColumn("dbo.Coworkers", "FirstName", c => c.String());
            AlterColumn("dbo.Coworkers", "LastName", c => c.String());
            AlterColumn("dbo.Coworkers", "Password", c => c.String());
            AlterColumn("dbo.Coworkers", "Login", c => c.String());
            DropColumn("dbo.TechnologistReports", "ModifyDate");
            DropColumn("dbo.TaskTypes", "ModifyDate");
            DropColumn("dbo.ProgrammerReports", "Detail_Id");
            DropColumn("dbo.ProgrammerReports", "ModifyDate");
            DropColumn("dbo.ProgramJournals", "Detail_Id");
            DropColumn("dbo.ProgramJournals", "ModifyDate");
            DropColumn("dbo.ProgramJournals", "Annuled");
            DropColumn("dbo.ProgramJournals", "TPStatus");
            DropColumn("dbo.ProgramJournals", "ActStatus");
            DropColumn("dbo.ProgramJournals", "WhatsDone");
            DropColumn("dbo.Machines", "ModifyDate");
            DropColumn("dbo.Coworkers", "ModifyDate");
            DropColumn("dbo.AnotherTasks", "ModifyDate");
            DropTable("dbo.Details");
            CreateIndex("dbo.ProgramJournals", "TPStatus_Id");
            CreateIndex("dbo.ProgramJournals", "ActStatus_Id");
            AddForeignKey("dbo.ProgramJournals", "TPStatus_Id", "dbo.TPStatus", "Id");
            AddForeignKey("dbo.ProgramJournals", "ActStatus_Id", "dbo.ActStatus", "Id");
        }
    }
}
