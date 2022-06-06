using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCTesting.Migrations
{
    public partial class Mod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestUser_Tests_TestsTestID",
                table: "TestUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TestUser_Users_UsersUserID",
                table: "TestUser");

            migrationBuilder.RenameColumn(
                name: "UsersUserID",
                table: "TestUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TestsTestID",
                table: "TestUser",
                newName: "TestId");

            migrationBuilder.RenameIndex(
                name: "IX_TestUser_UsersUserID",
                table: "TestUser",
                newName: "IX_TestUser_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestUser_Tests_TestId",
                table: "TestUser",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestUser_Users_UserId",
                table: "TestUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestUser_Tests_TestId",
                table: "TestUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TestUser_Users_UserId",
                table: "TestUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TestUser",
                newName: "UsersUserID");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "TestUser",
                newName: "TestsTestID");

            migrationBuilder.RenameIndex(
                name: "IX_TestUser_UserId",
                table: "TestUser",
                newName: "IX_TestUser_UsersUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_TestUser_Tests_TestsTestID",
                table: "TestUser",
                column: "TestsTestID",
                principalTable: "Tests",
                principalColumn: "TestID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestUser_Users_UsersUserID",
                table: "TestUser",
                column: "UsersUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
