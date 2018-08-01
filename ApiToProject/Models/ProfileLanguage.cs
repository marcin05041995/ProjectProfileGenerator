using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.Models
{
    public class ProfileLanguage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Speaking { get; set; }
        public int Writing { get; set; }
        public int Reading { get; set; }
    }
}
