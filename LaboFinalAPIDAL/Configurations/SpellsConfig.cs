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
    internal class SpellsConfig : IEntityTypeConfiguration<Spells>
    {
        public void Configure(EntityTypeBuilder<Spells> builder)
        {
            builder.HasData([
                new Spells
            {
                Id = 1,
                Name = "Boule de Feu",
                Level = 3,
                School = "Évocation",
                Range = "45 mètres",
                Components = "V, S, M",
                CastingTime = "1 action",
                Duration = "Instantanée",
                Description = "Un trait lumineux jaillit de votre doigt pointé vers un point que vous choisissez dans la portée, puis éclate avec un rugissement en une explosion de flammes.",
                HigherLevel = "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 4 ou plus, les dégâts augmentent de 1d6 pour chaque niveau d'emplacement au-dessus du niveau 3.",
                SourceId = 1
            },
            new Spells
            {
                Id = 2,
                Name = "Projectile Magique",
                Level = 1,
                School = "Évocation",
                Range = "36 mètres",
                Components = "V, S",
                CastingTime = "1 action",
                Duration = "Instantanée",
                Description = "Vous créez trois projectiles lumineux de force magique. Chaque projectile touche une créature de votre choix que vous pouvez voir dans la portée.",
                HigherLevel = "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 2 ou plus, le sort crée un projectile supplémentaire pour chaque niveau d'emplacement au-dessus du niveau 1.",
                SourceId = 1
            },
            new Spells
            {
                Id = 3,
                Name = "Mot de Guérison",
                Level = 1,
                School = "Évocation",
                Range = "18 mètres",
                Components = "V",
                CastingTime = "1 action bonus",
                Duration = "Instantanée",
                Description = "Une créature de votre choix que vous pouvez voir dans la portée regagne un nombre de points de vie égal à 1d4 + votre modificateur de capacité de lancement de sorts.",
                HigherLevel = "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 2 ou plus, la guérison augmente de 1d4 pour chaque niveau d'emplacement au-dessus du niveau 1.",
                SourceId = 2
            },
            new Spells
            {
                Id = 4,
                Name = "Bouclier",
                Level = 1,
                School = "Abjuration",
                Range = "Personnelle",
                Components = "V, S",
                CastingTime = "1 réaction, que vous prenez lorsque vous êtes touché par une attaque ou ciblé par le sort projectile magique",
                Duration = "1 round",
                Description = "Une barrière invisible de force magique apparaît et vous protège. Jusqu'au début de votre prochain tour, vous avez un bonus de +5 à la CA, y compris contre l'attaque déclenchant, et vous ne subissez aucun dégât de projectile magique.",
                HigherLevel = "",
                SourceId = 2
            },
            new Spells
            {
                Id = 5,
                Name = "Éclair",
                Level = 3,
                School = "Évocation",
                Range = "30 mètres",
                Components = "V, S, M",
                CastingTime = "1 action",
                Duration = "Instantanée",
                Description = "Un éclair de lumière jaillit de vos doigts tendus pour frapper une cible que vous pouvez voir dans la portée. La cible doit réussir un jet de sauvegarde de Dextérité, sinon elle subit 8d6 points de dégâts de foudre, ou la moitié des dégâts en cas de succès.",
                HigherLevel = "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 4 ou plus, les dégâts augmentent de 1d6 pour chaque niveau d'emplacement au-dessus du niveau 3.",
                SourceId = 1
            },
            new Spells
            {
                Id = 6,
                Name = "Main de Mage",
                Level = 0,
                School = "Transmutation",
                Range = "9 mètres",
                Components = "V, S",
                CastingTime = "1 action",
                Duration = "1 minute",
                Description = "Une main spectrale flottante apparaît à un point que vous choisissez dans la portée. La main reste pour la durée ou jusqu'à ce que vous la congédiez par une action. La main peut manipuler un objet, ouvrir une porte ou un contenant, ranger ou récupérer un objet dans un conteneur ouvert, ou verser le contenu d'une fiole.",
                HigherLevel = "",
                SourceId = 1
            }
                ]);
        }
    }
}
