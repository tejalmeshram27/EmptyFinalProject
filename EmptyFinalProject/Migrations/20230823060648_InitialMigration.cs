using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyFinalProject.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    catergoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.catergoryId);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    playersReq = table.Column<int>(type: "int", nullable: false),
                    sportsType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportsId);
                    table.ForeignKey(
                        name: "FK_Sports_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "catergoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "catergoryId", "categoryName", "description" },
                values: new object[] { 1, "Boring", "Very Boring" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "catergoryId", "categoryName", "description" },
                values: new object[] { 2, "Watchable", "Can Watch" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "catergoryId", "categoryName", "description" },
                values: new object[] { 3, "Interesting", "Very Interesting" });

            migrationBuilder.CreateIndex(
                name: "IX_Sports_categoryId",
                table: "Sports",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
