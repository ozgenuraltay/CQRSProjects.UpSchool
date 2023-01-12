using CQRSProjects.UpSchool.CQRS.Results.StudentResults;
using CQRSProjects.UpSchool.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Handlers.StudentHandlers
{
    public class GetAllStudentQueryHandler
    {
        private readonly ProductContext _context;

        public GetAllStudentQueryHandler(ProductContext context)
        {
            _context = context;
        }

        public List<GetAllStudentQueryResult> Handle()
        {
            var students = _context.Students.Select(x =>
              new GetAllStudentQueryResult
              {
                  StudentID = x.StudentID,
                  Name = x.Name,
                  Surname = x.Surname,
                  City = x.City,
                  Department = x.Department
              }).AsNoTracking().ToList();

            return students;
        }
    }
}
