using CQRSProjects.UpSchool.CQRS.Commands.UniversityCommands;
using CQRSProjects.UpSchool.DAL.Context;
using CQRSProjects.UpSchool.DAL.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.UniversityHandlers
{
    public class CreateUniversityCommandHandler:IRequestHandler<CreateUniversityCommand>
    {
        private readonly ProductContext _context;

        public CreateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
        {
            _context.Universitys.Add(new University
            {
                Name = request.Name,
                City = request.City,
                Population = request.Population,
                FacultyCount = request.FacultyCount
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
