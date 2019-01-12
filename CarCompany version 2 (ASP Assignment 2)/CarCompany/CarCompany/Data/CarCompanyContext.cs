using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarCompany.Models;

namespace CarCompany.Models
{
    public class CarCompanyContext : DbContext
    {
        public CarCompanyContext (DbContextOptions<CarCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<CarCompany.Models.Car> Car { get; set; }

        public DbSet<CarCompany.Models.Company> Company { get; set; }

        public DbSet<CarCompany.Models.Project> Project { get; set; }

        public DbSet<CarCompany.Models.Skill> Skill { get; set; }

        public DbSet<CarCompany.Models.User> User { get; set; }
    }
}
