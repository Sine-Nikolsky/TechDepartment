using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechDepartment.Entities
{
    public class AnotherTask : _Base
    {
        public DateTime TaskDate { get; set; }

        public Coworker Coworker { get; set; }

        public string Task { get; set; }

        public AnotherTask(): base()
        {

        }

        public AnotherTask(DateTime date, Coworker coworker) : this()
        {
            TaskDate = date;
            Coworker = coworker;
        }
    }
}
