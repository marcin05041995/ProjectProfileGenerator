using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Uzupełnij pole")]
        public string SkillName { get; set; }


        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
