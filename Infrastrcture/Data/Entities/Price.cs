using System.ComponentModel.DataAnnotations;
public class Price
{
    // writed by mhd
    [Key]
    public int Id { get; set; }
    public int carId { get; set; }


    // ghataat motor

    public int motorKamel { get; set; }
    public int blokSilandr { get; set; }
    public int silandr { get; set; }

    public int sarSilandr { get; set; }
    public int boshSilandr { get; set; }
    public int waterPump { get; set; }
    public int pichKarter { get; set; }
    public int karter { get; set; }
    public int millang { get; set; }
    public int ringPiston { get; set; }
    public int piston { get; set; }
    public int fanarSopap { get; set; }
    public int shaton { get; set; }
    public int flayol { get; set; }
    public int milSopap { get; set; }
    public int sopap { get; set; }
    public int sopapPVC { get; set; }
    public int motorStart { get; set; }
    public int superCharger { get; set; }
    public int turboCharger { get; set; }
    public int pumproghan { get; set; }
    public int manifold { get; set; }
    public int headers { get; set; }
    public int hydrolic { get; set; }
    public int compersorColer { get; set; }
    public int jabeFarman { get; set; }
    public int radiator { get; set; }
    public int carbirator { get; set; }
    public int ring { get; set; }
    public int sagDast { get; set; }
    public int kaseCharkh { get; set; }
    public int fanar { get; set; }
    public int komakfanar { get; set; }
    public int plasticMotor { get; set; }
    public int sayerMotor { get; set; }
    public int sayerZir { get; set; }



    // ghataat gearbox

    public int gearboxAuto { get; set; }
    public int gearboxManual { get; set; }
    public int safeCluch { get; set; }
    public int milMahak { get; set; }
    public int keshoie { get; set; }
    public int shafetVorodi { get; set; }
    public int shafetKharoji { get; set; }
    public int charkhDande { get; set; }
    public int bolboring { get; set; }
    public int hozing { get; set; }
    public int milGarden { get; set; }


}