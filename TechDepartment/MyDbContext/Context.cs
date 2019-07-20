using System.Data.Entity;
using TechDepartment.Entities;

namespace TechDepartment.MyDbContext
{
    class Context : DbContext
    {
        public DbSet<Detail> Details { get; set; }

        public DbSet<AnotherTask> AnotherTasks { get; set; }

        public DbSet<Coworker> Coworkers { get; set; }

        public DbSet<Machine> Machines { get; set; }

        public DbSet<ProgramJournal> ProgramJournals { get; set; }

        public DbSet<ProgrammerReport> ProgrammerReports { get; set; }

        public DbSet<TaskType> TaskTypes { get; set; }

        public DbSet<TechnologistReport> TechnologistReports { get; set; }


    }
}
