using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class Language
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Podaj jezyk")]
        public string LanguageName { get; set; }

        public ICollection<EmployeeLanguage> EmployeeLanguages { get; set; }
    }
}
