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
    internal class LanguageConfig : IEntityTypeConfiguration<Languages>
    {
        public void Configure(EntityTypeBuilder<Languages> builder)
        {
            builder.HasData([
                    new Languages { Id = 1, Language = "Commun" },
                new Languages { Id = 2, Language = "Nain" },
                new Languages { Id = 3, Language = "Elfe" },
                new Languages { Id = 4, Language = "Gnome" },
                new Languages { Id = 5, Language = "Halfelin" },
                new Languages { Id = 6, Language = "Orque" },
                new Languages { Id = 7, Language = "Abyssal" },
                new Languages { Id = 8, Language = "Céleste" },
                new Languages { Id = 9, Language = "Commun des profondeurs" },
                new Languages { Id = 10, Language = "Draconique" },
                new Languages { Id = 11, Language = "Infernal" },
                new Languages { Id = 12, Language = "Primordial" },
                new Languages { Id = 13, Language = "Sylvestre" },
                new Languages { Id = 14, Language = "Squelettique" },
                new Languages { Id = 15, Language = "Ignan" },
                new Languages { Id = 16, Language = "Terran" },
                new Languages { Id = 17, Language = "Aquatique" },
                new Languages { Id = 18, Language = "Auran" },
                new Languages { Id = 19, Language = "Géant" },
                new Languages { Id = 20, Language = "Gobelin" },
                new Languages { Id = 21, Language = "Gnoll" },
                new Languages { Id = 22, Language = "Halfling" },
                new Languages { Id = 23, Language = "Orc" },
                new Languages { Id = 24, Language = "Profond" },
                new Languages { Id = 25, Language = "Chaque" },
                new Languages { Id = 26, Language = "Mortel" },
                new Languages { Id = 27, Language = "Mouvement" },
                new Languages { Id = 28, Language = "Liaison" },
                new Languages { Id = 29, Language = "Ces" },
                new Languages { Id = 30, Language = "Ici" },
                new Languages { Id = 31, Language = "Mortelle" },
                new Languages { Id = 32, Language = "Moustique" },
                new Languages { Id = 33, Language = "L'Argile" },
                new Languages { Id = 34, Language = "Monde" },
                new Languages { Id = 35, Language = "Merveilles" },
                new Languages { Id = 36, Language = "Messager" },
                new Languages { Id = 37, Language = "Aujourd'hui" },
                new Languages { Id = 38, Language = "Peut" },
                new Languages { Id = 39, Language = "Les" },
                new Languages { Id = 40, Language = "L'Immonde" },
                new Languages { Id = 41, Language = "Meuble" },
                new Languages { Id = 42, Language = "Migale" }
                ]);
        }
    }
}
