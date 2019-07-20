using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDepartment.Enums;

namespace TechDepartment.Entities
{
    public class Coworker : _Base
    {
        [MaxLength(50)]
        public string Login { get; private set; }

        [MaxLength(50)]
        public string Password { get; private set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string MiddleName { get; set; }

        [MaxLength(10)]
        public string PersonalNumber { get; set; }

        public UserType UserType { get; private set; }

        public Coworker() : base()
        { }

        public Coworker(UserType type) : this()
        {
            UserType = type;
        }

        public Coworker(string login, string pass, string pn, string fname, string lname, string mname, UserType type) : this(type)
        {
            Login = login;
            Password = pass;
            PersonalNumber = pn;
            FirstName = fname;
            LastName = lname;
            MiddleName = mname;
            UserType = type;
        }

        public override string ToString()
        {
            return string.Format(LastName + " " + FirstName[0] + "." + MiddleName[0] + ".");
        }
    }
}
