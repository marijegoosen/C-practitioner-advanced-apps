using CarCompany.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Project
    {
        [Key]
        public long ProjectId { get; set; }

        //public EProjectType ProjectType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public User User { get; set; }
        public IList<Skill> Skills { get; set; }
    }
}
