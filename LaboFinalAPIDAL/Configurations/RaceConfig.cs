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
    internal class RaceConfig : IEntityTypeConfiguration<Races>
    {
        public void Configure(EntityTypeBuilder<Races> builder)
        {
            builder.HasData(
                new Races
                {
                    Id = 1,
                    Race = "Humain",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "1",
                    DexterityBonus = "1",
                    ConstitutionBonus = "1",
                    IntelligenceBonus = "1",
                    WisdomBonus = "1",
                    CharismsBonus = "1",
                    SourceId = 1
                },
                new Races
                {
                    Id = 2,
                    Race = "Haut-elfe",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "2",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "1",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 3,
                    Race = "Humain (Don)",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "0",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 4,
                    Race = "Nain",
                    Size = "M",
                    Speed = "7m/round",
                    StrenghtBonus = "2",
                    DexterityBonus = "0",
                    ConstitutionBonus = "2",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 5,
                    Race = "Gnome",
                    Size = "P",
                    Speed = "7m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "0",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "2",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 6,
                    Race = "Demi-Orc",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "2",
                    DexterityBonus = "0",
                    ConstitutionBonus = "1",
                    IntelligenceBonus = "-2",
                    WisdomBonus = "0",
                    CharismsBonus = "-1",
                    SourceId = 1
                },
                new Races
                {
                    Id = 7,
                    Race = "Tieffelin",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "0",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "2",
                    WisdomBonus = "1",
                    CharismsBonus = "1",
                    SourceId = 1
                },
                new Races
                {
                    Id = 8,
                    Race = "Elfe Noire",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "2",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 9,
                    Race = "Elfe des Montagnes",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "2",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                }
            );
        }
    }
}
