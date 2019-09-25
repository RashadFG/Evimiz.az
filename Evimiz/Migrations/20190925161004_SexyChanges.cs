using Microsoft.EntityFrameworkCore.Migrations;

namespace Evimiz.Migrations
{
    public partial class SexyChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillageId",
                table: "Homes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Homes_VillageId",
                table: "Homes",
                column: "VillageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homes_Villages_VillageId",
                table: "Homes",
                column: "VillageId",
                principalTable: "Villages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homes_Villages_VillageId",
                table: "Homes");

            migrationBuilder.DropIndex(
                name: "IX_Homes_VillageId",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "VillageId",
                table: "Homes");
        }
    }
}
