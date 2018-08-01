using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Models
{
    public class EmployeeViewModel
    {
        public Profile Profile { get; set; }
        public IList<ProfileSkill> Skills { get; set; }
        public IList<ProfileProject> Projects { get; set; }
        public IList<ProfileLanguage> Languages { get; set; }
    }
}
