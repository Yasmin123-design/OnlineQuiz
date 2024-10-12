using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineQuiz.Migrations
{
    /// <inheritdoc />
    public partial class insertagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
             table: "Categories",
             columns: new[] { "Name" },
             values: new object[,]
             {
                  { "Science" }, // 10
                  { "Math" },    // 11
                  {"Arabic" }    // 12
             });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
