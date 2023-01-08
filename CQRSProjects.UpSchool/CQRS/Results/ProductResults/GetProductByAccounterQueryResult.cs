using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Results.ProductResults
{
    public class GetProductByAccounterQueryResult
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public int Stock { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }
    }
}
