using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Domain
{
    public class SkillToProject
    {
        [Key]
        public int Id { get; set; }
        public Skill Skill { get; set; }
        public int SkillId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
