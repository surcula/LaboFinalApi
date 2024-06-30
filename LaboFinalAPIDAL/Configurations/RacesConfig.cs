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
    internal class RacesConfig : IEntityTypeConfiguration<Races>
    {
        public void Configure(EntityTypeBuilder<Races> builder)
        {
            builder.HasData(
                new Races
                {
                    Id = 1,
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
                    Id = 2,
                    Race = "elfe des bois",
                    Size = "M",
                    Speed = "10,5m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "2",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "1",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 3,
                    Race = "elfe noir",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "2",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "1",
                    SourceId = 1
                },
                new Races
                {
                    Id = 4,
                    Race = "Halfelin pied-léger",
                    Size = "P",
                    Speed = "7,5m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "2",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "1",
                    SourceId = 1
                },
                new Races
                {
                    Id = 5,
                    Race = "Halfelin robuste",
                    Size = "P",
                    Speed = "7,5m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "2",
                    ConstitutionBonus = "1",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                }, new Races
                {
                    Id = 6,
                    Race = "Humain ",
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
                    Id = 7,
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
                    Id = 8,
                    Race = "Nain des collines",
                    Size = "M",
                    Speed = "7,5m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "0",
                    ConstitutionBonus = "2",
                    IntelligenceBonus = "0",
                    WisdomBonus = "1",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 9,
                    Race = "Nain des montagnes",
                    Size = "M",
                    Speed = "7.5m/round",
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
                    Id = 10,
                    Race = "Demi-elfe",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "0",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "2",
                    SourceId = 1
                },
                new Races
                {
                    Id = 11,
                    Race = "Demi-Orc",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "2",
                    DexterityBonus = "0",
                    ConstitutionBonus = "1",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
               
                new Races
                {
                    Id = 12,
                    Race = "Drakéide",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "2",
                    DexterityBonus = "0",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "0",
                    WisdomBonus = "0",
                    CharismsBonus = "1",
                    SourceId = 1
                },                
                new Races
                {
                    Id = 13,
                    Race = "Gnome des forêts",
                    Size = "P",
                    Speed = "7,5m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "1",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "2",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 14,
                    Race = "Gnome des roches",
                    Size = "P",
                    Speed = "7,5m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "0",
                    ConstitutionBonus = "1",
                    IntelligenceBonus = "2",
                    WisdomBonus = "0",
                    CharismsBonus = "0",
                    SourceId = 1
                },
                new Races
                {
                    Id = 15,
                    Race = "Tieffelin",
                    Size = "M",
                    Speed = "9m/round",
                    StrenghtBonus = "0",
                    DexterityBonus = "0",
                    ConstitutionBonus = "0",
                    IntelligenceBonus = "1",
                    WisdomBonus = "0",
                    CharismsBonus = "2",
                    SourceId = 1
                },
                new Races{ Id = 16, Race = "Aarakocra", Size = "M", Speed = "7,5m/round (marche), 15m/round (vol)", SourceId = 9 },
                new Races { Id = 17, Race = "Aasimar", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 18, Race = "Centaure", Size = "M", Speed = "12m/round", SourceId = 9 },
                new Races { Id = 19, Race = "Changeling", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 20, Race = "Conil", Size = "P", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 21, Race = "Dhampire", Size = "M", Speed = "9m/round", SourceId = 10 },
                new Races { Id = 22, Race = "Duergar", Size = "M", Speed = "7,5m/round", SourceId = 10 },
                new Races { Id = 23, Race = "Eladrin", Size = "M", Speed = "9m/round", SourceId = 10 },
                new Races { Id = 24, Race = "Elfe aquatique", Size = "M", Speed = "9m/round, 9m/nage", SourceId = 10 },
                new Races { Id = 25, Race = "Fadette", Size = "M", Speed = "10,5m/round", SourceId = 10 },
                new Races { Id = 26, Race = "Féral", Size = "M", Speed = "9m/round", SourceId = 10 },
                new Races { Id = 27, Race = "Firbolg", Size = "M", Speed = "9m/round", SourceId = 10 },
                new Races { Id = 28, Race = "Forgelier", Size = "M", Speed = "9m/round", SourceId = 11 },
                new Races { Id = 29, Race = "Genasi (Air)", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 30, Race = "Genasi (Terre)", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 31, Race = "Genasi (Feu)", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 32, Race = "Genasi (Eau)", Size = "M", Speed = "9m/round, 9m/nage", SourceId = 9 },
                new Races { Id = 33, Race = "Githzerai", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 34, Race = "Gnome des profondeurs", Size = "P", Speed = "7,5m/round", SourceId = 9 },
                new Races { Id = 35, Race = "Gobelin", Size = "P", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 36, Race = "Gobelours", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 37, Race = "Goliath", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 38, Race = "Halfelin sagespectre", Size = "P", Speed = "7,5m/round", SourceId = 12 },
                new Races { Id = 39, Race = "Hiboulin", Size = "M", Speed = "9m/round (marche), 10,5m/round (vol)", SourceId = 13 },
                new Races { Id = 40, Race = "Hobgobelin", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 41, Race = "Homme-Lézard", Size = "M", Speed = "9m/round, 9m/nage", SourceId = 9 },
                new Races { Id = 42, Race = "Kenku", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 43, Race = "Kobold", Size = "P", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 44, Race = "Minotaure", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 45, Race = "Orc", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 46, Race = "Ressucité", Size = "M", Speed = "9m/round", SourceId = 10 },
                new Races { Id = 47, Race = "Sang maudit", Size = "M", Speed = "9m/round", SourceId = 10 },
                new Races { Id = 48, Race = "Satyre", Size = "M", Speed = "10,5m/round", SourceId = 9 },
                new Races { Id = 49, Race = "Shadar-kai", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 50, Race = "Tabaxi", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 51, Race = "Torte", Size = "M", Speed = "9m/round", SourceId = 9 },
                new Races { Id = 52, Race = "Triton", Size = "M", Speed = "9m/round, 9m/nage", SourceId = 9 },
                new Races { Id = 53, Race = "Yuan-ti", Size = "M", Speed = "9m/round", SourceId = 3 }

            );
        }
    }
}
