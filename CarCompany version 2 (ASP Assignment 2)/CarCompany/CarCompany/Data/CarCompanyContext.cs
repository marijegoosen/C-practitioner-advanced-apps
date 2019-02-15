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

        public DbSet<Car> Car { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<User> User { get; set; }


    }
}
