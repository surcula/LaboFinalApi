using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CharismsBonus",
                table: "Races",
                newName: "CharismasBonus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CharismasBonus",
                table: "Races",
                newName: "CharismsBonus");
        }
    }
}
