using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Models
{
    public class ProfileSkill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Experience { get; set; }
        public int Profficiency { get; set; }
    }
}
