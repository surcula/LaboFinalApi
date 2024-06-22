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
    internal class ItemsConfig : IEntityTypeConfiguration<Items>
    {

        //public void Configure(EntityTypeBuilder<Items> builder)
        //{
        //    builder.HasKey(p => p.ItemId);
        //    builder.Property(p => p.Item)
        //        .IsRequired();
        //    builder.Property(p => p.Price)
        //        .IsRequired();   
        //    builder.HasOne(p => p.TypesItems)
        //        .WithMany()
        //        .HasForeignKey(p => p.TypeId)
        //        .OnDelete(DeleteBehavior.Cascade);

        //}
        public void Configure(EntityTypeBuilder<Items> builder)
        {
            throw new NotImplementedException();
        }
    }
}
