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
    internal class ClassesConfig : IEntityTypeConfiguration<Classes>
    {
        public void Configure(EntityTypeBuilder<Classes> builder)
        {
            builder.HasData([
                //Barbare
                new Classes{
                    Id = 1,
                    Class = "Barbare",
                    DV = 12,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Barde
                new Classes{
                    Id = 2,
                    Class = "Barde",
                    DV = 8,
                    SourceId = 1,
                    NbSkill = 3
                },
                //Clerc
                new Classes{
                    Id = 3,
                    Class = "Clerc",
                    DV = 8,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Druid
                new Classes{
                    Id = 4,
                    Class = "Druide",
                    DV = 8,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Ensorceleur
                new Classes{
                    Id = 5,
                    Class = "Ensorceleur",
                    DV = 12,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Guerrier
                new Classes{
                    Id = 6,
                    Class = "Guerrier",
                    DV = 10,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Magicien
                new Classes{
                    Id = 7,
                    Class = "Magicien",
                    DV = 6,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Moine
                new Classes{
                    Id = 8,
                    Class = "Moine",
                    DV = 8,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Occultiste
                new Classes{
                    Id = 9,
                    Class = "Occultiste",
                    DV = 8,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Paladin
                 new Classes{
                    Id = 10,
                    Class = "Paladin",
                    DV = 10,
                    SourceId = 1,
                    NbSkill = 2
                },
                //Rodeur
                 new Classes{
                    Id = 11,
                    Class = "Rodeur",
                    DV = 10,
                    SourceId = 1,
                    NbSkill = 3
                },
                //Roublard
                new Classes{
                    Id = 12,
                    Class = "Roublard",
                    DV = 8,
                    SourceId = 1,
                    NbSkill = 4
                },
                ]);
        }
    }
}
