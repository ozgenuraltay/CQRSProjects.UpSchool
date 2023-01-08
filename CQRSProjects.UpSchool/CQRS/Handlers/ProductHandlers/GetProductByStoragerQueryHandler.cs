using CQRSProjects.UpSchool.CQRS.Results.ProductResults;
using CQRSProjects.UpSchool.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.ProductHandlers
{
    public class GetProductByStoragerQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductByStoragerQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductByStoragerQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductByStoragerQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Storage = x.Storage
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
