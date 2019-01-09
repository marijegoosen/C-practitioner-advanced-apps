using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Car
    {
        public long CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Range { get; set; }
        public double Mileage { get; set; }
        public Company CompanyID { get; set; }
        public User User { get; set; }
    }
}
