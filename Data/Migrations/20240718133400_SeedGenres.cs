using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStore.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Fighting" },
                    { 2, 2, "Roleplaying" },
                    { 3, 3, "Spots" },
                    { 4, 4, "Racing" },
                    { 5, 5, "Kids and Family" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
