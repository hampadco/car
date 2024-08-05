using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastrcture.Migrations
{
    public partial class use : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "use",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "use",
                table: "Users");
        }
    }
}
