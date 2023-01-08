using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Queries.ProductQueries
{
    public class GetProductByHumanResourceByIDQuery
    {
        public GetProductByHumanResourceByIDQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
