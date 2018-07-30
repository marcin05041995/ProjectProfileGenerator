using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class EmployeeLanguage
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public int LanguageId { get; set; }

        public Employee Employee { get; set; }
        public Language Language { get; set; }
    }
}
