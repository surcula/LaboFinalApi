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
        DbSet<BackgroundsItems> BackgroundsItems { get; set; }
        DbSet<Backgrounds> Backgrounds { get; set; }
        DbSet<BackgroundsSkills> BackgroundSkills { get; set; }
        DbSet<Classes> Classes { get; set; }
        DbSet<ClassSkills> ClassSkills { get; set; }
        DbSet<Entities> Entities { get; set; }
        DbSet<EntitySkills> entitySkills { get; set; }  
        DbSet<Inventories> inventories { get; set; }
        DbSet<Items> Items { get; set; }
        DbSet<Languages> Languages { get; set; }
        DbSet<RaceLanguages> RaceLanguages { get; set; }
        DbSet<Races> Races { get; set; }
        DbSet<Roles> Roles { get; set; }
        DbSet<Skills> Skills { get; set; }
        DbSet<Sources> Sources { get; set; }
        DbSet<Spells> Spells { get; set; }
        DbSet<TypesItems> TypesItems { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<Feats> Feats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;database=LaboFinal;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False",
            //    b => b.MigrationsAssembly("LaboFinalAPIDAL"));
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-HSV5O301;database=Labofinal2024;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BackgroundsConfig());
            modelBuilder.ApplyConfiguration(new BackgroundsItemsConfig());
            modelBuilder.ApplyConfiguration(new BackgroundSkillsConfig());
            modelBuilder.ApplyConfiguration(new ClassesConfig());
            modelBuilder.ApplyConfiguration(new ClassSkillConfig());
            modelBuilder.ApplyConfiguration(new EntitiesConfig());
            modelBuilder.ApplyConfiguration(new FeatsConfig());
            modelBuilder.ApplyConfiguration(new ItemsConfig());
            modelBuilder.ApplyConfiguration(new LanguagesConfig());
            modelBuilder.ApplyConfiguration(new RaceLanguagesConfig());
            modelBuilder.ApplyConfiguration(new RacesConfig());
            modelBuilder.ApplyConfiguration(new SkillsConfig());
            modelBuilder.ApplyConfiguration(new SourcesConfig());
            modelBuilder.ApplyConfiguration(new SpellsConfig());
            modelBuilder.ApplyConfiguration(new TypeItemConfig());

        }
    }
}
