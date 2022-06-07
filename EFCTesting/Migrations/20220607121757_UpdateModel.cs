using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCTesting.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Progress",
                table: "Tests");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "TestUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Progress",
                table: "TestUser",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "TestUser");

            migrationBuilder.DropColumn(
                name: "Progress",
                table: "TestUser");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Progress",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
