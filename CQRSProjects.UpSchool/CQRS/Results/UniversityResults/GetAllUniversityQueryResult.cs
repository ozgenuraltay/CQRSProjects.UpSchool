using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool.CQRS.Results.UniversityResults
{
    public class GetAllUniversityQueryResult
    {
        public int UniversityID { get; set; }

        public string Name { get; set; }

        public string Town { get; set; }
    }
}
