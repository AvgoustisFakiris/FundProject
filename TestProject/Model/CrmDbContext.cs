using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Model
{
    public class CrmDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public object Project { get; internal set; }

        //  public DbSet<Basket> Baskets { get; set; }
        //  public DbSet<BasketProduct> BasketProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //  optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=RegenCrm;Integrated Security=True");
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CrowdFunding;User ID=sa;Password=admin!@#123");

        }

    }
}
