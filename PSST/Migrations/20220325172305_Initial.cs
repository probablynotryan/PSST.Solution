using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PSST.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flavors",
                columns: table => new
                {
                    FlavorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FlavorName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flavors", x => x.FlavorId);
                });

            migrationBuilder.CreateTable(
                name: "Sweets",
                columns: table => new
                {
                    SweetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SweetName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sweets", x => x.SweetId);
                });

            migrationBuilder.CreateTable(
                name: "FlavorSweet",
                columns: table => new
                {
                    FlavorSweetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FlavorId = table.Column<int>(type: "int", nullable: false),
                    SweetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlavorSweet", x => x.FlavorSweetId);
                    table.ForeignKey(
                        name: "FK_FlavorSweet_Flavors_FlavorId",
                        column: x => x.FlavorId,
                        principalTable: "Flavors",
                        principalColumn: "FlavorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlavorSweet_Sweets_SweetId",
                        column: x => x.SweetId,
                        principalTable: "Sweets",
                        principalColumn: "SweetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlavorSweet_FlavorId",
                table: "FlavorSweet",
                column: "FlavorId");

            migrationBuilder.CreateIndex(
                name: "IX_FlavorSweet_SweetId",
                table: "FlavorSweet",
                column: "SweetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlavorSweet");

            migrationBuilder.DropTable(
                name: "Flavors");

            migrationBuilder.DropTable(
                name: "Sweets");
        }
    }
}
