using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastrcture.Migrations
{
    public partial class lat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Users");
        }
    }
}
