using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class User
    {
        public long UserId { get; set; }
        public int NumberOfCars { get; set; }
        public string Car { get; set; }
        public string Company { get; set; }

        //Optional
        public int NumberOfProjects { get; set; }
        public string Projects { get; set; }
        public string Skills { get; set; }
    }
}
