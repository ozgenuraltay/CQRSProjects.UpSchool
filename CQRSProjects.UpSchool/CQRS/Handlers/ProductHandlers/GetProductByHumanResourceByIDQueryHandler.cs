using CQRSProjects.UpSchool.CQRS.Queries.ProductQueries;
using CQRSProjects.UpSchool.CQRS.Results.ProductResults;
using CQRSProjects.UpSchool.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.ProductHandlers
{
    public class GetProductByHumanResourceByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductByHumanResourceByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public GetProductByHumanResourceByIDQueryResult Handle(GetProductByHumanResourceByIDQuery query)
        {
            var values = _productContext.Products.Find(query.ID);
            return new GetProductByHumanResourceByIDQueryResult
            {
                ProductID = values.ProductID,
                Name = values.Name,
                Brand = values.Brand,
                SalePrice = values.SalePrice
            };
        }
    }
}
