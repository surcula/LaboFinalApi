using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NbSkill",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                column: "NbSkill",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                column: "NbSkill",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11,
                column: "NbSkill",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12,
                column: "NbSkill",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Language",
                value: "Elfique");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Language",
                value: "Orc");

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 4,
                column: "RaceId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "RaceLanguages",
                columns: new[] { "Id", "LanguageId", "RaceId" },
                values: new object[,]
                {
                    { 10, 5, 5 },
                    { 11, 1, 6 },
                    { 12, 1, 7 },
                    { 13, 1, 8 },
                    { 14, 2, 8 },
                    { 15, 1, 9 },
                    { 16, 2, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CharismsBonus", "ConstitutionBonus", "DexterityBonus", "Race", "StrenghtBonus", "WisdomBonus" },
                values: new object[] { "0", "0", "2", "Haut-elfe", "0", "0" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IntelligenceBonus", "Race", "Speed", "WisdomBonus" },
                values: new object[] { "0", "elfe des bois", "10,5m/round", "1" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CharismsBonus", "DexterityBonus", "Race" },
                values: new object[] { "1", "2", "elfe noir" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CharismsBonus", "ConstitutionBonus", "DexterityBonus", "Race", "Size", "Speed", "StrenghtBonus" },
                values: new object[] { "1", "0", "2", "Halfelin pied-léger", "P", "7,5m/round", "0" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConstitutionBonus", "DexterityBonus", "IntelligenceBonus", "Race", "Speed" },
                values: new object[] { "1", "2", "0", "Halfelin robuste", "7,5m/round" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CharismsBonus", "DexterityBonus", "IntelligenceBonus", "Race", "StrenghtBonus", "WisdomBonus" },
                values: new object[] { "1", "1", "1", "Humain ", "1", "1" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CharismsBonus", "IntelligenceBonus", "Race", "WisdomBonus" },
                values: new object[] { "0", "0", "Humain (Don)", "0" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConstitutionBonus", "DexterityBonus", "Race", "Speed", "WisdomBonus" },
                values: new object[] { "2", "0", "Nain des collines", "7,5m/round", "1" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConstitutionBonus", "DexterityBonus", "Race", "Speed", "StrenghtBonus" },
                values: new object[] { "2", "0", "Nain des montagnes", "7.5m/round", "2" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CharismsBonus", "ConstitutionBonus", "DexterityBonus", "IntelligenceBonus", "Race", "Size", "SourceId", "Speed", "StrenghtBonus", "WisdomBonus" },
                values: new object[,]
                {
                    { 10, "2", "0", "0", "0", "Demi-elfe", "M", 1, "9m/round", "0", "0" },
                    { 11, "0", "1", "0", "0", "Demi-Orc", "M", 1, "9m/round", "2", "0" },
                    { 12, "1", "0", "0", "0", "Drakéide", "M", 1, "9m/round", "2", "0" },
                    { 13, "0", "0", "1", "2", "Gnome des forêts", "P", 1, "7,5m/round", "0", "0" },
                    { 14, "0", "1", "0", "2", "Gnome des roches", "P", 1, "7,5m/round", "0", "0" },
                    { 15, "2", "0", "0", "1", "Tieffelin", "M", 1, "9m/round", "0", "0" },
                    { 53, "0", "0", "0", "0", "Yuan-ti", "M", 3, "9m/round", "0", "0" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Skill" },
                values: new object[,]
                {
                    { 1, "Acrobaties (Dex)" },
                    { 2, "Arcanes (Int)" },
                    { 3, "Athlétisme (For)" },
                    { 4, "Tromperie (Cha)" },
                    { 5, "Médecine (Sag)" },
                    { 6, "Intuition (Sag)" },
                    { 7, "Discrétion (Dex)" },
                    { 8, "Investigation (Int)" },
                    { 9, "Intimidation (Cha)" },
                    { 10, "Perception (Sag)" },
                    { 11, "Persuasion (Cha)" },
                    { 12, "Religion (Int)" },
                    { 13, "Dressage (Sag)" },
                    { 14, "Survie (Sag)" },
                    { 15, "Nature (Int)" },
                    { 16, "Escamotage (Dex)" },
                    { 17, "Histoire (Int)" },
                    { 18, "Représentation (Cha)" }
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Source" },
                values: new object[,]
                {
                    { 9, "Monsters of the Multiverse" },
                    { 10, "Van Richten's Guide Ravenloft" },
                    { 11, "Ereborn: Rising from the Last War" },
                    { 12, "Sword Coast Adventurer's Guide" },
                    { 13, "Strixhaven : A Curriculum of Chaos" }
                });

            migrationBuilder.InsertData(
                table: "RaceLanguages",
                columns: new[] { "Id", "LanguageId", "RaceId" },
                values: new object[,]
                {
                    { 17, 1, 10 },
                    { 18, 2, 10 },
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

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CharismsBonus", "ConstitutionBonus", "DexterityBonus", "IntelligenceBonus", "Race", "Size", "SourceId", "Speed", "StrenghtBonus", "WisdomBonus" },
                values: new object[,]
                {
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
                    { 52, "0", "0", "0", "0", "Triton", "M", 9, "9m/round, 9m/nage", "0", "0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "NbSkill",
                table: "Classes");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Language",
                value: "Elfe");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Language",
                value: "Orque");

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 4,
                column: "RaceId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 15, 7 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LanguageId", "RaceId" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CharismsBonus", "ConstitutionBonus", "DexterityBonus", "Race", "StrenghtBonus", "WisdomBonus" },
                values: new object[] { "1", "1", "1", "Humain", "1", "1" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IntelligenceBonus", "Race", "Speed", "WisdomBonus" },
                values: new object[] { "1", "Haut-elfe", "9m/round", "0" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CharismsBonus", "DexterityBonus", "Race" },
                values: new object[] { "0", "0", "Humain (Don)" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CharismsBonus", "ConstitutionBonus", "DexterityBonus", "Race", "Size", "Speed", "StrenghtBonus" },
                values: new object[] { "0", "2", "0", "Nain", "M", "7m/round", "2" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConstitutionBonus", "DexterityBonus", "IntelligenceBonus", "Race", "Speed" },
                values: new object[] { "0", "0", "2", "Gnome", "7m/round" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CharismsBonus", "DexterityBonus", "IntelligenceBonus", "Race", "StrenghtBonus", "WisdomBonus" },
                values: new object[] { "-1", "0", "-2", "Demi-Orc", "2", "0" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CharismsBonus", "IntelligenceBonus", "Race", "WisdomBonus" },
                values: new object[] { "1", "2", "Tieffelin", "1" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConstitutionBonus", "DexterityBonus", "Race", "Speed", "WisdomBonus" },
                values: new object[] { "0", "2", "Elfe Noire", "9m/round", "0" });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConstitutionBonus", "DexterityBonus", "Race", "Speed", "StrenghtBonus" },
                values: new object[] { "0", "2", "Elfe des Montagnes", "9m/round", "0" });
        }
    }
}
