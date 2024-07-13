using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastrcture.Migrations
{
    public partial class rrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carId = table.Column<int>(type: "int", nullable: false),
                    motorKamel = table.Column<int>(type: "int", nullable: false),
                    blokSilandr = table.Column<int>(type: "int", nullable: false),
                    silandr = table.Column<int>(type: "int", nullable: false),
                    sarSilandr = table.Column<int>(type: "int", nullable: false),
                    boshSilandr = table.Column<int>(type: "int", nullable: false),
                    waterPump = table.Column<int>(type: "int", nullable: false),
                    pichKarter = table.Column<int>(type: "int", nullable: false),
                    karter = table.Column<int>(type: "int", nullable: false),
                    millang = table.Column<int>(type: "int", nullable: false),
                    ringPiston = table.Column<int>(type: "int", nullable: false),
                    piston = table.Column<int>(type: "int", nullable: false),
                    fanarSopap = table.Column<int>(type: "int", nullable: false),
                    shaton = table.Column<int>(type: "int", nullable: false),
                    flayol = table.Column<int>(type: "int", nullable: false),
                    milSopap = table.Column<int>(type: "int", nullable: false),
                    sopap = table.Column<int>(type: "int", nullable: false),
                    sopapPVC = table.Column<int>(type: "int", nullable: false),
                    motorStart = table.Column<int>(type: "int", nullable: false),
                    superCharger = table.Column<int>(type: "int", nullable: false),
                    turboCharger = table.Column<int>(type: "int", nullable: false),
                    pumproghan = table.Column<int>(type: "int", nullable: false),
                    manifold = table.Column<int>(type: "int", nullable: false),
                    headers = table.Column<int>(type: "int", nullable: false),
                    hydrolic = table.Column<int>(type: "int", nullable: false),
                    compersorColer = table.Column<int>(type: "int", nullable: false),
                    jabeFarman = table.Column<int>(type: "int", nullable: false),
                    radiator = table.Column<int>(type: "int", nullable: false),
                    carbirator = table.Column<int>(type: "int", nullable: false),
                    ring = table.Column<int>(type: "int", nullable: false),
                    sagDast = table.Column<int>(type: "int", nullable: false),
                    kaseCharkh = table.Column<int>(type: "int", nullable: false),
                    fanar = table.Column<int>(type: "int", nullable: false),
                    komakfanar = table.Column<int>(type: "int", nullable: false),
                    plasticMotor = table.Column<int>(type: "int", nullable: false),
                    sayerMotor = table.Column<int>(type: "int", nullable: false),
                    sayerZir = table.Column<int>(type: "int", nullable: false),
                    gearboxAuto = table.Column<int>(type: "int", nullable: false),
                    gearboxManual = table.Column<int>(type: "int", nullable: false),
                    safeCluch = table.Column<int>(type: "int", nullable: false),
                    milMahak = table.Column<int>(type: "int", nullable: false),
                    keshoie = table.Column<int>(type: "int", nullable: false),
                    shafetVorodi = table.Column<int>(type: "int", nullable: false),
                    shafetKharoji = table.Column<int>(type: "int", nullable: false),
                    charkhDande = table.Column<int>(type: "int", nullable: false),
                    bolboring = table.Column<int>(type: "int", nullable: false),
                    hozing = table.Column<int>(type: "int", nullable: false),
                    milGarden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}
