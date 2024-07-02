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
    internal class BackgroundsItemsConfig : IEntityTypeConfiguration<BackgroundsItems>
    {
        public void Configure(EntityTypeBuilder<BackgroundsItems> builder)
        {
       
                 builder.HasData([
                                          
                    //Artiste
                    new BackgroundsItems
                    {
                        Id = 1,
                        BackgroundId = 3,
                        ItemId = 68,
                    },
                    //Charlatan
                    new BackgroundsItems
                    {
                        Id = 2,
                        BackgroundId = 4,
                        ItemId = 68,
                    },
                    new BackgroundsItems
                    {
                        Id = 3,
                        BackgroundId = 4,
                        ItemId = 67,
                    },
                
                    //Criminel
                    new BackgroundsItems
                    {
                        Id = 4,
                        BackgroundId = 6,
                        ItemId = 87,
                    },
                    //Enfant des rues
                    new BackgroundsItems
                    {
                        Id = 5,
                        BackgroundId = 7,
                        ItemId = 68,
                    },
                    new BackgroundsItems
                    {
                        Id = 6,
                        BackgroundId = 7,
                        ItemId = 87,
                    },
                    //Ermite
                    new BackgroundsItems
                    {
                        Id = 7,
                        BackgroundId = 8,
                        ItemId = 66,
                    },                
                    //Marin
                    new BackgroundsItems
                    {
                        Id = 8,
                        BackgroundId = 10,
                        ItemId = 86,
                    }
                
                ]);
        }
    }
}
