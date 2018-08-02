using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiToProject.InputModels
{
    public class InputLanguageModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Speaking { get; set; }
        public int Writing { get; set; }
        public int Reading { get; set; }
    }
}
