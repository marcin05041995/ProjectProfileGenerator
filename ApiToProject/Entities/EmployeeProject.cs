using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class EmployeeProject
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }

        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
