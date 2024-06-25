using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_Sources_sourceId",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Sources_sourceId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Sources_sourceId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Sources_sourceId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Sources_sourceId",
                table: "Spells");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "sourceId",
                table: "Spells",
                newName: "SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_sourceId",
                table: "Spells",
                newName: "IX_Spells_SourceId");

            migrationBuilder.RenameColumn(
                name: "sourceId",
                table: "Races",
                newName: "SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Races_sourceId",
                table: "Races",
                newName: "IX_Races_SourceId");

            migrationBuilder.RenameColumn(
                name: "sourceId",
                table: "Feats",
                newName: "SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Feats_sourceId",
                table: "Feats",
                newName: "IX_Feats_SourceId");

            migrationBuilder.RenameColumn(
                name: "sourceId",
                table: "Classes",
                newName: "SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_sourceId",
                table: "Classes",
                newName: "IX_Classes_SourceId");

            migrationBuilder.RenameColumn(
                name: "sourceId",
                table: "Backgrounds",
                newName: "SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Backgrounds_sourceId",
                table: "Backgrounds",
                newName: "IX_Backgrounds_SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_Sources_SourceId",
                table: "Backgrounds",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Sources_SourceId",
                table: "Classes",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Sources_SourceId",
                table: "Feats",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Sources_SourceId",
                table: "Races",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Sources_SourceId",
                table: "Spells",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_Sources_SourceId",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Sources_SourceId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Sources_SourceId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Sources_SourceId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Sources_SourceId",
                table: "Spells");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Spells",
                newName: "sourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_SourceId",
                table: "Spells",
                newName: "IX_Spells_sourceId");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Races",
                newName: "sourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Races_SourceId",
                table: "Races",
                newName: "IX_Races_sourceId");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Feats",
                newName: "sourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Feats_SourceId",
                table: "Feats",
                newName: "IX_Feats_sourceId");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Classes",
                newName: "sourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_SourceId",
                table: "Classes",
                newName: "IX_Classes_sourceId");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Backgrounds",
                newName: "sourceId");

            migrationBuilder.RenameIndex(
                name: "IX_Backgrounds_SourceId",
                table: "Backgrounds",
                newName: "IX_Backgrounds_sourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_Sources_sourceId",
                table: "Backgrounds",
                column: "sourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Sources_sourceId",
                table: "Classes",
                column: "sourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Sources_sourceId",
                table: "Feats",
                column: "sourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Sources_sourceId",
                table: "Races",
                column: "sourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Sources_sourceId",
                table: "Spells",
                column: "sourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
