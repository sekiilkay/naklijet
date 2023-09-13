using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JwtUser.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AppUserAdTo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ToId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToId",
                table: "Messages",
                column: "ToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ToId",
                table: "Messages",
                column: "ToId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ToId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToId",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "ToId",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
