using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Domain
{
    public class User
    {
        public IList<UserToProject> Projects { get; set; }
    }
}
