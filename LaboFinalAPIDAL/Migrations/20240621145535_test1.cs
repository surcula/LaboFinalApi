using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_TypesItems_TypesItemsId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "TypesItemsId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_TypesItems_TypesItemsId",
                table: "Items",
                column: "TypesItemsId",
                principalTable: "TypesItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_TypesItems_TypesItemsId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "TypesItemsId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_TypesItems_TypesItemsId",
                table: "Items",
                column: "TypesItemsId",
                principalTable: "TypesItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
