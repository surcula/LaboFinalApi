using LaboFinalAPIDomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Configurations
{
    internal class typesItemsConfig : IEntityTypeConfiguration<TypesItems>
    {
        public void Configure(EntityTypeBuilder<TypesItems> builder)
        {
//            builder.Property(p => p.TypeItem)
//                .HasMaxLength(255)
//                .IsRequired();
//            builder.HasKey(p => new { p.TypeItemId });


//#if DEBUG
//            builder.HasData(
//                new TypesItems { TypeItemId = 1, TypeItem = "Armes" },
//                new TypesItems { TypeItemId = 2, TypeItem = "Bouclier" },
//                new TypesItems { TypeItemId = 3, TypeItem = "Outils" },
//                new TypesItems { TypeItemId = 4, TypeItem = "Bijoux" },
//                new TypesItems { TypeItemId = 5, TypeItem = "Montures" },
//                new TypesItems { TypeItemId = 6, TypeItem = "Autres" }
//            );
//#endif

        }
    }
}
