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
    internal class TypeItemConfig : IEntityTypeConfiguration<TypesItems>
    {
        public void Configure(EntityTypeBuilder<TypesItems> builder)
        {
            builder.HasData([
                new TypesItems{ Id = 1 , TypeItem = "Armes courantes de corps à corps"},
                new TypesItems{ Id = 2 , TypeItem = "Armes courantes à distance"},
                new TypesItems{ Id = 3 , TypeItem = "Armes de guerre de corps à corps"},
                new TypesItems{ Id = 4 , TypeItem = "Armes de guerre à distance"},
                new TypesItems{ Id = 5 , TypeItem = "Armures légères"},
                new TypesItems{ Id = 3 , TypeItem = "Armures intermédiaires"},
                new TypesItems{ Id = 4 , TypeItem = "Amures lourdes"},
                new TypesItems{ Id = 5 , TypeItem = "Bouclier"},
                new TypesItems{ Id = 6 , TypeItem = "Instrument de musique"},
                new TypesItems{ Id = 7 , TypeItem = "Jeux"},
                new TypesItems{ Id = 8 , TypeItem = "Outils d'artisan"},
                new TypesItems { Id = 9 , TypeItem = "Montures"},
                new TypesItems { Id = 10 , TypeItem = "Objet"},
                new TypesItems { Id = 11 , TypeItem = "Munitions"},

                ]);
        }
    }
}
