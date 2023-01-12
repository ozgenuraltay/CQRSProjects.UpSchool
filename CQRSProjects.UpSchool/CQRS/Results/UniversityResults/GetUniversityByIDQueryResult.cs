using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Results.UniversityResults
{
    public class GetUniversityByIDQueryResult
    {
        public int UniversityID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Population { get; set; }
    }
}
