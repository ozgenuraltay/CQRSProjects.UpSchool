using CQRSProjects.UpSchool.CQRS.Commands.ProductCommands;
using CQRSProjects.UpSchool.CQRS.Handlers.ProductHandlers;
using CQRSProjects.UpSchool.CQRS.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductByAcounterQueryHandler _getProductByAcounterQueryHandler;
        private readonly GetProductByStoragerQueryHandler _getProductByStoragerQueryHandler;
        private readonly GetProductByHumanResourceByIDQueryHandler _getProductByHumanResourceByIDQueryHandler;
        private readonly GetProductByAccounterByIDQueryHandler _getProductByAccounterByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(GetProductByAcounterQueryHandler getProductByAcounterQueryHandler, GetProductByStoragerQueryHandler getProductByStoragerQueryHandler, GetProductByHumanResourceByIDQueryHandler getProductByHumanResourceByIDQueryHandler, GetProductByAccounterByIDQueryHandler getProductByAccounterByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductByAcounterQueryHandler = getProductByAcounterQueryHandler;
            _getProductByStoragerQueryHandler = getProductByStoragerQueryHandler;
            _getProductByHumanResourceByIDQueryHandler = getProductByHumanResourceByIDQueryHandler;
            _getProductByAccounterByIDQueryHandler = getProductByAccounterByIDQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductByAcounterQueryHandler.Handle();

            return View(values);
        }

        public IActionResult StoragerIndex()
        {
            var values = _getProductByStoragerQueryHandler.Handle();

            return View(values);
        }

        public IActionResult HumanResourceIndex(int id)
        {
            var values = _getProductByHumanResourceByIDQueryHandler.Handle(new GetProductByHumanResourceByIDQuery(id));

            return View(values);
        }

        public IActionResult AccounterIndexByID(int id)
        {
            var values = _getProductByAccounterByIDQueryHandler.Handle(new GetProductByAccounterByIDQuery(id));

            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
