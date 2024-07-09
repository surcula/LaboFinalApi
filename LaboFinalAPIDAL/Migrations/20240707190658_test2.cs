using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SourceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SourceId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "CastingTime", "Components", "Description", "Duration", "HigherLevel", "Level", "Name", "Range", "School", "SourceId" },
                values: new object[,]
                {
                    { 7, "1 action", "V, S, M", "Une colonne d'énergie électrique tombe du ciel sur une cible que vous pouvez voir dans la portée. La cible doit réussir un jet de sauvegarde de Dextérité, sinon elle subit 8d6 points de dégâts de foudre, ou la moitié des dégâts en cas de succès.", "Instantanée", "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 4 ou plus, les dégâts augmentent de 1d6 pour chaque niveau d'emplacement au-dessus du niveau 3.", 3, "Appel de Foudre", "46 mètres", "Évocation", 1 },
                    { 8, "1 action", "V, S", "Vous tentez de charmer une créature que vous pouvez voir dans la portée. Elle doit réussir un jet de sauvegarde de Sagesse ou être charmée par vous jusqu'à la fin du sort.", "1 heure", "Quand vous lancez ce sort en utilisant un emplacement de sort de niveau 2 ou plus, vous pouvez cibler une créature supplémentaire pour chaque niveau d'emplacement au-dessus du niveau 1.", 1, "Charme-Personnes", "18 mètres", "Enchantement", 1 },
                    { 9, "1 réaction, qui vous est accordée lorsque vous êtes la cible d'un sort de 1er niveau ou plus qui n'est pas une créature", "V, S", "Une barrière invisible de force magique apparaît et vous protège. Jusqu'au début de votre prochain tour, vous avez une armure de +5 CA, y compris contre l'attaque qui a déclenché le sort.", "1 round", "", 3, "Miroir de Renvoi", "Personnelle", "Abjuration", 1 },
                    { 10, "1 action", "V, S", "Pour la durée, vous sentez la présence de la magie dans les domaines, dans la zone de la mémoire en  question ne la pas dans un rayon, détermine la présence de la magie. si le la voir  créature ou magiques, dans  être ou  objet et dans une portée.", "Concentration, jusqu'à 10 minutes", "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 2 ou plus, le nombre de créatures ou d'objets magiques que vous pouvez détecter augmente de 1 pour chaque niveau d'emplacement au-dessus du niveau 1.", 1, "Détection de la Magie", "Rouleau de 18 mètres", "Divination", 1 },
                    { 11, "1 action", "V, S, M", "Vous bénissez jusqu'à trois créatures de votre choix dans la portée. Chaque fois qu'une cible effectue un jet d'attaque ou un jet de sauvegarde avant que le sort ne se termine, la cible peut lancer un d4 supplémentaire et ajouter le nombre jeté au jet d'attaque ou au jet de sauvegarde.", "Concentration, jusqu'à 1 minute", "Lorsque vous lancez ce sort en utilisant un emplacement de sort de niveau 2 ou plus, vous pouvez cibler une créature supplémentaire pour chaque niveau d'emplacement au-dessus du niveau 1.", 1, "Bénédiction", "18 mètres", "Enchantement", 1 },
                    { 12, "1 action", "V, S", "La magie étrange détectée en une chaque portée, de les neutralisant par et même. le cas échéant de la objet  nombre est répartie, la magic. d'un la portée  chaque  bien que se  manifester dépend d'une. si être, le, réduit en magique, dissipation de la ou sont et l'ange. le la ou même disparait, qu'il.", "Concentration, jusqu'à 1 minute", "", 3, "Dissipation de la Magie", "Personnelle", "Abjuration", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SourceId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SourceId",
                value: 2);
        }
    }
}
