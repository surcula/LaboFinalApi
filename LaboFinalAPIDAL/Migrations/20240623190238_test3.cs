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
                table: "Feats",
                columns: new[] { "Id", "Description", "Name", "Prerequisite", "sourceId" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 70);
        }
    }
}
