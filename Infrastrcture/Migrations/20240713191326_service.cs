using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastrcture.Migrations
{
    public partial class service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "blokSilandr",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "bolboring",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "boshSilandr",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "carbirator",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "charkhDande",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "compersorColer",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "fanar",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "fanarSopap",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "flayol",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "gearboxAuto",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "gearboxManual",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "headers",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "hozing",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "hydrolic",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "jabeFarman",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "karter",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "kaseCharkh",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "keshoie",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "komakfanar",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "manifold",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "milGarden",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "milMahak",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "milSopap",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "millang",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "motorKamel",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "motorStart",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "pichKarter",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "piston",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "plasticMotor",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "pumproghan",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "radiator",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "ring",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "ringPiston",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "safeCluch",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "sagDast",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "sarSilandr",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "sayerMotor",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "sayerZir",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "shafetKharoji",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "shafetVorodi",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "shaton",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "silandr",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "sopap",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "sopapPVC",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "superCharger",
                table: "Prices");

            migrationBuilder.RenameColumn(
                name: "waterPump",
                table: "Prices",
                newName: "PriceValue");

            migrationBuilder.RenameColumn(
                name: "turboCharger",
                table: "Prices",
                newName: "IdService");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Srvicename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parentid = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.RenameColumn(
                name: "PriceValue",
                table: "Prices",
                newName: "waterPump");

            migrationBuilder.RenameColumn(
                name: "IdService",
                table: "Prices",
                newName: "turboCharger");

            migrationBuilder.AddColumn<int>(
                name: "blokSilandr",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "bolboring",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "boshSilandr",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "carbirator",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "charkhDande",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "compersorColer",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fanar",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fanarSopap",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "flayol",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "gearboxAuto",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "gearboxManual",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "headers",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hozing",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hydrolic",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "jabeFarman",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "karter",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "kaseCharkh",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "keshoie",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "komakfanar",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "manifold",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "milGarden",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "milMahak",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "milSopap",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "millang",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "motorKamel",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "motorStart",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pichKarter",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "piston",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "plasticMotor",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pumproghan",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "radiator",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ring",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ringPiston",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "safeCluch",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sagDast",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sarSilandr",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sayerMotor",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sayerZir",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "shafetKharoji",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "shafetVorodi",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "shaton",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "silandr",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sopap",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sopapPVC",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "superCharger",
                table: "Prices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
