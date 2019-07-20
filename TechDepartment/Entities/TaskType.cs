using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechDepartment.Entities
{
    public class TaskType : _Base
    {
        /// <summary>
        /// Тип работы (ИМ, ИТ и прочее)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Программист или технолог?
        /// </summary>
        public string TypeCoworker { get; set; }

        public TaskType() : base()
        {

        }

        public TaskType(string type, string typeCoworker) : this()
        {
            Type = type;
            TypeCoworker = typeCoworker;
        }
    }
}
