﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Uzupełnij pole: ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Uzupełnij pole: ")]
        public string ClientSector { get; set; }

        [Required(ErrorMessage = "Uzupełnij pole: ")]
        public string Technologies { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }

    }
}
