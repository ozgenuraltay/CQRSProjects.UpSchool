using CQRSProjects.UpSchool.CQRS.Results.UniversityResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIDQuery:IRequest<GetUniversityByIDQueryResult>
    {
        public int id { get; set; }

        public GetUniversityByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
