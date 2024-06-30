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
    internal class ClassSkillConfig : IEntityTypeConfiguration<ClassSkills>
    {
        public void Configure(EntityTypeBuilder<ClassSkills> builder)
        {
            builder.HasData(new[]
            {
                // Barbare
                new ClassSkills {Id = 1, ClassId = 1, SkillId = 3},
                new ClassSkills {Id = 2, ClassId = 1, SkillId = 5},
                new ClassSkills {Id = 3, ClassId = 1, SkillId = 8},
                new ClassSkills {Id = 4, ClassId = 1, SkillId = 12},
                new ClassSkills {Id = 5, ClassId = 1, SkillId = 13},
                new ClassSkills {Id = 6, ClassId = 1, SkillId = 17},

                // Barde
                new ClassSkills {Id = 7, ClassId = 2, SkillId = 1},
                new ClassSkills {Id = 8, ClassId = 2, SkillId = 2},
                new ClassSkills {Id = 9, ClassId = 2, SkillId = 3},
                new ClassSkills {Id = 10, ClassId = 2, SkillId = 4},
                new ClassSkills {Id = 11, ClassId = 2, SkillId = 5},
                new ClassSkills {Id = 12, ClassId = 2, SkillId = 6},
                new ClassSkills {Id = 13, ClassId = 2, SkillId = 7},
                new ClassSkills {Id = 14, ClassId = 2, SkillId = 8},
                new ClassSkills {Id = 15, ClassId = 2, SkillId = 9},
                new ClassSkills {Id = 16, ClassId = 2, SkillId = 10},
                new ClassSkills {Id = 17, ClassId = 2, SkillId = 11},
                new ClassSkills {Id = 18, ClassId = 2, SkillId = 12},
                new ClassSkills {Id = 19, ClassId = 2, SkillId = 13},
                new ClassSkills {Id = 20, ClassId = 2, SkillId = 14},
                new ClassSkills {Id = 21, ClassId = 2, SkillId = 15},
                new ClassSkills {Id = 22, ClassId = 2, SkillId = 16},
                new ClassSkills {Id = 23, ClassId = 2, SkillId = 17},
                new ClassSkills {Id = 24, ClassId = 2, SkillId = 18},

                // Clerc
                new ClassSkills {Id = 25, ClassId = 3, SkillId = 7},
                new ClassSkills {Id = 26, ClassId = 3, SkillId = 9},
                new ClassSkills {Id = 27, ClassId = 3, SkillId = 11},
                new ClassSkills {Id = 28, ClassId = 3, SkillId = 14},
                new ClassSkills {Id = 29, ClassId = 3, SkillId = 15},

                // Druide
                new ClassSkills {Id = 30, ClassId = 4, SkillId = 2},
                new ClassSkills {Id = 31, ClassId = 4, SkillId = 5},
                new ClassSkills {Id = 32, ClassId = 4, SkillId = 9},
                new ClassSkills {Id = 33, ClassId = 4, SkillId = 11},
                new ClassSkills {Id = 34, ClassId = 4, SkillId = 12},
                new ClassSkills {Id = 35, ClassId = 4, SkillId = 13},
                new ClassSkills {Id = 36, ClassId = 4, SkillId = 15},
                new ClassSkills {Id = 37, ClassId = 4, SkillId = 17},

                // Ensorceleur
                new ClassSkills {Id = 38, ClassId = 5, SkillId = 2},
                new ClassSkills {Id = 39, ClassId = 5, SkillId = 8},
                new ClassSkills {Id = 40, ClassId = 5, SkillId = 9},
                new ClassSkills {Id = 41, ClassId = 5, SkillId = 14},
                new ClassSkills {Id = 42, ClassId = 5, SkillId = 15},
                new ClassSkills {Id = 43, ClassId = 5, SkillId = 18},

                // Guerrier
                new ClassSkills {Id = 44, ClassId = 6, SkillId = 1},
                new ClassSkills {Id = 45, ClassId = 6, SkillId = 3},
                new ClassSkills {Id = 46, ClassId = 6, SkillId = 5},
                new ClassSkills {Id = 47, ClassId = 6, SkillId = 7},
                new ClassSkills {Id = 48, ClassId = 6, SkillId = 8},
                new ClassSkills {Id = 49, ClassId = 6, SkillId = 9},
                new ClassSkills {Id = 50, ClassId = 6, SkillId = 13},
                new ClassSkills {Id = 51, ClassId = 6, SkillId = 17},

                // Magicien
                new ClassSkills {Id = 52, ClassId = 7, SkillId = 2},
                new ClassSkills {Id = 53, ClassId = 7, SkillId = 7},
                new ClassSkills {Id = 54, ClassId = 7, SkillId = 9},
                new ClassSkills {Id = 55, ClassId = 7, SkillId = 10},
                new ClassSkills {Id = 56, ClassId = 7, SkillId = 11},
                new ClassSkills {Id = 57, ClassId = 7, SkillId = 15},

                // Moine
                new ClassSkills {Id = 58, ClassId = 8, SkillId = 1},
                new ClassSkills {Id = 59, ClassId = 8, SkillId = 3},
                new ClassSkills {Id = 60, ClassId = 8, SkillId = 4},
                new ClassSkills {Id = 61, ClassId = 8, SkillId = 7},
                new ClassSkills {Id = 62, ClassId = 8, SkillId = 9},
                new ClassSkills {Id = 63, ClassId = 8, SkillId = 15},

                // Occultistre
                new ClassSkills {Id = 64, ClassId = 9, SkillId = 2},
                new ClassSkills {Id = 65, ClassId = 9, SkillId = 7},
                new ClassSkills {Id = 66, ClassId = 9, SkillId = 8},
                new ClassSkills {Id = 67, ClassId = 9, SkillId = 10},
                new ClassSkills {Id = 68, ClassId = 9, SkillId = 12},
                new ClassSkills {Id = 69, ClassId = 9, SkillId = 15},
                new ClassSkills {Id = 70, ClassId = 9, SkillId = 18},

                // Paladin
                new ClassSkills {Id = 71, ClassId = 10, SkillId = 3},
                new ClassSkills {Id = 72, ClassId = 10, SkillId = 8},
                new ClassSkills {Id = 73, ClassId = 10, SkillId = 9},
                new ClassSkills {Id = 74, ClassId = 10, SkillId = 11},
                new ClassSkills {Id = 75, ClassId = 10, SkillId = 14},
                new ClassSkills {Id = 76, ClassId = 10, SkillId = 15},

                // Rodeur
                new ClassSkills {Id = 77, ClassId = 11, SkillId = 3},
                new ClassSkills {Id = 78, ClassId = 11, SkillId = 4},
                new ClassSkills {Id = 79, ClassId = 11, SkillId = 5},
                new ClassSkills {Id = 80, ClassId = 11, SkillId = 9},
                new ClassSkills {Id = 81, ClassId = 11, SkillId = 10},
                new ClassSkills {Id = 82, ClassId = 11, SkillId = 12},
                new ClassSkills {Id = 83, ClassId = 11, SkillId = 13},
                new ClassSkills {Id = 84, ClassId = 11, SkillId = 17},

                // Roublard
                new ClassSkills {Id = 85, ClassId = 12, SkillId = 1},
                new ClassSkills {Id = 86, ClassId = 12, SkillId = 3},
                new ClassSkills {Id = 87, ClassId = 12, SkillId = 4},
                new ClassSkills {Id = 88, ClassId = 12, SkillId = 6},
                new ClassSkills {Id = 89, ClassId = 12, SkillId = 8},
                new ClassSkills {Id = 90, ClassId = 12, SkillId = 9},
                new ClassSkills {Id = 91, ClassId = 12, SkillId = 10},
                new ClassSkills {Id = 92, ClassId = 12, SkillId = 13},
                new ClassSkills {Id = 93, ClassId = 12, SkillId = 14},
                new ClassSkills {Id = 94, ClassId = 12, SkillId = 16},
                new ClassSkills {Id = 95, ClassId = 12, SkillId = 18}
            });
        }
    }
}
