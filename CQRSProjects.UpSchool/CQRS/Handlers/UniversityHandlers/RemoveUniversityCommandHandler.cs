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
    public class RemoveUniversityCommandHandler:IRequestHandler<RemoveUniversityCommand>
    {
        private readonly ProductContext _context;

        public RemoveUniversityCommandHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveUniversityCommand request, CancellationToken cancellationToken)
        {
            var university = _context.Universitys.Find(request.id);
            _context.Universitys.Remove(university);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
