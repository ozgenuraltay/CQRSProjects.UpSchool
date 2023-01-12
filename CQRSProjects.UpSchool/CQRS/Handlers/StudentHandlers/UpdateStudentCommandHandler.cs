using CQRSProjects.UpSchool.CQRS.Commands.StudentCommands;
using CQRSProjects.UpSchool.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.StudentHandlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public UpdateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(UpdateStudentCommand command)
        {
            var student = _context.Students.Find(command.StudentID);
            student.Name = command.Name;
            student.Surname = command.Surname;
            student.Age = command.Age;
            student.City = command.City;
            _context.SaveChanges();
        }
    }
}
