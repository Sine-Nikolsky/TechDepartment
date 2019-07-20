using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TechDepartment.Entities
{
    public class Detail : _Base
    {
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public Detail() : base()
        {

        }

        public Detail(string code, string name) : this()
        {
            Code = code;
            Name = name;
        }

    }
}
