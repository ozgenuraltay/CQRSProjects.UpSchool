using CQRSProjects.UpSchool.CQRS.Queries.ProductQueries;
using CQRSProjects.UpSchool.CQRS.Results.ProductResults;
using CQRSProjects.UpSchool.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.ProductHandlers
{
    public class GetProductByAcounterQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductByAcounterQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductByAccounterQueryResult> Handle()
        {
            var result = _productContext.Products.Select(x => new GetProductByAccounterQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Stock = x.Stock,
                Brand = x.Brand,
                SalePrice = x.SalePrice,
                PurchasePrice = x.PurchasePrice
            }).AsNoTracking().ToList();

            return result;

        }
    }
}
