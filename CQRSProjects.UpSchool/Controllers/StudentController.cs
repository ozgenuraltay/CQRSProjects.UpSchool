using CQRSProjects.UpSchool.CQRS.Commands.StudentCommands;
using CQRSProjects.UpSchool.CQRS.Handlers.StudentHandlers;
using CQRSProjects.UpSchool.CQRS.Queries.StudentQueries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.Controllers
{
    public class StudentController : Controller
    {
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;
        private readonly GetStudentByIDQueryHandler _getStudentByIDQueryHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;

        public StudentController(CreateStudentCommandHandler createStudentCommandHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _createStudentCommandHandler = createStudentCommandHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(CreateStudentCommand createStudentCommand)
        {
            _createStudentCommandHandler.Handle(createStudentCommand);
            return RedirectToAction("Index");
        }
        
        public IActionResult Index()
        {
            var students = _getAllStudentQueryHandler.Handle();
            return View(students);
        }

        public IActionResult DeleteStudent(int id)
        {
            _removeStudentCommandHandler.Handle(new RemoveStudentCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var student=_getStudentByIDQueryHandler.Handle(new GetStudentByIDQuery(id));
            return View(student);
        }

        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
             return RedirectToAction("Index");
        }
    }
}
