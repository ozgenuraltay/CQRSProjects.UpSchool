using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Commands.UniversityCommands
{
    public class RemoveUniversityCommand:IRequest
    {
        public int id { get; set; }

        public RemoveUniversityCommand(int id)
        {
            this.id = id;
        }
    }
}
