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

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Class", "NbSkill" },
                values: new object[] { "Druide", 2 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Ensorceleur", 12 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Guerrier", 10 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Magicien", 6 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Moine", 8 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Class",
                value: "Occultiste");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Paladin", 10 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Class", "NbSkill" },
                values: new object[] { "Rodeur", 3 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Class", "DV", "NbSkill" },
                values: new object[] { "Roublard", 8, 4 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 2,
                column: "LanguageId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 4,
                column: "LanguageId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 6,
                column: "LanguageId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 18,
                column: "LanguageId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "Skill",
                value: "Discrétion (Dex)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "Skill",
                value: "Dressage (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "Skill",
                value: "Escamotage (Dex)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "Skill",
                value: "Histoire (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "Skill",
                value: "Intimidation (Cha)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "Skill",
                value: "Intuition (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "Skill",
                value: "Investigation (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "Skill",
                value: "Médecine (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "Skill",
                value: "Nature (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "Skill",
                value: "Perception (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "Skill",
                value: "Persuasion (Cha)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "Skill",
                value: "Religion (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "Skill",
                value: "Représentation (Cha)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "Skill",
                value: "Survie (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "Skill",
                value: "Tromperie (Cha)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ClassSkills",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Class", "NbSkill" },
                values: new object[] { "Roublard", 4 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Druide", 8 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Ensorceleur", 12 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Guerrier", 10 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Magicien", 6 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Class",
                value: "Moine");

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Class", "DV" },
                values: new object[] { "Occultiste", 8 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Class", "NbSkill" },
                values: new object[] { "Paladin", 2 });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Class", "DV", "NbSkill" },
                values: new object[] { "Rodeur", 10, 3 });

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 2,
                column: "LanguageId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 4,
                column: "LanguageId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 6,
                column: "LanguageId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RaceLanguages",
                keyColumn: "Id",
                keyValue: 18,
                column: "LanguageId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "Skill",
                value: "Tromperie (Cha)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "Skill",
                value: "Médecine (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "Skill",
                value: "Intuition (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "Skill",
                value: "Discrétion (Dex)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "Skill",
                value: "Investigation (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "Skill",
                value: "Intimidation (Cha)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "Skill",
                value: "Perception (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "Skill",
                value: "Persuasion (Cha)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "Skill",
                value: "Religion (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "Skill",
                value: "Dressage (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "Skill",
                value: "Survie (Sag)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "Skill",
                value: "Nature (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "Skill",
                value: "Escamotage (Dex)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "Skill",
                value: "Histoire (Int)");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "Skill",
                value: "Représentation (Cha)");
        }
    }
}
