using LaboFinalAPIDomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Configurations
{
    internal class RaceLanguageConfig : IEntityTypeConfiguration<RaceLanguages>
    {
        public void Configure(EntityTypeBuilder<RaceLanguages> builder)
        {
            builder.HasData(
                // Humain
                new RaceLanguages { Id = 1, RaceId = 1, LanguageId = 1 }, 
                // Haut-elfe
                new RaceLanguages { Id = 2, RaceId = 2, LanguageId = 3 }, 
                // Humain(don)
                new RaceLanguages { Id = 3, RaceId = 3, LanguageId = 2 },                                       
                // Nain
                 new RaceLanguages { Id = 4, RaceId = 4, LanguageId = 2 },                                                 
                // gnome
                new RaceLanguages { Id = 5, RaceId = 5, LanguageId = 4 },                                                         
                // Demi-orc
                new RaceLanguages { Id = 6, RaceId = 6, LanguageId = 23 }, 
                // Tieffelin
                new RaceLanguages { Id = 7, RaceId = 7, LanguageId = 15 },                                                                   
                // Elfe-noire
                new RaceLanguages { Id = 8, RaceId = 8, LanguageId = 3 },                                                                   
                // Elfe-des-montagnes
                new RaceLanguages { Id = 9, RaceId = 9, LanguageId = 3 }  
                                                                          
            );
        }
    }
}
