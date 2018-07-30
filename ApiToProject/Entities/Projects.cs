using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Entities
{
    public class Projects
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Uzupełnij pole: ")]
        [MaxLength(50,ErrorMessage ="Max 50 znaków")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Uzupełnij pole: ")]
        [MaxLength(50, ErrorMessage = "Max 50 znaków")]
        public string ClientSector { get; set; }

        [Required(ErrorMessage = "Uzupełnij pole: ")]
        [MaxLength(50, ErrorMessage = "Max 50 znaków")]
        public string Technologies { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public ICollection<Employee> Employees { get; set; }
        = new List<Employee>();
    }
}
