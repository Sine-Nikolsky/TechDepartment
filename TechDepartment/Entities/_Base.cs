using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechDepartment.Entities
{
    public class _Base
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public _Base()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }

    }
}
