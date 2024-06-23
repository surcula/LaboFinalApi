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
            migrationBuilder.InsertData(
                table: "Feats",
                columns: new[] { "Id", "Description", "Name", "Prerequisite", "sourceId" },
                values: new object[,]
                {
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
                    { 55, "Vous apprenez deux sorts de votre liste de sorts. Vous pouvez les lancer sans utiliser de composantes matérielles. Vous pouvez également les lancer une fois chacun sans utiliser de slots de sorts.", "Virtuose des arcanes", "Capacité à lancer au moins un sort", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Feats",
                keyColumn: "Id",
                keyValue: 55);
        }
    }
}
