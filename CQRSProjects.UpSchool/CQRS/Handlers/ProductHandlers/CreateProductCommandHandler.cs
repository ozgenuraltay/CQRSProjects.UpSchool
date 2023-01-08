using CQRSProjects.UpSchool.CQRS.Commands.ProductCommands;
using CQRSProjects.UpSchool.DAL.Context;
using CQRSProjects.UpSchool.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                Name = command.Name,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Size = command.Size,
                ProductOfDate = command.ProductOfDate,
                EndOfDate = command.EndOfDate,
                Status = true
            });
            _productContext.SaveChanges();
        }
    }
}
