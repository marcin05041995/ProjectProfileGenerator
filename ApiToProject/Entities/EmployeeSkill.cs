using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class EmployeeSkill
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public int SkillId { get; set; }

        public Skill Skill { get; set; }
        public Employee Employee { get; set; }
    }
}
