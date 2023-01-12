using CQRSProjects.UpSchool.CQRS.Queries.StudentQueries;
using CQRSProjects.UpSchool.CQRS.Results.StudentResults;
using CQRSProjects.UpSchool.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly ProductContext _context;

        public GetStudentByIDQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public GetStudentByIDQueryResult Handle(GetStudentByIDQuery query)
        {
            var student = _context.Students.Find(query.id);
            return new GetStudentByIDQueryResult
            {
                StudentID=student.StudentID,
                Name=student.Name,
                Surname=student.Surname,
                Age=student.Age,
                City=student.City
            };
        }
    }
}
