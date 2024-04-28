using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IntroductionToFramework.Migrations
{
    /// <inheritdoc />
    public partial class CheckUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "blogs",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 2, "Tech Trends", "https://techtrends.com" },
                    { 3, "Health News", "https://healthnews.com" },
                    { 4, "Travel Chronicles", "https://travelchronicles.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "blogs",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
