using System.ComponentModel.DataAnnotations;

public class Request
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }

    public DateTime CreateDate { get; set; }

    public string Status { get; set; }
    public string CarName { get; set; }
    public string ParentServiceName { get; set; }
    public string Description { get; set; }
    
    
    
    
   
}