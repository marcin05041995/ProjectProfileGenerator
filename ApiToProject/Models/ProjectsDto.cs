using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Models
{
    public class ProjectsDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ClientSector { get; set; }
        public string Technologies { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Guid EmployeeId { get; set; }
       
    }
}
