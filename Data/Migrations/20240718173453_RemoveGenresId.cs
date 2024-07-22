using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveGenresId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Genre");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Games",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Genre",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Games",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                column: "GenreId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                column: "GenreId",
                value: 5);
        }
    }
}
