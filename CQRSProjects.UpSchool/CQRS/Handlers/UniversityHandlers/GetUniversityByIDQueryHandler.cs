using CQRSProjects.UpSchool.CQRS.Queries.UniversityQueries;
using CQRSProjects.UpSchool.CQRS.Results.UniversityResults;
using CQRSProjects.UpSchool.DAL.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler:IRequestHandler<GetUniversityByIDQuery,GetUniversityByIDQueryResult>
    {
        private readonly ProductContext _context;

        public GetUniversityByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public async Task<GetUniversityByIDQueryResult> Handle(GetUniversityByIDQuery request, CancellationToken cancellationToken)
        {
            var universities = await _context.Universitys.FindAsync(request.id);
            return new GetUniversityByIDQueryResult
            {
                UniversityID = universities.UniversityID,
                City=universities.City,
                Name=universities.Name,
                Population=universities.Population
            }; ;
        }
    }
}
