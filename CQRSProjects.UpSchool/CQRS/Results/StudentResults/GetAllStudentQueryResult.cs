﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Results.StudentResults
{
    public class GetAllStudentQueryResult
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }

        public string Department { get; set; }
    }
}
