using CQRSProjects.UpSchool.CQRS.Queries.ProductQueries;
using CQRSProjects.UpSchool.CQRS.Results.ProductResults;
using CQRSProjects.UpSchool.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.ProductHandlers
{
    public class GetProductByAccounterByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductByAccounterByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public GetProductByAccounterByIDQueryResult Handle(GetProductByAccounterByIDQuery query)
        {
            var values = _productContext.Products.Find(query.ProductID);
            return new GetProductByAccounterByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Description = values.Description,
                Name = values.Name,
                PurchasePrice = values.PurchasePrice,
                SalePrice = values.SalePrice,
                Stock = values.Stock,
                Tax = values.Tax
            };
        }
    }
}
