using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechDepartment.Entities
{
    public class ProgrammerReport : _Base
    {
        public DateTime TaskDate { get; set; }

        public Coworker Coworker { get; set; }

        public TaskType TaskType { get; set; }

        public Detail Detail { get; set; }

        public bool Act { get; set; }

        public bool SetupCard { get; set; }

        public bool Project { get; set; }

        public bool HasManufactured { get; set; }

        public double ProgramTime { get; set; }

        public double AdjustingTime { get; set; }

        public ProgrammerReport() : base()
        {

        }

        public ProgrammerReport(DateTime taskDate, Coworker coworker, TaskType taskType, Detail detail, bool act, bool setupCard, bool project, bool hasManufact, double programTime, double adjustingTime): this()
        {
            TaskDate = taskDate;
            Coworker = coworker;
            TaskType = taskType;
            Detail = detail;
            Act = act;
            SetupCard = setupCard;
            Project = project;
            HasManufactured = hasManufact;
            ProgramTime = programTime;
            AdjustingTime = adjustingTime;
        }

    }
}
