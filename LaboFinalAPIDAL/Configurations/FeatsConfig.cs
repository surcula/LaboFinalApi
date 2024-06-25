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
    public class FeatsConfig : IEntityTypeConfiguration<Feats>
    {
        public void Configure(EntityTypeBuilder<Feats> builder)
        {
            builder.HasData([
                //PlayerHandBook
                new Feats { Id = 1, Name = "Actor", Prerequisite = "Aucun", Description = "Vous gagnez +1 en Charisme, jusqu'à un maximum de 20. Vous avez l'avantage sur les jets de Charisme (tromperie) et Charisme (représentation) lorsque vous tentez d'endosser une autre identité. Vous pouvez imiter la voix d'autres personnes ou des sons produits par d'autres créatures." , SourceId = 1},
                new Feats { Id = 2, Name = "Alert", Prerequisite = "Aucun", Description = "Vous gagnez un bonus de +5 à vos jets d'initiative. Vous ne pouvez pas être surpris tant que vous êtes conscient, et les créatures invisibles n'ont pas d'avantage tactique contre vous." ,SourceId = 1 },
                new Feats { Id = 3, Name = "Athlete", Prerequisite = "Aucun", Description = "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Lorsque vous êtes à terre, vous pouvez vous relever en utilisant seulement 5 pieds de mouvement. L'escalade ne coûte plus de mouvement supplémentaire pour vous, et vous pouvez effectuer des sauts en longueur ou en hauteur avec un élan réduit.", SourceId = 1},
                new Feats { Id = 4, Name = "Charger", Prerequisite = "Aucun", Description = "Lorsque vous utilisez l'action pour vous précipiter, vous pouvez utiliser une action bonus pour effectuer une attaque de mêlée ou pousser une créature. Si vous déplacez d'au moins 10 pieds en ligne droite, vous gagnez +5 aux dégâts de l'attaque.", SourceId = 1 },
                new Feats { Id = 5, Name = "Crossbow Expert", Prerequisite = "Aucun", Description = "Vous ignorez la propriété 'Recharge' des arbalètes avec lesquelles vous êtes compétent. Être à proximité d'une cible ne désavantage plus vos attaques à distance avec une arbalète. Vous pouvez attaquer avec une arbalète à une main comme une action bonus si vous attaquez avec une arme à une main." , SourceId = 1},
                new Feats { Id = 6, Name = "Defensive Duelist", Prerequisite = "Dextérité 13 ou plus", Description = "Lorsque vous êtes attaqué au corps à corps et que vous maniez une arme de finesse avec laquelle vous êtes compétent, vous pouvez utiliser votre réaction pour ajouter votre bonus de compétence à votre CA pour cette attaque.", SourceId = 1 },
                new Feats { Id = 7, Name = "Dual Wielder", Prerequisite = "Aucun", Description = "Vous gagnez un bonus de +1 à la CA lorsque vous maniez une arme dans chaque main. Vous pouvez manier des armes de mêlée à une main qui n'ont pas la propriété 'Léger' lorsque vous combattez à deux armes. Vous pouvez dégainer ou ranger deux armes d'une main lors de l'action d'attaque.", SourceId = 1 },
                new Feats { Id = 8, Name = "Dungeon Delver", Prerequisite = "Aucun", Description = "Vous avez l'avantage sur les jets de Sagesse (Perception) et d'Intelligence (Investigation) pour détecter la présence de portes secrètes. Vous avez une résistance aux pièges. Vous avez l'avantage sur les jets de sauvegarde pour éviter ou résister aux pièges, et vous pouvez détecter et désamorcer les pièges magiques.", SourceId = 1 },
                new Feats { Id = 9, Name = "Durable", Prerequisite = "Aucun", Description = "Augmentez votre Constitution de 1, jusqu'à un maximum de 20. Lorsque vous dépensez des dés de vie pour récupérer des points de vie, le minimum de points de vie que vous récupérez est égal à deux fois votre modificateur de Constitution." , SourceId = 1 },
                new Feats { Id = 10, Name = "Elemental Adept", Prerequisite = "Capacité à lancer au moins un sort", Description = "Choisissez un type de dégâts : acide, froid, feu, foudre ou tonnerre. Les jets de sauvegarde pour résister à vos sorts de ce type de dégâts n'ont plus de résistance contre ces dégâts. De plus, lorsque vous lancez un sort qui inflige ce type de dégâts, vous pouvez considérer un 1 sur un dé de dégâts comme un 2." , SourceId = 1 },
                new Feats { Id = 11, Name = "Grappler", Prerequisite = "Force 13 ou plus", Description = "Vous avez l'avantage sur les jets d'attaque contre une créature que vous avez agrippée. Vous pouvez utiliser une action pour tenter de maîtriser une créature agrippée en effectuant un nouveau jet d'agrippement. Vous pouvez restreindre une créature que vous avez agrippée et la rendre immobilisée.", SourceId = 1 },
                new Feats { Id = 12, Name = "Great Weapon Master", Prerequisite = "Aucun", Description = "Lorsque vous obtenez un coup critique avec une arme de mêlée ou réduisez une créature à 0 points de vie, vous pouvez effectuer une attaque de mêlée comme une action bonus. Avant de faire une attaque de mêlée avec une arme lourde avec laquelle vous êtes compétent, vous pouvez choisir de prendre un malus de -5 au jet d'attaque. Si l'attaque touche, vous ajoutez +10 aux dégâts de l'attaque.", SourceId = 1 },
                new Feats { Id = 13, Name = "Healer", Prerequisite = "Aucun", Description = "Lorsque vous utilisez un kit de soins pour stabiliser un personnage à 0 points de vie, il regagne 1 point de vie. Vous pouvez utiliser une action pour soigner un allié avec un kit de soins. Ce dernier regagne des points de vie égaux à 1d6 + 4 + son nombre maximum de dés de vie.", SourceId = 1 },
                new Feats { Id = 14, Name = "Heavily Armored", Prerequisite = "Compétence avec les armures intermédiaires", Description = "Augmentez votre Force de 1, jusqu'à un maximum de 20. Vous gagnez la compétence avec les armures lourdes.", SourceId = 1 },
                new Feats { Id = 15, Name = "Heavy Armor Master", Prerequisite = "Compétence avec les armures lourdes", Description = "Augmentez votre Force de 1, jusqu'à un maximum de 20. Lorsque vous êtes en armure lourde, vous subissez une réduction de 3 aux dégâts infligés par les armes non magiques.", SourceId = 1 },
                new Feats { Id = 16, Name = "Inspiring Leader", Prerequisite = "Charisme 13 ou plus", Description = "Vous pouvez passer 10 minutes à inspirer vos compagnons, leur offrant des points de vie temporaires égaux à votre niveau + votre modificateur de Charisme (minimum de 1). Pour bénéficier de cet effet, un compagnon doit pouvoir vous entendre et comprendre.", SourceId = 1 },
                new Feats { Id = 17, Name = "Keen Mind", Prerequisite = "Aucun", Description = "Augmentez votre Intelligence de 1, jusqu'à un maximum de 20. Vous avez une mémoire parfaite pour tout ce que vous avez vu ou entendu au cours du dernier mois. Vous pouvez toujours savoir quelle heure il est et quelle direction est le nord." , SourceId = 1},
                new Feats { Id = 18, Name = "Lightly Armored", Prerequisite = "Aucun", Description = "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Vous gagnez la compétence avec les armures légères." , SourceId = 1},
                new Feats { Id = 19, Name = "Linguist", Prerequisite = "Aucun", Description = "Augmentez votre Intelligence de 1, jusqu'à un maximum de 20. Vous apprenez trois langues au choix. Vous pouvez créer des codes écrits que d'autres ne peuvent déchiffrer qu'avec un jet réussi d'Intelligence (Investigation) contre un DD égal à votre DD de sauvegarde de sorts." , SourceId = 1},
                new Feats { Id = 20, Name = "Lucky", Prerequisite = "Aucun", Description = "Vous avez 3 points de chance. Chaque fois que vous effectuez un jet d'attaque, un jet de capacité ou un jet de sauvegarde, vous pouvez dépenser un point de chance pour lancer un dé supplémentaire et choisir lequel utiliser. Vous pouvez également utiliser un point de chance pour faire relancer un jet d'attaque contre vous." , SourceId = 1},
                new Feats { Id = 21, Name = "Mage Slayer", Prerequisite = "Aucun", Description = "Lorsque vous êtes à portée de mêlée d'une créature qui lance un sort, vous pouvez utiliser votre réaction pour effectuer une attaque de mêlée contre cette créature. Lorsque vous infligez des dégâts à une créature qui se concentre sur un sort, elle a un désavantage sur le jet de sauvegarde pour maintenir sa concentration. Vous avez l'avantage sur les jets de sauvegarde contre les sorts lancés par des créatures à portée de mêlée de vous." , SourceId = 1},
                new Feats { Id = 22, Name = "Magic Initiate", Prerequisite = "Aucun", Description = "Choisissez une classe de sort (barde, clerc, druide, ensorceleur, magicien, paladin, ranger, ou sorcier). Vous apprenez deux tours de magie au choix de cette classe. Vous apprenez également un sort de 1er niveau à lancer une fois par jour avec cette caractéristique de classe." , SourceId = 1},
                new Feats { Id = 23, Name = "Martial Adept", Prerequisite = "Aucun", Description = "Vous apprenez deux manœuvres au choix parmi celles disponibles pour l'archétype Martial du guerrier. Si une manœuvre vous oblige à effectuer un jet de sauvegarde pour résister à ses effets, le DD de sauvegarde est égal à 8 + votre bonus de compétence + votre modificateur de Force ou de Dextérité (à votre choix). Vous gagnez une d6 de supériorité que vous pouvez utiliser pour effectuer ces manœuvres." , SourceId = 1},
                new Feats { Id = 24, Name = "Medium Armor Master", Prerequisite = "Compétence avec les armures intermédiaires", Description = "Portez une armure intermédiaire ne vous impose plus de désavantage sur les jets de Dextérité (Discrétion). Lorsque vous portez une armure intermédiaire, vous pouvez ajouter 3 au lieu de 2 à votre CA si vous avez un modificateur de Dextérité positif.", SourceId = 1 },
                new Feats { Id = 25, Name = "Mobile", Prerequisite = "Aucun", Description = "Votre vitesse augmente de 10 pieds. Lorsque vous utilisez l'action pour vous désengager, votre déplacement n'est pas réduit par le terrain difficile jusqu'à la fin de votre tour. Lorsque vous effectuez une attaque au corps à corps contre une créature, vous ne provoquez pas d'attaque d'opportunité de sa part pour le reste de votre tour, que vous l'ayez touchée ou non.", SourceId = 1 },
                new Feats { Id = 26, Name = "Moderately Armored", Prerequisite = "Compétence avec les armures légères", Description = "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Vous gagnez la compétence avec les armures intermédiaires et les boucliers." , SourceId = 1},
                new Feats { Id = 27, Name = "Mounted Combatant", Prerequisite = "Aucun", Description = "Vous avez l'avantage sur les jets d'attaque contre toute créature de taille inférieure à celle de votre monture. Vous pouvez forcer une attaque visant votre monture à vous viser à la place. Si votre monture doit effectuer un jet de sauvegarde pour résister à un effet qui ne lui inflige que la moitié des dégâts en cas de succès, elle subit 0 dégâts en cas de succès et la moitié des dégâts en cas d'échec." , SourceId = 1},
                new Feats { Id = 28, Name = "Observant", Prerequisite = "Aucun", Description = "Augmentez votre Intelligence ou Sagesse de 1, jusqu'à un maximum de 20. Si vous pouvez voir la bouche d'une créature pendant qu'elle parle une langue que vous comprenez, vous pouvez interpréter ce qu'elle dit en lisant sur ses lèvres. Vous avez un bonus de +5 aux jets de Sagesse (Perception) et d'Intelligence (Investigation)." , SourceId = 1},
                new Feats { Id = 29, Name = "Polearm Master", Prerequisite = "Aucun", Description = "Lorsque vous prenez l'action d'attaque et attaquez avec une lance, une hallebarde, un bâton ou une pique, vous pouvez utiliser une action bonus pour effectuer une attaque de mêlée avec l'extrémité opposée de l'arme. Cette attaque inflige des dégâts contondants égaux à 1d4 + votre modificateur de Force. Pendant votre tour, les autres créatures provoquent une attaque d'opportunité lorsque qu'elles entrent dans votre portée d'arme de mêlée." , SourceId = 1},
                new Feats { Id = 30, Name = "Resilient", Prerequisite = "Aucun", Description = "Augmentez une caractéristique de votre choix de 1, jusqu'à un maximum de 20. Vous gagnez la compétence dans les jets de sauvegarde utilisant cette caractéristique." , SourceId = 1},
                new Feats { Id = 31, Name = "Ritual Caster", Prerequisite = "Intelligence ou Sagesse 13 ou plus", Description = "Vous apprenez deux sorts de niveau 1 au choix qui ont la propriété Rituel à partir d'une liste de sorts de n'importe quelle classe. Vous devez posséder un livre de sorts, qui contient ces sorts rituels." , SourceId = 1},
                new Feats { Id = 32, Name = "Savage Attacker", Prerequisite = "Aucun", Description = "Une fois par tour lorsque vous infligez des dégâts avec une arme de mêlée, vous pouvez relancer les dés de dégâts de l'arme et utiliser les meilleurs résultats." , SourceId = 1},
                new Feats { Id = 33, Name = "Sentinel", Prerequisite = "Aucun", Description = "Lorsque vous touchez une créature avec une attaque d'opportunité, sa vitesse devient 0 pour le reste du tour. Les créatures à portée de votre arme de mêlée provoquent une attaque d'opportunité même si elles utilisent l'action de désengagement. Lorsque une créature à portée de mêlée attaque une cible autre que vous, vous pouvez utiliser votre réaction pour effectuer une attaque de mêlée contre cette créature." , SourceId = 1},
                new Feats { Id = 34, Name = "Sharpshooter", Prerequisite = "Aucun", Description = "Attaquer à longue portée n'impose pas de désavantage à vos jets d'attaque à distance. Vos attaques à distance ignorent la couverture à moitié et les trois quarts. Avant de faire une attaque à distance avec une arme à distance avec laquelle vous êtes compétent, vous pouvez choisir de prendre un malus de -5 au jet d'attaque. Si l'attaque touche, vous ajoutez +10 aux dégâts de l'attaque." , SourceId = 1},
                new Feats { Id = 35, Name = "Shield Master", Prerequisite = "Aucun", Description = "Si vous utilisez l'action d'attaque lors de votre tour, vous pouvez utiliser une action bonus pour tenter de pousser une créature à portée avec votre bouclier. Si vous n'êtes pas immobilisé, vous pouvez ajouter votre bonus de bouclier à n'importe quel jet de sauvegarde de Dextérité contre un effet qui affecte seulement vous. Si vous subissez un jet de sauvegarde de Dextérité pour prendre seulement la moitié des dégâts, vous pouvez utiliser votre réaction pour ne subir aucun dégât si vous réussissez.", SourceId = 1 },
                new Feats { Id = 36, Name = "Skilled", Prerequisite = "Aucun", Description = "Vous gagnez la compétence dans trois compétences ou outils au choix." ,SourceId = 1 },
                new Feats { Id = 37, Name = "Skulker", Prerequisite = "Dextérité 13 ou plus", Description = "Vous pouvez tenter de vous cacher lorsque vous êtes légèrement obscurci par la lumière naturelle, une créature manque une attaque à distance contre vous et vous pouvez vous cacher, et lorsque vous attaquez et manquez avec une arme à distance, votre position n'est pas révélée." , SourceId = 1},
                new Feats { Id = 38, Name = "Spell Sniper", Prerequisite = "Capacité à lancer au moins un sort", Description = "Lorsque vous lancez un sort qui nécessite un jet d'attaque, la portée du sort est doublée. Vos attaques avec des sorts ignorent la couverture à moitié et les trois quarts. Vous apprenez un tour de magie au choix nécessitant un jet d'attaque à partir d'une liste de sorts d'une classe." , SourceId = 1},
                new Feats { Id = 39, Name = "Tavern Brawler", Prerequisite = "Aucun", Description = "Augmentez votre Force ou Constitution de 1, jusqu'à un maximum de 20. Vous êtes compétent avec les armes improvisées et vos attaques à mains nues infligent des dégâts contondants égaux à 1d4 + votre modificateur de Force. Lorsque vous frappez une créature avec une attaque à mains nues ou une arme improvisée pendant votre tour, vous pouvez utiliser une action bonus pour tenter d'agripper la cible." , SourceId = 1},
                new Feats { Id = 40, Name = "Tough", Prerequisite = "Aucun", Description = "Votre maximum de points de vie augmente de 2 pour chaque niveau que vous avez, et de 2 pour chaque niveau que vous gagnez par la suite." , SourceId = 1},
                new Feats { Id = 41, Name = "War Caster", Prerequisite = "Capacité à lancer au moins un sort", Description = "Vous avez l'avantage sur les jets de sauvegarde de Constitution pour maintenir votre concentration sur un sort lorsque vous subissez des dégâts. Vous pouvez effectuer des composantes somatiques de sorts même si vous avez des armes ou un bouclier dans une ou les deux mains. Lorsque vous provoquez une attaque d'opportunité, vous pouvez lancer un sort au lieu d'une attaque de mêlée." , SourceId = 1},
                new Feats { Id = 42, Name = "Weapon Master", Prerequisite = "Aucun", Description = "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Vous gagnez la compétence dans quatre armes au choix." , SourceId = 1},
                ///Xanathar
                new Feats
            {
                Id = 43,
                Name = "Adepte des arcanes",
                Prerequisite = "Classe de lanceur de sorts",
                Description = "Choisissez une école de magie. Vous apprenez deux sorts de niveau 1 de cette école. Vous pouvez les lancer sans utiliser de composantes matérielles. Vous gagnez une récupération partielle des emplacements de sorts utilisés.",
                SourceId = 2
            },
            new Feats
            {
                Id = 44,
                Name = "Apprenti Martial",
                Prerequisite = "Aucun",
                Description = "Vous apprenez deux manœuvres au choix parmi celles disponibles pour l'archétype Martial du guerrier. Vous gagnez une d6 de supériorité pour les manœuvres.",
                SourceId = 2
            },
            new Feats
            {
                Id = 45,
                Name = "Chef de bande",
                Prerequisite = "Charisme 13 ou plus",
                Description = "Lorsque vous effectuez une action pour aider un allié, la portée de cette action est de 30 pieds. Vous pouvez utiliser votre réaction pour accorder un bonus d'attaque ou de CA à un allié dans un rayon de 30 pieds.",
                SourceId = 2
            },
            new Feats
            {
                Id = 46,
                Name = "Guérisseur",
                Prerequisite = "Aucun",
                Description = "Lorsque vous utilisez un kit de soins, la créature regagne des points de vie supplémentaires égaux à 1d6 + 4 + son nombre de dés de vie.",
                SourceId = 2
            },
            new Feats
            {
                Id = 47,
                Name = "Marcheur des bois",
                Prerequisite = "Aucun",
                Description = "Vous avez l'avantage sur les jets de Sagesse (Survie) pour suivre les créatures et les jets de Constitution pour éviter les épuisements dus aux voyages sur de longues distances.",
                SourceId = 2
            },
            new Feats
            {
                Id = 48,
                Name = "Maître du camouflage",
                Prerequisite = "Aucun",
                Description = "Vous pouvez essayer de vous cacher même lorsque vous êtes légèrement obscurci par des feuillages, de la neige, de la pluie ou d'autres phénomènes naturels.",
                SourceId = 2
            },
            new Feats
            {
                Id = 49,
                Name = "Maître des livres de sorts",
                Prerequisite = "Intelligence 13 ou plus",
                Description = "Vous pouvez copier un sort dans votre livre de sorts en moitié moins de temps et en utilisant moitié moins de ressources.",
                SourceId = 2
            },
            new Feats
            {
                Id = 50,
                Name = "Percepteur des arcanes",
                Prerequisite = "Intelligence 13 ou plus",
                Description = "Vous apprenez deux sorts de l'école de magie de l'abjuration ou de la divination. Vous pouvez les lancer sans utiliser de composantes matérielles.",
                SourceId = 2
            },
            new Feats
            {
                Id = 51,
                Name = "Pilote de monture",
                Prerequisite = "Aucun",
                Description = "Vous avez l'avantage sur les jets pour rester en selle. Si votre monture est forcée de faire un jet de sauvegarde pour éviter des effets, elle subit seulement la moitié des dégâts en cas de réussite.",
                SourceId = 2
            },
            new Feats
            {
                Id = 52,
                Name = "Rodeur urbain",
                Prerequisite = "Aucun",
                Description = "Vous pouvez vous déplacer à votre vitesse normale à travers une foule. Vous avez l'avantage sur les jets de Sagesse (Perception) et d'Intelligence (Investigation) pour trouver des individus ou des objets cachés en milieu urbain.",
                SourceId = 2
            },
            new Feats
                {
                Id = 53,
                Name = "Sniper de sort",
                Prerequisite = "Capacité à lancer au moins un sort",
                Description = "Lorsque vous lancez un sort nécessitant un jet d'attaque, la portée du sort est doublée. Vos attaques de sort ignorent la demi-couverture et les trois quarts de couverture.",
                SourceId = 2
            },
            new Feats
            {
                Id = 54,
                Name = "Tireur d'élite",
                Prerequisite = "Aucun",
                Description = "Vous n'avez pas de désavantage sur les jets d'attaque à distance à longue portée. Vos attaques à distance ignorent la couverture à moitié et les trois quarts. Avant de faire une attaque à distance, vous pouvez choisir de prendre un malus de -5 au jet d'attaque. Si l'attaque touche, vous ajoutez +10 aux dégâts de l'attaque.",
                SourceId = 2
            },
            new Feats
            {
                Id = 55,
                Name = "Virtuose des arcanes",
                Prerequisite = "Capacité à lancer au moins un sort",
                Description = "Vous apprenez deux sorts de votre liste de sorts. Vous pouvez les lancer sans utiliser de composantes matérielles. Vous pouvez également les lancer une fois chacun sans utiliser de slots de sorts.",
                SourceId = 2
            },

            ///Tasha
            new Feats
            {
                Id = 56,
                Name = "Artificier initié",
                Prerequisite = "Aucun",
                Description = "Vous apprenez un tour de magie de la liste de sorts de l'artificier. Vous apprenez également deux sorts de 1er niveau de la liste de sorts de l'artificier. Vous pouvez lancer chacun de ces sorts une fois sans utiliser d'emplacement de sort. Vous récupérez la capacité de le faire lorsque vous terminez un repos long.",
                SourceId = 3
            },
            new Feats
            {
                Id = 57,
                Name = "Initiation au combat rapproché",
                Prerequisite = "Aucun",
                Description = "Vous gagnez une compétence avec les armes de guerre et une compétence avec un bouclier. Vous gagnez également une attaque supplémentaire avec une arme de guerre ou un bouclier.",
                SourceId = 3
            },
            new Feats
            {
                Id = 58,
                Name = "Adepte des métamorphoses",
                Prerequisite = "Aucun",
                Description = "Lorsque vous lancez un sort de métamorphose de 1er niveau ou plus qui cible une créature amie, vous pouvez cibler une deuxième créature amie dans la portée du sort avec le même sort.",
                SourceId = 3
            },
            new Feats
            {
                Id = 59,
                Name = "Érudition martiale",
                Prerequisite = "Aucun",
                Description = "Vous gagnez une compétence dans une arme au choix et une compétence dans une armure légère ou moyenne.",
                SourceId = 3
            },
            new Feats
            {
                Id = 60,
                Name = "Expert en survie",
                Prerequisite = "Aucun",
                Description = "Vous gagnez la compétence dans la compétence Survie. Vous avez l'avantage sur les jets de survie pour suivre les créatures et trouver de la nourriture et de l'eau dans la nature.",
                SourceId = 3
            },
            new Feats
            {
                Id = 61,
                Name = "Initiation à l'alchimie",
                Prerequisite = "Aucun",
                Description = "Vous apprenez la recette de trois potions de guérison et pouvez les créer pendant un repos long en utilisant des composants alchimiques.",
                SourceId = 3
            },
            new Feats
            {
                Id = 62,
                Name = "Initiation au tir à l'arc",
                Prerequisite = "Aucun",
                Description = "Vous gagnez une compétence avec les arcs longs et les arcs courts. Vous pouvez ignorer les pénalités de désavantage pour attaquer à longue portée avec ces armes.",
                SourceId = 3
            },
            new Feats
            {
                Id = 63,
                Name = "Adepte en manipulation magique",
                Prerequisite = "Aucun",
                Description = "Lorsque vous utilisez une baguette, un bâton ou un sceptre pour lancer un sort, vous pouvez augmenter le DD de sauvegarde du sort de 1.",
                SourceId = 3
            },
            new Feats
            {
                Id = 64,
                Name = "Défenseur des faibles",
                Prerequisite = "Aucun",
                Description = "Lorsque vous protégez une créature amie avec votre bouclier, la créature gagne un bonus de +1 à la CA et vous avez l'avantage sur les jets de sauvegarde pour éviter d'être déplacé ou renversé.",
                SourceId = 3
            },
            new Feats
            {
                Id = 65,
                Name = "Sorcier de l'ombre",
                Prerequisite = "Aucun",
                Description = "Vous apprenez deux sorts de la liste de sorts de l'école de l'illusion ou de la nécromancie. Vous pouvez les lancer sans utiliser de composantes matérielles.",
                SourceId = 3
            },
            new Feats
            {
                Id = 66,
                Name = "Maître des potions",
                Prerequisite = "Aucun",
                Description = "Vous pouvez créer une potion de guérison pendant un repos court en utilisant des composants alchimiques. Vous pouvez également identifier les potions en les goûtant.",
                SourceId = 3
            },
            new Feats
            {
                Id = 67,
                Name = "Initiation à l'invocation",
                Prerequisite = "Aucun",
                Description = "Vous apprenez deux sorts de l'école de l'invocation. Vous pouvez les lancer sans utiliser de composantes matérielles.",
                SourceId = 3
            },
            new Feats
            {
                Id = 68,
                Name = "Expert en armures",
                Prerequisite = "Aucun",
                Description = "Vous gagnez la compétence avec les armures intermédiaires et lourdes. Lorsque vous portez une armure intermédiaire ou lourde, vous pouvez ajouter 1 à la CA.",
                SourceId = 3
            },
            new Feats
            {
                Id = 69,
                Name = "Expert en armes",
                Prerequisite = "Aucun",
                Description = "Vous gagnez la compétence avec les armes de guerre. Vous pouvez choisir deux armes de guerre et vous gagnez un bonus de +1 aux jets d'attaque et de dégâts avec ces armes.",
                SourceId = 3
            },
            new Feats
            {
                Id = 70,
                Name = "Initiation au combat magique",
                Prerequisite = "Aucun",
                Description = "Vous apprenez un tour de magie de la liste de sorts de l'ensorceleur, du magicien ou du sorcier. Vous pouvez également lancer un sort de niveau 1 de ces listes de sorts une fois sans utiliser d'emplacement de sort. Vous récupérez la capacité de le faire lorsque vous terminez un repos long.",
                SourceId = 3
            }


            ]);


        }
    }
}
