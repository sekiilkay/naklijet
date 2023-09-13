using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JwtUser.Repository.Migrations
{
    /// <inheritdoc />
    public partial class from_tos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_CompanyId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Messages",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_CompanyId",
                table: "Messages",
                newName: "IX_Messages_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_AppUserId",
                table: "Messages",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_AppUserId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Messages",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_AppUserId",
                table: "Messages",
                newName: "IX_Messages_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_CompanyId",
                table: "Messages",
                column: "CompanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
