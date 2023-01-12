using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery
    {
        public int id { get; set; }

        public GetStudentByIDQuery(int id)
        {
            this.id = id;
        }
    }
}
