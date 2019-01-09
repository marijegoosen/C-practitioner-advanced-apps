using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Models
{
    public class Company
    {
        public long CompanyId { get; set; }
        public string Description { get; set; }
        public string Mission { get; set; }
        public string Strategy { get; set; }
        public string Vision { get; set; }
        public string Website { get; set; }
        public IList<Car> Cars { get; set; }

    }
}
