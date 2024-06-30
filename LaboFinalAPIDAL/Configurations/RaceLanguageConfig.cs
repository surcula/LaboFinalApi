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
                // Haut elfe
                new RaceLanguages { Id = 1, RaceId = 1, LanguageId = 1 },
                new RaceLanguages { Id = 2, RaceId = 1, LanguageId = 3 },

                // elfe des bois
                new RaceLanguages { Id = 3, RaceId = 2, LanguageId = 1 },
                new RaceLanguages { Id = 4, RaceId = 2, LanguageId = 3 },

                // elfe noir
                new RaceLanguages { Id = 5, RaceId = 3, LanguageId = 1 },
                new RaceLanguages { Id = 6, RaceId = 3, LanguageId = 3 },

                // halfelin pied-léger
                new RaceLanguages { Id = 7, RaceId = 4, LanguageId = 1 },
                new RaceLanguages { Id = 8, RaceId = 4, LanguageId = 5 },

                // halfelin robuste
                new RaceLanguages { Id = 9, RaceId = 5, LanguageId = 1 },
                new RaceLanguages { Id = 10, RaceId = 5, LanguageId = 5 },

                // humain
                new RaceLanguages { Id = 11, RaceId = 6, LanguageId = 1 },

                // humain(don)
                new RaceLanguages { Id = 12, RaceId = 7, LanguageId = 1 },

                // nain des colines
                new RaceLanguages { Id = 13, RaceId = 8, LanguageId = 1 },
                new RaceLanguages { Id = 14, RaceId = 8, LanguageId = 2 },

                // nain des montagnes
                new RaceLanguages { Id = 15, RaceId = 9, LanguageId = 1 },
                new RaceLanguages { Id = 16, RaceId = 9, LanguageId = 2 },

                // Demi-elfe
                new RaceLanguages { Id = 17, RaceId = 10, LanguageId = 1 },
                new RaceLanguages { Id = 18, RaceId = 10, LanguageId = 3 },

                // Demi-orc
                new RaceLanguages { Id = 19, RaceId = 11, LanguageId = 1 },
                new RaceLanguages { Id = 20, RaceId = 11, LanguageId = 6 },

                // Drakéide
                new RaceLanguages { Id = 21, RaceId = 12, LanguageId = 1 },
                new RaceLanguages { Id = 22, RaceId = 12, LanguageId = 10 },

                // Gnome des forêts
                new RaceLanguages { Id = 23, RaceId = 13, LanguageId = 1 },
                new RaceLanguages { Id = 24, RaceId = 13, LanguageId = 4 },

                // Gnome des roches
                new RaceLanguages { Id = 25, RaceId = 14, LanguageId = 1 },
                new RaceLanguages { Id = 26, RaceId = 14, LanguageId = 4 },

                // Tieffelin
                new RaceLanguages { Id = 27, RaceId = 15, LanguageId = 1 },
                new RaceLanguages { Id = 28, RaceId = 15, LanguageId = 11 }
            );
        }
    }
}