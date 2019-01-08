using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Company
    {
        public long CompanyId { get; set; }
        public string Owner { get; set; }
        public int NumberOfCars { get; set; }
        public string Car { get; set; }
        public DateTime DateFounding { get; set; }

    }
}
