using Microsoft.EntityFrameworkCore.Migrations;

namespace Evimiz.Migrations
{
    public partial class changesApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AspNetUsers_İstifadəçiId",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "İstifadəçiId",
                table: "Advertisements",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_İstifadəçiId",
                table: "Advertisements",
                newName: "IX_Advertisements_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AspNetUsers_ApplicationUserId",
                table: "Advertisements",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AspNetUsers_ApplicationUserId",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Advertisements",
                newName: "İstifadəçiId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_ApplicationUserId",
                table: "Advertisements",
                newName: "IX_Advertisements_İstifadəçiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AspNetUsers_İstifadəçiId",
                table: "Advertisements",
                column: "İstifadəçiId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
