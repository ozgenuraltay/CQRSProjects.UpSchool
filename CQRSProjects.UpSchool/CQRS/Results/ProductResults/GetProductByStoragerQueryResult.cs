using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Results.ProductResults
{
    public class GetProductByStoragerQueryResult
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Storage { get; set; }
    }
}
