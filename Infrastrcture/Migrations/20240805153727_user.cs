using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastrcture.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Mony",
                table: "Requests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mony",
                table: "Requests");
        }
    }
}
