using CQRSProjects.UpSchool.CQRS.Commands.UniversityCommands;
using CQRSProjects.UpSchool.CQRS.Queries.UniversityQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IMediator _mediator;

        public UniversityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var universities =await _mediator.Send(new GetAllUniversityQuery());
            return View(universities);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUniversity(int id)
        {
            var university = await _mediator.Send(new GetUniversityByIDQuery(id));
            return View(university);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUniversity(UpdateUniversityCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddUniversity()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUniversity(CreateUniversityCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteUniversity(int id)
        {
            await _mediator.Send(new RemoveUniversityCommand(id));
            return RedirectToAction("Index");
        }
    }
}
