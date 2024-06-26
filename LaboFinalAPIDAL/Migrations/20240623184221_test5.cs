using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                        Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skill = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeItem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageNumber = table.Column<int>(type: "int", nullable: false),
                    Feature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Sources_sourceId",
                        column: x => x.sourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrenghtBonus = table.Column<int>(type: "int", nullable: false),
                    DexterityBonus = table.Column<int>(type: "int", nullable: false),
                    ConstitutionBonus = table.Column<int>(type: "int", nullable: false),
                    WisdomBonus = table.Column<int>(type: "int", nullable: false),
                    IntelligenceBonus = table.Column<int>(type: "int", nullable: false),
                    CharismaBonus = table.Column<int>(type: "int", nullable: false),
                    DV = table.Column<int>(type: "int", nullable: false),
                    sourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Sources_sourceId",
                        column: x => x.sourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prerequisite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feats_Sources_sourceId",
                        column: x => x.sourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrenghtBonus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DexterityBonus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstitutionBonus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WisdomBonus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntelligenceBonus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharismsBonus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    sourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Sources_sourceId",
                        column: x => x.sourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Components = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CastingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HigherLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_Sources_sourceId",
                        column: x => x.sourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Ca = table.Column<int>(type: "int", nullable: true),
                    Ca_Bonus = table.Column<int>(type: "int", nullable: false),
                    DiceType = table.Column<int>(type: "int", nullable: true),
                    DiceNumber = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    TypesItemsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_TypesItems_TypesItemsId",
                        column: x => x.TypesItemsId,
                        principalTable: "TypesItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BackgroundSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillsId = table.Column<int>(type: "int", nullable: false),
                    BackgroundsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackgroundSkills_Backgrounds_BackgroundsId",
                        column: x => x.BackgroundsId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundSkills_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillsId = table.Column<int>(type: "int", nullable: false),
                    ClassesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSkills_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSkills_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguagesId = table.Column<int>(type: "int", nullable: false),
                    RacesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceLanguages_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceLanguages_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BackgroundId = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    ClasseId = table.Column<int>(type: "int", nullable: false),
                    ArmorId = table.Column<int>(type: "int", nullable: false),
                    ShieldId = table.Column<int>(type: "int", nullable: false),
                    WeaponOneId = table.Column<int>(type: "int", nullable: false),
                    WeaponTwoId = table.Column<int>(type: "int", nullable: false),
                    ToolOneId = table.Column<int>(type: "int", nullable: false),
                    ToolTwoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strenght = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    HitPoints = table.Column<int>(type: "int", nullable: false),
                    Treasures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Particularities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Alignment = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Xp = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Appareance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharachterBackStory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ideals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bonds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flaws = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Items_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Items_ShieldId",
                        column: x => x.ShieldId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Items_ToolOneId",
                        column: x => x.ToolOneId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Items_ToolTwoId",
                        column: x => x.ToolTwoId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Items_WeaponOneId",
                        column: x => x.WeaponOneId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Items_WeaponTwoId",
                        column: x => x.WeaponTwoId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entitySkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillsId = table.Column<int>(type: "int", nullable: false),
                    EntitiesId = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entitySkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_entitySkills_Entities_EntitiesId",
                        column: x => x.EntitiesId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_entitySkills_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    EntitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventories_Entities_EntitiesId",
                        column: x => x.EntitiesId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventories_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Source" },
                values: new object[,]
                {
                    { 1, "Player's Handbook" },
                    { 2, "Xanathar's Guide to Everything" },
                    { 3, "Tasha's Cauldron of Everything" },
                    { 4, "Fizban's Treasury of Dragons" },
                    { 5, "Glory of the Giants" },
                    { 6, "Settings" },
                    { 7, "Aventures" },
                    { 8, "Extra(divers)" }
                });

            migrationBuilder.InsertData(
                table: "Feats",
                columns: new[] { "Id", "Description", "Name", "Prerequisite", "sourceId" },
                values: new object[,]
                {
                    { 1, "Vous gagnez +1 en Charisme, jusqu'à un maximum de 20. Vous avez l'avantage sur les jets de Charisme (tromperie) et Charisme (représentation) lorsque vous tentez d'endosser une autre identité. Vous pouvez imiter la voix d'autres personnes ou des sons produits par d'autres créatures.", "Actor", "Aucun", 1 },
                    { 2, "Vous gagnez un bonus de +5 à vos jets d'initiative. Vous ne pouvez pas être surpris tant que vous êtes conscient, et les créatures invisibles n'ont pas d'avantage tactique contre vous.", "Alert", "Aucun", 1 },
                    { 3, "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Lorsque vous êtes à terre, vous pouvez vous relever en utilisant seulement 5 pieds de mouvement. L'escalade ne coûte plus de mouvement supplémentaire pour vous, et vous pouvez effectuer des sauts en longueur ou en hauteur avec un élan réduit.", "Athlete", "Aucun", 1 },
                    { 4, "Lorsque vous utilisez l'action pour vous précipiter, vous pouvez utiliser une action bonus pour effectuer une attaque de mêlée ou pousser une créature. Si vous déplacez d'au moins 10 pieds en ligne droite, vous gagnez +5 aux dégâts de l'attaque.", "Charger", "Aucun", 1 },
                    { 5, "Vous ignorez la propriété 'Recharge' des arbalètes avec lesquelles vous êtes compétent. Être à proximité d'une cible ne désavantage plus vos attaques à distance avec une arbalète. Vous pouvez attaquer avec une arbalète à une main comme une action bonus si vous attaquez avec une arme à une main.", "Crossbow Expert", "Aucun", 1 },
                    { 6, "Lorsque vous êtes attaqué au corps à corps et que vous maniez une arme de finesse avec laquelle vous êtes compétent, vous pouvez utiliser votre réaction pour ajouter votre bonus de compétence à votre CA pour cette attaque.", "Defensive Duelist", "Dextérité 13 ou plus", 1 },
                    { 7, "Vous gagnez un bonus de +1 à la CA lorsque vous maniez une arme dans chaque main. Vous pouvez manier des armes de mêlée à une main qui n'ont pas la propriété 'Léger' lorsque vous combattez à deux armes. Vous pouvez dégainer ou ranger deux armes d'une main lors de l'action d'attaque.", "Dual Wielder", "Aucun", 1 },
                    { 8, "Vous avez l'avantage sur les jets de Sagesse (Perception) et d'Intelligence (Investigation) pour détecter la présence de portes secrètes. Vous avez une résistance aux pièges. Vous avez l'avantage sur les jets de sauvegarde pour éviter ou résister aux pièges, et vous pouvez détecter et désamorcer les pièges magiques.", "Dungeon Delver", "Aucun", 1 },
                    { 9, "Augmentez votre Constitution de 1, jusqu'à un maximum de 20. Lorsque vous dépensez des dés de vie pour récupérer des points de vie, le minimum de points de vie que vous récupérez est égal à deux fois votre modificateur de Constitution.", "Durable", "Aucun", 1 },
                    { 10, "Choisissez un type de dégâts : acide, froid, feu, foudre ou tonnerre. Les jets de sauvegarde pour résister à vos sorts de ce type de dégâts n'ont plus de résistance contre ces dégâts. De plus, lorsque vous lancez un sort qui inflige ce type de dégâts, vous pouvez considérer un 1 sur un dé de dégâts comme un 2.", "Elemental Adept", "Capacité à lancer au moins un sort", 1 },
                    { 11, "Vous avez l'avantage sur les jets d'attaque contre une créature que vous avez agrippée. Vous pouvez utiliser une action pour tenter de maîtriser une créature agrippée en effectuant un nouveau jet d'agrippement. Vous pouvez restreindre une créature que vous avez agrippée et la rendre immobilisée.", "Grappler", "Force 13 ou plus", 1 },
                    { 12, "Lorsque vous obtenez un coup critique avec une arme de mêlée ou réduisez une créature à 0 points de vie, vous pouvez effectuer une attaque de mêlée comme une action bonus. Avant de faire une attaque de mêlée avec une arme lourde avec laquelle vous êtes compétent, vous pouvez choisir de prendre un malus de -5 au jet d'attaque. Si l'attaque touche, vous ajoutez +10 aux dégâts de l'attaque.", "Great Weapon Master", "Aucun", 1 },
                    { 13, "Lorsque vous utilisez un kit de soins pour stabiliser un personnage à 0 points de vie, il regagne 1 point de vie. Vous pouvez utiliser une action pour soigner un allié avec un kit de soins. Ce dernier regagne des points de vie égaux à 1d6 + 4 + son nombre maximum de dés de vie.", "Healer", "Aucun", 1 },
                    { 14, "Augmentez votre Force de 1, jusqu'à un maximum de 20. Vous gagnez la compétence avec les armures lourdes.", "Heavily Armored", "Compétence avec les armures intermédiaires", 1 },
                    { 15, "Augmentez votre Force de 1, jusqu'à un maximum de 20. Lorsque vous êtes en armure lourde, vous subissez une réduction de 3 aux dégâts infligés par les armes non magiques.", "Heavy Armor Master", "Compétence avec les armures lourdes", 1 },
                    { 16, "Vous pouvez passer 10 minutes à inspirer vos compagnons, leur offrant des points de vie temporaires égaux à votre niveau + votre modificateur de Charisme (minimum de 1). Pour bénéficier de cet effet, un compagnon doit pouvoir vous entendre et comprendre.", "Inspiring Leader", "Charisme 13 ou plus", 1 },
                    { 17, "Augmentez votre Intelligence de 1, jusqu'à un maximum de 20. Vous avez une mémoire parfaite pour tout ce que vous avez vu ou entendu au cours du dernier mois. Vous pouvez toujours savoir quelle heure il est et quelle direction est le nord.", "Keen Mind", "Aucun", 1 },
                    { 18, "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Vous gagnez la compétence avec les armures légères.", "Lightly Armored", "Aucun", 1 },
                    { 19, "Augmentez votre Intelligence de 1, jusqu'à un maximum de 20. Vous apprenez trois langues au choix. Vous pouvez créer des codes écrits que d'autres ne peuvent déchiffrer qu'avec un jet réussi d'Intelligence (Investigation) contre un DD égal à votre DD de sauvegarde de sorts.", "Linguist", "Aucun", 1 },
                    { 20, "Vous avez 3 points de chance. Chaque fois que vous effectuez un jet d'attaque, un jet de capacité ou un jet de sauvegarde, vous pouvez dépenser un point de chance pour lancer un dé supplémentaire et choisir lequel utiliser. Vous pouvez également utiliser un point de chance pour faire relancer un jet d'attaque contre vous.", "Lucky", "Aucun", 1 },
                    { 21, "Lorsque vous êtes à portée de mêlée d'une créature qui lance un sort, vous pouvez utiliser votre réaction pour effectuer une attaque de mêlée contre cette créature. Lorsque vous infligez des dégâts à une créature qui se concentre sur un sort, elle a un désavantage sur le jet de sauvegarde pour maintenir sa concentration. Vous avez l'avantage sur les jets de sauvegarde contre les sorts lancés par des créatures à portée de mêlée de vous.", "Mage Slayer", "Aucun", 1 },
                    { 22, "Choisissez une classe de sort (barde, clerc, druide, ensorceleur, magicien, paladin, ranger, ou sorcier). Vous apprenez deux tours de magie au choix de cette classe. Vous apprenez également un sort de 1er niveau à lancer une fois par jour avec cette caractéristique de classe.", "Magic Initiate", "Aucun", 1 },
                    { 23, "Vous apprenez deux manœuvres au choix parmi celles disponibles pour l'archétype Martial du guerrier. Si une manœuvre vous oblige à effectuer un jet de sauvegarde pour résister à ses effets, le DD de sauvegarde est égal à 8 + votre bonus de compétence + votre modificateur de Force ou de Dextérité (à votre choix). Vous gagnez une d6 de supériorité que vous pouvez utiliser pour effectuer ces manœuvres.", "Martial Adept", "Aucun", 1 },
                    { 24, "Portez une armure intermédiaire ne vous impose plus de désavantage sur les jets de Dextérité (Discrétion). Lorsque vous portez une armure intermédiaire, vous pouvez ajouter 3 au lieu de 2 à votre CA si vous avez un modificateur de Dextérité positif.", "Medium Armor Master", "Compétence avec les armures intermédiaires", 1 },
                    { 25, "Votre vitesse augmente de 10 pieds. Lorsque vous utilisez l'action pour vous désengager, votre déplacement n'est pas réduit par le terrain difficile jusqu'à la fin de votre tour. Lorsque vous effectuez une attaque au corps à corps contre une créature, vous ne provoquez pas d'attaque d'opportunité de sa part pour le reste de votre tour, que vous l'ayez touchée ou non.", "Mobile", "Aucun", 1 },
                    { 26, "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Vous gagnez la compétence avec les armures intermédiaires et les boucliers.", "Moderately Armored", "Compétence avec les armures légères", 1 },
                    { 27, "Vous avez l'avantage sur les jets d'attaque contre toute créature de taille inférieure à celle de votre monture. Vous pouvez forcer une attaque visant votre monture à vous viser à la place. Si votre monture doit effectuer un jet de sauvegarde pour résister à un effet qui ne lui inflige que la moitié des dégâts en cas de succès, elle subit 0 dégâts en cas de succès et la moitié des dégâts en cas d'échec.", "Mounted Combatant", "Aucun", 1 },
                    { 28, "Augmentez votre Intelligence ou Sagesse de 1, jusqu'à un maximum de 20. Si vous pouvez voir la bouche d'une créature pendant qu'elle parle une langue que vous comprenez, vous pouvez interpréter ce qu'elle dit en lisant sur ses lèvres. Vous avez un bonus de +5 aux jets de Sagesse (Perception) et d'Intelligence (Investigation).", "Observant", "Aucun", 1 },
                    { 29, "Lorsque vous prenez l'action d'attaque et attaquez avec une lance, une hallebarde, un bâton ou une pique, vous pouvez utiliser une action bonus pour effectuer une attaque de mêlée avec l'extrémité opposée de l'arme. Cette attaque inflige des dégâts contondants égaux à 1d4 + votre modificateur de Force. Pendant votre tour, les autres créatures provoquent une attaque d'opportunité lorsque qu'elles entrent dans votre portée d'arme de mêlée.", "Polearm Master", "Aucun", 1 },
                    { 30, "Augmentez une caractéristique de votre choix de 1, jusqu'à un maximum de 20. Vous gagnez la compétence dans les jets de sauvegarde utilisant cette caractéristique.", "Resilient", "Aucun", 1 },
                    { 31, "Vous apprenez deux sorts de niveau 1 au choix qui ont la propriété Rituel à partir d'une liste de sorts de n'importe quelle classe. Vous devez posséder un livre de sorts, qui contient ces sorts rituels.", "Ritual Caster", "Intelligence ou Sagesse 13 ou plus", 1 },
                    { 32, "Une fois par tour lorsque vous infligez des dégâts avec une arme de mêlée, vous pouvez relancer les dés de dégâts de l'arme et utiliser les meilleurs résultats.", "Savage Attacker", "Aucun", 1 },
                    { 33, "Lorsque vous touchez une créature avec une attaque d'opportunité, sa vitesse devient 0 pour le reste du tour. Les créatures à portée de votre arme de mêlée provoquent une attaque d'opportunité même si elles utilisent l'action de désengagement. Lorsque une créature à portée de mêlée attaque une cible autre que vous, vous pouvez utiliser votre réaction pour effectuer une attaque de mêlée contre cette créature.", "Sentinel", "Aucun", 1 },
                    { 34, "Attaquer à longue portée n'impose pas de désavantage à vos jets d'attaque à distance. Vos attaques à distance ignorent la couverture à moitié et les trois quarts. Avant de faire une attaque à distance avec une arme à distance avec laquelle vous êtes compétent, vous pouvez choisir de prendre un malus de -5 au jet d'attaque. Si l'attaque touche, vous ajoutez +10 aux dégâts de l'attaque.", "Sharpshooter", "Aucun", 1 },
                    { 35, "Si vous utilisez l'action d'attaque lors de votre tour, vous pouvez utiliser une action bonus pour tenter de pousser une créature à portée avec votre bouclier. Si vous n'êtes pas immobilisé, vous pouvez ajouter votre bonus de bouclier à n'importe quel jet de sauvegarde de Dextérité contre un effet qui affecte seulement vous. Si vous subissez un jet de sauvegarde de Dextérité pour prendre seulement la moitié des dégâts, vous pouvez utiliser votre réaction pour ne subir aucun dégât si vous réussissez.", "Shield Master", "Aucun", 1 },
                    { 36, "Vous gagnez la compétence dans trois compétences ou outils au choix.", "Skilled", "Aucun", 1 },
                    { 37, "Vous pouvez tenter de vous cacher lorsque vous êtes légèrement obscurci par la lumière naturelle, une créature manque une attaque à distance contre vous et vous pouvez vous cacher, et lorsque vous attaquez et manquez avec une arme à distance, votre position n'est pas révélée.", "Skulker", "Dextérité 13 ou plus", 1 },
                    { 38, "Lorsque vous lancez un sort qui nécessite un jet d'attaque, la portée du sort est doublée. Vos attaques avec des sorts ignorent la couverture à moitié et les trois quarts. Vous apprenez un tour de magie au choix nécessitant un jet d'attaque à partir d'une liste de sorts d'une classe.", "Spell Sniper", "Capacité à lancer au moins un sort", 1 },
                    { 39, "Augmentez votre Force ou Constitution de 1, jusqu'à un maximum de 20. Vous êtes compétent avec les armes improvisées et vos attaques à mains nues infligent des dégâts contondants égaux à 1d4 + votre modificateur de Force. Lorsque vous frappez une créature avec une attaque à mains nues ou une arme improvisée pendant votre tour, vous pouvez utiliser une action bonus pour tenter d'agripper la cible.", "Tavern Brawler", "Aucun", 1 },
                    { 40, "Votre maximum de points de vie augmente de 2 pour chaque niveau que vous avez, et de 2 pour chaque niveau que vous gagnez par la suite.", "Tough", "Aucun", 1 },
                    { 41, "Vous avez l'avantage sur les jets de sauvegarde de Constitution pour maintenir votre concentration sur un sort lorsque vous subissez des dégâts. Vous pouvez effectuer des composantes somatiques de sorts même si vous avez des armes ou un bouclier dans une ou les deux mains. Lorsque vous provoquez une attaque d'opportunité, vous pouvez lancer un sort au lieu d'une attaque de mêlée.", "War Caster", "Capacité à lancer au moins un sort", 1 },
                    { 42, "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Vous gagnez la compétence dans quatre armes au choix.", "Weapon Master", "Aucun", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_sourceId",
                table: "Backgrounds",
                column: "sourceId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundSkills_BackgroundsId",
                table: "BackgroundSkills",
                column: "BackgroundsId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundSkills_SkillsId",
                table: "BackgroundSkills",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_sourceId",
                table: "Classes",
                column: "sourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSkills_ClassesId",
                table: "ClassSkills",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSkills_SkillsId",
                table: "ClassSkills",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ArmorId",
                table: "Entities",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_BackgroundId",
                table: "Entities",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ClasseId",
                table: "Entities",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_RaceId",
                table: "Entities",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ShieldId",
                table: "Entities",
                column: "ShieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ToolOneId",
                table: "Entities",
                column: "ToolOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ToolTwoId",
                table: "Entities",
                column: "ToolTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_UserId",
                table: "Entities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_WeaponOneId",
                table: "Entities",
                column: "WeaponOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_WeaponTwoId",
                table: "Entities",
                column: "WeaponTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_entitySkills_EntitiesId",
                table: "entitySkills",
                column: "EntitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_entitySkills_SkillsId",
                table: "entitySkills",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_sourceId",
                table: "Feats",
                column: "sourceId");

            migrationBuilder.CreateIndex(
                name: "IX_inventories_EntitiesId",
                table: "inventories",
                column: "EntitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_inventories_ItemsId",
                table: "inventories",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TypesItemsId",
                table: "Items",
                column: "TypesItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceLanguages_LanguagesId",
                table: "RaceLanguages",
                column: "LanguagesId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceLanguages_RacesId",
                table: "RaceLanguages",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_sourceId",
                table: "Races",
                column: "sourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_sourceId",
                table: "Spells",
                column: "sourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolesId",
                table: "Users",
                column: "RolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackgroundSkills");

            migrationBuilder.DropTable(
                name: "ClassSkills");

            migrationBuilder.DropTable(
                name: "entitySkills");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "inventories");

            migrationBuilder.DropTable(
                name: "RaceLanguages");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TypesItems");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
