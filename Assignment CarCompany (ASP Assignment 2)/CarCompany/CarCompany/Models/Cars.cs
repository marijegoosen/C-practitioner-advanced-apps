using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Car
    {
        public long CarId { get; set; }
        public string Company { get; set; }
        public string User { get; set; }

        public int NumberWheels { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }

    }
}
