using CQRSProjects.UpSchool.CQRS.Commands.UniversityCommands;
using CQRSProjects.UpSchool.DAL.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.UniversityHandlers
{
    public class UpdateUniversityCommandHandler : IRequestHandler<UpdateUniversityCommand>
    {
        private readonly ProductContext _context;

        public UpdateUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUniversityCommand request, CancellationToken cancellationToken)
        {
            var university = _context.Universitys.Find(request.UniversityID);
            university.Name = request.Name;
            university.City = request.City;
            university.Population = request.Population;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
