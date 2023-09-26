using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyFinalProject.Migrations
{
    public partial class MigrationLatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportsId", "categoryId", "name", "playersReq", "sportsType" },
                values: new object[,]
                {
                    { 1, 1, "Cricket", 22, "Outdoor" },
                    { 2, 2, "Badminton", 2, "Indoor" },
                    { 3, 3, "Kabaddi", 14, "Indoor" },
                    { 4, 1, "Football", 22, "Outdoor" },
                    { 5, 2, "Tennis", 2, "Outdoor" },
                    { 6, 3, "Golf", 1, "Outdoor" },
                    { 7, 2, "Basketball", 24, "Indoor" },
                    { 8, 3, "Baseball", 18, "Outdoor" },
                    { 9, 2, "Chess", 2, "Indoor" },
                    { 10, 3, "FoosBall", 4, "Indoor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "SportsId",
                keyValue: 10);
        }
    }
}
