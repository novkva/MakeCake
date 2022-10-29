using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeCake.DAL.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BiscuitDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiscuitDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreamDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreamDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FillingDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FillingDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diametr = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    BiscuitId = table.Column<int>(type: "int", nullable: false),
                    CreamId = table.Column<int>(type: "int", nullable: false),
                    FillingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiers_BiscuitDto_BiscuitId",
                        column: x => x.BiscuitId,
                        principalTable: "BiscuitDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tiers_CreamDto_CreamId",
                        column: x => x.CreamId,
                        principalTable: "CreamDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tiers_FillingDto_FillingId",
                        column: x => x.FillingId,
                        principalTable: "FillingDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_BiscuitId",
                table: "Tiers",
                column: "BiscuitId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_CreamId",
                table: "Tiers",
                column: "CreamId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_FillingId",
                table: "Tiers",
                column: "FillingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiers");

            migrationBuilder.DropTable(
                name: "BiscuitDto");

            migrationBuilder.DropTable(
                name: "CreamDto");

            migrationBuilder.DropTable(
                name: "FillingDto");
        }
    }
}
