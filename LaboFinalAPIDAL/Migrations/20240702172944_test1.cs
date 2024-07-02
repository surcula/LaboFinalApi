using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
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
                    Feature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backgrounds_Sources_SourceId",
                        column: x => x.SourceId,
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
                    NbSkill = table.Column<int>(type: "int", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Sources_SourceId",
                        column: x => x.SourceId,
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
                    SourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feats_Sources_SourceId",
                        column: x => x.SourceId,
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
                    Speed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Sources_SourceId",
                        column: x => x.SourceId,
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
                    Level = table.Column<int>(type: "int", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Components = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CastingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HigherLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_Sources_SourceId",
                        column: x => x.SourceId,
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
                    Price = table.Column<int>(type: "int", nullable: true),
                    Ca = table.Column<int>(type: "int", nullable: true),
                    weight = table.Column<double>(type: "float", nullable: true),
                    Ca_Bonus = table.Column<int>(type: "int", nullable: true),
                    DiceType = table.Column<int>(type: "int", nullable: true),
                    DiceNumber = table.Column<int>(type: "int", nullable: true),
                    propreties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_TypesItems_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypesItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BackgroundSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackgroundSkills_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundSkills_Skills_SkillId",
                        column: x => x.SkillId,
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
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSkills_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSkills_Skills_SkillId",
                        column: x => x.SkillId,
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
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceLanguages_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundsItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BackgroundId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundsItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BackgroundsItems_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundsItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
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
                    ClassId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Entities_Classes_ClassId",
                        column: x => x.ClassId,
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
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entitySkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_entitySkills_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_entitySkills_Skills_SkillId",
                        column: x => x.SkillId,
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
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventories_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventories_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Language" },
                values: new object[,]
                {
                    { 1, "Commun" },
                    { 2, "Nain" },
                    { 3, "Elfique" },
                    { 4, "Gnome" },
                    { 5, "Halfelin" },
                    { 6, "Orc" },
                    { 7, "Abyssal" },
                    { 8, "Céleste" },
                    { 9, "Commun des profondeurs" },
                    { 10, "Draconique" },
                    { 11, "Infernal" },
                    { 12, "Primordial" },
                    { 13, "Sylvestre" },
                    { 14, "Squelettique" },
                    { 15, "Ignan" },
                    { 16, "Terran" },
                    { 17, "Aquatique" },
                    { 18, "Auran" },
                    { 19, "Géant" },
                    { 20, "Gobelin" },
                    { 21, "Gnoll" },
                    { 22, "Halfling" },
                    { 23, "Orc" },
                    { 24, "Profond" },
                    { 25, "Chaque" },
                    { 26, "Mortel" },
                    { 27, "Mouvement" },
                    { 28, "Liaison" },
                    { 29, "Ces" },
                    { 30, "Ici" },
                    { 31, "Mortelle" },
                    { 32, "Moustique" },
                    { 33, "L'Argile" },
                    { 34, "Monde" },
                    { 35, "Merveilles" },
                    { 36, "Messager" },
                    { 37, "Aujourd'hui" },
                    { 38, "Peut" },
                    { 39, "Les" },
                    { 40, "L'Immonde" },
                    { 41, "Meuble" },
                    { 42, "Migale" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Skill" },
                values: new object[,]
                {
                    { 1, "Acrobaties (Dex)" },
                    { 2, "Arcanes (Int)" },
                    { 3, "Athlétisme (For)" },
                    { 4, "Discrétion (Dex)" },
                    { 5, "Dressage (Sag)" },
                    { 6, "Escamotage (Dex)" },
                    { 7, "Histoire (Int)" },
                    { 8, "Intimidation (Cha)" },
                    { 9, "Intuition (Sag)" },
                    { 10, "Investigation (Int)" },
                    { 11, "Médecine (Sag)" },
                    { 12, "Nature (Int)" },
                    { 13, "Perception (Sag)" },
                    { 14, "Persuasion (Cha)" },
                    { 15, "Religion (Int)" },
                    { 16, "Représentation (Cha)" },
                    { 17, "Survie (Sag)" },
                    { 18, "Tromperie (Cha)" }
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
                    { 8, "Extra(divers)" },
                    { 9, "Monsters of the Multiverse" },
                    { 10, "Van Richten's Guide Ravenloft" },
                    { 11, "Ereborn: Rising from the Last War" },
                    { 12, "Sword Coast Adventurer's Guide" },
                    { 13, "Strixhaven : A Curriculum of Chaos" }
                });

            migrationBuilder.InsertData(
                table: "TypesItems",
                columns: new[] { "Id", "TypeItem" },
                values: new object[,]
                {
                    { 1, "Armes courantes de corps à corps" },
                    { 2, "Armes courantes à distance" },
                    { 3, "Armes de guerre de corps à corps" },
                    { 4, "Armes de guerre à distance" },
                    { 5, "Armures légères" },
                    { 6, "Armures intermédiaires" },
                    { 7, "Amures lourdes" },
                    { 8, "Bouclier" },
                    { 9, "Instrument de musique" },
                    { 10, "Jeux" },
                    { 11, "Outils d'artisan" },
                    { 12, "Montures" },
                    { 13, "Objet" },
                    { 14, "Munitions" },
                    { 15, "Symbole sacré" }
                });

            migrationBuilder.InsertData(
                table: "Backgrounds",
                columns: new[] { "Id", "Background", "Feature", "FeatureDescription", "LanguageNumber", "SourceId" },
                values: new object[,]
                {
                    { 1, "Acolyte", "Abri du fidèle", null, 2, 1 },
                    { 2, "Artisan de guilde", "Membre de guilde (soutiens des compagnons de guilde)", null, 1, 1 },
                    { 3, "Artiste", "À la demande du public", null, 0, 1 },
                    { 4, "Charlatan", "Fausse identité", null, 0, 1 },
                    { 5, "Chevalier", "Domestiques", null, 1, 1 },
                    { 6, "Criminel", "Accointances avec la pègre", null, 0, 1 },
                    { 7, "Enfant des rues", "Secrets de la ville (trouver un passage dans un labyrinthe urbain et se déplacer en ville 2 fois plus rapidement)", null, 0, 1 },
                    { 8, "Ermite", "Découverte", null, 1, 1 },
                    { 9, "Héros du peuple", "Hospitalité rustique", null, 0, 1 },
                    { 10, "Marin", "Place à bord", null, 0, 1 },
                    { 11, "Noble", "Apanage de la noblesse (bienvenue dans la haute société)", null, 1, 1 },
                    { 12, "Sage", "Chercheur", null, 2, 1 },
                    { 13, "Sauvageon", "Éternel vagabond", null, 1, 1 },
                    { 14, "Soldat", "Grade militaire", null, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CharismaBonus", "Class", "ConstitutionBonus", "DV", "DexterityBonus", "IntelligenceBonus", "NbSkill", "SourceId", "StrenghtBonus", "WisdomBonus" },
                values: new object[,]
                {
                    { 1, 0, "Barbare", 0, 12, 0, 0, 2, 1, 0, 0 },
                    { 2, 0, "Barde", 0, 8, 0, 0, 3, 1, 0, 0 },
                    { 3, 0, "Clerc", 0, 8, 0, 0, 2, 1, 0, 0 },
                    { 4, 0, "Druide", 0, 8, 0, 0, 2, 1, 0, 0 },
                    { 5, 0, "Ensorceleur", 0, 12, 0, 0, 2, 1, 0, 0 },
                    { 6, 0, "Guerrier", 0, 10, 0, 0, 2, 1, 0, 0 },
                    { 7, 0, "Magicien", 0, 6, 0, 0, 2, 1, 0, 0 },
                    { 8, 0, "Moine", 0, 8, 0, 0, 2, 1, 0, 0 },
                    { 9, 0, "Occultiste", 0, 8, 0, 0, 2, 1, 0, 0 },
                    { 10, 0, "Paladin", 0, 10, 0, 0, 2, 1, 0, 0 },
                    { 11, 0, "Rodeur", 0, 10, 0, 0, 3, 1, 0, 0 },
                    { 12, 0, "Roublard", 0, 8, 0, 0, 4, 1, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feats",
                columns: new[] { "Id", "Description", "Name", "Prerequisite", "SourceId" },
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
                    { 42, "Augmentez votre Force ou Dextérité de 1, jusqu'à un maximum de 20. Vous gagnez la compétence dans quatre armes au choix.", "Weapon Master", "Aucun", 1 },
                    { 43, "Choisissez une école de magie. Vous apprenez deux sorts de niveau 1 de cette école. Vous pouvez les lancer sans utiliser de composantes matérielles. Vous gagnez une récupération partielle des emplacements de sorts utilisés.", "Adepte des arcanes", "Classe de lanceur de sorts", 2 },
                    { 44, "Vous apprenez deux manœuvres au choix parmi celles disponibles pour l'archétype Martial du guerrier. Vous gagnez une d6 de supériorité pour les manœuvres.", "Apprenti Martial", "Aucun", 2 },
                    { 45, "Lorsque vous effectuez une action pour aider un allié, la portée de cette action est de 30 pieds. Vous pouvez utiliser votre réaction pour accorder un bonus d'attaque ou de CA à un allié dans un rayon de 30 pieds.", "Chef de bande", "Charisme 13 ou plus", 2 },
                    { 46, "Lorsque vous utilisez un kit de soins, la créature regagne des points de vie supplémentaires égaux à 1d6 + 4 + son nombre de dés de vie.", "Guérisseur", "Aucun", 2 },
                    { 47, "Vous avez l'avantage sur les jets de Sagesse (Survie) pour suivre les créatures et les jets de Constitution pour éviter les épuisements dus aux voyages sur de longues distances.", "Marcheur des bois", "Aucun", 2 },
                    { 48, "Vous pouvez essayer de vous cacher même lorsque vous êtes légèrement obscurci par des feuillages, de la neige, de la pluie ou d'autres phénomènes naturels.", "Maître du camouflage", "Aucun", 2 },
                    { 49, "Vous pouvez copier un sort dans votre livre de sorts en moitié moins de temps et en utilisant moitié moins de ressources.", "Maître des livres de sorts", "Intelligence 13 ou plus", 2 },
                    { 50, "Vous apprenez deux sorts de l'école de magie de l'abjuration ou de la divination. Vous pouvez les lancer sans utiliser de composantes matérielles.", "Percepteur des arcanes", "Intelligence 13 ou plus", 2 },
                    { 51, "Vous avez l'avantage sur les jets pour rester en selle. Si votre monture est forcée de faire un jet de sauvegarde pour éviter des effets, elle subit seulement la moitié des dégâts en cas de réussite.", "Pilote de monture", "Aucun", 2 },
                    { 52, "Vous pouvez vous déplacer à votre vitesse normale à travers une foule. Vous avez l'avantage sur les jets de Sagesse (Perception) et d'Intelligence (Investigation) pour trouver des individus ou des objets cachés en milieu urbain.", "Rodeur urbain", "Aucun", 2 },
                    { 53, "Lorsque vous lancez un sort nécessitant un jet d'attaque, la portée du sort est doublée. Vos attaques de sort ignorent la demi-couverture et les trois quarts de couverture.", "Sniper de sort", "Capacité à lancer au moins un sort", 2 },
                    { 54, "Vous n'avez pas de désavantage sur les jets d'attaque à distance à longue portée. Vos attaques à distance ignorent la couverture à moitié et les trois quarts. Avant de faire une attaque à distance, vous pouvez choisir de prendre un malus de -5 au jet d'attaque. Si l'attaque touche, vous ajoutez +10 aux dégâts de l'attaque.", "Tireur d'élite", "Aucun", 2 },
                    { 55, "Vous apprenez deux sorts de votre liste de sorts. Vous pouvez les lancer sans utiliser de composantes matérielles. Vous pouvez également les lancer une fois chacun sans utiliser de slots de sorts.", "Virtuose des arcanes", "Capacité à lancer au moins un sort", 2 },
                    { 56, "Vous apprenez un tour de magie de la liste de sorts de l'artificier. Vous apprenez également deux sorts de 1er niveau de la liste de sorts de l'artificier. Vous pouvez lancer chacun de ces sorts une fois sans utiliser d'emplacement de sort. Vous récupérez la capacité de le faire lorsque vous terminez un repos long.", "Artificier initié", "Aucun", 3 },
                    { 57, "Vous gagnez une compétence avec les armes de guerre et une compétence avec un bouclier. Vous gagnez également une attaque supplémentaire avec une arme de guerre ou un bouclier.", "Initiation au combat rapproché", "Aucun", 3 },
                    { 58, "Lorsque vous lancez un sort de métamorphose de 1er niveau ou plus qui cible une créature amie, vous pouvez cibler une deuxième créature amie dans la portée du sort avec le même sort.", "Adepte des métamorphoses", "Aucun", 3 },
                    { 59, "Vous gagnez une compétence dans une arme au choix et une compétence dans une armure légère ou moyenne.", "Érudition martiale", "Aucun", 3 },
                    { 60, "Vous gagnez la compétence dans la compétence Survie. Vous avez l'avantage sur les jets de survie pour suivre les créatures et trouver de la nourriture et de l'eau dans la nature.", "Expert en survie", "Aucun", 3 },
                    { 61, "Vous apprenez la recette de trois potions de guérison et pouvez les créer pendant un repos long en utilisant des composants alchimiques.", "Initiation à l'alchimie", "Aucun", 3 },
                    { 62, "Vous gagnez une compétence avec les arcs longs et les arcs courts. Vous pouvez ignorer les pénalités de désavantage pour attaquer à longue portée avec ces armes.", "Initiation au tir à l'arc", "Aucun", 3 },
                    { 63, "Lorsque vous utilisez une baguette, un bâton ou un sceptre pour lancer un sort, vous pouvez augmenter le DD de sauvegarde du sort de 1.", "Adepte en manipulation magique", "Aucun", 3 },
                    { 64, "Lorsque vous protégez une créature amie avec votre bouclier, la créature gagne un bonus de +1 à la CA et vous avez l'avantage sur les jets de sauvegarde pour éviter d'être déplacé ou renversé.", "Défenseur des faibles", "Aucun", 3 },
                    { 65, "Vous apprenez deux sorts de la liste de sorts de l'école de l'illusion ou de la nécromancie. Vous pouvez les lancer sans utiliser de composantes matérielles.", "Sorcier de l'ombre", "Aucun", 3 },
                    { 66, "Vous pouvez créer une potion de guérison pendant un repos court en utilisant des composants alchimiques. Vous pouvez également identifier les potions en les goûtant.", "Maître des potions", "Aucun", 3 },
                    { 67, "Vous apprenez deux sorts de l'école de l'invocation. Vous pouvez les lancer sans utiliser de composantes matérielles.", "Initiation à l'invocation", "Aucun", 3 },
                    { 68, "Vous gagnez la compétence avec les armures intermédiaires et lourdes. Lorsque vous portez une armure intermédiaire ou lourde, vous pouvez ajouter 1 à la CA.", "Expert en armures", "Aucun", 3 },
                    { 69, "Vous gagnez la compétence avec les armes de guerre. Vous pouvez choisir deux armes de guerre et vous gagnez un bonus de +1 aux jets d'attaque et de dégâts avec ces armes.", "Expert en armes", "Aucun", 3 },
                    { 70, "Vous apprenez un tour de magie de la liste de sorts de l'ensorceleur, du magicien ou du sorcier. Vous pouvez également lancer un sort de niveau 1 de ces listes de sorts une fois sans utiliser d'emplacement de sort. Vous récupérez la capacité de le faire lorsque vous terminez un repos long.", "Initiation au combat magique", "Aucun", 3 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Ca", "Ca_Bonus", "DiceNumber", "DiceType", "Item", "Price", "TypeId", "propreties", "weight" },
                values: new object[,]
                {
                    { 1, null, null, 1, 6, "Bâton", 200, 1, "Polyvalente (1d8)", 2000.0 },
                    { 2, null, null, 1, 4, "Dague", 2000, 1, "Finesse, légère, lancer (portée 6 m/18 m)", 500.0 },
                    { 3, null, null, 1, 4, "Gourdin", 100, 1, "Légère", 1000.0 },
                    { 4, null, null, 1, 6, "Hachette", 5000, 1, "Légère, lancer (portée 6 m/18 m)", 1000.0 },
                    { 5, null, null, 1, 6, "Javeline", 500, 1, "Lancer (portée 9 m/36 m)", 1000.0 },
                    { 6, null, null, 1, 6, "Lance", 100, 1, "Lancer (portée 6 m/18 m), polyvalente (1d8)", 1500.0 },
                    { 7, null, null, 1, 4, "Marteau léger", 2000, 1, "Légère, lancer (portée 6 m/18 m)", 1000.0 },
                    { 8, null, null, 1, 6, "Masse d'armes", 5000, 1, null, 2000.0 },
                    { 9, null, null, 1, 8, "Massue", 200, 1, "À deux mains", 5000.0 },
                    { 10, null, null, 1, 4, "Serpe", 100, 1, "Légère", 1000.0 },
                    { 11, null, null, 1, 8, "Arbalète légère", 2500, 2, "Munitions (portée 24 m/96 m), chargement, à deux mains", 2500.0 },
                    { 12, null, null, 1, 6, "Arc court", 2500, 2, "Munitions (portée 24 m/96 m), à deux mains", 1000.0 },
                    { 13, null, null, 1, 4, "Fléchette", 50, 2, "Finesse, lancer (portée 6 m/18 m)", 100.0 },
                    { 14, null, null, 1, 4, "Fronde", 100, 2, "Munitions (portée 9 m/36 m)", 0.0 },
                    { 15, null, null, 1, 6, "Cimeterre", 2500, 3, "Finesse, légère", 1500.0 },
                    { 16, null, null, 1, 10, "Coutille", 2000, 3, "Lourde, allonge, à deux mains", 3000.0 },
                    { 17, null, null, 3, 6, "Épée à deux mains", 5000, 3, "Lourde, à deux mains", 3000.0 },
                    { 18, null, null, 1, 6, "Épée courte", 1000, 3, "Finesse, légère", 1000.0 },
                    { 19, null, null, 1, 8, "Épée longue", 1500, 3, "Polyvalente (1d10)", 1500.0 },
                    { 20, null, null, 1, 8, "Fléau d'armes", 1000, 3, null, 1000.0 },
                    { 21, null, null, 1, 4, "Fouet", 200, 3, "Finesse, allonge", 1500.0 },
                    { 22, null, null, 1, 12, "Hache à deux mains", 3000, 3, "Lourde, à deux mains", 3500.0 },
                    { 23, null, null, 1, 8, "Hache d'armes", 1000, 3, "Polyvalente (1d10)", 2000.0 },
                    { 24, null, null, 1, 10, "Hallebarde", 2000, 3, "Lourde, allonge, à deux mains", 3000.0 },
                    { 25, null, null, 1, 12, "Lance d’arçon", 1000, 3, "Allonge, spécial", 3000.0 },
                    { 26, null, null, 2, 6, "Maillet", 1000, 3, "Lourde, à deux mains", 5000.0 },
                    { 27, null, null, 1, 8, "Marteau de guerre", 1500, 3, "Polyvalente (1d10)", 1000.0 },
                    { 28, null, null, 1, 8, "Morgenstern", 1500, 3, null, 2000.0 },
                    { 29, null, null, 1, 8, "Pic de guerre", 500, 3, null, 1000.0 },
                    { 30, null, null, 1, 10, "Pique", 500, 3, "Lourde, allonge, à deux mains", 9000.0 },
                    { 31, null, null, 1, 8, "Rapière", 2500, 3, "Finesse", 1000.0 },
                    { 32, null, null, 1, 6, "Trident", 500, 3, "Lancer (portée 6 m/18 m), polyvalente (1d8)", 2000.0 },
                    { 33, null, null, 4, 6, "Arbalète de poing", 7500, 2, "Munitions (portée 9 m/36 m), légère, chargement", 1500.0 },
                    { 34, null, null, 4, 10, "Arbalète lourde", 5000, 2, "Munitions (portée 30 m/120 m), lourde, chargement, à deux mains", 9000.0 },
                    { 35, null, null, 1, 8, "Arc long", 5000, 2, "Munitions (portée 45 m/180 m), lourde, à deux mains", 1000.0 },
                    { 36, null, null, 0, 0, "Filet", 100, 4, "Lancer (portée 1,50 m/4,50 m), spécial", 1500.0 },
                    { 37, null, null, 1, 1, "Sarbacane", 1000, 4, "Munitions (portée 7,50 m/15 m), légère", 500.0 },
                    { 38, 11, null, null, null, "Matelassée", 500, 5, "Discrétion : Désavantage", 4000.0 },
                    { 39, 11, null, null, null, "Cuir", 1000, 5, null, 5000.0 },
                    { 40, 12, null, null, null, "Cuir clouté", 4500, 5, null, 6500.0 },
                    { 41, 12, null, null, null, "Peaux", 1000, 6, "Mod.Dex (max +2)", 6000.0 },
                    { 42, 13, null, null, null, "Chemise de mailles", 5000, 6, "Mod.Dex (max +2)", 10000.0 },
                    { 43, 14, null, null, null, "Écailles", 5000, 6, "Mod.Dex (max +2), Discrétion : Désavantage", 22500.0 },
                    { 44, 14, null, null, null, "Cuirasse", 40000, 6, "Mod.Dex (max +2)", 10000.0 },
                    { 45, 15, null, null, null, "Demi-plate", 75000, 6, "Mod.Dex (max +2), Discrétion : Désavantage", 20000.0 },
                    { 46, 14, null, null, null, "Broigne", 3000, 7, "Discrétion : Désavantage", 20000.0 },
                    { 47, 16, null, null, null, "Cotte de mailles", 7500, 7, "Forces : 13, Discrétion : Désavantage", 27500.0 },
                    { 48, 17, null, null, null, "Clibanion", 20000, 7, "Forces : 15, Discrétion : Désavantage", 30000.0 },
                    { 49, 18, null, null, null, "Harnois", 150000, 7, "Forces : 15, Discrétion : Désavantage", 32500.0 },
                    { 50, 2, null, null, null, "Bouclier", 1000, 8, null, 3000.0 },
                    { 51, null, null, null, null, "Chalemie", 200, 9, null, 500.0 },
                    { 52, null, null, null, null, "Cor", 300, 9, null, 1000.0 },
                    { 53, null, null, null, null, "Cornemuse", 3000, 9, null, 3000.0 },
                    { 54, null, null, null, null, "Flûte", 200, 9, null, 500.0 },
                    { 55, null, null, null, null, "Flûte de pan", 1200, 9, null, 1000.0 },
                    { 56, null, null, null, null, "Luth", 3500, 9, null, 1000.0 },
                    { 57, null, null, null, null, "Lyre", 3000, 9, null, 1000.0 },
                    { 58, null, null, null, null, "Tambour", 600, 9, null, 1500.0 },
                    { 59, null, null, null, null, "Tympanon", 2500, 9, null, 5000.0 },
                    { 60, null, null, null, null, "Viole", 3000, 9, null, 500.0 },
                    { 61, null, null, null, null, "Dés", 10, 10, null, 0.0 },
                    { 62, null, null, null, null, "Jeu d'échecs draconiques", 100, 10, null, 250.0 },
                    { 63, null, null, null, null, "Jeu de cartes", 50, 10, null, 0.0 },
                    { 64, null, null, null, null, "Jeu des Dragons", 100, 10, null, 0.0 },
                    { 65, null, null, null, null, "Kit d'empoisonneur", 5000, 11, null, 1000.0 },
                    { 66, null, null, null, null, "Kit d'herboriste", 500, 11, null, 1500.0 },
                    { 67, null, null, null, null, "Kit de contrefaçon", 1500, 11, null, 2500.0 },
                    { 68, null, null, null, null, "Kit de déguisement", 2500, 11, null, 1500.0 },
                    { 69, null, null, null, null, "Matériel d'alchimiste", 5000, 11, null, 4000.0 },
                    { 70, null, null, null, null, "Matériel de brasseur", 2000, 11, null, 4500.0 },
                    { 71, null, null, null, null, "Matériel de calligraphe", 1000, 11, null, 2500.0 },
                    { 72, null, null, null, null, "Matériel de peintre", 1000, 11, null, 2500.0 },
                    { 73, null, null, null, null, "Outils de bijoutier", 2500, 11, null, 1000.0 },
                    { 74, null, null, null, null, "Outils de bricoleur", 5000, 11, null, 5000.0 },
                    { 75, null, null, null, null, "Outils de cartographe", 1500, 11, null, 3000.0 },
                    { 76, null, null, null, null, "Outils de charpentier", 800, 11, null, 3000.0 },
                    { 77, null, null, null, null, "Outils de cordonnier", 500, 11, null, 2500.0 },
                    { 78, null, null, null, null, "Outils de forgeron", 2000, 11, null, 4000.0 },
                    { 79, null, null, null, null, "Outils de maçon", 1000, 11, null, 4000.0 },
                    { 80, null, null, null, null, "Outils de menuisier", 100, 11, null, 2500.0 },
                    { 81, null, null, null, null, "Outils de potier", 1000, 11, null, 1000.0 },
                    { 82, null, null, null, null, "Outils de souffleur de verre", 3000, 11, null, 2500.0 },
                    { 83, null, null, null, null, "Outils de tanneur", 500, 11, null, 2500.0 },
                    { 84, null, null, null, null, "Outils de tisserand", 100, 11, null, 2500.0 },
                    { 85, null, null, null, null, "Ustensiles de cuisinier", 100, 11, null, 4000.0 },
                    { 86, null, null, null, null, "Outils de navigateur", 2500, 11, null, 1000.0 },
                    { 87, null, null, null, null, "Outils de voleur", 2500, 11, null, 500.0 },
                    { 88, null, null, null, null, "Âne ou mule", 800, 12, "Vitesse : 12 m, Capacité de charge : 210 kg", 0.0 },
                    { 89, null, null, null, null, "Chameau", 5000, 12, "Vitesse : 15 m, Capacité de charge : 240 kg", 0.0 },
                    { 90, null, null, null, null, "Cheval de guerre", 40000, 12, "Vitesse : 18 m, Capacité de charge : 270 kg", 0.0 },
                    { 91, null, null, null, null, "Cheval de selle", 7500, 12, "Vitesse : 18 m, Capacité de charge : 240 kg", 0.0 },
                    { 92, null, null, null, null, "Cheval de trait", 5000, 12, "Vitesse : 12 m, Capacité de charge : 270 kg", 0.0 },
                    { 93, null, null, null, null, "Éléphant", 20000, 12, "Vitesse : 12 m, Capacité de charge : 660 kg", 0.0 },
                    { 94, null, null, null, null, "Molosse", 2500, 12, "Vitesse : 12 m, Capacité de charge : 95 kg", 0.0 },
                    { 95, null, null, null, null, "Poney", 3000, 12, "Vitesse : 12 m, Capacité de charge : 115 kg", 0.0 },
                    { 97, null, null, null, null, "Antidote (fiole)", 5000, 13, null, 0.0 },
                    { 98, null, null, null, null, "Balance de marchand", 500, 13, null, 1500.0 },
                    { 99, null, null, null, null, "Bélier portable", 400, 13, null, 17500.0 },
                    { 100, null, null, null, null, "Billes (sac de 1000)", 100, 13, null, 1000.0 },
                    { 101, null, null, null, null, "Boite d'allume-feu", 5, 13, null, 500.0 },
                    { 102, null, null, null, null, "Bougie", 1, 13, null, 0.0 },
                    { 103, null, null, null, null, "Boulier", 2, 13, null, 1000.0 },
                    { 104, null, null, null, null, "Bouteille en verre", 2, 13, null, 1000.0 },
                    { 105, null, null, null, null, "Cadenas", 10, 13, null, 500.0 },
                    { 106, null, null, null, null, "Carquois", 1, 13, null, 500.0 },
                    { 107, null, null, null, null, "Chaîne (3 m)", 5, 13, null, 5000.0 },
                    { 108, null, null, null, null, "Chausse-trappes (sac de 20)", 1, 13, null, 1000.0 },
                    { 109, null, null, null, null, "Chevalière", 5, 13, null, 0.0 },
                    { 110, null, null, null, null, "Cire à cacheter", 5, 13, null, 0.0 },
                    { 111, null, null, null, null, "Cloche", 1, 13, null, 0.0 },
                    { 112, null, null, null, null, "Coffre", 5, 13, null, 12500.0 },
                    { 113, null, null, null, null, "Corde en chanvre (15 m)", 1, 13, null, 5000.0 },
                    { 114, null, null, null, null, "Corde en soie (15 m)", 10, 13, null, 2500.0 },
                    { 115, null, null, null, null, "Couverture", 5, 13, null, 1500.0 },
                    { 116, null, null, null, null, "Craie (un morceau)", 1, 13, null, 0.0 },
                    { 117, null, null, null, null, "Cruche ou pichet", 2, 13, null, 2000.0 },
                    { 118, null, null, null, null, "Eau bénite (flasque)", 2500, 13, null, 500.0 },
                    { 119, null, null, null, null, "Échelle (3 m)", 1, 13, null, 12500.0 },
                    { 120, null, null, null, null, "Encre (bouteille de 30 ml)", 10, 13, null, 0.0 },
                    { 121, null, null, null, null, "Étui à carreaux", 1, 13, null, 500.0 },
                    { 122, null, null, null, null, "Étui à cartes ou parchemins", 1, 13, null, 500.0 },
                    { 123, null, null, null, null, "Feu grégeois (flasque)", 5000, 13, null, 500.0 },
                    { 124, null, null, null, null, "Fiole (10 cl)", 1, 13, null, 0.0 },
                    { 125, null, null, null, null, "Flasque ou chope (50 cl)", 2, 13, null, 500.0 },
                    { 126, null, null, null, null, "Focaliseur arcanique - Baguette", 10, 13, null, 500.0 },
                    { 127, null, null, null, null, "Focaliseur arcanique - Bâton", 5, 13, null, 2000.0 },
                    { 128, null, null, null, null, "Focaliseur arcanique - Boule de cristal", 10, 13, null, 500.0 },
                    { 129, null, null, null, null, "Focaliseur arcanique - Orbe", 20, 13, null, 1500.0 },
                    { 130, null, null, null, null, "Focaliseur arcanique - Sceptre", 10, 13, null, 1000.0 },
                    { 131, null, null, null, null, "Focaliseur druidique - Baguette d'if", 10, 13, null, 500.0 },
                    { 132, null, null, null, null, "Focaliseur druidique - Bâton", 5, 13, null, 2000.0 },
                    { 133, null, null, null, null, "Focaliseur druidique - Branche de gui", 1, 13, null, 0.0 },
                    { 134, null, null, null, null, "Focaliseur druidique - Totem", 1, 13, null, 0.0 },
                    { 135, null, null, null, null, "Gamelle", 2, 7, null, 500.0 },
                    { 136, null, null, null, null, "Gourde (pleine)", 2, 13, null, 2500.0 },
                    { 137, null, null, null, null, "Grappin", 2, 13, null, 2000.0 },
                    { 138, null, null, null, null, "Grimoire", 50, 13, null, 1500.0 },
                    { 139, null, null, null, null, "Huile (flasque)", 1, 13, null, 500.0 },
                    { 140, null, null, null, null, "Kit d’escalade", 25, 13, null, 6000.0 },
                    { 141, null, null, null, null, "Lampe", 5, 13, null, 500.0 },
                    { 142, null, null, null, null, "Lanterne à capote", 5, 13, null, 1000.0 },
                    { 143, null, null, null, null, "Lanterne sourde", 10, 13, null, 1000.0 },
                    { 144, null, null, null, null, "Livre", 25, 13, null, 2500.0 },
                    { 145, null, null, null, null, "Longue-vue", 1000, 13, null, 500.0 },
                    { 146, null, null, null, null, "Loupe", 100, 13, null, 0.0 },
                    { 147, null, null, null, null, "Marteau", 1, 13, null, 1500.0 },
                    { 148, null, null, null, null, "Marteau de forgeron", 2, 13, null, 5000.0 },
                    { 149, null, null, null, null, "Matériel de pêche", 1, 13, null, 2000.0 },
                    { 150, null, null, null, null, "Menottes", 2, 13, null, 3000.0 },
                    { 151, null, null, null, null, "Miroir en acier", 5, 13, null, 250.0 },
                    { 152, null, null, null, null, "Aiguilles de sarbacane (50)", 100, 11, null, 500.0 },
                    { 153, null, null, null, null, "Billes de fronde (20)", 4, 11, null, 750.0 },
                    { 154, null, null, null, null, "Carreaux d'arbalète (20)", 1, 11, null, 750.0 },
                    { 155, null, null, null, null, "Flèches (20)", 1, 11, null, 500.0 },
                    { 156, null, null, null, null, "Palan", 1, 13, null, 2500.0 },
                    { 157, null, null, null, null, "Panier", 4, 13, null, 1000.0 },
                    { 158, null, null, null, null, "Papier (une feuille)", 2, 13, null, 0.0 },
                    { 159, null, null, null, null, "Parchemin (une feuille)", 1, 13, null, 0.0 },
                    { 160, null, null, null, null, "Parfum (fiole)", 5, 13, null, 0.0 },
                    { 161, null, null, null, null, "Pelle", 2, 13, null, 2500.0 },
                    { 162, null, null, null, null, "Perche (3 m)", 5, 13, null, 3500.0 },
                    { 163, null, null, null, null, "Pied-de-biche", 2, 13, null, 2500.0 },
                    { 164, null, null, null, null, "Piège à mâchoires", 5, 13, null, 12500.0 },
                    { 165, null, null, null, null, "Pierre à aiguiser", 1, 13, null, 500.0 },
                    { 166, null, null, null, null, "Pioche de mineur", 2, 13, null, 5000.0 },
                    { 167, null, null, null, null, "Piton", 5, 13, null, 125.0 },
                    { 168, null, null, null, null, "Plume d’écriture", 2, 13, null, 0.0 },
                    { 169, null, null, null, null, "Pointes en fer (10)", 1, 13, null, 2500.0 },
                    { 170, null, null, null, null, "Poison (fiole)", 100, 13, null, 0.0 },
                    { 171, null, null, null, null, "Pot en fer", 2, 13, null, 5000.0 },
                    { 172, null, null, null, null, "Potion de guérison", 50, 13, null, 250.0 },
                    { 173, null, null, null, null, "Rations (1 jour)", 5, 13, null, 1000.0 },
                    { 174, null, null, null, null, "Robes", 1, 13, null, 2000.0 },
                    { 175, null, null, null, null, "Sablier", 25, 13, null, 500.0 },
                    { 176, null, null, null, null, "Sac", 1, 13, null, 250.0 },
                    { 177, null, null, null, null, "Sac à dos", 2, 13, null, 2500.0 },
                    { 178, null, null, null, null, "Sac de couchage", 1, 13, null, 3500.0 },
                    { 179, null, null, null, null, "Sacoche", 5, 10, null, 500.0 },
                    { 180, null, null, null, null, "Sacoche à composantes", 25, 13, null, 1000.0 },
                    { 181, null, null, null, null, "Savon", 2, 13, null, 0.0 },
                    { 182, null, null, null, null, "Seau", 5, 13, null, 1000.0 },
                    { 183, null, null, null, null, "Sifflet", 5, 13, null, 0.0 },
                    { 184, null, null, null, null, "Amulette", 5, 12, null, 500.0 },
                    { 185, null, null, null, null, "Emblème", 5, 12, null, 0.0 },
                    { 186, null, null, null, null, "Reliquaire", 5, 12, null, 1000.0 },
                    { 187, null, null, null, null, "Tente", 200, 13, null, 10000.0 },
                    { 188, null, null, null, null, "Tonneau", 200, 13, null, 35000.0 },
                    { 189, null, null, null, null, "Torche", 1, 13, null, 500.0 },
                    { 190, null, null, null, null, "Trousse de soins", 500, 13, null, 1500.0 },
                    { 191, null, null, null, null, "Vêtements, communs", 5, 13, null, 1500.0 },
                    { 192, null, null, null, null, "Vêtements, costume", 500, 13, null, 2000.0 },
                    { 193, null, null, null, null, "Vêtements, fins", 1500, 13, null, 3000.0 },
                    { 194, null, null, null, null, "Vêtements, voyage", 200, 13, null, 2000.0 }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CharismsBonus", "ConstitutionBonus", "DexterityBonus", "IntelligenceBonus", "Race", "Size", "SourceId", "Speed", "StrenghtBonus", "WisdomBonus" },
                values: new object[,]
                {
                    { 1, "0", "0", "2", "1", "Haut-elfe", "M", 1, "9m/round", "0", "0" },
                    { 2, "0", "0", "2", "0", "elfe des bois", "M", 1, "10,5m/round", "0", "1" },
                    { 3, "1", "0", "2", "0", "elfe noir", "M", 1, "9m/round", "0", "0" },
                    { 4, "1", "0", "2", "0", "Halfelin pied-léger", "P", 1, "7,5m/round", "0", "0" },
                    { 5, "0", "1", "2", "0", "Halfelin robuste", "P", 1, "7,5m/round", "0", "0" },
                    { 6, "1", "1", "1", "1", "Humain ", "M", 1, "9m/round", "1", "1" },
                    { 7, "0", "0", "0", "0", "Humain (Don)", "M", 1, "9m/round", "0", "0" },
                    { 8, "0", "2", "0", "0", "Nain des collines", "M", 1, "7,5m/round", "0", "1" },
                    { 9, "0", "2", "0", "0", "Nain des montagnes", "M", 1, "7.5m/round", "2", "0" },
                    { 10, "2", "0", "0", "0", "Demi-elfe", "M", 1, "9m/round", "0", "0" },
                    { 11, "0", "1", "0", "0", "Demi-Orc", "M", 1, "9m/round", "2", "0" },
                    { 12, "1", "0", "0", "0", "Drakéide", "M", 1, "9m/round", "2", "0" },
                    { 13, "0", "0", "1", "2", "Gnome des forêts", "P", 1, "7,5m/round", "0", "0" },
                    { 14, "0", "1", "0", "2", "Gnome des roches", "P", 1, "7,5m/round", "0", "0" },
                    { 15, "2", "0", "0", "1", "Tieffelin", "M", 1, "9m/round", "0", "0" },
                    { 16, "0", "0", "0", "0", "Aarakocra", "M", 9, "7,5m/round (marche), 15m/round (vol)", "0", "0" },
                    { 17, "0", "0", "0", "0", "Aasimar", "M", 9, "9m/round", "0", "0" },
                    { 18, "0", "0", "0", "0", "Centaure", "M", 9, "12m/round", "0", "0" },
                    { 19, "0", "0", "0", "0", "Changeling", "M", 9, "9m/round", "0", "0" },
                    { 20, "0", "0", "0", "0", "Conil", "P", 9, "9m/round", "0", "0" },
                    { 21, "0", "0", "0", "0", "Dhampire", "M", 10, "9m/round", "0", "0" },
                    { 22, "0", "0", "0", "0", "Duergar", "M", 10, "7,5m/round", "0", "0" },
                    { 23, "0", "0", "0", "0", "Eladrin", "M", 10, "9m/round", "0", "0" },
                    { 24, "0", "0", "0", "0", "Elfe aquatique", "M", 10, "9m/round, 9m/nage", "0", "0" },
                    { 25, "0", "0", "0", "0", "Fadette", "M", 10, "10,5m/round", "0", "0" },
                    { 26, "0", "0", "0", "0", "Féral", "M", 10, "9m/round", "0", "0" },
                    { 27, "0", "0", "0", "0", "Firbolg", "M", 10, "9m/round", "0", "0" },
                    { 28, "0", "0", "0", "0", "Forgelier", "M", 11, "9m/round", "0", "0" },
                    { 29, "0", "0", "0", "0", "Genasi (Air)", "M", 9, "9m/round", "0", "0" },
                    { 30, "0", "0", "0", "0", "Genasi (Terre)", "M", 9, "9m/round", "0", "0" },
                    { 31, "0", "0", "0", "0", "Genasi (Feu)", "M", 9, "9m/round", "0", "0" },
                    { 32, "0", "0", "0", "0", "Genasi (Eau)", "M", 9, "9m/round, 9m/nage", "0", "0" },
                    { 33, "0", "0", "0", "0", "Githzerai", "M", 9, "9m/round", "0", "0" },
                    { 34, "0", "0", "0", "0", "Gnome des profondeurs", "P", 9, "7,5m/round", "0", "0" },
                    { 35, "0", "0", "0", "0", "Gobelin", "P", 9, "9m/round", "0", "0" },
                    { 36, "0", "0", "0", "0", "Gobelours", "M", 9, "9m/round", "0", "0" },
                    { 37, "0", "0", "0", "0", "Goliath", "M", 9, "9m/round", "0", "0" },
                    { 38, "0", "0", "0", "0", "Halfelin sagespectre", "P", 12, "7,5m/round", "0", "0" },
                    { 39, "0", "0", "0", "0", "Hiboulin", "M", 13, "9m/round (marche), 10,5m/round (vol)", "0", "0" },
                    { 40, "0", "0", "0", "0", "Hobgobelin", "M", 9, "9m/round", "0", "0" },
                    { 41, "0", "0", "0", "0", "Homme-Lézard", "M", 9, "9m/round, 9m/nage", "0", "0" },
                    { 42, "0", "0", "0", "0", "Kenku", "M", 9, "9m/round", "0", "0" },
                    { 43, "0", "0", "0", "0", "Kobold", "P", 9, "9m/round", "0", "0" },
                    { 44, "0", "0", "0", "0", "Minotaure", "M", 9, "9m/round", "0", "0" },
                    { 45, "0", "0", "0", "0", "Orc", "M", 9, "9m/round", "0", "0" },
                    { 46, "0", "0", "0", "0", "Ressucité", "M", 10, "9m/round", "0", "0" },
                    { 47, "0", "0", "0", "0", "Sang maudit", "M", 10, "9m/round", "0", "0" },
                    { 48, "0", "0", "0", "0", "Satyre", "M", 9, "10,5m/round", "0", "0" },
                    { 49, "0", "0", "0", "0", "Shadar-kai", "M", 9, "9m/round", "0", "0" },
                    { 50, "0", "0", "0", "0", "Tabaxi", "M", 9, "9m/round", "0", "0" },
                    { 51, "0", "0", "0", "0", "Torte", "M", 9, "9m/round", "0", "0" },
                    { 52, "0", "0", "0", "0", "Triton", "M", 9, "9m/round, 9m/nage", "0", "0" },
                    { 53, "0", "0", "0", "0", "Yuan-ti", "M", 3, "9m/round", "0", "0" }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "CastingTime", "Components", "Description", "Duration", "HigherLevel", "Level", "Name", "Range", "School", "SourceId" },
                values: new object[,]
                {
                    { 1, "1 action", "V, S, M", "Un trait lumineux jaillit de votre doigt pointé vers un point que vous choisissez dans la portée, puis éclate avec un rugissement en une explosion de flammes.", "Instantanée", "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 4 ou plus, les dégâts augmentent de 1d6 pour chaque niveau d'emplacement au-dessus du niveau 3.", 3, "Boule de Feu", "45 mètres", "Évocation", 1 },
                    { 2, "1 action", "V, S", "Vous créez trois projectiles lumineux de force magique. Chaque projectile touche une créature de votre choix que vous pouvez voir dans la portée.", "Instantanée", "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 2 ou plus, le sort crée un projectile supplémentaire pour chaque niveau d'emplacement au-dessus du niveau 1.", 1, "Projectile Magique", "36 mètres", "Évocation", 1 },
                    { 3, "1 action bonus", "V", "Une créature de votre choix que vous pouvez voir dans la portée regagne un nombre de points de vie égal à 1d4 + votre modificateur de capacité de lancement de sorts.", "Instantanée", "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 2 ou plus, la guérison augmente de 1d4 pour chaque niveau d'emplacement au-dessus du niveau 1.", 1, "Mot de Guérison", "18 mètres", "Évocation", 2 },
                    { 4, "1 réaction, que vous prenez lorsque vous êtes touché par une attaque ou ciblé par le sort projectile magique", "V, S", "Une barrière invisible de force magique apparaît et vous protège. Jusqu'au début de votre prochain tour, vous avez un bonus de +5 à la CA, y compris contre l'attaque déclenchant, et vous ne subissez aucun dégât de projectile magique.", "1 round", "", 1, "Bouclier", "Personnelle", "Abjuration", 2 },
                    { 5, "1 action", "V, S, M", "Un éclair de lumière jaillit de vos doigts tendus pour frapper une cible que vous pouvez voir dans la portée. La cible doit réussir un jet de sauvegarde de Dextérité, sinon elle subit 8d6 points de dégâts de foudre, ou la moitié des dégâts en cas de succès.", "Instantanée", "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 4 ou plus, les dégâts augmentent de 1d6 pour chaque niveau d'emplacement au-dessus du niveau 3.", 3, "Éclair", "30 mètres", "Évocation", 1 },
                    { 6, "1 action", "V, S", "Une main spectrale flottante apparaît à un point que vous choisissez dans la portée. La main reste pour la durée ou jusqu'à ce que vous la congédiez par une action. La main peut manipuler un objet, ouvrir une porte ou un contenant, ranger ou récupérer un objet dans un conteneur ouvert, ou verser le contenu d'une fiole.", "1 minute", "", 0, "Main de Mage", "9 mètres", "Transmutation", 1 }
                });

            migrationBuilder.InsertData(
                table: "BackgroundSkills",
                columns: new[] { "Id", "BackgroundId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 2, 1, 15 },
                    { 3, 2, 9 },
                    { 4, 2, 14 },
                    { 5, 3, 1 },
                    { 6, 3, 16 },
                    { 7, 4, 6 },
                    { 8, 4, 18 },
                    { 9, 5, 7 },
                    { 10, 5, 14 },
                    { 11, 6, 4 },
                    { 12, 6, 18 },
                    { 13, 7, 4 },
                    { 14, 7, 6 },
                    { 15, 8, 11 },
                    { 16, 8, 15 },
                    { 17, 9, 5 },
                    { 18, 9, 17 },
                    { 19, 10, 3 },
                    { 20, 10, 13 },
                    { 21, 11, 7 },
                    { 22, 11, 14 },
                    { 23, 12, 2 },
                    { 24, 12, 7 },
                    { 25, 13, 3 },
                    { 26, 13, 17 },
                    { 27, 14, 3 },
                    { 28, 14, 8 }
                });

            migrationBuilder.InsertData(
                table: "BackgroundsItems",
                columns: new[] { "Id", "BackgroundId", "ItemId" },
                values: new object[,]
                {
                    { 1, 3, 68 },
                    { 2, 4, 68 },
                    { 3, 4, 67 },
                    { 4, 6, 87 },
                    { 5, 7, 68 },
                    { 6, 7, 87 },
                    { 7, 8, 66 },
                    { 8, 10, 86 }
                });

            migrationBuilder.InsertData(
                table: "ClassSkills",
                columns: new[] { "Id", "ClassId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 1, 5 },
                    { 3, 1, 8 },
                    { 4, 1, 12 },
                    { 5, 1, 13 },
                    { 6, 1, 17 },
                    { 7, 2, 1 },
                    { 8, 2, 2 },
                    { 9, 2, 3 },
                    { 10, 2, 4 },
                    { 11, 2, 5 },
                    { 12, 2, 6 },
                    { 13, 2, 7 },
                    { 14, 2, 8 },
                    { 15, 2, 9 },
                    { 16, 2, 10 },
                    { 17, 2, 11 },
                    { 18, 2, 12 },
                    { 19, 2, 13 },
                    { 20, 2, 14 },
                    { 21, 2, 15 },
                    { 22, 2, 16 },
                    { 23, 2, 17 },
                    { 24, 2, 18 },
                    { 25, 3, 7 },
                    { 26, 3, 9 },
                    { 27, 3, 11 },
                    { 28, 3, 14 },
                    { 29, 3, 15 },
                    { 30, 4, 2 },
                    { 31, 4, 5 },
                    { 32, 4, 9 },
                    { 33, 4, 11 },
                    { 34, 4, 12 },
                    { 35, 4, 13 },
                    { 36, 4, 15 },
                    { 37, 4, 17 },
                    { 38, 5, 2 },
                    { 39, 5, 8 },
                    { 40, 5, 9 },
                    { 41, 5, 14 },
                    { 42, 5, 15 },
                    { 43, 5, 18 },
                    { 44, 6, 1 },
                    { 45, 6, 3 },
                    { 46, 6, 5 },
                    { 47, 6, 7 },
                    { 48, 6, 8 },
                    { 49, 6, 9 },
                    { 50, 6, 13 },
                    { 51, 6, 17 },
                    { 52, 7, 2 },
                    { 53, 7, 7 },
                    { 54, 7, 9 },
                    { 55, 7, 10 },
                    { 56, 7, 11 },
                    { 57, 7, 15 },
                    { 58, 8, 1 },
                    { 59, 8, 3 },
                    { 60, 8, 4 },
                    { 61, 8, 7 },
                    { 62, 8, 9 },
                    { 63, 8, 15 },
                    { 64, 9, 2 },
                    { 65, 9, 7 },
                    { 66, 9, 8 },
                    { 67, 9, 10 },
                    { 68, 9, 12 },
                    { 69, 9, 15 },
                    { 70, 9, 18 },
                    { 71, 10, 3 },
                    { 72, 10, 8 },
                    { 73, 10, 9 },
                    { 74, 10, 11 },
                    { 75, 10, 14 },
                    { 76, 10, 15 },
                    { 77, 11, 3 },
                    { 78, 11, 4 },
                    { 79, 11, 5 },
                    { 80, 11, 9 },
                    { 81, 11, 10 },
                    { 82, 11, 12 },
                    { 83, 11, 13 },
                    { 84, 11, 17 },
                    { 85, 12, 1 },
                    { 86, 12, 3 },
                    { 87, 12, 4 },
                    { 88, 12, 6 },
                    { 89, 12, 8 },
                    { 90, 12, 9 },
                    { 91, 12, 10 },
                    { 92, 12, 13 },
                    { 93, 12, 14 },
                    { 94, 12, 16 },
                    { 95, 12, 18 }
                });

            migrationBuilder.InsertData(
                table: "RaceLanguages",
                columns: new[] { "Id", "LanguageId", "RaceId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 1, 2 },
                    { 4, 3, 2 },
                    { 5, 1, 3 },
                    { 6, 3, 3 },
                    { 7, 1, 4 },
                    { 8, 5, 4 },
                    { 9, 1, 5 },
                    { 10, 5, 5 },
                    { 11, 1, 6 },
                    { 12, 1, 7 },
                    { 13, 1, 8 },
                    { 14, 2, 8 },
                    { 15, 1, 9 },
                    { 16, 2, 9 },
                    { 17, 1, 10 },
                    { 18, 3, 10 },
                    { 19, 1, 11 },
                    { 20, 6, 11 },
                    { 21, 1, 12 },
                    { 22, 10, 12 },
                    { 23, 1, 13 },
                    { 24, 4, 13 },
                    { 25, 1, 14 },
                    { 26, 4, 14 },
                    { 27, 1, 15 },
                    { 28, 11, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_SourceId",
                table: "Backgrounds",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundsItems_BackgroundId",
                table: "BackgroundsItems",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundsItems_ItemId",
                table: "BackgroundsItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundSkills_BackgroundId",
                table: "BackgroundSkills",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundSkills_SkillId",
                table: "BackgroundSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SourceId",
                table: "Classes",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSkills_ClassId",
                table: "ClassSkills",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSkills_SkillId",
                table: "ClassSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ArmorId",
                table: "Entities",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_BackgroundId",
                table: "Entities",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_ClassId",
                table: "Entities",
                column: "ClassId");

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
                name: "IX_entitySkills_EntityId",
                table: "entitySkills",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_entitySkills_SkillId",
                table: "entitySkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_SourceId",
                table: "Feats",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_inventories_EntityId",
                table: "inventories",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_inventories_ItemId",
                table: "inventories",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TypeId",
                table: "Items",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceLanguages_LanguageId",
                table: "RaceLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceLanguages_RaceId",
                table: "RaceLanguages",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SourceId",
                table: "Races",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SourceId",
                table: "Spells",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackgroundsItems");

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
