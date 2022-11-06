using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeCake.DAL.Migrations
{
    public partial class AddRelationsToBiscuitDTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Fillings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Creams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Biscuits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "BiscuitDtoCreamDto",
                columns: table => new
                {
                    BiscuitsId = table.Column<int>(type: "int", nullable: false),
                    CreamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiscuitDtoCreamDto", x => new { x.BiscuitsId, x.CreamsId });
                    table.ForeignKey(
                        name: "FK_BiscuitDtoCreamDto_Biscuits_BiscuitsId",
                        column: x => x.BiscuitsId,
                        principalTable: "Biscuits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BiscuitDtoCreamDto_Creams_CreamsId",
                        column: x => x.CreamsId,
                        principalTable: "Creams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BiscuitDtoFillingDto",
                columns: table => new
                {
                    BiscuitsId = table.Column<int>(type: "int", nullable: false),
                    FillingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiscuitDtoFillingDto", x => new { x.BiscuitsId, x.FillingsId });
                    table.ForeignKey(
                        name: "FK_BiscuitDtoFillingDto_Biscuits_BiscuitsId",
                        column: x => x.BiscuitsId,
                        principalTable: "Biscuits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BiscuitDtoFillingDto_Fillings_FillingsId",
                        column: x => x.FillingsId,
                        principalTable: "Fillings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiscuitDtoCreamDto_CreamsId",
                table: "BiscuitDtoCreamDto",
                column: "CreamsId");

            migrationBuilder.CreateIndex(
                name: "IX_BiscuitDtoFillingDto_FillingsId",
                table: "BiscuitDtoFillingDto",
                column: "FillingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiscuitDtoCreamDto");

            migrationBuilder.DropTable(
                name: "BiscuitDtoFillingDto");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Fillings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Creams");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Biscuits");
        }
    }
}
