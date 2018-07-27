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
        [MaxLength(20,ErrorMessage ="Max 20 znaków")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Podaj nazwisko")]
        [MaxLength(30,ErrorMessage ="Max 30 znaków")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage ="Podaj specjzalizacje")]
        [MaxLength(50,ErrorMessage ="Max 50 znaków")]
        public string Specialization { get; set; }

        [Required(ErrorMessage ="Podaj ilość lat pracy w zawodzie.")]
        [MaxLength(2,ErrorMessage ="Error")]
        public int YearsOfWork { get; set; }
    }
}
