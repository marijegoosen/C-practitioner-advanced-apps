﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Domain
{
    public class UserToProject
    {
        public User User { get; set; }
        public string UserId { get; set; }
        public Project2 Project2 { get; set; }
        public int Project2Id { get; set; }
    }
}
