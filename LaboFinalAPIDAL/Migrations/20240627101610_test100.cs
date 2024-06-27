using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboFinalAPIDAL.Migrations
{
    /// <inheritdoc />
    public partial class test100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "level",
                table: "Spells",
                newName: "Level");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Spells",
                newName: "level");
        }
    }
}
