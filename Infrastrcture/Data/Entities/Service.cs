using System.ComponentModel.DataAnnotations;
public class Service
{
    // writed by mhd
    [Key]
    public int Id { get; set; }
    public string Srvicename { get; set; }
    public int Parentid { get; set; }
    public string Status { get; set; }
    }