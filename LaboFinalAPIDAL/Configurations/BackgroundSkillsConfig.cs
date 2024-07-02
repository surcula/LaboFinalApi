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
    internal class BackgroundSkillsConfig : IEntityTypeConfiguration<BackgroundsSkills>
    {
        public void Configure(EntityTypeBuilder<BackgroundsSkills> builder)
        {
            builder.HasData([
                //Acolyte
                new BackgroundsSkills
                {
                    Id = 1,
                    BackgroundId = 1,
                    SkillId = 9,
                },
                new BackgroundsSkills
                {
                    Id = 2,
                    BackgroundId = 1,
                    SkillId = 15,
                },
                //Artisan de guilde
                new BackgroundsSkills
                {
                    Id = 3,
                    BackgroundId = 2,
                    SkillId = 9,
                },
                new BackgroundsSkills
                {
                    Id = 4,
                    BackgroundId = 2,
                    SkillId = 14,
                },
                //Artiste
                new BackgroundsSkills
                {
                    Id = 5,
                    BackgroundId = 3,
                    SkillId = 1,
                },
                new BackgroundsSkills
                {
                    Id = 6,
                    BackgroundId = 3,
                    SkillId = 16,
                },
                //Charlatan
                new BackgroundsSkills
                {
                    Id = 7,
                    BackgroundId = 4,
                    SkillId = 6,
                },
                new BackgroundsSkills
                {
                    Id = 8,
                    BackgroundId = 4,
                    SkillId = 18,
                },
                //Chevalier
                new BackgroundsSkills
                {
                    Id = 9,
                    BackgroundId = 5,
                    SkillId = 7,
                },
                new BackgroundsSkills
                {
                    Id = 10,
                    BackgroundId = 5,
                    SkillId = 14,
                },
                //Criminel
                new BackgroundsSkills
                {
                    Id = 11,
                    BackgroundId = 6,
                    SkillId = 4,
                },
                new BackgroundsSkills
                {
                    Id = 12,
                    BackgroundId = 6,
                    SkillId = 18,
                },
                //Enfant des rues
                new BackgroundsSkills
                {
                    Id = 13,
                    BackgroundId = 7,
                    SkillId = 4,
                },
                new BackgroundsSkills
                {
                    Id = 14,
                    BackgroundId = 7,
                    SkillId = 6,
                },
                //Ermite
                new BackgroundsSkills
                {
                    Id = 15,
                    BackgroundId = 8,
                    SkillId = 11,
                },
                new BackgroundsSkills
                {
                    Id = 16,
                    BackgroundId = 8,
                    SkillId = 15,
                },
                //Héros du peuple
                new BackgroundsSkills
                {
                    Id = 17,
                    BackgroundId = 9,
                    SkillId = 5,
                },
                new BackgroundsSkills
                {
                    Id = 18,
                    BackgroundId = 9,
                    SkillId = 17,
                },
                //Marin
                new BackgroundsSkills
                {
                    Id = 19,
                    BackgroundId = 10,
                    SkillId = 3,
                },
                new BackgroundsSkills
                {
                    Id = 20,
                    BackgroundId = 10,
                    SkillId = 13,
                },
                //Noble
                new BackgroundsSkills
                {
                    Id = 21,
                    BackgroundId = 11,
                    SkillId = 7,
                },
                new BackgroundsSkills
                {
                    Id = 22,
                    BackgroundId = 11,
                    SkillId = 14,
                },
                //Sage
                new BackgroundsSkills
                {
                    Id = 23,
                    BackgroundId = 12,
                    SkillId = 2,
                },
                new BackgroundsSkills
                {
                    Id = 24,
                    BackgroundId = 12,
                    SkillId = 7,
                },
                //Sauvageon
                new BackgroundsSkills
                {
                    Id = 25,
                    BackgroundId = 13,
                    SkillId = 3,
                },
                new BackgroundsSkills
                {
                    Id = 26,
                    BackgroundId = 13,
                    SkillId = 17,
                },
                //Soldat
                new BackgroundsSkills
                {
                    Id = 27,
                    BackgroundId = 14,
                    SkillId = 3,
                },
                new BackgroundsSkills
                {
                    Id = 28,
                    BackgroundId = 14,
                    SkillId = 8,
                },

                ]);
        }
    }
}
