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
    internal class BackgroundsConfig : IEntityTypeConfiguration<Backgrounds>
    {
        public void Configure(EntityTypeBuilder<Backgrounds> builder)
        {
            builder.HasData([
                new Backgrounds
                {
                    Id = 1,
                    Background = "Acolyte",
                    LanguageNumber = 2,
                    Feature = "Abri du fidèle",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 2,
                    Background = "Artisan de guilde",
                    LanguageNumber = 1,
                    Feature = "Membre de guilde (soutiens des compagnons de guilde)",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 3,
                    Background = "Artiste",
                    LanguageNumber = 0,
                    Feature = "À la demande du public",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 4,
                    Background = "Charlatan",
                    LanguageNumber = 0,
                    Feature = "Fausse identité",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 5,
                    Background = "Chevalier",
                    LanguageNumber = 1,
                    Feature = "Domestiques",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 6,
                    Background = "Criminel",
                    LanguageNumber = 0,
                    Feature = "Accointances avec la pègre",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 7,
                    Background = "Enfant des rues",
                    LanguageNumber = 0,
                    Feature = "Secrets de la ville (trouver un passage dans un labyrinthe urbain et se déplacer en ville 2 fois plus rapidement)",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 8,
                    Background = "Ermite",
                    LanguageNumber = 1,
                    Feature = "Découverte",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 9,
                    Background = "Héros du peuple",
                    LanguageNumber = 0,
                    Feature = "Hospitalité rustique",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 10,
                    Background = "Marin",
                    LanguageNumber = 0,
                    Feature = "Place à bord",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 11,
                    Background = "Noble",
                    LanguageNumber = 1,
                    Feature = "Apanage de la noblesse (bienvenue dans la haute société)",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 12,
                    Background = "Sage",
                    LanguageNumber = 2,
                    Feature = "Chercheur",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 13,
                    Background = "Sauvageon",
                    LanguageNumber = 1,
                    Feature = "Éternel vagabond",
                    SourceId = 1
                },
                new Backgrounds
                {
                    Id = 14,
                    Background = "Soldat",
                    LanguageNumber = 0,
                    Feature = "Grade militaire",
                    SourceId = 1
                }

                ]);
        }
    }
}
