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
    internal class SourcesConfig : IEntityTypeConfiguration<Sources>
    {
        public void Configure(EntityTypeBuilder<Sources> builder)
        {
            builder.HasData([
                new Sources {Id = 1, Source = "Player's Handbook"},
                new Sources {Id = 2, Source = "Xanathar's Guide to Everything"},
                new Sources {Id = 3, Source = "Tasha's Cauldron of Everything"},
                new Sources {Id = 4, Source = "Fizban's Treasury of Dragons"},
                new Sources {Id = 5, Source = "Glory of the Giants"},
                new Sources {Id = 6, Source = "Settings"},
                new Sources {Id = 7, Source = "Aventures"},
                new Sources {Id = 8, Source = "Extra(divers)"},
                new Sources {Id = 9, Source = "Monsters of the Multiverse"},
                new Sources {Id = 10, Source = "Van Richten's Guide Ravenloft"},
                new Sources {Id = 11, Source = "Ereborn: Rising from the Last War"},
                new Sources {Id = 12, Source = "Sword Coast Adventurer's Guide"},
                new Sources {Id = 13, Source = "Strixhaven : A Curriculum of Chaos"},
                ]);
        }
    }
}
