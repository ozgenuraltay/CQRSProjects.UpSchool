using CQRSProjects.UpSchool.CQRS.Results.UniversityResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Queries.UniversityQueries
{
    public class GetAllUniversityQuery:IRequest<List<GetAllUniversityQueryResult>>
    {
    }
}
