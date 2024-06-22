using LaboFinalAPIDAL.Configurations;
using LaboFinalAPIDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL
{
    public class DDBContext : DbContext
    {
        DbSet<TypesItems> TypesItems { get; set; }
        DbSet<Items> Items { get; set; }
        DbSet<Sources> Sources { get; set; }
        DbSet<Spells> Spells { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-HSV5O301;database=Labofinal2024;Integrated Security=True;Trust Server Certificate=True",
                b => b.MigrationsAssembly("LaboFinalAPIDAL"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new typesItemsConfig());
            //modelBuilder.ApplyConfiguration(new ItemsConfig());
        }
    }
}
