using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeCake.DAL.Migrations
{
    public partial class Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_BiscuitDto_BiscuitId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_CreamDto_CreamId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_FillingDto_FillingId",
                table: "Tiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FillingDto",
                table: "FillingDto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreamDto",
                table: "CreamDto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BiscuitDto",
                table: "BiscuitDto");

            migrationBuilder.RenameTable(
                name: "FillingDto",
                newName: "Fillings");

            migrationBuilder.RenameTable(
                name: "CreamDto",
                newName: "Creams");

            migrationBuilder.RenameTable(
                name: "BiscuitDto",
                newName: "Biscuits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fillings",
                table: "Fillings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Creams",
                table: "Creams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Biscuits",
                table: "Biscuits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_Biscuits_BiscuitId",
                table: "Tiers",
                column: "BiscuitId",
                principalTable: "Biscuits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_Creams_CreamId",
                table: "Tiers",
                column: "CreamId",
                principalTable: "Creams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_Fillings_FillingId",
                table: "Tiers",
                column: "FillingId",
                principalTable: "Fillings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_Biscuits_BiscuitId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_Creams_CreamId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_Fillings_FillingId",
                table: "Tiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fillings",
                table: "Fillings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Creams",
                table: "Creams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Biscuits",
                table: "Biscuits");

            migrationBuilder.RenameTable(
                name: "Fillings",
                newName: "FillingDto");

            migrationBuilder.RenameTable(
                name: "Creams",
                newName: "CreamDto");

            migrationBuilder.RenameTable(
                name: "Biscuits",
                newName: "BiscuitDto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FillingDto",
                table: "FillingDto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreamDto",
                table: "CreamDto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BiscuitDto",
                table: "BiscuitDto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_BiscuitDto_BiscuitId",
                table: "Tiers",
                column: "BiscuitId",
                principalTable: "BiscuitDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_CreamDto_CreamId",
                table: "Tiers",
                column: "CreamId",
                principalTable: "CreamDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_FillingDto_FillingId",
                table: "Tiers",
                column: "FillingId",
                principalTable: "FillingDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
