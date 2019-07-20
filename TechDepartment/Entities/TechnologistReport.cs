using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechDepartment.Entities
{
    public class TechnologistReport : _Base
    {
        public DateTime TaskDate { get; set; }

        public Coworker Coworker { get; set; }

        public TaskType TaskType { get; set; }

        public string Code { get; set; }

        public string Notes { get; set; }

        public TechnologistReport() : base()
        {

        }

        public TechnologistReport(DateTime taskDate, Coworker coworker, TaskType taskType, string code, string notes) : this()
        {
            TaskDate = taskDate;
            Coworker = coworker;
            TaskType = taskType;
            Code = code;
            Notes = notes;
        }
    }
}
