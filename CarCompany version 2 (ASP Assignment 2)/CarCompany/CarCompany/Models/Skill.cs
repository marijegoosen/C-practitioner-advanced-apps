using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Skill
    {
        [Key]
        public long SkillId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Company CompanyID { get; set; }
    }
}
