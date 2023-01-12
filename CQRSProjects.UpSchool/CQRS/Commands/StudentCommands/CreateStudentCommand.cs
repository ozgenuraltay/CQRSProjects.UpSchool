using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Commands.StudentCommands
{
    public class CreateStudentCommand
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }

        public bool Status { get; set; }

        public int Age { get; set; }
    }
}
