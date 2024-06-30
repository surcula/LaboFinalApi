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
    internal class SkillsConfig : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            builder.HasData([
                new Skills { Id = 1, Skill = "Acrobaties (Dex)" },
                new Skills { Id = 2, Skill = "Arcanes (Int)" },
                new Skills { Id = 3, Skill = "Athlétisme (For)" },
                new Skills { Id = 4, Skill = "Discrétion (Dex)" }, 
                new Skills { Id = 5, Skill = "Dressage (Sag)" },
                new Skills { Id = 6, Skill = "Escamotage (Dex)" },
                new Skills { Id = 7, Skill = "Histoire (Int)" },
                new Skills { Id = 8, Skill = "Intimidation (Cha)" },
                new Skills { Id = 9, Skill = "Intuition (Sag)" },
                new Skills { Id = 10, Skill = "Investigation (Int)" },
                new Skills { Id = 11, Skill = "Médecine (Sag)" },
                new Skills { Id = 12, Skill = "Nature (Int)" },
                new Skills { Id = 13, Skill = "Perception (Sag)" },
                new Skills { Id = 14, Skill = "Persuasion (Cha)" },
                new Skills { Id = 15, Skill = "Religion (Int)" },
                new Skills { Id = 16, Skill = "Représentation (Cha)" },
                new Skills { Id = 17, Skill = "Survie (Sag)" },
                new Skills { Id = 18, Skill = "Tromperie (Cha)" },
                ]) ;
        }
    }
}
