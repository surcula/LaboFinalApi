using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CharismaBonus", "Class", "ConstitutionBonus", "DV", "DexterityBonus", "IntelligenceBonus", "SourceId", "StrenghtBonus", "WisdomBonus" },
                values: new object[,]
                {
                    { 1, 0, "Barbare", 0, 12, 0, 0, 1, 0, 0 },
                    { 2, 0, "Barde", 0, 8, 0, 0, 1, 0, 0 },
                    { 3, 0, "Clerc", 0, 8, 0, 0, 1, 0, 0 },
                    { 4, 0, "Roublard", 0, 8, 0, 0, 1, 0, 0 },
                    { 5, 0, "Druide", 0, 8, 0, 0, 1, 0, 0 },
                    { 6, 0, "Ensorceleur", 0, 12, 0, 0, 1, 0, 0 },
                    { 7, 0, "Guerrier", 0, 10, 0, 0, 1, 0, 0 },
                    { 8, 0, "Magicien", 0, 6, 0, 0, 1, 0, 0 },
                    { 9, 0, "Moine", 0, 8, 0, 0, 1, 0, 0 },
                    { 10, 0, "Occultiste", 0, 8, 0, 0, 1, 0, 0 },
                    { 11, 0, "Paladin", 0, 10, 0, 0, 1, 0, 0 },
                    { 12, 0, "Rodeur", 0, 10, 0, 0, 1, 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
