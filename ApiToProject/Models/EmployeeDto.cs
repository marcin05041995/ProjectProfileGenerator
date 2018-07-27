﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Models
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public int YearsOfWork { get; set; }
    }
}
