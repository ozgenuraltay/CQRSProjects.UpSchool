using CQRSProjects.UpSchool.CQRS.Commands.StudentCommands;
using CQRSProjects.UpSchool.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.StudentHandlers
{
    public class RemoveStudentCommandHandler
    {
        private readonly ProductContext _context;

        public RemoveStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(RemoveStudentCommand command)
        {
            var student = _context.Students.Find(command.id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
