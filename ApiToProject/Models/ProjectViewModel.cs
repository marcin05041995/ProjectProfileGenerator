using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Models
{
    public class ProjectViewModel
    {
        public ProfileProject ProfileProject { get; set; }
        public IList<Profile> Profiles { get; set; }
    }
}
