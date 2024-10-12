using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineQuiz.Migrations
{
    /// <inheritdoc />
    public partial class deleteCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "Name",
            keyValue: "Science");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Math");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Arabic");
            migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "Name",
            keyValue: "Science");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Math");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Arabic");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
