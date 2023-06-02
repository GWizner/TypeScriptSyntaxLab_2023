using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp2023
{
    public class Student: User
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override string EmailAddress { get; set; }
        public override string Password { get; set; }
        public string Major { get; set; }
        public RegistrationStatus CurrentStatus { get; set; }
    }
}
