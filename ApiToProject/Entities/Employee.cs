using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Podaj imie")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Podaj nazwisko")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage ="Podaj specjzalizacje")]
        public string Specialization { get; set; }

        [Required(ErrorMessage = "Podaj rating")]
        [Range(1, 5, ErrorMessage = "Zakres jest od 1 do 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage ="Podaj ilość lat pracy w zawodzie.")]
        public int YearsOfWork { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public ICollection<EmployeeLanguage> EmployeeLanguages { get; set; }
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }

        //public ICollection<Skill> Skills { get; set; }
        //= new List<Skill>();

        //public ICollection<Language> Languages { get; set; }
        //= new List<Language>();

    }
}
