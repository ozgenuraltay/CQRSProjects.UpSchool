using CQRSProjects.UpSchool.CQRS.Queries.UniversityQueries;
using CQRSProjects.UpSchool.CQRS.Results.UniversityResults;
using CQRSProjects.UpSchool.DAL.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.UniversityHandlers
{
    public class GetAllUniversityQueryHandler:IRequestHandler<GetAllUniversityQuery,List<GetAllUniversityQueryResult>>
    {
        private readonly ProductContext _context;

        public GetAllUniversityQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllUniversityQueryResult>> Handle(GetAllUniversityQuery request, CancellationToken cancellationToken)
        {
            return await _context.Universitys.Select(x =>
            new GetAllUniversityQueryResult
            {
                UniversityID = x.UniversityID,
                Name = x.Name,
                Town = x.City
            }).AsNoTracking().ToListAsync();
        }
    }
}
