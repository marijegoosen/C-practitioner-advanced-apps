using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Car
    {
        [Key]
        public long CarId { get; set; }

        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Range { get; set; }
        public double Mileage { get; set; }
        public Company Company { get; set; }
        public User User { get; set; }
    }
}
