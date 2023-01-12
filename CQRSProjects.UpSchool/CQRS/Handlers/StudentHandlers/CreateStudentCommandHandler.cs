using CQRSProjects.UpSchool.CQRS.Commands.StudentCommands;
using CQRSProjects.UpSchool.DAL.Context;
using CQRSProjects.UpSchool.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler
    {
        private readonly ProductContext _context;

        public CreateStudentCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public void Handle(CreateStudentCommand command)
        {
            _context.Students.Add(new Student
            {
                Name = command.Name,
                Surname=command.Surname,
                Age=command.Age,
                City=command.City,
                Status=false
            });
            _context.SaveChanges();
        }
    }
}
