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
    internal class EntitiesConfig : IEntityTypeConfiguration<Entities>
    {

        public void Configure(EntityTypeBuilder<Entities> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Treasures).IsRequired();
            builder.Property(e => e.Particularities).IsRequired();
            builder.Property(e => e.CharachterBackStory).IsRequired();
            builder.Property(e => e.Personality).IsRequired();
            builder.Property(e => e.Ideals).IsRequired();
            builder.Property(e => e.Bonds).IsRequired();
            builder.Property(e => e.Flaws).IsRequired();
            builder.Property(e => e.Allies).IsRequired();
            builder.Property(e => e.AdditionalFeatures).IsRequired();

            builder.HasOne(e => e.Users)
                        .WithMany()
                                    .HasForeignKey(e => e.UserId)
                                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Backgrounds)
                .WithMany()
                        .HasForeignKey(e => e.BackgroundId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Races)
                .WithMany()
                .HasForeignKey(e => e.RaceId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Classes)
                .WithMany()
                .HasForeignKey(e => e.ClasseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Armor)
                .WithMany()
                .HasForeignKey(e => e.ArmorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Shield)
                .WithMany()
                .HasForeignKey(e => e.ShieldId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.WeaponOne)
                .WithMany()
                .HasForeignKey(e => e.WeaponOneId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.WeaponTwo)
                .WithMany()
                .HasForeignKey(e => e.WeaponTwoId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ToolOne)
                .WithMany()
                .HasForeignKey(e => e.ToolOneId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.ToolTwo)
                .WithMany()
                .HasForeignKey(e => e.ToolTwoId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }

}

