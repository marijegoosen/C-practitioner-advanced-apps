using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Project
    {
        public long ProjectId { get; set; }
        public string User { get; set; }
        public int NumberOfSkills { get; set; }
        public string Skills { get; set; }
    }
}
