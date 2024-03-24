using Entites.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    // Context= Db tabloları ile  proje claslarına bağlamak
    public class RecapDataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ozgun\sqlexpress;Database=RecapData;TrustServerCertificate=True;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<CarColor> Colors { get; set; }
    
    }
}
