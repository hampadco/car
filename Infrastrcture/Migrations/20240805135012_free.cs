using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastrcture.Migrations
{
    public partial class free : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "free",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "free",
                table: "Users");
        }
    }
}
