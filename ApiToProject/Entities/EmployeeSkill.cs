using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class EmployeeSkill
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }
        public Guid SkillId { get; set; }

        public Skill Skill { get; set; }
        public Employee Employee { get; set; }


        //[Required(ErrorMessage = "Uzupełnij pole")]
        //public double ExperienceInYears { get; set; }

        //[Required(ErrorMessage = "Uzupełnij pole")]
        //[Range(1, 5, ErrorMessage = "Oceń w skali od 1 do 5")]
        //public int Profficiency { get; set; }
    }
}
