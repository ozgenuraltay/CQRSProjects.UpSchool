using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Queries.ProductQueries
{
    public class GetProductByAccounterByIDQuery
    {
        public int ProductID { get; set; }

        public GetProductByAccounterByIDQuery(int id)
        {
            ProductID = id;
        }
    }
}
